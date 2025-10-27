namespace Kleur_mixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kleur k1 = new Kleur();
            k1.Rood = 10;
            k1.Groen = 0;
            k1.Blauw = 20;
            Kleur k2 = new Kleur();
            k2.Rood = 10;
            k2.Groen = 10;
            k2.Blauw = 50;

            k1.MengKleur(k2);
            Console.WriteLine($"{k1.Rood},{k1.Groen},{k1.Blauw}");
        }
    }
}