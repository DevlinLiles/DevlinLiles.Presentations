using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Entities;

namespace UI.Mapping
{
	public class JobCandidateMap : EntityTypeConfiguration<JobCandidate>
	{
		public JobCandidateMap()
		{
			// Primary Key
			this.HasKey(t => t.JobCandidateID);

			// Properties
			// Table & Column Mappings
			this.ToTable("JobCandidate");
			this.Property(t => t.JobCandidateID).HasColumnName("JobCandidateID");
			this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
			this.Property(t => t.Resume).HasColumnName("Resume");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			this.HasOptional(t => t.Employee)
				.WithMany(t => t.JobCandidates)
				.HasForeignKey(d => d.EmployeeID);
				
		}
	}
}

