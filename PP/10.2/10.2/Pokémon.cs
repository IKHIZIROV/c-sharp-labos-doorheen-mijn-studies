using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    public class Pokémon
    {
        // Base stats

        private int _HP_Base;
        public int HP_Base
        {
            get { return _HP_Base; }
            set { _HP_Base = value; }
        }

        private int _Attack_Base;
        public int Attack_Base
        {
            get { return _Attack_Base; }
            set { _Attack_Base = value; }
        }

        private int _Defence_Base;
        public int Defence_Base
        {
            get { return _Defence_Base; }
            set { _Defence_Base = value; }
        }

        private int _SpecialAttack_Base;
        public int SpecialAttack_Base
        {
            get { return _SpecialAttack_Base; }
            set { _SpecialAttack_Base = value; }
        }

        private int _SpecialDefence_Base;
        public int SpecialDefence_Base
        {
            get { return _SpecialDefence_Base; }
            set { _SpecialDefence_Base = value; }
        }

        private int _Speed_Base;
        public int Speed_Base
        {
            get { return _Speed_Base; }
            set { _Speed_Base = value; }
        }


        // Extra stats

        public string Naam { get; set; }

        public string Type { get; set; }

        public int Nummer { get; set; }


        // Level

        private int _Level;
        public int Level
        {
            get { return _Level; }
            private set { _Level = value; }
        }

        public void VerhoogLevel()
        {
            Level++;
        }


        // Statistieken

        public int Total
        {
            get
            {
                return (HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base);
            }
        }

        public double Average
        {
            get
            {
                return (Total / 6.0);
            }
        }


        // Level-gebaseerde stats

        public int HP_Full
        {
            get
            {
                return (((HP_Base + 50) * Level) / 50) + 10;
            }
        }

        public int Attack_Full
        {
            get
            {
                return (((Attack_Base + 50) * Level) / 50) + 5;
            }
        }

        public int Defence_Full
        {
            get
            {
                return (((Defence_Base + 50) * Level) / 50) + 5;
            }
        }

        public int SpecialAttack_Full
        {
            get
            {
                return (((SpecialAttack_Base + 50) * Level) / 50) + 5;
            }
        }

        public int SpecialDefence_Full
        {
            get
            {
                return (((SpecialDefence_Base + 50) * Level) / 50) + 5;
            }
        }

        public int Speed_Full
        {
            get
            {
                return (((Speed_Base + 50) * Level) / 50) + 5;
            }
        }


        // Pokémontester

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine(Naam + $" (level {Level})");
            Console.WriteLine();
            Console.WriteLine("Base stats:");
            Console.WriteLine("   * Health = " + HP_Base);
            Console.WriteLine("   * Attack = " + Attack_Base);
            Console.WriteLine("   * Defence = " + Defence_Base);
            Console.WriteLine("   * Special Attack = " + SpecialAttack_Base);
            Console.WriteLine("   * Special Defence = " + SpecialDefence_Base);
            Console.WriteLine("   * Speed = " + Speed_Base);
            Console.WriteLine();
            Console.WriteLine("Full stats:");
            Console.WriteLine("   * Health = " + HP_Full);
            Console.WriteLine("   * Attack = " + Attack_Full);
            Console.WriteLine("   * Defence = " + Defence_Full);
            Console.WriteLine("   * Special Attack = " + SpecialAttack_Full);
            Console.WriteLine("   * Special Defence = " + SpecialDefence_Full);
            Console.WriteLine("   * Speed = " + Speed_Full);
        }
    }
}
