using Xunit;
using DiceTower;
using DiceTower.RNG;
using System;

namespace DiceTower.Tests.RNG
{
    public class CSRandomNumberGeneratorTests
    {
        [Fact]
        public void GenerateRandomInt_WhenMinIsGreaterThanMax_ShouldThrowException()
        {
            // Arrange
            var csRandomNumberGenerator = new CSRandomNumberGenerator();

            // Act/Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => csRandomNumberGenerator.GenerateRandomInt(5, 3));
            Assert.Equal("Specified argument was out of the range of valid values.\nParameter name: max must be larger than min.", exception.Message);
        }
    }
}
