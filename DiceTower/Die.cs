using System;

namespace DiceTower
{
    public class Die
    {
        public Die(int numberOfSides)
        {
            this.NumberOfSides = numberOfSides;
        }

        public bool HasAdvantage { get; set; }
        public bool HasDisadvantage { get; set; }
        private int NumberOfSides { get; }

        public int Roll()
        {
            if (this.HasAdvantage && this.HasDisadvantage)
            {
                throw new Exception("A die can't have advantage and disadvantage at the same time.");
            }
            if (this.HasAdvantage)
            {
                var firstResult = new Random().Next(1, this.NumberOfSides);
                var secondResult = new Random().Next(1, this.NumberOfSides);
                return Math.Max(firstResult, secondResult);
            }
            if (this.HasDisadvantage)
            {
                var firstResult = new Random().Next(1, this.NumberOfSides);
                var secondResult = new Random().Next(1, this.NumberOfSides);
                return Math.Min(firstResult, secondResult);
            }
            return new Random().Next(1, this.NumberOfSides);
        }
    }
}
