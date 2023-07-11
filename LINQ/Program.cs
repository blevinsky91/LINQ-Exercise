namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Video> videoGames = ListManager.Data();

            videoGames.OrderBy(x => x.Name.Length).ToList().ForEach(x => Console.WriteLine(x.Name));




        }
    }
}
