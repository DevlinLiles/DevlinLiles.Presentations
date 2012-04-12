using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class IllustrationMap : EntityTypeConfiguration<Illustration>
	{
		public IllustrationMap()
		{
			// Primary Key
			this.HasKey(t => t.IllustrationID);

			// Properties
			// Table & Column Mappings
			this.ToTable("Illustration");
			this.Property(t => t.IllustrationID).HasColumnName("IllustrationID");
			this.Property(t => t.Diagram).HasColumnName("Diagram");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

