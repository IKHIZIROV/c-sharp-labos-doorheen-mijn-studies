namespace Hfd_9_oefn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            List<Balletje> veelBalletjes = new List<Balletje>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                veelBalletjes.Add(new Balletje() { X = r.Next(1, 10), Y = r.Next(1, 10), VectorX = r.Next(-2, 3), VectorY = r.Next(-2, 3) });
            }

            while (true)
            {
                for (int i = 0; i < veelBalletjes.Count; i++) // List<> is een array op steroids, hier gebruiken we een Count in plaats van Length
                {
                    veelBalletjes[i].Update();
                    veelBalletjes[i].TekenOpScherm();
                }

                System.Threading.Thread.Sleep(50); //50 ms wachten
                Console.Clear();
            }
        }
    }
}