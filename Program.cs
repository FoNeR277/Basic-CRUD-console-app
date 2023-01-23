namespace lab3
{
    class Program
    {
        static List<Game> games = new List<Game>();
        static void Main(string[] args)
        {
            Seed.CreateSeedData(games);
            games.Sort();
            // Interface
            Console.Title = "Game Stats App - Burlaka Bohdan";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome to my GameApp");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Display game list - 1");
                Console.WriteLine("Find game by Name - 2");
                Console.WriteLine("Add your own game - 3");
                Console.WriteLine("Edit game (finding by id of game) - 4");
                Console.WriteLine("Delete game (finding by id) - 5");
                Console.Write("what is your action: ");
                int keyOfChoice = Convert.ToInt16(Console.ReadLine());
                if (keyOfChoice == 1)
                {
                    foreach (var game in games)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{game.Id} {game.Name} Rank: {game.Rank}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Current players: {game.CurrentPlayers}");
                        Console.WriteLine($"Peak today: {game.PeakToday}");
                    }
                }
                else if(keyOfChoice == 2)
                {
                    Console.Write("Write name of game: ");
                    string name = Console.ReadLine();
                    GetByName(name);
                }
                else if (keyOfChoice == 3)
                {
                    Console.Write("Write id of game(only integer): ");
                    int gameid = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write name of game: ");
                    string name = Console.ReadLine();
                    Console.Write("Write game rank: ");
                    int rank = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write current players of game: ");
                    int currentPleyers = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write peak of game today: ");
                    int peakToday = Convert.ToInt16(Console.ReadLine());

                    Game game = new Game
                    {
                        Id = gameid,
                        Name = name,
                        Rank = rank,
                        CurrentPlayers = currentPleyers,
                        PeakToday = peakToday
                    };
                    AddGame(game);
                }
                else if (keyOfChoice == 4)
                {
                    Console.Write("Write id of game you want to edit: ");
                    int id = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write name of game: ");
                    string gameName = Console.ReadLine();
                    Console.Write("Write game rank: ");
                    int rank = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write name of game: ");
                    int currentPleyers = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Write peak of game today: ");
                    int peakToday = Convert.ToInt16(Console.ReadLine());

                    Game game = new Game
                    {
                        Name = gameName,
                        Rank = rank,
                        CurrentPlayers = currentPleyers,
                        PeakToday = peakToday
                    };
                    EditGame(game, id);
                }
                else if (keyOfChoice == 5)
                {
                    Console.Write("Write id of game you want to delete: ");
                    int id = Convert.ToInt16(Console.ReadLine());
                    DeleteGame(id);
                }
            }
            
        }
        
        // CRUD Methods
        public static void AddGame(Game game)
        {
            var gameid = games.Find(x => x.Id == game.Id);
            if (game is null || string.IsNullOrWhiteSpace(game.Name) || 
                string.IsNullOrWhiteSpace(game.Id.ToString()) || gameid != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I couldn't add this game!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            games.Add(game);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game successfully added!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void GetByName(string name)
        {
            var gname = games.FirstOrDefault(x => x.Name == name);
            if (gname is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game doesn't exist");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{gname.Id} {gname.Name} Rank:{gname.Rank}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Current players: {gname.CurrentPlayers}");
            Console.WriteLine($"Peak today: {gname.PeakToday}");
        }
        public static void EditGame(Game game, int id)
        {
            var gameById = games.FirstOrDefault(x => x.Id == id);
            if (gameById is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I couldn't find this game");
                Console.ForegroundColor = ConsoleColor.White;
            }

            gameById.Name = game.Name;
            gameById.Rank = game.Rank;
            gameById.CurrentPlayers = game.CurrentPlayers;
            gameById.PeakToday = game.PeakToday;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game successfully edited!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DeleteGame(int id)
        {
            var game = games.FirstOrDefault(x => x.Id == id);
            if (game is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game doesn't exist");
                Console.ForegroundColor = ConsoleColor.White;
            }
            games.Remove(game);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game successfully deleted!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}