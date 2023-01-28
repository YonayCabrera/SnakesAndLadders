using SnamesAndLadders;

namespace SnamesAndLadders
{
    public class Player
    {
        private Die die;

        public Player(Die die)
        {
            this.die = die;
        }

        public int RollADie()
        {
            return die.Roll();
        }
    }
}