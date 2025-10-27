using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hfds_9_oefn_2
{
    internal class Computer
    {
        private bool staatAan = false;

        public void ZetAan()
        {
            if (!staatAan)
            {
                staatAan = true;
                Console.WriteLine("Aangezet");
            }
            else
                Console.WriteLine("Staat al aan");
        }
    }
}
