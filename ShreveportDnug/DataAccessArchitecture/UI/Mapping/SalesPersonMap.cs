using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class SalesPersonMap : EntityTypeConfiguration<SalesPerson>
	{
		public SalesPersonMap()
		{
			// Primary Key
			this.HasKey(t => t.SalesPersonID);

			// Properties
			this.Property(t => t.SalesPersonID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("SalesPerson");
			this.Property(t => t.SalesPersonID).HasColumnName("SalesPersonID");
			this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
			this.Property(t => t.SalesQuota).HasColumnName("SalesQuota");
			this.Property(t => t.Bonus).HasColumnName("Bonus");
			this.Property(t => t.CommissionPct).HasColumnName("CommissionPct");
			this.Property(t => t.SalesYTD).HasColumnName("SalesYTD");
			this.Property(t => t.SalesLastYear).HasColumnName("SalesLastYear");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Employee)
				.WithOptional(t => t.SalesPerson);
				
			this.HasOptional(t => t.SalesTerritory)
				.WithMany(t => t.SalesPersons)
				.HasForeignKey(d => d.TerritoryID);
				
		}
	}
}

