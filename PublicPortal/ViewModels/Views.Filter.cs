using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Cf.Data;

namespace Cf.ViewModels
{
    #region CashPaymentVw class definition
    public partial class CashPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public CashPaymentVwFilter Filter {get; set; } = new CashPaymentVwFilter();
        #endregion
	}
	#endregion

    #region CollectOrderVw class definition
    public partial class CollectOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public CollectOrderVwFilter Filter {get; set; } = new CollectOrderVwFilter();
        #endregion
	}
	#endregion

    #region DebtVw class definition
    public partial class DebtVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public DebtVwFilter Filter {get; set; } = new DebtVwFilter();
        #endregion
	}
	#endregion

    #region DepartmentVw class definition
    public partial class DepartmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public DepartmentVwFilter Filter {get; set; } = new DepartmentVwFilter();
        #endregion
	}
	#endregion

    #region DownPaymentVw class definition
    public partial class DownPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public DownPaymentVwFilter Filter {get; set; } = new DownPaymentVwFilter();
        #endregion
	}
	#endregion

    #region EmployeeVw class definition
    public partial class EmployeeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public EmployeeVwFilter Filter {get; set; } = new EmployeeVwFilter();
        #endregion
	}
	#endregion

    #region ErrorDefinitionVw class definition
    public partial class ErrorDefinitionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public ErrorDefinitionVwFilter Filter {get; set; } = new ErrorDefinitionVwFilter();
        #endregion
	}
	#endregion

    #region EventCategoryVw class definition
    public partial class EventCategoryVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public EventCategoryVwFilter Filter {get; set; } = new EventCategoryVwFilter();
        #endregion
	}
	#endregion

    #region EventLogErrorVw class definition
    public partial class EventLogErrorVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public EventLogErrorVwFilter Filter {get; set; } = new EventLogErrorVwFilter();
        #endregion
	}
	#endregion

    #region EventLogVw class definition
    public partial class EventLogVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public EventLogVwFilter Filter {get; set; } = new EventLogVwFilter();
        #endregion
	}
	#endregion

    #region ExternalGrantVw class definition
    public partial class ExternalGrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public ExternalGrantVwFilter Filter {get; set; } = new ExternalGrantVwFilter();
        #endregion
	}
	#endregion

    #region GrantDecisionVw class definition
    public partial class GrantDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GrantDecisionVwFilter Filter {get; set; } = new GrantDecisionVwFilter();
        #endregion
	}
	#endregion

    #region GrantPaymentOrderVw class definition
    public partial class GrantPaymentOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GrantPaymentOrderVwFilter Filter {get; set; } = new GrantPaymentOrderVwFilter();
        #endregion
	}
	#endregion

    #region GrantPaymentVw class definition
    public partial class GrantPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GrantPaymentVwFilter Filter {get; set; } = new GrantPaymentVwFilter();
        #endregion
	}
	#endregion

    #region GrantRequestVw class definition
    public partial class GrantRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GrantRequestVwFilter Filter {get; set; } = new GrantRequestVwFilter();
        #endregion
	}
	#endregion

    #region GrantVw class definition
    public partial class GrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GrantVwFilter Filter {get; set; } = new GrantVwFilter();
        #endregion
	}
	#endregion

    #region GuarantorVw class definition
    public partial class GuarantorVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public GuarantorVwFilter Filter {get; set; } = new GuarantorVwFilter();
        #endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPaymentVw class definition
    public partial class HealthLoanDecisionFirstPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public HealthLoanDecisionFirstPaymentVwFilter Filter {get; set; } = new HealthLoanDecisionFirstPaymentVwFilter();
        #endregion
	}
	#endregion

    #region HealthLoanDecisionVw class definition
    public partial class HealthLoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public HealthLoanDecisionVwFilter Filter {get; set; } = new HealthLoanDecisionVwFilter();
        #endregion
	}
	#endregion

    #region IncomingLoanVw class definition
    public partial class IncomingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public IncomingLoanVwFilter Filter {get; set; } = new IncomingLoanVwFilter();
        #endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVw class definition
    public partial class InstallmentDecreaseOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public InstallmentDecreaseOrderVwFilter Filter {get; set; } = new InstallmentDecreaseOrderVwFilter();
        #endregion
	}
	#endregion

    #region InstallmentDecreaseVw class definition
    public partial class InstallmentDecreaseVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public InstallmentDecreaseVwFilter Filter {get; set; } = new InstallmentDecreaseVwFilter();
        #endregion
	}
	#endregion

    #region InstallmentVw class definition
    public partial class InstallmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public InstallmentVwFilter Filter {get; set; } = new InstallmentVwFilter();
        #endregion
	}
	#endregion

    #region LoanChangeVw class definition
    public partial class LoanChangeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public LoanChangeVwFilter Filter {get; set; } = new LoanChangeVwFilter();
        #endregion
	}
	#endregion

    #region LoanDecisionVw class definition
    public partial class LoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public LoanDecisionVwFilter Filter {get; set; } = new LoanDecisionVwFilter();
        #endregion
	}
	#endregion

    #region LoanRequestVw class definition
    public partial class LoanRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public LoanRequestVwFilter Filter {get; set; } = new LoanRequestVwFilter();
        #endregion
	}
	#endregion

    #region LoanTypeVw class definition
    public partial class LoanTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public LoanTypeVwFilter Filter {get; set; } = new LoanTypeVwFilter();
        #endregion
	}
	#endregion

    #region LoanVw class definition
    public partial class LoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public LoanVwFilter Filter {get; set; } = new LoanVwFilter();
        #endregion
	}
	#endregion

    #region MissingInstallmentDecreaseVw class definition
    public partial class MissingInstallmentDecreaseVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public MissingInstallmentDecreaseVwFilter Filter {get; set; } = new MissingInstallmentDecreaseVwFilter();
        #endregion
	}
	#endregion

    #region MonthlyBalanceVw class definition
    public partial class MonthlyBalanceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public MonthlyBalanceVwFilter Filter {get; set; } = new MonthlyBalanceVwFilter();
        #endregion
	}
	#endregion

    #region OutgoingLoanVw class definition
    public partial class OutgoingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public OutgoingLoanVwFilter Filter {get; set; } = new OutgoingLoanVwFilter();
        #endregion
	}
	#endregion

    #region PaymentVw class definition
    public partial class PaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public PaymentVwFilter Filter {get; set; } = new PaymentVwFilter();
        #endregion
	}
	#endregion

    #region PayOrderVw class definition
    public partial class PayOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public PayOrderVwFilter Filter {get; set; } = new PayOrderVwFilter();
        #endregion
	}
	#endregion

    #region ProductVw class definition
    public partial class ProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public ProductVwFilter Filter {get; set; } = new ProductVwFilter();
        #endregion
	}
	#endregion

    #region RefundableProductVw class definition
    public partial class RefundableProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public RefundableProductVwFilter Filter {get; set; } = new RefundableProductVwFilter();
        #endregion
	}
	#endregion

    #region RequestVw class definition
    public partial class RequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public RequestVwFilter Filter {get; set; } = new RequestVwFilter();
        #endregion
	}
	#endregion

    #region ResourceVw class definition
    public partial class ResourceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public ResourceVwFilter Filter {get; set; } = new ResourceVwFilter();
        #endregion
	}
	#endregion

    #region SalaryPaymentVw class definition
    public partial class SalaryPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public SalaryPaymentVwFilter Filter {get; set; } = new SalaryPaymentVwFilter();
        #endregion
	}
	#endregion

    #region SalaryWorkPlaceVw class definition
    public partial class SalaryWorkPlaceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public SalaryWorkPlaceVwFilter Filter {get; set; } = new SalaryWorkPlaceVwFilter();
        #endregion
	}
	#endregion

    #region ServiceEndGrantRequestVw class definition
    public partial class ServiceEndGrantRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public ServiceEndGrantRequestVwFilter Filter {get; set; } = new ServiceEndGrantRequestVwFilter();
        #endregion
	}
	#endregion

    #region SettlementVw class definition
    public partial class SettlementVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public SettlementVwFilter Filter {get; set; } = new SettlementVwFilter();
        #endregion
	}
	#endregion

    #region SpecialCaseLoanVw class definition
    public partial class SpecialCaseLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public SpecialCaseLoanVwFilter Filter {get; set; } = new SpecialCaseLoanVwFilter();
        #endregion
	}
	#endregion

    #region SubscriptionVw class definition
    public partial class SubscriptionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public SubscriptionVwFilter Filter {get; set; } = new SubscriptionVwFilter();
        #endregion
	}
	#endregion

    #region TransitoryIncomingLoanVw class definition
    public partial class TransitoryIncomingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public TransitoryIncomingLoanVwFilter Filter {get; set; } = new TransitoryIncomingLoanVwFilter();
        #endregion
	}
	#endregion

    #region WarrantVw class definition
    public partial class WarrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A Filter object by which the List should be filtered
		/// </summary>
		public WarrantVwFilter Filter {get; set; } = new WarrantVwFilter();
        #endregion
	}
	#endregion
}
