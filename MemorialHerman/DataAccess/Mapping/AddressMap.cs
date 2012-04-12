using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class AddressMap : EntityTypeConfiguration<Address>
	{
		public AddressMap()
		{
			// Primary Key
			this.HasKey(t => t.AddressID);

			// Properties
			this.Property(t => t.AddressLine1)
				.IsRequired()
				.HasMaxLength(60);
				
			this.Property(t => t.AddressLine2)
				.HasMaxLength(60);
				
			this.Property(t => t.City)
				.IsRequired()
				.HasMaxLength(30);
				
			this.Property(t => t.PostalCode)
				.IsRequired()
				.HasMaxLength(15);
				
			// Table & Column Mappings
			this.ToTable("Address");
			this.Property(t => t.AddressID).HasColumnName("AddressID");
			this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
			this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.StateProvinceID).HasColumnName("StateProvinceID");
			this.Property(t => t.PostalCode).HasColumnName("PostalCode");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.StateProvince)
				.WithMany(t => t.Addresses)
				.HasForeignKey(d => d.StateProvinceID);
				
		}
	}
}

