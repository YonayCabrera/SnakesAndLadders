using SnamesAndLadders;
using FluentAssertions;
using NSubstitute;
using System.Numerics;

namespace SnamesAndLaddersShould
{
    public class GameShould
    {
        private Game game;
        private Player player;
        private Die die;

        [SetUp]
        public void Setup()
        {
            die = Substitute.For<Die>();
            player = new Player(die);
            game = new Game();
        }

        [Test]
        public void Start_with_the_token_on_square_1()
        {
            var expectedSquare = 1;
            game.GetTokenPosition().Should().Be(expectedSquare);
            game.IsStarted().Should().BeFalse();
        }

        [Test]
        public void Have_token_in_square_4_after_moving_3_spaces_from_square_1()
        {
            var dieValue = 3;

            game.MoveToken(dieValue);

            var expectedSquare = 4;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }

        [Test]
        public void Have_token_in_square_8_after_moving_3_spaces_then_4_spaces_from_square_1()
        {
            var dieValue = 3;
            var secondDieValue = 4;

            game.MoveToken(dieValue);
            game.MoveToken(secondDieValue);

            var expectedSquare = 8;
            game.GetTokenPosition().Should().Be(expectedSquare);
        }

        [Test]
        public void End_the_game_when_token_is_in_square_100_after_moving_3_spaces_from_square_97()
        {
            var valueOfDie = 96;
            var valueOfSecondDie = 3;

            game.MoveToken(valueOfDie);
            game.MoveToken(valueOfSecondDie);

            game.IsFinished().Should().BeTrue();
        }

        [Test]
        public void Not_end_the_game_when_token_move_4_spaces_from_square_97_and_then_the_token_is_on_97()
        {
            var valueOfDie = 96;
            var valueOfSecondDie = 4;

            game.MoveToken(valueOfDie);
            game.MoveToken(valueOfSecondDie);

            var expectedSquare = 97;
            game.IsFinished().Should().BeFalse();
            game.GetTokenPosition().Should().Be(expectedSquare);
        }

        [Test]
        public void Start_when_then_player_rolls_a_die()
        {
            game.MoveToken(1);

            game.IsStarted().Should().BeTrue();
        }

        [Test]
        public void Move_4_spaces_when_the_player_rolls_a_4()
        {
            die.Roll().Returns(4);
            var valueOfDie = player.RollADie();

            game.MoveToken(valueOfDie);

            var expectedPosition = 5;
            game.GetTokenPosition().Should().Be(expectedPosition);
        }
    }
}