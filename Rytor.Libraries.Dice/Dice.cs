using System.Collections.Generic;
using System.Linq;

namespace Rytor.Libraries.Dice
{
    public class Dice
    {
        public List<Die> Set { get; set; }

        public Dice(int numberOfDice, int numberOfSides)
        {
            Set = new List<Die>();

            for (int i = 0; i < numberOfDice; i++)
            {
                Set.Add(new Die(numberOfSides));
            }
        }

        public RollResult Roll()
        {
            for (int i = 0; i < Set.Count; i++)
            {
                Set[i].Roll();
            }

            return new RollResult {Total = Set.Sum(x => x.Value), Dice = Set};
        }
    }
}