namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string DNA = "DNA: ";
            char convert;
         while (count <= 12)
         {
            Console.WriteLine("Geef een DNA-nucleotide. Kies uit G, C, T of A.");
            string ingave = Console.ReadLine();

                switch (ingave)
                {
                    case "G" or "g":
                        ingave = "C";
                        count++;
                        DNA += ingave;
                        Console.WriteLine(DNA);
                        break;
                    case "C" or "c":
                        ingave = "G";
                        count++;
                        DNA += ingave;
                        Console.WriteLine(DNA);
                        break;
                    case "T" or "t":
                        ingave = "A";
                        count++;
                        DNA += ingave;
                        Console.WriteLine(DNA);
                        break;
                    case "A" or "a":
                        ingave = "U";
                        count++;
                        DNA += ingave;
                        Console.WriteLine(DNA);
                        break;
                    default:
                        Console.WriteLine("Foutieve ingave, probeer opnieuw");
                        break;
                }
         }
        }
    }
}