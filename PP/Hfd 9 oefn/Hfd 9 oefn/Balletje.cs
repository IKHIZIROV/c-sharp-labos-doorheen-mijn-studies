using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hfd_9_oefn
{
    internal class Balletje
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int VectorX { get; set; }

        public int VectorY { get; set; }

        public void Update()
        {
            //Xvector van richting veranderen aan de randen
            if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX; //X positie updaten
                                   //Yvector van richting veranderen aan de randen
            if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY; //Y positie updaten
        }

        public void TekenOpScherm()
        {
            //Output naar scherm sturen
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }

    }
}
