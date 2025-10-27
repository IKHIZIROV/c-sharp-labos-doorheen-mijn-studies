using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._8
{
    class Container : Doos
    {   
        public Container(int id) : base(id)
        {
        }
        public override int KostPrijs
        {
            get { return base.KostPrijs + 5; }
        }
    }
}
