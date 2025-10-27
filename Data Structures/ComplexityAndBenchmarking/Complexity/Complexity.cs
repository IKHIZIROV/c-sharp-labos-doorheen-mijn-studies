using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity
{
    public class Complexity
    {
        public int CalculateSum(int[] data)
        {
            int sum = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
            }
            return sum;
        }

        public bool IsSumGreaterThan100(int[] data)
        {
            long sum = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
                if (sum > 100)
                {
                    return true;
                }
            }

            return false;
        }

        public double CalculateAverage(int[] data)
        {
            double sum = 0.0;
            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
            }
            double numberOfElements = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                numberOfElements++;
            }
            return sum / numberOfElements;
        }

        
    }
}
