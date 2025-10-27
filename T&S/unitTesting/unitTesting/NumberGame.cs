using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    public class NumberGame(IDie die)
    {
        private readonly IDie die = die;

        /*
         * rate guess according to following rules:
         * - correct: 2 points
         * - 1 off: 1 point
         * - wrong: 0 points
         */
        public int RateGuess(int guess)
        {
            int result;
            try
            {
                result = die.Roll();
            }
            catch (Exception)
            {
                result = die.Fallback();
            }
            if (result == guess)
            {
                return 2;
            }
            if ((result == guess - 1) || (result == guess + 1))
            {
                return 1;
            }
            return 0;
        }
    }
}
