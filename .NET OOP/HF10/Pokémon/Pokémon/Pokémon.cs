using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon
{
    enum PokémonType { Grass, Poison, Fire, Ice, Water, Dragon, Fairy, Psychic, Dark, Ghost, Steel, Rock, Ground, Electric, Flying, Fighting, Bug, Normal}

    class Pokémon
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
        public string Name { get; set; } = "";

        public int Index { get; set; }

        public PokémonType Type { get; set; }

        // Level
        private int _Level;

        public int Level
        {
            get { return _Level; }
            private set { _Level = value; }
        }

        public void LevelUp()
        {
            Level++;
        }

        // Statistics
        public double Average
        {
            get { return (HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base) / 6.0; }
        }

        public int Total
        {
            get { return HP_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base; }
        }

        // Level-based stats
        public int HP_Full
        {
            get { return (((HP_Base + 50) * Level) / 50) + 10; }
        }

        public int Attack_Full
        {
            get { return ((Attack_Base * Level) / 50) + 5; }
        }

        public int Defence_Full
        {
            get { return ((Defence_Base * Level) / 50) + 5; }
        }

        public int SpecialAttack_Full
        {
            get { return ((SpecialAttack_Base * Level) / 50) + 5; }
        }

        public int SpecialDefence_Full
        {
            get { return ((SpecialDefence_Base * Level) / 50) + 5; }
        }

        public int Speed_Full
        {
            get { return ((Speed_Base * Level) / 50) + 5; }
        }
    }
}
