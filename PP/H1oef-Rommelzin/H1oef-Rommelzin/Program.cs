namespace H1oef_Rommelzin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hallo, wat is je naam?");
            string result;
            result = Console.ReadLine();
            Console.WriteLine("Nou dat is een mooie naam, hoe oud ben je?");
            string kleur; // eerste variabele aanmaken
            string leeftijd; // tweede variabele aanmaken
            string eten; // derde variabele aanmaken
            string auto; // vierde variabele aanmaken
            string boek; // vijfde variabele aanmaken
            leeftijd = Console.ReadLine();
            Console.WriteLine("Al " + leeftijd + "? Amai je bent oud!");
            Console.WriteLine("Kun jij je favoriete eten, favoriete kleur, je favoriete auto en je favoriet boek ook geven aub?");
            eten = Console.ReadLine();
            kleur = Console.ReadLine();
            auto = Console.ReadLine();
            boek = Console.ReadLine();
            Console.WriteLine("Amai! je favoriete eten is " + eten + ", je favoriete kleur is " + kleur + ", je favoriete auto is " + auto + " en je favoriete boek is is " + boek + "? Super! Bedankt voor je informatie!");

        }
    }
}