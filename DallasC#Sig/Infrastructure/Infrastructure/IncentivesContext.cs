using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infrastructure.Entities;
using Infrastructure.Mapping;

namespace Infrastructure
{
	public class IncentivesContext : DbContext
	{
		static IncentivesContext()
		{ 
			Database.SetInitializer<IncentivesContext>(null);
		}

        /// <summary>
        /// Initializes a new instance of the IncentivesContext class.
        /// </summary>
        public IncentivesContext()
        {
            Activities = new List<Activity>();
            Employees = new List<Employee>();
            RecordedActivities = new List<RecordedActivity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new ActivityMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new RecordedActivityMap());
        }
    }
}

