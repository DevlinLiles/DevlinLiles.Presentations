using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class ProductDescriptionMap : EntityTypeConfiguration<ProductDescription>
	{
		public ProductDescriptionMap()
		{
			// Primary Key
			this.HasKey(t => t.ProductDescriptionID);

			// Properties
			this.Property(t => t.Description)
				.IsRequired()
				.HasMaxLength(400);
				
			// Table & Column Mappings
			this.ToTable("ProductDescription");
			this.Property(t => t.ProductDescriptionID).HasColumnName("ProductDescriptionID");
			this.Property(t => t.Description).HasColumnName("Description");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

