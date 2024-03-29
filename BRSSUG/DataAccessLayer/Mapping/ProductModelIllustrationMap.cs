using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class ProductModelIllustrationMap : EntityTypeConfiguration<ProductModelIllustration>
	{
		public ProductModelIllustrationMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ProductModelID, t.IllustrationID });

			// Properties
			this.Property(t => t.ProductModelID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IllustrationID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ProductModelIllustration");
			this.Property(t => t.ProductModelID).HasColumnName("ProductModelID");
			this.Property(t => t.IllustrationID).HasColumnName("IllustrationID");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Illustration)
				.WithMany(t => t.ProductModelIllustrations)
				.HasForeignKey(d => d.IllustrationID);
				
			this.HasRequired(t => t.ProductModel)
				.WithMany(t => t.ProductModelIllustrations)
				.HasForeignKey(d => d.ProductModelID);
				
		}
	}
}

