using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace allessamen._1
{
    abstract class Vorm
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual ConsoleColor Kleur { get { return ConsoleColor.Red; } }
        public abstract void TekenVorm();
        public Vorm(int x, int y)
        {
            X = x;
            Y = y;
        }


    }
}
