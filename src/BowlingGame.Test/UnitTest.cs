using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CalculatePartialScore_WhenIsStrike_ShouldReturn10PlusTwoShots()
        {
            // Arrange
            var frame1 = new Frame() { FirstShot = 10, SecondShot = 0 };
            var frame2 = new Frame() { FirstShot = 4, SecondShot = 5 };

            // Act
            int score = ScoreCalculator.CalculatePartialScore(frame1, frame2);

            // Assert
            Assert.IsTrue(19 == score);
        }

        [TestMethod]
        public void CalculatePartialScore_WhenIsSpare_ShouldReturn10PlusOneShot()
        {
            // Arrange
            var frame1 = new Frame() { FirstShot = 6, SecondShot = 4 };
            var frame2 = new Frame() { FirstShot = 4, SecondShot = 5 };

            // Act
            int score = ScoreCalculator.CalculatePartialScore(frame1, frame2);

            // Assert
            Assert.IsTrue(14 == score);
        }

        [TestMethod]
        public void CalculatePartialScore_WhenIsOpenFrame_ShouldReturnSumOfTwoShots()
        {
            // Arrange
            var frame1 = new Frame() { FirstShot = 1, SecondShot = 2 };
            var frame2 = new Frame() { FirstShot = 4, SecondShot = 5 };

            // Act
            int score = ScoreCalculator.CalculatePartialScore(frame1, frame2);

            // Assert
            Assert.IsTrue(3 == score);
        }
    }
}