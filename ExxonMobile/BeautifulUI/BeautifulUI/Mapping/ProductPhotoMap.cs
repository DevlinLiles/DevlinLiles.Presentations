using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BeautifulUI.Entities;

namespace BeautifulUI.Mapping
{
	public class ProductPhotoMap : EntityTypeConfiguration<ProductPhoto>
	{
		public ProductPhotoMap()
		{
			// Primary Key
			this.HasKey(t => t.ProductPhotoID);

			// Properties
			this.Property(t => t.ThumbnailPhotoFileName)
				.HasMaxLength(50);
				
			this.Property(t => t.LargePhotoFileName)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ProductPhoto");
			this.Property(t => t.ProductPhotoID).HasColumnName("ProductPhotoID");
			this.Property(t => t.ThumbNailPhoto).HasColumnName("ThumbNailPhoto");
			this.Property(t => t.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName");
			this.Property(t => t.LargePhoto).HasColumnName("LargePhoto");
			this.Property(t => t.LargePhotoFileName).HasColumnName("LargePhotoFileName");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}

