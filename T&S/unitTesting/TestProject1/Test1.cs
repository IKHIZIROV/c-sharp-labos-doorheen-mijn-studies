using Moq;
using NumberGame;

namespace Unittests
{
    [TestClass]
    public class NumberGameTest
    {
        private Mock<IDie> mockDie;
        private NumberGame.NumberGame game;

        public NumberGameTest()
        {
            mockDie = new();
            game = new(mockDie.Object);
        }

        private void GivenNumberToGuess(int number)
        {
            mockDie.Setup(x => x.Roll()).Returns(number);
        }

        [TestMethod]
        public void When_guess_is_right_score_two_points()
        {
            // ARRANGE
            GivenNumberToGuess(4);

            // ACT
            var result = game.RateGuess(4);

            // ASSERT
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void When_guess_is_number_minus_one_score_one_point()
        {
            // ARRANGE
            GivenNumberToGuess(4);

            // ACT
            var result = game.RateGuess(3);

            // ASSERT
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void When_guess_is_number_plus_one_score_one_point()
        {
            // ARRANGE
            GivenNumberToGuess(4);

            // ACT
            var result = game.RateGuess(5);

            // ASSERT
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void When_guess_is_number_minus_two_score_zero_points()
        {
            // ARRANGE
            GivenNumberToGuess(4);

            // ACT
            var result = game.RateGuess(2);

            // ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void When_guess_is_number_plus_two_score_zero_points()
        {
            // ARRANGE
            GivenNumberToGuess(4);

            // ACT
            var result = game.RateGuess(6);

            // ASSERT
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void When_rolling_die_fails_use_fallback()
        {
            // ARRANGE
            mockDie.Setup(x => x.Roll()).Throws<Exception>();

            // ACT
            var result = game.RateGuess(1);

            // ASSERT
            mockDie.Verify(x => x.Fallback(), Times.Once);
        }
    }
}