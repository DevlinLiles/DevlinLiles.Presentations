using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class CultureMap : EntityTypeConfiguration<Culture>
    {
        public CultureMap()
        {
            // Primary Key
            this.HasKey(t => t.CultureID);

            // Properties
            this.Property(t => t.CultureID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Culture", "Production");
            this.Property(t => t.CultureID).HasColumnName("CultureID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
