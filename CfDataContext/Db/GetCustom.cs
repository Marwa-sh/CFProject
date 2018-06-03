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
		#region EmployeeLoans procedure.


		[FunctionAttribute(Name = "dbo.EmployeeLoans", IsComposable = true)]
		private IQueryable<EmployeeLoansResult> _EmployeeLoans([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return this.CreateMethodCallQuery<EmployeeLoansResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of EmployeeLoansResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeLoansResult> EmployeeLoans([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			IQueryable<EmployeeLoansResult> list = _EmployeeLoans(_employeeId);
            return list.ToList<EmployeeLoansResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeLoansResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeLoansResult> EmployeeLoans(EmployeeLoansFilter filterInstance)
		{
			IQueryable<EmployeeLoansResult> list = _EmployeeLoans(filterInstance.EmployeeId);
            return list.ToList<EmployeeLoansResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of EmployeeLoansResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeLoansResult EmployeeLoansFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return EmployeeLoans(_employeeId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeLoansResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeLoansResult EmployeeLoansFirstOrDefault(EmployeeLoansFilter filterInstance)
		{
			return EmployeeLoans(filterInstance.EmployeeId).FirstOrDefault();
		}
		#endregion

		#region EmployeeMonthPayments procedure.


		[FunctionAttribute(Name = "dbo.EmployeeMonthPayments", IsComposable = true)]
		private IQueryable<EmployeeMonthPaymentsResult> _EmployeeMonthPayments([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			return this.CreateMethodCallQuery<EmployeeMonthPaymentsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeMonthPaymentsResult> EmployeeMonthPayments([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			IQueryable<EmployeeMonthPaymentsResult> list = _EmployeeMonthPayments(_month, _employee);
            return list.ToList<EmployeeMonthPaymentsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeMonthPaymentsResult> EmployeeMonthPayments(EmployeeMonthPaymentsFilter filterInstance)
		{
			IQueryable<EmployeeMonthPaymentsResult> list = _EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee);
            return list.ToList<EmployeeMonthPaymentsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of EmployeeMonthPaymentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			return EmployeeMonthPayments(_month, _employee).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeMonthPaymentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault(EmployeeMonthPaymentsFilter filterInstance)
		{
			return EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee).FirstOrDefault();
		}
		#endregion

		#region EmployeeMonthSubscriptions procedure.


		[FunctionAttribute(Name = "dbo.EmployeeMonthSubscriptions", IsComposable = true)]
		private IQueryable<EmployeeMonthSubscriptionsResult> _EmployeeMonthSubscriptions([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			return this.CreateMethodCallQuery<EmployeeMonthSubscriptionsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			IQueryable<EmployeeMonthSubscriptionsResult> list = _EmployeeMonthSubscriptions(_month, _employee);
            return list.ToList<EmployeeMonthSubscriptionsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions(EmployeeMonthSubscriptionsFilter filterInstance)
		{
			IQueryable<EmployeeMonthSubscriptionsResult> list = _EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee);
            return list.ToList<EmployeeMonthSubscriptionsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of EmployeeMonthSubscriptionsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			return EmployeeMonthSubscriptions(_month, _employee).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeMonthSubscriptionsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault(EmployeeMonthSubscriptionsFilter filterInstance)
		{
			return EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee).FirstOrDefault();
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

		#region GetDebts procedure.


		[FunctionAttribute(Name = "dbo.GetDebts", IsComposable = true)]
		private IQueryable<GetDebtsResult> _GetDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return this.CreateMethodCallQuery<GetDebtsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetDebtsResult> GetDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IQueryable<GetDebtsResult> list = _GetDebts(_employeeId, _date);
            return list.ToList<GetDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetDebtsResult> GetDebts(GetDebtsFilter filterInstance)
		{
			IQueryable<GetDebtsResult> list = _GetDebts(filterInstance.EmployeeId, filterInstance.Date);
            return list.ToList<GetDebtsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtsResult GetDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return GetDebts(_employeeId, _date).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtsResult GetDebtsFirstOrDefault(GetDebtsFilter filterInstance)
		{
			return GetDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault();
		}
		#endregion

		#region GetDebtScalar procedure.

		[Function(Name = "dbo.GetDebtScalar")]
		[return: Parameter(DbType = "money")]
		private decimal _GetDebtScalar([Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date, _employeeId);
			return (decimal) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_date"></param>
		/// <param name="_employeeId"></param>
		public decimal GetDebtScalar([Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			 return _GetDebtScalar(_date, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtScalarFilter that defines filtering options.</param>
		public decimal GetDebtScalar(GetDebtScalarFilter filterInstance)
		{
			 return _GetDebtScalar(filterInstance.Date, filterInstance.EmployeeId);
		}
		#endregion

		#region GetDebtSolvency procedure.


		[FunctionAttribute(Name = "dbo.GetDebtSolvency", IsComposable = true)]
		private IQueryable<GetDebtSolvencyResult> _GetDebtSolvency([Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			return this.CreateMethodCallQuery<GetDebtSolvencyResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetDebtSolvencyResult> GetDebtSolvency([Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			IQueryable<GetDebtSolvencyResult> list = _GetDebtSolvency(_productId);
            return list.ToList<GetDebtSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetDebtSolvencyResult> GetDebtSolvency(GetDebtSolvencyFilter filterInstance)
		{
			IQueryable<GetDebtSolvencyResult> list = _GetDebtSolvency(filterInstance.ProductId);
            return list.ToList<GetDebtSolvencyResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetDebtSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault([Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			return GetDebtSolvency(_productId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetDebtSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault(GetDebtSolvencyFilter filterInstance)
		{
			return GetDebtSolvency(filterInstance.ProductId).FirstOrDefault();
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

		#region GetEmployeeDebts procedure.


		[FunctionAttribute(Name = "dbo.GetEmployeeDebts", IsComposable = true)]
		private IQueryable<GetEmployeeDebtsResult> _GetEmployeeDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return this.CreateMethodCallQuery<GetEmployeeDebtsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeDebtsResult> GetEmployeeDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IQueryable<GetEmployeeDebtsResult> list = _GetEmployeeDebts(_employeeId, _date);
            return list.ToList<GetEmployeeDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeDebtsResult> GetEmployeeDebts(GetEmployeeDebtsFilter filterInstance)
		{
			IQueryable<GetEmployeeDebtsResult> list = _GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date);
            return list.ToList<GetEmployeeDebtsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetEmployeeDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return GetEmployeeDebts(_employeeId, _date).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault(GetEmployeeDebtsFilter filterInstance)
		{
			return GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault();
		}
		#endregion

		#region GetEmployeeSolvency procedure.


		[FunctionAttribute(Name = "dbo.GetEmployeeSolvency", IsComposable = true)]
		private IQueryable<GetEmployeeSolvencyResult> _GetEmployeeSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary)
		{
			return this.CreateMethodCallQuery<GetEmployeeSolvencyResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeSolvencyResult> GetEmployeeSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary)
		{
			IQueryable<GetEmployeeSolvencyResult> list = _GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
            return list.ToList<GetEmployeeSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeSolvencyResult> GetEmployeeSolvency(GetEmployeeSolvencyFilter filterInstance)
		{
			IQueryable<GetEmployeeSolvencyResult> list = _GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary);
            return list.ToList<GetEmployeeSolvencyResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetEmployeeSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary)
		{
			return GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault(GetEmployeeSolvencyFilter filterInstance)
		{
			return GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary).FirstOrDefault();
		}
		#endregion

		#region GetEmployeeSumDebts procedure.


		[FunctionAttribute(Name = "dbo.GetEmployeeSumDebts", IsComposable = true)]
		private IQueryable<GetEmployeeSumDebtsResult> _GetEmployeeSumDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return this.CreateMethodCallQuery<GetEmployeeSumDebtsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IQueryable<GetEmployeeSumDebtsResult> list = _GetEmployeeSumDebts(_employeeId, _date);
            return list.ToList<GetEmployeeSumDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts(GetEmployeeSumDebtsFilter filterInstance)
		{
			IQueryable<GetEmployeeSumDebtsResult> list = _GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date);
            return list.ToList<GetEmployeeSumDebtsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetEmployeeSumDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return GetEmployeeSumDebts(_employeeId, _date).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeSumDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault(GetEmployeeSumDebtsFilter filterInstance)
		{
			return GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault();
		}
		#endregion

		#region GetEmployeeWarrants procedure.


		[FunctionAttribute(Name = "dbo.GetEmployeeWarrants", IsComposable = true)]
		private IQueryable<GetEmployeeWarrantsResult> _GetEmployeeWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return this.CreateMethodCallQuery<GetEmployeeWarrantsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeWarrantsResult> GetEmployeeWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IQueryable<GetEmployeeWarrantsResult> list = _GetEmployeeWarrants(_employeeId, _date);
            return list.ToList<GetEmployeeWarrantsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetEmployeeWarrantsResult> GetEmployeeWarrants(GetEmployeeWarrantsFilter filterInstance)
		{
			IQueryable<GetEmployeeWarrantsResult> list = _GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date);
            return list.ToList<GetEmployeeWarrantsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetEmployeeWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return GetEmployeeWarrants(_employeeId, _date).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault(GetEmployeeWarrantsFilter filterInstance)
		{
			return GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault();
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

		#region GetWarrants procedure.


		[FunctionAttribute(Name = "dbo.GetWarrants", IsComposable = true)]
		private IQueryable<GetWarrantsResult> _GetWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return this.CreateMethodCallQuery<GetWarrantsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetWarrantsResult> GetWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IQueryable<GetWarrantsResult> list = _GetWarrants(_employeeId, _date);
            return list.ToList<GetWarrantsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetWarrantsResult> GetWarrants(GetWarrantsFilter filterInstance)
		{
			IQueryable<GetWarrantsResult> list = _GetWarrants(filterInstance.EmployeeId, filterInstance.Date);
            return list.ToList<GetWarrantsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantsResult GetWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return GetWarrants(_employeeId, _date).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
		/// <returns>An instance of GetWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantsResult GetWarrantsFirstOrDefault(GetWarrantsFilter filterInstance)
		{
			return GetWarrants(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault();
		}
		#endregion

		#region GetWarrantSolvency procedure.


		[FunctionAttribute(Name = "dbo.GetWarrantSolvency", IsComposable = true)]
		private IQueryable<GetWarrantSolvencyResult> _GetWarrantSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			return this.CreateMethodCallQuery<GetWarrantSolvencyResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetWarrantSolvencyResult> GetWarrantSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			IQueryable<GetWarrantSolvencyResult> list = _GetWarrantSolvency(_employeeId, _productId);
            return list.ToList<GetWarrantSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GetWarrantSolvencyResult> GetWarrantSolvency(GetWarrantSolvencyFilter filterInstance)
		{
			IQueryable<GetWarrantSolvencyResult> list = _GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId);
            return list.ToList<GetWarrantSolvencyResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of GetWarrantSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			return GetWarrantSolvency(_employeeId, _productId).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetWarrantSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault(GetWarrantSolvencyFilter filterInstance)
		{
			return GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId).FirstOrDefault();
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

		#region LoanMoveToEmployee procedure.

		[Function(Name = "dbo.LoanMoveToEmployee")]
		private int _LoanMoveToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _employeeId, _loanDecisionId);
			return (int) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_loan"></param>
		/// <param name="_employeeId"></param>
		/// <param name="_loanDecisionId"></param>
		public void LoanMoveToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId)
		{
			_LoanMoveToEmployee(_loan, _employeeId, _loanDecisionId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveToEmployeeFilter that defines filtering options.</param>
		public void LoanMoveToEmployee(LoanMoveToEmployeeFilter filterInstance)
		{
			_LoanMoveToEmployee(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId);
		}
		#endregion

		#region MonthlyBalanceSum procedure.


		[FunctionAttribute(Name = "dbo.MonthlyBalanceSum", IsComposable = true)]
		private IQueryable<MonthlyBalanceSumResult> _MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth)
		{
			return this.CreateMethodCallQuery<MonthlyBalanceSumResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minMonth, _maxMonth);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceSumResult> MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth)
		{
			IQueryable<MonthlyBalanceSumResult> list = _MonthlyBalanceSum(_minMonth, _maxMonth);
            return list.ToList<MonthlyBalanceSumResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceSumResult> MonthlyBalanceSum(MonthlyBalanceSumFilter filterInstance)
		{
			IQueryable<MonthlyBalanceSumResult> list = _MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth);
            return list.ToList<MonthlyBalanceSumResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of MonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth)
		{
			return MonthlyBalanceSum(_minMonth, _maxMonth).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
		/// <returns>An instance of MonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault(MonthlyBalanceSumFilter filterInstance)
		{
			return MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth).FirstOrDefault();
		}
		#endregion

		#region PaymentBetweenTwoDates procedure.


		[Function(Name = "dbo.PaymentBetweenTwoDates")]
		private ISingleResult<PaymentBetweenTwoDatesResult> _PaymentBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minDate, _maxDate);
			return (result.ReturnValue as ISingleResult<PaymentBetweenTwoDatesResult>);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of PaymentBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentBetweenTwoDatesResult> PaymentBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			ISingleResult<PaymentBetweenTwoDatesResult> list = _PaymentBetweenTwoDates(_minDate, _maxDate);
            return list.ToList<PaymentBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of PaymentBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of PaymentBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentBetweenTwoDatesResult> PaymentBetweenTwoDates(PaymentBetweenTwoDatesFilter filterInstance)
		{
			ISingleResult<PaymentBetweenTwoDatesResult> list = _PaymentBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate);
            return list.ToList<PaymentBetweenTwoDatesResult>();
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

		#region ReportLoansBetweenTwoDates procedure.


		[FunctionAttribute(Name = "dbo.ReportLoansBetweenTwoDates", IsComposable = true)]
		private IQueryable<ReportLoansBetweenTwoDatesResult> _ReportLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate)
		{
			return this.CreateMethodCallQuery<ReportLoansBetweenTwoDatesResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromDate, _toDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate)
		{
			IQueryable<ReportLoansBetweenTwoDatesResult> list = _ReportLoansBetweenTwoDates(_fromDate, _toDate);
            return list.ToList<ReportLoansBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates(ReportLoansBetweenTwoDatesFilter filterInstance)
		{
			IQueryable<ReportLoansBetweenTwoDatesResult> list = _ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate);
            return list.ToList<ReportLoansBetweenTwoDatesResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of ReportLoansBetweenTwoDatesResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate)
		{
			return ReportLoansBetweenTwoDates(_fromDate, _toDate).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
		/// <returns>An instance of ReportLoansBetweenTwoDatesResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault(ReportLoansBetweenTwoDatesFilter filterInstance)
		{
			return ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate).FirstOrDefault();
		}
		#endregion

		#region ReportPaymentsBetweenTwoDates procedure.


		[Function(Name = "dbo.ReportPaymentsBetweenTwoDates")]
		private ISingleResult<ReportPaymentsBetweenTwoDatesResult> _ReportPaymentsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@PaymentDiff")] Nullable<int> _paymentDiff)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstMonth, _secondMonth, _limit, _paymentDiff);
			return (result.ReturnValue as ISingleResult<ReportPaymentsBetweenTwoDatesResult>);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_paymentDiff"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of ReportPaymentsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportPaymentsBetweenTwoDatesResult> ReportPaymentsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@PaymentDiff")] Nullable<int> _paymentDiff)
		{
			ISingleResult<ReportPaymentsBetweenTwoDatesResult> list = _ReportPaymentsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _paymentDiff);
            return list.ToList<ReportPaymentsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportPaymentsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportPaymentsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportPaymentsBetweenTwoDatesResult> ReportPaymentsBetweenTwoDates(ReportPaymentsBetweenTwoDatesFilter filterInstance)
		{
			ISingleResult<ReportPaymentsBetweenTwoDatesResult> list = _ReportPaymentsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.PaymentDiff);
            return list.ToList<ReportPaymentsBetweenTwoDatesResult>();
		}
		#endregion

		#region ReportSubscriptionsBetweenTwoDates procedure.


		[Function(Name = "dbo.ReportSubscriptionsBetweenTwoDates")]
		private ISingleResult<ReportSubscriptionsBetweenTwoDatesResult> _ReportSubscriptionsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@SubscriptionDiff")] Nullable<int> _subscriptionDiff)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstMonth, _secondMonth, _limit, _subscriptionDiff);
			return (result.ReturnValue as ISingleResult<ReportSubscriptionsBetweenTwoDatesResult>);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_subscriptionDiff"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of ReportSubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportSubscriptionsBetweenTwoDatesResult> ReportSubscriptionsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@SubscriptionDiff")] Nullable<int> _subscriptionDiff)
		{
			ISingleResult<ReportSubscriptionsBetweenTwoDatesResult> list = _ReportSubscriptionsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _subscriptionDiff);
            return list.ToList<ReportSubscriptionsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportSubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportSubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportSubscriptionsBetweenTwoDatesResult> ReportSubscriptionsBetweenTwoDates(ReportSubscriptionsBetweenTwoDatesFilter filterInstance)
		{
			ISingleResult<ReportSubscriptionsBetweenTwoDatesResult> list = _ReportSubscriptionsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.SubscriptionDiff);
            return list.ToList<ReportSubscriptionsBetweenTwoDatesResult>();
		}
		#endregion

		#region RequestStatistics procedure.


		[FunctionAttribute(Name = "dbo.RequestStatistics", IsComposable = true)]
		private IQueryable<RequestStatisticsResult> _RequestStatistics([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			return this.CreateMethodCallQuery<RequestStatisticsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minDate, _maxDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatisticsResult> RequestStatistics([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			IQueryable<RequestStatisticsResult> list = _RequestStatistics(_minDate, _maxDate);
            return list.ToList<RequestStatisticsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
        /// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatisticsResult> RequestStatistics(RequestStatisticsFilter filterInstance)
		{
			IQueryable<RequestStatisticsResult> list = _RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate);
            return list.ToList<RequestStatisticsResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of RequestStatisticsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public RequestStatisticsResult RequestStatisticsFirstOrDefault([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			return RequestStatistics(_minDate, _maxDate).FirstOrDefault();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
		/// <returns>An instance of RequestStatisticsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public RequestStatisticsResult RequestStatisticsFirstOrDefault(RequestStatisticsFilter filterInstance)
		{
			return RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate).FirstOrDefault();
		}
		#endregion

		#region SubscriptionsBetweenTwoDates procedure.


		[Function(Name = "dbo.SubscriptionsBetweenTwoDates")]
		private ISingleResult<SubscriptionsBetweenTwoDatesResult> _SubscriptionsBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minDate, _maxDate);
			return (result.ReturnValue as ISingleResult<SubscriptionsBetweenTwoDatesResult>);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of SubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionsBetweenTwoDatesResult> SubscriptionsBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			ISingleResult<SubscriptionsBetweenTwoDatesResult> list = _SubscriptionsBetweenTwoDates(_minDate, _maxDate);
            return list.ToList<SubscriptionsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of SubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionsBetweenTwoDatesResult> SubscriptionsBetweenTwoDates(SubscriptionsBetweenTwoDatesFilter filterInstance)
		{
			ISingleResult<SubscriptionsBetweenTwoDatesResult> list = _SubscriptionsBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate);
            return list.ToList<SubscriptionsBetweenTwoDatesResult>();
		}
		#endregion
	}
	#endregion
}
