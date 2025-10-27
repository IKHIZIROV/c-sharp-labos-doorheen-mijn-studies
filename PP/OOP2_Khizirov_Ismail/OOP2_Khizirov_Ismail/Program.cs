namespace OOP2_Khizirov_Ismail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Commentaar: de opgaves zijn veel te lang en we kunnen niet alles klaar hebben in 2 uur tijd
            // gelieve genade te tonen en volgende keer een kortere opgave geven aub

            Console.WriteLine("Wenst u een voorbeeld database met 10 samples? j/n");
            string antwoord = Console.ReadLine();

            if (antwoord == "n")
            {
                Console.WriteLine("Wenst u dat de database enkel digitale items bevat of beide soorten items? digitale/beide");
                string antwoord1 = Console.ReadLine();
                if (antwoord1 == "digitale") { }
                    
                else if (antwoord1 == "beide") { }
            }

            string optie = null;

            while (optie != "e")
            {
                Console.WriteLine("Kies uit het menu:");
                Console.WriteLine("a) Items toevoegen");
                Console.WriteLine("b) DB visualiseren");
                Console.WriteLine("c) Statistieken van de database tonen");
                Console.WriteLine("d) Informatie in de database aanpassen");
                Console.WriteLine("e) afsluiten");
                optie = Console.ReadLine();
            }

            MuziekDB db1 = new MuziekDB;

            switch (optie)
            {
                case "a":

                    break;
                case "b":
                    break;
                case "c":
                    db1.ToonStatistieken();
                    break;
                case "d":
                    break;
                default:
                    break;
            }
        }
    }
}