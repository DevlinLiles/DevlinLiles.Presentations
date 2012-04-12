using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
	public class CountryRegion
	{
	    public CountryRegion()
		{
			this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
			this.StateProvinces = new List<StateProvince>();
		}

		public string CountryRegionCode { get; set; }
		public string Name { get; set; }
		public System.DateTime ModifiedDate { get; set; }
		public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
		public virtual ICollection<StateProvince> StateProvinces { get; set; }
	}
}

