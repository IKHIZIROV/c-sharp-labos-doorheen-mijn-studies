using Sort.Test;

namespace SorteerAlgoritmes
{
    [TestClass]
    public class RandomGeneratorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            RandomGenerator rng = new RandomGenerator(20, 5, 50, false);
            int[] lijst = rng.Generate();
        }
    }
}