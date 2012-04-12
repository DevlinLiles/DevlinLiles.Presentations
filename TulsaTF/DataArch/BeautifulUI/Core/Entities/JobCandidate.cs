using System;
using System.Collections.Generic;

namespace Core.Entities
{
	public class JobCandidate
	{
		public int JobCandidateID { get; set; }
		public Nullable<int> EmployeeID { get; set; }
		public string Resume { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual Employee Employee { get; set; }
	}
}

