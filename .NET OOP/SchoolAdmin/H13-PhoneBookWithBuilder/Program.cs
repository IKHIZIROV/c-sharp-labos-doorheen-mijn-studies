namespace H13_PhoneBookWithBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void PhoneBookNumber()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            bool stop = true;

            while (stop)
            {
                Console.WriteLine("Welkom bij de oefeningen van objectgeorieenteerd prorgammeren!");
                Console.WriteLine("Topic van de uit te voeren oefening?");

                Console.WriteLine("1.DateTime");
                Console.WriteLine("2.Properties en access modifiers");
                Console.WriteLine("3.Datastructuren");

                string keuze = Console.ReadLine();
                string naam;
                string nummer;

                if (keuze == "3")
                {
                    Console.WriteLine("Uit te voeren oefening?");
                    Console.WriteLine("H13- Phonebook name number");
                    Console.WriteLine("H13- Phonebook city name number");
                    Console.WriteLine("H13- Phonebook with builder");
                    keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        Console.WriteLine("Wil je een naam en nummer invoegen?");
                        keuze = Console.ReadLine();
                        if (keuze == "ja")
                        {
                            Console.Write("Naam? ");
                            naam = Console.ReadLine();
                            Console.Write("Nummer? ");
                            nummer = Console.ReadLine();

                            if (phoneBook.ContainsKey(naam))
                            {
                                phoneBook[naam] = nummer;
                            }
                            else
                            {
                                phoneBook.Add(naam, nummer);
                            }


                            Console.WriteLine("Wil je nog een naam toevoegen?");
                            keuze = Console.ReadLine();
                            if (keuze == "ja")
                            {
                                Console.Write("Naam? ");
                                naam = Console.ReadLine();
                                Console.Write("Nummer? ");
                                nummer = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Bedankt!");
                            }
                            foreach (var number in phoneBook)
                            {
                                Console.WriteLine($"{number.Key}: {number.Value} ");
                            }
                        }

                    }

                }

            }
        }
}
