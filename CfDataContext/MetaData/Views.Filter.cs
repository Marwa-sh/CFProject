using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
    #region CashPaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of CashPaymentVw class
    /// </summary>
	public partial class CashPaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for PaymentEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeIdTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  PaymentEmployeeId { get; set; }

		/// <summary>
		/// Metadata for PaymentEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  PaymentEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for PaymentEmployeeDepartmentSalaryWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeDepartmentSalaryWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeDepartmentSalaryWorkPlaceIdTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  PaymentEmployeeDepartmentSalaryWorkPlaceId { get; set; }

		/// <summary>
		/// Metadata for MinPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MinPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("MinPaymentDateTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinPaymentDate { get; set; }

		/// <summary>
		/// Metadata for MaxPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MaxPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("MaxPaymentDateTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxPaymentDate { get; set; }

		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.CashPaymentVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.CashPaymentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }
		#endregion
	}
	#endregion

    #region CollectOrderVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of CollectOrderVw class
    /// </summary>
	public partial class CollectOrderVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.CollectOrderVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.CollectOrderVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.CollectOrderVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.CollectOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.CollectOrderVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.CollectOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region DebtVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of DebtVw class
    /// </summary>
	public partial class DebtVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for EmployeeDepartmentSalaryWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeDepartmentSalaryWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("EmployeeDepartmentSalaryWorkPlaceIdTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeDepartmentSalaryWorkPlaceId { get; set; }

		/// <summary>
		/// Metadata for IssuerId  filter property
		/// </summary>
		[Display(
			Name = "IssuerId",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("IssuerIdTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  IssuerId { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.DebtVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.DebtVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region DepartmentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of DepartmentVw class
    /// </summary>
	public partial class DepartmentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Id  filter property
		/// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.DepartmentVwFilter))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.DepartmentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  Id { get; set; }

		/// <summary>
		/// Metadata for NameContains  filter property
		/// </summary>
		[Display(
			Name = "NameContains",
			ResourceType = typeof(Cf.Data.Resources.DepartmentVwFilter))
		]
		[Tooltip("NameContainsTooltip", typeof(Cf.Data.Resources.DepartmentVwFilter))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  NameContains { get; set; }

		/// <summary>
		/// Metadata for SalaryWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "SalaryWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.DepartmentVwFilter))
		]
		[Tooltip("SalaryWorkPlaceIdTooltip", typeof(Cf.Data.Resources.DepartmentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  SalaryWorkPlaceId { get; set; }

		/// <summary>
		/// Metadata for SalaryWorkPlaceMainWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "SalaryWorkPlaceMainWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.DepartmentVwFilter))
		]
		[Tooltip("SalaryWorkPlaceMainWorkPlaceIdTooltip", typeof(Cf.Data.Resources.DepartmentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  SalaryWorkPlaceMainWorkPlaceId { get; set; }
		#endregion
	}
	#endregion

    #region DownPaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of DownPaymentVw class
    /// </summary>
	public partial class DownPaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for PaymentEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.DownPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeIdTooltip", typeof(Cf.Data.Resources.DownPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  PaymentEmployeeId { get; set; }

		/// <summary>
		/// Metadata for PaymentEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.DownPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.DownPaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  PaymentEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MinPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.DownPaymentVwFilter))
		]
		[Tooltip("MinPaymentDateTooltip", typeof(Cf.Data.Resources.DownPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinPaymentDate { get; set; }

		/// <summary>
		/// Metadata for MaxPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MaxPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.DownPaymentVwFilter))
		]
		[Tooltip("MaxPaymentDateTooltip", typeof(Cf.Data.Resources.DownPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxPaymentDate { get; set; }

		/// <summary>
		/// Metadata for RequestProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "RequestProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.DownPaymentVwFilter))
		]
		[Tooltip("RequestProductProductTypeIdTooltip", typeof(Cf.Data.Resources.DownPaymentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  RequestProductProductTypeId { get; set; }
		#endregion
	}
	#endregion

    #region EmployeeVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of EmployeeVw class
    /// </summary>
	public partial class EmployeeVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Id  filter property
		/// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EmployeeVwFilter))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EmployeeVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  Id { get; set; }

		/// <summary>
		/// Metadata for FullNameArabicSoundex  filter property
		/// </summary>
		[Display(
			Name = "FullNameArabicSoundex",
			ResourceType = typeof(Cf.Data.Resources.EmployeeVwFilter))
		]
		[Tooltip("FullNameArabicSoundexTooltip", typeof(Cf.Data.Resources.EmployeeVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  FullNameArabicSoundex { get; set; }

		/// <summary>
		/// Metadata for DepartmentId  filter property
		/// </summary>
		[Display(
			Name = "DepartmentId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeVwFilter))
		]
		[Tooltip("DepartmentIdTooltip", typeof(Cf.Data.Resources.EmployeeVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  DepartmentId { get; set; }

		/// <summary>
		/// Metadata for DepartmentNameContains  filter property
		/// </summary>
		[Display(
			Name = "DepartmentNameContains",
			ResourceType = typeof(Cf.Data.Resources.EmployeeVwFilter))
		]
		[Tooltip("DepartmentNameContainsTooltip", typeof(Cf.Data.Resources.EmployeeVwFilter))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  DepartmentNameContains { get; set; }

		/// <summary>
		/// Metadata for CategoryId  filter property
		/// </summary>
		[Display(
			Name = "CategoryId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeVwFilter))
		]
		[Tooltip("CategoryIdTooltip", typeof(Cf.Data.Resources.EmployeeVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  CategoryId { get; set; }
		#endregion
	}
	#endregion

    #region ErrorDefinitionVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of ErrorDefinitionVw class
    /// </summary>
	public partial class ErrorDefinitionVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for MessageContains  filter property
		/// </summary>
		[Display(
			Name = "MessageContains",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinitionVwFilter))
		]
		[Tooltip("MessageContainsTooltip", typeof(Cf.Data.Resources.ErrorDefinitionVwFilter))]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  MessageContains { get; set; }

		/// <summary>
		/// Metadata for LocalizedMessageArabicSoundex  filter property
		/// </summary>
		[Display(
			Name = "LocalizedMessageArabicSoundex",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinitionVwFilter))
		]
		[Tooltip("LocalizedMessageArabicSoundexTooltip", typeof(Cf.Data.Resources.ErrorDefinitionVwFilter))]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  LocalizedMessageArabicSoundex { get; set; }
		#endregion
	}
	#endregion

    #region EventCategoryVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of EventCategoryVw class
    /// </summary>
	public partial class EventCategoryVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for NameContains  filter property
		/// </summary>
		[Display(
			Name = "NameContains",
			ResourceType = typeof(Cf.Data.Resources.EventCategoryVwFilter))
		]
		[Tooltip("NameContainsTooltip", typeof(Cf.Data.Resources.EventCategoryVwFilter))]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  NameContains { get; set; }
		#endregion
	}
	#endregion

    #region EventLogErrorVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of EventLogErrorVw class
    /// </summary>
	public partial class EventLogErrorVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EventLogEventCategoryId  filter property
		/// </summary>
		[Display(
			Name = "EventLogEventCategoryId",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("EventLogEventCategoryIdTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EventLogEventCategoryId { get; set; }

		/// <summary>
		/// Metadata for EventLogEventStatusId  filter property
		/// </summary>
		[Display(
			Name = "EventLogEventStatusId",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("EventLogEventStatusIdTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EventLogEventStatusId { get; set; }

		/// <summary>
		/// Metadata for MinEventLogDate  filter property
		/// </summary>
		[Display(
			Name = "MinEventLogDate",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("MinEventLogDateTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[DataType(
			DataType.DateTime,
			ErrorMessageResourceName = "DateTimeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinEventLogDate { get; set; }

		/// <summary>
		/// Metadata for MaxEventLogDate  filter property
		/// </summary>
		[Display(
			Name = "MaxEventLogDate",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("MaxEventLogDateTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[DataType(
			DataType.DateTime,
			ErrorMessageResourceName = "DateTimeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxEventLogDate { get; set; }

		/// <summary>
		/// Metadata for EventLogUser  filter property
		/// </summary>
		[Display(
			Name = "EventLogUser",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("EventLogUserTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EventLogUser { get; set; }

		/// <summary>
		/// Metadata for MessageContains  filter property
		/// </summary>
		[Display(
			Name = "MessageContains",
			ResourceType = typeof(Cf.Data.Resources.EventLogErrorVwFilter))
		]
		[Tooltip("MessageContainsTooltip", typeof(Cf.Data.Resources.EventLogErrorVwFilter))]
		[StringLength(
			1000,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  MessageContains { get; set; }
		#endregion
	}
	#endregion

    #region EventLogVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of EventLogVw class
    /// </summary>
	public partial class EventLogVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Id  filter property
		/// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[Range(
			0,
			9223372036854775807,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public long  Id { get; set; }

		/// <summary>
		/// Metadata for EventCategoryId  filter property
		/// </summary>
		[Display(
			Name = "EventCategoryId",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("EventCategoryIdTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EventCategoryId { get; set; }

		/// <summary>
		/// Metadata for EventStatusId  filter property
		/// </summary>
		[Display(
			Name = "EventStatusId",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("EventStatusIdTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EventStatusId { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[DataType(
			DataType.DateTime,
			ErrorMessageResourceName = "DateTimeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[DataType(
			DataType.DateTime,
			ErrorMessageResourceName = "DateTimeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for User  filter property
		/// </summary>
		[Display(
			Name = "User",
			ResourceType = typeof(Cf.Data.Resources.EventLogVwFilter))
		]
		[Tooltip("UserTooltip", typeof(Cf.Data.Resources.EventLogVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  User { get; set; }
		#endregion
	}
	#endregion

    #region ExternalGrantVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of ExternalGrantVw class
    /// </summary>
	public partial class ExternalGrantVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrantVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.ExternalGrantVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrantVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.ExternalGrantVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinRequestDate  filter property
		/// </summary>
		[Display(
			Name = "MinRequestDate",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrantVwFilter))
		]
		[Tooltip("MinRequestDateTooltip", typeof(Cf.Data.Resources.ExternalGrantVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinRequestDate { get; set; }

		/// <summary>
		/// Metadata for MaxRequestDate  filter property
		/// </summary>
		[Display(
			Name = "MaxRequestDate",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrantVwFilter))
		]
		[Tooltip("MaxRequestDateTooltip", typeof(Cf.Data.Resources.ExternalGrantVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxRequestDate { get; set; }

		/// <summary>
		/// Metadata for GrantTypeId  filter property
		/// </summary>
		[Display(
			Name = "GrantTypeId",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrantVwFilter))
		]
		[Tooltip("GrantTypeIdTooltip", typeof(Cf.Data.Resources.ExternalGrantVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  GrantTypeId { get; set; }
		#endregion
	}
	#endregion

    #region GrantDecisionVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GrantDecisionVw class
    /// </summary>
	public partial class GrantDecisionVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.GrantDecisionVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.GrantDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for Year  filter property
		/// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.GrantDecisionVwFilter))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.GrantDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Year { get; set; }

		/// <summary>
		/// Metadata for GrantTypeGroupId  filter property
		/// </summary>
		[Display(
			Name = "GrantTypeGroupId",
			ResourceType = typeof(Cf.Data.Resources.GrantDecisionVwFilter))
		]
		[Tooltip("GrantTypeGroupIdTooltip", typeof(Cf.Data.Resources.GrantDecisionVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  GrantTypeGroupId { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecisionVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.GrantDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecisionVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.GrantDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region GrantPaymentOrderVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GrantPaymentOrderVw class
    /// </summary>
	public partial class GrantPaymentOrderVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for Year  filter property
		/// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Year { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.GrantPaymentOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region GrantPaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GrantPaymentVw class
    /// </summary>
	public partial class GrantPaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for GrantPaymentOrderNumber  filter property
		/// </summary>
		[Display(
			Name = "GrantPaymentOrderNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("GrantPaymentOrderNumberTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  GrantPaymentOrderNumber { get; set; }

		/// <summary>
		/// Metadata for MinGrantPaymentOrderDate  filter property
		/// </summary>
		[Display(
			Name = "MinGrantPaymentOrderDate",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("MinGrantPaymentOrderDateTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinGrantPaymentOrderDate { get; set; }

		/// <summary>
		/// Metadata for MaxGrantPaymentOrderDate  filter property
		/// </summary>
		[Display(
			Name = "MaxGrantPaymentOrderDate",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("MaxGrantPaymentOrderDateTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxGrantPaymentOrderDate { get; set; }

		/// <summary>
		/// Metadata for SubNumber  filter property
		/// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  SubNumber { get; set; }

		/// <summary>
		/// Metadata for GrantProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "GrantProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("GrantProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  GrantProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for GrantProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "GrantProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("GrantProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  GrantProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinAmount  filter property
		/// </summary>
		[Display(
			Name = "MinAmount",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("MinAmountTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		public decimal  MinAmount { get; set; }

		/// <summary>
		/// Metadata for MaxAmount  filter property
		/// </summary>
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentVwFilter))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.GrantPaymentVwFilter))]
		public decimal  MaxAmount { get; set; }
		#endregion
	}
	#endregion

    #region GrantRequestVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GrantRequestVw class
    /// </summary>
	public partial class GrantRequestVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for RequestProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "RequestProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GrantRequestVwFilter))
		]
		[Tooltip("RequestProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GrantRequestVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  RequestProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for RequestProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "RequestProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.GrantRequestVwFilter))
		]
		[Tooltip("RequestProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.GrantRequestVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  RequestProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for GrantType  filter property
		/// </summary>
		[Display(
			Name = "GrantType",
			ResourceType = typeof(Cf.Data.Resources.GrantRequestVwFilter))
		]
		[Tooltip("GrantTypeTooltip", typeof(Cf.Data.Resources.GrantRequestVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  GrantType { get; set; }
		#endregion
	}
	#endregion

    #region GrantVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GrantVw class
    /// </summary>
	public partial class GrantVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GrantVwFilter))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GrantVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  ProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for ProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.GrantVwFilter))
		]
		[Tooltip("ProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.GrantVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for GrantDecisionNumber  filter property
		/// </summary>
		[Display(
			Name = "GrantDecisionNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantVwFilter))
		]
		[Tooltip("GrantDecisionNumberTooltip", typeof(Cf.Data.Resources.GrantVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  GrantDecisionNumber { get; set; }

		/// <summary>
		/// Metadata for GrantDecisionYear  filter property
		/// </summary>
		[Display(
			Name = "GrantDecisionYear",
			ResourceType = typeof(Cf.Data.Resources.GrantVwFilter))
		]
		[Tooltip("GrantDecisionYearTooltip", typeof(Cf.Data.Resources.GrantVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  GrantDecisionYear { get; set; }
		#endregion
	}
	#endregion

    #region GuarantorVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of GuarantorVw class
    /// </summary>
	public partial class GuarantorVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for RefundableProductProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "RefundableProductProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GuarantorVwFilter))
		]
		[Tooltip("RefundableProductProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GuarantorVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  RefundableProductProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for RefundableProductProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "RefundableProductProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.GuarantorVwFilter))
		]
		[Tooltip("RefundableProductProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.GuarantorVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  RefundableProductProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GuarantorVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GuarantorVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.GuarantorVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.GuarantorVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }
		#endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of HealthLoanDecisionFirstPaymentVw class
    /// </summary>
	public partial class HealthLoanDecisionFirstPaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for HealthLoanDecisionNumber  filter property
		/// </summary>
		[Display(
			Name = "HealthLoanDecisionNumber",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))
		]
		[Tooltip("HealthLoanDecisionNumberTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  HealthLoanDecisionNumber { get; set; }

		/// <summary>
		/// Metadata for HealthLoanDecisionYear  filter property
		/// </summary>
		[Display(
			Name = "HealthLoanDecisionYear",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))
		]
		[Tooltip("HealthLoanDecisionYearTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPaymentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  HealthLoanDecisionYear { get; set; }
		#endregion
	}
	#endregion

    #region HealthLoanDecisionVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of HealthLoanDecisionVw class
    /// </summary>
	public partial class HealthLoanDecisionVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for Year  filter property
		/// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Year { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region IncomingLoanVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of IncomingLoanVw class
    /// </summary>
	public partial class IncomingLoanVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for LoanProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoanVwFilter))
		]
		[Tooltip("LoanProductEmployeeIdTooltip", typeof(Cf.Data.Resources.IncomingLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  LoanProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for LoanProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoanVwFilter))
		]
		[Tooltip("LoanProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.IncomingLoanVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  LoanProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for LoanProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "LoanProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoanVwFilter))
		]
		[Tooltip("LoanProductProductTypeIdTooltip", typeof(Cf.Data.Resources.IncomingLoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for LoanLoanDecisionNumber  filter property
		/// </summary>
		[Display(
			Name = "LoanLoanDecisionNumber",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoanVwFilter))
		]
		[Tooltip("LoanLoanDecisionNumberTooltip", typeof(Cf.Data.Resources.IncomingLoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanLoanDecisionNumber { get; set; }

		/// <summary>
		/// Metadata for LoanLoanDecisionYear  filter property
		/// </summary>
		[Display(
			Name = "LoanLoanDecisionYear",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoanVwFilter))
		]
		[Tooltip("LoanLoanDecisionYearTooltip", typeof(Cf.Data.Resources.IncomingLoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanLoanDecisionYear { get; set; }
		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of InstallmentDecreaseOrderVw class
    /// </summary>
	public partial class InstallmentDecreaseOrderVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for MinMonth  filter property
		/// </summary>
		[Display(
			Name = "MinMonth",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrderVwFilter))
		]
		[Tooltip("MinMonthTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinMonth { get; set; }

		/// <summary>
		/// Metadata for MaxMonth  filter property
		/// </summary>
		[Display(
			Name = "MaxMonth",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrderVwFilter))
		]
		[Tooltip("MaxMonthTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxMonth { get; set; }
		#endregion
	}
	#endregion

    #region InstallmentDecreaseVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of InstallmentDecreaseVw class
    /// </summary>
	public partial class InstallmentDecreaseVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for MinInstallmentDecreaseOrderMonth  filter property
		/// </summary>
		[Display(
			Name = "MinInstallmentDecreaseOrderMonth",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))
		]
		[Tooltip("MinInstallmentDecreaseOrderMonthTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinInstallmentDecreaseOrderMonth { get; set; }

		/// <summary>
		/// Metadata for MaxInstallmentDecreaseOrderMonth  filter property
		/// </summary>
		[Display(
			Name = "MaxInstallmentDecreaseOrderMonth",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))
		]
		[Tooltip("MaxInstallmentDecreaseOrderMonthTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxInstallmentDecreaseOrderMonth { get; set; }

		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }
		#endregion
	}
	#endregion

    #region InstallmentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of InstallmentVw class
    /// </summary>
	public partial class InstallmentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for RefundableProductProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "RefundableProductProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("RefundableProductProductEmployeeIdTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  RefundableProductProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for RefundableProductProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "RefundableProductProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("RefundableProductProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  RefundableProductProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for RefundableProductProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "RefundableProductProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("RefundableProductProductProductTypeIdTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  RefundableProductProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for SubNumber  filter property
		/// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  SubNumber { get; set; }

		/// <summary>
		/// Metadata for MinDueDate  filter property
		/// </summary>
		[Display(
			Name = "MinDueDate",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("MinDueDateTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDueDate { get; set; }

		/// <summary>
		/// Metadata for MaxDueDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDueDate",
			ResourceType = typeof(Cf.Data.Resources.InstallmentVwFilter))
		]
		[Tooltip("MaxDueDateTooltip", typeof(Cf.Data.Resources.InstallmentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDueDate { get; set; }
		#endregion
	}
	#endregion

    #region LoanChangeVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanChangeVw class
    /// </summary>
	public partial class LoanChangeVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for LoanProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("LoanProductEmployeeIdTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  LoanProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for LoanProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("LoanProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  LoanProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for LoanLoanType  filter property
		/// </summary>
		[Display(
			Name = "LoanLoanType",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("LoanLoanTypeTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanLoanType { get; set; }

		/// <summary>
		/// Metadata for FromLoanProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "FromLoanProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("FromLoanProductEmployeeIdTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  FromLoanProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for FromLoanProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "FromLoanProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("FromLoanProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  FromLoanProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for FromLoanLoanType  filter property
		/// </summary>
		[Display(
			Name = "FromLoanLoanType",
			ResourceType = typeof(Cf.Data.Resources.LoanChangeVwFilter))
		]
		[Tooltip("FromLoanLoanTypeTooltip", typeof(Cf.Data.Resources.LoanChangeVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  FromLoanLoanType { get; set; }
		#endregion
	}
	#endregion

    #region LoanDecisionVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanDecisionVw class
    /// </summary>
	public partial class LoanDecisionVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.LoanDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for Year  filter property
		/// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionVwFilter))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.LoanDecisionVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Year { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.LoanDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.LoanDecisionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for LoanDecisionTypeId  filter property
		/// </summary>
		[Display(
			Name = "LoanDecisionTypeId",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionVwFilter))
		]
		[Tooltip("LoanDecisionTypeIdTooltip", typeof(Cf.Data.Resources.LoanDecisionVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  LoanDecisionTypeId { get; set; }
		#endregion
	}
	#endregion

    #region LoanExtendedVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanExtendedVw class
    /// </summary>
	public partial class LoanExtendedVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  ProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for ProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  ProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for LoanDecisionYear  filter property
		/// </summary>
		[Display(
			Name = "LoanDecisionYear",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("LoanDecisionYearTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanDecisionYear { get; set; }

		/// <summary>
		/// Metadata for MinLoanDecisionDate  filter property
		/// </summary>
		[Display(
			Name = "MinLoanDecisionDate",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("MinLoanDecisionDateTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinLoanDecisionDate { get; set; }

		/// <summary>
		/// Metadata for MaxLoanDecisionDate  filter property
		/// </summary>
		[Display(
			Name = "MaxLoanDecisionDate",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("MaxLoanDecisionDateTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxLoanDecisionDate { get; set; }

		/// <summary>
		/// Metadata for MinLoanDecisionDeductionStartDate  filter property
		/// </summary>
		[Display(
			Name = "MinLoanDecisionDeductionStartDate",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("MinLoanDecisionDeductionStartDateTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinLoanDecisionDeductionStartDate { get; set; }

		/// <summary>
		/// Metadata for MaxLoanDecisionDeductionStartDate  filter property
		/// </summary>
		[Display(
			Name = "MaxLoanDecisionDeductionStartDate",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("MaxLoanDecisionDeductionStartDateTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxLoanDecisionDeductionStartDate { get; set; }

		/// <summary>
		/// Metadata for LoanGenerationStatusId  filter property
		/// </summary>
		[Display(
			Name = "LoanGenerationStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("LoanGenerationStatusIdTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  LoanGenerationStatusId { get; set; }

		/// <summary>
		/// Metadata for LoanStatusId  filter property
		/// </summary>
		[Display(
			Name = "LoanStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanExtendedVwFilter))
		]
		[Tooltip("LoanStatusIdTooltip", typeof(Cf.Data.Resources.LoanExtendedVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  LoanStatusId { get; set; }
		#endregion
	}
	#endregion

    #region LoanRequestVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanRequestVw class
    /// </summary>
	public partial class LoanRequestVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for RequestProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "RequestProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("RequestProductEmployeeIdTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  RequestProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for RequestProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "RequestProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("RequestProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  RequestProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for RequestProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "RequestProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("RequestProductProductTypeIdTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  RequestProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for MinRequestDate  filter property
		/// </summary>
		[Display(
			Name = "MinRequestDate",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("MinRequestDateTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinRequestDate { get; set; }

		/// <summary>
		/// Metadata for MaxRequestDate  filter property
		/// </summary>
		[Display(
			Name = "MaxRequestDate",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("MaxRequestDateTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxRequestDate { get; set; }

		/// <summary>
		/// Metadata for RequestRequestStatusId  filter property
		/// </summary>
		[Display(
			Name = "RequestRequestStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanRequestVwFilter))
		]
		[Tooltip("RequestRequestStatusIdTooltip", typeof(Cf.Data.Resources.LoanRequestVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  RequestRequestStatusId { get; set; }
		#endregion
	}
	#endregion

    #region LoanTypeVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanTypeVw class
    /// </summary>
	public partial class LoanTypeVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductTypeNameContains  filter property
		/// </summary>
		[Display(
			Name = "ProductTypeNameContains",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeVwFilter))
		]
		[Tooltip("ProductTypeNameContainsTooltip", typeof(Cf.Data.Resources.LoanTypeVwFilter))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ProductTypeNameContains { get; set; }

		/// <summary>
		/// Metadata for ProductTypeProfitStrategyId  filter property
		/// </summary>
		[Display(
			Name = "ProductTypeProfitStrategyId",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeVwFilter))
		]
		[Tooltip("ProductTypeProfitStrategyIdTooltip", typeof(Cf.Data.Resources.LoanTypeVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  ProductTypeProfitStrategyId { get; set; }

		/// <summary>
		/// Metadata for ProductTypePaymentGroupId  filter property
		/// </summary>
		[Display(
			Name = "ProductTypePaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeVwFilter))
		]
		[Tooltip("ProductTypePaymentGroupIdTooltip", typeof(Cf.Data.Resources.LoanTypeVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  ProductTypePaymentGroupId { get; set; }
		#endregion
	}
	#endregion

    #region LoanVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of LoanVw class
    /// </summary>
	public partial class LoanVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  ProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for ProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("ProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for ProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  ProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for LoanDecisionNumber  filter property
		/// </summary>
		[Display(
			Name = "LoanDecisionNumber",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("LoanDecisionNumberTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanDecisionNumber { get; set; }

		/// <summary>
		/// Metadata for MinLoanDecisionDate  filter property
		/// </summary>
		[Display(
			Name = "MinLoanDecisionDate",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("MinLoanDecisionDateTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinLoanDecisionDate { get; set; }

		/// <summary>
		/// Metadata for MaxLoanDecisionDate  filter property
		/// </summary>
		[Display(
			Name = "MaxLoanDecisionDate",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("MaxLoanDecisionDateTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxLoanDecisionDate { get; set; }

		/// <summary>
		/// Metadata for LoanStatusId  filter property
		/// </summary>
		[Display(
			Name = "LoanStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanVwFilter))
		]
		[Tooltip("LoanStatusIdTooltip", typeof(Cf.Data.Resources.LoanVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  LoanStatusId { get; set; }
		#endregion
	}
	#endregion

    #region MissingInstallmentDecreaseVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of MissingInstallmentDecreaseVw class
    /// </summary>
	public partial class MissingInstallmentDecreaseVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinTransferMonth  filter property
		/// </summary>
		[Display(
			Name = "MinTransferMonth",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))
		]
		[Tooltip("MinTransferMonthTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinTransferMonth { get; set; }

		/// <summary>
		/// Metadata for MaxTransferMonth  filter property
		/// </summary>
		[Display(
			Name = "MaxTransferMonth",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))
		]
		[Tooltip("MaxTransferMonthTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecreaseVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxTransferMonth { get; set; }
		#endregion
	}
	#endregion

    #region MonthlyBalanceVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of MonthlyBalanceVw class
    /// </summary>
	public partial class MonthlyBalanceVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for PaymentGroupId  filter property
		/// </summary>
		[Display(
			Name = "PaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))
		]
		[Tooltip("PaymentGroupIdTooltip", typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentGroupId { get; set; }

		/// <summary>
		/// Metadata for MinMonth  filter property
		/// </summary>
		[Display(
			Name = "MinMonth",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))
		]
		[Tooltip("MinMonthTooltip", typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinMonth { get; set; }

		/// <summary>
		/// Metadata for MaxMonth  filter property
		/// </summary>
		[Display(
			Name = "MaxMonth",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))
		]
		[Tooltip("MaxMonthTooltip", typeof(Cf.Data.Resources.MonthlyBalanceVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxMonth { get; set; }
		#endregion
	}
	#endregion

    #region OutgoingLoanVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of OutgoingLoanVw class
    /// </summary>
	public partial class OutgoingLoanVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for LoanProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoanVwFilter))
		]
		[Tooltip("LoanProductEmployeeIdTooltip", typeof(Cf.Data.Resources.OutgoingLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  LoanProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for LoanProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "LoanProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoanVwFilter))
		]
		[Tooltip("LoanProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.OutgoingLoanVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  LoanProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for LoanProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "LoanProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoanVwFilter))
		]
		[Tooltip("LoanProductProductTypeIdTooltip", typeof(Cf.Data.Resources.OutgoingLoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for MainWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "MainWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoanVwFilter))
		]
		[Tooltip("MainWorkPlaceIdTooltip", typeof(Cf.Data.Resources.OutgoingLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  MainWorkPlaceId { get; set; }
		#endregion
	}
	#endregion

    #region PaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of PaymentVw class
    /// </summary>
	public partial class PaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for PaymentGroupId  filter property
		/// </summary>
		[Display(
			Name = "PaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("PaymentGroupIdTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentGroupId { get; set; }

		/// <summary>
		/// Metadata for PaymentStatusId  filter property
		/// </summary>
		[Display(
			Name = "PaymentStatusId",
			ResourceType = typeof(Cf.Data.Resources.PaymentVwFilter))
		]
		[Tooltip("PaymentStatusIdTooltip", typeof(Cf.Data.Resources.PaymentVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentStatusId { get; set; }
		#endregion
	}
	#endregion

    #region PayOrderVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of PayOrderVw class
    /// </summary>
	public partial class PayOrderVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for Number  filter property
		/// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  Number { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for PaymentGroupId  filter property
		/// </summary>
		[Display(
			Name = "PaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.PayOrderVwFilter))
		]
		[Tooltip("PaymentGroupIdTooltip", typeof(Cf.Data.Resources.PayOrderVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentGroupId { get; set; }
		#endregion
	}
	#endregion

    #region ProductVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of ProductVw class
    /// </summary>
	public partial class ProductVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ProductVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.ProductVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.ProductVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.ProductVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for ProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.ProductVwFilter))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.ProductVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  ProductTypeId { get; set; }
		#endregion
	}
	#endregion

    #region RefundableProductVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of RefundableProductVw class
    /// </summary>
	public partial class RefundableProductVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.RefundableProductVwFilter))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.RefundableProductVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  ProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for ProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.RefundableProductVwFilter))
		]
		[Tooltip("ProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.RefundableProductVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for ProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.RefundableProductVwFilter))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.RefundableProductVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  ProductProductTypeId { get; set; }
		#endregion
	}
	#endregion

    #region RequestVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of RequestVw class
    /// </summary>
	public partial class RequestVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for ProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  ProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for ProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "ProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("ProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for ProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  ProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for RequestStatusId  filter property
		/// </summary>
		[Display(
			Name = "RequestStatusId",
			ResourceType = typeof(Cf.Data.Resources.RequestVwFilter))
		]
		[Tooltip("RequestStatusIdTooltip", typeof(Cf.Data.Resources.RequestVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  RequestStatusId { get; set; }
		#endregion
	}
	#endregion

    #region ResourceVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of ResourceVw class
    /// </summary>
	public partial class ResourceVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for Language  filter property
		/// </summary>
		[Display(
			Name = "Language",
			ResourceType = typeof(Cf.Data.Resources.ResourceVwFilter))
		]
		[Tooltip("LanguageTooltip", typeof(Cf.Data.Resources.ResourceVwFilter))]
		[StringLength(
			2,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  Language { get; set; }

		/// <summary>
		/// Metadata for ModuleContains  filter property
		/// </summary>
		[Display(
			Name = "ModuleContains",
			ResourceType = typeof(Cf.Data.Resources.ResourceVwFilter))
		]
		[Tooltip("ModuleContainsTooltip", typeof(Cf.Data.Resources.ResourceVwFilter))]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ModuleContains { get; set; }

		/// <summary>
		/// Metadata for KeyContains  filter property
		/// </summary>
		[Display(
			Name = "KeyContains",
			ResourceType = typeof(Cf.Data.Resources.ResourceVwFilter))
		]
		[Tooltip("KeyContainsTooltip", typeof(Cf.Data.Resources.ResourceVwFilter))]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  KeyContains { get; set; }

		/// <summary>
		/// Metadata for ValueContains  filter property
		/// </summary>
		[Display(
			Name = "ValueContains",
			ResourceType = typeof(Cf.Data.Resources.ResourceVwFilter))
		]
		[Tooltip("ValueContainsTooltip", typeof(Cf.Data.Resources.ResourceVwFilter))]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  ValueContains { get; set; }
		#endregion
	}
	#endregion

    #region SalaryPaymentVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of SalaryPaymentVw class
    /// </summary>
	public partial class SalaryPaymentVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for PaymentEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeIdTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  PaymentEmployeeId { get; set; }

		/// <summary>
		/// Metadata for PaymentEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "PaymentEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("PaymentEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  PaymentEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MinPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("MinPaymentDateTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinPaymentDate { get; set; }

		/// <summary>
		/// Metadata for MaxPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MaxPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("MaxPaymentDateTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxPaymentDate { get; set; }

		/// <summary>
		/// Metadata for PaymentPaymentGroupId  filter property
		/// </summary>
		[Display(
			Name = "PaymentPaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("PaymentPaymentGroupIdTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentPaymentGroupId { get; set; }

		/// <summary>
		/// Metadata for PaymentPaymentStatusId  filter property
		/// </summary>
		[Display(
			Name = "PaymentPaymentStatusId",
			ResourceType = typeof(Cf.Data.Resources.SalaryPaymentVwFilter))
		]
		[Tooltip("PaymentPaymentStatusIdTooltip", typeof(Cf.Data.Resources.SalaryPaymentVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  PaymentPaymentStatusId { get; set; }
		#endregion
	}
	#endregion

    #region SalaryWorkPlaceVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of SalaryWorkPlaceVw class
    /// </summary>
	public partial class SalaryWorkPlaceVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for MainWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "MainWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.SalaryWorkPlaceVwFilter))
		]
		[Tooltip("MainWorkPlaceIdTooltip", typeof(Cf.Data.Resources.SalaryWorkPlaceVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  MainWorkPlaceId { get; set; }
		#endregion
	}
	#endregion

    #region ServiceEndGrantRequestVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of ServiceEndGrantRequestVw class
    /// </summary>
	public partial class ServiceEndGrantRequestVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for GrantRequestRequestProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "GrantRequestRequestProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequestVwFilter))
		]
		[Tooltip("GrantRequestRequestProductEmployeeIdTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequestVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  GrantRequestRequestProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for GrantRequestRequestProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "GrantRequestRequestProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequestVwFilter))
		]
		[Tooltip("GrantRequestRequestProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequestVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  GrantRequestRequestProductEmployeeFullNameContains { get; set; }
		#endregion
	}
	#endregion

    #region SettlementVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of SettlementVw class
    /// </summary>
	public partial class SettlementVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for InstallmentRefundableProductProductEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "InstallmentRefundableProductProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("InstallmentRefundableProductProductEmployeeIdTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  InstallmentRefundableProductProductEmployeeId { get; set; }

		/// <summary>
		/// Metadata for InstallmentRefundableProductProductEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "InstallmentRefundableProductProductEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("InstallmentRefundableProductProductEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  InstallmentRefundableProductProductEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for InstallmentRefundableProductProductProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "InstallmentRefundableProductProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("InstallmentRefundableProductProductProductTypeIdTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  InstallmentRefundableProductProductProductTypeId { get; set; }

		/// <summary>
		/// Metadata for MinInstallmentSubNumber  filter property
		/// </summary>
		[Display(
			Name = "MinInstallmentSubNumber",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MinInstallmentSubNumberTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  MinInstallmentSubNumber { get; set; }

		/// <summary>
		/// Metadata for MaxInstallmentSubNumber  filter property
		/// </summary>
		[Display(
			Name = "MaxInstallmentSubNumber",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MaxInstallmentSubNumberTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  MaxInstallmentSubNumber { get; set; }

		/// <summary>
		/// Metadata for MinPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MinPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MinPaymentDateTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinPaymentDate { get; set; }

		/// <summary>
		/// Metadata for MaxPaymentDate  filter property
		/// </summary>
		[Display(
			Name = "MaxPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MaxPaymentDateTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxPaymentDate { get; set; }

		/// <summary>
		/// Metadata for MinPaymentAmount  filter property
		/// </summary>
		[Display(
			Name = "MinPaymentAmount",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MinPaymentAmountTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		public decimal  MinPaymentAmount { get; set; }

		/// <summary>
		/// Metadata for MaxPaymentAmount  filter property
		/// </summary>
		[Display(
			Name = "MaxPaymentAmount",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MaxPaymentAmountTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		public decimal  MaxPaymentAmount { get; set; }

		/// <summary>
		/// Metadata for MinAmount  filter property
		/// </summary>
		[Display(
			Name = "MinAmount",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MinAmountTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		public decimal  MinAmount { get; set; }

		/// <summary>
		/// Metadata for MaxAmount  filter property
		/// </summary>
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.SettlementVwFilter))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.SettlementVwFilter))]
		public decimal  MaxAmount { get; set; }
		#endregion
	}
	#endregion

    #region SpecialCaseLoanVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of SpecialCaseLoanVw class
    /// </summary>
	public partial class SpecialCaseLoanVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinDate  filter property
		/// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDate { get; set; }

		/// <summary>
		/// Metadata for MaxDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDate { get; set; }

		/// <summary>
		/// Metadata for LoanTypeProductTypeId  filter property
		/// </summary>
		[Display(
			Name = "LoanTypeProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))
		]
		[Tooltip("LoanTypeProductTypeIdTooltip", typeof(Cf.Data.Resources.SpecialCaseLoanVwFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public short  LoanTypeProductTypeId { get; set; }
		#endregion
	}
	#endregion

    #region SubscriptionVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of SubscriptionVw class
    /// </summary>
	public partial class SubscriptionVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.SubscriptionVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.SubscriptionVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinMonth  filter property
		/// </summary>
		[Display(
			Name = "MinMonth",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionVwFilter))
		]
		[Tooltip("MinMonthTooltip", typeof(Cf.Data.Resources.SubscriptionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinMonth { get; set; }

		/// <summary>
		/// Metadata for MaxMonth  filter property
		/// </summary>
		[Display(
			Name = "MaxMonth",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionVwFilter))
		]
		[Tooltip("MaxMonthTooltip", typeof(Cf.Data.Resources.SubscriptionVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxMonth { get; set; }

		/// <summary>
		/// Metadata for SubscriptionTypeId  filter property
		/// </summary>
		[Display(
			Name = "SubscriptionTypeId",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionVwFilter))
		]
		[Tooltip("SubscriptionTypeIdTooltip", typeof(Cf.Data.Resources.SubscriptionVwFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public byte  SubscriptionTypeId { get; set; }
		#endregion
	}
	#endregion

    #region TransitoryIncomingLoanVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of TransitoryIncomingLoanVw class
    /// </summary>
	public partial class TransitoryIncomingLoanVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MainWorkPlaceId  filter property
		/// </summary>
		[Display(
			Name = "MainWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))
		]
		[Tooltip("MainWorkPlaceIdTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  MainWorkPlaceId { get; set; }

		/// <summary>
		/// Metadata for IsVerified  filter property
		/// </summary>
		[Display(
			Name = "IsVerified",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))
		]
		[Tooltip("IsVerifiedTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoanVwFilter))]
		public bool  IsVerified { get; set; }
		#endregion
	}
	#endregion

    #region WarrantVwFilter meta data class definition
    /// <summary>
    /// Metadata for the Filter filter of WarrantVw class
    /// </summary>
	public partial class WarrantVwFilterMetaData
	{
		#region Public properties
		/// <summary>
		/// Metadata for DebtEmployeeId  filter property
		/// </summary>
		[Display(
			Name = "DebtEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("DebtEmployeeIdTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  DebtEmployeeId { get; set; }

		/// <summary>
		/// Metadata for DebtEmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "DebtEmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("DebtEmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  DebtEmployeeFullNameContains { get; set; }

		/// <summary>
		/// Metadata for MinDebtDate  filter property
		/// </summary>
		[Display(
			Name = "MinDebtDate",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("MinDebtDateTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MinDebtDate { get; set; }

		/// <summary>
		/// Metadata for MaxDebtDate  filter property
		/// </summary>
		[Display(
			Name = "MaxDebtDate",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("MaxDebtDateTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public DateTime  MaxDebtDate { get; set; }

		/// <summary>
		/// Metadata for EmployeeId  filter property
		/// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public int  EmployeeId { get; set; }

		/// <summary>
		/// Metadata for EmployeeFullNameContains  filter property
		/// </summary>
		[Display(
			Name = "EmployeeFullNameContains",
			ResourceType = typeof(Cf.Data.Resources.WarrantVwFilter))
		]
		[Tooltip("EmployeeFullNameContainsTooltip", typeof(Cf.Data.Resources.WarrantVwFilter))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		public string  EmployeeFullNameContains { get; set; }
		#endregion
	}
	#endregion
}
