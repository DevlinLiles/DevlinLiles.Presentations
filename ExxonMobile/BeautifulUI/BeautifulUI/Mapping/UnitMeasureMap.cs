using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class UnitMeasureMap : EntityTypeConfiguration<UnitMeasure>
	{
		public UnitMeasureMap()
		{
			// Primary Key
			this.HasKey(t => t.UnitMeasureCode);

			// Properties
			this.Property(t => t.UnitMeasureCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(3);
				
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("UnitMeasure");
			this.Property(t => t.UnitMeasureCode).HasColumnName("UnitMeasureCode");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

