using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herodemo
{
    public enum DobbelWaarden { Skelet, HeldSchild, MonsterSchild }

    internal class Dobbelsteen
    {
        static Random rng = new Random();
        public DobbelWaarden Rol()
        {
            int rolWaarde = rng.Next(0, 6);
            switch (rolWaarde)
            {
                case 0:
                    return DobbelWaarden.MonsterSchild;
                    break;
                case 1:
                case 2:
                    return DobbelWaarden.HeldSchild;
                    break;
                default:
                    return DobbelWaarden.Skelet;
                    break;
            }
        }
    }
}