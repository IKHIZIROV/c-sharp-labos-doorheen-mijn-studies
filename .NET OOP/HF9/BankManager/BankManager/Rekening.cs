using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    enum RekeningStaat { Geldig, Geblokkeerd}
    class Rekening
    {
        private int balans = 1000;
        public int Balans
        {
            get { return balans; }
        }
        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }
        public RekeningStaat Staat { get; set; }

        public int HaalGeldAf(int aantal)
        {
            if (Staat == RekeningStaat.Geblokkeerd)
            {
                Console.WriteLine("Kan niet, rekening geblokkeerd!");
            }
            else {
                if (aantal < balans)
                {
                    balans = balans - aantal;
                    Console.WriteLine($"U hebt {aantal} EUR afgehaald");
                    Console.WriteLine($"Uw nieuwe balans: {Balans} EUR");
                    Console.WriteLine("");
                    return aantal;
                }
                else if (aantal >= balans)
                {
                    Console.WriteLine($"U balans is niet genoeg om {aantal} EUR af te halen");
                    Console.WriteLine($"Er werd {Balans} EUR afgehaald in plaats van {aantal} EUR");
                    balans = 0;
                    Console.WriteLine($"Uw balans is nu {balans} EUR");
                    Console.WriteLine("");
                    VeranderStaat();
                    return balans;
                } 
            }
        return 0;
        }
        public void StortGeld(int aantal)
        {
            if (Staat == RekeningStaat.Geblokkeerd)
            {
                Console.WriteLine("Kan niet, rekening geblokkeerd!");
            }
            else
            {
                balans = balans + aantal;
                Console.WriteLine($"U hebt {aantal} EUR gestort");
                Console.WriteLine($"Uw nieuwe balans: {Balans} EUR");
                Console.WriteLine("");
            }
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam: {NaamKlant}");
            Console.WriteLine($"Rekeningnummer: {RekeningNummer}");
            Console.WriteLine($"Balans: {Balans} EUR");
            Console.WriteLine("");
        }
        public void VeranderStaat()
        {
            if (Staat == RekeningStaat.Geldig)
            {
                Staat = RekeningStaat.Geblokkeerd;
                Console.WriteLine("Uw rekening is nu geblokkeerd!");
            }
            else if (Staat == RekeningStaat.Geblokkeerd)
            {
                Staat = RekeningStaat.Geldig;
                Console.WriteLine("Uw rekening is weer geldig!");
            }
        }
    }
}
