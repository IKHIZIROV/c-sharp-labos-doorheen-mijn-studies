namespace _9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NummerBerekenaar paar1 = new NummerBerekenaar();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;
            Console.WriteLine($"Paar: {paar1.Getal1}, {paar1.Getal2}");

            int berekendeSom = paar1.Som();
            Console.WriteLine($"Som =  {berekendeSom}");

            Console.WriteLine($"Verschil = {paar1.Verschil()}");
            Console.WriteLine($"Product = {paar1.Product()}");
            Console.WriteLine($"Quotient = {paar1.Quotient()}");
        }
    }
}