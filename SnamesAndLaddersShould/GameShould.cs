using SnamesAndLadders;
using FluentAssertions;

namespace SnamesAndLaddersShould
{
    public class GameShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Start_when_the_token_is_on_square_1()
        {
            var game = new Game();

            var expectedSquare = 1;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }
    }
}