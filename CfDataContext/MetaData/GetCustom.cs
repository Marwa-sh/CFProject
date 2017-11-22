using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region EmployeeCustom filter and result classes
	#region EmployeeCustomFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeCustomFilter class
    /// </summary>
	public partial class EmployeeCustomFilterMetaData
	{
		#region Public properties
		#endregion
	}
	#endregion


    #region EmployeeCustomResult1MetaData class definition
	/// <summary>
    /// Result class for EmployeeCustom.
	/// </summary>
	public partial class EmployeeCustomResult1MetaData
	{
		#region Public properties
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id {get; set; }
		
		[Display(
			Name = "FirstName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("FirstNameTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstName {get; set; }
		
		[Display(
			Name = "LastName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("LastNameTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LastName {get; set; }
		
		[Display(
			Name = "FatherName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("FatherNameTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FatherName {get; set; }
		
		[Display(
			Name = "MotherName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("MotherNameTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string MotherName {get; set; }
		
		[Display(
			Name = "BirthDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("BirthDateTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> BirthDate {get; set; }
		
		[Display(
			Name = "ExpectedEndDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("ExpectedEndDateTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ExpectedEndDate {get; set; }
		
		[Display(
			Name = "CersStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("CersStartDateTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersStartDate {get; set; }
		
		[Display(
			Name = "CfStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("CfStartDateTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CfStartDate {get; set; }
		
		[Display(
			Name = "LeaveDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("LeaveDateTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> LeaveDate {get; set; }
		
		[Display(
			Name = "LeaveReason",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("LeaveReasonTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LeaveReason {get; set; }
		
		[Display(
			Name = "EmployeeStatus",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("EmployeeStatusTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte EmployeeStatus {get; set; }
		
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Department {get; set; }
		
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes {get; set; }
		
		[Display(
			Name = "Category",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult1))
		]
		[Tooltip("CategoryTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult1))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Category {get; set; }
		#endregion
	}
	#endregion

    #region EmployeeCustomResult2MetaData class definition
	/// <summary>
    /// Result class for EmployeeCustom.
	/// </summary>
	public partial class EmployeeCustomResult2MetaData
	{
		#region Public properties
		[Display(
			Name = "Product",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult2))
		]
		[Tooltip("ProductTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult2))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Product {get; set; }
		
		[Display(
			Name = "LoanDecision",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult2))
		]
		[Tooltip("LoanDecisionTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult2))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int LoanDecision {get; set; }
		
		[Display(
			Name = "LoanType",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult2))
		]
		[Tooltip("LoanTypeTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult2))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short LoanType {get; set; }
		
		[Display(
			Name = "LoanGenerationStatus",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult2))
		]
		[Tooltip("LoanGenerationStatusTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult2))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte LoanGenerationStatus {get; set; }
		
		[Display(
			Name = "LoanStatus",
			ResourceType = typeof(Cf.Data.Resources.EmployeeCustomResult2))
		]
		[Tooltip("LoanStatusTooltip", typeof(Cf.Data.Resources.EmployeeCustomResult2))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte LoanStatus {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region EmployeeProductCalculator filter and result classes
	#region EmployeeProductCalculatorFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeProductCalculatorFilter class
    /// </summary>
	public partial class EmployeeProductCalculatorFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.ProductTypeId property
        /// </summary>
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		#endregion
	}
	#endregion


    #region EmployeeProductCalculatorResultMetaData class definition
	/// <summary>
    /// Result class for EmployeeProductCalculator.
	/// </summary>
	public partial class EmployeeProductCalculatorResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "FullName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("FullNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FullName {get; set; }
		
		[Display(
			Name = "CersStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CersStartDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersStartDate {get; set; }
		
		[Display(
			Name = "CfStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CfStartDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CfStartDate {get; set; }
		
		[Display(
			Name = "LeaveDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("LeaveDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> LeaveDate {get; set; }
		
		[Display(
			Name = "LeaveReason",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("LeaveReasonTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LeaveReason {get; set; }
		
		[Display(
			Name = "DepartmentId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int DepartmentId {get; set; }
		
		[Display(
			Name = "DepartmentName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string DepartmentName {get; set; }
		
		[Display(
			Name = "DepartmentSalaryWorkPlaceId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentSalaryWorkPlaceIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int DepartmentSalaryWorkPlaceId {get; set; }
		
		[Display(
			Name = "DepartmentSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string DepartmentSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "EmployeeStatusId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("EmployeeStatusIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte EmployeeStatusId {get; set; }
		
		[Display(
			Name = "EmployeeStatusName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("EmployeeStatusNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string EmployeeStatusName {get; set; }
		
		[Display(
			Name = "CategoryId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CategoryIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte CategoryId {get; set; }
		
		[Display(
			Name = "CategoryName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CategoryNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CategoryName {get; set; }
		
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> MaxAmount {get; set; }
		
		[Display(
			Name = "Seniority",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("SeniorityTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Seniority {get; set; }
		
		[Display(
			Name = "MinSeniority",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MinSeniorityTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinSeniority {get; set; }
		
		[Display(
			Name = "MinReusePeriod",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MinReusePeriodTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinReusePeriod {get; set; }
		
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> ProfitAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> Installment {get; set; }
		
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<double> Rate {get; set; }
		
		[Display(
			Name = "GuarantorsCount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("GuarantorsCountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetAvailabilityCeilingByProductTypeId_EmployeeId filter and result classes
	#region GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter meta data class definition
    /// <summary>
    /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter class
    /// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter.ProductTypeId property
        /// </summary>
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId { get; set; }
		
        /// <summary>
        /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion


    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdResultMetaData class definition
	/// <summary>
    /// Result class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Seniority",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("SeniorityTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Seniority {get; set; }
		
		[Display(
			Name = "MinSeniority",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MinSeniorityTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinSeniority {get; set; }
		
		[Display(
			Name = "MinReusePeriod",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MinReusePeriodTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinReusePeriod {get; set; }
		
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
        public Nullable<decimal> MaxAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDueProfit filter and result classes
	#region GetDueProfitFilter meta data class definition
    /// <summary>
    /// Metadata for GetDueProfitFilter class
    /// </summary>
	public partial class GetDueProfitFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetDueProfitFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GetDueProfitFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetDueProfitFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
        public Nullable<double> Rate { get; set; }
		#endregion
	}
	#endregion

	#endregion

	#region GetFinancialRatio filter and result classes
	#region GetFinancialRatioFilter meta data class definition
    /// <summary>
    /// Metadata for GetFinancialRatioFilter class
    /// </summary>
	public partial class GetFinancialRatioFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion

	#endregion

	#region GetInstallment filter and result classes
	#region GetInstallmentFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentFilter class
    /// </summary>
	public partial class GetInstallmentFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion

	#endregion

	#region GetInstallmentPaidAmounts filter and result classes
	#region GetInstallmentPaidAmountsFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentPaidAmountsFilter class
    /// </summary>
	public partial class GetInstallmentPaidAmountsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentPaidAmountsFilter.RefundableProductId property
        /// </summary>
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsFilter))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RefundableProductId { get; set; }
		#endregion
	}
	#endregion


    #region GetInstallmentPaidAmountsResultMetaData class definition
	/// <summary>
    /// Result class for GetInstallmentPaidAmounts.
	/// </summary>
	public partial class GetInstallmentPaidAmountsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "InstallmentId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))
		]
		[Tooltip("InstallmentIdTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int InstallmentId {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal PaidAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetInstallments filter and result classes
	#region GetInstallmentsFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentsFilter class
    /// </summary>
	public partial class GetInstallmentsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentsFilter.RefundableProductId property
        /// </summary>
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsFilter))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RefundableProductId { get; set; }
		#endregion
	}
	#endregion


    #region GetInstallmentsResultMetaData class definition
	/// <summary>
    /// Result class for GetInstallments.
	/// </summary>
	public partial class GetInstallmentsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id {get; set; }
		
		[Display(
			Name = "RefundableProduct",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("RefundableProductTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int RefundableProduct {get; set; }
		
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short SubNumber {get; set; }
		
		[Display(
			Name = "DueDate",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueDateTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime DueDate {get; set; }
		
		[Display(
			Name = "DueCapital",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueCapitalTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueCapital {get; set; }
		
		[Display(
			Name = "DueProfit",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueProfitTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueProfit {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal PaidAmount {get; set; }
		
		[Display(
			Name = "PaymentStatus",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("PaymentStatusTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int PaymentStatus {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetPresentValue filter and result classes
	#region GetPresentValueFilter meta data class definition
    /// <summary>
    /// Metadata for GetPresentValueFilter class
    /// </summary>
	public partial class GetPresentValueFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetPresentValueFilter.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<decimal> Installment { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion

	#endregion

	#region GetRefundableProducts filter and result classes
	#region GetRefundableProductsFilter meta data class definition
    /// <summary>
    /// Metadata for GetRefundableProductsFilter class
    /// </summary>
	public partial class GetRefundableProductsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetRefundableProductsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion


    #region GetRefundableProductsResultMetaData class definition
	/// <summary>
    /// Result class for GetRefundableProducts.
	/// </summary>
	public partial class GetRefundableProductsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int ProductId {get; set; }
		
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int ProductEmployeeId {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ProfitAmount {get; set; }
		
		[Display(
			Name = "PaymentPeriod",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("PaymentPeriodTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short PaymentPeriod {get; set; }
		
		[Display(
			Name = "DueAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("DueAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
        public Nullable<decimal> DueAmount {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
        public Nullable<decimal> PaidAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region LoanGenerate filter and result classes
	#region LoanGenerateFilter meta data class definition
    /// <summary>
    /// Metadata for LoanGenerateFilter class
    /// </summary>
	public partial class LoanGenerateFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanGenerateFilter.ProductId property
        /// </summary>
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> ProductId { get; set; }
		
        /// <summary>
        /// Metadata for LoanGenerateFilter.LoanDecisionId property
        /// </summary>
		[Display(
			Name = "LoanDecisionId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("LoanDecisionIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> LoanDecisionId { get; set; }
		
        /// <summary>
        /// Metadata for LoanGenerateFilter.LoanGenerationStatusId property
        /// </summary>
		[Display(
			Name = "LoanGenerationStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("LoanGenerationStatusIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> LoanGenerationStatusId { get; set; }
		#endregion
	}
	#endregion

	#endregion

	#region ProductCalculator filter and result classes
	#region ProductCalculatorFilter meta data class definition
    /// <summary>
    /// Metadata for ProductCalculatorFilter class
    /// </summary>
	public partial class ProductCalculatorFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ProductCalculatorFilter.ProductType property
        /// </summary>
		[Display(
			Name = "ProductType",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("ProductTypeTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductType { get; set; }
		
        /// <summary>
        /// Metadata for ProductCalculatorFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for ProductCalculatorFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		#endregion
	}
	#endregion


    #region ProductCalculatorResultMetaData class definition
	/// <summary>
    /// Result class for ProductCalculator.
	/// </summary>
	public partial class ProductCalculatorResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> ProfitAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> Installment {get; set; }
		
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<double> Rate {get; set; }
		
		[Display(
			Name = "GuarantorsCount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("GuarantorsCountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
	#endregion
}
