using System.Collections.Generic;

namespace DiceTower
{
    public class Roller
    {
        public Roller(int numberOfDice, int numberOfSides)
        {
            this.NumberOfDice = numberOfDice;
            this.NumberOfSides = numberOfSides;
        }

        private int NumberOfDice { get; }
        private int NumberOfSides { get; }

        public RollResult Roll()
        {
            var dice = new List<Die>();
            for (var i = 0; i < this.NumberOfDice; i++)
            {
                var die = new Die(this.NumberOfSides);
                die.Roll();
                dice.Add(die);
            }
            return new RollResult(dice);
        }
    }
}
