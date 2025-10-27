using BenchmarkDotNet.Running;
using Benchmark1;

namespace Benchmarking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static long CalculateSum(int[] data)
        {
            long sum = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
            }

            return sum;
        }

        public static bool IsSumGreaterThan100(int[] data)
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

        public static double CalculateAverage(int[] data)
        {
            double sum = 0;
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

        public static long CalculateSpecialSum(int[] data)
        {
            long specialSum = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                for (int j = 0; j < data.Length; ++j)
                {
                    specialSum += data[j];
                }
            }
            return specialSum;
        }

        public static long CalculateSpecialSum2(int[] data)
        {
            long specialSum = 0;
            for (int i = 0; i < 100; ++i)
            {
                for (int j = 0; j < data.Length; ++j)
                {
                    specialSum += data[j];
                }
            }
            return specialSum;
        }

        public static bool TestIfEnoughMemoryIsPresent(int N)
        {
            double[] temp = new double[N];
            int counter = 0;
            for (int i = 0; i < temp.Length; ++i)
            {
                temp[i] = counter++;
            }
            return true;
        }

        public static bool TestIfEnoughMemoryIsPresent2(int N)
        {
            double[,] temp = new double[N, N];
            int counter = 0;
            for (int i = 0; i < temp.GetLength(0); ++i)
            {
                for (int j = 0; j < temp.GetLength(1); ++j)
                {
                    temp[j, i] = counter++;
                }
            }
            return true;
        }

        public static bool TestIfEnoughMemoryIsPresent3(int N)
        {
            double[,,] temp = new double[N, N, N];
            int counter = 0;
            for (int i = 0; i < temp.GetLength(0); ++i)
            {
                for (int j = 0; j < temp.GetLength(1); ++j)
                {
                    for (int k = 0; k < temp.GetLength(2) - temp.GetLength(1) + 1; ++k)
                    {
                        temp[i, j, k] = counter++;
                    }
                }
            }
            return true;
        }

        public static double TestRandomElement(int[] data)
        {
            double[] temp = new double[data.Length * data.Length];

            var r = new Random().Next(data.Length);
            return data[r];
        }
    }
}