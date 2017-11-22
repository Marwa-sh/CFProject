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
		#region EmployeeCustom procedure.


		[Function(Name = "dbo.EmployeeCustom")]
        [ResultType(typeof(EmployeeCustomResult1))]
        [ResultType(typeof(EmployeeCustomResult2))]
		private IMultipleResults _EmployeeCustom()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (IMultipleResults)(result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of EmployeeCustomResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public EmployeeCustomResult EmployeeCustom()
		{
			IMultipleResults multipleResult = _EmployeeCustom();
            EmployeeCustomResult result =
                new EmployeeCustomResult
                (
                    multipleResult.GetResult<EmployeeCustomResult1>().ToList<EmployeeCustomResult1>(),
                    multipleResult.GetResult<EmployeeCustomResult2>().ToList<EmployeeCustomResult2>()
                );
            return result;
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeCustomFilter that defines filtering options.</param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>A list of EmployeeCustomResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public EmployeeCustomResult EmployeeCustom(EmployeeCustomFilter filterInstance)
		{
			IMultipleResults multipleResult = _EmployeeCustom();
            EmployeeCustomResult result =
                new EmployeeCustomResult
                (
                    multipleResult.GetResult<EmployeeCustomResult1>().ToList<EmployeeCustomResult1>(),
                    multipleResult.GetResult<EmployeeCustomResult2>().ToList<EmployeeCustomResult2>()
                );
            return result;
		}
		#endregion

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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of EmployeeProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			return EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault(EmployeeProductCalculatorFilter filterInstance)
		{
			return EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period).FirstOrDefault();
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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
		/// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance)
		{
			return GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId).FirstOrDefault();
		}
		#endregion

		#region GetDueProfit procedure.

		[Function(Name = "dbo.GetDueProfit")]
		[return: Parameter(DbType = "money")]
		private decimal _GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate)
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
		public decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate)
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

		#region GetInstallmentPaidAmounts procedure.


		[FunctionAttribute(Name = "dbo.GetInstallmentPaidAmounts", IsComposable = true)]
		private IQueryable<GetInstallmentPaidAmountsResult> _GetInstallmentPaidAmounts([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			return this.CreateMethodCallQuery<GetInstallmentPaidAmountsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			IQueryable<GetInstallmentPaidAmountsResult> list = _GetInstallmentPaidAmounts(_refundableProductId);
            return list.ToList<GetInstallmentPaidAmountsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts(GetInstallmentPaidAmountsFilter filterInstance)
		{
			IQueryable<GetInstallmentPaidAmountsResult> list = _GetInstallmentPaidAmounts(filterInstance.RefundableProductId);
            return list.ToList<GetInstallmentPaidAmountsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetInstallmentPaidAmountsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			return GetInstallmentPaidAmounts(_refundableProductId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
		/// <returns>An instance of GetInstallmentPaidAmountsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault(GetInstallmentPaidAmountsFilter filterInstance)
		{
			return GetInstallmentPaidAmounts(filterInstance.RefundableProductId).FirstOrDefault();
		}
		#endregion

		#region GetInstallments procedure.


		[FunctionAttribute(Name = "dbo.GetInstallments", IsComposable = true)]
		private IQueryable<GetInstallmentsResult> _GetInstallments([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			return this.CreateMethodCallQuery<GetInstallmentsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetInstallmentsResult> GetInstallments([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			IQueryable<GetInstallmentsResult> list = _GetInstallments(_refundableProductId);
            return list.ToList<GetInstallmentsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetInstallmentsResult> GetInstallments(GetInstallmentsFilter filterInstance)
		{
			IQueryable<GetInstallmentsResult> list = _GetInstallments(filterInstance.RefundableProductId);
            return list.ToList<GetInstallmentsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetInstallmentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentsResult GetInstallmentsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			return GetInstallments(_refundableProductId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
		/// <returns>An instance of GetInstallmentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentsResult GetInstallmentsFirstOrDefault(GetInstallmentsFilter filterInstance)
		{
			return GetInstallments(filterInstance.RefundableProductId).FirstOrDefault();
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

		#region GetRefundableProducts procedure.


		[FunctionAttribute(Name = "dbo.GetRefundableProducts", IsComposable = true)]
		private IQueryable<GetRefundableProductsResult> _GetRefundableProducts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return this.CreateMethodCallQuery<GetRefundableProductsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetRefundableProductsResult> GetRefundableProducts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			IQueryable<GetRefundableProductsResult> list = _GetRefundableProducts(_employeeId);
            return list.ToList<GetRefundableProductsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
        /// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetRefundableProductsResult> GetRefundableProducts(GetRefundableProductsFilter filterInstance)
		{
			IQueryable<GetRefundableProductsResult> list = _GetRefundableProducts(filterInstance.EmployeeId);
            return list.ToList<GetRefundableProductsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetRefundableProductsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetRefundableProductsResult GetRefundableProductsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return GetRefundableProducts(_employeeId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
		/// <returns>An instance of GetRefundableProductsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetRefundableProductsResult GetRefundableProductsFirstOrDefault(GetRefundableProductsFilter filterInstance)
		{
			return GetRefundableProducts(filterInstance.EmployeeId).FirstOrDefault();
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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of ProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ProductCalculatorResult ProductCalculatorFirstOrDefault([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			return ProductCalculator(_productType, _amount, _period).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
		/// <returns>An instance of ProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ProductCalculatorResult ProductCalculatorFirstOrDefault(ProductCalculatorFilter filterInstance)
		{
			return ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period).FirstOrDefault();
		}
		#endregion
	}
	#endregion
}
