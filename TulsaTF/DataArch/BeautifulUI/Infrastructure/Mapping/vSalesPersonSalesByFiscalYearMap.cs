using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class vSalesPersonSalesByFiscalYearMap : EntityTypeConfiguration<vSalesPersonSalesByFiscalYear>
	{
		public vSalesPersonSalesByFiscalYearMap()
		{
			// Primary Key
			this.HasKey(t => new { t.Title, t.SalesTerritory });

			// Properties
			this.Property(t => t.FullName)
				.HasMaxLength(152);
				
			this.Property(t => t.Title)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.SalesTerritory)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("vSalesPersonSalesByFiscalYears");
			this.Property(t => t.SalesPersonID).HasColumnName("SalesPersonID");
			this.Property(t => t.FullName).HasColumnName("FullName");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.SalesTerritory).HasColumnName("SalesTerritory");
			this.Property(t => t.C2002).HasColumnName("2002");
			this.Property(t => t.C2003).HasColumnName("2003");
			this.Property(t => t.C2004).HasColumnName("2004");
		}
	}
}

