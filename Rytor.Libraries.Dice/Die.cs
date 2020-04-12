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
            Value = _random.Next(NumberOfSides);
            return Value;
        }
    }
}
