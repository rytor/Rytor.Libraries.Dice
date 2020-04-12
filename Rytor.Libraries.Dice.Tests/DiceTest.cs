using Xunit;

namespace Rytor.Libraries.Dice.Tests
{
    public class DiceTest
    {
        private Dice TwoSixSidedDice = new Dice(2, 6);

        [Fact]
        public void Dice_2Set_6Side_CanInstantiate_ReturnTrue()
        {
            Assert.True(TwoSixSidedDice.Set.Count == 2);
            Assert.True(TwoSixSidedDice.Set[0].NumberOfSides == 6);
        }

        [Fact]
        public void Dice_2Set_6Side_CanRoll_ReturnTrue()
        {
            TwoSixSidedDice.Roll();
            Assert.True(TwoSixSidedDice.Set[0].Value >= 1 && TwoSixSidedDice.Set[0].Value <= 6);
            Assert.True(TwoSixSidedDice.Set[1].Value >= 1 && TwoSixSidedDice.Set[1].Value <= 6);
        }
    }
}
