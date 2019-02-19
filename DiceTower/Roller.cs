using System.Collections.Generic;
using DiceTower.Parsers;

namespace DiceTower
{
    public class Roller
    {
        public Roller(string notation)
        {
            var notationParser = new NotationParser(notation);
            var notationParseResult = notationParser.Parse();

            this.NumberOfDice = notationParseResult.NumberOfDice;
            this.NumberOfSides = notationParseResult.NumberOfSides;
            this.Modifier = notationParseResult.Modifier;
        }
        public Roller(int numberOfDice, int numberOfSides, int modifier = 0)
        {
            this.NumberOfDice = numberOfDice;
            this.NumberOfSides = numberOfSides;
            this.Modifier = 0;
        }

        private int NumberOfDice { get; }
        private int NumberOfSides { get; }
        private int Modifier { get; }

        public RollResult Roll()
        {
            var dice = new List<IDie>();
            for (var i = 0; i < this.NumberOfDice; i++)
            {
                var die = new Die(this.NumberOfSides);
                die.Roll();
                dice.Add(die);
            }
            return new RollResult(dice, this.Modifier);
        }
    }
}
