using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class ProductInventoryMap : EntityTypeConfiguration<ProductInventory>
	{
		public ProductInventoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ProductID, t.LocationID });

			// Properties
			this.Property(t => t.ProductID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Shelf)
				.IsRequired()
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("ProductInventory");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.LocationID).HasColumnName("LocationID");
			this.Property(t => t.Shelf).HasColumnName("Shelf");
			this.Property(t => t.Bin).HasColumnName("Bin");
			this.Property(t => t.Quantity).HasColumnName("Quantity");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Location)
				.WithMany(t => t.ProductInventories)
				.HasForeignKey(d => d.LocationID);
				
			this.HasRequired(t => t.Product)
				.WithMany(t => t.ProductInventories)
				.HasForeignKey(d => d.ProductID);
				
		}
	}
}

