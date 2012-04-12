using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infrastructure.Mapping;

namespace Infrastructure
{
	public class AdventureWorksContext : DbContext
	{
		static AdventureWorksContext()
		{ 
			Database.SetInitializer<AdventureWorksContext>(null);
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
			
			modelBuilder.Configurations.Add(new ProductMap());
			
		}
	}
}

