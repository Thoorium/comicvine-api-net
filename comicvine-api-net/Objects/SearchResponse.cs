using System.Collections.Generic;

namespace Thoorium.Comicvine.Objects
{
    public class SearchResponse : Response
    {
        public Result Results { get; set; }

        public class Result
        {
            public List<Character> Characters { get; set; }
            public List<Video> Videos { get; set; }
            public List<Episode> Episodes { get; set; }
            public List<Volume> Volumes { get; set; }
        }
    }
}