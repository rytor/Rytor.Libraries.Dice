using System.Collections.Generic;

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

        public List<Die> Roll()
        {
            for (int i = 0; i < Set.Count; i++)
            {
                Set[i].Roll();
            }

            return Set;
        }
    }
}