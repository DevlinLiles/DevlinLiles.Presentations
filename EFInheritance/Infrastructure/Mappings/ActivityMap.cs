using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class ActivityMap : EntityTypeConfiguration<Activity>
    {
        public ActivityMap()
        {
            this.Property(x => x.WorkCompleted);
        }
    }
}