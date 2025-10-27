namespace H1oef_Visietkaartje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string voornaam; // eerste variabele aanmaken
            string achternaam; // tweede variabele aanmaken
            string hobby; // derde variabele aanmaken
            string adres; // vierde variabele aanmaken
            string keuzeap; // vijfde variabele aanmaken
            string keuzeopleiding; // zesde variabele aanmaken
            Console.WriteLine("Hallo, wat is je voornaam?");
            voornaam = Console.ReadLine();
            Console.WriteLine("Wat is je achternaam?");
            achternaam = Console.ReadLine();
            Console.WriteLine("Wat is je hobby?");
            hobby = Console.ReadLine();
            Console.WriteLine("Waar woon je?");
            adres = Console.ReadLine();
            Console.WriteLine("Waarom heb je voor AP gekozen?");
            keuzeap = Console.ReadLine();
            Console.WriteLine("Waarom heb je voor deze opleiding gekozen?");
            keuzeopleiding = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Goed, hier volgt je visietkaartje:");
            Console.WriteLine();
            Console.WriteLine("Je naam: " + voornaam + " " + achternaam);
            Console.WriteLine("Je hobby: " + hobby);
            Console.WriteLine("Je adres: " + adres);
            Console.WriteLine("Waarom op AP: " + keuzeap);
            Console.WriteLine("Waarom voor deze opleiding gekozen: " + keuzeopleiding);


        }
    }
}