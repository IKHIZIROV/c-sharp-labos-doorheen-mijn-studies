using Sort.Test;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SorteerAlgoritmes
{
    [TestClass]
    public class BubbleSortUnitTests
    {
        [TestMethod]
        public void SimpleTest()
        {

            var list = new int[] { 5, 7, 2, 1, 10 };
            var bs = new BubbleSort();
            bs.Sort(list);

            for (int i = 0; i < list.Length - 1; i++)
            {
                Assert.IsTrue(list[i] <= list[i + 1]);
            }
        }

        [TestMethod]
        public void LargeListTest()
        {
            var list = new RandomGenerator(10000, 0, 100000).GenerateNumbers();
            var bs = new BubbleSort();
            bs.Sort(list);

            for (int i = 0; i < list.Length - 1; i++)
            {
                Assert.IsTrue(list[i] <= list[i + 1]);
            }
        }


        [TestMethod]
        public void MeasurePerformance()
        {
            var sw = new Stopwatch();
            var amount = 10000;
            while (amount <= 50000)
            {
                var list = new RandomGenerator(amount, 0, 1000000).GenerateNumbers();
                var bs = new BubbleSort();

                sw.Start();
                bs.Sort(list);
                sw.Stop();

                Debug.WriteLine($"sorting {amount} numbers took {sw.ElapsedMilliseconds}ms");
                amount += 10000;
                sw.Reset();
            }
        }


        [TestMethod]
        public void SortIntelligentAndMeasure()
        {
            var list = new RandomGenerator(10000, 0, 1000000).GenerateNumbers();
            var sw = new Stopwatch();
            var bs = new BubbleSort();

            sw.Start();
            bs.SortIntelligent(list);
            sw.Stop();
            Debug.WriteLine($"sorting 10000 numbers first time took {sw.ElapsedMilliseconds}ms");

            sw.Reset();

            sw.Start();
            bs.SortIntelligent(list);
            sw.Stop();
            Debug.WriteLine($"sorting 10000 numbers again took {sw.ElapsedMilliseconds}ms");
        }

        [TestMethod]
        public void SortRecursive()
        {
            var list = new RandomGenerator(10000, 0, 1000000).GenerateNumbers();
            var bs = new BubbleSort();

            bs.SortRecursive(list);

            for (int i = 0; i < list.Length - 1; i++)
            {
                Assert.IsTrue(list[i] <= list[i + 1]);
            }
        }
    }
}