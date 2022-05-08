namespace AnimInterf
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get; }
        public int NumberOfWings   { get; }


        public Bat()
        {
            NumberOfNipples = 2;
            NumberOfWings = 2;
        }


        public override string Sound()
        {
            return "Iiiii";
        }
    }
}