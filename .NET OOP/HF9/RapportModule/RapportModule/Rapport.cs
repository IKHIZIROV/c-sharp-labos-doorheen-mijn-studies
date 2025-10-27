using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapportModule
{
    class Rapport
    {
        public int Percentage { get; set; }

        public void PrintGraad()
        {
            if (Percentage < 50)
                Console.WriteLine("Niet geslaagd");
            else if (Percentage <= 68)
                Console.WriteLine("Voldoende");
            else if (Percentage <= 75)
                Console.WriteLine("onderscheiding");
            else if (Percentage <= 85)
                Console.WriteLine("Grote onderschijding");
            else if (Percentage > 85)
                Console.WriteLine("Grootste onderscheiding");
        }
    }
}
