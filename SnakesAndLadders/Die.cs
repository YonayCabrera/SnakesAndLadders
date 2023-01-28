namespace SnamesAndLadders
{
    public class Die
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}