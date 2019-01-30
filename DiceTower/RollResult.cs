using System.Collections.Generic;
using System.Linq;

namespace DiceTower
{
    public class RollResult
    {
        public RollResult(IList<Die> dice)
        {
            this.Dice = dice;
        }

        public int TotalValue => this.Dice.Sum(x => x.Value);
        public int NumberOfDice => this.Dice.Count;
        public IList<Die> Dice { get; private set; }
        public bool IsCriticalSuccess => this.Dice.Any(x => x.IsCriticalSuccess);
        public bool IsCriticalFailure => this.Dice.Any(x => x.IsCriticalFailure);
    }
}
