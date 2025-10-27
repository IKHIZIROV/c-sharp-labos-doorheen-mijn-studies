namespace hfd4_live_les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel uur per dag werk je?");
            double urenPerDag = 7.5; //double.Parse(Console.ReadLine());
            Console.WriteLine("Hoeveel dagen per maand?");
            int dagenPerMaand = 22; //int.Parse(Console.ReadLine());
            Console.WriteLine("Hoeveel euro per uur?");
            double prijsPerUur = 8.68; //double.Parse(Console.ReadLine());

            Random rng = new Random();
            double BRUTO_PERCENT = rng.NextDouble() + 1 ; 

            //const double BRTUO_PERCENT = 1.08;
            const double RSZ = 0.1307;
            const double BVH = 237.09;//bedrijfsvoorheffing


            double basis = urenPerDag * dagenPerMaand * prijsPerUur;
            Console.WriteLine($"Je basis brutoloon={basis:C}");
            double basis108 = basis * BRTUO_PERCENT;
            double afgerondBasis108 = Math.Round(basis108, 2);
            Console.WriteLine($"108% van je basis brutoloon={afgerondBasis108:C}");
            double rszAftrek = Math.Round(afgerondBasis108 * RSZ, 2);
            Console.WriteLine($"RSZ die zal worden afgehouden = {rszAftrek:C}");
            double belastbaarLoon = basis - rszAftrek;


            Console.WriteLine($"Belastbaar loon: {belastbaarLoon:C}");
            double nettoLoon = Math.Round(belastbaarLoon - BVH, 2);
            Console.WriteLine($"Je nettoloon is geworden :{nettoLoon:C}");

        }


    }
}