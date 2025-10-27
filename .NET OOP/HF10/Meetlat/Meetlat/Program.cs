namespace Meetlat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meetlat mijnLat = new Meetlat();
            mijnLat.BeginLengte = 500.0;
            Console.WriteLine($"Meter: {mijnLat.Meter}");
            Console.WriteLine($"Centimeter: {mijnLat.Cm}");
            Console.WriteLine($"Kilometer: {mijnLat.Km}");
            Console.WriteLine($"Voet: {mijnLat.Voet}");
        }
    }
}