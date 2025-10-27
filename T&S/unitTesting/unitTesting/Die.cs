using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class Die : IDie
    {
        private static readonly Random random = new();

        public int Roll()
        {
            return random.Next(5) + 1;
        }
    }
}
