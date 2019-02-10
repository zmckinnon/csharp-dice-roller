using Xunit;
using DiceTower;
using System.Collections.Generic;
using Moq;

namespace DiceTower.Tests
{
    public class RollResultTests
    {
        [Fact]
        public void IsCriticalSuccess_ShouldReturnTrue()
        {
            var dieMock = new Mock<IDie>();
            dieMock.SetupGet(x => x.IsCriticalSuccess).Returns(true);
            // Arrange
            var dice = new List<IDie>
            {
                dieMock.Object
            };
            var rollResult = new RollResult(dice);

            // Act/Assert
            Assert.True(rollResult.IsCriticalSuccess);
        }

        [Fact]
        public void IsCriticalSuccess_ShouldReturnFalse()
        {
            var dieMock = new Mock<IDie>();
            dieMock.SetupGet(x => x.IsCriticalSuccess).Returns(false);
            // Arrange
            var dice = new List<IDie>
            {
                dieMock.Object
            };
            var rollResult = new RollResult(dice);

            // Act/Assert
            Assert.False(rollResult.IsCriticalSuccess);
        }

        [Fact]
        public void IsCriticalFailure_ShouldReturnTrue()
        {
            var dieMock = new Mock<IDie>();
            dieMock.SetupGet(x => x.IsCriticalFailure).Returns(true);
            // Arrange
            var dice = new List<IDie>
            {
                dieMock.Object
            };
            var rollResult = new RollResult(dice);

            // Act/Assert
            Assert.True(rollResult.IsCriticalFailure);
        }

        [Fact]
        public void IsCriticalFailure_ShouldReturnFalse()
        {
            var dieMock = new Mock<IDie>();
            dieMock.SetupGet(x => x.IsCriticalFailure).Returns(false);
            // Arrange
            var dice = new List<IDie>
            {
                dieMock.Object
            };
            var rollResult = new RollResult(dice);

            // Act/Assert
            Assert.False(rollResult.IsCriticalFailure);
        }
    }
}
