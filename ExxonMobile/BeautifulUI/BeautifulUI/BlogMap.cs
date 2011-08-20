using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BeautifulUI
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            this.ToTable("Blogs");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("BlogId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Title).HasMaxLength(125).IsRequired();
            this.HasMany(x => x.Posts);
            this.Property(x => x.CreationDate).HasColumnType("date").IsRequired();
        }
    }
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.ToTable("Posts");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("PostId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }
    }
}