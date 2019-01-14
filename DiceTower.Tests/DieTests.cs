using Xunit;
using DiceTower;

namespace DiceTower.Tests
{
    public class DieTests
    {
        [Fact]
        public void Roll_WhenD4_ShouldReturnBetween1And4()
        {
            // Arrange
            var die = new Die(4);

            // Act
            var result = die.Roll();

            // Assert
            Assert.True(result >= 1 && result <= 4);
        }

        [Fact]
        public void Roll_WhenDieHasAdvantage_ShouldReturnBetween1And20()
        {
            // Arrange
            var die = new Die(20);

            // Act
            var result = die.WithAdvantage().Roll();

            // Assert
            Assert.True(result >= 1 && result <= 20);
        }

        [Fact]
        public void Roll_WhenDieHasDisadvantage_ShouldReturnBetween1And20()
        {
            // Arrange
            var die = new Die(20);

            // Act
            var result = die.WithDisadvantage().Roll();

            // Assert
            Assert.True(result >= 1 && result <= 20);
        }
    }
}
