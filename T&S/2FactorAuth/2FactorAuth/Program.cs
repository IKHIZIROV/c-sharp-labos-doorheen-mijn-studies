using System.Diagnostics;

namespace _2FactorAuth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randomGetal = generateRandomGetal();
                Console.WriteLine(randomGetal);

                Stopwatch time = new Stopwatch();
                time.Start();

                Console.WriteLine("Geef de code in:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == randomGetal)
                {
                    if (time.ElapsedMilliseconds > 5000)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Het getal is juist maar niet binnen de tijd ingegeven!");
                        Console.ResetColor();
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Het getal is juist en binnen de tijd ingegeven!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    if (time.ElapsedMilliseconds > 5000)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Het getal is fout en niet binnen de tijd ingegeven!");
                        Console.ResetColor();
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Het getal is fout!");
                        Console.ResetColor();
                    }  
                }
            }
        }

        public static int generateRandomGetal()
        {
            Random rng = new Random();
            int randomGetal = rng.Next(100000, 1000000);

            return randomGetal;
        }
    }
}
