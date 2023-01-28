namespace SnamesAndLadders
{
    public class Game
    {
        private int position = 1;
        public int GetTokenPosition()
        {
            return position;
        }

        public bool IsFinished()
        {
            return position == 100;
        }

        public bool IsStarted()
        {
            return position > 1;
        }

        public int MoveToken(int spaces)
        {
            if (position + spaces > 100) return position;
            return position += spaces;
        }
    }
}