using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class BuildingMap : EntityTypeConfiguration<Building>
    {
        public BuildingMap()
        {
            this.ToTable("Buildings");
            this.Property(c => c.Address).IsRequired();
        } 
    }
}