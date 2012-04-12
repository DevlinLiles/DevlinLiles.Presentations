using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class SalesTerritoryMap : EntityTypeConfiguration<SalesTerritory>
	{
		public SalesTerritoryMap()
		{
			// Primary Key
			this.HasKey(t => t.TerritoryID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.CountryRegionCode)
				.IsRequired()
				.HasMaxLength(3);
				
			this.Property(t => t.Group)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("SalesTerritory");
			this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.CountryRegionCode).HasColumnName("CountryRegionCode");
			this.Property(t => t.Group).HasColumnName("Group");
			this.Property(t => t.SalesYTD).HasColumnName("SalesYTD");
			this.Property(t => t.SalesLastYear).HasColumnName("SalesLastYear");
			this.Property(t => t.CostYTD).HasColumnName("CostYTD");
			this.Property(t => t.CostLastYear).HasColumnName("CostLastYear");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

