using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class ShiftMap : EntityTypeConfiguration<Shift>
	{
		public ShiftMap()
		{
			// Primary Key
			this.HasKey(t => t.ShiftID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("Shift");
			this.Property(t => t.ShiftID).HasColumnName("ShiftID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.StartTime).HasColumnName("StartTime");
			this.Property(t => t.EndTime).HasColumnName("EndTime");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

