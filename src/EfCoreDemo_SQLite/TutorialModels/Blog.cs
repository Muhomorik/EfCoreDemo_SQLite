using System.Collections.Generic;

namespace EfCoreDemo_SQLite.TutorialModels
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}
