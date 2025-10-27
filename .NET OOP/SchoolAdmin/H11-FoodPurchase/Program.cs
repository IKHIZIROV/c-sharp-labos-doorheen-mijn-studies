namespace H11_FoodPurchase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoPurchase();
        }

        public static void DemoPurchase()
        {
            FoodPurchase kaas = new FoodPurchase("Kaas", 2, 2.45, true);
            Console.WriteLine($"De totaalprijs van {kaas.ProductName} is {kaas.CalculateTotalPrice()} EUR" );

            FoodPurchase boter = new FoodPurchase("Boter", 0, 5555, true);
            Console.WriteLine($"De totaalprijs van {boter.ProductName} is {boter.CalculateTotalPrice()} EUR");

        }
    }
}
