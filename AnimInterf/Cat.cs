namespace AnimInterf
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get; }


        public Cat()
        {
            NumberOfNipples = 8;
        }


        public override string Sound()
        {
            return "Miau";
        }
    }
}