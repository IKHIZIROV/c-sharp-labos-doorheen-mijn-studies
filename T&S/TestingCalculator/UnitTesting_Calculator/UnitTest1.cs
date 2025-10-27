using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingCalculator;

// ALTIJD DEZE 3 STAPPEN BIJ TESTING
// 1. using zetten in unit test project
// 2. class public zetten in plaats van internal (in de main project)
// 3. reference leggen vanuit unit testing project (dependencies > add project reference)

namespace UnitTesting_Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize]
        public void ArrangeTests()
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(4, 5, 9)]
        [DataRow(-6, -9, -15)]
        [DataRow(-1, 2, 1)]
        public void SumTest(int input1, int input2, int expected)
        {

            // Arrange
            // see datarows

            // Act
            int actual = calculator.Sum(input1, input2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(70, 1.50, 31.1)]
        [DataRow(100, 1.87, 28.6)]
        [DataRow(65, 1.60, 25.4)]
        public void TestBMICorrect(double gewicht, double lengte, double expected)
        {

            // Arrange
            // see datarows

            // Act
            double actual = calculator.BMICalculator(gewicht, lengte);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(6)]
        public void EvenTestTrue(int input)
        {
            // Arrange
            // see datarows

            // Act

            bool actual = calculator.Even(input);

            // Assert 

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EvenTestFalse()
        {
            // Arrange

            int input = 7;

            // Act

            bool actual = calculator.Even(input);

            // Assert 

            Assert.IsFalse(actual);
        }
    }
}

