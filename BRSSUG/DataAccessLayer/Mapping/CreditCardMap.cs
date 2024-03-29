using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class CreditCardMap : EntityTypeConfiguration<CreditCard>
	{
		public CreditCardMap()
		{
			// Primary Key
			this.HasKey(t => t.CreditCardID);

			// Properties
			this.Property(t => t.CardType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.CardNumber)
				.IsRequired()
				.HasMaxLength(25);
				
			// Table & Column Mappings
			this.ToTable("CreditCard");
			this.Property(t => t.CreditCardID).HasColumnName("CreditCardID");
			this.Property(t => t.CardType).HasColumnName("CardType");
			this.Property(t => t.CardNumber).HasColumnName("CardNumber");
			this.Property(t => t.ExpMonth).HasColumnName("ExpMonth");
			this.Property(t => t.ExpYear).HasColumnName("ExpYear");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

