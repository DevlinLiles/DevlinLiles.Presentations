using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}