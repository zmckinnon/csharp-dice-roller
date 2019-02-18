using DiceTower.Parsers;
using Xunit;

namespace DiceTower.Tests.Parsers
{
    public class NotationParserTests
    {
        [Fact]
        public void Parse_WhenModiferExists_ShouldReturnCorrectValues()
        {
            // Arrange
            var notationParser = new NotationParser("2d20+5");

            // Act
            var result = notationParser.Parse();

            // Assert
            Assert.Equal(2, result.NumberOfDice);
            Assert.Equal(20, result.NumberOfSides);
            Assert.Equal(5, result.Modifier);
        }

        [Fact]
        public void Parse_WhenModiferDoesNotExist_ShouldReturnCorrectValues()
        {
            // Arrange
            var notationParser = new NotationParser("2d20");

            // Act
            var result = notationParser.Parse();

            // Assert
            Assert.Equal(2, result.NumberOfDice);
            Assert.Equal(20, result.NumberOfSides);
            Assert.Equal(0, result.Modifier);
        }
    }
}
