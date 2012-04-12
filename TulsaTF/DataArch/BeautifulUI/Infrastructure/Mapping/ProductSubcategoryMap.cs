using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class ProductSubcategoryMap : EntityTypeConfiguration<ProductSubcategory>
	{
		public ProductSubcategoryMap()
		{
			// Primary Key
			this.HasKey(t => t.ProductSubcategoryID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ProductSubcategory");
			this.Property(t => t.ProductSubcategoryID).HasColumnName("ProductSubcategoryID");
			this.Property(t => t.ProductCategoryID).HasColumnName("ProductCategoryID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.ProductCategory)
				.WithMany(t => t.ProductSubcategories)
				.HasForeignKey(d => d.ProductCategoryID);
				
		}
	}
}

