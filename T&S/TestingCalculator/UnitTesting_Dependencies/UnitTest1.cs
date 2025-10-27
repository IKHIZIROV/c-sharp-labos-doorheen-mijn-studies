using DependenciesExercise;
using Moq;
namespace UnitTesting_Dependencies
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RateGuess_Returns_2_When_Guess_Is_Correct()
        {
            var numberGame = new NumberGame(new DieMock(5)); //<--
            int result = numberGame.RateGuess(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RateGuess_Returns_1_When_Guess_Is_Only_1_Wrong()
        {
            var numberGame = new NumberGame(new DieMock(5));
            int result = numberGame.RateGuess(4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RateGuess_Returns_0_When_Guess_Is_Wrong()
        {
            var numberGame = new NumberGame(new DieMock(5));
            int result = numberGame.RateGuess(3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RateGuess_Returns_2_When_Guess_Is_Correct_Moq()
        {
            var die = new Mock<IDie>();
            die.Setup(x => x.Roll()).Returns(5); //<-- dit is nieuw!
            var numberGame = new NumberGame(die.Object);
            int result = numberGame.RateGuess(5);
            Assert.AreEqual(2, result);
        }
    }
}