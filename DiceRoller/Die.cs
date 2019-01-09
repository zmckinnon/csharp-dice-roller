using System;

namespace DiceRoller
{
    public class Die
    {
        public Die(int numberOfSides)
        {
            this.NumberOfSides = numberOfSides;
        }

        private int NumberOfSides { get; }

        public int Roll() => new Random().Next(1, this.NumberOfSides);
    }
}
