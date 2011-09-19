using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class vEmployeeDepartmentMap : EntityTypeConfiguration<vEmployeeDepartment>
	{
		public vEmployeeDepartmentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.EmployeeID, t.FirstName, t.LastName, t.JobTitle, t.Department, t.GroupName, t.StartDate });

			// Properties
			this.Property(t => t.EmployeeID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Title)
				.HasMaxLength(8);
				
			this.Property(t => t.FirstName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.MiddleName)
				.HasMaxLength(50);
				
			this.Property(t => t.LastName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.Suffix)
				.HasMaxLength(10);
				
			this.Property(t => t.JobTitle)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.Department)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.GroupName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("vEmployeeDepartment");
			this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.FirstName).HasColumnName("FirstName");
			this.Property(t => t.MiddleName).HasColumnName("MiddleName");
			this.Property(t => t.LastName).HasColumnName("LastName");
			this.Property(t => t.Suffix).HasColumnName("Suffix");
			this.Property(t => t.JobTitle).HasColumnName("JobTitle");
			this.Property(t => t.Department).HasColumnName("Department");
			this.Property(t => t.GroupName).HasColumnName("GroupName");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
		}
	}
}

