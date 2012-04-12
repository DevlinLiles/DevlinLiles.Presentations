using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class WorkOrderMap : EntityTypeConfiguration<WorkOrder>
	{
		public WorkOrderMap()
		{
			// Primary Key
			this.HasKey(t => t.WorkOrderID);

			// Properties
			// Table & Column Mappings
			this.ToTable("WorkOrder");
			this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.OrderQty).HasColumnName("OrderQty");
			this.Property(t => t.StockedQty).HasColumnName("StockedQty");
			this.Property(t => t.ScrappedQty).HasColumnName("ScrappedQty");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.DueDate).HasColumnName("DueDate");
			this.Property(t => t.ScrapReasonID).HasColumnName("ScrapReasonID");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Product)
				.WithMany(t => t.WorkOrders)
				.HasForeignKey(d => d.ProductID);
				
			this.HasOptional(t => t.ScrapReason)
				.WithMany(t => t.WorkOrders)
				.HasForeignKey(d => d.ScrapReasonID);
				
		}
	}
}

