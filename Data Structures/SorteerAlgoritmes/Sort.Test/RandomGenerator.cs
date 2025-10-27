using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SorteerAlgoritmes;

namespace SorteerAlgoritmes
{
    public class RandomGenerator
    {
        private readonly int amount;
        private readonly int min;
        private readonly int max;
        private readonly bool unique;

        public RandomGenerator(int amount, int min, int max, bool unique)
        {
            this.amount = amount;
            this.min = min;
            this.max = max;
            this.unique = unique;
        }

        public int[] Generate()
        {
            int[] numbers = new int[amount];
            int temp;
            bool valueExists = false;
            for (int i = 0; i < amount; i++)
            {
                valueExists = false;
                do
                {
                    temp = new Random().Next(min, max + 1);
                    if (unique)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (temp == numbers[j])
                            {
                                valueExists = true;
                                break;
                            }
                        }
                    }

                    if (!valueExists)
                        numbers[i] = temp;
                } while (valueExists);
            }
            return numbers;
        }
    }
}
