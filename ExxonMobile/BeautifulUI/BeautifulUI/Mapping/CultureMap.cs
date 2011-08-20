using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class CultureMap : EntityTypeConfiguration<Culture>
	{
		public CultureMap()
		{
			// Primary Key
			this.HasKey(t => t.CultureID);

			// Properties
			this.Property(t => t.CultureID)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(6);
				
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("Culture");
			this.Property(t => t.CultureID).HasColumnName("CultureID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

