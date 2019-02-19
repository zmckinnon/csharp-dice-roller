using System;

namespace DiceTower.Parsers
{
    public class NotationParser
    {
        public NotationParser(string notation)
        {
            this.Notation = notation;
        }

        public string Notation { get; }

        public NotationParserResult Parse()
        {
            if (!this.Notation.Contains('d'))
            {
                throw new Exception("Invalid notation.");
            }
            var numberOfDiceString = this.Notation.Split('d')[0].Trim();
            if (!int.TryParse(numberOfDiceString, out int numberOfDice))
            {
                throw new Exception("Invalid notation.");
            }
            var numberOfSidesString = this.Notation.Split('d')[1].Split('+')[0].Trim();
            if (!int.TryParse(numberOfSidesString, out int numberOfSides))
            {
                throw new Exception("Invalid notation.");
            }
            var modifier = 0;
            if (this.Notation.Contains('+'))
            {
                var modifierString = this.Notation.Split('d')[1].Split('+')[1].Trim();
                if (!int.TryParse(modifierString, out modifier))
                {
                    throw new Exception("Invalid notation.");
                }
            }
            return new NotationParserResult
            {
                NumberOfDice = numberOfDice,
                NumberOfSides = numberOfSides,
                Modifier = modifier
            };
        }
    }

    public class NotationParserResult
    {
        public int NumberOfDice { get; set; }
        public int NumberOfSides { get; set; }
        public int Modifier { get; set; }
    }
}
