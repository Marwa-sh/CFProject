using System;
using System.Configuration;

namespace Cf.Services
{
	///<summary>
	/// Encapsulates Cf.Data.Db class level methods
	///</summary>
    public static partial class DbServices
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CfDatabase"].ConnectionString;
            }
        }
    }    
}
