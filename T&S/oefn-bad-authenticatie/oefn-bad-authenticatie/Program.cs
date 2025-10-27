using System.Diagnostics;

namespace oefn_bad_authenticatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string juisteGebruikersnaam = "admin";
            const string juistWachtwoord = "admin";

            int foutTeller = 0;

            do
            {
                Console.WriteLine("Geef de juiste gebruikersnaam en paswoord:");
                string gebruikersnaam = Console.ReadLine();
                string paswoord = Console.ReadLine();

                if (gebruikersnaam == juisteGebruikersnaam || paswoord == juistWachtwoord)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    foutTeller = 0;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("INCORRECT!");
                    Console.ResetColor();

                    foutTeller++;
                }
            } while (foutTeller < 3);

            if (foutTeller !< 3)
            {
                Console.WriteLine("Account geblokkeerd");
                Environment.Exit(0);
            }
        }
    }
}
