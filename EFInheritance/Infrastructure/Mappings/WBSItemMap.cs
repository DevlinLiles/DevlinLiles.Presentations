using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class WBSItemMap : EntityTypeConfiguration<WBSItem>
    {
        public WBSItemMap()
        {

            this.Map(x =>
                         {
                             x.MapInheritedProperties();
                             x.ToTable("WBSItems");
                             this.Property(c => c.Description).IsRequired();
                             this.HasMany(c => c.Activities).WithOptional();


                         });
        }
    }
}