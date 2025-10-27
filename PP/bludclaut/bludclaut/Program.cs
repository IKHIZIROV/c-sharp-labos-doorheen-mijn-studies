namespace bludclaut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hvl bitches heb je?");
            Console.WriteLine("geef hieronder 2 getallen in; de lengte van je l en de lente van jezelf");
            int lengteLul = Convert.ToInt32(Console.ReadLine());
            int lengteLichaam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AantalBitches(lengteLul, lengteLichaam));
        }

        static int AantalBitches(int a, int b)
        {
            int aantalBitches = a + b;
            return aantalBitches;
        }
    }
}