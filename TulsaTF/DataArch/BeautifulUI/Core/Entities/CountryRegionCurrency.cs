using System;
using System.Collections.Generic;

namespace Core.Entities
{
	public class CountryRegionCurrency
	{
		public string CountryRegionCode { get; set; }
		public string CurrencyCode { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual CountryRegion CountryRegion { get; set; }
		public virtual Currency Currency { get; set; }
	}
}

