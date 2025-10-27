using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class PostDoos : Doos
    {
        public PostDoos(int id) : base(id)
        {
        }

        public override int KostPrijs => 10;
    }
}
