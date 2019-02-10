using Xunit;
using DiceTower;
using Moq;
using DiceTower.RNG;

namespace DiceTower.Tests
{
    public class DieTests
    {
        [Fact]
        public void Roll_WhenD4_ShouldReturnThree()
        {
            // Arrange
            var randomNumberGeneratorMock = new Mock<IRandomNumberGenerator>();
            randomNumberGeneratorMock.Setup(x => x.GenerateRandomInt(1, 4)).Returns(3);
            var die = new Die(4, randomNumberGeneratorMock.Object);

            // Act
            die.Roll();

            // Assert
            Assert.Equal(3, die.Value);
        }

        [Fact]
        public void Roll_WhenDieHasAdvantage_ShouldReturnTen()
        {
            // Arrange
            var randomNumberGeneratorMock = new Mock<IRandomNumberGenerator>();
            randomNumberGeneratorMock.SetupSequence(x => x.GenerateRandomInt(1, 20))
                .Returns(10)
                .Returns(6);
            var die = new Die(20, randomNumberGeneratorMock.Object);

            // Act
            die.WithAdvantage().Roll();

            // Assert
            Assert.Equal(10, die.Value);
        }

        [Fact]
        public void Roll_WhenDieHasDisadvantage_ShouldReturnSix()
        {
            // Arrange
            var randomNumberGeneratorMock = new Mock<IRandomNumberGenerator>();
            randomNumberGeneratorMock.SetupSequence(x => x.GenerateRandomInt(1, 20))
                .Returns(10)
                .Returns(6);
            var die = new Die(20, randomNumberGeneratorMock.Object);

            // Act
            die.WithDisadvantage().Roll();

            // Assert
            Assert.Equal(6, die.Value);
        }
    }
}
