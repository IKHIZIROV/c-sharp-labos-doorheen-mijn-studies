namespace hoofdstuk4_oefn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef zijde");
            double zijde = double.Parse(Console.ReadLine());

            double opp = Math.Pow(zijde, 2);
            double omtrek = zijde * 4;
            Console.WriteLine($"Zijde: {zijde}");
            Console.WriteLine($"Omtrekt: {omtrek}");
            Console.WriteLine($"Oppervlakte: {oppf}");
        }
    }
}