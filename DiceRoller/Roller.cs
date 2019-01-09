namespace DiceRoller
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

        public int Roll()
        {
            var retVal = 0;
            for (var i = 0; i < this.NumberOfDice; i++)
            {
                var die = new Die(this.NumberOfSides);
                retVal += die.Roll();
            }
            return retVal;
        }
    }
}
