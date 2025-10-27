namespace hfd15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            President ikke = new President() { Naam = "Tim" };
            List<Minister> mins = new List<Minister>();
            mins.Add(new Minister() { Naam = "Bruno" });
            mins.Add(new Minister() { Naam = "Freya" });
            mins.Add(new Minister() { Naam = "Peter" });
            mins.Add(new Minister() { Naam = "Ann" });

            Land mijnLand = new Land();
            mijnLand.MaakRegering(ikke, mins);
            mijnLand.MaakRegering(ikke, mins); //Moet error geven
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Weer een jaar verder");
                mijnLand.JaarVerder();
            }
        }
    }
}