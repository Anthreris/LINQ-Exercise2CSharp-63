namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
