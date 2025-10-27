using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciesExercise
{
    public class Die : IDie //<--
    {
        private static Random random = new Random();

        public int Roll()
        {
            return random.Next(6) + 1;
        }
    }
}
