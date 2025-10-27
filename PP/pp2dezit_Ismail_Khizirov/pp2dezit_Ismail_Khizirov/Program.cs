using System;
using System.Collections.Immutable;

namespace pp2dezit_Ismail_Khizirov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine("Uit hoeveel wedstrijden zal het kampioenschap bestaan?");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x < 0 || x > 10);

            double[] zeilerEen = new double[x];
            double[] zeilerTwee = new double[x];
            double[] zeilerDrie = new double[x];

            double[] resultaat = new double[x];

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Wedstrijd {i}");
                resultaat = Wedstrijd();
                for (int j = 0; j < i; j++)
                {
                    zeilerEen[0+j] = resultaat[0];
                    zeilerTwee[0+j] = resultaat[1];
                    zeilerDrie[0+j] = resultaat[2];
                }
            }

            double gemiddeldeEen = 0;
            double gemiddeldeTwee = 0;
            double gemiddeldeDrie = 0;

            for (int i = 0; i < x; i++)
            {
                gemiddeldeEen += zeilerEen[0 + i];
            }
            gemiddeldeEen = gemiddeldeEen / x;

            for (int i = 0; i < x; i++)
            {
                gemiddeldeTwee += zeilerTwee[0 + i];
            }
            gemiddeldeTwee = gemiddeldeTwee / x;

            for (int i = 0; i < x; i++)
            {
                gemiddeldeDrie += zeilerDrie[0 + i];
            }
            gemiddeldeDrie = gemiddeldeDrie / x;

            Console.WriteLine($"Gemiddelde tijd zeiler één: {gemiddeldeEen}");
            Console.WriteLine($"Gemiddelde tijd zeiler twee: {gemiddeldeTwee}");
            Console.WriteLine($"Gemiddelde tijd zeiler drie: {gemiddeldeDrie}");
            Console.WriteLine($"De gemiddelde tijd van de 3 spelers samen is: {(gemiddeldeEen+gemiddeldeTwee+gemiddeldeDrie)/3}");

            BerekenWinnaar(zeilerEen, zeilerTwee, zeilerDrie);

            bool ja;

            Console.WriteLine("Wil je op zoek gaan naar valsspeler? j/n");
            if (Console.ReadLine() == "j")
            {
                ja = FraudeSpotter(zeilerEen, zeilerTwee, zeilerDrie);
                if (ja = true)
                {
                    Console.WriteLine("Er werd mogelijk gefraudeerd. Dit kampioenschap is afgelast.");
                }
                else if (ja = false)
                {
                    Console.WriteLine("Dit kampioenschap bevat geen vreemde tijden en kan goedgekeurd worden, jeuj!");
                }
            }
        }

        static double[] Wedstrijd()
        {
            Random r = new Random();
            double tijdEen = 10.0 + (r.NextDouble() * 10.0);
            double tijdTwee = 10.0 + (r.NextDouble() * 10.0);
            double tijdDrie = 10.0 + (r.NextDouble() * 10.0);
            double[] resultaat = {tijdEen, tijdTwee, tijdDrie};
            return resultaat;
        }

        static void BerekenWinnaar(double[] een, double[] twee, double[] drie)
        {

            Console.WriteLine("De winnaar");
            Console.WriteLine("De verliezer");
            Console.WriteLine("De snelste tijd");
            Console.WriteLine("Gemiddelde tijd");
        }

        static bool FraudeSpotter(double[] een, double[] twee, double[] drie)
        {
            Array.Sort(een);
            Array.Sort(twee);
            Array.Sort(drie);
            int indexEen = Array.BinarySearch(een, 20.0);
            int indexTwee = Array.BinarySearch(twee, 20.0);
            int indexDrie = Array.BinarySearch(drie, 20.0);
            if (indexEen >= 0)
            {
                Console.WriteLine("Speler één: mogelijke fraude");
                return true;
            }
            else
                Console.WriteLine("Speler één: in orde");
            if (indexTwee >= 0)
            {
                Console.WriteLine("Speler twee: mogelijke fraude");
                return true;
            }
            else
                Console.WriteLine("Speler twee: in orde");
            if (indexDrie >= 0)
            {
                Console.WriteLine("Speler drie: mogelijke fraude");
                return true;
            }
            else
                Console.WriteLine("Speler drie: in orde");

            return false;
        }
    }
}