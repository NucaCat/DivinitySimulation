using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DivinitySimulation
{
    public partial class Form1 : Form
    {
        private int _hitCount = 1000;

        private int _level = 10;

        private bool _handyMan = true;
        private bool _resourcefulness = true;


        private int _testNumber = 0;
        private int _maxTestCount = 5000;
        private int _maxIterationCount = 5000;

        private int _wand1Damage = 16;
        private int _wand2Damage = 8;

        private int _additionalIntelligence = 0;
        private int _additionalPerception = 0;

        private int _additionalTwoHanded = 0;
        private int _additionalKillingArt = 0;

        private int _additionalCritChance;

        private int _numberOfCores = Environment.ProcessorCount;
        private int _basicPoints;
        private int _basicSkillPoints;

        private List<SkillSet> _skillSets = new List<SkillSet>();

        Random r = new Random();
        private void AddRandomBasic(SkillSet skillSet)
        {
            if (r.Next(1, 3) == 1)
            {
                if (skillSet.AddIntelligence() == false)
                {
                    skillSet.AddPerception();
                }
            }
            else
            {
                if (skillSet.AddPerception() == false)
                {
                    skillSet.AddIntelligence();
                }
            }
        }

        public void AddRandomBasicSkill(SkillSet skillSet)
        {
            var x = r.Next(1, 4);
            for (; ; )
            {
                switch (x)
                {
                    case 1:
                        if (skillSet.AddKillingArt() == false)
                        {
                            x = r.Next(2, 4);
                            continue;
                        }
                        return;
                    case 2:
                        if (skillSet.AddPolymorph() == false)
                        {
                            x = r.Next(0, 2);
                            if (x == 0)
                            {
                                x = 1;
                            }
                            else
                            {
                                x = 3;
                            }
                            continue;
                        }
                        return;
                    case 3:
                        if (skillSet.AddTwoHands() == false)
                        {
                            x = r.Next(1, 3);
                            continue;
                        }
                        return;
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private async Task Start()
        {
            DialogResult responce;
            if (File.Exists(Environment.CurrentDirectory + "//SkillSets.txt") == false)
            {
                responce = DialogResult.No;
            }
            else
            {
                responce = MessageBox.Show("Прочитать данные из файла?", "", MessageBoxButtons.YesNo);
            }
            _basicPoints = _level * 2 + 1 + (_handyMan ? 2 : 0);
            _basicSkillPoints = _level + 1 + (_resourcefulness ? 1 : 0);


            var timeStamp = DateTime.Now;
            if (responce == DialogResult.No)
            {
                progressBar1.Maximum = _maxTestCount;

                for (; _testNumber != _maxTestCount; _testNumber++)
                {
                    if ((await Task.Run(AddUniqueSkillSet)) == false)
                    {
                        progressBar1.Value = progressBar1.Maximum;
                        break;
                    }
                    progressBar1.Value = _testNumber;
                }

                SkillSet.AdditionalKillingArt = _additionalKillingArt;
                SkillSet.AdditionalTwoHands = _additionalTwoHanded;
                SkillSet.AdditionalIntelligence = _additionalIntelligence;
                SkillSet.AdditionalPerception = _additionalPerception;
                SkillSet.AdditionalCritChance = _additionalCritChance;

                foreach (var skillSet in _skillSets)
                {
                    skillSet.ApplyModifiers();
                }
            }
            else
            {
                using StreamReader sr = new StreamReader(Environment.CurrentDirectory + "//SkillSets.txt");
                while (sr.Peek() >= 0)
                {
                    var x = sr.ReadLine();
                    if (x.IndexOf("int") - x.IndexOf("id") - "id".Length <= 0)
                    {
                        //TODO read additional params
                        var str = sr.ReadToEnd();
                        Int32.TryParse(str.Substring(str.IndexOf("int") + "int".Length, 3).Trim(), out _additionalIntelligence);
                        Int32.TryParse(str.Substring(str.IndexOf("perc") + "perc".Length, 3).Trim(), out _additionalPerception);
                        Int32.TryParse(str.Substring(str.IndexOf("twoHanded") + "twoHanded".Length, 3).Trim(), out _additionalTwoHanded);
                        Int32.TryParse(str.Substring(str.IndexOf("killing") + "killing".Length, 3).Trim(), out _additionalKillingArt);
                        Int32.TryParse(str.Substring(str.IndexOf("wand1Damage") + "wand1Damage".Length, 3).Trim(), out _wand1Damage);
                        Int32.TryParse(str.Substring(str.IndexOf("wand2Damage") + "wand2Damage".Length, 3).Trim(), out _wand2Damage);
                        Int32.TryParse(str.Substring(str.IndexOf("critChance") + "critChance".Length, 3).Trim(), out _additionalCritChance);
                        Int32.TryParse(str.Substring(str.IndexOf("handyman") + "handyman".Length, 3).Trim(), out var handyman);
                        Int32.TryParse(str.Substring(str.IndexOf("resourcefullness") + "resourcefullness".Length, 3).Trim(), out var resourcefullness);
                        /*MessageBox.Show($"{_additionalIntelligence}\r\n" +
                                        $"{_additionalPerception}\r\n" +
                                        $"{_additionalTwoHanded}\r\n" +
                                        $"{_additionalKillingArt}\r\n" +
                                        $"{_wand1Damage}\r\n" +
                                        $"{_wand2Damage}");*/


                        SkillSet.AdditionalKillingArt = _additionalKillingArt;
                        SkillSet.AdditionalTwoHands = _additionalTwoHanded;
                        SkillSet.AdditionalIntelligence = _additionalIntelligence;
                        SkillSet.AdditionalPerception = _additionalPerception;
                        SkillSet.AdditionalCritChance = _additionalCritChance;


                        textBox1.Text = _wand1Damage.ToString();
                        textBox2.Text = _wand2Damage.ToString();

                        textBox3.Text = _additionalIntelligence.ToString();
                        textBox4.Text = _additionalPerception.ToString();

                        textBox5.Text = _additionalTwoHanded.ToString();
                        textBox6.Text = _additionalKillingArt.ToString();

                        textBox7.Text = _additionalCritChance.ToString();

                        checkBox1.Checked = resourcefullness == 1;
                        checkBox2.Checked = handyman == 1;
                        break;
                    }
                    int.TryParse(x.Substring(x.IndexOf("id") + "id".Length,
                        x.IndexOf("int") - x.IndexOf("id") - "id".Length).Trim(), out var id);

                    int.TryParse(x.Substring(x.IndexOf("int") + "int".Length,
                        x.IndexOf("perc") - x.IndexOf("int") - "int".Length).Trim(), out var intelligence);

                    int.TryParse(x.Substring(x.IndexOf("perc") + "perc".Length,
                        x.IndexOf("twoHanded") - x.IndexOf("perc") - "perc".Length).Trim(), out var perception);

                    int.TryParse(x.Substring(x.IndexOf("twoHanded") + "twoHanded".Length,
                        x.IndexOf("poly") - x.IndexOf("twoHanded") - "twoHanded".Length).Trim(), out var twoHanded);

                    int.TryParse(x.Substring(x.IndexOf("poly") + "poly".Length,
                        x.IndexOf("killing") - x.IndexOf("poly") - "poly".Length).Trim(), out var poly);

                    int.TryParse(x.Substring(x.IndexOf("killing") + "killing".Length,
                        x.Length - x.IndexOf("killing") - "killing".Length).Trim(), out var killing);

                    SkillSet skillSet = new SkillSet(id, _basicPoints, _basicSkillPoints);

                    for (int i = 0; i < poly; i++)
                    {
                        skillSet.AddPolymorph();
                    }
                    for (int i = 0; i < killing; i++)
                    {
                        skillSet.AddKillingArt();
                    }
                    for (int i = 0; i < twoHanded; i++)
                    {
                        skillSet.AddTwoHands();
                    }
                    for (int i = 0; i < perception; i++)
                    {
                        skillSet.AddPerception();
                    }
                    for (int i = 0; i < intelligence; i++)
                    {
                        skillSet.AddIntelligence();
                    }
                    //MessageBox.Show(skillSet.ToString());
                    _skillSets.Add(skillSet);
                }
                foreach (var skillSet in _skillSets)
                {
                    skillSet.ApplyModifiers();
                }
            }
            var timeElapsed = (DateTime.Now - timeStamp).Seconds;

            int skillsetNumber = 0;

            progressBar1.Value = 0;
            progressBar1.Maximum = _skillSets.Count;

            foreach (var skillSet in _skillSets)
            {
                progressBar1.Value = await Task.Run(() =>
                {
                    //int averageDamage = 0;
                    for (int i = 0; i < _hitCount; i++)
                    {
                        var wand1Damage = skillSet.EnhanceDamage(_wand1Damage);
                        var wand2Damage = skillSet.EnhanceDamage(_wand2Damage);
                        if (r.Next(1, 101) <= skillSet.CritChance)
                        {
                            skillSet.CritCount++;
                            wand1Damage = (int)(wand1Damage * skillSet.CritMultiplier);
                        }
                        if (r.Next(1, 101) <= skillSet.CritChance)
                        {
                            skillSet.CritCount++;
                            wand2Damage = (int)(wand2Damage * skillSet.CritMultiplier);
                        }
                        var damage = wand1Damage + wand2Damage;
                        skillSet.AverageDamage += damage;
                        skillSet.Damage.Add(damage);

                        //chart1.Series[skillSet.Id.ToString()].Points.AddXY(i, damage);
                    }

                    skillSet.AverageDamage /= _hitCount;
                    skillSet.MinDamage = skillSet.Damage.Min();
                    skillSet.MaxDamage = skillSet.Damage.Max();

                    Console.WriteLine(skillSet.AverageDamage + "\r\n");

                    skillsetNumber++;
                    return skillsetNumber;
                });
            }

            foreach (var button in Controls.OfType<Button>())
            {
                button.Enabled = true;
            }

            button1.Enabled = false;

            if (responce == DialogResult.No)
            {
                using StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//SkillSets.txt");
                foreach (var skillSet in _skillSets)
                {
                    sw.Write($"id {skillSet.Id} " +
                             $"int {skillSet.Intelligence} " +
                             $"perc {skillSet.Perception} " +
                             $"twoHanded {skillSet.TwoHands} " +
                             $"poly {skillSet.Polymorph} " +
                             $"killing {skillSet.KillingArt}\r\n");
                }
                sw.Write($"Количество сетов = {_skillSets.Count} \r\n" +
                         $"Поиск сетов завершен за {timeElapsed} секунд\r\n");
                sw.Write($"Дополнительные параметры: \r\n" +
                         $"int {SkillSet.AdditionalIntelligence} \r\n" +
                         $"perc {SkillSet.AdditionalPerception} \r\n" +
                         $"twoHanded {SkillSet.AdditionalTwoHands} \r\n" +
                         $"killing {SkillSet.AdditionalKillingArt} \r\n" +
                         $"critChance {SkillSet.AdditionalCritChance} \r\n" +
                         $"wand1Damage {_wand1Damage} \r\n" +
                         $"wand2Damage {_wand2Damage * 2} \r\n");
                if (_handyMan == true)
                {
                    sw.Write($"handyMan 1 \r\n");
                }
                else
                {
                    sw.Write($"handyMan 0 \r\n");
                }

                if (_resourcefulness == true)
                {
                    sw.Write($"resourcefulness 1 \r\n");
                }
                else
                {
                    sw.Write($"resourcefulness 0 \r\n");
                }
            }
        }

        /// <summary>
        /// Returns false if unique SkillSet cannot be created
        /// </summary>
        /// <returns></returns>
        private bool AddUniqueSkillSet()
        {
            for (int iteration = 0; iteration != _maxIterationCount; iteration++)
            {
                SkillSet skillSet = new SkillSet(_testNumber, _basicPoints, _basicSkillPoints);
                while (skillSet.BasicSkillPoints != 0)
                {
                    AddRandomBasicSkill(skillSet);
                }

                while (skillSet.BasicPoints != 0)
                {
                    AddRandomBasic(skillSet);
                }

                if (CheckSkillSet(skillSet) == true)
                {
                    _skillSets.Add(skillSet);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns true if skill set is unique
        /// </summary>
        /// <param name="skillSet">Skillset to be checked</param>
        /// <returns></returns>
        private bool CheckSkillSet(SkillSet skillSet)
        {
            foreach (var x in _skillSets)
            {
                if (x.Compare(skillSet))
                {
                    return false;
                }
            }

            return true;
        }

        private void AddToChart(IOrderedEnumerable<SkillSet> sorted, Chart chart)
        {
            chart.Series.Clear();

            int count = 0;
            foreach (var x in sorted)
            {
                if (count == 10)
                {
                    return;
                }
                int i = 0;
                chart.Series.Add(x.GetInfo(true));
                chart.Series[x.GetInfo(true)].ChartType = SeriesChartType.Line;

                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = x.Damage.Count;

                foreach (var damage in x.Damage)
                {
                    chart.Series[x.GetInfo(true)].Points.AddXY(i, damage);
                    i++;
                }

                count++;
            }
        }

        private void AddToAvgChart(IOrderedEnumerable<SkillSet> sorted, Chart chart)
        {
            chart.Series.Clear();

            int i = 0;

            var averageDamageList = new List<int>();
            foreach (var x in sorted)
            {
                averageDamageList.Add(x.AverageDamage);

                if (i == 10)
                {
                    return;
                }

                chart.Series.Add(x.GetInfo(true));
                chart.Series[x.GetInfo(true)].ChartType = SeriesChartType.Line;
                chart.Series[x.GetInfo(true)].BorderWidth = 5;

                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = x.Damage.Count;

                chart.Series[x.GetInfo(true)].Points.AddXY(0, x.AverageDamage);
                chart.Series[x.GetInfo(true)].Points.AddXY(x.Damage.Count, x.AverageDamage);

                i++;
            }
            chart.ChartAreas[0].AxisY.Minimum = averageDamageList.Min() - averageDamageList.Min() * 0.1;
            chart.ChartAreas[0].AxisY.Maximum = averageDamageList.Max() + averageDamageList.Max() * 0.1;
        }

        private void WriteToFile10(IOrderedEnumerable<SkillSet> sorted, string title, string fileName)
        {
            if (fileName.IndexOf('.') == -1)
            {
                fileName += ".txt";
            }
            using StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//" + fileName);
            sw.Write(title + ":\r\n");
            sw.Write($"Дополнительные параметры: \r\n" +
                     $"Интеллект {SkillSet.AdditionalIntelligence} \r\n" +
                     $"Восприятие {SkillSet.AdditionalPerception} \r\n" +
                     $"Два оружия {SkillSet.AdditionalTwoHands} \r\n" +
                     $"Искусство убийства {SkillSet.AdditionalKillingArt}\r\n" +
                     $"Шанс крита {SkillSet.AdditionalCritChance}\r\n" +
                     $"Урон первым жезлом {_wand1Damage} \r\n" +
                     $"Урон вторым жезлом {_wand2Damage * 2} ({_wand2Damage}) \r\n" +
                     $"Бережливость {_resourcefulness} \r\n" +
                     $"Мастер на все руки {_handyMan} \r\n");
            int i = 1;
            foreach (var skillSet in sorted)
            {
                if (i == 10)
                {
                    return;
                }
                sw.Write("Статы: \r\n" + skillSet.GetInfo(true) + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("Средний урон: " + skillSet.AverageDamage + "\r\n");
                sw.Write("Минимальный урон: " + skillSet.MinDamage + "\r\n");
                sw.Write("Максимальный урон: " + skillSet.MaxDamage + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("Количество критов: " + skillSet.CritCount + "\r\n");
                sw.Write("Шанс крита: " + skillSet.CritChance + " (" + SkillSet.AdditionalCritChance + ")\r\n");
                sw.Write("Множитель критов: " + skillSet.CritMultiplier + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("---------------------------------------------\r\n");
                i++;
            }
        }

        private void MostDamage1_Click(object sender, EventArgs e)
        {
            var sorted = _skillSets.OrderByDescending(skillSet => skillSet.AverageDamage);
            AddToChart(sorted, chart1);
            AddToAvgChart(sorted, chart2);
            WriteToFile10(sorted, "Наибольший урон", "MostDamage");
            if (isWritedSorted == false)
            {
                WriteSorted(sorted);
                isWritedSorted = true;
            }
        }

        private void LeastDamage1_Click(object sender, EventArgs e)
        {
            var sorted = _skillSets.OrderBy(skillSet => skillSet.AverageDamage);
            AddToChart(sorted, chart1);
            AddToAvgChart(sorted, chart2);
            WriteToFile10(sorted, "Наименьший урон", "LeastDamage");
            if (isWritedSorted == false)
            {
                WriteSorted(sorted);
                isWritedSorted = true;
            }
        }

        private void MostCrits1_Click(object sender, EventArgs e)
        {
            var sorted = _skillSets.OrderByDescending(skillSet => skillSet.CritCount);
            AddToChart(sorted, chart1);
            AddToAvgChart(sorted, chart2);
            WriteToFile10(sorted, "Наибольшее количество критов", "MostCrits");
            if (isWritedSorted == false)
            {
                WriteSorted(sorted);
                isWritedSorted = true;
            }
        }

        private void LeastCrits1_Click(object sender, EventArgs e)
        {
            var sorted = _skillSets.OrderBy(skillSet => skillSet.CritCount);
            AddToChart(sorted, chart1);
            AddToAvgChart(sorted, chart2);
            WriteToFile10(sorted, "Наименьшее количество критов", "LeastCrits");
            if (isWritedSorted == false)
            {
                WriteSorted(sorted);
                isWritedSorted = true;
            }
        }

        private void TopAndLeastDamage1_Click(object sender, EventArgs e)
        {
            var sorted = _skillSets.OrderBy(skillSet => skillSet.AverageDamage).ToArray();
            chart1.Series.Clear();
            chart2.Series.Clear();


            chart2.ChartAreas[0].AxisY.Minimum = sorted[0].AverageDamage - sorted[0].AverageDamage * 0.1;

            chart2.ChartAreas[0].AxisY.Maximum = sorted[sorted.Length - 1].AverageDamage 
                                                 + sorted[sorted.Length - 1].AverageDamage * 0.1;


            int i = 0;
            chart1.Series.Add(sorted[0].GetInfo(true));
            chart1.Series[sorted[0].GetInfo(true)].ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = sorted[0].Damage.Count;

            chart2.Series.Add(sorted[0].GetInfo(true));
            chart2.Series[sorted[0].GetInfo(true)].ChartType = SeriesChartType.Line;
            chart2.Series[sorted[0].GetInfo(true)].BorderWidth = 5;

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = sorted[0].Damage.Count;

            foreach (var damage in sorted[0].Damage)
            {
                chart1.Series[sorted[0].GetInfo(true)].Points.AddXY(i, damage);
                i++;
            }
            chart2.Series[sorted[0].GetInfo(true)].Points.AddXY(0, sorted[0].AverageDamage);
            chart2.Series[sorted[0].GetInfo(true)].Points.AddXY(sorted.Length, sorted[0].AverageDamage);

            i = 0;
            chart1.Series.Add(sorted[sorted.Length - 1].GetInfo(true));
            chart1.Series[sorted[sorted.Length - 1].GetInfo(true)].ChartType = SeriesChartType.Line;

            chart2.Series.Add(sorted[sorted.Length - 1].GetInfo(true));
            chart2.Series[sorted[sorted.Length - 1].GetInfo(true)].ChartType = SeriesChartType.Line;
            chart2.Series[sorted[sorted.Length - 1].GetInfo(true)].BorderWidth = 5;

            foreach (var damage in sorted[sorted.Length - 1].Damage)
            {
                chart1.Series[sorted[sorted.Length - 1].GetInfo(true)].Points.AddXY(i, damage);
                i++;
            }
            chart2.Series[sorted[sorted.Length - 1].GetInfo(true)].Points
                .AddXY(0, sorted[sorted.Length - 1].AverageDamage);

            chart2.Series[sorted[sorted.Length - 1].GetInfo(true)].Points
                .AddXY(sorted.Length, sorted[sorted.Length - 1].AverageDamage);

            using StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//TopAndLeastDamage.txt");
            sw.Write("Наибольший урон и наименьший урон:\r\n");
            sw.Write($"Дополнительные параметры: \r\n" +
                     $"Интеллект {SkillSet.AdditionalIntelligence} \r\n" +
                     $"Восприятие {SkillSet.AdditionalPerception} \r\n" +
                     $"Два оружия {SkillSet.AdditionalTwoHands} \r\n" +
                     $"Искусство убийства {SkillSet.AdditionalKillingArt}\r\n" +
                     $"Шанс крита {SkillSet.AdditionalCritChance}\r\n" +
                     $"Урон первым жезлом {_wand1Damage} \r\n" +
                     $"Урон вторым жезлом {_wand2Damage * 2} ({_wand2Damage}) \r\n");

            sw.Write("Статы: \r\n" + sorted[0].GetInfo(true) + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("Средний урон: " + sorted[0].AverageDamage + "\r\n");
            sw.Write("Минимальный урон: " + sorted[0].MinDamage + "\r\n");
            sw.Write("Максимальный урон: " + sorted[0].MaxDamage + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("Количество критов: " + sorted[0].CritCount + "\r\n");
            sw.Write("Шанс крита: " + sorted[0].CritChance + " (" + SkillSet.AdditionalCritChance + ")\r\n");
            sw.Write("Множитель критов: " + sorted[0].CritMultiplier + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("---------------------------------------------\r\n");

            sw.Write("Статы: " + sorted[sorted.Length - 1].GetInfo(true) + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("Средний урон: " + sorted[sorted.Length - 1].AverageDamage + "\r\n");
            sw.Write("Минимальный урон: " + sorted[sorted.Length - 1].MinDamage + "\r\n");
            sw.Write("Максимальный урон: " + sorted[sorted.Length - 1].MaxDamage + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("Количество критов: " + sorted[sorted.Length - 1].CritCount + "\r\n");
            sw.Write("Шанс крита: " + sorted[sorted.Length - 1].CritChance + " (" + SkillSet.AdditionalCritChance + ")\r\n");
            sw.Write("Множитель критов: " + sorted[sorted.Length - 1].CritMultiplier + "\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("---------------------------------------------\r\n");
            sw.Write("---------------------------------------------\r\n");
        }

        private bool isWritedSorted = false;

        private void WriteSorted(IOrderedEnumerable<SkillSet> sorted)
        {
            using StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "//SortedSkillSets.txt");
            sw.Write($"Дополнительные параметры: \r\n" +
                     $"Интеллект {SkillSet.AdditionalIntelligence} \r\n" +
                     $"Восприятие {SkillSet.AdditionalPerception} \r\n" +
                     $"Два оружия {SkillSet.AdditionalTwoHands} \r\n" +
                     $"Искусство убийства {SkillSet.AdditionalKillingArt}\r\n" +
                     $"Шанс крита {SkillSet.AdditionalCritChance}\r\n" +
                     $"Урон первым жезлом {_wand1Damage} \r\n" +
                     $"Урон вторым жезлом {_wand2Damage * 2} ({_wand2Damage}) \r\n" +
                     $"Бережливость {_resourcefulness} \r\n" +
                     $"Мастер на все руки {_handyMan} \r\n");
            foreach (var skillSet in sorted)
            {
                sw.Write("Статы: \r\n" + skillSet.GetInfo(true) + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("Средний урон: " + skillSet.AverageDamage + "\r\n");
                sw.Write("Минимальный урон: " + skillSet.MinDamage + "\r\n");
                sw.Write("Максимальный урон: " + skillSet.MaxDamage + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("Количество критов: " + skillSet.CritCount + "\r\n");
                sw.Write("Шанс крита: " + skillSet.CritChance + " (" + SkillSet.AdditionalCritChance + ")\r\n");
                sw.Write("Множитель критов: " + skillSet.CritMultiplier + "\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("---------------------------------------------\r\n");
                sw.Write("---------------------------------------------\r\n");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.Enabled = false;
            }

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;

            string errorMessage = "";
            if (Int32.TryParse(textBox1.Text, out var wand1Damage) == false)
            {
                errorMessage += "Не введено значение урона жезла 1\r\n";
            }
            if (Int32.TryParse(textBox2.Text, out var wand2Damage) == false)
            {
                errorMessage += "Не введено значение урона жезла 2\r\n";
            }
            if (Int32.TryParse(textBox3.Text, out var intModifier) == false)
            {
                errorMessage += "Не введено значение дополнительного интеллекта\r\n";
            }
            if (Int32.TryParse(textBox4.Text, out var percModifier) == false)
            {
                errorMessage += "Не введено значение дополнительного восприятия\r\n";
            }
            if (Int32.TryParse(textBox5.Text, out var twoHandsModifier) == false)
            {
                errorMessage += "Не введено значение двух оружий\r\n";
            }
            if (Int32.TryParse(textBox6.Text, out var killingModifier) == false)
            {
                errorMessage += "Не введено значение дополнительного искусства убийства\r\n";
            }
            if (Int32.TryParse(textBox7.Text, out var CritChanceModifier) == false)
            {
                errorMessage += "Не введено значение шанса крита\r\n";
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            _wand1Damage = wand1Damage;
            _wand2Damage = wand2Damage / 2;

            _additionalIntelligence = intModifier;
            _additionalPerception = percModifier;

            _additionalTwoHanded = twoHandsModifier;
            _additionalKillingArt = killingModifier;

            _resourcefulness = checkBox1.Checked;
            _handyMan = checkBox2.Checked;

            _additionalCritChance = CritChanceModifier;

            await Start();
        }
    }
}
