using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location", "Production");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CostRate).HasColumnName("CostRate");
            this.Property(t => t.Availability).HasColumnName("Availability");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
