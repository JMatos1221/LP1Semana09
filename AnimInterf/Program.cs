namespace AnimInterf // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new();

            Animal[] animals = new Animal[10];

            for (int i = 0; i < animals.Length; i++)
            {
                int randomNumber = rnd.Next(0, 4);

                animals[i] = randomNumber switch
                {
                    0 => new Dog(),
                    1 => new Cat(),
                    2 => new Bat(),
                    3 => new Bee(),
                    _ => new Dog()
                };
            }

            string output;

            for (int i = 0; i < animals.Length; i++)
            {
                output = animals[i].Sound();

                if (animals[i] is IMammal)
                {
                    IMammal mammal = animals[i] as IMammal;

                    output += $" Number of nipples: {mammal.NumberOfNipples}";
                }

                if (animals[i] is ICanFly)
                {
                    ICanFly canFly = animals[i] as ICanFly;

                    output += $" Number of wings: {canFly.NumberOfWings}";
                }

                Console.WriteLine(output);
            }
        }
    }
}