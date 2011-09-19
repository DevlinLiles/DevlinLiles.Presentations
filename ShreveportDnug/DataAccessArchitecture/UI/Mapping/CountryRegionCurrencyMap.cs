using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class CountryRegionCurrencyMap : EntityTypeConfiguration<CountryRegionCurrency>
	{
		public CountryRegionCurrencyMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CountryRegionCode, t.CurrencyCode });

			// Properties
			this.Property(t => t.CountryRegionCode)
				.IsRequired()
				.HasMaxLength(3);
				
			this.Property(t => t.CurrencyCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(3);
				
			// Table & Column Mappings
			this.ToTable("CountryRegionCurrency");
			this.Property(t => t.CountryRegionCode).HasColumnName("CountryRegionCode");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.CountryRegion)
				.WithMany(t => t.CountryRegionCurrencies)
				.HasForeignKey(d => d.CountryRegionCode);
				
			this.HasRequired(t => t.Currency)
				.WithMany(t => t.CountryRegionCurrencies)
				.HasForeignKey(d => d.CurrencyCode);
				
		}
	}
}

