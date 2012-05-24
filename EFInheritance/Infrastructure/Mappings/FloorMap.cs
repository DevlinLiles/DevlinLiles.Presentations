using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class FloorMap : EntityTypeConfiguration<Floor>
    {
        public FloorMap()
        {
            this.Map(x =>
                         {
                             x.Properties(p => p.FloorNumber);
                             x.ToTable("Floors");
                             this.Property(c => c.FloorNumber).IsRequired();
                         });
            
        }
    }
}