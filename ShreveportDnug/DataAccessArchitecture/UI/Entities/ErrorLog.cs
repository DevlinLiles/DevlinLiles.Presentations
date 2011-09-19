using System;
using System.Collections.Generic;

namespace UI.Entities
{
	public class ErrorLog
	{
		public int ErrorLogID { get; set; }
		public System.DateTime ErrorTime { get; set; }
		public string UserName { get; set; }
		public int ErrorNumber { get; set; }
		public Nullable<int> ErrorSeverity { get; set; }
		public Nullable<int> ErrorState { get; set; }
		public string ErrorProcedure { get; set; }
		public Nullable<int> ErrorLine { get; set; }
		public string ErrorMessage { get; set; }
	}
}

