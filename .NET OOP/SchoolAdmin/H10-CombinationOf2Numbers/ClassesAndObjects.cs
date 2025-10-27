using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace H10_CombinationOf2Numbers
{
    class ClassesAndObjects
    {
        public int Number1;
        public int Number2;

        public double Sum()
        {
            return Number1 + Number2;
        }

        public double Difference()
        {
            return Number1 - Number2;
        }

        public double Product()
        {
            return Number1 * Number2;
        }

        public double Quotient()
        {
            if (Number2 != 0)
            {
                return Number1 / (double)Number2;
            }
            else
            {
                Console.WriteLine("FOUT");
                return -1;
            }
        }
    }
}
