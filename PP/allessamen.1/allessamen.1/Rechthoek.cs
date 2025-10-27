using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._1
{
    class Rechthoek : Vorm
    {
        public override void TekenVorm()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Lengte; i++)
            {
                for (int j = 0; j < Breedte; j++)
                {
                    Console.SetCursorPosition(X + i, Y + j);
                    Console.Write("*");
                }
            }
            Console.ResetColor();
        }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public Rechthoek(int x, int y, int lengte, int breedte) : base(x,y)
        {
            X = x;
            Y = y;
            Lengte = lengte;
            Breedte = breedte;
        }
        public Rechthoek() : base(1,1)
        {
            Lengte = 2;
            Breedte = 2;
        }
    }
}
