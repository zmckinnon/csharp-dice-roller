using Xunit;
using DiceTower;

namespace DiceTower.Tests
{
    public class RollerTests
    {
        [Fact]
        public void Roll_WhenThreeD20s_ShouldReturnBetween3And60()
        {
            // Arrange
            var roller = new Roller(3, 20);

            // Act
            var result = roller.Roll();

            // Assert
            Assert.True(result.TotalValue >= 3 && result.TotalValue <= 60);
            Assert.Equal(3, result.NumberOfDice);
        }

        [Fact]
        public void Roll_WhenThreeD20sWithDiceNotation_ShouldReturnBetween3And60()
        {
            // Arrange
            var roller = new Roller("3d20");

            // Act
            var result = roller.Roll();

            // Assert
            Assert.True(result.TotalValue >= 4 && result.TotalValue <= 60);
            Assert.Equal(3, result.NumberOfDice);
        }
    }
}
