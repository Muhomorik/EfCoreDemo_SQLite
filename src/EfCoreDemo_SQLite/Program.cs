using System;
using EfCoreDemo_SQLite.TutorialModels;

namespace EfCoreDemo_SQLite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();

                var blog_1 = new Blog {Url = "http://blogs.msdn.com/adonet"};
                db.Blogs.Add(blog_1);

                //db.Posts.Add(new Post
                //{
                //    Blog = blog_1,
                //    BlogId = 1,
                //    Content = "Hello World",
                //    PostId = 1,
                //    Title = "Super title!"
                //});
                var count = db.SaveChanges();

                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
        }
    }
}
