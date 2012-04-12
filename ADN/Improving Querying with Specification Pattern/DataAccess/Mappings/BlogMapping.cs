using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using BusinessLogic;

namespace DataAccess.Mappings
{
    public class BlogMapping : EntityTypeConfiguration<Blog>
    {
        public BlogMapping()
        {
            this.ToTable("Blogs");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("BlogId");

            this.Property(x => x.Title).IsRequired().HasMaxLength(250);
            this.Property(x => x.Creationdate).HasColumnName("CreationDate").IsRequired();
            this.Property(x => x.ShortDescription).HasColumnType("Text").IsMaxLength().IsOptional().HasColumnName("Description");
       }

    }
}