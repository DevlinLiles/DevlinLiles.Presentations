using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataAccess.Entities;

namespace DataAccess.Mapping
{
	public class IndividualMap : EntityTypeConfiguration<Individual>
	{
		public IndividualMap()
		{
			// Primary Key
			this.HasKey(t => t.CustomerID);

			// Properties
			this.Property(t => t.CustomerID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("Individual");
			this.Property(t => t.CustomerID).HasColumnName("CustomerID");
			this.Property(t => t.ContactID).HasColumnName("ContactID");
			this.Property(t => t.Demographics).HasColumnName("Demographics");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasRequired(t => t.Contact)
				.WithMany(t => t.Individuals)
				.HasForeignKey(d => d.ContactID);
				
			this.HasRequired(t => t.Customer)
				.WithOptional(t => t.Individual);
				
		}
	}
}

