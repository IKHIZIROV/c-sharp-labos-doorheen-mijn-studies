using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khizirov_Ismail_OOP
{
    class Container : Doos
    {
        public override int KostPrijs
        {
            get { return (Gewicht * 15) + 5; }
        }
    }
}
