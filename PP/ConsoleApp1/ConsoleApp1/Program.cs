namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int teller = 1;

            while (teller <= 100)
            { 
                som += teller;
                teller+=2;
            }

            Console.WriteLine(som);
        }
    }
}