using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo
{
    internal class Mummie
    {
        public string Naam { get; } = "Mummie";
        public int Lopen { get; } = 4;
        public int Aanval { get; } = 3;
        public int Verdediging { get; } = 0;
        public int Lichaam { get; private set; } = 1;
        public int Intelligentie { get; } = 0;

        public void ToonInfo()
        {
            Console.WriteLine($"{Naam}: L{Lopen} A{Aanval} V{Verdediging} L{Lichaam} I{Intelligentie}");
        }

        public void KrijgSchade(int aantalSchade)
        {
            //Todo Lichaam fullprop van maken
            if (Lichaam != 0 && aantalSchade > 0)//als monster nog leeft
            {
                Lichaam = 0;
            }
            else
            {
                //Todo  throw new Exception("Ge moogt niet kloppen op lijken");
            }
        }
    }
}