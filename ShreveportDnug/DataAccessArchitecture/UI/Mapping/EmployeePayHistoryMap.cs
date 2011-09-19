using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class EmployeePayHistoryMap : EntityTypeConfiguration<EmployeePayHistory>
	{
		public EmployeePayHistoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.EmployeeID, t.RateChangeDate });

			// Properties
			this.Property(t => t.EmployeeID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("EmployeePayHistory");
			this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
			this.Property(t => t.RateChangeDate).HasColumnName("RateChangeDate");
			this.Property(t => t.Rate).HasColumnName("Rate");
			this.Property(t => t.PayFrequency).HasColumnName("PayFrequency");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Employee)
				.WithMany(t => t.EmployeePayHistories)
				.HasForeignKey(d => d.EmployeeID);
				
		}
	}
}

