using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class CurrencyRateMap : EntityTypeConfiguration<CurrencyRate>
	{
		public CurrencyRateMap()
		{
			// Primary Key
			this.HasKey(t => t.CurrencyRateID);

			// Properties
			this.Property(t => t.FromCurrencyCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(3);
				
			this.Property(t => t.ToCurrencyCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(3);
				
			// Table & Column Mappings
			this.ToTable("CurrencyRate");
			this.Property(t => t.CurrencyRateID).HasColumnName("CurrencyRateID");
			this.Property(t => t.CurrencyRateDate).HasColumnName("CurrencyRateDate");
			this.Property(t => t.FromCurrencyCode).HasColumnName("FromCurrencyCode");
			this.Property(t => t.ToCurrencyCode).HasColumnName("ToCurrencyCode");
			this.Property(t => t.AverageRate).HasColumnName("AverageRate");
			this.Property(t => t.EndOfDayRate).HasColumnName("EndOfDayRate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Currency)
				.WithMany(t => t.CurrencyRates)
				.HasForeignKey(d => d.FromCurrencyCode);
				
			this.HasRequired(t => t.Currency1)
				.WithMany(t => t.CurrencyRates1)
				.HasForeignKey(d => d.ToCurrencyCode);
				
		}
	}
}

