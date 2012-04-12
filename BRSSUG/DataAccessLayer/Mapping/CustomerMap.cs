using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class CustomerMap : EntityTypeConfiguration<Customer>
	{
		public CustomerMap()
		{
			// Primary Key
			this.HasKey(t => t.CustomerID);

			// Properties
			this.Property(t => t.AccountNumber)
				.IsRequired()
				.HasMaxLength(10);
				
			this.Property(t => t.CustomerType)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(1);
				
			// Table & Column Mappings
			this.ToTable("Customer");
			this.Property(t => t.CustomerID).HasColumnName("CustomerID");
			this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
			this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
			this.Property(t => t.CustomerType).HasColumnName("CustomerType");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasOptional(t => t.SalesTerritory)
				.WithMany(t => t.Customers)
				.HasForeignKey(d => d.TerritoryID);
				
		}
	}
}

