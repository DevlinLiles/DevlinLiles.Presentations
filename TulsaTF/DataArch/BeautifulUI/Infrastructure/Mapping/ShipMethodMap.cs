using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class ShipMethodMap : EntityTypeConfiguration<ShipMethod>
	{
		public ShipMethodMap()
		{
			// Primary Key
			this.HasKey(t => t.ShipMethodID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ShipMethod");
			this.Property(t => t.ShipMethodID).HasColumnName("ShipMethodID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ShipBase).HasColumnName("ShipBase");
			this.Property(t => t.ShipRate).HasColumnName("ShipRate");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

