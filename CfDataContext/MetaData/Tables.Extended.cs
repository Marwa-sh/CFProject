using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	public partial class EmployeeMetaData
	{
		/// <summary>
		/// Metadata for Employee.FullName property
		/// </summary>
		[Display(
			Name = "FullName",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("FullNameTooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string FullName { get; set; }

		/// <summary>
		/// Metadata for Employee.FullName3 property
		/// </summary>
		[Display(
			Name = "FullName3",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("FullName3Tooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			152,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string FullName3 { get; set; }
	}
}
