using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
	public class Activity
	{
	    public Activity()
		{
			this.RecordedActivities = new List<RecordedActivity>();
		}

		public int Id { get; set; }
		public string Category { get; set; }
		public int PointsPerActivity { get; set; }
		public string Type { get; set; }
		public virtual ICollection<RecordedActivity> RecordedActivities { get; set; }
	}
}

