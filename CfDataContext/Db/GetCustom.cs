using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
	#region Db class definition
    public partial class Db
    {
		#region EmployeeProductCalculator procedure.


		[FunctionAttribute(Name = "dbo.EmployeeProductCalculator", IsComposable = true)]
		private IQueryable<EmployeeProductCalculatorResult> _EmployeeProductCalculator([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			return this.CreateMethodCallQuery<EmployeeProductCalculatorResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _productTypeId, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeProductCalculatorResult> EmployeeProductCalculator([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			IQueryable<EmployeeProductCalculatorResult> list = _EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period);
            return list.ToList<EmployeeProductCalculatorResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeProductCalculatorResult> EmployeeProductCalculator(EmployeeProductCalculatorFilter filterInstance)
		{
			IQueryable<EmployeeProductCalculatorResult> list = _EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period);            
            return list.ToList<EmployeeProductCalculatorResult>();
		}
		#endregion

		#region GetAvailabilityCeilingByProductTypeId_EmployeeId procedure.


		[FunctionAttribute(Name = "dbo.GetAvailabilityCeilingByProductTypeId_EmployeeId", IsComposable = true)]
		private IQueryable<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> _GetAvailabilityCeilingByProductTypeId_EmployeeId([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return this.CreateMethodCallQuery<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			IQueryable<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> list = _GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId);
            return list.ToList<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
        /// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance)
		{
			IQueryable<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> list = _GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId);
            return list.ToList<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
		}
		#endregion

		#region GetDueProfit procedure.

		[Function(Name = "dbo.GetDueProfit")]
		[return: Parameter(DbType = "money")]
		private decimal _GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<decimal> _rate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _amount, _period, _rate);
			return (decimal) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		public decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<decimal> _rate)
		{
			 return _GetDueProfit(_amount, _period, _rate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDueProfitFilter that defines filtering options.</param>
		public decimal GetDueProfit(GetDueProfitFilter filterInstance)
		{
			 return _GetDueProfit(filterInstance.Amount, filterInstance.Period, filterInstance.Rate);
		}
		#endregion

		#region GetFinancialRatio procedure.

		[Function(Name = "dbo.GetFinancialRatio")]
		[return: Parameter(DbType = "float")]
		private double _GetFinancialRatio([Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _period, _rate, _type);
			return (double) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public double GetFinancialRatio([Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			 return _GetFinancialRatio(_period, _rate, _type);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetFinancialRatioFilter that defines filtering options.</param>
		public double GetFinancialRatio(GetFinancialRatioFilter filterInstance)
		{
			 return _GetFinancialRatio(filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region GetInstallment procedure.

		[Function(Name = "dbo.GetInstallment")]
		[return: Parameter(DbType = "money")]
		private decimal _GetInstallment([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _amount, _period, _rate, _type);
			return (decimal) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public decimal GetInstallment([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			 return _GetInstallment(_amount, _period, _rate, _type);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentFilter that defines filtering options.</param>
		public decimal GetInstallment(GetInstallmentFilter filterInstance)
		{
			 return _GetInstallment(filterInstance.Amount, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region GetPresentValue procedure.

		[Function(Name = "dbo.GetPresentValue")]
		[return: Parameter(DbType = "money")]
		private decimal _GetPresentValue([Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment, _period, _rate, _type);
			return (decimal) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_installment"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public decimal GetPresentValue([Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			 return _GetPresentValue(_installment, _period, _rate, _type);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetPresentValueFilter that defines filtering options.</param>
		public decimal GetPresentValue(GetPresentValueFilter filterInstance)
		{
			 return _GetPresentValue(filterInstance.Installment, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region LoanGenerate procedure.

		[Function(Name = "dbo.LoanGenerate")]
		private int _LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId, _loanDecisionId, _loanGenerationStatusId);
			return (int) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <param name="_loanGenerationStatusId">معرف حالة توليد البطاقة</param>
		public void LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId)
		{
			_LoanGenerate(_productId, _loanDecisionId, _loanGenerationStatusId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanGenerateFilter that defines filtering options.</param>
		public void LoanGenerate(LoanGenerateFilter filterInstance)
		{
			_LoanGenerate(filterInstance.ProductId, filterInstance.LoanDecisionId, filterInstance.LoanGenerationStatusId);
		}
		#endregion

		#region ProductCalculator procedure.


		[FunctionAttribute(Name = "dbo.ProductCalculator", IsComposable = true)]
		private IQueryable<ProductCalculatorResult> _ProductCalculator([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			return this.CreateMethodCallQuery<ProductCalculatorResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductCalculatorResult> ProductCalculator([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			IQueryable<ProductCalculatorResult> list = _ProductCalculator(_productType, _amount, _period);
            return list.ToList<ProductCalculatorResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
        /// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductCalculatorResult> ProductCalculator(ProductCalculatorFilter filterInstance)
		{
			IQueryable<ProductCalculatorResult> list = _ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period);
            return list.ToList<ProductCalculatorResult>();
		}
		#endregion
	}
	#endregion

	#region EmployeeProductCalculator filter and result classes
    #region EmployeeProductCalculatorFilter class definition
	/// <summary>
    /// Filter class for EmployeeProductCalculator.
	/// </summary>
	public partial class EmployeeProductCalculatorFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductTypeId {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		#endregion
	}
	#endregion

    #region EmployeeProductCalculatorResult class definition
	/// <summary>
    /// Result class for EmployeeProductCalculator.
	/// </summary>
	public partial class EmployeeProductCalculatorResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public string FullName {get; set; }
		
        public Nullable<DateTime> CersStartDate {get; set; }
		
        public Nullable<DateTime> CfStartDate {get; set; }
		
        public Nullable<DateTime> LeaveDate {get; set; }
		
        public string LeaveReason {get; set; }
		
        public int DepartmentId {get; set; }
		
        public string DepartmentName {get; set; }
		
        public int DepartmentSalaryWorkPlaceId {get; set; }
		
        public string DepartmentSalaryWorkPlaceName {get; set; }
		
        public byte EmployeeStatusId {get; set; }
		
        public string EmployeeStatusName {get; set; }
		
        public byte CategoryId {get; set; }
		
        public string CategoryName {get; set; }
		
        public Nullable<decimal> MaxAmount {get; set; }
		
        public Nullable<short> Seniority {get; set; }
		
        public Nullable<byte> MinSeniority {get; set; }
		
        public Nullable<byte> MinReusePeriod {get; set; }
		
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public Nullable<decimal> NetAmount {get; set; }
		
        public Nullable<decimal> ProfitAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		
        public Nullable<double> Rate {get; set; }
		
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetAvailabilityCeilingByProductTypeId_EmployeeId filter and result classes
    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter class definition
	/// <summary>
    /// Filter class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductTypeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdResult class definition
	/// <summary>
    /// Result class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<short> Seniority {get; set; }
		
        public Nullable<byte> MinSeniority {get; set; }
		
        public Nullable<byte> MinReusePeriod {get; set; }
		
        public Nullable<decimal> MaxAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetDueProfit filter and result classes
    #region GetDueProfitFilter class definition
	/// <summary>
    /// Filter class for GetDueProfit.
	/// </summary>
	public partial class GetDueProfitFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Rate {get; set; }
		#endregion
	}
	#endregion

    #region GetDueProfit result class
    public class GetDueProfitResult
    {
        internal GetDueProfitResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetFinancialRatio filter and result classes
    #region GetFinancialRatioFilter class definition
	/// <summary>
    /// Filter class for GetFinancialRatio.
	/// </summary>
	public partial class GetFinancialRatioFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetFinancialRatio result class
    public class GetFinancialRatioResult
    {
        internal GetFinancialRatioResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetInstallment filter and result classes
    #region GetInstallmentFilter class definition
	/// <summary>
    /// Filter class for GetInstallment.
	/// </summary>
	public partial class GetInstallmentFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetInstallment result class
    public class GetInstallmentResult
    {
        internal GetInstallmentResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetPresentValue filter and result classes
    #region GetPresentValueFilter class definition
	/// <summary>
    /// Filter class for GetPresentValue.
	/// </summary>
	public partial class GetPresentValueFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Installment {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetPresentValue result class
    public class GetPresentValueResult
    {
        internal GetPresentValueResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region LoanGenerate filter and result classes
    #region LoanGenerateFilter class definition
	/// <summary>
    /// Filter class for LoanGenerate.
	/// </summary>
	public partial class LoanGenerateFilter
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> ProductId {get; set; }
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanDecisionId {get; set; }
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanGenerationStatusId {get; set; }
		#endregion
	}
	#endregion

    #region LoanGenerate result class
    public class LoanGenerateResult
    {
        internal LoanGenerateResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region ProductCalculator filter and result classes
    #region ProductCalculatorFilter class definition
	/// <summary>
    /// Filter class for ProductCalculator.
	/// </summary>
	public partial class ProductCalculatorFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductType {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		#endregion
	}
	#endregion

    #region ProductCalculatorResult class definition
	/// <summary>
    /// Result class for ProductCalculator.
	/// </summary>
	public partial class ProductCalculatorResult
	{
		#region Public properties
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public Nullable<decimal> NetAmount {get; set; }
		
        public Nullable<decimal> ProfitAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		
        public Nullable<double> Rate {get; set; }
		
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
    #endregion
}
