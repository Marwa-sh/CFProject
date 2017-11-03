using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;

namespace Cf.Data
{
	///<summary>
	/// قاعدة المعطيات المركزية لنظام معلومات الصندوق التعاوني
	///</summary>
	public partial class Db : DataContext
	{
		#region Public constructors
		/// <summary>
		/// Creates an instance that represents a data context for the Cf database.
		/// </summary>
		/// <param name="cs">Holds the connection string of the Cf database.</param>
		public Db(string cs)
			: base(cs)
		{
		}

		/// <summary>
		/// Creates an instance that represents a data context for the Cf database.
		/// </summary>
		/// <param name="cs">Holds the connection string of the Cf database.</param>
		public Db()
			: base(ConfigurationManager.ConnectionStrings[@"CfDatabase"].ConnectionString)
		{
		}
		#endregion
    }
}
