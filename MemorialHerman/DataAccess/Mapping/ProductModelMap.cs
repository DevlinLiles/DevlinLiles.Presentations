using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class ProductModelMap : EntityTypeConfiguration<ProductModel>
	{
		public ProductModelMap()
		{
			// Primary Key
			this.HasKey(t => t.ProductModelID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ProductModel");
			this.Property(t => t.ProductModelID).HasColumnName("ProductModelID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.CatalogDescription).HasColumnName("CatalogDescription");
			this.Property(t => t.Instructions).HasColumnName("Instructions");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

