using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverervingen
{
    class InternationalRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get { return Convert.ToByte(Math.Ceiling(Distance / 50)); }
        }


    }
}
