using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using EFCodeFirst.Domain;

namespace EFCodeFirst.Mapping
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            this.ToTable("Product","Production");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("ProductID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}