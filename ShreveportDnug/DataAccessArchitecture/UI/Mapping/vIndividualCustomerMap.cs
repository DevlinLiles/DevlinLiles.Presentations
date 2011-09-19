using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class vIndividualCustomerMap : EntityTypeConfiguration<vIndividualCustomer>
	{
		public vIndividualCustomerMap()
		{
			// Primary Key
			this.HasKey(t => new { t.CustomerID, t.FirstName, t.LastName, t.EmailPromotion, t.AddressType, t.AddressLine1, t.City, t.StateProvinceName, t.PostalCode, t.CountryRegionName });

			// Properties
			this.Property(t => t.CustomerID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Title)
				.HasMaxLength(8);
				
			this.Property(t => t.FirstName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.MiddleName)
				.HasMaxLength(50);
				
			this.Property(t => t.LastName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.Suffix)
				.HasMaxLength(10);
				
			this.Property(t => t.Phone)
				.HasMaxLength(25);
				
			this.Property(t => t.EmailAddress)
				.HasMaxLength(50);
				
			this.Property(t => t.EmailPromotion)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AddressType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.AddressLine1)
				.IsRequired()
				.HasMaxLength(60);
				
			this.Property(t => t.AddressLine2)
				.HasMaxLength(60);
				
			this.Property(t => t.City)
				.IsRequired()
				.HasMaxLength(30);
				
			this.Property(t => t.StateProvinceName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.PostalCode)
				.IsRequired()
				.HasMaxLength(15);
				
			this.Property(t => t.CountryRegionName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("vIndividualCustomer");
			this.Property(t => t.CustomerID).HasColumnName("CustomerID");
			this.Property(t => t.Title).HasColumnName("Title");
			this.Property(t => t.FirstName).HasColumnName("FirstName");
			this.Property(t => t.MiddleName).HasColumnName("MiddleName");
			this.Property(t => t.LastName).HasColumnName("LastName");
			this.Property(t => t.Suffix).HasColumnName("Suffix");
			this.Property(t => t.Phone).HasColumnName("Phone");
			this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
			this.Property(t => t.EmailPromotion).HasColumnName("EmailPromotion");
			this.Property(t => t.AddressType).HasColumnName("AddressType");
			this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
			this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.StateProvinceName).HasColumnName("StateProvinceName");
			this.Property(t => t.PostalCode).HasColumnName("PostalCode");
			this.Property(t => t.CountryRegionName).HasColumnName("CountryRegionName");
			this.Property(t => t.Demographics).HasColumnName("Demographics");
		}
	}
}

