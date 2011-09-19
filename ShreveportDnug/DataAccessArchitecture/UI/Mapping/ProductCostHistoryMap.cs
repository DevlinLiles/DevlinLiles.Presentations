using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class ProductCostHistoryMap : EntityTypeConfiguration<ProductCostHistory>
	{
		public ProductCostHistoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ProductID, t.StartDate });

			// Properties
			this.Property(t => t.ProductID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ProductCostHistory");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.StandardCost).HasColumnName("StandardCost");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Product)
				.WithMany(t => t.ProductCostHistories)
				.HasForeignKey(d => d.ProductID);
				
		}
	}
}

