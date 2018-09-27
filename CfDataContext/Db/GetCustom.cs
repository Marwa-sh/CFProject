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
			return _EmployeeLoans(_employeeId).ToList<EmployeeLoansResult>();
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
			return _EmployeeLoans(filterInstance.EmployeeId).ToList<EmployeeLoansResult>();
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
			return _EmployeeLoans(_employeeId).FirstOrDefault<EmployeeLoansResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeLoansResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeLoansResult EmployeeLoansFirstOrDefault(EmployeeLoansFilter filterInstance)
		{
			return _EmployeeLoans(filterInstance.EmployeeId).FirstOrDefault<EmployeeLoansResult>();
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
			return _EmployeeMonthPayments(_month, _employee).ToList<EmployeeMonthPaymentsResult>();
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
			return _EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee).ToList<EmployeeMonthPaymentsResult>();
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
			return _EmployeeMonthPayments(_month, _employee).FirstOrDefault<EmployeeMonthPaymentsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeMonthPaymentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault(EmployeeMonthPaymentsFilter filterInstance)
		{
			return _EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee).FirstOrDefault<EmployeeMonthPaymentsResult>();
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
			return _EmployeeMonthSubscriptions(_month, _employee).ToList<EmployeeMonthSubscriptionsResult>();
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
			return _EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee).ToList<EmployeeMonthSubscriptionsResult>();
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
			return _EmployeeMonthSubscriptions(_month, _employee).FirstOrDefault<EmployeeMonthSubscriptionsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeMonthSubscriptionsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault(EmployeeMonthSubscriptionsFilter filterInstance)
		{
			return _EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee).FirstOrDefault<EmployeeMonthSubscriptionsResult>();
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
			return _EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period).ToList<EmployeeProductCalculatorResult>();
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
			return _EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period).ToList<EmployeeProductCalculatorResult>();
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
			return _EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period).FirstOrDefault<EmployeeProductCalculatorResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
		/// <returns>An instance of EmployeeProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault(EmployeeProductCalculatorFilter filterInstance)
		{
			return _EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period).FirstOrDefault<EmployeeProductCalculatorResult>();
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
			return _GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId).ToList<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
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
			return _GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId).ToList<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
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
			return _GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId).FirstOrDefault<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
		/// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance)
		{
			return _GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId).FirstOrDefault<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult>();
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
			return _GetDebts(_employeeId, _date).ToList<GetDebtsResult>();
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
			return _GetDebts(filterInstance.EmployeeId, filterInstance.Date).ToList<GetDebtsResult>();
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
			return _GetDebts(_employeeId, _date).FirstOrDefault<GetDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtsResult GetDebtsFirstOrDefault(GetDebtsFilter filterInstance)
		{
			return _GetDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault<GetDebtsResult>();
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
			return _GetDebtSolvency(_productId).ToList<GetDebtSolvencyResult>();
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
			return _GetDebtSolvency(filterInstance.ProductId).ToList<GetDebtSolvencyResult>();
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
			return _GetDebtSolvency(_productId).FirstOrDefault<GetDebtSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetDebtSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault(GetDebtSolvencyFilter filterInstance)
		{
			return _GetDebtSolvency(filterInstance.ProductId).FirstOrDefault<GetDebtSolvencyResult>();
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
			return _GetEmployeeDebts(_employeeId, _date).ToList<GetEmployeeDebtsResult>();
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
			return _GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date).ToList<GetEmployeeDebtsResult>();
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
			return _GetEmployeeDebts(_employeeId, _date).FirstOrDefault<GetEmployeeDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault(GetEmployeeDebtsFilter filterInstance)
		{
			return _GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault<GetEmployeeDebtsResult>();
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
			return _GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary).ToList<GetEmployeeSolvencyResult>();
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
			return _GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary).ToList<GetEmployeeSolvencyResult>();
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
			return _GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary).FirstOrDefault<GetEmployeeSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault(GetEmployeeSolvencyFilter filterInstance)
		{
			return _GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary).FirstOrDefault<GetEmployeeSolvencyResult>();
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
			return _GetEmployeeSumDebts(_employeeId, _date).ToList<GetEmployeeSumDebtsResult>();
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
			return _GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date).ToList<GetEmployeeSumDebtsResult>();
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
			return _GetEmployeeSumDebts(_employeeId, _date).FirstOrDefault<GetEmployeeSumDebtsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeSumDebtsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault(GetEmployeeSumDebtsFilter filterInstance)
		{
			return _GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault<GetEmployeeSumDebtsResult>();
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
			return _GetEmployeeWarrants(_employeeId, _date).ToList<GetEmployeeWarrantsResult>();
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
			return _GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date).ToList<GetEmployeeWarrantsResult>();
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
			return _GetEmployeeWarrants(_employeeId, _date).FirstOrDefault<GetEmployeeWarrantsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
		/// <returns>An instance of GetEmployeeWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault(GetEmployeeWarrantsFilter filterInstance)
		{
			return _GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault<GetEmployeeWarrantsResult>();
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
			return _GetInstallmentPaidAmounts(_refundableProductId).ToList<GetInstallmentPaidAmountsResult>();
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
			return _GetInstallmentPaidAmounts(filterInstance.RefundableProductId).ToList<GetInstallmentPaidAmountsResult>();
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
			return _GetInstallmentPaidAmounts(_refundableProductId).FirstOrDefault<GetInstallmentPaidAmountsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
		/// <returns>An instance of GetInstallmentPaidAmountsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault(GetInstallmentPaidAmountsFilter filterInstance)
		{
			return _GetInstallmentPaidAmounts(filterInstance.RefundableProductId).FirstOrDefault<GetInstallmentPaidAmountsResult>();
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
			return _GetInstallments(_refundableProductId).ToList<GetInstallmentsResult>();
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
			return _GetInstallments(filterInstance.RefundableProductId).ToList<GetInstallmentsResult>();
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
			return _GetInstallments(_refundableProductId).FirstOrDefault<GetInstallmentsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
		/// <returns>An instance of GetInstallmentsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetInstallmentsResult GetInstallmentsFirstOrDefault(GetInstallmentsFilter filterInstance)
		{
			return _GetInstallments(filterInstance.RefundableProductId).FirstOrDefault<GetInstallmentsResult>();
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
			return _GetRefundableProducts(_employeeId).ToList<GetRefundableProductsResult>();
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
			return _GetRefundableProducts(filterInstance.EmployeeId).ToList<GetRefundableProductsResult>();
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
			return _GetRefundableProducts(_employeeId).FirstOrDefault<GetRefundableProductsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
		/// <returns>An instance of GetRefundableProductsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetRefundableProductsResult GetRefundableProductsFirstOrDefault(GetRefundableProductsFilter filterInstance)
		{
			return _GetRefundableProducts(filterInstance.EmployeeId).FirstOrDefault<GetRefundableProductsResult>();
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
			return _GetWarrants(_employeeId, _date).ToList<GetWarrantsResult>();
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
			return _GetWarrants(filterInstance.EmployeeId, filterInstance.Date).ToList<GetWarrantsResult>();
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
			return _GetWarrants(_employeeId, _date).FirstOrDefault<GetWarrantsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
		/// <returns>An instance of GetWarrantsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantsResult GetWarrantsFirstOrDefault(GetWarrantsFilter filterInstance)
		{
			return _GetWarrants(filterInstance.EmployeeId, filterInstance.Date).FirstOrDefault<GetWarrantsResult>();
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
			return _GetWarrantSolvency(_employeeId, _productId).ToList<GetWarrantSolvencyResult>();
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
			return _GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId).ToList<GetWarrantSolvencyResult>();
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
			return _GetWarrantSolvency(_employeeId, _productId).FirstOrDefault<GetWarrantSolvencyResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
		/// <returns>An instance of GetWarrantSolvencyResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault(GetWarrantSolvencyFilter filterInstance)
		{
			return _GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId).FirstOrDefault<GetWarrantSolvencyResult>();
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
		private IQueryable<MonthlyBalanceSumResult> _MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return this.CreateMethodCallQuery<MonthlyBalanceSumResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceSumResult> MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return _MonthlyBalanceSum(_minMonth, _maxMonth, _employeeId).ToList<MonthlyBalanceSumResult>();
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
			return _MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId).ToList<MonthlyBalanceSumResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of MonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return _MonthlyBalanceSum(_minMonth, _maxMonth, _employeeId).FirstOrDefault<MonthlyBalanceSumResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
		/// <returns>An instance of MonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault(MonthlyBalanceSumFilter filterInstance)
		{
			return _MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId).FirstOrDefault<MonthlyBalanceSumResult>();
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
			return _PaymentBetweenTwoDates(_minDate, _maxDate).ToList<PaymentBetweenTwoDatesResult>();
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
			return _PaymentBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate).ToList<PaymentBetweenTwoDatesResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>An instance of type PaymentBetweenTwoDatesResult or null.</returns>
		public PaymentBetweenTwoDatesResult PaymentBetweenTwoDatesFirstOrDefault([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			return _PaymentBetweenTwoDates(_minDate, _maxDate).FirstOrDefault<PaymentBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of PaymentBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of type PaymentBetweenTwoDatesResult or null.</returns>
		public PaymentBetweenTwoDatesResult PaymentBetweenTwoDatesFirstOrDefault(PaymentBetweenTwoDatesFilter filterInstance)
		{
			return _PaymentBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate).FirstOrDefault<PaymentBetweenTwoDatesResult>();
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
			return _ProductCalculator(_productType, _amount, _period).ToList<ProductCalculatorResult>();
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
			return _ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period).ToList<ProductCalculatorResult>();
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
			return _ProductCalculator(_productType, _amount, _period).FirstOrDefault<ProductCalculatorResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
		/// <returns>An instance of ProductCalculatorResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ProductCalculatorResult ProductCalculatorFirstOrDefault(ProductCalculatorFilter filterInstance)
		{
			return _ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period).FirstOrDefault<ProductCalculatorResult>();
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
			return _ReportLoansBetweenTwoDates(_fromDate, _toDate).ToList<ReportLoansBetweenTwoDatesResult>();
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
			return _ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate).ToList<ReportLoansBetweenTwoDatesResult>();
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
			return _ReportLoansBetweenTwoDates(_fromDate, _toDate).FirstOrDefault<ReportLoansBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
		/// <returns>An instance of ReportLoansBetweenTwoDatesResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault(ReportLoansBetweenTwoDatesFilter filterInstance)
		{
			return _ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate).FirstOrDefault<ReportLoansBetweenTwoDatesResult>();
		}
		#endregion

		#region ReportMonthlyBalanceSum procedure.

		[FunctionAttribute(Name = "dbo.ReportMonthlyBalanceSum", IsComposable = true)]
		private IQueryable<ReportMonthlyBalanceSumResult> _ReportMonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return this.CreateMethodCallQuery<ReportMonthlyBalanceSumResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return _ReportMonthlyBalanceSum(_minMonth, _maxMonth, _employeeId).ToList<ReportMonthlyBalanceSumResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum(ReportMonthlyBalanceSumFilter filterInstance)
		{
			return _ReportMonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId).ToList<ReportMonthlyBalanceSumResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>An instance of ReportMonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			return _ReportMonthlyBalanceSum(_minMonth, _maxMonth, _employeeId).FirstOrDefault<ReportMonthlyBalanceSumResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
		/// <returns>An instance of ReportMonthlyBalanceSumResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault(ReportMonthlyBalanceSumFilter filterInstance)
		{
			return _ReportMonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId).FirstOrDefault<ReportMonthlyBalanceSumResult>();
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
			return _ReportPaymentsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _paymentDiff).ToList<ReportPaymentsBetweenTwoDatesResult>();
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
			return _ReportPaymentsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.PaymentDiff).ToList<ReportPaymentsBetweenTwoDatesResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_paymentDiff"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>An instance of type ReportPaymentsBetweenTwoDatesResult or null.</returns>
		public ReportPaymentsBetweenTwoDatesResult ReportPaymentsBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@PaymentDiff")] Nullable<int> _paymentDiff)
		{
			return _ReportPaymentsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _paymentDiff).FirstOrDefault<ReportPaymentsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportPaymentsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of type ReportPaymentsBetweenTwoDatesResult or null.</returns>
		public ReportPaymentsBetweenTwoDatesResult ReportPaymentsBetweenTwoDatesFirstOrDefault(ReportPaymentsBetweenTwoDatesFilter filterInstance)
		{
			return _ReportPaymentsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.PaymentDiff).FirstOrDefault<ReportPaymentsBetweenTwoDatesResult>();
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
			return _ReportSubscriptionsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _subscriptionDiff).ToList<ReportSubscriptionsBetweenTwoDatesResult>();
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
			return _ReportSubscriptionsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.SubscriptionDiff).ToList<ReportSubscriptionsBetweenTwoDatesResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_subscriptionDiff"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>An instance of type ReportSubscriptionsBetweenTwoDatesResult or null.</returns>
		public ReportSubscriptionsBetweenTwoDatesResult ReportSubscriptionsBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@SubscriptionDiff")] Nullable<int> _subscriptionDiff)
		{
			return _ReportSubscriptionsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _subscriptionDiff).FirstOrDefault<ReportSubscriptionsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportSubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of type ReportSubscriptionsBetweenTwoDatesResult or null.</returns>
		public ReportSubscriptionsBetweenTwoDatesResult ReportSubscriptionsBetweenTwoDatesFirstOrDefault(ReportSubscriptionsBetweenTwoDatesFilter filterInstance)
		{
			return _ReportSubscriptionsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.SubscriptionDiff).FirstOrDefault<ReportSubscriptionsBetweenTwoDatesResult>();
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
			return _RequestStatistics(_minDate, _maxDate).ToList<RequestStatisticsResult>();
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
			return _RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate).ToList<RequestStatisticsResult>();
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
			return _RequestStatistics(_minDate, _maxDate).FirstOrDefault<RequestStatisticsResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
		/// <returns>An instance of RequestStatisticsResult.</returns>
		/// <remarks>If no instances the method returns null.</remarks>
		public RequestStatisticsResult RequestStatisticsFirstOrDefault(RequestStatisticsFilter filterInstance)
		{
			return _RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate).FirstOrDefault<RequestStatisticsResult>();
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
			return _SubscriptionsBetweenTwoDates(_minDate, _maxDate).ToList<SubscriptionsBetweenTwoDatesResult>();
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
			return _SubscriptionsBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate).ToList<SubscriptionsBetweenTwoDatesResult>();
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>An instance of type SubscriptionsBetweenTwoDatesResult or null.</returns>
		public SubscriptionsBetweenTwoDatesResult SubscriptionsBetweenTwoDatesFirstOrDefault([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			return _SubscriptionsBetweenTwoDates(_minDate, _maxDate).FirstOrDefault<SubscriptionsBetweenTwoDatesResult>();
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of type SubscriptionsBetweenTwoDatesResult or null.</returns>
		public SubscriptionsBetweenTwoDatesResult SubscriptionsBetweenTwoDatesFirstOrDefault(SubscriptionsBetweenTwoDatesFilter filterInstance)
		{
			return _SubscriptionsBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate).FirstOrDefault<SubscriptionsBetweenTwoDatesResult>();
		}
		#endregion

		#region SumComingLoansForEmployee procedure.

		[Function(Name = "dbo.SumComingLoansForEmployee")]
		[return: Parameter(DbType = "float")]
		private double _SumComingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromDate, _toDate, _employee);
			return (double) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public double SumComingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			 return _SumComingLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumComingLoansForEmployeeFilter that defines filtering options.</param>
		public double SumComingLoansForEmployee(SumComingLoansForEmployeeFilter filterInstance)
		{
			 return _SumComingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion

		#region SumLoansForEmployee procedure.

		[Function(Name = "dbo.SumLoansForEmployee")]
		[return: Parameter(DbType = "float")]
		private double _SumLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromDate, _toDate, _employee);
			return (double) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public double SumLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			 return _SumLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumLoansForEmployeeFilter that defines filtering options.</param>
		public double SumLoansForEmployee(SumLoansForEmployeeFilter filterInstance)
		{
			 return _SumLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion

		#region SumOutgoingLoansForEmployee procedure.

		[Function(Name = "dbo.SumOutgoingLoansForEmployee")]
		[return: Parameter(DbType = "float")]
		private double _SumOutgoingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromDate, _toDate, _employee);
			return (double) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public double SumOutgoingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			 return _SumOutgoingLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumOutgoingLoansForEmployeeFilter that defines filtering options.</param>
		public double SumOutgoingLoansForEmployee(SumOutgoingLoansForEmployeeFilter filterInstance)
		{
			 return _SumOutgoingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion
	}
	#endregion
}
