using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Core.Domain.Entities;
using Infrastructure.Mapping;

namespace Infrastructure
{
	public class AdventureWorksContext : DbContext
	{
		public AdventureWorksContext(string connectionString) :base(connectionString)
		{ 
			Database.SetInitializer<AdventureWorksContext>(null);
		}

		public DbSet<Product> Products { get; set; }
		
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            modelBuilder.Configurations.Add(new ProductMap());
			base.OnModelCreating(modelBuilder);
		}
	}
}

