namespace UncommonWords.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using System.Web.Configuration;

    internal sealed class Configuration : DbMigrationsConfiguration<UncommonWords.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UncommonWords.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var store = new UserStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);
            if (!(context.Users.Any(u => u.UserName == "michael.null@bpmw.net")))
            {
                string password = WebConfigurationManager.AppSettings["password"];
                var user = new ApplicationUser { UserName = "michael.null@bpmw.net" };
                manager.Create(user, password);
            }

            context.Items.AddOrUpdate(
                s=>s.Spelling,
                new Item { Spelling = "the", Rank =1 },
                new Item { Spelling = "be", Rank = 2},
                new Item { Spelling = "to", Rank = 3},
                new Item { Spelling = "of", Rank = 4},
                new Item { Spelling = "and", Rank = 5},
                new Item { Spelling = "a", Rank = 6},
                new Item { Spelling = "in", Rank = 7},
                new Item { Spelling = "that", Rank = 8},
                new Item { Spelling = "have", Rank = 9},
                new Item { Spelling = "i", Rank = 10},
                new Item { Spelling = "it", Rank = 11 },
                new Item { Spelling = "for", Rank = 12 },
                new Item { Spelling = "not", Rank = 13 },
                new Item { Spelling = "on", Rank = 14 },
                new Item { Spelling = "with", Rank = 15 },
                new Item { Spelling = "he", Rank = 16 },
                new Item { Spelling = "as", Rank = 17 },
                new Item { Spelling = "you", Rank = 18 },
                new Item { Spelling = "do", Rank = 19 },
                new Item { Spelling = "at", Rank = 20 },
                new Item { Spelling = "this", Rank = 21 },
                new Item { Spelling = "but", Rank = 22 },
                new Item { Spelling = "his", Rank = 23 },
                new Item { Spelling = "by", Rank = 24 },
                new Item { Spelling = "from", Rank = 25 },
                new Item { Spelling = "they", Rank = 26 },
                new Item { Spelling = "we", Rank = 27 },
                new Item { Spelling = "say", Rank = 28 },
                new Item { Spelling = "her", Rank = 29 },
                new Item { Spelling = "she", Rank = 30 },
                new Item { Spelling = "or", Rank = 31 },
                new Item { Spelling = "an", Rank = 32 },
                new Item { Spelling = "will", Rank = 33 },
                new Item { Spelling = "my", Rank = 34 },
                new Item { Spelling = "one", Rank = 35 },
                new Item { Spelling = "all", Rank = 36 },
                new Item { Spelling = "would", Rank = 37 },
                new Item { Spelling = "there", Rank = 38 },
                new Item { Spelling = "their", Rank = 39 },
                new Item { Spelling = "what", Rank = 40 },
                new Item { Spelling = "so", Rank = 41 },
                new Item { Spelling = "up", Rank = 42 },
                new Item { Spelling = "out", Rank = 43 },
                new Item { Spelling = "if", Rank = 44 },
                new Item { Spelling = "about", Rank = 45 },
                new Item { Spelling = "who", Rank = 46 },
                new Item { Spelling = "get", Rank = 47 },
                new Item { Spelling = "which", Rank = 48 },
                new Item { Spelling = "go", Rank = 49 },
                new Item { Spelling = "me", Rank = 50 },
                new Item { Spelling = "when", Rank = 51 },
                new Item { Spelling = "make", Rank = 52 },
                new Item { Spelling = "can", Rank = 53 },
                new Item { Spelling = "like", Rank = 54 },
                new Item { Spelling = "time", Rank = 55 },
                new Item { Spelling = "no", Rank = 56 },
                new Item { Spelling = "just", Rank = 57 },
                new Item { Spelling = "him", Rank = 58 },
                new Item { Spelling = "know", Rank = 59 },
                new Item { Spelling = "take", Rank = 60 },
                new Item { Spelling = "people", Rank = 61 },
                new Item { Spelling = "into", Rank = 62 },
                new Item { Spelling = "year", Rank = 63 },
                new Item { Spelling = "your", Rank = 64 },
                new Item { Spelling = "good", Rank = 65 },
                new Item { Spelling = "some", Rank = 66 },
                new Item { Spelling = "could", Rank = 67 },
                new Item { Spelling = "them", Rank = 68 },
                new Item { Spelling = "see", Rank = 69 },
                new Item { Spelling = "other", Rank = 70 },
                new Item { Spelling = "than", Rank = 71 },
                new Item { Spelling = "then", Rank = 72 },
                new Item { Spelling = "now", Rank = 73 },
                new Item { Spelling = "look", Rank = 74 },
                new Item { Spelling = "only", Rank = 75 },
                new Item { Spelling = "come", Rank = 76 },
                new Item { Spelling = "its", Rank = 77 },
                new Item { Spelling = "over", Rank = 78 },
                new Item { Spelling = "think", Rank = 79 },
                new Item { Spelling = "also", Rank = 80 },
                new Item { Spelling = "back", Rank = 81 },
                new Item { Spelling = "after", Rank = 82 },
                new Item { Spelling = "use", Rank = 83 },
                new Item { Spelling = "two", Rank = 84 },
                new Item { Spelling = "how", Rank = 85 },
                new Item { Spelling = "our", Rank = 86 },
                new Item { Spelling = "work", Rank = 87 },
                new Item { Spelling = "first", Rank = 88 },
                new Item { Spelling = "well", Rank = 89 },
                new Item { Spelling = "way", Rank = 90 },
                new Item { Spelling = "even", Rank = 91 },
                new Item { Spelling = "new", Rank = 92 },
                new Item { Spelling = "want", Rank = 93 },
                new Item { Spelling = "because", Rank = 94 },
                new Item { Spelling = "any", Rank = 95 },
                new Item { Spelling = "these", Rank = 96 },
                new Item { Spelling = "give", Rank = 97 },
                new Item { Spelling = "day", Rank = 98 },
                new Item { Spelling = "most", Rank = 99 },
                new Item { Spelling = "us", Rank = 100 }
                );
        }
    }
}