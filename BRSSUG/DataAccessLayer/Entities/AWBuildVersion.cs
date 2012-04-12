using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
	public class AWBuildVersion
	{
		public byte SystemInformationID { get; set; }
		public string Database_Version { get; set; }
		public System.DateTime VersionDate { get; set; }
		public System.DateTime ModifiedDate { get; set; }
	}
}

