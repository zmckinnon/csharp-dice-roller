using System;
using System.Security.Cryptography;
using DiceTower.RNG;

namespace DiceTower
{
    public class Die
    {
        public Die(int numberOfSides, IRandomNumberGenerator rng = null)
        {
            this.NumberOfSides = numberOfSides;
            this.RandomNumberGenerator = rng ?? new CSRandomNumberGenerator();
        }

        public bool HasAdvantage { get; set; }
        public bool HasDisadvantage { get; set; }
        private int NumberOfSides { get; }
        private IRandomNumberGenerator RandomNumberGenerator { get; }

        public int Roll()
        {
            if (this.HasAdvantage && this.HasDisadvantage)
            {
                throw new Exception("A die can't have advantage and disadvantage at the same time.");
            }
            if (this.HasAdvantage)
            {
                var firstResult = this.RandomNumberGenerator.GenerateRandomInt(1, this.NumberOfSides);
                var secondResult = this.RandomNumberGenerator.GenerateRandomInt(1, this.NumberOfSides);
                return Math.Max(firstResult, secondResult);
            }
            if (this.HasDisadvantage)
            {
                var firstResult = this.RandomNumberGenerator.GenerateRandomInt(1, this.NumberOfSides);
                var secondResult = this.RandomNumberGenerator.GenerateRandomInt(1, this.NumberOfSides);
                return Math.Min(firstResult, secondResult);
            }
            return this.RandomNumberGenerator.GenerateRandomInt(1, this.NumberOfSides);
        }
    }
}
