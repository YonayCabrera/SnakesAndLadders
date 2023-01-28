using SnamesAndLadders;
using FluentAssertions;

namespace SnamesAndLaddersShould
{
    public class GameShould
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Start_when_the_token_is_on_square_1()
        {
            var expectedSquare = 1;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }

        [Test]
        public void have_token_in_square_4_after_moving_3_spaces_from_square_1()
        {
            var dieValue = 3;

            game.MoveToken(dieValue);

            var expectedSquare = 4;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }

        [Test]
        public void have_token_in_square_8_after_moving_3_spaces_then_4_spaces_from_square_1()
        {
            var dieValue = 3;
            var secondDieValue = 4;

            game.MoveToken(dieValue);
            game.MoveToken(secondDieValue);

            var expectedSquare = 8;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }
    }
}