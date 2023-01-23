namespace lab3;

public static class Seed
{
    public static void CreateSeedData(List<Game> gamesList)
    {
        List<Game> games = new List<Game>
            {
                new Game()
                {
                    Id = 1,
                    Name = "Counter-Strike: Global Offensive",
                    Rank = 1,
                    CurrentPlayers = 899639,
                    PeakToday = 970395
                },
                new Game()
                {
                    Id = 2,
                    Name = "Dota 2",
                    Rank = 2,
                    CurrentPlayers = 532537,
                    PeakToday = 633623
                },
                new Game()
                {
                    Id = 3,
                    Name = "Pubg",
                    Rank = 3,
                    CurrentPlayers = 207639,
                    PeakToday = 370395
                },
                new Game()
                {
                    Id = 4,
                    Name = "Apex Legends",
                    Rank = 4,
                    CurrentPlayers = 166629,
                    PeakToday = 385395
                },
                new Game()
                {
                    Id = 5,
                    Name = "Lost Ark",
                    Rank = 5,
                    CurrentPlayers = 138639,
                    PeakToday = 144395
                },
                new Game()
                {
                    Id = 6,
                    Name = "Grand Theft Auto V",
                    Rank = 6,
                    CurrentPlayers = 125195,
                    PeakToday = 149832
                },
                new Game()
                {
                    Id = 7,
                    Name = "Rust",
                    Rank = 7,
                    CurrentPlayers = 113532,
                    PeakToday = 142523
                },
                new Game()
                {
                    Id = 8,
                    Name = "Team Fortress 2",
                    Rank = 8,
                    CurrentPlayers = 109657,
                    PeakToday = 109657
                },
                new Game()
                {
                    Id = 9,
                    Name = "Call of Duty®: Modern Warfare® II",
                    Rank = 9,
                    CurrentPlayers = 96022,
                    PeakToday = 136250
                },
                new Game()
                {
                    Id = 10,
                    Name = "Goose Goose Duck",
                    Rank = 10,
                    CurrentPlayers = 93010,
                    PeakToday = 300362
                },
            };
        gamesList.AddRange(games);
    }
}