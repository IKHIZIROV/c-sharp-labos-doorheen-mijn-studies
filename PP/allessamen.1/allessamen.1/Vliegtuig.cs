using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._1
{
    class Vliegtuig : Vorm
    {
        private Rechthoek rechthoek;
        private Lijn lijn;
        private Lijn lijnn;
        public Vliegtuig(int x, int y) : base(x,y)
        {
            rechthoek = new Rechthoek(x + 3, y, 5, 2);
            lijn = new Lijn(x, y + 2, 3);
            lijnn = new Lijn(x + 5, y + 2, 3);
        }
        public override void TekenVorm()
        {
            rechthoek.TekenVorm();
            lijn.TekenVorm();
            lijnn.TekenVorm();
        }
    }
}
