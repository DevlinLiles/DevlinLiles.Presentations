using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class SalesTerritoryHistoryMap : EntityTypeConfiguration<SalesTerritoryHistory>
	{
		public SalesTerritoryHistoryMap()
		{
			// Primary Key
			this.HasKey(t => new { t.SalesPersonID, t.TerritoryID, t.StartDate });

			// Properties
			this.Property(t => t.SalesPersonID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.TerritoryID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("SalesTerritoryHistory");
			this.Property(t => t.SalesPersonID).HasColumnName("SalesPersonID");
			this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.SalesPerson)
				.WithMany(t => t.SalesTerritoryHistories)
				.HasForeignKey(d => d.SalesPersonID);
				
			this.HasRequired(t => t.SalesTerritory)
				.WithMany(t => t.SalesTerritoryHistories)
				.HasForeignKey(d => d.TerritoryID);
				
		}
	}
}

