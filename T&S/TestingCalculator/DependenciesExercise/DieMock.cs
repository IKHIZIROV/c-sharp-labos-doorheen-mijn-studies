using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciesExercise
{
    public class DieMock : IDie
    {
        private int result;

        public DieMock(int result)
        {
            this.result = result;
        }

        public int Roll()
        {
            return result;
        }
    }
}
