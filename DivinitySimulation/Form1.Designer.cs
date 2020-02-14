namespace DivinitySimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopAndLeastDamage1 = new System.Windows.Forms.Button();
            this.LeastCrits1 = new System.Windows.Forms.Button();
            this.MostCrits1 = new System.Windows.Forms.Button();
            this.LeastDamage1 = new System.Windows.Forms.Button();
            this.MostDamage1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(980, 600);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 675);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1278, 55);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(178, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 657);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Урон за пару ударов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Средний урон";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(970, 600);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // TopAndLeastDamage1
            // 
            this.TopAndLeastDamage1.Enabled = false;
            this.TopAndLeastDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopAndLeastDamage1.Location = new System.Drawing.Point(1176, 398);
            this.TopAndLeastDamage1.Name = "TopAndLeastDamage1";
            this.TopAndLeastDamage1.Size = new System.Drawing.Size(114, 85);
            this.TopAndLeastDamage1.TabIndex = 5;
            this.TopAndLeastDamage1.Text = "Top And Least Damage";
            this.TopAndLeastDamage1.UseVisualStyleBackColor = true;
            this.TopAndLeastDamage1.Click += new System.EventHandler(this.TopAndLeastDamage1_Click);
            // 
            // LeastCrits1
            // 
            this.LeastCrits1.Enabled = false;
            this.LeastCrits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeastCrits1.Location = new System.Drawing.Point(1176, 307);
            this.LeastCrits1.Name = "LeastCrits1";
            this.LeastCrits1.Size = new System.Drawing.Size(114, 85);
            this.LeastCrits1.TabIndex = 4;
            this.LeastCrits1.Text = "Top 10 Least Crits";
            this.LeastCrits1.UseVisualStyleBackColor = true;
            this.LeastCrits1.Click += new System.EventHandler(this.LeastCrits1_Click);
            // 
            // MostCrits1
            // 
            this.MostCrits1.Enabled = false;
            this.MostCrits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostCrits1.Location = new System.Drawing.Point(1176, 216);
            this.MostCrits1.Name = "MostCrits1";
            this.MostCrits1.Size = new System.Drawing.Size(114, 85);
            this.MostCrits1.TabIndex = 3;
            this.MostCrits1.Text = "Top 10 Most Crits";
            this.MostCrits1.UseVisualStyleBackColor = true;
            this.MostCrits1.Click += new System.EventHandler(this.MostCrits1_Click);
            // 
            // LeastDamage1
            // 
            this.LeastDamage1.Enabled = false;
            this.LeastDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeastDamage1.Location = new System.Drawing.Point(1176, 125);
            this.LeastDamage1.Name = "LeastDamage1";
            this.LeastDamage1.Size = new System.Drawing.Size(114, 85);
            this.LeastDamage1.TabIndex = 2;
            this.LeastDamage1.Text = "Top 10 Least Damage";
            this.LeastDamage1.UseVisualStyleBackColor = true;
            this.LeastDamage1.Click += new System.EventHandler(this.LeastDamage1_Click);
            // 
            // MostDamage1
            // 
            this.MostDamage1.Enabled = false;
            this.MostDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostDamage1.Location = new System.Drawing.Point(1176, 34);
            this.MostDamage1.Name = "MostDamage1";
            this.MostDamage1.Size = new System.Drawing.Size(114, 85);
            this.MostDamage1.TabIndex = 1;
            this.MostDamage1.Text = "Top 10 Most Damage";
            this.MostDamage1.UseVisualStyleBackColor = true;
            this.MostDamage1.Click += new System.EventHandler(this.MostDamage1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(9, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "16";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Урон жезлом 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Урон жезлом 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Доп. Интеллект";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Доп. Восприятие";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(9, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 31);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "16";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(9, 154);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 31);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(9, 216);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 31);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(9, 273);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 31);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Доп. Два Оружия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Доп Иск. Убийства";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(9, 334);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 31);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(9, 435);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 28);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Бережливость";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(9, 469);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 57);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Мастер на все руки";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Доп Шанс Крита";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(9, 398);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 31);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 739);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TopAndLeastDamage1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LeastCrits1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MostCrits1);
            this.Controls.Add(this.MostDamage1);
            this.Controls.Add(this.LeastDamage1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button TopAndLeastDamage1;
        private System.Windows.Forms.Button LeastCrits1;
        private System.Windows.Forms.Button MostCrits1;
        private System.Windows.Forms.Button LeastDamage1;
        private System.Windows.Forms.Button MostDamage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
    }
}

