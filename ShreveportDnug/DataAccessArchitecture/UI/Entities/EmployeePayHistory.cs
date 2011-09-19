using System;
using System.Collections.Generic;

namespace UI.Entities
{
	public class EmployeePayHistory
	{
		public int EmployeeID { get; set; }
		public System.DateTime RateChangeDate { get; set; }
		public decimal Rate { get; set; }
		public byte PayFrequency { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual Employee Employee { get; set; }
	}
}

