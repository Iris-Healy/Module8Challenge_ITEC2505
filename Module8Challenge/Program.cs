namespace VideoGames
{
    public class Program
    {
        //Main Method of Program
        public static void Main()
        {
            //Create New List of VideoGame objects Game
            List<VideoGame> games = new List<VideoGame>
            {
                new VideoGame {Name = "Hollow Knight", Genre = "Metroidvainia", Rating = 4.8},
                new VideoGame {Name = "Hollow Knight SilkSong", Genre = "Metroidvainia", Rating = 4.9},
                new VideoGame {Name = "Neon White", Genre = "Shooter", Rating = 4.5},
                new VideoGame {Name = "Overwatch", Genre = "Multiplayer", Rating = 3.2},
                new VideoGame {Name = "Rain World", Genre = "Exploration", Rating = 4.6},
                new VideoGame {Name = "STRAFTAT", Genre = "Shooter", Rating = 3.6},
                new VideoGame {Name = "Cruelty Squad", Genre = "Immersive Sim", Rating = 4.1},
                new VideoGame {Name = "Keep Talking and No one Explodes", Genre = "Puzzle", Rating = 3.9},
                new VideoGame {Name = "The Binding of Issac Rebirth", Genre = "Roguelike", Rating = 3.7},
                new VideoGame {Name = "Cobalt Core", Genre = "Roguelike", Rating = 3.8}
            };

            //LINQ query of games list to find games rated 4.0 or higher
            var topRatedGames = (from game in games
                                where game.Rating >= 4.0
                                select game).ToList();
            //LINQ query of sorted games to order them by name
            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

            //For loop through sorted games
            Console.WriteLine("Top Rated Games");
            foreach (var game in sortedGames)
            {
                Console.WriteLine($"Name: {game.Name} Genre: {game.Genre} Rating: {game.Rating}");
            }
        }
    }
}