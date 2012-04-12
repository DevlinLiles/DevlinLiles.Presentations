using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class ProductModelProductDescriptionCultureMap : EntityTypeConfiguration<ProductModelProductDescriptionCulture>
	{
		public ProductModelProductDescriptionCultureMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ProductModelID, t.ProductDescriptionID, t.CultureID });

			// Properties
			this.Property(t => t.ProductModelID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ProductDescriptionID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CultureID)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(6);
				
			// Table & Column Mappings
			this.ToTable("ProductModelProductDescriptionCulture");
			this.Property(t => t.ProductModelID).HasColumnName("ProductModelID");
			this.Property(t => t.ProductDescriptionID).HasColumnName("ProductDescriptionID");
			this.Property(t => t.CultureID).HasColumnName("CultureID");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Culture)
				.WithMany(t => t.ProductModelProductDescriptionCultures)
				.HasForeignKey(d => d.CultureID);
				
			this.HasRequired(t => t.ProductDescription)
				.WithMany(t => t.ProductModelProductDescriptionCultures)
				.HasForeignKey(d => d.ProductDescriptionID);
				
			this.HasRequired(t => t.ProductModel)
				.WithMany(t => t.ProductModelProductDescriptionCultures)
				.HasForeignKey(d => d.ProductModelID);
				
		}
	}
}

