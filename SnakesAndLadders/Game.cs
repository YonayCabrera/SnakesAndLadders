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
            return true;
        }

        public int MoveToken(int spaces)
        {
            return position += spaces;
        }
    }
}