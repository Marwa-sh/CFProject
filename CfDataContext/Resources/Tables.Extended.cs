using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf.Data.Resources
{
	public partial class Employee
	{
		/// <summary>
		/// Looks up a localized string similar to FullName.
		/// </summary>
		public static string FullName
		{
			get
			{
				return ResourcesCollection.GetString(Culture, "Employee", "FullName");
			}
		}

		/// <summary>
		/// Looks up a localized string similar to FullNameTooltip.
		/// </summary>
		public static string FullNameTooltip
		{
			get
			{
				return ResourcesCollection.GetString(Culture, "Employee", "FullNameTooltip");
			}
		}

		/// <summary>
		/// Looks up a localized string similar to FullName3.
		/// </summary>
		public static string FullName3
		{
			get
			{
				return ResourcesCollection.GetString(Culture, "Employee", "FullName3");
			}
		}

		/// <summary>
		/// Looks up a localized string similar to FullName3Tooltip.
		/// </summary>
		public static string FullName3Tooltip
		{
			get
			{
				return ResourcesCollection.GetString(Culture, "Employee", "FullName3Tooltip");
			}
		}
	}



    #region LoanVw
    public partial class LoanVw
    {
        public bool IsChecked { get; set; }
    }
    #endregion
}
