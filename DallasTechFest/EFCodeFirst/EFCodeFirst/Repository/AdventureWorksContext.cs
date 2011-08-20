using System.Data.Entity;
using EFCodeFirst.Domain;
using EFCodeFirst.Mapping;

namespace EFCodeFirst.Repository
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; } 
    }
}