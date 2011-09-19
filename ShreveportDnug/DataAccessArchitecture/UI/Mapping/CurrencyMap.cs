using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class CurrencyMap : EntityTypeConfiguration<Currency>
	{
		public CurrencyMap()
		{
			// Primary Key
			this.HasKey(t => t.CurrencyCode);

			// Properties
			this.Property(t => t.CurrencyCode)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(3);
				
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("Currency");
			this.Property(t => t.CurrencyCode).HasColumnName("CurrencyCode");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

