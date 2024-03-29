using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class TransactionHistoryMap : EntityTypeConfiguration<TransactionHistory>
	{
		public TransactionHistoryMap()
		{
			// Primary Key
			this.HasKey(t => t.TransactionID);

			// Properties
			this.Property(t => t.TransactionType)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(1);
				
			// Table & Column Mappings
			this.ToTable("TransactionHistory");
			this.Property(t => t.TransactionID).HasColumnName("TransactionID");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.ReferenceOrderID).HasColumnName("ReferenceOrderID");
			this.Property(t => t.ReferenceOrderLineID).HasColumnName("ReferenceOrderLineID");
			this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
			this.Property(t => t.TransactionType).HasColumnName("TransactionType");
			this.Property(t => t.Quantity).HasColumnName("Quantity");
			this.Property(t => t.ActualCost).HasColumnName("ActualCost");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Product)
				.WithMany(t => t.TransactionHistories)
				.HasForeignKey(d => d.ProductID);
				
		}
	}
}

