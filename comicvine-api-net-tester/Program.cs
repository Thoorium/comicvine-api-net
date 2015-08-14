using Thoorium.Comicvine.Api;

namespace comicvine_api_net_tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var comic = new Comicvine("");//Put your api key here
            var character = comic.GetCharacter("4005-1468");//DOOM
            var i = comic.GetIssue("4000-487843");//Secret Wars 2015 #1
        }
    }
}