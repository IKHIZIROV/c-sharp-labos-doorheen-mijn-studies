using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._1
{
    class Lijn : Vorm
    {
        public override void TekenVorm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Lengte; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write("*");
            }
            Console.ResetColor();
        }
        public int Lengte { get; set; }
        public Lijn (int x, int y, int lengte) : base(x,y)
        {
            Lengte = lengte;
            X = x;
            Y = y;
        }
    }
}
