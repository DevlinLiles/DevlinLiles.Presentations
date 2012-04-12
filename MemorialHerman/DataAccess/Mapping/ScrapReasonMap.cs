using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class ScrapReasonMap : EntityTypeConfiguration<ScrapReason>
	{
		public ScrapReasonMap()
		{
			// Primary Key
			this.HasKey(t => t.ScrapReasonID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ScrapReason");
			this.Property(t => t.ScrapReasonID).HasColumnName("ScrapReasonID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

