using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class CustomerAddressMap : EntityTypeConfiguration<CustomerAddress>
	{
		public CustomerAddressMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CustomerID, t.AddressID });

			// Properties
			this.Property(t => t.CustomerID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AddressID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("CustomerAddress");
			this.Property(t => t.CustomerID).HasColumnName("CustomerID");
			this.Property(t => t.AddressID).HasColumnName("AddressID");
			this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Address)
				.WithMany(t => t.CustomerAddresses)
				.HasForeignKey(d => d.AddressID);
				
			this.HasRequired(t => t.AddressType)
				.WithMany(t => t.CustomerAddresses)
				.HasForeignKey(d => d.AddressTypeID);
				
			this.HasRequired(t => t.Customer)
				.WithMany(t => t.CustomerAddresses)
				.HasForeignKey(d => d.CustomerID);
				
		}
	}
}

