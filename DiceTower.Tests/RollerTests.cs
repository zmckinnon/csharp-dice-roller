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
            var roller = new Roller(4, 20);

            // Act
            var result = roller.Roll();

            // Assert
            Assert.True(result >= 3 && result <= 60);
        }
    }
}
