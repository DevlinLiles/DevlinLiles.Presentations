using System;
using System.Data.Entity;
using System.Linq;
using BusinessLogic;
using DataAccess.Mappings;
using DataAccess.QueryObjects;
using BusinessLogic.QueryObjects;

namespace DataAccess
{
    public class BlogContext : DbContext, IDbContext
    {
        public BlogContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BlogMapping());
            base.OnModelCreating(modelBuilder);
        }

        public void Refresh()
        {
            this.ChangeTracker.Entries().ToList().ForEach(x=>x.Reload());
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return this.Set<T>();
        }
    }
}
