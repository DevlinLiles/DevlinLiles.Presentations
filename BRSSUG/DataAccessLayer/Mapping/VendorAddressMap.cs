using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class VendorAddressMap : EntityTypeConfiguration<VendorAddress>
	{
		public VendorAddressMap()
		{
			// Primary Key
			this.HasKey(t => new { t.VendorID, t.AddressID });

			// Properties
			this.Property(t => t.VendorID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AddressID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VendorAddress");
			this.Property(t => t.VendorID).HasColumnName("VendorID");
			this.Property(t => t.AddressID).HasColumnName("AddressID");
			this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Address)
				.WithMany(t => t.VendorAddresses)
				.HasForeignKey(d => d.AddressID);
				
			this.HasRequired(t => t.AddressType)
				.WithMany(t => t.VendorAddresses)
				.HasForeignKey(d => d.AddressTypeID);
				
			this.HasRequired(t => t.Vendor)
				.WithMany(t => t.VendorAddresses)
				.HasForeignKey(d => d.VendorID);
				
		}
	}
}

