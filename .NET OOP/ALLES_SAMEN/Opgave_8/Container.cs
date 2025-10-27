using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class Container : Doos
    {
        public Container(int id) : base(id)
        { 
        }

        public override int KostPrijs => base.KostPrijs + 5;
    }
}
