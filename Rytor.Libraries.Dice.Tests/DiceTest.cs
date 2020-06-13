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
            RollResult result = TwoSixSidedDice.Roll();
            Assert.True(result.Dice[0].Value >= 1 && result.Dice[0].Value <= 6);
            Assert.True(result.Dice[1].Value >= 1 && result.Dice[1].Value <= 6);
            Assert.True(result.Total > 0);
        }

        [Fact]
        public void Dice_2Set_6Side_CanRollEveryNumber_ReturnTrue()
        {
            RollResult roll;
            bool rolled2, rolled3, rolled4, rolled5, rolled6, rolled7, rolled8, rolled9, rolled10, rolled11, rolled12;
            rolled2 = rolled3 = rolled4 = rolled5 = rolled6 = rolled7 = rolled8 = rolled9 = rolled10 = rolled11 = rolled12 = false;

            while (!(rolled2 && rolled3 && rolled4 && rolled5 && rolled6 && rolled7 && rolled8 && rolled9 && rolled10 && rolled11 && rolled12))
            {
                roll = TwoSixSidedDice.Roll();

                switch (roll.Total)
                {
                    case 2:
                        System.Console.WriteLine("Rolled a 2");
                        rolled2 = true;
                        break;
                    case 3:
                        System.Console.WriteLine("Rolled a 3");
                        rolled3 = true;
                        break;
                    case 4:
                        System.Console.WriteLine("Rolled a 4");
                        rolled4 = true;
                        break;
                    case 5:
                        System.Console.WriteLine("Rolled a 5");
                        rolled5 = true;
                        break;
                    case 6:
                        System.Console.WriteLine("Rolled a 6");
                        rolled6 = true;
                        break;
                    case 7:
                        System.Console.WriteLine("Rolled a 7");
                        rolled7 = true;
                        break;
                    case 8:
                        System.Console.WriteLine("Rolled a 8");
                        rolled8 = true;
                        break;
                    case 9:
                        System.Console.WriteLine("Rolled a 9");
                        rolled9 = true;
                        break;
                    case 10:
                        System.Console.WriteLine("Rolled a 10");
                        rolled10 = true;
                        break;
                    case 11:
                        System.Console.WriteLine("Rolled a 11");
                        rolled11 = true;
                        break;
                    case 12:
                        System.Console.WriteLine("Rolled a 12");
                        rolled12 = true;
                        break;
                    default:
                        break;
                }
            }

            //if we get here, test passed
            Assert.True(1 == 1);
        }
    }
}
