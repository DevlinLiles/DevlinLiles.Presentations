using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
	public class Employee
	{
	    public Employee()
		{
			this.RecordedActivities = new List<RecordedActivity>();
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Name { get; set; }
		public string UserName { get; set; }
		public virtual ICollection<RecordedActivity> RecordedActivities { get; set; }
	}
}

