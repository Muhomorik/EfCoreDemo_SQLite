﻿using System;
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

                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
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
