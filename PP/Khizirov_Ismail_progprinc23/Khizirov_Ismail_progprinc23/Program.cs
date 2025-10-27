using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Khizirov_Ismail_progprinc23
{
    internal class Program
    {
        static string naamGen()
        {
            Random randomGenerator2 = new Random();
            int keuze = randomGenerator2.Next(1, 11);
            string[] naamGenerator = { "TorBro", "Vuilhard", "Merci", "Junkpoes", "Genki", "Ono", "April", "Yingyatta", "Ombra", "Lookup" };
            string gegenereerdeNaam = naamGenerator[keuze];
            return gegenereerdeNaam;
        }

        static void toonHeld(string naam, int aanval, int verdediging)
        {
            int aantalSterretjes = 0;

            Console.WriteLine();

            string sterretjes = "";


            for (aantalSterretjes = 0; aantalSterretjes < naam.Length; aantalSterretjes++)
            {
                sterretjes += "*";
            }

            Console.WriteLine(sterretjes);
            Console.WriteLine(naam);
            Console.WriteLine("A=" + aanval);
            Console.WriteLine("V=" + verdediging);
            Console.WriteLine(sterretjes);
        }

        static void doeTraining(string naam, int aanval, int verdediging)
        {
            int aanvalOefMonster = 4;
            int verdedigingOefMonster = 6;

            Console.WriteLine();
            Console.WriteLine("---De training---");
            Console.WriteLine();
            Console.WriteLine($"Hoeveel wenst u te schieten? (min=1, max={aanval})");
            int antwoord = Int32.Parse(Console.ReadLine());

            while (antwoord > aanval)
            {
                Console.WriteLine();
                Console.WriteLine($"U kunt niet meer dan {aanval} kiezen!");
                Console.WriteLine("Gelieve opnieuw in te geven.");
                antwoord = Int32.Parse(Console.ReadLine());
            }

            while (antwoord < 1)
            {
                Console.WriteLine();
                Console.WriteLine("U moet minstens 1 schieten!");
                Console.WriteLine("Gelieve opnieuw in te geven.");
                antwoord = Int32.Parse(Console.ReadLine());
            }

            if (antwoord == verdedigingOefMonster +1 || antwoord == verdedigingOefMonster -1 || antwoord == verdedigingOefMonster)
            {
                Console.WriteLine();
                Console.WriteLine("Raak!");
                Console.WriteLine("Door te raken wordt de verdediging van het monster verlaagd met 1.");
                verdedigingOefMonster--;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"Oei, gemist. Het monster heeft verdediging {verdedigingOefMonster}.");
                Console.WriteLine($"Je had een getal tussen {verdedigingOefMonster -1} en {verdedigingOefMonster +1} moeten kiezen");
                Console.WriteLine("(als dat kon met je huidige aanvalskracht).");
                Console.WriteLine();
                Console.WriteLine("Door te missen wordt je aanval met 1 verlaagt.");
                aanval--;
            }

            Random randomGenerator3 = new Random();

            int aanvalskrachtOefMonster = randomGenerator3.Next(1, 5);

            Console.WriteLine();
            Console.WriteLine("Nu valt het monster aan.");
            Console.WriteLine($"Het valt aan met {aanvalskrachtOefMonster}.");

            if (aanvalskrachtOefMonster == verdediging + 1 || aanvalskrachtOefMonster == verdediging - 1 || aanvalskrachtOefMonster == verdediging)
            {
                Console.WriteLine();
                Console.WriteLine("Raak!");
                Console.WriteLine("Door te raken wordt de aanval van het monster verlaagd met 1.");
                verdediging--;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Oef, gemist. De aanvalskracht van het monster zakt");
                aanvalOefMonster--;
            }

            Console.WriteLine();
            Console.WriteLine("Eens kijken wie wint. Diegene met de hoogste som van aantal en verdediging wint.");
            Console.WriteLine("Bij gelijke stand wint de held");

            int somOefMonster = aanvalOefMonster + verdedigingOefMonster;
            int somHeld = aanval + verdediging;

            if (somHeld >= somOefMonster)
            {
                Console.WriteLine();
                Console.WriteLine("U heeft de training gewonnen!");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Het monster wint de training.");
            }
        }

        static void doeGame(string naam, int aanval, int verdediging)
        {
            Console.WriteLine();
            Console.WriteLine("Het spel gaat beginnen. Druk op enter om door te gaan.");
            Console.ReadLine();
            Console.Clear();
            int score = 0;

            for (int i = 0; i < 3; i++)
            {
                if (doeGevecht(aanval, verdediging) == true)
                {
                    score++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Mooi zo {naam}. Je behaalde een score van {score}. Tot volgende keer!");
        }

        static bool doeGevecht(int aanval, int verdediging)
        {
            bool gewonnen1;
            Random randomGenerator4 = new Random();

            int aanvalMonster = randomGenerator4.Next(1, 10);
            int verdedigingMonster = 10 - aanvalMonster;

            Console.WriteLine();
            Console.WriteLine("Nieuwe monster staat klaar!");
            Console.WriteLine();
            Console.WriteLine($"Hoeveel wenst u te schieten? (min=1, max={aanval})");
            int antwoord = Int32.Parse(Console.ReadLine());

            while (antwoord > aanval)
            {
                Console.WriteLine();
                Console.WriteLine($"U kunt niet meer dan {aanval} kiezen!");
                Console.WriteLine("Gelieve opnieuw in te geven.");
                antwoord = Int32.Parse(Console.ReadLine());
            }

            while (antwoord < 1)
            {
                Console.WriteLine();
                Console.WriteLine("U moet minstens 1 schieten!");
                Console.WriteLine("Gelieve opnieuw in te geven.");
                antwoord = Int32.Parse(Console.ReadLine());
            }

            if (antwoord == verdedigingMonster + 1 || antwoord == verdedigingMonster - 1 || antwoord == verdedigingMonster)
            {
                Console.WriteLine();
                Console.WriteLine("Raak!");
                Console.WriteLine("Door te raken wordt de verdediging van het monster verlaagd met 1.");
                verdedigingMonster--;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"Oei, gemist. Het monster heeft verdediging {verdedigingMonster}.");
                Console.WriteLine($"Je had een getal tussen {verdedigingMonster - 1} en {verdedigingMonster + 1} moeten kiezen");
                Console.WriteLine("(als dat kon met je huidige aanvalskracht).");
                Console.WriteLine();
                Console.WriteLine("Door te missen wordt je aanval met 1 verlaagt.");
                aanval--;
            }

            Random randomGenerator3 = new Random();

            int aanvalskrachtOefMonster = randomGenerator4.Next(1, 5);

            Console.WriteLine();
            Console.WriteLine("Nu valt het monster aan.");
            Console.WriteLine($"Het valt aan met {aanvalskrachtOefMonster}.");

            if (aanvalskrachtOefMonster == verdediging + 1 || aanvalskrachtOefMonster == verdediging - 1 || aanvalskrachtOefMonster == verdediging)
            {
                Console.WriteLine();
                Console.WriteLine("Raak!");
                Console.WriteLine("Door te raken wordt de aanval van het monster verlaagd met 1.");
                verdediging--;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Oef, gemist. De aanvalskracht van het monster zakt");
                aanvalMonster--;
            }

            Console.WriteLine();
            Console.WriteLine("Eens kijken wie wint. Diegene met de hoogste som van aantal en verdediging wint.");
            Console.WriteLine("Bij gelijke stand wint de held");

            int somMonster = aanvalMonster + verdedigingMonster;
            int somHeld = aanval + verdediging;

            if (somHeld >= somMonster)
            {
                Console.WriteLine();
                Console.WriteLine("U heeft dit rondje gewonnen");
                gewonnen1 = true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Het monster wint dit rondje.");
                gewonnen1 = false;
            }

            return gewonnen1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wil je een random held genereren?(ja/nee)");
            string antwoord = Console.ReadLine();

            Random randomGenerator = new Random();

            int aanval = 0;
            int verdediging = 0;
            string naam = "";

            if (antwoord == "nee")
            {
                aanval = 5;
                verdediging = 5;
                naam = "Default";
            }

            else if (antwoord == "ja")
            {
                aanval = randomGenerator.Next(1, 10);
                verdediging = 10 - aanval;
                naam = naamGen();
            }

            toonHeld(naam, aanval, verdediging);
            doeTraining(naam, aanval, verdediging);
            doeGame(naam, aanval, verdediging);
        }
    }
}