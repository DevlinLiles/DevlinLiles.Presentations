using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using EFCodeFirst.Domain;

namespace EFCodeFirst.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Product","Production");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("ProductID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Name).HasMaxLength(50).IsRequired();
            this.HasRequired(x => x.Category).WithRequiredPrincipal(x=>x.Product);
        }
    }
}