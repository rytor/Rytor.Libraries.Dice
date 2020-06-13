using System;

namespace Rytor.Libraries.Dice
{
    public class Die
    {
        private Random _random;

        public int Value { get; set; }
        public int NumberOfSides { get; set; }

        public Die(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
            _random = new Random();
        }

        public int Roll()
        {
            //Random.Next uses an inclusive lower bound, but an exclusive upper bound
            Value = _random.Next(1, NumberOfSides+1);
            return Value;
        }
    }
}
