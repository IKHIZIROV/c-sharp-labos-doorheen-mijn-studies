using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleur_mixer
{
    class Kleur
    {
        public int Rood { get; set; }
        public int Groen { get; set; }
        public int Blauw { get; set; }

        public void MengKleur(Kleur kleur)
        {
            Rood = (Rood + kleur.Rood) / 2;
            Groen = (Groen + kleur.Groen) / 2;
            Blauw = (Blauw + kleur.Blauw) / 2;
        }
    }
}
