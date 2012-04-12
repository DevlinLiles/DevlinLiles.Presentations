using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
	public class RecordedActivity
	{
		public int Id { get; set; }
		public int Activities { get; set; }
		public int AdjustedPointValue { get; set; }
		public System.DateTime Date { get; set; }
		public string Description { get; set; }
		public int PointValue { get; set; }
		public int Activity_Id { get; set; }
		public int Employee_Id { get; set; }
		public virtual Activity Activity { get; set; }
		public virtual Employee Employee { get; set; }
	}
}

