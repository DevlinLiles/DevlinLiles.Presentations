using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Entities;

namespace Infrastructure.Mapping
{
	public class ActivityMap : EntityTypeConfiguration<Activity>
	{
		public ActivityMap()
		{
			// Primary Key
			this.HasKey(t => t.Id);

			// Properties
			// Table & Column Mappings
			this.ToTable("Activities");
			this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.Category).HasColumnName("Category");
			this.Property(t => t.PointsPerActivity).HasColumnName("PointsPerActivity");
			this.Property(t => t.Type).HasColumnName("Type");
		}
	}
}

