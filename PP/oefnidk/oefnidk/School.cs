using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefnidk
{
    class School
    {
        private int geldHoeveelheid;

        public int GeldHoeveelheid
        {
            get { return geldHoeveelheid; }
            set
            {
                if (value <= 15)
                    geldHoeveelheid = 15;
                else geldHoeveelheid = value;
            }
        }

        public bool IsBijnaLeeg
        {
            get
            {
                if (GeldHoeveelheid >= 15)
                    return true;
                else
                    return false;
            }
        }

        public List<string> Leerlingen = new List<string>();

        public string Naam { get; set; } = "school90";

        public double GeefGeld()
        {
            return 0.0;
        }
    }
}
