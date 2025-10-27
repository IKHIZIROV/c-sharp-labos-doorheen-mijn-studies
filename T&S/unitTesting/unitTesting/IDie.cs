using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    public interface IDie
    {
        int Roll();

        int Fallback()
        {
            return 0;
        }
    }
}
