namespace AnimInterf
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get; }


        public Dog()
        {
            NumberOfNipples = 8;
        }


        public override string Sound()
        {
            return "Woof!";
        }
    }
}