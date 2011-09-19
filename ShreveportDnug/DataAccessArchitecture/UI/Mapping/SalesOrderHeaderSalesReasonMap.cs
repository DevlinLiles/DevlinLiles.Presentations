using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class SalesOrderHeaderSalesReasonMap : EntityTypeConfiguration<SalesOrderHeaderSalesReason>
	{
		public SalesOrderHeaderSalesReasonMap()
		{
			// Primary Key
			this.HasKey(t => new { t.SalesOrderID, t.SalesReasonID });

			// Properties
			this.Property(t => t.SalesOrderID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SalesReasonID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("SalesOrderHeaderSalesReason");
			this.Property(t => t.SalesOrderID).HasColumnName("SalesOrderID");
			this.Property(t => t.SalesReasonID).HasColumnName("SalesReasonID");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.SalesOrderHeader)
				.WithMany(t => t.SalesOrderHeaderSalesReasons)
				.HasForeignKey(d => d.SalesOrderID);
				
			this.HasRequired(t => t.SalesReason)
				.WithMany(t => t.SalesOrderHeaderSalesReasons)
				.HasForeignKey(d => d.SalesReasonID);
				
		}
	}
}

