using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyCode);

            // Properties
            this.Property(t => t.CurrencyCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Currency", "Sales");
            this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
