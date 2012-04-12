using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class AddressTypeMap : EntityTypeConfiguration<AddressType>
	{
		public AddressTypeMap()
		{
			// Primary Key
			this.HasKey(t => t.AddressTypeID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("AddressType");
			this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

