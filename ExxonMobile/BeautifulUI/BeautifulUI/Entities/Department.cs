using System;
using System.Collections.Generic;

namespace BeautifulUI.Entities
{
	public class Department
	{
	    public Department()
		{
			this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
		}

		public short DepartmentID { get; set; }
		public string Name { get; set; }
		public string GroupName { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
	}
}

