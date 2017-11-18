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
        /// An instance of Availability
		/// </summary>
		public Availability Availability = new Availability();




		#endregion
	}
	#endregion

    #region AvailabilityCeiling class definition
    public partial class AvailabilityCeilingViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of AvailabilityCeiling
		/// </summary>
		public AvailabilityCeiling AvailabilityCeiling = new AvailabilityCeiling();




		#endregion
	}
	#endregion

    #region BypassStatus class definition
    public partial class BypassStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of BypassStatus
		/// </summary>
		public BypassStatus BypassStatus = new BypassStatus();




		#endregion
	}
	#endregion

    #region CashPayment class definition
    public partial class CashPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of CashPayment
		/// </summary>
		public CashPayment CashPayment = new CashPayment();


		/// <summary>
		/// Related Payment object
		/// </summary>
		public Payment Payment { get; set; } = new Payment();


		/// <summary>
		/// Related DownPayment objects
		/// </summary>
		public DownPayment PaymentPaymentDownPayment{ get; set; } = new DownPayment();

		/// <summary>
		/// Related SalaryPayment objects
		/// </summary>
		public SalaryPayment PaymentPaymentSalaryPayment{ get; set; } = new SalaryPayment();



		#endregion
	}
	#endregion

    #region Category class definition
    public partial class CategoryViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Category
		/// </summary>
		public Category Category = new Category();




		#endregion
	}
	#endregion

    #region CollectOrder class definition
    public partial class CollectOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of CollectOrder
		/// </summary>
		public CollectOrder CollectOrder = new CollectOrder();




		#endregion
	}
	#endregion

    #region Debt class definition
    public partial class DebtViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Debt
		/// </summary>
		public Debt Debt = new Debt();




		#endregion
	}
	#endregion

    #region Department class definition
    public partial class DepartmentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Department
		/// </summary>
		public Department Department = new Department();




		#endregion
	}
	#endregion

    #region DownPayment class definition
    public partial class DownPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of DownPayment
		/// </summary>
		public DownPayment DownPayment = new DownPayment();


		/// <summary>
		/// Related Payment object
		/// </summary>
		public Payment Payment { get; set; } = new Payment();


		/// <summary>
		/// Related CashPayment objects
		/// </summary>
		public CashPayment PaymentPaymentCashPayment{ get; set; } = new CashPayment();

		/// <summary>
		/// Related SalaryPayment objects
		/// </summary>
		public SalaryPayment PaymentPaymentSalaryPayment{ get; set; } = new SalaryPayment();



		#endregion
	}
	#endregion

    #region Employee class definition
    public partial class EmployeeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Employee
		/// </summary>
		public Employee Employee = new Employee();




		/// <summary>
		/// Related Profile objects
		/// </summary>
		public Profile EmployeeProfile{ get; set; } = new Profile();

		#endregion
	}
	#endregion

    #region EmployeeSeniority class definition
    public partial class EmployeeSeniorityViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EmployeeSeniority
		/// </summary>
		public EmployeeSeniority EmployeeSeniority = new EmployeeSeniority();


		/// <summary>
		/// Related Employee object
		/// </summary>
		public Employee Employee { get; set; } = new Employee();


		/// <summary>
		/// Related Profile objects
		/// </summary>
		public Profile EmployeeEmployeeProfile{ get; set; } = new Profile();



		#endregion
	}
	#endregion

    #region EmployeeStatus class definition
    public partial class EmployeeStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EmployeeStatus
		/// </summary>
		public EmployeeStatus EmployeeStatus = new EmployeeStatus();




		#endregion
	}
	#endregion

    #region EndWorkGrantBracket class definition
    public partial class EndWorkGrantBracketViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EndWorkGrantBracket
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
        /// An instance of ErrorDefinition
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
        /// An instance of EventCategory
		/// </summary>
		public EventCategory EventCategory = new EventCategory();




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
		/// Related EventLog object
		/// </summary>
		public EventLog EventLog { get; set; } = new EventLog();




		#endregion
	}
	#endregion

    #region EventSource class definition
    public partial class EventSourceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventSource
		/// </summary>
		public EventSource EventSource = new EventSource();




		#endregion
	}
	#endregion

    #region EventStatus class definition
    public partial class EventStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of EventStatus
		/// </summary>
		public EventStatus EventStatus = new EventStatus();




		#endregion
	}
	#endregion

    #region ExceptionalAmount class definition
    public partial class ExceptionalAmountViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExceptionalAmount
		/// </summary>
		public ExceptionalAmount ExceptionalAmount = new ExceptionalAmount();




		#endregion
	}
	#endregion

    #region ExceptionalAmountType class definition
    public partial class ExceptionalAmountTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExceptionalAmountType
		/// </summary>
		public ExceptionalAmountType ExceptionalAmountType = new ExceptionalAmountType();




		#endregion
	}
	#endregion

    #region ExternalGrant class definition
    public partial class ExternalGrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ExternalGrant
		/// </summary>
		public ExternalGrant ExternalGrant = new ExternalGrant();




		#endregion
	}
	#endregion

    #region Grant class definition
    public partial class GrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Grant
		/// </summary>
		public Grant Grant = new Grant();


		/// <summary>
		/// Related Product object
		/// </summary>
		public Product Product { get; set; } = new Product();


		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan ProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan ProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange ProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan ProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct ProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request ProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest ProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest ProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest ProductProductRequestLoanRequest{ get; set; } = new LoanRequest();



		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction GrantGrantDeduction{ get; set; } = new GrantDeduction();

		#endregion
	}
	#endregion

    #region GrantDecision class definition
    public partial class GrantDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantDecision
		/// </summary>
		public GrantDecision GrantDecision = new GrantDecision();




		#endregion
	}
	#endregion

    #region GrantDeduction class definition
    public partial class GrantDeductionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantDeduction
		/// </summary>
		public GrantDeduction GrantDeduction = new GrantDeduction();


		/// <summary>
		/// Related Grant object
		/// </summary>
		public Grant Grant { get; set; } = new Grant();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product GrantProduct { get; set; } = new Product();


		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan GrantProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan GrantProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange GrantProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan GrantProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct GrantProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request GrantProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest GrantProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest GrantProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest GrantProductProductRequestLoanRequest{ get; set; } = new LoanRequest();




		#endregion
	}
	#endregion

    #region GrantPayment class definition
    public partial class GrantPaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantPayment
		/// </summary>
		public GrantPayment GrantPayment = new GrantPayment();




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




		#endregion
	}
	#endregion

    #region GrantRequest class definition
    public partial class GrantRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantRequest
		/// </summary>
		public GrantRequest GrantRequest { get; set; } = new GrantRequest();


		/// <summary>
		/// Related Request object
		/// </summary>
		public Request Request { get; set; } = new Request();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product RequestProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant RequestProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction RequestProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan RequestProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan RequestProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange RequestProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan RequestProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct RequestProductProductRefundableProduct{ get; set; } = new RefundableProduct();


		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest RequestRequestLoanRequest{ get; set; } = new LoanRequest();



		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest GrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		#endregion
	}
	#endregion

    #region GrantType class definition
    public partial class GrantTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantType
		/// </summary>
		public GrantType GrantType = new GrantType();




		#endregion
	}
	#endregion

    #region GrantTypeGroup class definition
    public partial class GrantTypeGroupViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GrantTypeGroup
		/// </summary>
		public GrantTypeGroup GrantTypeGroup = new GrantTypeGroup();




		#endregion
	}
	#endregion

    #region Guarantor class definition
    public partial class GuarantorViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Guarantor
		/// </summary>
		public Guarantor Guarantor = new Guarantor();




		/// <summary>
		/// Related GuarantorStatement objects
		/// </summary>
		public GuarantorStatement GuarantorGuarantorStatement{ get; set; } = new GuarantorStatement();

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
		/// Related Guarantor object
		/// </summary>
		public Guarantor Guarantor { get; set; } = new Guarantor();




		#endregion
	}
	#endregion

    #region GuarantorStatus class definition
    public partial class GuarantorStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of GuarantorStatus
		/// </summary>
		public GuarantorStatus GuarantorStatus = new GuarantorStatus();




		#endregion
	}
	#endregion

    #region HealthLoanDecision class definition
    public partial class HealthLoanDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of HealthLoanDecision
		/// </summary>
		public HealthLoanDecision HealthLoanDecision = new HealthLoanDecision();




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




		#endregion
	}
	#endregion

    #region IncomingLoan class definition
    public partial class IncomingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of IncomingLoan
		/// </summary>
		public IncomingLoan IncomingLoan = new IncomingLoan();


		/// <summary>
		/// Related Loan object
		/// </summary>
		public Loan Loan { get; set; } = new Loan();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product LoanProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant LoanProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction LoanProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct LoanProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request LoanProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest LoanProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest LoanProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest LoanProductProductRequestLoanRequest{ get; set; } = new LoanRequest();


		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange LoanLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan LoanLoanOutgoingLoan{ get; set; } = new OutgoingLoan();



		#endregion
	}
	#endregion

    #region Installment class definition
    public partial class InstallmentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Installment
		/// </summary>
		public Installment Installment = new Installment();




		#endregion
	}
	#endregion

    #region InstallmentDecrease class definition
    public partial class InstallmentDecreaseViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of InstallmentDecrease
		/// </summary>
		public InstallmentDecrease InstallmentDecrease = new InstallmentDecrease();




		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrder class definition
    public partial class InstallmentDecreaseOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of InstallmentDecreaseOrder
		/// </summary>
		public InstallmentDecreaseOrder InstallmentDecreaseOrder = new InstallmentDecreaseOrder();




		#endregion
	}
	#endregion

    #region InsuranceType class definition
    public partial class InsuranceTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of InsuranceType
		/// </summary>
		public InsuranceType InsuranceType = new InsuranceType();




		#endregion
	}
	#endregion

    #region Issuer class definition
    public partial class IssuerViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Issuer
		/// </summary>
		public Issuer Issuer = new Issuer();




		#endregion
	}
	#endregion

    #region Loan class definition
    public partial class LoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Loan
		/// </summary>
		public Loan Loan = new Loan();


		/// <summary>
		/// Related Product object
		/// </summary>
		public Product Product { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant ProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction ProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct ProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request ProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest ProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest ProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest ProductProductRequestLoanRequest{ get; set; } = new LoanRequest();



		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan LoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange LoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan LoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		#endregion
	}
	#endregion

    #region LoanChange class definition
    public partial class LoanChangeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanChange
		/// </summary>
		public LoanChange LoanChange = new LoanChange();


		/// <summary>
		/// Related Loan object
		/// </summary>
		public Loan Loan { get; set; } = new Loan();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product LoanProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant LoanProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction LoanProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct LoanProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request LoanProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest LoanProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest LoanProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest LoanProductProductRequestLoanRequest{ get; set; } = new LoanRequest();


		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan LoanLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan LoanLoanOutgoingLoan{ get; set; } = new OutgoingLoan();



		#endregion
	}
	#endregion

    #region LoanDecision class definition
    public partial class LoanDecisionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanDecision
		/// </summary>
		public LoanDecision LoanDecision = new LoanDecision();




		#endregion
	}
	#endregion

    #region LoanDecisionType class definition
    public partial class LoanDecisionTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanDecisionType
		/// </summary>
		public LoanDecisionType LoanDecisionType = new LoanDecisionType();




		#endregion
	}
	#endregion

    #region LoanGenerationStatus class definition
    public partial class LoanGenerationStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanGenerationStatus
		/// </summary>
		public LoanGenerationStatus LoanGenerationStatus = new LoanGenerationStatus();




		#endregion
	}
	#endregion

    #region LoanRequest class definition
    public partial class LoanRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanRequest
		/// </summary>
		public LoanRequest LoanRequest { get; set; } = new LoanRequest();


		/// <summary>
		/// Related Request object
		/// </summary>
		public Request Request { get; set; } = new Request();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product RequestProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant RequestProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction RequestProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan RequestProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan RequestProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange RequestProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan RequestProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct RequestProductProductRefundableProduct{ get; set; } = new RefundableProduct();


		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest RequestRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest RequestRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();



		#endregion
	}
	#endregion

    #region LoanStatus class definition
    public partial class LoanStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanStatus
		/// </summary>
		public LoanStatus LoanStatus = new LoanStatus();




		#endregion
	}
	#endregion

    #region LoanType class definition
    public partial class LoanTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanType
		/// </summary>
		public LoanType LoanType = new LoanType();


		/// <summary>
		/// Related ProductType object
		/// </summary>
		public ProductType ProductType { get; set; } = new ProductType();




		#endregion
	}
	#endregion

    #region LoanTypeClosure class definition
    public partial class LoanTypeClosureViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of LoanTypeClosure
		/// </summary>
		public LoanTypeClosure LoanTypeClosure = new LoanTypeClosure();




		#endregion
	}
	#endregion

    #region MainWorkPlace class definition
    public partial class MainWorkPlaceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MainWorkPlace
		/// </summary>
		public MainWorkPlace MainWorkPlace = new MainWorkPlace();




		#endregion
	}
	#endregion

    #region MissingInstallmentDecrease class definition
    public partial class MissingInstallmentDecreaseViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MissingInstallmentDecrease
		/// </summary>
		public MissingInstallmentDecrease MissingInstallmentDecrease = new MissingInstallmentDecrease();


		/// <summary>
		/// Related Employee object
		/// </summary>
		public Employee Employee { get; set; } = new Employee();


		/// <summary>
		/// Related Profile objects
		/// </summary>
		public Profile EmployeeEmployeeProfile{ get; set; } = new Profile();



		#endregion
	}
	#endregion

    #region MonthlyBalance class definition
    public partial class MonthlyBalanceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of MonthlyBalance
		/// </summary>
		public MonthlyBalance MonthlyBalance = new MonthlyBalance();




		#endregion
	}
	#endregion

    #region OutgoingLoan class definition
    public partial class OutgoingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of OutgoingLoan
		/// </summary>
		public OutgoingLoan OutgoingLoan = new OutgoingLoan();


		/// <summary>
		/// Related Loan object
		/// </summary>
		public Loan Loan { get; set; } = new Loan();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product LoanProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant LoanProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction LoanProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct LoanProductProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request LoanProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest LoanProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest LoanProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest LoanProductProductRequestLoanRequest{ get; set; } = new LoanRequest();


		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan LoanLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange LoanLoanLoanChange{ get; set; } = new LoanChange();



		#endregion
	}
	#endregion

    #region Payment class definition
    public partial class PaymentViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Payment
		/// </summary>
		public Payment Payment = new Payment();




		/// <summary>
		/// Related CashPayment objects
		/// </summary>
		public CashPayment PaymentCashPayment{ get; set; } = new CashPayment();

		/// <summary>
		/// Related DownPayment objects
		/// </summary>
		public DownPayment PaymentDownPayment{ get; set; } = new DownPayment();

		/// <summary>
		/// Related SalaryPayment objects
		/// </summary>
		public SalaryPayment PaymentSalaryPayment{ get; set; } = new SalaryPayment();

		#endregion
	}
	#endregion

    #region PaymentGroup class definition
    public partial class PaymentGroupViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of PaymentGroup
		/// </summary>
		public PaymentGroup PaymentGroup = new PaymentGroup();




		#endregion
	}
	#endregion

    #region PaymentStatus class definition
    public partial class PaymentStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of PaymentStatus
		/// </summary>
		public PaymentStatus PaymentStatus = new PaymentStatus();




		#endregion
	}
	#endregion

    #region PayOrder class definition
    public partial class PayOrderViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of PayOrder
		/// </summary>
		public PayOrder PayOrder = new PayOrder();




		#endregion
	}
	#endregion

    #region Product class definition
    public partial class ProductViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Product
		/// </summary>
		public Product Product = new Product();




		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant ProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction ProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan ProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan ProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange ProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan ProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct ProductRefundableProduct{ get; set; } = new RefundableProduct();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request ProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest ProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest ProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest ProductRequestLoanRequest{ get; set; } = new LoanRequest();

		#endregion
	}
	#endregion

    #region ProductType class definition
    public partial class ProductTypeViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProductType
		/// </summary>
		public ProductType ProductType = new ProductType();




		/// <summary>
		/// Related LoanType objects
		/// </summary>
		public LoanType ProductTypeLoanType{ get; set; } = new LoanType();

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




		#endregion
	}
	#endregion

    #region Profile class definition
    public partial class ProfileViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Profile
		/// </summary>
		public Profile Profile = new Profile();


		/// <summary>
		/// Related Employee object
		/// </summary>
		public Employee Employee { get; set; } = new Employee();




		#endregion
	}
	#endregion

    #region ProfitStrategy class definition
    public partial class ProfitStrategyViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ProfitStrategy
		/// </summary>
		public ProfitStrategy ProfitStrategy = new ProfitStrategy();




		#endregion
	}
	#endregion

    #region RefundableProduct class definition
    public partial class RefundableProductViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of RefundableProduct
		/// </summary>
		public RefundableProduct RefundableProduct = new RefundableProduct();


		/// <summary>
		/// Related Product object
		/// </summary>
		public Product Product { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant ProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction ProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan ProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan ProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange ProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan ProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related Request objects
		/// </summary>
		public Request ProductProductRequest{ get; set; } = new Request();

		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest ProductProductRequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest ProductProductRequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest ProductProductRequestLoanRequest{ get; set; } = new LoanRequest();



		#endregion
	}
	#endregion

    #region Request class definition
    public partial class RequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Request
		/// </summary>
		public Request Request = new Request();


		/// <summary>
		/// Related Product object
		/// </summary>
		public Product Product { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant ProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction ProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan ProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan ProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange ProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan ProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct ProductProductRefundableProduct{ get; set; } = new RefundableProduct();



		/// <summary>
		/// Related GrantRequest objects
		/// </summary>
		public GrantRequest RequestGrantRequest{ get; set; } = new GrantRequest();

		/// <summary>
		/// Related ServiceEndGrantRequest objects
		/// </summary>
		public ServiceEndGrantRequest RequestGrantRequestServiceEndGrantRequest{ get; set; } = new ServiceEndGrantRequest();

		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest RequestLoanRequest{ get; set; } = new LoanRequest();

		#endregion
	}
	#endregion

    #region RequestStatus class definition
    public partial class RequestStatusViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of RequestStatus
		/// </summary>
		public RequestStatus RequestStatus = new RequestStatus();




		#endregion
	}
	#endregion

    #region Resource class definition
    public partial class ResourceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Resource
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
        /// An instance of SalaryPayment
		/// </summary>
		public SalaryPayment SalaryPayment = new SalaryPayment();


		/// <summary>
		/// Related Payment object
		/// </summary>
		public Payment Payment { get; set; } = new Payment();


		/// <summary>
		/// Related CashPayment objects
		/// </summary>
		public CashPayment PaymentPaymentCashPayment{ get; set; } = new CashPayment();

		/// <summary>
		/// Related DownPayment objects
		/// </summary>
		public DownPayment PaymentPaymentDownPayment{ get; set; } = new DownPayment();



		#endregion
	}
	#endregion

    #region SalaryWorkPlace class definition
    public partial class SalaryWorkPlaceViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of SalaryWorkPlace
		/// </summary>
		public SalaryWorkPlace SalaryWorkPlace = new SalaryWorkPlace();




		#endregion
	}
	#endregion

    #region ServiceEndGrantRequest class definition
    public partial class ServiceEndGrantRequestViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of ServiceEndGrantRequest
		/// </summary>
		public ServiceEndGrantRequest ServiceEndGrantRequest = new ServiceEndGrantRequest();


		/// <summary>
		/// Related GrantRequest object
		/// </summary>
		public GrantRequest GrantRequest { get; set; } = new GrantRequest();

		/// <summary>
		/// Related Request object
		/// </summary>
		public Request GrantRequestRequest { get; set; } = new Request();

		/// <summary>
		/// Related Product object
		/// </summary>
		public Product GrantRequestRequestProduct { get; set; } = new Product();


		/// <summary>
		/// Related Grant objects
		/// </summary>
		public Grant GrantRequestRequestProductProductGrant{ get; set; } = new Grant();

		/// <summary>
		/// Related GrantDeduction objects
		/// </summary>
		public GrantDeduction GrantRequestRequestProductProductGrantGrantDeduction{ get; set; } = new GrantDeduction();

		/// <summary>
		/// Related Loan objects
		/// </summary>
		public Loan GrantRequestRequestProductProductLoan{ get; set; } = new Loan();

		/// <summary>
		/// Related IncomingLoan objects
		/// </summary>
		public IncomingLoan GrantRequestRequestProductProductLoanIncomingLoan{ get; set; } = new IncomingLoan();

		/// <summary>
		/// Related LoanChange objects
		/// </summary>
		public LoanChange GrantRequestRequestProductProductLoanLoanChange{ get; set; } = new LoanChange();

		/// <summary>
		/// Related OutgoingLoan objects
		/// </summary>
		public OutgoingLoan GrantRequestRequestProductProductLoanOutgoingLoan{ get; set; } = new OutgoingLoan();

		/// <summary>
		/// Related RefundableProduct objects
		/// </summary>
		public RefundableProduct GrantRequestRequestProductProductRefundableProduct{ get; set; } = new RefundableProduct();


		/// <summary>
		/// Related LoanRequest objects
		/// </summary>
		public LoanRequest GrantRequestRequestRequestLoanRequest{ get; set; } = new LoanRequest();




		#endregion
	}
	#endregion

    #region Settlement class definition
    public partial class SettlementViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Settlement
		/// </summary>
		public Settlement Settlement = new Settlement();




		#endregion
	}
	#endregion

    #region SpecialCaseLoan class definition
    public partial class SpecialCaseLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of SpecialCaseLoan
		/// </summary>
		public SpecialCaseLoan SpecialCaseLoan = new SpecialCaseLoan();




		#endregion
	}
	#endregion

    #region Subscription class definition
    public partial class SubscriptionViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Subscription
		/// </summary>
		public Subscription Subscription = new Subscription();




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




		#endregion
	}
	#endregion

    #region TransitoryIncomingLoan class definition
    public partial class TransitoryIncomingLoanViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of TransitoryIncomingLoan
		/// </summary>
		public TransitoryIncomingLoan TransitoryIncomingLoan = new TransitoryIncomingLoan();


		/// <summary>
		/// Related Employee object
		/// </summary>
		public Employee Employee { get; set; } = new Employee();


		/// <summary>
		/// Related Profile objects
		/// </summary>
		public Profile EmployeeEmployeeProfile{ get; set; } = new Profile();



		#endregion
	}
	#endregion

    #region Warrant class definition
    public partial class WarrantViewModel
	{
		#region Public properties
		/// <summary>
        /// An instance of Warrant
		/// </summary>
		public Warrant Warrant = new Warrant();




		#endregion
	}
	#endregion
}
