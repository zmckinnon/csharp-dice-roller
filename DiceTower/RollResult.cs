using System.Collections.Generic;
using System.Linq;

namespace DiceTower
{
    public class RollResult
    {
        public RollResult(IList<IDie> dice, int modifier = 0)
        {
            this.Dice = dice;
            this.Modifier = modifier;
        }

        public int TotalValue => this.Dice.Sum(x => x.Value) + this.Modifier;
        public int NumberOfDice => this.Dice.Count;
        public IList<IDie> Dice { get; }
        public bool IsCriticalSuccess => this.Dice.Any(x => x.IsCriticalSuccess);
        public bool IsCriticalFailure => this.Dice.Any(x => x.IsCriticalFailure);
        public int Modifier { get; }
    }
}
