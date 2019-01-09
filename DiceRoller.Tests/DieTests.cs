using Xunit;
using DiceRoller;

namespace DiceRoller.Tests
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
    }
}
