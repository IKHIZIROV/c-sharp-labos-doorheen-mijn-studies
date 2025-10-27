using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_oefeningen
{
    internal class Balletje
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        public void Update()
        {
            Console.CursorVisible = false;
            int balX = 20;
            int balY = 20;
            int VectorX = 2;
            int VectorY = 1;
            while (true)
            {
                //Xvector van richting veranderen aan de randen
                if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
                {
                    VectorX = -VectorX;
                }
                X = X + VectorX; //X positie updaten
                                       //Yvector van richting veranderen aan de randen
                if (Y + VectorY >= Console.WindowHeight || balY + VectorY < 0)
                {
                    VectorY = -VectorY;
                }
                Y = Y + VectorY; //Y positie updaten
                                       //Output naar scherm sturen
                Console.SetCursorPosition(X, Y);
                Console.Write("O");
                System.Threading.Thread.Sleep(50); //50 ms wachten
                Console.Clear();
            }

        }

    }
}
