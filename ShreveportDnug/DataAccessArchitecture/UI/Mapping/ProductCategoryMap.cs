using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
	{
		public ProductCategoryMap()
		{
			// Primary Key
			this.HasKey(t => t.ProductCategoryID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ProductCategory");
			this.Property(t => t.ProductCategoryID).HasColumnName("ProductCategoryID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

