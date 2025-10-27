namespace Khizirov_Ismail_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // de opdracht is zeer slecht uitgelegd, opdrachten staan ook niet in volgorde

            DHLSchips nameSchip = new DHLSchips();
            Console.WriteLine("Geef scheepsnaam voor we verder gaan aub");
            string naamSchip = Console.ReadLine();

            DHLSchips nameSchip = new DHLSchips();
            nameSchip = naamSchip;

            bool blabla = true;

            while (true)
            {
                Console.WriteLine("************************");
                Console.WriteLine("* DHL MANIFEST CREATOR *");
                Console.WriteLine("************************");
                Console.WriteLine("Maak uw keuze");
                Console.WriteLine("a. Een doos aanmaken en op het schip zetten");
                Console.WriteLine("b. Het schip-manifest op het scherm afdrukken");
                Console.WriteLine("c. Het programma afsluiten");
                string antw = Console.ReadLine();
                if (antw == "a")
                {
                    Console.WriteLine("Geef type doos");
                    Console.WriteLine("wat voor doos wil je?:");
                    Console.WriteLine("a. Postdoos");
                    Console.WriteLine("b. Container");
                    Console.WriteLine("c. SecureContainer");

                    string typeDoos = Console.ReadLine();

                    Console.WriteLine("Geef gewicht");
                    string gewicht = Console.ReadLine();

                    Console.WriteLine("Geef inhoud");
                    string inhoud = Console.ReadLine();

                }

                else if (antw == "b")
                {
                    ToonManifest();
                }

                else if (antw == "c")
                {
                    blabla = false;
                }
            }
        }
    }
}