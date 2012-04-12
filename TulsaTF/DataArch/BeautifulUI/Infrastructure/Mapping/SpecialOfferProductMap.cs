using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Infrastructure.Mapping
{
	public class SpecialOfferProductMap : EntityTypeConfiguration<SpecialOfferProduct>
	{
		public SpecialOfferProductMap()
		{
			// Primary Key
			this.HasKey(t => new { t.SpecialOfferID, t.ProductID });

			// Properties
			this.Property(t => t.SpecialOfferID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ProductID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("SpecialOfferProduct");
			this.Property(t => t.SpecialOfferID).HasColumnName("SpecialOfferID");
			this.Property(t => t.ProductID).HasColumnName("ProductID");
			this.Property(t => t.rowguid).HasColumnName("rowguid");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Product)
				.WithMany(t => t.SpecialOfferProducts)
				.HasForeignKey(d => d.ProductID);
				
			this.HasRequired(t => t.SpecialOffer)
				.WithMany(t => t.SpecialOfferProducts)
				.HasForeignKey(d => d.SpecialOfferID);
				
		}
	}
}

