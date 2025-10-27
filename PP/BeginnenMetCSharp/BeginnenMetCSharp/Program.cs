using System;
namespace BeginnenMetCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, hoe heet je?");
            string name = Console.ReadLine();
            Console.WriteLine($"Dag {name}, hoe gaat het met je?");

            Console.Write("Waar woon je? ");
            string place = Console.ReadLine();
            Console.WriteLine($"Dus jij bent {name} uit {place}.");
        }
    }
}
