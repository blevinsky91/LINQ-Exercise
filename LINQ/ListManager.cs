using System;
namespace LINQ
{
	public class ListManager
	{
		public static List<Video> Data()
		{
            List<Video> videoGames = new List<Video>();

            videoGames.Add(new Video { Name = "Halo", Console = "Xbox" });
            videoGames.Add(new Video { Name = "Forza", Console = "Xbox" });
            videoGames.Add(new Video { Name = "Fortnite", Console = "PS5" });
            videoGames.Add(new Video { Name = "Dead by Daylight", Console = "Mobile" });
            videoGames.Add(new Video { Name = "Gran Turismo", Console = "PS5" });
            videoGames.Add(new Video { Name = "Half life", Console = "Xbox" });
            videoGames.Add(new Video { Name = "Overwatch", Console = "PC" });
            videoGames.Add(new Video { Name = "Elden Ring", Console = "PC" });

            return videoGames;
        }
	}
}

