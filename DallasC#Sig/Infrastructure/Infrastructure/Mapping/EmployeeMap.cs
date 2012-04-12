using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Entities;

namespace Infrastructure.Mapping
{
	public class EmployeeMap : EntityTypeConfiguration<Employee>
	{
		public EmployeeMap()
		{
			// Primary Key
			this.HasKey(t => t.Id);

			// Properties
			// Table & Column Mappings
			this.ToTable("Employees");
			this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.FirstName).HasColumnName("FirstName");
			this.Property(t => t.LastName).HasColumnName("LastName");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.UserName).HasColumnName("UserName");
		}
	}
}

