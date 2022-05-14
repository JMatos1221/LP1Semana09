namespace PlayerManager2
{
    internal class Program
    {
        private List<Player> players;
        private bool         running;
        private string       option;


        private static void Main(string[] args)
        {
            Program p = new();

            p.Run();
        }


        private void Run()
        {
            running = true;

            option = string.Empty;

            players = new List<Player>
                { new("Default 1", 0), new("Default 2", 0) };

            Console.WriteLine("Add a player => insert [name] [score]");
            Console.WriteLine("List players => list");

            Console.WriteLine("List players with a score higher than " +
                              "given amount => higher [minimum] (exclusive)");

            while (running)
            {
                option = Console.ReadLine().ToLower();

                string[] splitOption = option.Split();

                switch (splitOption[0])
                {
                    case "insert":
                        players.Add(new Player(splitOption[1],
                                               int.Parse(splitOption[2])));

                        break;

                    case "list":
                        PrintPlayers(players);

                        break;

                    case "higher":
                        int min = int.Parse(splitOption[1]);

                        IEnumerable<Player> higherPlayers =
                            GetPlayersWithScoreGreaterThan(players, min);

                        PrintPlayers(higherPlayers);

                        break;
                }
            }
        }


        public IEnumerable<Player> GetPlayersWithScoreGreaterThan(
            IEnumerable<Player> players, int min)
        {
            foreach (Player p in players)
                if (p.Score > min)
                    yield return p;
        }


        private void PrintPlayers(IEnumerable<Player> playersToPrint)
        {
            foreach (Player p in playersToPrint)
                Console.WriteLine($"Name: {p.Name}\tScore: {p.Score}");
        }
    }
}