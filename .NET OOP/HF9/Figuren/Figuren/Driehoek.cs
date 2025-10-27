using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    public class Driehoek
    {
        private int basis;
        public int Basis
        {
            get { return basis; }
            set { basis = value; }
        }
        private int hoogte;
        public int Hoogte
        {
            get { return hoogte; }
            set { hoogte = value; }
        }

        public void ToonOppervlakte()
        {
            int oppervlakte =(basis * hoogte) / 2;
            Console.WriteLine($"Oppervlakte: {oppervlakte}");
        }
    }
}
