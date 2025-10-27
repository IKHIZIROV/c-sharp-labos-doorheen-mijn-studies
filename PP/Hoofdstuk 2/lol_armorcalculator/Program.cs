namespace lol_armorcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armor = -25;
            int damage = 100;

            Console.WriteLine("Geef armor");
            armor = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef damage");
            damage = int.Parse(Console.ReadLine());

            double dmgMultiplier = 0.0;

            if (armor >= 0)
                dmgMultiplier = 100 / (100.0 + armor);
            else
                dmgMultiplier = 2 - 100 / (100.0 - armor);
            double dmgEffective = damage * dmgMultiplier;
            
            Console.WriteLine("Je multiplier = " + dmgMultiplier);
            Console.WriteLine("Je schade wordt dan" + dmgEffective);

        }
    }
}