using SnamesAndLadders;
using FluentAssertions;

namespace SnamesAndLaddersShould
{
    public class DieShould
    {
        [Test]
        public void Return_value_between_1_6()
        {
            var dieMinValue = 1;
            var dieMaxValue = 6;
            var numberOfRolls = 100;

            for (int i = 0; i < numberOfRolls; i++)
            {
                int result = new Die().Roll();

                result.Should().BeGreaterThanOrEqualTo(dieMinValue);
                result.Should().BeLessThanOrEqualTo(dieMaxValue);
            }
        }
    }
}