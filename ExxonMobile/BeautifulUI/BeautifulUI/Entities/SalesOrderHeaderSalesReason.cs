using System;
using System.Collections.Generic;

namespace BeautifulUI.Entities
{
	public class SalesOrderHeaderSalesReason
	{
		public int SalesOrderID { get; set; }
		public int SalesReasonID { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual SalesOrderHeader SalesOrderHeader { get; set; }
		public virtual SalesReason SalesReason { get; set; }
	}
}

