using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Entities;

namespace Infrastructure.Mapping
{
	public class RecordedActivityMap : EntityTypeConfiguration<RecordedActivity>
	{
		public RecordedActivityMap()
		{
			// Primary Key
			this.HasKey(t => t.Id);

			// Properties
			this.Property(t => t.Description)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("RecordedActivity");
			this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.Activities).HasColumnName("Activities");
			this.Property(t => t.AdjustedPointValue).HasColumnName("AdjustedPointValue");
			this.Property(t => t.Date).HasColumnName("Date");
			this.Property(t => t.Description).HasColumnName("Description");
			this.Property(t => t.PointValue).HasColumnName("PointValue");
			this.Property(t => t.Activity_Id).HasColumnName("Activity_Id");
			this.Property(t => t.Employee_Id).HasColumnName("Employee_Id");

			// Relationships
			this.HasRequired(t => t.Activity)
				.WithMany(t => t.RecordedActivities)
				.HasForeignKey(d => d.Activity_Id);
				
			this.HasRequired(t => t.Employee)
				.WithMany(t => t.RecordedActivities)
				.HasForeignKey(d => d.Employee_Id);
				
		}
	}
}

