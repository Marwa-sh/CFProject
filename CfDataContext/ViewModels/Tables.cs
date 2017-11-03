using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cf.Data;

namespace Cf.ViewModels
{
    #region Availability class definition
    public partial class AvailabilityViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of 
		/// </summary>
		public Availability Availability = new Availability();

		/// <summary>
        /// Related AvailabilityCeiling View model objects
		/// </summary>
		public List<AvailabilityCeilingViewModel> AvailabilityCeilingViewModelList {get; set;} = new List<AvailabilityCeilingViewModel>();

		/// <summary>
        /// Related ProductTypeAvailability View model objects
		/// </summary>
		public List<ProductTypeAvailabilityViewModel> ProductTypeAvailabilityViewModelList {get; set;} = new List<ProductTypeAvailabilityViewModel>();
		#endregion
	}
	#endregion

    #region AvailabilityCeiling class definition
    public partial class AvailabilityCeilingViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductTypeAvailability
		/// </summary>
		public AvailabilityCeiling AvailabilityCeiling = new AvailabilityCeiling();

		/// <summary>
        /// Related Availability View model objects
		/// </summary>
		public AvailabilityViewModel AvailabilityViewModel {get; set;} = new AvailabilityViewModel();
		#endregion
	}
	#endregion

    #region BypassStatus class definition
    public partial class BypassStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Availability
		/// </summary>
		public BypassStatus BypassStatus = new BypassStatus();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public List<RequestViewModel> RequestViewModelList {get; set;} = new List<RequestViewModel>();
		#endregion
	}
	#endregion

    #region CashPayment class definition
    public partial class CashPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public CashPayment CashPayment = new CashPayment();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public PaymentViewModel PaymentViewModel {get; set;} = new PaymentViewModel();
		#endregion
	}
	#endregion

    #region Category class definition
    public partial class CategoryViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Payment
		/// </summary>
		public Category Category = new Category();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public List<EmployeeViewModel> EmployeeViewModelList {get; set;} = new List<EmployeeViewModel>();
		#endregion
	}
	#endregion

    #region CollectOrder class definition
    public partial class CollectOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public CollectOrder CollectOrder = new CollectOrder();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public List<PaymentViewModel> PaymentViewModelList {get; set;} = new List<PaymentViewModel>();
		#endregion
	}
	#endregion

    #region Debt class definition
    public partial class DebtViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Payment
		/// </summary>
		public Debt Debt = new Debt();

		/// <summary>
        /// Related Issuer View model objects
		/// </summary>
		public IssuerViewModel IssuerViewModel {get; set;} = new IssuerViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related Warrant View model objects
		/// </summary>
		public List<WarrantViewModel> WarrantViewModelList {get; set;} = new List<WarrantViewModel>();
		#endregion
	}
	#endregion

    #region Department class definition
    public partial class DepartmentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Warrant
		/// </summary>
		public Department Department = new Department();

		/// <summary>
        /// Related SalaryWorkPlace View model objects
		/// </summary>
		public SalaryWorkPlaceViewModel SalaryWorkPlaceViewModel {get; set;} = new SalaryWorkPlaceViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public List<EmployeeViewModel> EmployeeViewModelList {get; set;} = new List<EmployeeViewModel>();

		/// <summary>
        /// Related InstallmentDecrease View model objects
		/// </summary>
		public List<InstallmentDecreaseViewModel> InstallmentDecreaseViewModelList {get; set;} = new List<InstallmentDecreaseViewModel>();

		/// <summary>
        /// Related SalaryPayment View model objects
		/// </summary>
		public List<SalaryPaymentViewModel> SalaryPaymentViewModelList {get; set;} = new List<SalaryPaymentViewModel>();

		/// <summary>
        /// Related Subscription View model objects
		/// </summary>
		public List<SubscriptionViewModel> SubscriptionViewModelList {get; set;} = new List<SubscriptionViewModel>();
		#endregion
	}
	#endregion

    #region DownPayment class definition
    public partial class DownPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Subscription
		/// </summary>
		public DownPayment DownPayment = new DownPayment();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public PaymentViewModel PaymentViewModel {get; set;} = new PaymentViewModel();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public RequestViewModel RequestViewModel {get; set;} = new RequestViewModel();
		#endregion
	}
	#endregion

    #region Employee class definition
    public partial class EmployeeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public Employee Employee = new Employee();

		/// <summary>
        /// Related Category View model objects
		/// </summary>
		public CategoryViewModel CategoryViewModel {get; set;} = new CategoryViewModel();

		/// <summary>
        /// Related Department View model objects
		/// </summary>
		public DepartmentViewModel DepartmentViewModel {get; set;} = new DepartmentViewModel();

		/// <summary>
        /// Related EmployeeStatus View model objects
		/// </summary>
		public EmployeeStatusViewModel EmployeeStatusViewModel {get; set;} = new EmployeeStatusViewModel();

		/// <summary>
        /// Related MissingInstallmentDecrease View model objects
		/// </summary>
		public MissingInstallmentDecreaseViewModel MissingInstallmentDecreaseViewModel {get; set;} = new MissingInstallmentDecreaseViewModel();

		/// <summary>
        /// Related Debt View model objects
		/// </summary>
		public List<DebtViewModel> DebtViewModelList {get; set;} = new List<DebtViewModel>();

		/// <summary>
        /// Related EmployeeSeniority View model objects
		/// </summary>
		public EmployeeSeniorityViewModel EmployeeSeniorityViewModel {get; set;} = new EmployeeSeniorityViewModel();

		/// <summary>
        /// Related ExternalGrant View model objects
		/// </summary>
		public List<ExternalGrantViewModel> ExternalGrantViewModelList {get; set;} = new List<ExternalGrantViewModel>();

		/// <summary>
        /// Related Guarantor View model objects
		/// </summary>
		public List<GuarantorViewModel> GuarantorViewModelList {get; set;} = new List<GuarantorViewModel>();

		/// <summary>
        /// Related HealthLoanDecisionFirstPayment View model objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentViewModel> HealthLoanDecisionFirstPaymentViewModelList {get; set;} = new List<HealthLoanDecisionFirstPaymentViewModel>();

		/// <summary>
        /// Related InstallmentDecrease View model objects
		/// </summary>
		public List<InstallmentDecreaseViewModel> InstallmentDecreaseViewModelList {get; set;} = new List<InstallmentDecreaseViewModel>();

		/// <summary>
        /// Related MonthlyBalance View model objects
		/// </summary>
		public List<MonthlyBalanceViewModel> MonthlyBalanceViewModelList {get; set;} = new List<MonthlyBalanceViewModel>();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public List<PaymentViewModel> PaymentViewModelList {get; set;} = new List<PaymentViewModel>();

		/// <summary>
        /// Related PayOrder View model objects
		/// </summary>
		public List<PayOrderViewModel> PayOrderViewModelList {get; set;} = new List<PayOrderViewModel>();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public List<ProductViewModel> ProductViewModelList {get; set;} = new List<ProductViewModel>();

		/// <summary>
        /// Related Profile View model objects
		/// </summary>
		public ProfileViewModel ProfileViewModel {get; set;} = new ProfileViewModel();

		/// <summary>
        /// Related SpecialCaseLoan View model objects
		/// </summary>
		public List<SpecialCaseLoanViewModel> SpecialCaseLoanViewModelList {get; set;} = new List<SpecialCaseLoanViewModel>();

		/// <summary>
        /// Related Subscription View model objects
		/// </summary>
		public List<SubscriptionViewModel> SubscriptionViewModelList {get; set;} = new List<SubscriptionViewModel>();

		/// <summary>
        /// Related TransitoryIncomingLoan View model objects
		/// </summary>
		public TransitoryIncomingLoanViewModel TransitoryIncomingLoanViewModel {get; set;} = new TransitoryIncomingLoanViewModel();

		/// <summary>
        /// Related Warrant View model objects
		/// </summary>
		public List<WarrantViewModel> WarrantViewModelList {get; set;} = new List<WarrantViewModel>();
		#endregion
	}
	#endregion

    #region EmployeeSeniority class definition
    public partial class EmployeeSeniorityViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Warrant
		/// </summary>
		public EmployeeSeniority EmployeeSeniority = new EmployeeSeniority();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();
		#endregion
	}
	#endregion

    #region EmployeeStatus class definition
    public partial class EmployeeStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public EmployeeStatus EmployeeStatus = new EmployeeStatus();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public List<EmployeeViewModel> EmployeeViewModelList {get; set;} = new List<EmployeeViewModel>();
		#endregion
	}
	#endregion

    #region EndWorkGrantBracket class definition
    public partial class EndWorkGrantBracketViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public EndWorkGrantBracket EndWorkGrantBracket = new EndWorkGrantBracket();
		#endregion
	}
	#endregion

    #region ErrorDefinition class definition
    public partial class ErrorDefinitionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public ErrorDefinition ErrorDefinition = new ErrorDefinition();
		#endregion
	}
	#endregion

    #region EventCategory class definition
    public partial class EventCategoryViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public EventCategory EventCategory = new EventCategory();

		/// <summary>
        /// Related EventLog View model objects
		/// </summary>
		public List<EventLogViewModel> EventLogViewModelList {get; set;} = new List<EventLogViewModel>();
		#endregion
	}
	#endregion

    #region EventLog class definition
    public partial class EventLogViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventLog
		/// </summary>
		public EventLog EventLog = new EventLog();

		/// <summary>
        /// Related EventCategory View model objects
		/// </summary>
		public EventCategoryViewModel EventCategoryViewModel {get; set;} = new EventCategoryViewModel();

		/// <summary>
        /// Related EventSource View model objects
		/// </summary>
		public EventSourceViewModel EventSourceViewModel {get; set;} = new EventSourceViewModel();

		/// <summary>
        /// Related EventStatus View model objects
		/// </summary>
		public EventStatusViewModel EventStatusViewModel {get; set;} = new EventStatusViewModel();

		/// <summary>
        /// Related EventLogError View model objects
		/// </summary>
		public EventLogErrorViewModel EventLogErrorViewModel {get; set;} = new EventLogErrorViewModel();
		#endregion
	}
	#endregion

    #region EventLogError class definition
    public partial class EventLogErrorViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventLogError
		/// </summary>
		public EventLogError EventLogError = new EventLogError();

		/// <summary>
        /// Related EventLog View model objects
		/// </summary>
		public EventLogViewModel EventLogViewModel {get; set;} = new EventLogViewModel();
		#endregion
	}
	#endregion

    #region EventSource class definition
    public partial class EventSourceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventLog
		/// </summary>
		public EventSource EventSource = new EventSource();

		/// <summary>
        /// Related EventLog View model objects
		/// </summary>
		public List<EventLogViewModel> EventLogViewModelList {get; set;} = new List<EventLogViewModel>();
		#endregion
	}
	#endregion

    #region EventStatus class definition
    public partial class EventStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventLog
		/// </summary>
		public EventStatus EventStatus = new EventStatus();

		/// <summary>
        /// Related EventLog View model objects
		/// </summary>
		public List<EventLogViewModel> EventLogViewModelList {get; set;} = new List<EventLogViewModel>();
		#endregion
	}
	#endregion

    #region ExceptionalAmount class definition
    public partial class ExceptionalAmountViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventLog
		/// </summary>
		public ExceptionalAmount ExceptionalAmount = new ExceptionalAmount();

		/// <summary>
        /// Related ExceptionalAmountType View model objects
		/// </summary>
		public ExceptionalAmountTypeViewModel ExceptionalAmountTypeViewModel {get; set;} = new ExceptionalAmountTypeViewModel();

		/// <summary>
        /// Related LoanRequest View model objects
		/// </summary>
		public LoanRequestViewModel LoanRequestViewModel {get; set;} = new LoanRequestViewModel();
		#endregion
	}
	#endregion

    #region ExceptionalAmountType class definition
    public partial class ExceptionalAmountTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanRequest
		/// </summary>
		public ExceptionalAmountType ExceptionalAmountType = new ExceptionalAmountType();

		/// <summary>
        /// Related ExceptionalAmount View model objects
		/// </summary>
		public List<ExceptionalAmountViewModel> ExceptionalAmountViewModelList {get; set;} = new List<ExceptionalAmountViewModel>();
		#endregion
	}
	#endregion

    #region ExternalGrant class definition
    public partial class ExternalGrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExceptionalAmount
		/// </summary>
		public ExternalGrant ExternalGrant = new ExternalGrant();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related GrantType View model objects
		/// </summary>
		public GrantTypeViewModel GrantTypeViewModel {get; set;} = new GrantTypeViewModel();
		#endregion
	}
	#endregion

    #region Grant class definition
    public partial class GrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantType
		/// </summary>
		public Grant Grant = new Grant();

		/// <summary>
        /// Related GrantDecision View model objects
		/// </summary>
		public GrantDecisionViewModel GrantDecisionViewModel {get; set;} = new GrantDecisionViewModel();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public ProductViewModel ProductViewModel {get; set;} = new ProductViewModel();

		/// <summary>
        /// Related GrantDeduction View model objects
		/// </summary>
		public GrantDeductionViewModel GrantDeductionViewModel {get; set;} = new GrantDeductionViewModel();

		/// <summary>
        /// Related GrantPayment View model objects
		/// </summary>
		public List<GrantPaymentViewModel> GrantPaymentViewModelList {get; set;} = new List<GrantPaymentViewModel>();
		#endregion
	}
	#endregion

    #region GrantDecision class definition
    public partial class GrantDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantPayment
		/// </summary>
		public GrantDecision GrantDecision = new GrantDecision();

		/// <summary>
        /// Related GrantTypeGroup View model objects
		/// </summary>
		public GrantTypeGroupViewModel GrantTypeGroupViewModel {get; set;} = new GrantTypeGroupViewModel();

		/// <summary>
        /// Related Grant View model objects
		/// </summary>
		public List<GrantViewModel> GrantViewModelList {get; set;} = new List<GrantViewModel>();
		#endregion
	}
	#endregion

    #region GrantDeduction class definition
    public partial class GrantDeductionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Grant
		/// </summary>
		public GrantDeduction GrantDeduction = new GrantDeduction();

		/// <summary>
        /// Related Grant View model objects
		/// </summary>
		public GrantViewModel GrantViewModel {get; set;} = new GrantViewModel();
		#endregion
	}
	#endregion

    #region GrantPayment class definition
    public partial class GrantPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Grant
		/// </summary>
		public GrantPayment GrantPayment = new GrantPayment();

		/// <summary>
        /// Related Grant View model objects
		/// </summary>
		public GrantViewModel GrantViewModel {get; set;} = new GrantViewModel();

		/// <summary>
        /// Related GrantPaymentOrder View model objects
		/// </summary>
		public GrantPaymentOrderViewModel GrantPaymentOrderViewModel {get; set;} = new GrantPaymentOrderViewModel();
		#endregion
	}
	#endregion

    #region GrantPaymentOrder class definition
    public partial class GrantPaymentOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantPaymentOrder
		/// </summary>
		public GrantPaymentOrder GrantPaymentOrder = new GrantPaymentOrder();

		/// <summary>
        /// Related GrantPayment View model objects
		/// </summary>
		public List<GrantPaymentViewModel> GrantPaymentViewModelList {get; set;} = new List<GrantPaymentViewModel>();
		#endregion
	}
	#endregion

    #region GrantRequest class definition
    public partial class GrantRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantPayment
		/// </summary>
		public GrantRequest GrantRequest = new GrantRequest();

		/// <summary>
        /// Related GrantType View model objects
		/// </summary>
		public GrantTypeViewModel GrantTypeViewModel {get; set;} = new GrantTypeViewModel();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public RequestViewModel RequestViewModel {get; set;} = new RequestViewModel();

		/// <summary>
        /// Related ServiceEndGrantRequest View model objects
		/// </summary>
		public ServiceEndGrantRequestViewModel ServiceEndGrantRequestViewModel {get; set;} = new ServiceEndGrantRequestViewModel();
		#endregion
	}
	#endregion

    #region GrantType class definition
    public partial class GrantTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ServiceEndGrantRequest
		/// </summary>
		public GrantType GrantType = new GrantType();

		/// <summary>
        /// Related GrantTypeGroup View model objects
		/// </summary>
		public GrantTypeGroupViewModel GrantTypeGroupViewModel {get; set;} = new GrantTypeGroupViewModel();

		/// <summary>
        /// Related GrantRequest View model objects
		/// </summary>
		public List<GrantRequestViewModel> GrantRequestViewModelList {get; set;} = new List<GrantRequestViewModel>();

		/// <summary>
        /// Related ExternalGrant View model objects
		/// </summary>
		public List<ExternalGrantViewModel> ExternalGrantViewModelList {get; set;} = new List<ExternalGrantViewModel>();
		#endregion
	}
	#endregion

    #region GrantTypeGroup class definition
    public partial class GrantTypeGroupViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExternalGrant
		/// </summary>
		public GrantTypeGroup GrantTypeGroup = new GrantTypeGroup();

		/// <summary>
        /// Related GrantDecision View model objects
		/// </summary>
		public List<GrantDecisionViewModel> GrantDecisionViewModelList {get; set;} = new List<GrantDecisionViewModel>();

		/// <summary>
        /// Related GrantType View model objects
		/// </summary>
		public List<GrantTypeViewModel> GrantTypeViewModelList {get; set;} = new List<GrantTypeViewModel>();
		#endregion
	}
	#endregion

    #region Guarantor class definition
    public partial class GuarantorViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantType
		/// </summary>
		public Guarantor Guarantor = new Guarantor();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related GuarantorStatus View model objects
		/// </summary>
		public GuarantorStatusViewModel GuarantorStatusViewModel {get; set;} = new GuarantorStatusViewModel();

		/// <summary>
        /// Related RefundableProduct View model objects
		/// </summary>
		public RefundableProductViewModel RefundableProductViewModel {get; set;} = new RefundableProductViewModel();

		/// <summary>
        /// Related GuarantorStatement View model objects
		/// </summary>
		public GuarantorStatementViewModel GuarantorStatementViewModel {get; set;} = new GuarantorStatementViewModel();
		#endregion
	}
	#endregion

    #region GuarantorStatement class definition
    public partial class GuarantorStatementViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GuarantorStatement
		/// </summary>
		public GuarantorStatement GuarantorStatement = new GuarantorStatement();

		/// <summary>
        /// Related Guarantor View model objects
		/// </summary>
		public GuarantorViewModel GuarantorViewModel {get; set;} = new GuarantorViewModel();
		#endregion
	}
	#endregion

    #region GuarantorStatus class definition
    public partial class GuarantorStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Guarantor
		/// </summary>
		public GuarantorStatus GuarantorStatus = new GuarantorStatus();

		/// <summary>
        /// Related Guarantor View model objects
		/// </summary>
		public List<GuarantorViewModel> GuarantorViewModelList {get; set;} = new List<GuarantorViewModel>();
		#endregion
	}
	#endregion

    #region HealthLoanDecision class definition
    public partial class HealthLoanDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Guarantor
		/// </summary>
		public HealthLoanDecision HealthLoanDecision = new HealthLoanDecision();

		/// <summary>
        /// Related HealthLoanDecisionFirstPayment View model objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentViewModel> HealthLoanDecisionFirstPaymentViewModelList {get; set;} = new List<HealthLoanDecisionFirstPaymentViewModel>();
		#endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPayment class definition
    public partial class HealthLoanDecisionFirstPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of HealthLoanDecisionFirstPayment
		/// </summary>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPayment = new HealthLoanDecisionFirstPayment();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related HealthLoanDecision View model objects
		/// </summary>
		public HealthLoanDecisionViewModel HealthLoanDecisionViewModel {get; set;} = new HealthLoanDecisionViewModel();

		/// <summary>
        /// Related InsuranceType View model objects
		/// </summary>
		public InsuranceTypeViewModel InsuranceTypeViewModel {get; set;} = new InsuranceTypeViewModel();
		#endregion
	}
	#endregion

    #region IncomingLoan class definition
    public partial class IncomingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of InsuranceType
		/// </summary>
		public IncomingLoan IncomingLoan = new IncomingLoan();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public LoanViewModel LoanViewModel {get; set;} = new LoanViewModel();

		/// <summary>
        /// Related MainWorkPlace View model objects
		/// </summary>
		public MainWorkPlaceViewModel MainWorkPlaceViewModel {get; set;} = new MainWorkPlaceViewModel();
		#endregion
	}
	#endregion

    #region Installment class definition
    public partial class InstallmentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MainWorkPlace
		/// </summary>
		public Installment Installment = new Installment();

		/// <summary>
        /// Related RefundableProduct View model objects
		/// </summary>
		public RefundableProductViewModel RefundableProductViewModel {get; set;} = new RefundableProductViewModel();

		/// <summary>
        /// Related Settlement View model objects
		/// </summary>
		public List<SettlementViewModel> SettlementViewModelList {get; set;} = new List<SettlementViewModel>();
		#endregion
	}
	#endregion

    #region InstallmentDecrease class definition
    public partial class InstallmentDecreaseViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Settlement
		/// </summary>
		public InstallmentDecrease InstallmentDecrease = new InstallmentDecrease();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related InstallmentDecreaseOrder View model objects
		/// </summary>
		public InstallmentDecreaseOrderViewModel InstallmentDecreaseOrderViewModel {get; set;} = new InstallmentDecreaseOrderViewModel();

		/// <summary>
        /// Related Department View model objects
		/// </summary>
		public DepartmentViewModel DepartmentViewModel {get; set;} = new DepartmentViewModel();
		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrder class definition
    public partial class InstallmentDecreaseOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Department
		/// </summary>
		public InstallmentDecreaseOrder InstallmentDecreaseOrder = new InstallmentDecreaseOrder();

		/// <summary>
        /// Related InstallmentDecrease View model objects
		/// </summary>
		public List<InstallmentDecreaseViewModel> InstallmentDecreaseViewModelList {get; set;} = new List<InstallmentDecreaseViewModel>();
		#endregion
	}
	#endregion

    #region InsuranceType class definition
    public partial class InsuranceTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of InstallmentDecrease
		/// </summary>
		public InsuranceType InsuranceType = new InsuranceType();

		/// <summary>
        /// Related HealthLoanDecisionFirstPayment View model objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentViewModel> HealthLoanDecisionFirstPaymentViewModelList {get; set;} = new List<HealthLoanDecisionFirstPaymentViewModel>();
		#endregion
	}
	#endregion

    #region Issuer class definition
    public partial class IssuerViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of HealthLoanDecisionFirstPayment
		/// </summary>
		public Issuer Issuer = new Issuer();

		/// <summary>
        /// Related Debt View model objects
		/// </summary>
		public List<DebtViewModel> DebtViewModelList {get; set;} = new List<DebtViewModel>();
		#endregion
	}
	#endregion

    #region Loan class definition
    public partial class LoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Debt
		/// </summary>
		public Loan Loan = new Loan();

		/// <summary>
        /// Related LoanDecision View model objects
		/// </summary>
		public LoanDecisionViewModel LoanDecisionViewModel {get; set;} = new LoanDecisionViewModel();

		/// <summary>
        /// Related LoanGenerationStatus View model objects
		/// </summary>
		public LoanGenerationStatusViewModel LoanGenerationStatusViewModel {get; set;} = new LoanGenerationStatusViewModel();

		/// <summary>
        /// Related LoanStatus View model objects
		/// </summary>
		public LoanStatusViewModel LoanStatusViewModel {get; set;} = new LoanStatusViewModel();

		/// <summary>
        /// Related LoanType View model objects
		/// </summary>
		public LoanTypeViewModel LoanTypeViewModel {get; set;} = new LoanTypeViewModel();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public ProductViewModel ProductViewModel {get; set;} = new ProductViewModel();

		/// <summary>
        /// Related IncomingLoan View model objects
		/// </summary>
		public IncomingLoanViewModel IncomingLoanViewModel {get; set;} = new IncomingLoanViewModel();

		/// <summary>
        /// Related LoanChange View model objects
		/// </summary>
		public LoanChangeViewModel LoanChangeViewModel {get; set;} = new LoanChangeViewModel();

		/// <summary>
        /// Related LoanChange View model objects
		/// </summary>
		public List<LoanChangeViewModel> FromLoanChangeViewModelList {get; set;} = new List<LoanChangeViewModel>();

		/// <summary>
        /// Related OutgoingLoan View model objects
		/// </summary>
		public OutgoingLoanViewModel OutgoingLoanViewModel {get; set;} = new OutgoingLoanViewModel();
		#endregion
	}
	#endregion

    #region LoanChange class definition
    public partial class LoanChangeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of OutgoingLoan
		/// </summary>
		public LoanChange LoanChange = new LoanChange();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public LoanViewModel LoanViewModel {get; set;} = new LoanViewModel();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public LoanViewModel FromLoanViewModel {get; set;} = new LoanViewModel();
		#endregion
	}
	#endregion

    #region LoanDecision class definition
    public partial class LoanDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Loan
		/// </summary>
		public LoanDecision LoanDecision = new LoanDecision();

		/// <summary>
        /// Related LoanDecisionType View model objects
		/// </summary>
		public LoanDecisionTypeViewModel LoanDecisionTypeViewModel {get; set;} = new LoanDecisionTypeViewModel();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public List<LoanViewModel> LoanViewModelList {get; set;} = new List<LoanViewModel>();

		/// <summary>
        /// Related OutgoingLoan View model objects
		/// </summary>
		public List<OutgoingLoanViewModel> OutgoingLoanViewModelList {get; set;} = new List<OutgoingLoanViewModel>();
		#endregion
	}
	#endregion

    #region LoanDecisionType class definition
    public partial class LoanDecisionTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of OutgoingLoan
		/// </summary>
		public LoanDecisionType LoanDecisionType = new LoanDecisionType();

		/// <summary>
        /// Related LoanDecision View model objects
		/// </summary>
		public List<LoanDecisionViewModel> LoanDecisionViewModelList {get; set;} = new List<LoanDecisionViewModel>();
		#endregion
	}
	#endregion

    #region LoanGenerationStatus class definition
    public partial class LoanGenerationStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanDecision
		/// </summary>
		public LoanGenerationStatus LoanGenerationStatus = new LoanGenerationStatus();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public List<LoanViewModel> LoanViewModelList {get; set;} = new List<LoanViewModel>();
		#endregion
	}
	#endregion

    #region LoanRequest class definition
    public partial class LoanRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Loan
		/// </summary>
		public LoanRequest LoanRequest = new LoanRequest();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public RequestViewModel RequestViewModel {get; set;} = new RequestViewModel();

		/// <summary>
        /// Related ExceptionalAmount View model objects
		/// </summary>
		public List<ExceptionalAmountViewModel> ExceptionalAmountViewModelList {get; set;} = new List<ExceptionalAmountViewModel>();
		#endregion
	}
	#endregion

    #region LoanStatus class definition
    public partial class LoanStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExceptionalAmount
		/// </summary>
		public LoanStatus LoanStatus = new LoanStatus();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public List<LoanViewModel> LoanViewModelList {get; set;} = new List<LoanViewModel>();
		#endregion
	}
	#endregion

    #region LoanType class definition
    public partial class LoanTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Loan
		/// </summary>
		public LoanType LoanType = new LoanType();

		/// <summary>
        /// Related ProductType View model objects
		/// </summary>
		public ProductTypeViewModel ProductTypeViewModel {get; set;} = new ProductTypeViewModel();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public List<LoanViewModel> LoanViewModelList {get; set;} = new List<LoanViewModel>();

		/// <summary>
        /// Related LoanTypeClosure View model objects
		/// </summary>
		public List<LoanTypeClosureViewModel> ClosingLoanTypeClosureViewModelList {get; set;} = new List<LoanTypeClosureViewModel>();

		/// <summary>
        /// Related LoanTypeClosure View model objects
		/// </summary>
		public List<LoanTypeClosureViewModel> LoanTypeClosureViewModelList {get; set;} = new List<LoanTypeClosureViewModel>();

		/// <summary>
        /// Related SpecialCaseLoan View model objects
		/// </summary>
		public List<SpecialCaseLoanViewModel> SpecialCaseLoanViewModelList {get; set;} = new List<SpecialCaseLoanViewModel>();
		#endregion
	}
	#endregion

    #region LoanTypeClosure class definition
    public partial class LoanTypeClosureViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of SpecialCaseLoan
		/// </summary>
		public LoanTypeClosure LoanTypeClosure = new LoanTypeClosure();

		/// <summary>
        /// Related LoanType View model objects
		/// </summary>
		public LoanTypeViewModel ClosingLoanTypeViewModel {get; set;} = new LoanTypeViewModel();

		/// <summary>
        /// Related LoanType View model objects
		/// </summary>
		public LoanTypeViewModel LoanTypeViewModel {get; set;} = new LoanTypeViewModel();
		#endregion
	}
	#endregion

    #region MainWorkPlace class definition
    public partial class MainWorkPlaceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanType
		/// </summary>
		public MainWorkPlace MainWorkPlace = new MainWorkPlace();

		/// <summary>
        /// Related IncomingLoan View model objects
		/// </summary>
		public List<IncomingLoanViewModel> IncomingLoanViewModelList {get; set;} = new List<IncomingLoanViewModel>();

		/// <summary>
        /// Related OutgoingLoan View model objects
		/// </summary>
		public List<OutgoingLoanViewModel> OutgoingLoanViewModelList {get; set;} = new List<OutgoingLoanViewModel>();

		/// <summary>
        /// Related SalaryWorkPlace View model objects
		/// </summary>
		public List<SalaryWorkPlaceViewModel> SalaryWorkPlaceViewModelList {get; set;} = new List<SalaryWorkPlaceViewModel>();

		/// <summary>
        /// Related TransitoryIncomingLoan View model objects
		/// </summary>
		public List<TransitoryIncomingLoanViewModel> TransitoryIncomingLoanViewModelList {get; set;} = new List<TransitoryIncomingLoanViewModel>();
		#endregion
	}
	#endregion

    #region MissingInstallmentDecrease class definition
    public partial class MissingInstallmentDecreaseViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of TransitoryIncomingLoan
		/// </summary>
		public MissingInstallmentDecrease MissingInstallmentDecrease = new MissingInstallmentDecrease();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();
		#endregion
	}
	#endregion

    #region MonthlyBalance class definition
    public partial class MonthlyBalanceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public MonthlyBalance MonthlyBalance = new MonthlyBalance();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related PaymentGroup View model objects
		/// </summary>
		public PaymentGroupViewModel PaymentGroupViewModel {get; set;} = new PaymentGroupViewModel();
		#endregion
	}
	#endregion

    #region OutgoingLoan class definition
    public partial class OutgoingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of PaymentGroup
		/// </summary>
		public OutgoingLoan OutgoingLoan = new OutgoingLoan();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public LoanViewModel LoanViewModel {get; set;} = new LoanViewModel();

		/// <summary>
        /// Related LoanDecision View model objects
		/// </summary>
		public LoanDecisionViewModel LoanDecisionViewModel {get; set;} = new LoanDecisionViewModel();

		/// <summary>
        /// Related MainWorkPlace View model objects
		/// </summary>
		public MainWorkPlaceViewModel MainWorkPlaceViewModel {get; set;} = new MainWorkPlaceViewModel();
		#endregion
	}
	#endregion

    #region Payment class definition
    public partial class PaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MainWorkPlace
		/// </summary>
		public Payment Payment = new Payment();

		/// <summary>
        /// Related CollectOrder View model objects
		/// </summary>
		public CollectOrderViewModel CollectOrderViewModel {get; set;} = new CollectOrderViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related PaymentGroup View model objects
		/// </summary>
		public PaymentGroupViewModel PaymentGroupViewModel {get; set;} = new PaymentGroupViewModel();

		/// <summary>
        /// Related PaymentStatus View model objects
		/// </summary>
		public PaymentStatusViewModel PaymentStatusViewModel {get; set;} = new PaymentStatusViewModel();

		/// <summary>
        /// Related CashPayment View model objects
		/// </summary>
		public CashPaymentViewModel CashPaymentViewModel {get; set;} = new CashPaymentViewModel();

		/// <summary>
        /// Related DownPayment View model objects
		/// </summary>
		public DownPaymentViewModel DownPaymentViewModel {get; set;} = new DownPaymentViewModel();

		/// <summary>
        /// Related SalaryPayment View model objects
		/// </summary>
		public SalaryPaymentViewModel SalaryPaymentViewModel {get; set;} = new SalaryPaymentViewModel();

		/// <summary>
        /// Related Settlement View model objects
		/// </summary>
		public List<SettlementViewModel> SettlementViewModelList {get; set;} = new List<SettlementViewModel>();
		#endregion
	}
	#endregion

    #region PaymentGroup class definition
    public partial class PaymentGroupViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Settlement
		/// </summary>
		public PaymentGroup PaymentGroup = new PaymentGroup();

		/// <summary>
        /// Related MonthlyBalance View model objects
		/// </summary>
		public List<MonthlyBalanceViewModel> MonthlyBalanceViewModelList {get; set;} = new List<MonthlyBalanceViewModel>();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public List<PaymentViewModel> PaymentViewModelList {get; set;} = new List<PaymentViewModel>();

		/// <summary>
        /// Related PayOrder View model objects
		/// </summary>
		public List<PayOrderViewModel> PayOrderViewModelList {get; set;} = new List<PayOrderViewModel>();

		/// <summary>
        /// Related ProductType View model objects
		/// </summary>
		public List<ProductTypeViewModel> ProductTypeViewModelList {get; set;} = new List<ProductTypeViewModel>();
		#endregion
	}
	#endregion

    #region PaymentStatus class definition
    public partial class PaymentStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductType
		/// </summary>
		public PaymentStatus PaymentStatus = new PaymentStatus();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public List<PaymentViewModel> PaymentViewModelList {get; set;} = new List<PaymentViewModel>();
		#endregion
	}
	#endregion

    #region PayOrder class definition
    public partial class PayOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Payment
		/// </summary>
		public PayOrder PayOrder = new PayOrder();

		/// <summary>
        /// Related PaymentGroup View model objects
		/// </summary>
		public PaymentGroupViewModel PaymentGroupViewModel {get; set;} = new PaymentGroupViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();
		#endregion
	}
	#endregion

    #region Product class definition
    public partial class ProductViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public Product Product = new Product();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related ProductType View model objects
		/// </summary>
		public ProductTypeViewModel ProductTypeViewModel {get; set;} = new ProductTypeViewModel();

		/// <summary>
        /// Related Grant View model objects
		/// </summary>
		public GrantViewModel GrantViewModel {get; set;} = new GrantViewModel();

		/// <summary>
        /// Related Loan View model objects
		/// </summary>
		public LoanViewModel LoanViewModel {get; set;} = new LoanViewModel();

		/// <summary>
        /// Related RefundableProduct View model objects
		/// </summary>
		public RefundableProductViewModel RefundableProductViewModel {get; set;} = new RefundableProductViewModel();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public RequestViewModel RequestViewModel {get; set;} = new RequestViewModel();
		#endregion
	}
	#endregion

    #region ProductType class definition
    public partial class ProductTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public ProductType ProductType = new ProductType();

		/// <summary>
        /// Related PaymentGroup View model objects
		/// </summary>
		public PaymentGroupViewModel PaymentGroupViewModel {get; set;} = new PaymentGroupViewModel();

		/// <summary>
        /// Related ProfitStrategy View model objects
		/// </summary>
		public ProfitStrategyViewModel ProfitStrategyViewModel {get; set;} = new ProfitStrategyViewModel();

		/// <summary>
        /// Related LoanType View model objects
		/// </summary>
		public LoanTypeViewModel LoanTypeViewModel {get; set;} = new LoanTypeViewModel();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public List<ProductViewModel> ProductViewModelList {get; set;} = new List<ProductViewModel>();

		/// <summary>
        /// Related ProductTypeAvailability View model objects
		/// </summary>
		public List<ProductTypeAvailabilityViewModel> ProductTypeAvailabilityViewModelList {get; set;} = new List<ProductTypeAvailabilityViewModel>();
		#endregion
	}
	#endregion

    #region ProductTypeAvailability class definition
    public partial class ProductTypeAvailabilityViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductTypeAvailability
		/// </summary>
		public ProductTypeAvailability ProductTypeAvailability = new ProductTypeAvailability();

		/// <summary>
        /// Related Availability View model objects
		/// </summary>
		public AvailabilityViewModel AvailabilityViewModel {get; set;} = new AvailabilityViewModel();

		/// <summary>
        /// Related ProductType View model objects
		/// </summary>
		public ProductTypeViewModel ProductTypeViewModel {get; set;} = new ProductTypeViewModel();
		#endregion
	}
	#endregion

    #region Profile class definition
    public partial class ProfileViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductType
		/// </summary>
		public Profile Profile = new Profile();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();
		#endregion
	}
	#endregion

    #region ProfitStrategy class definition
    public partial class ProfitStrategyViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public ProfitStrategy ProfitStrategy = new ProfitStrategy();

		/// <summary>
        /// Related ProductType View model objects
		/// </summary>
		public List<ProductTypeViewModel> ProductTypeViewModelList {get; set;} = new List<ProductTypeViewModel>();
		#endregion
	}
	#endregion

    #region RefundableProduct class definition
    public partial class RefundableProductViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductType
		/// </summary>
		public RefundableProduct RefundableProduct = new RefundableProduct();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public ProductViewModel ProductViewModel {get; set;} = new ProductViewModel();

		/// <summary>
        /// Related Guarantor View model objects
		/// </summary>
		public List<GuarantorViewModel> GuarantorViewModelList {get; set;} = new List<GuarantorViewModel>();

		/// <summary>
        /// Related Installment View model objects
		/// </summary>
		public List<InstallmentViewModel> InstallmentViewModelList {get; set;} = new List<InstallmentViewModel>();
		#endregion
	}
	#endregion

    #region Request class definition
    public partial class RequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Installment
		/// </summary>
		public Request Request = new Request();

		/// <summary>
        /// Related BypassStatus View model objects
		/// </summary>
		public BypassStatusViewModel BypassStatusViewModel {get; set;} = new BypassStatusViewModel();

		/// <summary>
        /// Related Product View model objects
		/// </summary>
		public ProductViewModel ProductViewModel {get; set;} = new ProductViewModel();

		/// <summary>
        /// Related RequestStatus View model objects
		/// </summary>
		public RequestStatusViewModel RequestStatusViewModel {get; set;} = new RequestStatusViewModel();

		/// <summary>
        /// Related DownPayment View model objects
		/// </summary>
		public List<DownPaymentViewModel> DownPaymentViewModelList {get; set;} = new List<DownPaymentViewModel>();

		/// <summary>
        /// Related GrantRequest View model objects
		/// </summary>
		public GrantRequestViewModel GrantRequestViewModel {get; set;} = new GrantRequestViewModel();

		/// <summary>
        /// Related LoanRequest View model objects
		/// </summary>
		public LoanRequestViewModel LoanRequestViewModel {get; set;} = new LoanRequestViewModel();
		#endregion
	}
	#endregion

    #region RequestStatus class definition
    public partial class RequestStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanRequest
		/// </summary>
		public RequestStatus RequestStatus = new RequestStatus();

		/// <summary>
        /// Related Request View model objects
		/// </summary>
		public List<RequestViewModel> RequestViewModelList {get; set;} = new List<RequestViewModel>();
		#endregion
	}
	#endregion

    #region Resource class definition
    public partial class ResourceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public Resource Resource = new Resource();
		#endregion
	}
	#endregion

    #region SalaryPayment class definition
    public partial class SalaryPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public SalaryPayment SalaryPayment = new SalaryPayment();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public PaymentViewModel PaymentViewModel {get; set;} = new PaymentViewModel();

		/// <summary>
        /// Related Department View model objects
		/// </summary>
		public DepartmentViewModel DepartmentViewModel {get; set;} = new DepartmentViewModel();
		#endregion
	}
	#endregion

    #region SalaryWorkPlace class definition
    public partial class SalaryWorkPlaceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Department
		/// </summary>
		public SalaryWorkPlace SalaryWorkPlace = new SalaryWorkPlace();

		/// <summary>
        /// Related MainWorkPlace View model objects
		/// </summary>
		public MainWorkPlaceViewModel MainWorkPlaceViewModel {get; set;} = new MainWorkPlaceViewModel();

		/// <summary>
        /// Related Department View model objects
		/// </summary>
		public List<DepartmentViewModel> DepartmentViewModelList {get; set;} = new List<DepartmentViewModel>();
		#endregion
	}
	#endregion

    #region ServiceEndGrantRequest class definition
    public partial class ServiceEndGrantRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Department
		/// </summary>
		public ServiceEndGrantRequest ServiceEndGrantRequest = new ServiceEndGrantRequest();

		/// <summary>
        /// Related GrantRequest View model objects
		/// </summary>
		public GrantRequestViewModel GrantRequestViewModel {get; set;} = new GrantRequestViewModel();
		#endregion
	}
	#endregion

    #region Settlement class definition
    public partial class SettlementViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantRequest
		/// </summary>
		public Settlement Settlement = new Settlement();

		/// <summary>
        /// Related Installment View model objects
		/// </summary>
		public InstallmentViewModel InstallmentViewModel {get; set;} = new InstallmentViewModel();

		/// <summary>
        /// Related Payment View model objects
		/// </summary>
		public PaymentViewModel PaymentViewModel {get; set;} = new PaymentViewModel();
		#endregion
	}
	#endregion

    #region SpecialCaseLoan class definition
    public partial class SpecialCaseLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Payment
		/// </summary>
		public SpecialCaseLoan SpecialCaseLoan = new SpecialCaseLoan();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related LoanType View model objects
		/// </summary>
		public LoanTypeViewModel LoanTypeViewModel {get; set;} = new LoanTypeViewModel();
		#endregion
	}
	#endregion

    #region Subscription class definition
    public partial class SubscriptionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanType
		/// </summary>
		public Subscription Subscription = new Subscription();

		/// <summary>
        /// Related Department View model objects
		/// </summary>
		public DepartmentViewModel DepartmentViewModel {get; set;} = new DepartmentViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related SubscriptionType View model objects
		/// </summary>
		public SubscriptionTypeViewModel SubscriptionTypeViewModel {get; set;} = new SubscriptionTypeViewModel();
		#endregion
	}
	#endregion

    #region SubscriptionType class definition
    public partial class SubscriptionTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of SubscriptionType
		/// </summary>
		public SubscriptionType SubscriptionType = new SubscriptionType();

		/// <summary>
        /// Related Subscription View model objects
		/// </summary>
		public List<SubscriptionViewModel> SubscriptionViewModelList {get; set;} = new List<SubscriptionViewModel>();
		#endregion
	}
	#endregion

    #region TransitoryIncomingLoan class definition
    public partial class TransitoryIncomingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Subscription
		/// </summary>
		public TransitoryIncomingLoan TransitoryIncomingLoan = new TransitoryIncomingLoan();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();

		/// <summary>
        /// Related MainWorkPlace View model objects
		/// </summary>
		public MainWorkPlaceViewModel MainWorkPlaceViewModel {get; set;} = new MainWorkPlaceViewModel();
		#endregion
	}
	#endregion

    #region Warrant class definition
    public partial class WarrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MainWorkPlace
		/// </summary>
		public Warrant Warrant = new Warrant();

		/// <summary>
        /// Related Debt View model objects
		/// </summary>
		public DebtViewModel DebtViewModel {get; set;} = new DebtViewModel();

		/// <summary>
        /// Related Employee View model objects
		/// </summary>
		public EmployeeViewModel EmployeeViewModel {get; set;} = new EmployeeViewModel();
		#endregion
	}
	#endregion
}
