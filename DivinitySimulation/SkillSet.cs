using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivinitySimulation
{
    public class SkillSet
    {
        public int Id { get; set; } = 0;
        public int Intelligence { get; private set; } = 0;
        public int Perception { get; private set; } = 0;
        public double IntelligenceDamageIncrease { get; private set; } = 0;

        public int Polymorph { get; private set; } = 0;
        public int KillingArt { get; private set; } = 0;
        public int TwoHands { get; private set; } = 0;
        public double TwoHandsDamageIncrease { get; private set; } = 0;

        public int CritChance { get; private set; } = 0;
        public double CritMultiplier { get; private set; } = 1.60;

        public int BasicPoints { get; set; }
        public int BasicSkillPoints { get; set; }


        public int AverageDamage { get; set; }
        public int CritCount { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public List<int> Damage = new List<int>();

        public SkillSet(int id, int basicPoints, int basicSkillPoints)
        {
            Id = id;
            BasicPoints = basicPoints;
            BasicSkillPoints = basicSkillPoints;
        }

        public override string ToString()
        {
            return $"i{Intelligence}p{Perception}P{Polymorph}K{KillingArt}T{TwoHands}".ToString();
        }

        public string GetInfo()
        {
            return $"Интеллект {Intelligence}\r\n" +
                   $"Восприятие {Perception}\r\n" +
                   $"Превращение {Polymorph}\r\n" +
                   $"Искусство убийства {KillingArt}\r\n" +
                   $"Два оружия {TwoHands}";
        }

        public bool Compare(SkillSet obj)
        {
            return obj.ToString().Equals(ToString());
        }

        public bool AddPolymorph()
        {
            if (BasicSkillPoints == 0 || Polymorph == 10)
            {
                return false;
            }
            BasicSkillPoints--;

            Polymorph++;
            BasicPoints++;

            return true;
        }

        public bool AddKillingArt()
        {
            if (BasicSkillPoints == 0 || KillingArt == 10)
            {
                return false;
            }
            BasicSkillPoints--;

            KillingArt++;
            CritMultiplier += 0.05;

            return true;
        }

        public bool AddTwoHands()
        {
            if (BasicSkillPoints == 0 || TwoHands == 10)
            {
                return false;
            }
            BasicSkillPoints--;

            TwoHands++;
            TwoHandsDamageIncrease += 0.05;

            return true;
        }

        public bool AddIntelligence()
        {
            if (BasicPoints == 0)
            {
                return false;
            }
            BasicPoints--;

            Intelligence++;
            IntelligenceDamageIncrease += 0.05;

            return true;
        }

        public bool AddPerception()
        {
            if (BasicPoints == 0)
            {
                return false;
            }

            BasicPoints--;

            Perception++;
            CritChance += 1;

            return true;
        }


        public int EnhanceDamage(int damage)
        {
            return damage + (int)(damage * Intelligence * 0.05) + (int)(damage * TwoHands * 0.05);
        }
    }
}

