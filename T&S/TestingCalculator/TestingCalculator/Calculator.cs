using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCalculator
{
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public bool Even(int input)
        {
            return input % 2 == 0;
        }

        public double BMICalculator(double gewicht, double lengte)
        {
            return Math.Round(gewicht / (Math.Pow(lengte, 2)), 1);
        }
    }
}