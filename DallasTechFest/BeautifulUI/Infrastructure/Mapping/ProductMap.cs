using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Domain.Entities;

namespace Infrastructure.Mapping
{
	public class ProductMap : EntityTypeConfiguration<Product>
	{
		public ProductMap()
		{
			// Primary Key
			this.HasKey(t => t.Id);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ProductNumber)
				.IsRequired()
				.HasMaxLength(25);
				
			this.Property(t => t.Color)
				.HasMaxLength(15);
				
			this.Property(t => t.Size)
				.HasMaxLength(5);
				
			this.Property(t => t.SizeUnitMeasureCode)
				.IsFixedLength()
				.HasMaxLength(3);
				
			this.Property(t => t.WeightUnitMeasureCode)
				.IsFixedLength()
				.HasMaxLength(3);
				
			this.Property(t => t.ProductLine)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.Class)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.Style)
				.IsFixedLength()
				.HasMaxLength(2);
				
			// Table & Column Mappings
			this.ToTable("Product","Production");
			this.Property(t => t.Id).HasColumnName("ProductID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ProductNumber).HasColumnName("ProductNumber");
			this.Property(t => t.MakeFlag).HasColumnName("MakeFlag");
			this.Property(t => t.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag");
			this.Property(t => t.Color).HasColumnName("Color");
			this.Property(t => t.SafetyStockLevel).HasColumnName("SafetyStockLevel");
			this.Property(t => t.ReorderPoint).HasColumnName("ReorderPoint");
			this.Property(t => t.StandardCost).HasColumnName("StandardCost");
			this.Property(t => t.ListPrice).HasColumnName("ListPrice");
			this.Property(t => t.Size).HasColumnName("Size");
			this.Property(t => t.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode");
			this.Property(t => t.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode");
			this.Property(t => t.Weight).HasColumnName("Weight");
			this.Property(t => t.DaysToManufacture).HasColumnName("DaysToManufacture");
			this.Property(t => t.ProductLine).HasColumnName("ProductLine");
			this.Property(t => t.Class).HasColumnName("Class");
			this.Property(t => t.Style).HasColumnName("Style");
			this.Property(t => t.ProductSubcategoryID).HasColumnName("ProductSubcategoryID");
			this.Property(t => t.ProductModelID).HasColumnName("ProductModelID");
			this.Property(t => t.SellStartDate).HasColumnName("SellStartDate");
			this.Property(t => t.SellEndDate).HasColumnName("SellEndDate");
			this.Property(t => t.DiscontinuedDate).HasColumnName("DiscontinuedDate");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

