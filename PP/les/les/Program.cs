namespace les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int balX = 20;
            int balY = 20;
            int vectorX = 2;
            int vectorY = 1;

            int bal2X = 10;
            int bal2Y = 8;
            int vector2X = 2;
            int vector2Y = -1;

            while (true)
            {
                if (balX + vectorX >= Console.WindowWidth || balX + vectorX < 0)
                {
                    vectorX = -vectorX;
                }
                if (bal2X + vector2X >= Console.WindowWidth || bal2X + vector2X < 0)
                {
                    vector2X = -vector2X;
                }

                balX = balX + vectorX;
                bal2X = bal2X + vector2X;
                //enzovoort
            }
        }
    }
}