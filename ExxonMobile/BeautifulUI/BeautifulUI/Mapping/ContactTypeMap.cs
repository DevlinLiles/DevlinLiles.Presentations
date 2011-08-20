using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class ContactTypeMap : EntityTypeConfiguration<ContactType>
	{
		public ContactTypeMap()
		{
			// Primary Key
			this.HasKey(t => t.ContactTypeID);

			// Properties
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ContactType");
			this.Property(t => t.ContactTypeID).HasColumnName("ContactTypeID");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

