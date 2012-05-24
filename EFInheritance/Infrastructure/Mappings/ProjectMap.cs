using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace Infrastructure.Mappings
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            this.Map(x =>
                         {
                             x.Properties(p => p.ProjectName);
                             x.ToTable("Projects");
                             this.Property(c => c.ProjectName).IsRequired();
                             this.HasMany(c => c.Buildings).WithRequired(c=> c.Project);
                         });
            
        }
    }
}