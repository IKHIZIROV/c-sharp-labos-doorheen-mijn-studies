using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class DHLSchip 
    {
        private List<Doos> vrachtRuim = new List<Doos>();

        public List<Doos> VrachtRuim
        {
            get { return vrachtRuim; }
            private set { vrachtRuim = value; }
        }

        public bool VoegDoosToe(Doos doos)
        {
            //Bereken gewicht
            int gewicht = BerekenGewicht();
            if (gewicht + doos.Gewicht > 10)
                throw new Exception("Te zwaar. Doos niet toegevoegd");
            else
                vrachtRuim.Add(doos);

            return true;
        }

        private int BerekenGewicht()
        {
            int gewicht = 0;
            foreach (var doos in vrachtRuim)
            {
                gewicht += doos.Gewicht;
            }

            return gewicht;
        }

        public string Naam { get; set; }

        public void ToonManifest()
        {
            Console.WriteLine(this.Naam);
            foreach (var doos in vrachtRuim)
            {
                Console.Write($"\n- {doos.Inhoud}\t{doos.Gewicht}\t{doos.KostPrijs}");
            }

            Console.WriteLine($"$TOTAAL GEWICHT\t\t{BerekenGewicht()}");
            Console.WriteLine($"$TOTAAL PRIJS\t\t{BerekenPrijs()}");
        }

        private int BerekenPrijs()
        {
            int prijs = 0;
            foreach (var doos in vrachtRuim)
            {
                prijs += doos.KostPrijs;
                if (doos is ISafe) prijs += 10;
            }
            return prijs;
        }

    }
}
