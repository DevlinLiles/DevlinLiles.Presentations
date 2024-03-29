using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class ProductDescriptionMap : EntityTypeConfiguration<ProductDescription>
    {
        public ProductDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductDescriptionID);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("ProductDescription", "Production");
            this.Property(t => t.ProductDescriptionID).HasColumnName("ProductDescriptionID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
