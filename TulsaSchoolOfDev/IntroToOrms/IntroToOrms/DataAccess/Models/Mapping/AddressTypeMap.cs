using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Models.Mapping
{
    public class AddressTypeMap : EntityTypeConfiguration<AddressType>
    {
        public AddressTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AddressType", "Person");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
