using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Khizirov_Ismail
{
    class DVD : MuziekItem, IFysiek
    {
        public int AantalItems { get; }

        public DVD(string naam, int duur, int aantalItems) : base(naam, duur)
        {
            Inhoud = "DVD";
        }

        public override void ToonInfo()
        {
            if (AantalItems >= 2)
            {
                Console.WriteLine($"Dit item bevat {AantalItems} items.");
            }
        }


    }
}
