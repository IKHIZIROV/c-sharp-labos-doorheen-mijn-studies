using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Khizirov_Ismail
{
    class CD : MuziekItem, IFysiek
    {
        public int AantalItems { get { return 1; } }

        public CD(string naam, int duur) : base(naam, duur)
        {
            Inhoud = "CD";
        }
    }
}
