namespace Hoofdstuk_5_oefn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int K = 10;
            Random rng = new Random();
            Console.WriteLine("Rating speler A?");
            double ra = double.Parse(Console.ReadLine());
            if (ra < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                ra = rng.Next(500, 3001);
                Console.WriteLine($"Negatieve rating mag niet. Ik pas deze aan naar random getal, namelijk {ra}.");
                Console.ResetColor();
            }
            Console.WriteLine("Rating speler B?");
            double rb = double.Parse(Console.ReadLine());
            if (rb < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                rb = rng.Next(500, 3001);
                Console.WriteLine($"Negatieve rating mag niet. Ik pas deze aan naar random getal, namelijk {rb}.");
                Console.ResetColor();
            }



            double ea = 1 / (1 + Math.Pow(10, (rb - ra) / 400.0));
            double eb = 1 / (1 + Math.Pow(10, (ra - rb) / 400.0));

            Console.WriteLine("Wie is er gewonnen? A, B of D  (draw)");
            string whowon = Console.ReadLine();
            double puntA = 0;
            double puntB = 0;
            if (whowon == "A")
            {
                puntA = 1;
            }
            else if (whowon == "B")
            {
                puntB = 1;
            }
            else if (whowon == "D")
            {
                puntA = 0.5;
                puntB = 0.5;
            }
            else
            {
                puntA = 1;
                Console.WriteLine("Onbekende waarde. Ik laat A winnen.");
            }




            double ranew = ra + K * (puntA - ea);
            double rbnew = rb + K * (puntB - eb);

            Console.WriteLine($"Nieuwe rating van A:{Math.Round(ranew, 0)}");
            Console.WriteLine($"Nieuwe rating van B:{Math.Round(rbnew, 0)}");




        }
    }
}
