namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hoi, ik ben het!");
            Console.WriteLine("Wie ben jij?");
            string result;
            result = Console.ReadLine();
            Console.WriteLine("Dag " + result + " hoe gaat het met je?");
            string leeftijd; //eerste variabele aanmaken
            string adres; //tweede variabele aanmaken
            Console.WriteLine("Geef je leeftijd");
            leeftijd = Console.ReadLine();
            Console.WriteLine("Geef je adres");
            adres = Console.ReadLine();
            
        }
    }
}