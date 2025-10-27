using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._1
{
    class Vloot : Vorm
    {
        private List<Vliegtuig> v = new List<Vliegtuig>();
        public Vloot(int x, int y, int aantal) : base(x,y)
        {
            for (int i = 0; i < aantal; i++)
            {
                v.Add(new Vliegtuig(x, y + 5 * i));
            }
        }
        public override void TekenVorm()
        {
            foreach (var item in v)
            {
                item.TekenVorm();
            }
        }
    }
}
