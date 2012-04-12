using System;
using System.Data.Entity;
using BusinessLogic;

namespace DataAccess.Database
{

    public class Initializer : DropCreateDatabaseAlways<BlogContext>
    {
        public Initializer()
        {
            
        }
        protected override void Seed(BlogContext context)
        {
            context.Set<Blog>().Add(new Blog()
            {
                Creationdate = DateTime.Now,
                ShortDescription = "Testing",
                Title = "Test Blog"
            });
            context.Set<Blog>().Add(new Blog()
            {
                Creationdate = DateTime.Now,
                ShortDescription = "Testing",
                Title = "Test Blog 2"
            });
            context.Set<Blog>().Add(new Blog()
            {
                Creationdate = DateTime.Now,
                ShortDescription = "Testing",
                Title = "not Blog"
            });
            context.SaveChanges();
        }
    }
}
