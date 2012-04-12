using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class PurchaseOrderHeaderMap : EntityTypeConfiguration<PurchaseOrderHeader>
	{
		public PurchaseOrderHeaderMap()
		{
			// Primary Key
			this.HasKey(t => t.PurchaseOrderID);

			// Properties
			// Table & Column Mappings
			this.ToTable("PurchaseOrderHeader");
			this.Property(t => t.PurchaseOrderID).HasColumnName("PurchaseOrderID");
			this.Property(t => t.RevisionNumber).HasColumnName("RevisionNumber");
			this.Property(t => t.Status).HasColumnName("Status");
			this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
			this.Property(t => t.VendorID).HasColumnName("VendorID");
			this.Property(t => t.ShipMethodID).HasColumnName("ShipMethodID");
			this.Property(t => t.OrderDate).HasColumnName("OrderDate");
			this.Property(t => t.ShipDate).HasColumnName("ShipDate");
			this.Property(t => t.SubTotal).HasColumnName("SubTotal");
			this.Property(t => t.TaxAmt).HasColumnName("TaxAmt");
			this.Property(t => t.Freight).HasColumnName("Freight");
			this.Property(t => t.TotalDue).HasColumnName("TotalDue");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Employee)
				.WithMany(t => t.PurchaseOrderHeaders)
				.HasForeignKey(d => d.EmployeeID);
				
			this.HasRequired(t => t.ShipMethod)
				.WithMany(t => t.PurchaseOrderHeaders)
				.HasForeignKey(d => d.ShipMethodID);
				
			this.HasRequired(t => t.Vendor)
				.WithMany(t => t.PurchaseOrderHeaders)
				.HasForeignKey(d => d.VendorID);
				
		}
	}
}

