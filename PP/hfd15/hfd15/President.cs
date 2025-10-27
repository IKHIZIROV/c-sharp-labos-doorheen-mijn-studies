using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hfd15
{
    public class President: Minister
    {
        public int Teller { get; private set; } = 4;
        public void JaarVerder()
        {
            Teller--;
        }
    }
}
