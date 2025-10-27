using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    class Vak
    {
        public string Titel { get; set; } = "Onbekend";

        private int duur;

        public int Duur
        {
            get { return duur; }
            set { if (value == 1 || value == 2) duur = value; }
        }

        // public Lector Lector { get; set; }

        public override string ToString()
        {
            return $"{Titel} - Lector - Vak -  ";
        }
    }
}
