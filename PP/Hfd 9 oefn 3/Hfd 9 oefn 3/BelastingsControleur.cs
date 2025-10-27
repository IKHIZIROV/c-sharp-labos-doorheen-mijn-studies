using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hfd_9_oefn_3
{
    internal class BelastingsControleur
    {
        private int aantalBerekeningen = 0;

        public int berekenBelastingen(int inkomen)
        {
            aantalBerekeningen++;
            if (aantalBerekeningen < 5)
                return Doeberekening(inkomen, 0.21);

            return Doeberekening(inkomen, 0.31);
        }

        private int Doeberekening(int getal, double percentage)
        {
            return (int)(getal * percentage);
        }
    }
}
