using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenciesExercise
{

    public class NumberGame
    {
        private IDie die; //<--
        public NumberGame(IDie die) //<--
        {
            this.die = die; //<--
        }

        public int RateGuess(int guess)
        {
            int result = die.Roll();
            if (result == guess)
            {
                return 2;
            }
            if (result - 1 == guess || result + 1 == guess)
            {
                return 1;
            }
            return 0;
        }
    }

}
