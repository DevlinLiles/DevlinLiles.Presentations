using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class EmployeeDepartmentHistoryMap : EntityTypeConfiguration<EmployeeDepartmentHistory>
	{
		public EmployeeDepartmentHistoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.EmployeeID, t.DepartmentID, t.ShiftID, t.StartDate });

			// Properties
			this.Property(t => t.EmployeeID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("EmployeeDepartmentHistory");
			this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
			this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
			this.Property(t => t.ShiftID).HasColumnName("ShiftID");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Department)
				.WithMany(t => t.EmployeeDepartmentHistories)
				.HasForeignKey(d => d.DepartmentID);
				
			this.HasRequired(t => t.Employee)
				.WithMany(t => t.EmployeeDepartmentHistories)
				.HasForeignKey(d => d.EmployeeID);
				
			this.HasRequired(t => t.Shift)
				.WithMany(t => t.EmployeeDepartmentHistories)
				.HasForeignKey(d => d.ShiftID);
				
		}
	}
}

