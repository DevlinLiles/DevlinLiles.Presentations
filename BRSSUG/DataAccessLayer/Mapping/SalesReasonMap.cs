using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Mapping
{
	public class SalesReasonMap : EntityTypeConfiguration<SalesReason>
	{
		public SalesReasonMap()
		{
			// Primary Key
			this.HasKey(t => t.SalesReasonID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ReasonType)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("SalesReason");
			this.Property(t => t.SalesReasonID).HasColumnName("SalesReasonID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ReasonType).HasColumnName("ReasonType");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

