using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.ViewModels
{
    #region AvailabilityVw class definition
    public partial class AvailabilityVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related AvailabilityCeilingVw View model objects
		/// </summary>
		public AvailabilityCeilingVwViewModel AvailabilityCeilingVwViewModel {get; set;} = new AvailabilityCeilingVwViewModel();

		/// <summary>
        /// Related ProductTypeAvailabilityVw View model objects
		/// </summary>
		public ProductTypeAvailabilityVwViewModel ProductTypeAvailabilityVwViewModel {get; set;} = new ProductTypeAvailabilityVwViewModel();
		#endregion
	}
	#endregion

    #region BypassStatusVw class definition
    public partial class BypassStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related RequestVw View model objects
		/// </summary>
		public RequestVwViewModel RequestVwViewModel {get; set;} = new RequestVwViewModel();
		#endregion
	}
	#endregion

    #region CategoryVw class definition
    public partial class CategoryVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EmployeeVw View model objects
		/// </summary>
		public EmployeeVwViewModel EmployeeVwViewModel {get; set;} = new EmployeeVwViewModel();
		#endregion
	}
	#endregion

    #region CollectOrderVw class definition
    public partial class CollectOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related PaymentVw View model objects
		/// </summary>
		public PaymentVwViewModel PaymentVwViewModel {get; set;} = new PaymentVwViewModel();
		#endregion
	}
	#endregion

    #region DebtVw class definition
    public partial class DebtVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related WarrantVw View model objects
		/// </summary>
		public WarrantVwViewModel WarrantVwViewModel {get; set;} = new WarrantVwViewModel();
		#endregion
	}
	#endregion

    #region DepartmentVw class definition
    public partial class DepartmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EmployeeVw View model objects
		/// </summary>
		public EmployeeVwViewModel EmployeeVwViewModel {get; set;} = new EmployeeVwViewModel();

		/// <summary>
        /// Related InstallmentDecreaseVw View model objects
		/// </summary>
		public InstallmentDecreaseVwViewModel InstallmentDecreaseVwViewModel {get; set;} = new InstallmentDecreaseVwViewModel();

		/// <summary>
        /// Related SalaryPaymentVw View model objects
		/// </summary>
		public SalaryPaymentVwViewModel SalaryPaymentVwViewModel {get; set;} = new SalaryPaymentVwViewModel();

		/// <summary>
        /// Related SubscriptionVw View model objects
		/// </summary>
		public SubscriptionVwViewModel SubscriptionVwViewModel {get; set;} = new SubscriptionVwViewModel();
		#endregion
	}
	#endregion

    #region EmployeeStatusVw class definition
    public partial class EmployeeStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EmployeeVw View model objects
		/// </summary>
		public EmployeeVwViewModel EmployeeVwViewModel {get; set;} = new EmployeeVwViewModel();
		#endregion
	}
	#endregion

    #region EmployeeVw class definition
    public partial class EmployeeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related MissingInstallmentDecreaseVw View model objects
		/// </summary>
		public MissingInstallmentDecreaseVwViewModel MissingInstallmentDecreaseVwViewModel {get; set;} = new MissingInstallmentDecreaseVwViewModel();

		/// <summary>
        /// Related DebtVw View model objects
		/// </summary>
		public DebtVwViewModel DebtVwViewModel {get; set;} = new DebtVwViewModel();

		/// <summary>
        /// Related EmployeeSeniorityVw View model objects
		/// </summary>
		public EmployeeSeniorityVwViewModel EmployeeSeniorityVwViewModel {get; set;} = new EmployeeSeniorityVwViewModel();

		/// <summary>
        /// Related ExternalGrantVw View model objects
		/// </summary>
		public ExternalGrantVwViewModel ExternalGrantVwViewModel {get; set;} = new ExternalGrantVwViewModel();

		/// <summary>
        /// Related GuarantorVw View model objects
		/// </summary>
		public GuarantorVwViewModel GuarantorVwViewModel {get; set;} = new GuarantorVwViewModel();

		/// <summary>
        /// Related HealthLoanDecisionFirstPaymentVw View model objects
		/// </summary>
		public HealthLoanDecisionFirstPaymentVwViewModel HealthLoanDecisionFirstPaymentVwViewModel {get; set;} = new HealthLoanDecisionFirstPaymentVwViewModel();

		/// <summary>
        /// Related InstallmentDecreaseVw View model objects
		/// </summary>
		public InstallmentDecreaseVwViewModel InstallmentDecreaseVwViewModel {get; set;} = new InstallmentDecreaseVwViewModel();

		/// <summary>
        /// Related MonthlyBalanceVw View model objects
		/// </summary>
		public MonthlyBalanceVwViewModel MonthlyBalanceVwViewModel {get; set;} = new MonthlyBalanceVwViewModel();

		/// <summary>
        /// Related PaymentVw View model objects
		/// </summary>
		public PaymentVwViewModel PaymentVwViewModel {get; set;} = new PaymentVwViewModel();

		/// <summary>
        /// Related PayOrderVw View model objects
		/// </summary>
		public PayOrderVwViewModel PayOrderVwViewModel {get; set;} = new PayOrderVwViewModel();

		/// <summary>
        /// Related ProductVw View model objects
		/// </summary>
		public ProductVwViewModel ProductVwViewModel {get; set;} = new ProductVwViewModel();

		/// <summary>
        /// Related ProfileVw View model objects
		/// </summary>
		public ProfileVwViewModel ProfileVwViewModel {get; set;} = new ProfileVwViewModel();

		/// <summary>
        /// Related SpecialCaseLoanVw View model objects
		/// </summary>
		public SpecialCaseLoanVwViewModel SpecialCaseLoanVwViewModel {get; set;} = new SpecialCaseLoanVwViewModel();

		/// <summary>
        /// Related SubscriptionVw View model objects
		/// </summary>
		public SubscriptionVwViewModel SubscriptionVwViewModel {get; set;} = new SubscriptionVwViewModel();

		/// <summary>
        /// Related TransitoryIncomingLoanVw View model objects
		/// </summary>
		public TransitoryIncomingLoanVwViewModel TransitoryIncomingLoanVwViewModel {get; set;} = new TransitoryIncomingLoanVwViewModel();

		/// <summary>
        /// Related WarrantVw View model objects
		/// </summary>
		public WarrantVwViewModel WarrantVwViewModel {get; set;} = new WarrantVwViewModel();
		#endregion
	}
	#endregion

    #region EventCategoryVw class definition
    public partial class EventCategoryVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EventLogVw View model objects
		/// </summary>
		public EventLogVwViewModel EventLogVwViewModel {get; set;} = new EventLogVwViewModel();
		#endregion
	}
	#endregion

    #region EventLogVw class definition
    public partial class EventLogVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EventLogErrorVw View model objects
		/// </summary>
		public EventLogErrorVwViewModel EventLogErrorVwViewModel {get; set;} = new EventLogErrorVwViewModel();
		#endregion
	}
	#endregion

    #region EventSourceVw class definition
    public partial class EventSourceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EventLogVw View model objects
		/// </summary>
		public EventLogVwViewModel EventLogVwViewModel {get; set;} = new EventLogVwViewModel();
		#endregion
	}
	#endregion

    #region EventStatusVw class definition
    public partial class EventStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related EventLogVw View model objects
		/// </summary>
		public EventLogVwViewModel EventLogVwViewModel {get; set;} = new EventLogVwViewModel();
		#endregion
	}
	#endregion

    #region ExceptionalAmountTypeVw class definition
    public partial class ExceptionalAmountTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related ExceptionalAmountVw View model objects
		/// </summary>
		public ExceptionalAmountVwViewModel ExceptionalAmountVwViewModel {get; set;} = new ExceptionalAmountVwViewModel();
		#endregion
	}
	#endregion

    #region GrantDecisionVw class definition
    public partial class GrantDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantVw View model objects
		/// </summary>
		public GrantVwViewModel GrantVwViewModel {get; set;} = new GrantVwViewModel();
		#endregion
	}
	#endregion

    #region GrantPaymentOrderVw class definition
    public partial class GrantPaymentOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantPaymentVw View model objects
		/// </summary>
		public GrantPaymentVwViewModel GrantPaymentVwViewModel {get; set;} = new GrantPaymentVwViewModel();
		#endregion
	}
	#endregion

    #region GrantRequestVw class definition
    public partial class GrantRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related ServiceEndGrantRequestVw View model objects
		/// </summary>
		public ServiceEndGrantRequestVwViewModel ServiceEndGrantRequestVwViewModel {get; set;} = new ServiceEndGrantRequestVwViewModel();
		#endregion
	}
	#endregion

    #region GrantTypeGroupVw class definition
    public partial class GrantTypeGroupVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantDecisionVw View model objects
		/// </summary>
		public GrantDecisionVwViewModel GrantDecisionVwViewModel {get; set;} = new GrantDecisionVwViewModel();

		/// <summary>
        /// Related GrantTypeVw View model objects
		/// </summary>
		public GrantTypeVwViewModel GrantTypeVwViewModel {get; set;} = new GrantTypeVwViewModel();
		#endregion
	}
	#endregion

    #region GrantTypeVw class definition
    public partial class GrantTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantRequestVw View model objects
		/// </summary>
		public GrantRequestVwViewModel GrantRequestVwViewModel {get; set;} = new GrantRequestVwViewModel();

		/// <summary>
        /// Related ExternalGrantVw View model objects
		/// </summary>
		public ExternalGrantVwViewModel ExternalGrantVwViewModel {get; set;} = new ExternalGrantVwViewModel();
		#endregion
	}
	#endregion

    #region GrantVw class definition
    public partial class GrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantDeductionVw View model objects
		/// </summary>
		public GrantDeductionVwViewModel GrantDeductionVwViewModel {get; set;} = new GrantDeductionVwViewModel();

		/// <summary>
        /// Related GrantPaymentVw View model objects
		/// </summary>
		public GrantPaymentVwViewModel GrantPaymentVwViewModel {get; set;} = new GrantPaymentVwViewModel();
		#endregion
	}
	#endregion

    #region GuarantorStatusVw class definition
    public partial class GuarantorStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GuarantorVw View model objects
		/// </summary>
		public GuarantorVwViewModel GuarantorVwViewModel {get; set;} = new GuarantorVwViewModel();
		#endregion
	}
	#endregion

    #region GuarantorVw class definition
    public partial class GuarantorVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GuarantorStatementVw View model objects
		/// </summary>
		public GuarantorStatementVwViewModel GuarantorStatementVwViewModel {get; set;} = new GuarantorStatementVwViewModel();
		#endregion
	}
	#endregion

    #region HealthLoanDecisionVw class definition
    public partial class HealthLoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related HealthLoanDecisionFirstPaymentVw View model objects
		/// </summary>
		public HealthLoanDecisionFirstPaymentVwViewModel HealthLoanDecisionFirstPaymentVwViewModel {get; set;} = new HealthLoanDecisionFirstPaymentVwViewModel();
		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVw class definition
    public partial class InstallmentDecreaseOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related InstallmentDecreaseVw View model objects
		/// </summary>
		public InstallmentDecreaseVwViewModel InstallmentDecreaseVwViewModel {get; set;} = new InstallmentDecreaseVwViewModel();
		#endregion
	}
	#endregion

    #region InstallmentVw class definition
    public partial class InstallmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related SettlementVw View model objects
		/// </summary>
		public SettlementVwViewModel SettlementVwViewModel {get; set;} = new SettlementVwViewModel();
		#endregion
	}
	#endregion

    #region InsuranceTypeVw class definition
    public partial class InsuranceTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related HealthLoanDecisionFirstPaymentVw View model objects
		/// </summary>
		public HealthLoanDecisionFirstPaymentVwViewModel HealthLoanDecisionFirstPaymentVwViewModel {get; set;} = new HealthLoanDecisionFirstPaymentVwViewModel();
		#endregion
	}
	#endregion

    #region IssuerVw class definition
    public partial class IssuerVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related DebtVw View model objects
		/// </summary>
		public DebtVwViewModel DebtVwViewModel {get; set;} = new DebtVwViewModel();
		#endregion
	}
	#endregion

    #region LoanDecisionTypeVw class definition
    public partial class LoanDecisionTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanDecisionVw View model objects
		/// </summary>
		public LoanDecisionVwViewModel LoanDecisionVwViewModel {get; set;} = new LoanDecisionVwViewModel();
		#endregion
	}
	#endregion

    #region LoanDecisionVw class definition
    public partial class LoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanVw View model objects
		/// </summary>
		public LoanVwViewModel LoanVwViewModel {get; set;} = new LoanVwViewModel();

		/// <summary>
        /// Related OutgoingLoanVw View model objects
		/// </summary>
		public OutgoingLoanVwViewModel OutgoingLoanVwViewModel {get; set;} = new OutgoingLoanVwViewModel();
		#endregion
	}
	#endregion

    #region LoanGenerationStatusVw class definition
    public partial class LoanGenerationStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanVw View model objects
		/// </summary>
		public LoanVwViewModel LoanVwViewModel {get; set;} = new LoanVwViewModel();
		#endregion
	}
	#endregion

    #region LoanRequestVw class definition
    public partial class LoanRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related ExceptionalAmountVw View model objects
		/// </summary>
		public ExceptionalAmountVwViewModel ExceptionalAmountVwViewModel {get; set;} = new ExceptionalAmountVwViewModel();
		#endregion
	}
	#endregion

    #region LoanStatusVw class definition
    public partial class LoanStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanVw View model objects
		/// </summary>
		public LoanVwViewModel LoanVwViewModel {get; set;} = new LoanVwViewModel();
		#endregion
	}
	#endregion

    #region LoanTypeVw class definition
    public partial class LoanTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanVw View model objects
		/// </summary>
		public LoanVwViewModel LoanVwViewModel {get; set;} = new LoanVwViewModel();

		/// <summary>
        /// Related LoanTypeClosureVw View model objects
		/// </summary>
		public LoanTypeClosureVwViewModel ClosingLoanTypeClosureVwViewModel {get; set;} = new LoanTypeClosureVwViewModel();

		/// <summary>
        /// Related LoanTypeClosureVw View model objects
		/// </summary>
		public LoanTypeClosureVwViewModel LoanTypeClosureVwViewModel {get; set;} = new LoanTypeClosureVwViewModel();

		/// <summary>
        /// Related SpecialCaseLoanVw View model objects
		/// </summary>
		public SpecialCaseLoanVwViewModel SpecialCaseLoanVwViewModel {get; set;} = new SpecialCaseLoanVwViewModel();
		#endregion
	}
	#endregion

    #region LoanVw class definition
    public partial class LoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related IncomingLoanVw View model objects
		/// </summary>
		public IncomingLoanVwViewModel IncomingLoanVwViewModel {get; set;} = new IncomingLoanVwViewModel();

		/// <summary>
        /// Related LoanChangeVw View model objects
		/// </summary>
		public LoanChangeVwViewModel LoanChangeVwViewModel {get; set;} = new LoanChangeVwViewModel();

		/// <summary>
        /// Related LoanChangeVw View model objects
		/// </summary>
		public LoanChangeVwViewModel FromLoanChangeVwViewModel {get; set;} = new LoanChangeVwViewModel();

		/// <summary>
        /// Related OutgoingLoanVw View model objects
		/// </summary>
		public OutgoingLoanVwViewModel OutgoingLoanVwViewModel {get; set;} = new OutgoingLoanVwViewModel();
		#endregion
	}
	#endregion

    #region MainWorkPlaceVw class definition
    public partial class MainWorkPlaceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related IncomingLoanVw View model objects
		/// </summary>
		public IncomingLoanVwViewModel IncomingLoanVwViewModel {get; set;} = new IncomingLoanVwViewModel();

		/// <summary>
        /// Related OutgoingLoanVw View model objects
		/// </summary>
		public OutgoingLoanVwViewModel OutgoingLoanVwViewModel {get; set;} = new OutgoingLoanVwViewModel();

		/// <summary>
        /// Related SalaryWorkPlaceVw View model objects
		/// </summary>
		public SalaryWorkPlaceVwViewModel SalaryWorkPlaceVwViewModel {get; set;} = new SalaryWorkPlaceVwViewModel();

		/// <summary>
        /// Related TransitoryIncomingLoanVw View model objects
		/// </summary>
		public TransitoryIncomingLoanVwViewModel TransitoryIncomingLoanVwViewModel {get; set;} = new TransitoryIncomingLoanVwViewModel();
		#endregion
	}
	#endregion

    #region PaymentGroupVw class definition
    public partial class PaymentGroupVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related MonthlyBalanceVw View model objects
		/// </summary>
		public MonthlyBalanceVwViewModel MonthlyBalanceVwViewModel {get; set;} = new MonthlyBalanceVwViewModel();

		/// <summary>
        /// Related PaymentVw View model objects
		/// </summary>
		public PaymentVwViewModel PaymentVwViewModel {get; set;} = new PaymentVwViewModel();

		/// <summary>
        /// Related PayOrderVw View model objects
		/// </summary>
		public PayOrderVwViewModel PayOrderVwViewModel {get; set;} = new PayOrderVwViewModel();

		/// <summary>
        /// Related ProductTypeVw View model objects
		/// </summary>
		public ProductTypeVwViewModel ProductTypeVwViewModel {get; set;} = new ProductTypeVwViewModel();
		#endregion
	}
	#endregion

    #region PaymentStatusVw class definition
    public partial class PaymentStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related PaymentVw View model objects
		/// </summary>
		public PaymentVwViewModel PaymentVwViewModel {get; set;} = new PaymentVwViewModel();
		#endregion
	}
	#endregion

    #region PaymentVw class definition
    public partial class PaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related CashPaymentVw View model objects
		/// </summary>
		public CashPaymentVwViewModel CashPaymentVwViewModel {get; set;} = new CashPaymentVwViewModel();

		/// <summary>
        /// Related DownPaymentVw View model objects
		/// </summary>
		public DownPaymentVwViewModel DownPaymentVwViewModel {get; set;} = new DownPaymentVwViewModel();

		/// <summary>
        /// Related SalaryPaymentVw View model objects
		/// </summary>
		public SalaryPaymentVwViewModel SalaryPaymentVwViewModel {get; set;} = new SalaryPaymentVwViewModel();

		/// <summary>
        /// Related SettlementVw View model objects
		/// </summary>
		public SettlementVwViewModel SettlementVwViewModel {get; set;} = new SettlementVwViewModel();
		#endregion
	}
	#endregion

    #region ProductTypeVw class definition
    public partial class ProductTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related LoanTypeVw View model objects
		/// </summary>
		public LoanTypeVwViewModel LoanTypeVwViewModel {get; set;} = new LoanTypeVwViewModel();

		/// <summary>
        /// Related ProductVw View model objects
		/// </summary>
		public ProductVwViewModel ProductVwViewModel {get; set;} = new ProductVwViewModel();

		/// <summary>
        /// Related ProductTypeAvailabilityVw View model objects
		/// </summary>
		public ProductTypeAvailabilityVwViewModel ProductTypeAvailabilityVwViewModel {get; set;} = new ProductTypeAvailabilityVwViewModel();
		#endregion
	}
	#endregion

    #region ProductVw class definition
    public partial class ProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GrantVw View model objects
		/// </summary>
		public GrantVwViewModel GrantVwViewModel {get; set;} = new GrantVwViewModel();

		/// <summary>
        /// Related LoanVw View model objects
		/// </summary>
		public LoanVwViewModel LoanVwViewModel {get; set;} = new LoanVwViewModel();

		/// <summary>
        /// Related RefundableProductVw View model objects
		/// </summary>
		public RefundableProductVwViewModel RefundableProductVwViewModel {get; set;} = new RefundableProductVwViewModel();

		/// <summary>
        /// Related RequestVw View model objects
		/// </summary>
		public RequestVwViewModel RequestVwViewModel {get; set;} = new RequestVwViewModel();
		#endregion
	}
	#endregion

    #region ProfitStrategyVw class definition
    public partial class ProfitStrategyVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related ProductTypeVw View model objects
		/// </summary>
		public ProductTypeVwViewModel ProductTypeVwViewModel {get; set;} = new ProductTypeVwViewModel();
		#endregion
	}
	#endregion

    #region RefundableProductVw class definition
    public partial class RefundableProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related GuarantorVw View model objects
		/// </summary>
		public GuarantorVwViewModel GuarantorVwViewModel {get; set;} = new GuarantorVwViewModel();

		/// <summary>
        /// Related InstallmentVw View model objects
		/// </summary>
		public InstallmentVwViewModel InstallmentVwViewModel {get; set;} = new InstallmentVwViewModel();
		#endregion
	}
	#endregion

    #region RequestStatusVw class definition
    public partial class RequestStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related RequestVw View model objects
		/// </summary>
		public RequestVwViewModel RequestVwViewModel {get; set;} = new RequestVwViewModel();
		#endregion
	}
	#endregion

    #region RequestVw class definition
    public partial class RequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related DownPaymentVw View model objects
		/// </summary>
		public DownPaymentVwViewModel DownPaymentVwViewModel {get; set;} = new DownPaymentVwViewModel();

		/// <summary>
        /// Related GrantRequestVw View model objects
		/// </summary>
		public GrantRequestVwViewModel GrantRequestVwViewModel {get; set;} = new GrantRequestVwViewModel();

		/// <summary>
        /// Related LoanRequestVw View model objects
		/// </summary>
		public LoanRequestVwViewModel LoanRequestVwViewModel {get; set;} = new LoanRequestVwViewModel();
		#endregion
	}
	#endregion

    #region SalaryWorkPlaceVw class definition
    public partial class SalaryWorkPlaceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related DepartmentVw View model objects
		/// </summary>
		public DepartmentVwViewModel DepartmentVwViewModel {get; set;} = new DepartmentVwViewModel();
		#endregion
	}
	#endregion

    #region SubscriptionTypeVw class definition
    public partial class SubscriptionTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// Related SubscriptionVw View model objects
		/// </summary>
		public SubscriptionVwViewModel SubscriptionVwViewModel {get; set;} = new SubscriptionVwViewModel();
		#endregion
	}
	#endregion
}
