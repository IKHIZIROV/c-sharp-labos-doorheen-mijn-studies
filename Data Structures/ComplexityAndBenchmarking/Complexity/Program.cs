namespace Complexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complexity c = new Complexity();

            Console.WriteLine("Hallo, geef 5 getallen!");
            Console.WriteLine("");

            int[] list = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("Opties:");
            Console.WriteLine("1.Som berekenen");
            Console.WriteLine("2.Check of som groter is dan 100");
            Console.WriteLine("3.Gemiddelde berekenen");
            Console.WriteLine("");

            int optie = Convert.ToInt32(Console.ReadLine());

            if (optie == 1)
            {
                int sum = c.CalculateSum(list);
                Console.WriteLine(sum);
            } 
            else if (optie == 2)
            {
                bool isGreater = c.IsSumGreaterThan100(list);
                Console.WriteLine(isGreater);
            }
            else if (optie == 3)
            {
                double gem = c.CalculateAverage(list);
                Console.WriteLine(gem);
            }
        }
    }
}