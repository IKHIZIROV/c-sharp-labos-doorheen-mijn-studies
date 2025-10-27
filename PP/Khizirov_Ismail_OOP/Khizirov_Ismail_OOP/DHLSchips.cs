using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khizirov_Ismail_OOP
{
    class DHLSchips
    {
        string nameSchip = "The Exam-Failing Pegassus-Manifest";

        List<Doos> Vrachtruim = new List<Doos>();
        bool VoegDoosToe(Doos doos)
        {
            for (int i = 0; i < length; i++)
            {

            }

            Vrachtruim.Add(doos);
            return true;
        }

        void ToonManifest()
        {
            Console.WriteLine(nameSchip);
            Console.WriteLine("**************");
            Console.WriteLine("-Ijzer          5");
            Console.WriteLine("---------------");
            Console.WriteLine($"TOTAAL GEWICHT =          {gewichtAlleDozen}");
            int prijs = 0;

            for (int i = 0; i < Doos.Count; i++)
            {
                prijs++;
            }

            if (Doos = verzegeld)
            {
                prijs = 10;
            }
            else
            {
                prijs = KostPrijs + 10;
            }
            Console.WriteLine($"TOTAAL PRIJS =          {prijs}");
        }
    }
}
