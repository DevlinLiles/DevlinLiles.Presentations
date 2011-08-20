using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class DepartmentMap : EntityTypeConfiguration<Department>
	{
		public DepartmentMap()
		{
			// Primary Key
			this.HasKey(t => t.DepartmentID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.GroupName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("Department");
			this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.GroupName).HasColumnName("GroupName");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

