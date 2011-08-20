using System;
using System.Collections.Generic;

namespace BeautifulUI.Entities
{
	public class ContactCreditCard
	{
		public int ContactID { get; set; }
		public int CreditCardID { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual Contact Contact { get; set; }
		public virtual CreditCard CreditCard { get; set; }
	}
}

