namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Video Game List:\n");
            var videoGameNames = new List<string>()
            {
                "Stronghold Legends",
                "Ultimate Spiderman",
                "Age of Wonders 4",
                "Ark Survival Evolved",
                "Dragon Age Inquisition",
                "Deus Ex Human Revolution",
                "Dishonored 2",
                "Dark Souls 3",
                "The Elder Scrolls V: Skyrim",
                "Fallout 3",
                "Tainted Grail The Fall of Avalon"
            };

            var orderedVideoGames = videoGameNames.OrderBy(videoGameNames => videoGameNames.Length).ToList();
            orderedVideoGames.ForEach(game => Console.WriteLine(game));
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Movie List:\n");

            var movieNames = new List<string>()
            {
                "Iron Man",
                "Spiderman",
                "The Godfather",
                "The Birds",
                "Star Wars: Rogue One",
                "Avatar",
                "Back to the Future",
                "Gladiator",
                "Lelo and Stitch",
            };
            
            var orderedMovieNames = movieNames.OrderBy(movieName => movieName.Length).ToList();
            orderedMovieNames.ForEach(movieName => Console.WriteLine(movieName));
        }
    }
}
