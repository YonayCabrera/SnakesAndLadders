namespace SnamesAndLadders
{
    public class Die
    {
        public virtual int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}