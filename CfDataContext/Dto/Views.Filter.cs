using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilder;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region CashPaymentVwFilter class definition
	/// <summary>
    /// Filter class for CashPaymentVw
	/// </summary>
    [MetadataType(typeof(CashPaymentVwFilterMetaData))]
	public partial class CashPaymentVwFilter : Query
	{
        #region Constructors
        public CashPaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[PaymentId]");
            Select.Columns.Add("[PaymentEmployeeId]");
            // Select.Columns.Add("[PaymentEmployeeFirstName]");
            // Select.Columns.Add("[PaymentEmployeeLastName]");
            Select.Columns.Add("[PaymentEmployeeFullName]");
            // Select.Columns.Add("[PaymentEmployeeFatherName]");
            // Select.Columns.Add("[PaymentEmployeeFullName3]");
            // Select.Columns.Add("[PaymentEmployeeMotherName]");
            // Select.Columns.Add("[PaymentEmployeeBirthDate]");
            // Select.Columns.Add("[PaymentEmployeeExpectedEndDate]");
            // Select.Columns.Add("[PaymentEmployeeCersStartDate]");
            // Select.Columns.Add("[PaymentEmployeeCfStartDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveReason]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceId]");
            Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeNotes]");
            // Select.Columns.Add("[PaymentEmployeeCategoryId]");
            // Select.Columns.Add("[PaymentEmployeeCategoryName]");
            Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[PaymentPaymentGroupId]");
            Select.Columns.Add("[PaymentPaymentGroupName]");
            Select.Columns.Add("[PaymentAmount]");
            // Select.Columns.Add("[PaymentNotes]");
            // Select.Columns.Add("[PaymentPaymentStatusId]");
            Select.Columns.Add("[PaymentPaymentStatusName]");
            // Select.Columns.Add("[PaymentCollectOrderId]");
            // Select.Columns.Add("[PaymentCollectOrderNumber]");
            // Select.Columns.Add("[PaymentCollectOrderDate]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentNumber]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentDate]");
            // Select.Columns.Add("[Number]");
            // Select.Columns.Add("[ReceiptNumber]");
            // Select.Columns.Add("[ReceiptDate]");
            // Select.Columns.Add("[FeeAmount]");
            FromClause = "[dbo].[CashPaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> PaymentEmployeeId { get; set; }
		public string PaymentEmployeeFullNameContains { get; set; }
		public Nullable<int> PaymentEmployeeDepartmentSalaryWorkPlaceId { get; set; }
		public Nullable<DateTime> MinPaymentDate { get; set; }
		public Nullable<DateTime> MaxPaymentDate { get; set; }
		public Nullable<short> Number { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add PaymentEmployeeId criterion
			criterion = new SimpleCriterion("[PaymentEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@PaymentEmployeeId", PaymentEmployeeId));
			Criteria.Add(criterion);

			// Add PaymentEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[PaymentEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@PaymentEmployeeFullNameContains", PaymentEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add PaymentEmployeeDepartmentSalaryWorkPlaceId criterion
			criterion = new SimpleCriterion("[PaymentEmployeeDepartmentSalaryWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@PaymentEmployeeDepartmentSalaryWorkPlaceId", PaymentEmployeeDepartmentSalaryWorkPlaceId));
			Criteria.Add(criterion);

			// Add PaymentDateDateBetween criterion
			criterion = new DateBetweenCriterion("[PaymentDate]", SqlDbType.Date, new Parameter("@MinPaymentDate", MinPaymentDate), new Parameter("@MaxPaymentDate", MaxPaymentDate));
			Criteria.Add(criterion);

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region CollectOrderVwFilter class definition
	/// <summary>
    /// Filter class for CollectOrderVw
	/// </summary>
    [MetadataType(typeof(CollectOrderVwFilterMetaData))]
	public partial class CollectOrderVwFilter : Query
	{
        #region Constructors
        public CollectOrderVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Number]");
            Select.Columns.Add("[Date]");
            // Select.Columns.Add("[AccountingDocumentNumber]");
            // Select.Columns.Add("[AccountingDocumentDate]");
            FromClause = "[dbo].[CollectOrderVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> Number { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region DebtVwFilter class definition
	/// <summary>
    /// Filter class for DebtVw
	/// </summary>
    [MetadataType(typeof(DebtVwFilterMetaData))]
	public partial class DebtVwFilter : Query
	{
        #region Constructors
        public DebtVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[IssuerId]");
            Select.Columns.Add("[IssuerName]");
            // Select.Columns.Add("[ReferenceNumber]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[PeriodInMonths]");
            Select.Columns.Add("[ExceptionalPayment]");
            // Select.Columns.Add("[IsActive]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[IssueDescription]");
            Select.Columns.Add("[Installment]");
            FromClause = "[dbo].[DebtVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<int> EmployeeDepartmentSalaryWorkPlaceId { get; set; }
		public Nullable<byte> IssuerId { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add EmployeeDepartmentSalaryWorkPlaceId criterion
			criterion = new SimpleCriterion("[EmployeeDepartmentSalaryWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeDepartmentSalaryWorkPlaceId", EmployeeDepartmentSalaryWorkPlaceId));
			Criteria.Add(criterion);

			// Add IssuerId criterion
			criterion = new SimpleCriterion("[IssuerId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@IssuerId", IssuerId));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region DepartmentVwFilter class definition
	/// <summary>
    /// Filter class for DepartmentVw
	/// </summary>
    [MetadataType(typeof(DepartmentVwFilterMetaData))]
	public partial class DepartmentVwFilter : Query
	{
        #region Constructors
        public DepartmentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Name]");
            // Select.Columns.Add("[SalaryWorkPlaceId]");
            Select.Columns.Add("[SalaryWorkPlaceName]");
            // Select.Columns.Add("[SalaryWorkPlaceMainWorkPlaceId]");
            Select.Columns.Add("[SalaryWorkPlaceMainWorkPlaceName]");
            FromClause = "[dbo].[DepartmentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> Id { get; set; }
		public string NameContains { get; set; }
		public Nullable<int> SalaryWorkPlaceId { get; set; }
		public Nullable<int> SalaryWorkPlaceMainWorkPlaceId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Id criterion
			criterion = new SimpleCriterion("[Id]", SqlDbType.Int, OperatorType.Equals, new Parameter("@Id", Id));
			Criteria.Add(criterion);

			// Add NameContains criterion
			criterion = new SimpleCriterion("[Name]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@NameContains", NameContains));
			Criteria.Add(criterion);

			// Add SalaryWorkPlaceId criterion
			criterion = new SimpleCriterion("[SalaryWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@SalaryWorkPlaceId", SalaryWorkPlaceId));
			Criteria.Add(criterion);

			// Add SalaryWorkPlaceMainWorkPlaceId criterion
			criterion = new SimpleCriterion("[SalaryWorkPlaceMainWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@SalaryWorkPlaceMainWorkPlaceId", SalaryWorkPlaceMainWorkPlaceId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region DownPaymentVwFilter class definition
	/// <summary>
    /// Filter class for DownPaymentVw
	/// </summary>
    [MetadataType(typeof(DownPaymentVwFilterMetaData))]
	public partial class DownPaymentVwFilter : Query
	{
        #region Constructors
        public DownPaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[PaymentId]");
            Select.Columns.Add("[PaymentEmployeeId]");
            // Select.Columns.Add("[PaymentEmployeeFirstName]");
            // Select.Columns.Add("[PaymentEmployeeLastName]");
            Select.Columns.Add("[PaymentEmployeeFullName]");
            // Select.Columns.Add("[PaymentEmployeeFatherName]");
            // Select.Columns.Add("[PaymentEmployeeFullName3]");
            // Select.Columns.Add("[PaymentEmployeeMotherName]");
            // Select.Columns.Add("[PaymentEmployeeBirthDate]");
            // Select.Columns.Add("[PaymentEmployeeExpectedEndDate]");
            // Select.Columns.Add("[PaymentEmployeeCersStartDate]");
            // Select.Columns.Add("[PaymentEmployeeCfStartDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveReason]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeNotes]");
            // Select.Columns.Add("[PaymentEmployeeCategoryId]");
            // Select.Columns.Add("[PaymentEmployeeCategoryName]");
            Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[PaymentPaymentGroupId]");
            // Select.Columns.Add("[PaymentPaymentGroupName]");
            Select.Columns.Add("[PaymentAmount]");
            // Select.Columns.Add("[PaymentNotes]");
            // Select.Columns.Add("[PaymentPaymentStatusId]");
            // Select.Columns.Add("[PaymentPaymentStatusName]");
            // Select.Columns.Add("[PaymentCollectOrderId]");
            // Select.Columns.Add("[PaymentCollectOrderNumber]");
            // Select.Columns.Add("[PaymentCollectOrderDate]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentNumber]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentDate]");
            // Select.Columns.Add("[RequestProductId]");
            // Select.Columns.Add("[RequestProductEmployeeId]");
            // Select.Columns.Add("[RequestProductEmployeeFirstName]");
            // Select.Columns.Add("[RequestProductEmployeeLastName]");
            // Select.Columns.Add("[RequestProductEmployeeFullName]");
            // Select.Columns.Add("[RequestProductEmployeeFatherName]");
            // Select.Columns.Add("[RequestProductEmployeeFullName3]");
            // Select.Columns.Add("[RequestProductEmployeeMotherName]");
            // Select.Columns.Add("[RequestProductEmployeeBirthDate]");
            // Select.Columns.Add("[RequestProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[RequestProductEmployeeCersStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeCfStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveReason]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeNotes]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryId]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryName]");
            // Select.Columns.Add("[RequestProductProductTypeId]");
            Select.Columns.Add("[RequestProductProductTypeName]");
            // Select.Columns.Add("[RequestProductProductTypeRate]");
            // Select.Columns.Add("[RequestProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[RequestProductProductTypeAccountNumber]");
            // Select.Columns.Add("[RequestProductProductTypePrintLabel]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[RequestProductProductTypeIsActive]");
            Select.Columns.Add("[RequestProductAmount]");
            // Select.Columns.Add("[RequestProductNotes]");
            Select.Columns.Add("[RequestDate]");
            // Select.Columns.Add("[RequestAmount]");
            // Select.Columns.Add("[RequestAttachment]");
            // Select.Columns.Add("[RequestCost]");
            // Select.Columns.Add("[RequestRequestStatusId]");
            Select.Columns.Add("[RequestRequestStatusName]");
            // Select.Columns.Add("[RequestBypassStatusId]");
            // Select.Columns.Add("[RequestBypassStatusName]");
            // Select.Columns.Add("[RequestNotes]");
            FromClause = "[dbo].[DownPaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> PaymentEmployeeId { get; set; }
		public string PaymentEmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinPaymentDate { get; set; }
		public Nullable<DateTime> MaxPaymentDate { get; set; }
		public Nullable<short> RequestProductProductTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add PaymentEmployeeId criterion
			criterion = new SimpleCriterion("[PaymentEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@PaymentEmployeeId", PaymentEmployeeId));
			Criteria.Add(criterion);

			// Add PaymentEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[PaymentEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@PaymentEmployeeFullNameContains", PaymentEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add PaymentDateDateBetween criterion
			criterion = new DateBetweenCriterion("[PaymentDate]", SqlDbType.Date, new Parameter("@MinPaymentDate", MinPaymentDate), new Parameter("@MaxPaymentDate", MaxPaymentDate));
			Criteria.Add(criterion);

			// Add RequestProductProductTypeId criterion
			criterion = new SimpleCriterion("[RequestProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@RequestProductProductTypeId", RequestProductProductTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region EmployeeVwFilter class definition
	/// <summary>
    /// Filter class for EmployeeVw
	/// </summary>
    [MetadataType(typeof(EmployeeVwFilterMetaData))]
	public partial class EmployeeVwFilter : Query
	{
        #region Constructors
        public EmployeeVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[FirstName]");
            // Select.Columns.Add("[LastName]");
            Select.Columns.Add("[FullName]");
            Select.Columns.Add("[FatherName]");
            // Select.Columns.Add("[FullName3]");
            // Select.Columns.Add("[MotherName]");
            // Select.Columns.Add("[BirthDate]");
            // Select.Columns.Add("[ExpectedEndDate]");
            // Select.Columns.Add("[CersStartDate]");
            // Select.Columns.Add("[CfStartDate]");
            // Select.Columns.Add("[LeaveDate]");
            // Select.Columns.Add("[LeaveReason]");
            // Select.Columns.Add("[EmployeeStatusId]");
            Select.Columns.Add("[EmployeeStatusName]");
            // Select.Columns.Add("[EmployeeStatusIsActive]");
            // Select.Columns.Add("[DepartmentId]");
            Select.Columns.Add("[DepartmentName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[CategoryId]");
            // Select.Columns.Add("[CategoryName]");
            FromClause = "[dbo].[EmployeeVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> Id { get; set; }
		public string FullNameContains { get; set; }
		public Nullable<int> DepartmentId { get; set; }
		public string DepartmentNameContains { get; set; }
		public Nullable<byte> CategoryId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Id criterion
			criterion = new SimpleCriterion("[Id]", SqlDbType.Int, OperatorType.Equals, new Parameter("@Id", Id));
			Criteria.Add(criterion);

			// Add FullNameContains criterion
			criterion = new SimpleCriterion("[FullName]", SqlDbType.VarChar, OperatorType.ArabicSoundex, new Parameter("@FullNameContains", FullNameContains));
			Criteria.Add(criterion);

			// Add DepartmentId criterion
			criterion = new SimpleCriterion("[DepartmentId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@DepartmentId", DepartmentId));
			Criteria.Add(criterion);

			// Add DepartmentNameContains criterion
			criterion = new SimpleCriterion("[DepartmentName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@DepartmentNameContains", DepartmentNameContains));
			Criteria.Add(criterion);

			// Add CategoryId criterion
			criterion = new SimpleCriterion("[CategoryId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@CategoryId", CategoryId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region ErrorDefinitionVwFilter class definition
	/// <summary>
    /// Filter class for ErrorDefinitionVw
	/// </summary>
    [MetadataType(typeof(ErrorDefinitionVwFilterMetaData))]
	public partial class ErrorDefinitionVwFilter : Query
	{
        #region Constructors
        public ErrorDefinitionVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Message]");
            Select.Columns.Add("[LocalizedMessage]");
            Select.Columns.Add("[LikeExpression]");
            FromClause = "[dbo].[ErrorDefinitionVw]";
        }
        #endregion

        #region Public properties

		public string MessageContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add MessageContains criterion
			criterion = new SimpleCriterion("[Message]", SqlDbType.NVarChar, OperatorType.Contains, new Parameter("@MessageContains", MessageContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region EventCategoryVwFilter class definition
	/// <summary>
    /// Filter class for EventCategoryVw
	/// </summary>
    [MetadataType(typeof(EventCategoryVwFilterMetaData))]
	public partial class EventCategoryVwFilter : Query
	{
        #region Constructors
        public EventCategoryVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Name]");
            FromClause = "[dbo].[EventCategoryVw]";
        }
        #endregion

        #region Public properties

		public string NameContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add NameContains criterion
			criterion = new SimpleCriterion("[Name]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@NameContains", NameContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region EventLogErrorVwFilter class definition
	/// <summary>
    /// Filter class for EventLogErrorVw
	/// </summary>
    [MetadataType(typeof(EventLogErrorVwFilterMetaData))]
	public partial class EventLogErrorVwFilter : Query
	{
        #region Constructors
        public EventLogErrorVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[EventLogId]");
            // Select.Columns.Add("[EventLogEventSourceId]");
            // Select.Columns.Add("[EventLogEventSourceName]");
            // Select.Columns.Add("[EventLogEventCategoryId]");
            Select.Columns.Add("[EventLogEventCategoryName]");
            // Select.Columns.Add("[EventLogEventStatusId]");
            Select.Columns.Add("[EventLogEventStatusName]");
            // Select.Columns.Add("[EventLogEventStatusIcon]");
            Select.Columns.Add("[EventLogParameters]");
            Select.Columns.Add("[EventLogDate]");
            Select.Columns.Add("[EventLogUser]");
            Select.Columns.Add("[Number]");
            Select.Columns.Add("[Message]");
            // Select.Columns.Add("[StackTrace]");
            FromClause = "[dbo].[EventLogErrorVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EventLogEventCategoryId { get; set; }
		public Nullable<int> EventLogEventStatusId { get; set; }
		public CriterionBase EventLogParametersCustomCriterion { get; set; }
		public Nullable<DateTime> MinEventLogDate { get; set; }
		public Nullable<DateTime> MaxEventLogDate { get; set; }
		public Nullable<int> EventLogUser { get; set; }
		public string MessageContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EventLogEventCategoryId criterion
			criterion = new SimpleCriterion("[EventLogEventCategoryId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EventLogEventCategoryId", EventLogEventCategoryId));
			Criteria.Add(criterion);

			// Add EventLogEventStatusId criterion
			criterion = new SimpleCriterion("[EventLogEventStatusId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EventLogEventStatusId", EventLogEventStatusId));
			Criteria.Add(criterion);

			// Add EventLogParameters custom criterion
			if (EventLogParametersCustomCriterion != null)
				Criteria.Add(EventLogParametersCustomCriterion);

			// Add EventLogDateDateBetween criterion
			criterion = new DateBetweenCriterion("[EventLogDate]", SqlDbType.DateTime, new Parameter("@MinEventLogDate", MinEventLogDate), new Parameter("@MaxEventLogDate", MaxEventLogDate));
			Criteria.Add(criterion);

			// Add EventLogUser criterion
			criterion = new SimpleCriterion("[EventLogUser]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EventLogUser", EventLogUser));
			Criteria.Add(criterion);

			// Add MessageContains criterion
			criterion = new SimpleCriterion("[Message]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@MessageContains", MessageContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region EventLogVwFilter class definition
	/// <summary>
    /// Filter class for EventLogVw
	/// </summary>
    [MetadataType(typeof(EventLogVwFilterMetaData))]
	public partial class EventLogVwFilter : Query
	{
        #region Constructors
        public EventLogVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[EventSourceId]");
            // Select.Columns.Add("[EventSourceName]");
            // Select.Columns.Add("[EventCategoryId]");
            Select.Columns.Add("[EventCategoryName]");
            // Select.Columns.Add("[EventStatusId]");
            Select.Columns.Add("[EventStatusName]");
            // Select.Columns.Add("[EventStatusIcon]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[User]");
            Select.Columns.Add("[Parameters]");
            FromClause = "[dbo].[EventLogVw]";
        }
        #endregion

        #region Public properties

		public Nullable<long> Id { get; set; }
		public Nullable<int> EventCategoryId { get; set; }
		public Nullable<int> EventStatusId { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<int> User { get; set; }
		public CriterionBase ParametersCustomCriterion { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Id criterion
			criterion = new SimpleCriterion("[Id]", SqlDbType.BigInt, OperatorType.Equals, new Parameter("@Id", Id));
			Criteria.Add(criterion);

			// Add EventCategoryId criterion
			criterion = new SimpleCriterion("[EventCategoryId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EventCategoryId", EventCategoryId));
			Criteria.Add(criterion);

			// Add EventStatusId criterion
			criterion = new SimpleCriterion("[EventStatusId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EventStatusId", EventStatusId));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.DateTime, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add User criterion
			criterion = new SimpleCriterion("[User]", SqlDbType.Int, OperatorType.Equals, new Parameter("@User", User));
			Criteria.Add(criterion);

			// Add Parameters custom criterion
			if (ParametersCustomCriterion != null)
				Criteria.Add(ParametersCustomCriterion);

        }
        #endregion
    }
	#endregion

	#region ExternalGrantVwFilter class definition
	/// <summary>
    /// Filter class for ExternalGrantVw
	/// </summary>
    [MetadataType(typeof(ExternalGrantVwFilterMetaData))]
	public partial class ExternalGrantVwFilter : Query
	{
        #region Constructors
        public ExternalGrantVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[RequestDate]");
            // Select.Columns.Add("[GrantTypeId]");
            Select.Columns.Add("[GrantTypeName]");
            Select.Columns.Add("[GrantTypeAmount]");
            // Select.Columns.Add("[GrantTypeGrantTypeGroupId]");
            // Select.Columns.Add("[GrantTypeGrantTypeGroupName]");
            // Select.Columns.Add("[Description]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[CersNumber]");
            // Select.Columns.Add("[CersDate]");
            // Select.Columns.Add("[PaymentNumber]");
            // Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[ExternalGrantVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinRequestDate { get; set; }
		public Nullable<DateTime> MaxRequestDate { get; set; }
		public Nullable<byte> GrantTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add RequestDateDateBetween criterion
			criterion = new DateBetweenCriterion("[RequestDate]", SqlDbType.Date, new Parameter("@MinRequestDate", MinRequestDate), new Parameter("@MaxRequestDate", MaxRequestDate));
			Criteria.Add(criterion);

			// Add GrantTypeId criterion
			criterion = new SimpleCriterion("[GrantTypeId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@GrantTypeId", GrantTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GrantDecisionVwFilter class definition
	/// <summary>
    /// Filter class for GrantDecisionVw
	/// </summary>
    [MetadataType(typeof(GrantDecisionVwFilterMetaData))]
	public partial class GrantDecisionVwFilter : Query
	{
        #region Constructors
        public GrantDecisionVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Number]");
            Select.Columns.Add("[Year]");
            // Select.Columns.Add("[GrantTypeGroupId]");
            Select.Columns.Add("[GrantTypeGroupName]");
            Select.Columns.Add("[Date]");
            // Select.Columns.Add("[CersNumber]");
            // Select.Columns.Add("[CersDate]");
            // Select.Columns.Add("[PaymentNumber]");
            // Select.Columns.Add("[PaymentDate]");
            Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[TableNumber]");
            // Select.Columns.Add("[TableDate]");
            // Select.Columns.Add("[BaseNumber]");
            // Select.Columns.Add("[BaseDate]");
            // Select.Columns.Add("[AdditionalClause]");
            // Select.Columns.Add("[AdditionalIntroduction]");
            FromClause = "[dbo].[GrantDecisionVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> Number { get; set; }
		public Nullable<short> Year { get; set; }
		public Nullable<byte> GrantTypeGroupId { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add Year criterion
			criterion = new SimpleCriterion("[Year]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Year", Year));
			Criteria.Add(criterion);

			// Add GrantTypeGroupId criterion
			criterion = new SimpleCriterion("[GrantTypeGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@GrantTypeGroupId", GrantTypeGroupId));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GrantPaymentOrderVwFilter class definition
	/// <summary>
    /// Filter class for GrantPaymentOrderVw
	/// </summary>
    [MetadataType(typeof(GrantPaymentOrderVwFilterMetaData))]
	public partial class GrantPaymentOrderVwFilter : Query
	{
        #region Constructors
        public GrantPaymentOrderVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Number]");
            Select.Columns.Add("[Year]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[GrantPaymentOrderVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> Number { get; set; }
		public Nullable<short> Year { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add Year criterion
			criterion = new SimpleCriterion("[Year]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Year", Year));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GrantPaymentVwFilter class definition
	/// <summary>
    /// Filter class for GrantPaymentVw
	/// </summary>
    [MetadataType(typeof(GrantPaymentVwFilterMetaData))]
	public partial class GrantPaymentVwFilter : Query
	{
        #region Constructors
        public GrantPaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[GrantPaymentOrderId]");
            Select.Columns.Add("[GrantPaymentOrderNumber]");
            // Select.Columns.Add("[GrantPaymentOrderYear]");
            Select.Columns.Add("[GrantPaymentOrderDate]");
            // Select.Columns.Add("[GrantPaymentOrderNotes]");
            Select.Columns.Add("[SubNumber]");
            // Select.Columns.Add("[GrantProductId]");
            Select.Columns.Add("[GrantProductEmployeeId]");
            // Select.Columns.Add("[GrantProductEmployeeFirstName]");
            // Select.Columns.Add("[GrantProductEmployeeLastName]");
            Select.Columns.Add("[GrantProductEmployeeFullName]");
            // Select.Columns.Add("[GrantProductEmployeeFatherName]");
            // Select.Columns.Add("[GrantProductEmployeeFullName3]");
            // Select.Columns.Add("[GrantProductEmployeeMotherName]");
            // Select.Columns.Add("[GrantProductEmployeeBirthDate]");
            // Select.Columns.Add("[GrantProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[GrantProductEmployeeCersStartDate]");
            // Select.Columns.Add("[GrantProductEmployeeCfStartDate]");
            // Select.Columns.Add("[GrantProductEmployeeLeaveDate]");
            // Select.Columns.Add("[GrantProductEmployeeLeaveReason]");
            // Select.Columns.Add("[GrantProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[GrantProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[GrantProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentId]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentName]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[GrantProductEmployeeNotes]");
            // Select.Columns.Add("[GrantProductEmployeeCategoryId]");
            // Select.Columns.Add("[GrantProductEmployeeCategoryName]");
            // Select.Columns.Add("[GrantProductProductTypeId]");
            Select.Columns.Add("[GrantProductProductTypeName]");
            // Select.Columns.Add("[GrantProductProductTypeRate]");
            // Select.Columns.Add("[GrantProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[GrantProductProductTypeAccountNumber]");
            // Select.Columns.Add("[GrantProductProductTypePrintLabel]");
            // Select.Columns.Add("[GrantProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[GrantProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[GrantProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[GrantProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[GrantProductProductTypeIsActive]");
            Select.Columns.Add("[GrantProductAmount]");
            // Select.Columns.Add("[GrantProductNotes]");
            // Select.Columns.Add("[GrantGrantDecisionId]");
            // Select.Columns.Add("[GrantGrantDecisionNumber]");
            // Select.Columns.Add("[GrantGrantDecisionYear]");
            // Select.Columns.Add("[GrantGrantDecisionGrantTypeGroupId]");
            // Select.Columns.Add("[GrantGrantDecisionGrantTypeGroupName]");
            // Select.Columns.Add("[GrantGrantDecisionDate]");
            // Select.Columns.Add("[GrantGrantDecisionCersNumber]");
            // Select.Columns.Add("[GrantGrantDecisionCersDate]");
            // Select.Columns.Add("[GrantGrantDecisionPaymentNumber]");
            // Select.Columns.Add("[GrantGrantDecisionPaymentDate]");
            // Select.Columns.Add("[GrantGrantDecisionNotes]");
            // Select.Columns.Add("[GrantGrantDecisionTableNumber]");
            // Select.Columns.Add("[GrantGrantDecisionTableDate]");
            // Select.Columns.Add("[GrantGrantDecisionBaseNumber]");
            // Select.Columns.Add("[GrantGrantDecisionBaseDate]");
            // Select.Columns.Add("[GrantGrantDecisionAdditionalClause]");
            // Select.Columns.Add("[GrantGrantDecisionAdditionalIntroduction]");
            Select.Columns.Add("[GrantAmount]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[GrantPaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> GrantPaymentOrderNumber { get; set; }
		public Nullable<DateTime> MinGrantPaymentOrderDate { get; set; }
		public Nullable<DateTime> MaxGrantPaymentOrderDate { get; set; }
		public Nullable<byte> SubNumber { get; set; }
		public Nullable<int> GrantProductEmployeeId { get; set; }
		public string GrantProductEmployeeFullNameContains { get; set; }
		public Nullable<decimal> MinAmount { get; set; }
		public Nullable<decimal> MaxAmount { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add GrantPaymentOrderNumber criterion
			criterion = new SimpleCriterion("[GrantPaymentOrderNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@GrantPaymentOrderNumber", GrantPaymentOrderNumber));
			Criteria.Add(criterion);

			// Add GrantPaymentOrderDateDateBetween criterion
			criterion = new DateBetweenCriterion("[GrantPaymentOrderDate]", SqlDbType.Date, new Parameter("@MinGrantPaymentOrderDate", MinGrantPaymentOrderDate), new Parameter("@MaxGrantPaymentOrderDate", MaxGrantPaymentOrderDate));
			Criteria.Add(criterion);

			// Add SubNumber criterion
			criterion = new SimpleCriterion("[SubNumber]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@SubNumber", SubNumber));
			Criteria.Add(criterion);

			// Add GrantProductEmployeeId criterion
			criterion = new SimpleCriterion("[GrantProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@GrantProductEmployeeId", GrantProductEmployeeId));
			Criteria.Add(criterion);

			// Add GrantProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[GrantProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@GrantProductEmployeeFullNameContains", GrantProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add AmountBetween criterion
			criterion = new BetweenCriterion("[Amount]", SqlDbType.Money, new Parameter("@MinAmount", MinAmount), new Parameter("@MaxAmount", MaxAmount));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GrantRequestVwFilter class definition
	/// <summary>
    /// Filter class for GrantRequestVw
	/// </summary>
    [MetadataType(typeof(GrantRequestVwFilterMetaData))]
	public partial class GrantRequestVwFilter : Query
	{
        #region Constructors
        public GrantRequestVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[RequestProductId]");
            Select.Columns.Add("[RequestProductEmployeeId]");
            // Select.Columns.Add("[RequestProductEmployeeFirstName]");
            // Select.Columns.Add("[RequestProductEmployeeLastName]");
            Select.Columns.Add("[RequestProductEmployeeFullName]");
            // Select.Columns.Add("[RequestProductEmployeeFatherName]");
            // Select.Columns.Add("[RequestProductEmployeeFullName3]");
            // Select.Columns.Add("[RequestProductEmployeeMotherName]");
            // Select.Columns.Add("[RequestProductEmployeeBirthDate]");
            // Select.Columns.Add("[RequestProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[RequestProductEmployeeCersStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeCfStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveReason]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeNotes]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryId]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryName]");
            // Select.Columns.Add("[RequestProductProductTypeId]");
            Select.Columns.Add("[RequestProductProductTypeName]");
            // Select.Columns.Add("[RequestProductProductTypeRate]");
            // Select.Columns.Add("[RequestProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[RequestProductProductTypeAccountNumber]");
            // Select.Columns.Add("[RequestProductProductTypePrintLabel]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[RequestProductProductTypeIsActive]");
            // Select.Columns.Add("[RequestProductAmount]");
            // Select.Columns.Add("[RequestProductNotes]");
            Select.Columns.Add("[RequestDate]");
            // Select.Columns.Add("[RequestAmount]");
            // Select.Columns.Add("[RequestAttachment]");
            // Select.Columns.Add("[RequestCost]");
            // Select.Columns.Add("[RequestRequestStatusId]");
            // Select.Columns.Add("[RequestRequestStatusName]");
            // Select.Columns.Add("[RequestBypassStatusId]");
            // Select.Columns.Add("[RequestBypassStatusName]");
            // Select.Columns.Add("[RequestNotes]");
            Select.Columns.Add("[GrantType]");
            Select.Columns.Add("[Description]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            Select.Columns.Add("[EventDate]");
            Select.Columns.Add("[IsFromOtherBranch]");
            FromClause = "[dbo].[GrantRequestVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> RequestProductEmployeeId { get; set; }
		public string RequestProductEmployeeFullNameContains { get; set; }
		public Nullable<byte> GrantType { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add RequestProductEmployeeId criterion
			criterion = new SimpleCriterion("[RequestProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@RequestProductEmployeeId", RequestProductEmployeeId));
			Criteria.Add(criterion);

			// Add RequestProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[RequestProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@RequestProductEmployeeFullNameContains", RequestProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add GrantType criterion
			criterion = new SimpleCriterion("[GrantType]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@GrantType", GrantType));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GrantVwFilter class definition
	/// <summary>
    /// Filter class for GrantVw
	/// </summary>
    [MetadataType(typeof(GrantVwFilterMetaData))]
	public partial class GrantVwFilter : Query
	{
        #region Constructors
        public GrantVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[ProductId]");
            Select.Columns.Add("[ProductEmployeeId]");
            // Select.Columns.Add("[ProductEmployeeFirstName]");
            // Select.Columns.Add("[ProductEmployeeLastName]");
            Select.Columns.Add("[ProductEmployeeFullName]");
            // Select.Columns.Add("[ProductEmployeeFatherName]");
            // Select.Columns.Add("[ProductEmployeeFullName3]");
            // Select.Columns.Add("[ProductEmployeeMotherName]");
            // Select.Columns.Add("[ProductEmployeeBirthDate]");
            // Select.Columns.Add("[ProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[ProductEmployeeCersStartDate]");
            // Select.Columns.Add("[ProductEmployeeCfStartDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveReason]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[ProductEmployeeDepartmentId]");
            Select.Columns.Add("[ProductEmployeeDepartmentName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceId]");
            Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeNotes]");
            // Select.Columns.Add("[ProductEmployeeCategoryId]");
            // Select.Columns.Add("[ProductEmployeeCategoryName]");
            // Select.Columns.Add("[ProductProductTypeId]");
            Select.Columns.Add("[ProductProductTypeName]");
            // Select.Columns.Add("[ProductProductTypeRate]");
            // Select.Columns.Add("[ProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductProductTypePrintLabel]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductProductTypeIsActive]");
            // Select.Columns.Add("[ProductAmount]");
            // Select.Columns.Add("[ProductNotes]");
            // Select.Columns.Add("[GrantDecisionId]");
            Select.Columns.Add("[GrantDecisionNumber]");
            Select.Columns.Add("[GrantDecisionYear]");
            // Select.Columns.Add("[GrantDecisionGrantTypeGroupId]");
            // Select.Columns.Add("[GrantDecisionGrantTypeGroupName]");
            Select.Columns.Add("[GrantDecisionDate]");
            // Select.Columns.Add("[GrantDecisionCersNumber]");
            // Select.Columns.Add("[GrantDecisionCersDate]");
            // Select.Columns.Add("[GrantDecisionPaymentNumber]");
            // Select.Columns.Add("[GrantDecisionPaymentDate]");
            // Select.Columns.Add("[GrantDecisionNotes]");
            // Select.Columns.Add("[GrantDecisionTableNumber]");
            // Select.Columns.Add("[GrantDecisionTableDate]");
            // Select.Columns.Add("[GrantDecisionBaseNumber]");
            // Select.Columns.Add("[GrantDecisionBaseDate]");
            // Select.Columns.Add("[GrantDecisionAdditionalClause]");
            // Select.Columns.Add("[GrantDecisionAdditionalIntroduction]");
            Select.Columns.Add("[Amount]");
            FromClause = "[dbo].[GrantVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> ProductEmployeeId { get; set; }
		public string ProductEmployeeFullNameContains { get; set; }
		public Nullable<short> GrantDecisionNumber { get; set; }
		public Nullable<short> GrantDecisionYear { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add ProductEmployeeId criterion
			criterion = new SimpleCriterion("[ProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@ProductEmployeeId", ProductEmployeeId));
			Criteria.Add(criterion);

			// Add ProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[ProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ProductEmployeeFullNameContains", ProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add GrantDecisionNumber criterion
			criterion = new SimpleCriterion("[GrantDecisionNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@GrantDecisionNumber", GrantDecisionNumber));
			Criteria.Add(criterion);

			// Add GrantDecisionYear criterion
			criterion = new SimpleCriterion("[GrantDecisionYear]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@GrantDecisionYear", GrantDecisionYear));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region GuarantorVwFilter class definition
	/// <summary>
    /// Filter class for GuarantorVw
	/// </summary>
    [MetadataType(typeof(GuarantorVwFilterMetaData))]
	public partial class GuarantorVwFilter : Query
	{
        #region Constructors
        public GuarantorVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[RefundableProductProductId]");
            Select.Columns.Add("[RefundableProductProductEmployeeId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFirstName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLastName]");
            Select.Columns.Add("[RefundableProductProductEmployeeFullName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFatherName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFullName3]");
            // Select.Columns.Add("[RefundableProductProductEmployeeMotherName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeBirthDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCersStartDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCfStartDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLeaveDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLeaveReason]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeNotes]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCategoryId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCategoryName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeId]");
            Select.Columns.Add("[RefundableProductProductProductTypeName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeRate]");
            // Select.Columns.Add("[RefundableProductProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[RefundableProductProductProductTypeAccountNumber]");
            // Select.Columns.Add("[RefundableProductProductProductTypePrintLabel]");
            // Select.Columns.Add("[RefundableProductProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[RefundableProductProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[RefundableProductProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[RefundableProductProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeIsActive]");
            Select.Columns.Add("[RefundableProductProductAmount]");
            // Select.Columns.Add("[RefundableProductProductNotes]");
            // Select.Columns.Add("[RefundableProductPaymentPeriod]");
            // Select.Columns.Add("[RefundableProductInstallment]");
            // Select.Columns.Add("[RefundableProductNetAmount]");
            // Select.Columns.Add("[RefundableProductProfitAmount]");
            // Select.Columns.Add("[RefundableProductSyrianPoundRounds]");
            // Select.Columns.Add("[SubNumber]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[GuarantorStatusId]");
            Select.Columns.Add("[GuarantorStatusName]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[GuarantorVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> RefundableProductProductEmployeeId { get; set; }
		public string RefundableProductProductEmployeeFullNameContains { get; set; }
		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add RefundableProductProductEmployeeId criterion
			criterion = new SimpleCriterion("[RefundableProductProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@RefundableProductProductEmployeeId", RefundableProductProductEmployeeId));
			Criteria.Add(criterion);

			// Add RefundableProductProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[RefundableProductProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@RefundableProductProductEmployeeFullNameContains", RefundableProductProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region HealthLoanDecisionFirstPaymentVwFilter class definition
	/// <summary>
    /// Filter class for HealthLoanDecisionFirstPaymentVw
	/// </summary>
    [MetadataType(typeof(HealthLoanDecisionFirstPaymentVwFilterMetaData))]
	public partial class HealthLoanDecisionFirstPaymentVwFilter : Query
	{
        #region Constructors
        public HealthLoanDecisionFirstPaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[PaymentDate]");
            Select.Columns.Add("[PaymentAmount]");
            // Select.Columns.Add("[PaymentNotes]");
            // Select.Columns.Add("[InvoiceDate]");
            // Select.Columns.Add("[InvoiceAmount]");
            // Select.Columns.Add("[InvoiceNotes]");
            // Select.Columns.Add("[InsuranceDate]");
            // Select.Columns.Add("[InsuranceAmount]");
            // Select.Columns.Add("[InsuranceTypeId]");
            // Select.Columns.Add("[InsuranceTypeName]");
            // Select.Columns.Add("[InsuranceNotes]");
            // Select.Columns.Add("[BoardDate]");
            // Select.Columns.Add("[BoardAmount]");
            // Select.Columns.Add("[BoardType]");
            // Select.Columns.Add("[BoardNotes]");
            // Select.Columns.Add("[DirectPaymentDate]");
            // Select.Columns.Add("[DirectPaymentAmount]");
            // Select.Columns.Add("[DirectPaymentNotes]");
            // Select.Columns.Add("[PaymentStatus]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[Department]");
            // Select.Columns.Add("[HealthLoanDecisionId]");
            Select.Columns.Add("[HealthLoanDecisionNumber]");
            // Select.Columns.Add("[HealthLoanDecisionYear]");
            Select.Columns.Add("[HealthLoanDecisionDate]");
            // Select.Columns.Add("[HealthLoanDecisionCersNumber]");
            // Select.Columns.Add("[HealthLoanDecisionCersDate]");
            // Select.Columns.Add("[HealthLoanDecisionPaymentNumber]");
            // Select.Columns.Add("[HealthLoanDecisionPaymentDate]");
            // Select.Columns.Add("[HealthLoanDecisionNotes]");
            // Select.Columns.Add("[RequestCost]");
            // Select.Columns.Add("[LoanRequest]");
            FromClause = "[dbo].[HealthLoanDecisionFirstPaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<short> HealthLoanDecisionNumber { get; set; }
		public Nullable<short> HealthLoanDecisionYear { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add HealthLoanDecisionNumber criterion
			criterion = new SimpleCriterion("[HealthLoanDecisionNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@HealthLoanDecisionNumber", HealthLoanDecisionNumber));
			Criteria.Add(criterion);

			// Add HealthLoanDecisionYear criterion
			criterion = new SimpleCriterion("[HealthLoanDecisionYear]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@HealthLoanDecisionYear", HealthLoanDecisionYear));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region HealthLoanDecisionVwFilter class definition
	/// <summary>
    /// Filter class for HealthLoanDecisionVw
	/// </summary>
    [MetadataType(typeof(HealthLoanDecisionVwFilterMetaData))]
	public partial class HealthLoanDecisionVwFilter : Query
	{
        #region Constructors
        public HealthLoanDecisionVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Number]");
            // Select.Columns.Add("[Year]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[CersNumber]");
            Select.Columns.Add("[CersDate]");
            // Select.Columns.Add("[PaymentNumber]");
            // Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[HealthLoanDecisionVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> Number { get; set; }
		public Nullable<short> Year { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add Year criterion
			criterion = new SimpleCriterion("[Year]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Year", Year));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region IncomingLoanVwFilter class definition
	/// <summary>
    /// Filter class for IncomingLoanVw
	/// </summary>
    [MetadataType(typeof(IncomingLoanVwFilterMetaData))]
	public partial class IncomingLoanVwFilter : Query
	{
        #region Constructors
        public IncomingLoanVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[LoanProductId]");
            Select.Columns.Add("[LoanProductEmployeeId]");
            // Select.Columns.Add("[LoanProductEmployeeFirstName]");
            // Select.Columns.Add("[LoanProductEmployeeLastName]");
            Select.Columns.Add("[LoanProductEmployeeFullName]");
            // Select.Columns.Add("[LoanProductEmployeeFatherName]");
            // Select.Columns.Add("[LoanProductEmployeeFullName3]");
            // Select.Columns.Add("[LoanProductEmployeeMotherName]");
            // Select.Columns.Add("[LoanProductEmployeeBirthDate]");
            // Select.Columns.Add("[LoanProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[LoanProductEmployeeCersStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeCfStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveReason]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeNotes]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryId]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryName]");
            // Select.Columns.Add("[LoanProductProductTypeId]");
            Select.Columns.Add("[LoanProductProductTypeName]");
            // Select.Columns.Add("[LoanProductProductTypeRate]");
            // Select.Columns.Add("[LoanProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[LoanProductProductTypeAccountNumber]");
            // Select.Columns.Add("[LoanProductProductTypePrintLabel]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[LoanProductProductTypeIsActive]");
            Select.Columns.Add("[LoanProductAmount]");
            // Select.Columns.Add("[LoanProductNotes]");
            // Select.Columns.Add("[LoanLoanDecisionId]");
            Select.Columns.Add("[LoanLoanDecisionNumber]");
            // Select.Columns.Add("[LoanLoanDecisionYear]");
            Select.Columns.Add("[LoanLoanDecisionDate]");
            // Select.Columns.Add("[LoanLoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[LoanLoanDecisionCersNumber]");
            // Select.Columns.Add("[LoanLoanDecisionCersDate]");
            // Select.Columns.Add("[LoanLoanDecisionNotes]");
            // Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeId]");
            Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentNumber]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentDate]");
            // Select.Columns.Add("[LoanLoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[LoanLoanDecisionReason]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalClause]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalIntroduction]");
            // Select.Columns.Add("[LoanLoanType]");
            // Select.Columns.Add("[LoanLoanGenerationStatusId]");
            // Select.Columns.Add("[LoanLoanGenerationStatusName]");
            // Select.Columns.Add("[LoanLoanStatusId]");
            Select.Columns.Add("[LoanLoanStatusName]");
            // Select.Columns.Add("[MainWorkPlaceId]");
            // Select.Columns.Add("[MainWorkPlaceName]");
            FromClause = "[dbo].[IncomingLoanVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> LoanProductEmployeeId { get; set; }
		public string LoanProductEmployeeFullNameContains { get; set; }
		public Nullable<short> LoanProductProductTypeId { get; set; }
		public Nullable<short> LoanLoanDecisionNumber { get; set; }
		public Nullable<short> LoanLoanDecisionYear { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add LoanProductEmployeeId criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@LoanProductEmployeeId", LoanProductEmployeeId));
			Criteria.Add(criterion);

			// Add LoanProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@LoanProductEmployeeFullNameContains", LoanProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add LoanProductProductTypeId criterion
			criterion = new SimpleCriterion("[LoanProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanProductProductTypeId", LoanProductProductTypeId));
			Criteria.Add(criterion);

			// Add LoanLoanDecisionNumber criterion
			criterion = new SimpleCriterion("[LoanLoanDecisionNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanLoanDecisionNumber", LoanLoanDecisionNumber));
			Criteria.Add(criterion);

			// Add LoanLoanDecisionYear criterion
			criterion = new SimpleCriterion("[LoanLoanDecisionYear]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanLoanDecisionYear", LoanLoanDecisionYear));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region InstallmentDecreaseOrderVwFilter class definition
	/// <summary>
    /// Filter class for InstallmentDecreaseOrderVw
	/// </summary>
    [MetadataType(typeof(InstallmentDecreaseOrderVwFilterMetaData))]
	public partial class InstallmentDecreaseOrderVwFilter : Query
	{
        #region Constructors
        public InstallmentDecreaseOrderVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Month]");
            Select.Columns.Add("[CersNumber]");
            Select.Columns.Add("[CersDate]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[InstallmentDecreaseOrderVw]";
        }
        #endregion

        #region Public properties

		public Nullable<DateTime> MinMonth { get; set; }
		public Nullable<DateTime> MaxMonth { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add MonthDateBetween criterion
			criterion = new DateBetweenCriterion("[Month]", SqlDbType.Date, new Parameter("@MinMonth", MinMonth), new Parameter("@MaxMonth", MaxMonth));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region InstallmentDecreaseVwFilter class definition
	/// <summary>
    /// Filter class for InstallmentDecreaseVw
	/// </summary>
    [MetadataType(typeof(InstallmentDecreaseVwFilterMetaData))]
	public partial class InstallmentDecreaseVwFilter : Query
	{
        #region Constructors
        public InstallmentDecreaseVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[InstallmentDecreaseOrderId]");
            Select.Columns.Add("[InstallmentDecreaseOrderMonth]");
            Select.Columns.Add("[InstallmentDecreaseOrderCersNumber]");
            Select.Columns.Add("[InstallmentDecreaseOrderCersDate]");
            // Select.Columns.Add("[InstallmentDecreaseOrderNotes]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[DepartmentId]");
            // Select.Columns.Add("[DepartmentName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceName]");
            Select.Columns.Add("[DecreaseAmount]");
            Select.Columns.Add("[NewInstallmentAmount]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[InstallmentDecreaseVw]";
        }
        #endregion

        #region Public properties

		public Nullable<DateTime> MinInstallmentDecreaseOrderMonth { get; set; }
		public Nullable<DateTime> MaxInstallmentDecreaseOrderMonth { get; set; }
		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add InstallmentDecreaseOrderMonthDateBetween criterion
			criterion = new DateBetweenCriterion("[InstallmentDecreaseOrderMonth]", SqlDbType.Date, new Parameter("@MinInstallmentDecreaseOrderMonth", MinInstallmentDecreaseOrderMonth), new Parameter("@MaxInstallmentDecreaseOrderMonth", MaxInstallmentDecreaseOrderMonth));
			Criteria.Add(criterion);

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region InstallmentVwFilter class definition
	/// <summary>
    /// Filter class for InstallmentVw
	/// </summary>
    [MetadataType(typeof(InstallmentVwFilterMetaData))]
	public partial class InstallmentVwFilter : Query
	{
        #region Constructors
        public InstallmentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[RefundableProductProductId]");
            Select.Columns.Add("[RefundableProductProductEmployeeId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFirstName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLastName]");
            Select.Columns.Add("[RefundableProductProductEmployeeFullName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFatherName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeFullName3]");
            // Select.Columns.Add("[RefundableProductProductEmployeeMotherName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeBirthDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCersStartDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCfStartDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLeaveDate]");
            // Select.Columns.Add("[RefundableProductProductEmployeeLeaveReason]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[RefundableProductProductEmployeeNotes]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCategoryId]");
            // Select.Columns.Add("[RefundableProductProductEmployeeCategoryName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeId]");
            Select.Columns.Add("[RefundableProductProductProductTypeName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeRate]");
            // Select.Columns.Add("[RefundableProductProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[RefundableProductProductProductTypeAccountNumber]");
            // Select.Columns.Add("[RefundableProductProductProductTypePrintLabel]");
            // Select.Columns.Add("[RefundableProductProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[RefundableProductProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[RefundableProductProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[RefundableProductProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[RefundableProductProductProductTypeIsActive]");
            // Select.Columns.Add("[RefundableProductProductAmount]");
            // Select.Columns.Add("[RefundableProductProductNotes]");
            // Select.Columns.Add("[RefundableProductPaymentPeriod]");
            Select.Columns.Add("[RefundableProductInstallment]");
            // Select.Columns.Add("[RefundableProductNetAmount]");
            // Select.Columns.Add("[RefundableProductProfitAmount]");
            // Select.Columns.Add("[RefundableProductSyrianPoundRounds]");
            Select.Columns.Add("[SubNumber]");
            Select.Columns.Add("[DueDate]");
            Select.Columns.Add("[DueCapital]");
            Select.Columns.Add("[DueProfit]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[InstallmentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> RefundableProductProductEmployeeId { get; set; }
		public string RefundableProductProductEmployeeFullNameContains { get; set; }
		public Nullable<short> RefundableProductProductProductTypeId { get; set; }
		public Nullable<short> SubNumber { get; set; }
		public Nullable<DateTime> MinDueDate { get; set; }
		public Nullable<DateTime> MaxDueDate { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add RefundableProductProductEmployeeId criterion
			criterion = new SimpleCriterion("[RefundableProductProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@RefundableProductProductEmployeeId", RefundableProductProductEmployeeId));
			Criteria.Add(criterion);

			// Add RefundableProductProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[RefundableProductProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@RefundableProductProductEmployeeFullNameContains", RefundableProductProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add RefundableProductProductProductTypeId criterion
			criterion = new SimpleCriterion("[RefundableProductProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@RefundableProductProductProductTypeId", RefundableProductProductProductTypeId));
			Criteria.Add(criterion);

			// Add SubNumber criterion
			criterion = new SimpleCriterion("[SubNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@SubNumber", SubNumber));
			Criteria.Add(criterion);

			// Add DueDateDateBetween criterion
			criterion = new DateBetweenCriterion("[DueDate]", SqlDbType.Date, new Parameter("@MinDueDate", MinDueDate), new Parameter("@MaxDueDate", MaxDueDate));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region LoanChangeVwFilter class definition
	/// <summary>
    /// Filter class for LoanChangeVw
	/// </summary>
    [MetadataType(typeof(LoanChangeVwFilterMetaData))]
	public partial class LoanChangeVwFilter : Query
	{
        #region Constructors
        public LoanChangeVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[LoanProductId]");
            Select.Columns.Add("[LoanProductEmployeeId]");
            // Select.Columns.Add("[LoanProductEmployeeFirstName]");
            // Select.Columns.Add("[LoanProductEmployeeLastName]");
            Select.Columns.Add("[LoanProductEmployeeFullName]");
            // Select.Columns.Add("[LoanProductEmployeeFatherName]");
            // Select.Columns.Add("[LoanProductEmployeeFullName3]");
            // Select.Columns.Add("[LoanProductEmployeeMotherName]");
            // Select.Columns.Add("[LoanProductEmployeeBirthDate]");
            // Select.Columns.Add("[LoanProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[LoanProductEmployeeCersStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeCfStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveReason]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeNotes]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryId]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryName]");
            // Select.Columns.Add("[LoanProductProductTypeId]");
            Select.Columns.Add("[LoanProductProductTypeName]");
            // Select.Columns.Add("[LoanProductProductTypeRate]");
            // Select.Columns.Add("[LoanProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[LoanProductProductTypeAccountNumber]");
            // Select.Columns.Add("[LoanProductProductTypePrintLabel]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[LoanProductProductTypeIsActive]");
            Select.Columns.Add("[LoanProductAmount]");
            // Select.Columns.Add("[LoanProductNotes]");
            // Select.Columns.Add("[LoanLoanDecisionId]");
            // Select.Columns.Add("[LoanLoanDecisionNumber]");
            // Select.Columns.Add("[LoanLoanDecisionYear]");
            Select.Columns.Add("[LoanLoanDecisionDate]");
            // Select.Columns.Add("[LoanLoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[LoanLoanDecisionCersNumber]");
            // Select.Columns.Add("[LoanLoanDecisionCersDate]");
            // Select.Columns.Add("[LoanLoanDecisionNotes]");
            // Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeId]");
            // Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentNumber]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentDate]");
            // Select.Columns.Add("[LoanLoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[LoanLoanDecisionReason]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalClause]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalIntroduction]");
            Select.Columns.Add("[LoanLoanType]");
            // Select.Columns.Add("[LoanLoanGenerationStatusId]");
            // Select.Columns.Add("[LoanLoanGenerationStatusName]");
            // Select.Columns.Add("[LoanLoanStatusId]");
            // Select.Columns.Add("[LoanLoanStatusName]");
            // Select.Columns.Add("[FromLoanProductId]");
            Select.Columns.Add("[FromLoanProductEmployeeId]");
            // Select.Columns.Add("[FromLoanProductEmployeeFirstName]");
            // Select.Columns.Add("[FromLoanProductEmployeeLastName]");
            Select.Columns.Add("[FromLoanProductEmployeeFullName]");
            // Select.Columns.Add("[FromLoanProductEmployeeFatherName]");
            // Select.Columns.Add("[FromLoanProductEmployeeFullName3]");
            // Select.Columns.Add("[FromLoanProductEmployeeMotherName]");
            // Select.Columns.Add("[FromLoanProductEmployeeBirthDate]");
            // Select.Columns.Add("[FromLoanProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[FromLoanProductEmployeeCersStartDate]");
            // Select.Columns.Add("[FromLoanProductEmployeeCfStartDate]");
            // Select.Columns.Add("[FromLoanProductEmployeeLeaveDate]");
            // Select.Columns.Add("[FromLoanProductEmployeeLeaveReason]");
            // Select.Columns.Add("[FromLoanProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[FromLoanProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[FromLoanProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentId]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentName]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[FromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[FromLoanProductEmployeeNotes]");
            // Select.Columns.Add("[FromLoanProductEmployeeCategoryId]");
            // Select.Columns.Add("[FromLoanProductEmployeeCategoryName]");
            // Select.Columns.Add("[FromLoanProductProductTypeId]");
            // Select.Columns.Add("[FromLoanProductProductTypeName]");
            // Select.Columns.Add("[FromLoanProductProductTypeRate]");
            // Select.Columns.Add("[FromLoanProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[FromLoanProductProductTypeAccountNumber]");
            // Select.Columns.Add("[FromLoanProductProductTypePrintLabel]");
            // Select.Columns.Add("[FromLoanProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[FromLoanProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[FromLoanProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[FromLoanProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[FromLoanProductProductTypeIsActive]");
            // Select.Columns.Add("[FromLoanProductAmount]");
            // Select.Columns.Add("[FromLoanProductNotes]");
            // Select.Columns.Add("[FromLoanLoanDecisionId]");
            // Select.Columns.Add("[FromLoanLoanDecisionNumber]");
            // Select.Columns.Add("[FromLoanLoanDecisionYear]");
            // Select.Columns.Add("[FromLoanLoanDecisionDate]");
            // Select.Columns.Add("[FromLoanLoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[FromLoanLoanDecisionCersNumber]");
            // Select.Columns.Add("[FromLoanLoanDecisionCersDate]");
            // Select.Columns.Add("[FromLoanLoanDecisionNotes]");
            // Select.Columns.Add("[FromLoanLoanDecisionLoanDecisionTypeId]");
            // Select.Columns.Add("[FromLoanLoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[FromLoanLoanDecisionPaymentNumber]");
            // Select.Columns.Add("[FromLoanLoanDecisionPaymentDate]");
            // Select.Columns.Add("[FromLoanLoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[FromLoanLoanDecisionReason]");
            // Select.Columns.Add("[FromLoanLoanDecisionAdditionalClause]");
            // Select.Columns.Add("[FromLoanLoanDecisionAdditionalIntroduction]");
            Select.Columns.Add("[FromLoanLoanType]");
            // Select.Columns.Add("[FromLoanLoanGenerationStatusId]");
            // Select.Columns.Add("[FromLoanLoanGenerationStatusName]");
            // Select.Columns.Add("[FromLoanLoanStatusId]");
            // Select.Columns.Add("[FromLoanLoanStatusName]");
            FromClause = "[dbo].[LoanChangeVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> LoanProductEmployeeId { get; set; }
		public string LoanProductEmployeeFullNameContains { get; set; }
		public Nullable<short> LoanLoanType { get; set; }
		public Nullable<int> FromLoanProductEmployeeId { get; set; }
		public string FromLoanProductEmployeeFullNameContains { get; set; }
		public Nullable<short> FromLoanLoanType { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add LoanProductEmployeeId criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@LoanProductEmployeeId", LoanProductEmployeeId));
			Criteria.Add(criterion);

			// Add LoanProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@LoanProductEmployeeFullNameContains", LoanProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add LoanLoanType criterion
			criterion = new SimpleCriterion("[LoanLoanType]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanLoanType", LoanLoanType));
			Criteria.Add(criterion);

			// Add FromLoanProductEmployeeId criterion
			criterion = new SimpleCriterion("[FromLoanProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@FromLoanProductEmployeeId", FromLoanProductEmployeeId));
			Criteria.Add(criterion);

			// Add FromLoanProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[FromLoanProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@FromLoanProductEmployeeFullNameContains", FromLoanProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add FromLoanLoanType criterion
			criterion = new SimpleCriterion("[FromLoanLoanType]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@FromLoanLoanType", FromLoanLoanType));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region LoanDecisionVwFilter class definition
	/// <summary>
    /// Filter class for LoanDecisionVw
	/// </summary>
    [MetadataType(typeof(LoanDecisionVwFilterMetaData))]
	public partial class LoanDecisionVwFilter : Query
	{
        #region Constructors
        public LoanDecisionVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Number]");
            // Select.Columns.Add("[Year]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[DeductionStartDate]");
            // Select.Columns.Add("[CersNumber]");
            // Select.Columns.Add("[CersDate]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[LoanDecisionTypeId]");
            Select.Columns.Add("[LoanDecisionTypeName]");
            // Select.Columns.Add("[PaymentNumber]");
            // Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[IsPaidFromSalary]");
            Select.Columns.Add("[Reason]");
            // Select.Columns.Add("[AdditionalClause]");
            // Select.Columns.Add("[AdditionalIntroduction]");
            FromClause = "[dbo].[LoanDecisionVw]";
        }
        #endregion

        #region Public properties

		public Nullable<short> Number { get; set; }
		public Nullable<short> Year { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<byte> LoanDecisionTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add Year criterion
			criterion = new SimpleCriterion("[Year]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Year", Year));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add LoanDecisionTypeId criterion
			criterion = new SimpleCriterion("[LoanDecisionTypeId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@LoanDecisionTypeId", LoanDecisionTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region LoanRequestVwFilter class definition
	/// <summary>
    /// Filter class for LoanRequestVw
	/// </summary>
    [MetadataType(typeof(LoanRequestVwFilterMetaData))]
	public partial class LoanRequestVwFilter : Query
	{
        #region Constructors
        public LoanRequestVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[RequestProductId]");
            Select.Columns.Add("[RequestProductEmployeeId]");
            // Select.Columns.Add("[RequestProductEmployeeFirstName]");
            // Select.Columns.Add("[RequestProductEmployeeLastName]");
            Select.Columns.Add("[RequestProductEmployeeFullName]");
            // Select.Columns.Add("[RequestProductEmployeeFatherName]");
            // Select.Columns.Add("[RequestProductEmployeeFullName3]");
            // Select.Columns.Add("[RequestProductEmployeeMotherName]");
            // Select.Columns.Add("[RequestProductEmployeeBirthDate]");
            // Select.Columns.Add("[RequestProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[RequestProductEmployeeCersStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeCfStartDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveDate]");
            // Select.Columns.Add("[RequestProductEmployeeLeaveReason]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[RequestProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[RequestProductEmployeeNotes]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryId]");
            // Select.Columns.Add("[RequestProductEmployeeCategoryName]");
            // Select.Columns.Add("[RequestProductProductTypeId]");
            Select.Columns.Add("[RequestProductProductTypeName]");
            // Select.Columns.Add("[RequestProductProductTypeRate]");
            // Select.Columns.Add("[RequestProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[RequestProductProductTypeAccountNumber]");
            // Select.Columns.Add("[RequestProductProductTypePrintLabel]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[RequestProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[RequestProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[RequestProductProductTypeIsActive]");
            // Select.Columns.Add("[RequestProductAmount]");
            // Select.Columns.Add("[RequestProductNotes]");
            Select.Columns.Add("[RequestDate]");
            Select.Columns.Add("[RequestAmount]");
            // Select.Columns.Add("[RequestAttachment]");
            // Select.Columns.Add("[RequestCost]");
            // Select.Columns.Add("[RequestRequestStatusId]");
            Select.Columns.Add("[RequestRequestStatusName]");
            // Select.Columns.Add("[RequestBypassStatusId]");
            // Select.Columns.Add("[RequestBypassStatusName]");
            // Select.Columns.Add("[RequestNotes]");
            // Select.Columns.Add("[NetIncome]");
            // Select.Columns.Add("[TotalDeduction]");
            FromClause = "[dbo].[LoanRequestVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> RequestProductEmployeeId { get; set; }
		public string RequestProductEmployeeFullNameContains { get; set; }
		public Nullable<short> RequestProductProductTypeId { get; set; }
		public Nullable<DateTime> MinRequestDate { get; set; }
		public Nullable<DateTime> MaxRequestDate { get; set; }
		public Nullable<byte> RequestRequestStatusId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add RequestProductEmployeeId criterion
			criterion = new SimpleCriterion("[RequestProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@RequestProductEmployeeId", RequestProductEmployeeId));
			Criteria.Add(criterion);

			// Add RequestProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[RequestProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@RequestProductEmployeeFullNameContains", RequestProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add RequestProductProductTypeId criterion
			criterion = new SimpleCriterion("[RequestProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@RequestProductProductTypeId", RequestProductProductTypeId));
			Criteria.Add(criterion);

			// Add RequestDateDateBetween criterion
			criterion = new DateBetweenCriterion("[RequestDate]", SqlDbType.Date, new Parameter("@MinRequestDate", MinRequestDate), new Parameter("@MaxRequestDate", MaxRequestDate));
			Criteria.Add(criterion);

			// Add RequestRequestStatusId criterion
			criterion = new SimpleCriterion("[RequestRequestStatusId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@RequestRequestStatusId", RequestRequestStatusId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region LoanTypeVwFilter class definition
	/// <summary>
    /// Filter class for LoanTypeVw
	/// </summary>
    [MetadataType(typeof(LoanTypeVwFilterMetaData))]
	public partial class LoanTypeVwFilter : Query
	{
        #region Constructors
        public LoanTypeVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[ProductTypeId]");
            Select.Columns.Add("[ProductTypeName]");
            Select.Columns.Add("[ProductTypeRate]");
            Select.Columns.Add("[ProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductTypePrintLabel]");
            // Select.Columns.Add("[ProductTypeProfitStrategyId]");
            Select.Columns.Add("[ProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductTypePaymentGroupId]");
            Select.Columns.Add("[ProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductTypeIsActive]");
            FromClause = "[dbo].[LoanTypeVw]";
        }
        #endregion

        #region Public properties

		public string ProductTypeNameContains { get; set; }
		public Nullable<byte> ProductTypeProfitStrategyId { get; set; }
		public Nullable<byte> ProductTypePaymentGroupId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add ProductTypeNameContains criterion
			criterion = new SimpleCriterion("[ProductTypeName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ProductTypeNameContains", ProductTypeNameContains));
			Criteria.Add(criterion);

			// Add ProductTypeProfitStrategyId criterion
			criterion = new SimpleCriterion("[ProductTypeProfitStrategyId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@ProductTypeProfitStrategyId", ProductTypeProfitStrategyId));
			Criteria.Add(criterion);

			// Add ProductTypePaymentGroupId criterion
			criterion = new SimpleCriterion("[ProductTypePaymentGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@ProductTypePaymentGroupId", ProductTypePaymentGroupId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region LoanVwFilter class definition
	/// <summary>
    /// Filter class for LoanVw
	/// </summary>
    [MetadataType(typeof(LoanVwFilterMetaData))]
	public partial class LoanVwFilter : Query
	{
        #region Constructors
        public LoanVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[ProductId]");
            Select.Columns.Add("[ProductEmployeeId]");
            // Select.Columns.Add("[ProductEmployeeFirstName]");
            // Select.Columns.Add("[ProductEmployeeLastName]");
            Select.Columns.Add("[ProductEmployeeFullName]");
            // Select.Columns.Add("[ProductEmployeeFatherName]");
            // Select.Columns.Add("[ProductEmployeeFullName3]");
            // Select.Columns.Add("[ProductEmployeeMotherName]");
            // Select.Columns.Add("[ProductEmployeeBirthDate]");
            // Select.Columns.Add("[ProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[ProductEmployeeCersStartDate]");
            // Select.Columns.Add("[ProductEmployeeCfStartDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveReason]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[ProductEmployeeDepartmentId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeNotes]");
            // Select.Columns.Add("[ProductEmployeeCategoryId]");
            // Select.Columns.Add("[ProductEmployeeCategoryName]");
            // Select.Columns.Add("[ProductProductTypeId]");
            Select.Columns.Add("[ProductProductTypeName]");
            Select.Columns.Add("[ProductProductTypeRate]");
            // Select.Columns.Add("[ProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductProductTypePrintLabel]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductProductTypeIsActive]");
            Select.Columns.Add("[ProductAmount]");
            // Select.Columns.Add("[ProductNotes]");
            // Select.Columns.Add("[LoanDecisionId]");
            Select.Columns.Add("[LoanDecisionNumber]");
            // Select.Columns.Add("[LoanDecisionYear]");
            Select.Columns.Add("[LoanDecisionDate]");
            // Select.Columns.Add("[LoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[LoanDecisionCersNumber]");
            // Select.Columns.Add("[LoanDecisionCersDate]");
            // Select.Columns.Add("[LoanDecisionNotes]");
            // Select.Columns.Add("[LoanDecisionLoanDecisionTypeId]");
            // Select.Columns.Add("[LoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[LoanDecisionPaymentNumber]");
            // Select.Columns.Add("[LoanDecisionPaymentDate]");
            // Select.Columns.Add("[LoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[LoanDecisionReason]");
            // Select.Columns.Add("[LoanDecisionAdditionalClause]");
            // Select.Columns.Add("[LoanDecisionAdditionalIntroduction]");
            // Select.Columns.Add("[LoanType]");
            // Select.Columns.Add("[LoanGenerationStatusId]");
            // Select.Columns.Add("[LoanGenerationStatusName]");
            // Select.Columns.Add("[LoanStatusId]");
            Select.Columns.Add("[LoanStatusName]");
            FromClause = "[dbo].[LoanVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> ProductEmployeeId { get; set; }
		public string ProductEmployeeFullNameContains { get; set; }
		public Nullable<short> ProductProductTypeId { get; set; }
		public Nullable<short> LoanDecisionNumber { get; set; }
		public Nullable<DateTime> MinLoanDecisionDate { get; set; }
		public Nullable<DateTime> MaxLoanDecisionDate { get; set; }
		public Nullable<byte> LoanStatusId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add ProductEmployeeId criterion
			criterion = new SimpleCriterion("[ProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@ProductEmployeeId", ProductEmployeeId));
			Criteria.Add(criterion);

			// Add ProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[ProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ProductEmployeeFullNameContains", ProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add ProductProductTypeId criterion
			criterion = new SimpleCriterion("[ProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@ProductProductTypeId", ProductProductTypeId));
			Criteria.Add(criterion);

			// Add LoanDecisionNumber criterion
			criterion = new SimpleCriterion("[LoanDecisionNumber]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanDecisionNumber", LoanDecisionNumber));
			Criteria.Add(criterion);

			// Add LoanDecisionDateDateBetween criterion
			criterion = new DateBetweenCriterion("[LoanDecisionDate]", SqlDbType.Date, new Parameter("@MinLoanDecisionDate", MinLoanDecisionDate), new Parameter("@MaxLoanDecisionDate", MaxLoanDecisionDate));
			Criteria.Add(criterion);

			// Add LoanStatusId criterion
			criterion = new SimpleCriterion("[LoanStatusId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@LoanStatusId", LoanStatusId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region MissingInstallmentDecreaseVwFilter class definition
	/// <summary>
    /// Filter class for MissingInstallmentDecreaseVw
	/// </summary>
    [MetadataType(typeof(MissingInstallmentDecreaseVwFilterMetaData))]
	public partial class MissingInstallmentDecreaseVwFilter : Query
	{
        #region Constructors
        public MissingInstallmentDecreaseVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[SalaryAmount]");
            Select.Columns.Add("[TransferMonth]");
            Select.Columns.Add("[FinishedInstallmentsAmount]");
            Select.Columns.Add("[RemainingInstallmentsAmount]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[MissingInstallmentDecreaseVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinTransferMonth { get; set; }
		public Nullable<DateTime> MaxTransferMonth { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add TransferMonthDateBetween criterion
			criterion = new DateBetweenCriterion("[TransferMonth]", SqlDbType.Date, new Parameter("@MinTransferMonth", MinTransferMonth), new Parameter("@MaxTransferMonth", MaxTransferMonth));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region MonthlyBalanceVwFilter class definition
	/// <summary>
    /// Filter class for MonthlyBalanceVw
	/// </summary>
    [MetadataType(typeof(MonthlyBalanceVwFilterMetaData))]
	public partial class MonthlyBalanceVwFilter : Query
	{
        #region Constructors
        public MonthlyBalanceVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[PaymentGroupId]");
            Select.Columns.Add("[PaymentGroupName]");
            Select.Columns.Add("[Month]");
            Select.Columns.Add("[Opening]");
            Select.Columns.Add("[NormalLoans]");
            Select.Columns.Add("[IncomingLoans]");
            Select.Columns.Add("[Restitution]");
            Select.Columns.Add("[OutgoingLoans]");
            Select.Columns.Add("[SalaryPayment]");
            Select.Columns.Add("[CashPayment]");
            FromClause = "[dbo].[MonthlyBalanceVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<byte> PaymentGroupId { get; set; }
		public Nullable<DateTime> MinMonth { get; set; }
		public Nullable<DateTime> MaxMonth { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add PaymentGroupId criterion
			criterion = new SimpleCriterion("[PaymentGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentGroupId", PaymentGroupId));
			Criteria.Add(criterion);

			// Add MonthDateBetween criterion
			criterion = new DateBetweenCriterion("[Month]", SqlDbType.Date, new Parameter("@MinMonth", MinMonth), new Parameter("@MaxMonth", MaxMonth));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region OutgoingLoanVwFilter class definition
	/// <summary>
    /// Filter class for OutgoingLoanVw
	/// </summary>
    [MetadataType(typeof(OutgoingLoanVwFilterMetaData))]
	public partial class OutgoingLoanVwFilter : Query
	{
        #region Constructors
        public OutgoingLoanVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[LoanProductId]");
            Select.Columns.Add("[LoanProductEmployeeId]");
            // Select.Columns.Add("[LoanProductEmployeeFirstName]");
            // Select.Columns.Add("[LoanProductEmployeeLastName]");
            Select.Columns.Add("[LoanProductEmployeeFullName]");
            // Select.Columns.Add("[LoanProductEmployeeFatherName]");
            // Select.Columns.Add("[LoanProductEmployeeFullName3]");
            // Select.Columns.Add("[LoanProductEmployeeMotherName]");
            // Select.Columns.Add("[LoanProductEmployeeBirthDate]");
            // Select.Columns.Add("[LoanProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[LoanProductEmployeeCersStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeCfStartDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveDate]");
            // Select.Columns.Add("[LoanProductEmployeeLeaveReason]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[LoanProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[LoanProductEmployeeNotes]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryId]");
            // Select.Columns.Add("[LoanProductEmployeeCategoryName]");
            // Select.Columns.Add("[LoanProductProductTypeId]");
            Select.Columns.Add("[LoanProductProductTypeName]");
            // Select.Columns.Add("[LoanProductProductTypeRate]");
            // Select.Columns.Add("[LoanProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[LoanProductProductTypeAccountNumber]");
            // Select.Columns.Add("[LoanProductProductTypePrintLabel]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[LoanProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[LoanProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[LoanProductProductTypeIsActive]");
            Select.Columns.Add("[LoanProductAmount]");
            // Select.Columns.Add("[LoanProductNotes]");
            // Select.Columns.Add("[LoanLoanDecisionId]");
            // Select.Columns.Add("[LoanLoanDecisionNumber]");
            // Select.Columns.Add("[LoanLoanDecisionYear]");
            // Select.Columns.Add("[LoanLoanDecisionDate]");
            // Select.Columns.Add("[LoanLoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[LoanLoanDecisionCersNumber]");
            // Select.Columns.Add("[LoanLoanDecisionCersDate]");
            // Select.Columns.Add("[LoanLoanDecisionNotes]");
            // Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeId]");
            // Select.Columns.Add("[LoanLoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentNumber]");
            // Select.Columns.Add("[LoanLoanDecisionPaymentDate]");
            // Select.Columns.Add("[LoanLoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[LoanLoanDecisionReason]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalClause]");
            // Select.Columns.Add("[LoanLoanDecisionAdditionalIntroduction]");
            Select.Columns.Add("[LoanLoanType]");
            // Select.Columns.Add("[LoanLoanGenerationStatusId]");
            // Select.Columns.Add("[LoanLoanGenerationStatusName]");
            // Select.Columns.Add("[LoanLoanStatusId]");
            // Select.Columns.Add("[LoanLoanStatusName]");
            // Select.Columns.Add("[LoanDecisionId]");
            Select.Columns.Add("[LoanDecisionNumber]");
            // Select.Columns.Add("[LoanDecisionYear]");
            Select.Columns.Add("[LoanDecisionDate]");
            // Select.Columns.Add("[LoanDecisionDeductionStartDate]");
            // Select.Columns.Add("[LoanDecisionCersNumber]");
            // Select.Columns.Add("[LoanDecisionCersDate]");
            // Select.Columns.Add("[LoanDecisionNotes]");
            // Select.Columns.Add("[LoanDecisionLoanDecisionTypeId]");
            // Select.Columns.Add("[LoanDecisionLoanDecisionTypeName]");
            // Select.Columns.Add("[LoanDecisionPaymentNumber]");
            // Select.Columns.Add("[LoanDecisionPaymentDate]");
            // Select.Columns.Add("[LoanDecisionIsPaidFromSalary]");
            // Select.Columns.Add("[LoanDecisionReason]");
            // Select.Columns.Add("[LoanDecisionAdditionalClause]");
            // Select.Columns.Add("[LoanDecisionAdditionalIntroduction]");
            // Select.Columns.Add("[MainWorkPlaceId]");
            Select.Columns.Add("[MainWorkPlaceName]");
            Select.Columns.Add("[ApprovedAmount]");
            Select.Columns.Add("[NetAmount]");
            Select.Columns.Add("[ProfitAmount]");
            FromClause = "[dbo].[OutgoingLoanVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> LoanProductEmployeeId { get; set; }
		public string LoanProductEmployeeFullNameContains { get; set; }
		public Nullable<short> LoanProductProductTypeId { get; set; }
		public Nullable<int> MainWorkPlaceId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add LoanProductEmployeeId criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@LoanProductEmployeeId", LoanProductEmployeeId));
			Criteria.Add(criterion);

			// Add LoanProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[LoanProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@LoanProductEmployeeFullNameContains", LoanProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add LoanProductProductTypeId criterion
			criterion = new SimpleCriterion("[LoanProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanProductProductTypeId", LoanProductProductTypeId));
			Criteria.Add(criterion);

			// Add MainWorkPlaceId criterion
			criterion = new SimpleCriterion("[MainWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@MainWorkPlaceId", MainWorkPlaceId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region PaymentVwFilter class definition
	/// <summary>
    /// Filter class for PaymentVw
	/// </summary>
    [MetadataType(typeof(PaymentVwFilterMetaData))]
	public partial class PaymentVwFilter : Query
	{
        #region Constructors
        public PaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[Date]");
            // Select.Columns.Add("[PaymentGroupId]");
            Select.Columns.Add("[PaymentGroupName]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[PaymentStatusId]");
            Select.Columns.Add("[PaymentStatusName]");
            // Select.Columns.Add("[CollectOrderId]");
            // Select.Columns.Add("[CollectOrderNumber]");
            // Select.Columns.Add("[CollectOrderDate]");
            // Select.Columns.Add("[CollectOrderAccountingDocumentNumber]");
            // Select.Columns.Add("[CollectOrderAccountingDocumentDate]");
            FromClause = "[dbo].[PaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<byte> PaymentGroupId { get; set; }
		public Nullable<byte> PaymentStatusId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add PaymentGroupId criterion
			criterion = new SimpleCriterion("[PaymentGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentGroupId", PaymentGroupId));
			Criteria.Add(criterion);

			// Add PaymentStatusId criterion
			criterion = new SimpleCriterion("[PaymentStatusId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentStatusId", PaymentStatusId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region PayOrderVwFilter class definition
	/// <summary>
    /// Filter class for PayOrderVw
	/// </summary>
    [MetadataType(typeof(PayOrderVwFilterMetaData))]
	public partial class PayOrderVwFilter : Query
	{
        #region Constructors
        public PayOrderVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[Number]");
            Select.Columns.Add("[Date]");
            // Select.Columns.Add("[VoucherNumber]");
            // Select.Columns.Add("[VoucherDate]");
            // Select.Columns.Add("[PaymentNumber]");
            // Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[AccountingDocumentNumber]");
            // Select.Columns.Add("[AccountingDocumentDate]");
            // Select.Columns.Add("[PaymentGroupId]");
            Select.Columns.Add("[PaymentGroupName]");
            Select.Columns.Add("[PaidAmount]");
            Select.Columns.Add("[IsProfit]");
            Select.Columns.Add("[IsFixed]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[PayOrderVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<short> Number { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<byte> PaymentGroupId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add Number criterion
			criterion = new SimpleCriterion("[Number]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@Number", Number));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add PaymentGroupId criterion
			criterion = new SimpleCriterion("[PaymentGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentGroupId", PaymentGroupId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region ProductVwFilter class definition
	/// <summary>
    /// Filter class for ProductVw
	/// </summary>
    [MetadataType(typeof(ProductVwFilterMetaData))]
	public partial class ProductVwFilter : Query
	{
        #region Constructors
        public ProductVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[ProductTypeId]");
            Select.Columns.Add("[ProductTypeName]");
            // Select.Columns.Add("[ProductTypeRate]");
            // Select.Columns.Add("[ProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductTypePrintLabel]");
            // Select.Columns.Add("[ProductTypeProfitStrategyId]");
            // Select.Columns.Add("[ProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductTypePaymentGroupId]");
            // Select.Columns.Add("[ProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductTypeIsActive]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[ProductVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<short> ProductTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add ProductTypeId criterion
			criterion = new SimpleCriterion("[ProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@ProductTypeId", ProductTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region RefundableProductVwFilter class definition
	/// <summary>
    /// Filter class for RefundableProductVw
	/// </summary>
    [MetadataType(typeof(RefundableProductVwFilterMetaData))]
	public partial class RefundableProductVwFilter : Query
	{
        #region Constructors
        public RefundableProductVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[ProductId]");
            Select.Columns.Add("[ProductEmployeeId]");
            // Select.Columns.Add("[ProductEmployeeFirstName]");
            // Select.Columns.Add("[ProductEmployeeLastName]");
            Select.Columns.Add("[ProductEmployeeFullName]");
            // Select.Columns.Add("[ProductEmployeeFatherName]");
            // Select.Columns.Add("[ProductEmployeeFullName3]");
            // Select.Columns.Add("[ProductEmployeeMotherName]");
            // Select.Columns.Add("[ProductEmployeeBirthDate]");
            // Select.Columns.Add("[ProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[ProductEmployeeCersStartDate]");
            // Select.Columns.Add("[ProductEmployeeCfStartDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveReason]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[ProductEmployeeDepartmentId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeNotes]");
            // Select.Columns.Add("[ProductEmployeeCategoryId]");
            // Select.Columns.Add("[ProductEmployeeCategoryName]");
            // Select.Columns.Add("[ProductProductTypeId]");
            Select.Columns.Add("[ProductProductTypeName]");
            // Select.Columns.Add("[ProductProductTypeRate]");
            // Select.Columns.Add("[ProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductProductTypePrintLabel]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductProductTypeIsActive]");
            Select.Columns.Add("[ProductAmount]");
            // Select.Columns.Add("[ProductNotes]");
            // Select.Columns.Add("[PaymentPeriod]");
            Select.Columns.Add("[Installment]");
            // Select.Columns.Add("[NetAmount]");
            // Select.Columns.Add("[ProfitAmount]");
            // Select.Columns.Add("[SyrianPoundRounds]");
            FromClause = "[dbo].[RefundableProductVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> ProductEmployeeId { get; set; }
		public string ProductEmployeeFullNameContains { get; set; }
		public Nullable<short> ProductProductTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add ProductEmployeeId criterion
			criterion = new SimpleCriterion("[ProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@ProductEmployeeId", ProductEmployeeId));
			Criteria.Add(criterion);

			// Add ProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[ProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ProductEmployeeFullNameContains", ProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add ProductProductTypeId criterion
			criterion = new SimpleCriterion("[ProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@ProductProductTypeId", ProductProductTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region RequestVwFilter class definition
	/// <summary>
    /// Filter class for RequestVw
	/// </summary>
    [MetadataType(typeof(RequestVwFilterMetaData))]
	public partial class RequestVwFilter : Query
	{
        #region Constructors
        public RequestVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[ProductId]");
            Select.Columns.Add("[ProductEmployeeId]");
            // Select.Columns.Add("[ProductEmployeeFirstName]");
            // Select.Columns.Add("[ProductEmployeeLastName]");
            Select.Columns.Add("[ProductEmployeeFullName]");
            // Select.Columns.Add("[ProductEmployeeFatherName]");
            // Select.Columns.Add("[ProductEmployeeFullName3]");
            // Select.Columns.Add("[ProductEmployeeMotherName]");
            // Select.Columns.Add("[ProductEmployeeBirthDate]");
            // Select.Columns.Add("[ProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[ProductEmployeeCersStartDate]");
            // Select.Columns.Add("[ProductEmployeeCfStartDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveDate]");
            // Select.Columns.Add("[ProductEmployeeLeaveReason]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[ProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[ProductEmployeeDepartmentId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[ProductEmployeeNotes]");
            // Select.Columns.Add("[ProductEmployeeCategoryId]");
            // Select.Columns.Add("[ProductEmployeeCategoryName]");
            // Select.Columns.Add("[ProductProductTypeId]");
            Select.Columns.Add("[ProductProductTypeName]");
            // Select.Columns.Add("[ProductProductTypeRate]");
            // Select.Columns.Add("[ProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[ProductProductTypeAccountNumber]");
            // Select.Columns.Add("[ProductProductTypePrintLabel]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[ProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[ProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[ProductProductTypeIsActive]");
            // Select.Columns.Add("[ProductAmount]");
            // Select.Columns.Add("[ProductNotes]");
            Select.Columns.Add("[Date]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Attachment]");
            // Select.Columns.Add("[Cost]");
            // Select.Columns.Add("[RequestStatusId]");
            Select.Columns.Add("[RequestStatusName]");
            // Select.Columns.Add("[BypassStatusId]");
            // Select.Columns.Add("[BypassStatusName]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[RequestVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> ProductEmployeeId { get; set; }
		public string ProductEmployeeFullNameContains { get; set; }
		public Nullable<short> ProductProductTypeId { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<byte> RequestStatusId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add ProductEmployeeId criterion
			criterion = new SimpleCriterion("[ProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@ProductEmployeeId", ProductEmployeeId));
			Criteria.Add(criterion);

			// Add ProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[ProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ProductEmployeeFullNameContains", ProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add ProductProductTypeId criterion
			criterion = new SimpleCriterion("[ProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@ProductProductTypeId", ProductProductTypeId));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add RequestStatusId criterion
			criterion = new SimpleCriterion("[RequestStatusId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@RequestStatusId", RequestStatusId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region ResourceVwFilter class definition
	/// <summary>
    /// Filter class for ResourceVw
	/// </summary>
    [MetadataType(typeof(ResourceVwFilterMetaData))]
	public partial class ResourceVwFilter : Query
	{
        #region Constructors
        public ResourceVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Language]");
            Select.Columns.Add("[Module]");
            Select.Columns.Add("[Key]");
            Select.Columns.Add("[Value]");
            // Select.Columns.Add("[IsEditable]");
            FromClause = "[dbo].[ResourceVw]";
        }
        #endregion

        #region Public properties

		public string Language { get; set; }
		public string ModuleContains { get; set; }
		public string KeyContains { get; set; }
		public string ValueContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add Language criterion
			criterion = new SimpleCriterion("[Language]", SqlDbType.Char, OperatorType.Equals, new Parameter("@Language", Language));
			Criteria.Add(criterion);

			// Add ModuleContains criterion
			criterion = new SimpleCriterion("[Module]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ModuleContains", ModuleContains));
			Criteria.Add(criterion);

			// Add KeyContains criterion
			criterion = new SimpleCriterion("[Key]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@KeyContains", KeyContains));
			Criteria.Add(criterion);

			// Add ValueContains criterion
			criterion = new SimpleCriterion("[Value]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@ValueContains", ValueContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region SalaryPaymentVwFilter class definition
	/// <summary>
    /// Filter class for SalaryPaymentVw
	/// </summary>
    [MetadataType(typeof(SalaryPaymentVwFilterMetaData))]
	public partial class SalaryPaymentVwFilter : Query
	{
        #region Constructors
        public SalaryPaymentVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[PaymentId]");
            Select.Columns.Add("[PaymentEmployeeId]");
            // Select.Columns.Add("[PaymentEmployeeFirstName]");
            // Select.Columns.Add("[PaymentEmployeeLastName]");
            Select.Columns.Add("[PaymentEmployeeFullName]");
            // Select.Columns.Add("[PaymentEmployeeFatherName]");
            // Select.Columns.Add("[PaymentEmployeeFullName3]");
            // Select.Columns.Add("[PaymentEmployeeMotherName]");
            // Select.Columns.Add("[PaymentEmployeeBirthDate]");
            // Select.Columns.Add("[PaymentEmployeeExpectedEndDate]");
            // Select.Columns.Add("[PaymentEmployeeCersStartDate]");
            // Select.Columns.Add("[PaymentEmployeeCfStartDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveReason]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceId]");
            Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeNotes]");
            // Select.Columns.Add("[PaymentEmployeeCategoryId]");
            // Select.Columns.Add("[PaymentEmployeeCategoryName]");
            Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[PaymentPaymentGroupId]");
            Select.Columns.Add("[PaymentPaymentGroupName]");
            Select.Columns.Add("[PaymentAmount]");
            // Select.Columns.Add("[PaymentNotes]");
            // Select.Columns.Add("[PaymentPaymentStatusId]");
            Select.Columns.Add("[PaymentPaymentStatusName]");
            // Select.Columns.Add("[PaymentCollectOrderId]");
            // Select.Columns.Add("[PaymentCollectOrderNumber]");
            // Select.Columns.Add("[PaymentCollectOrderDate]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentNumber]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentDate]");
            // Select.Columns.Add("[DepartmentId]");
            // Select.Columns.Add("[DepartmentName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceName]");
            Select.Columns.Add("[Balance]");
            FromClause = "[dbo].[SalaryPaymentVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> PaymentEmployeeId { get; set; }
		public string PaymentEmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinPaymentDate { get; set; }
		public Nullable<DateTime> MaxPaymentDate { get; set; }
		public Nullable<byte> PaymentPaymentGroupId { get; set; }
		public Nullable<byte> PaymentPaymentStatusId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add PaymentEmployeeId criterion
			criterion = new SimpleCriterion("[PaymentEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@PaymentEmployeeId", PaymentEmployeeId));
			Criteria.Add(criterion);

			// Add PaymentEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[PaymentEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@PaymentEmployeeFullNameContains", PaymentEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add PaymentDateDateBetween criterion
			criterion = new DateBetweenCriterion("[PaymentDate]", SqlDbType.Date, new Parameter("@MinPaymentDate", MinPaymentDate), new Parameter("@MaxPaymentDate", MaxPaymentDate));
			Criteria.Add(criterion);

			// Add PaymentPaymentGroupId criterion
			criterion = new SimpleCriterion("[PaymentPaymentGroupId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentPaymentGroupId", PaymentPaymentGroupId));
			Criteria.Add(criterion);

			// Add PaymentPaymentStatusId criterion
			criterion = new SimpleCriterion("[PaymentPaymentStatusId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@PaymentPaymentStatusId", PaymentPaymentStatusId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region SalaryWorkPlaceVwFilter class definition
	/// <summary>
    /// Filter class for SalaryWorkPlaceVw
	/// </summary>
    [MetadataType(typeof(SalaryWorkPlaceVwFilterMetaData))]
	public partial class SalaryWorkPlaceVwFilter : Query
	{
        #region Constructors
        public SalaryWorkPlaceVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[Name]");
            // Select.Columns.Add("[MainWorkPlaceId]");
            Select.Columns.Add("[MainWorkPlaceName]");
            FromClause = "[dbo].[SalaryWorkPlaceVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> MainWorkPlaceId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add MainWorkPlaceId criterion
			criterion = new SimpleCriterion("[MainWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@MainWorkPlaceId", MainWorkPlaceId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region ServiceEndGrantRequestVwFilter class definition
	/// <summary>
    /// Filter class for ServiceEndGrantRequestVw
	/// </summary>
    [MetadataType(typeof(ServiceEndGrantRequestVwFilterMetaData))]
	public partial class ServiceEndGrantRequestVwFilter : Query
	{
        #region Constructors
        public ServiceEndGrantRequestVwFilter()
        {

            // Fill Select clause
            // Select.Columns.Add("[GrantRequestRequestProductId]");
            Select.Columns.Add("[GrantRequestRequestProductEmployeeId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeFirstName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeLastName]");
            Select.Columns.Add("[GrantRequestRequestProductEmployeeFullName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeFatherName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeFullName3]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeMotherName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeBirthDate]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeCersStartDate]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeCfStartDate]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeLeaveDate]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeLeaveReason]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeNotes]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeCategoryId]");
            // Select.Columns.Add("[GrantRequestRequestProductEmployeeCategoryName]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeId]");
            Select.Columns.Add("[GrantRequestRequestProductProductTypeName]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeRate]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeAccountNumber]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypePrintLabel]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[GrantRequestRequestProductProductTypeIsActive]");
            // Select.Columns.Add("[GrantRequestRequestProductAmount]");
            // Select.Columns.Add("[GrantRequestRequestProductNotes]");
            // Select.Columns.Add("[GrantRequestRequestDate]");
            // Select.Columns.Add("[GrantRequestRequestAmount]");
            // Select.Columns.Add("[GrantRequestRequestAttachment]");
            // Select.Columns.Add("[GrantRequestRequestCost]");
            // Select.Columns.Add("[GrantRequestRequestRequestStatusId]");
            // Select.Columns.Add("[GrantRequestRequestRequestStatusName]");
            // Select.Columns.Add("[GrantRequestRequestBypassStatusId]");
            // Select.Columns.Add("[GrantRequestRequestBypassStatusName]");
            // Select.Columns.Add("[GrantRequestRequestNotes]");
            // Select.Columns.Add("[GrantRequestGrantType]");
            // Select.Columns.Add("[GrantRequestDescription]");
            Select.Columns.Add("[GrantRequestAmount]");
            // Select.Columns.Add("[GrantRequestNotes]");
            // Select.Columns.Add("[GrantRequestEventDate]");
            // Select.Columns.Add("[GrantRequestIsFromOtherBranch]");
            // Select.Columns.Add("[AverageIncome]");
            // Select.Columns.Add("[GrantPercentage]");
            Select.Columns.Add("[ServiceInMonthes]");
            FromClause = "[dbo].[ServiceEndGrantRequestVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> GrantRequestRequestProductEmployeeId { get; set; }
		public string GrantRequestRequestProductEmployeeFullNameContains { get; set; }
		public Nullable<short> GrantRequestRequestProductProductTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add GrantRequestRequestProductEmployeeId criterion
			criterion = new SimpleCriterion("[GrantRequestRequestProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@GrantRequestRequestProductEmployeeId", GrantRequestRequestProductEmployeeId));
			Criteria.Add(criterion);

			// Add GrantRequestRequestProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[GrantRequestRequestProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@GrantRequestRequestProductEmployeeFullNameContains", GrantRequestRequestProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add GrantRequestRequestProductProductTypeId criterion
			criterion = new SimpleCriterion("[GrantRequestRequestProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@GrantRequestRequestProductProductTypeId", GrantRequestRequestProductProductTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region SettlementVwFilter class definition
	/// <summary>
    /// Filter class for SettlementVw
	/// </summary>
    [MetadataType(typeof(SettlementVwFilterMetaData))]
	public partial class SettlementVwFilter : Query
	{
        #region Constructors
        public SettlementVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[InstallmentId]");
            Select.Columns.Add("[InstallmentRefundableProductProductId]");
            Select.Columns.Add("[InstallmentRefundableProductProductEmployeeId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeFirstName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeLastName]");
            Select.Columns.Add("[InstallmentRefundableProductProductEmployeeFullName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeFatherName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeFullName3]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeMotherName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeBirthDate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeExpectedEndDate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeCersStartDate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeCfStartDate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeLeaveDate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeLeaveReason]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeNotes]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeCategoryId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductEmployeeCategoryName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeId]");
            Select.Columns.Add("[InstallmentRefundableProductProductProductTypeName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeRate]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeGuarantorsCount]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeAccountNumber]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypePrintLabel]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeProfitStrategyId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeProfitStrategyName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypePaymentGroupId]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypePaymentGroupName]");
            // Select.Columns.Add("[InstallmentRefundableProductProductProductTypeIsActive]");
            // Select.Columns.Add("[InstallmentRefundableProductProductAmount]");
            // Select.Columns.Add("[InstallmentRefundableProductProductNotes]");
            // Select.Columns.Add("[InstallmentRefundableProductPaymentPeriod]");
            // Select.Columns.Add("[InstallmentRefundableProductInstallment]");
            // Select.Columns.Add("[InstallmentRefundableProductNetAmount]");
            // Select.Columns.Add("[InstallmentRefundableProductProfitAmount]");
            // Select.Columns.Add("[InstallmentRefundableProductSyrianPoundRounds]");
            Select.Columns.Add("[InstallmentSubNumber]");
            Select.Columns.Add("[InstallmentDueDate]");
            Select.Columns.Add("[InstallmentDueCapital]");
            Select.Columns.Add("[InstallmentDueProfit]");
            // Select.Columns.Add("[InstallmentNotes]");
            // Select.Columns.Add("[PaymentId]");
            // Select.Columns.Add("[PaymentEmployeeId]");
            // Select.Columns.Add("[PaymentEmployeeFirstName]");
            // Select.Columns.Add("[PaymentEmployeeLastName]");
            // Select.Columns.Add("[PaymentEmployeeFullName]");
            // Select.Columns.Add("[PaymentEmployeeFatherName]");
            // Select.Columns.Add("[PaymentEmployeeFullName3]");
            // Select.Columns.Add("[PaymentEmployeeMotherName]");
            // Select.Columns.Add("[PaymentEmployeeBirthDate]");
            // Select.Columns.Add("[PaymentEmployeeExpectedEndDate]");
            // Select.Columns.Add("[PaymentEmployeeCersStartDate]");
            // Select.Columns.Add("[PaymentEmployeeCfStartDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveDate]");
            // Select.Columns.Add("[PaymentEmployeeLeaveReason]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[PaymentEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[PaymentEmployeeNotes]");
            // Select.Columns.Add("[PaymentEmployeeCategoryId]");
            // Select.Columns.Add("[PaymentEmployeeCategoryName]");
            Select.Columns.Add("[PaymentDate]");
            // Select.Columns.Add("[PaymentPaymentGroupId]");
            // Select.Columns.Add("[PaymentPaymentGroupName]");
            // Select.Columns.Add("[PaymentAmount]");
            // Select.Columns.Add("[PaymentNotes]");
            // Select.Columns.Add("[PaymentPaymentStatusId]");
            // Select.Columns.Add("[PaymentPaymentStatusName]");
            // Select.Columns.Add("[PaymentCollectOrderId]");
            // Select.Columns.Add("[PaymentCollectOrderNumber]");
            // Select.Columns.Add("[PaymentCollectOrderDate]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentNumber]");
            // Select.Columns.Add("[PaymentCollectOrderAccountingDocumentDate]");
            Select.Columns.Add("[Amount]");
            FromClause = "[dbo].[SettlementVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> InstallmentRefundableProductProductEmployeeId { get; set; }
		public string InstallmentRefundableProductProductEmployeeFullNameContains { get; set; }
		public Nullable<short> InstallmentRefundableProductProductProductTypeId { get; set; }
		public Nullable<short> MinInstallmentSubNumber { get; set; }
		public Nullable<short> MaxInstallmentSubNumber { get; set; }
		public Nullable<DateTime> MinPaymentDate { get; set; }
		public Nullable<DateTime> MaxPaymentDate { get; set; }
		public Nullable<decimal> MinPaymentAmount { get; set; }
		public Nullable<decimal> MaxPaymentAmount { get; set; }
		public Nullable<decimal> MinAmount { get; set; }
		public Nullable<decimal> MaxAmount { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add InstallmentRefundableProductProductEmployeeId criterion
			criterion = new SimpleCriterion("[InstallmentRefundableProductProductEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@InstallmentRefundableProductProductEmployeeId", InstallmentRefundableProductProductEmployeeId));
			Criteria.Add(criterion);

			// Add InstallmentRefundableProductProductEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[InstallmentRefundableProductProductEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@InstallmentRefundableProductProductEmployeeFullNameContains", InstallmentRefundableProductProductEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add InstallmentRefundableProductProductProductTypeId criterion
			criterion = new SimpleCriterion("[InstallmentRefundableProductProductProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@InstallmentRefundableProductProductProductTypeId", InstallmentRefundableProductProductProductTypeId));
			Criteria.Add(criterion);

			// Add InstallmentSubNumberBetween criterion
			criterion = new BetweenCriterion("[InstallmentSubNumber]", SqlDbType.SmallInt, new Parameter("@MinInstallmentSubNumber", MinInstallmentSubNumber), new Parameter("@MaxInstallmentSubNumber", MaxInstallmentSubNumber));
			Criteria.Add(criterion);

			// Add PaymentDateBetween criterion
			criterion = new BetweenCriterion("[PaymentDate]", SqlDbType.Date, new Parameter("@MinPaymentDate", MinPaymentDate), new Parameter("@MaxPaymentDate", MaxPaymentDate));
			Criteria.Add(criterion);

			// Add PaymentAmountBetween criterion
			criterion = new BetweenCriterion("[PaymentAmount]", SqlDbType.Money, new Parameter("@MinPaymentAmount", MinPaymentAmount), new Parameter("@MaxPaymentAmount", MaxPaymentAmount));
			Criteria.Add(criterion);

			// Add AmountBetween criterion
			criterion = new BetweenCriterion("[Amount]", SqlDbType.Money, new Parameter("@MinAmount", MinAmount), new Parameter("@MaxAmount", MaxAmount));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region SpecialCaseLoanVwFilter class definition
	/// <summary>
    /// Filter class for SpecialCaseLoanVw
	/// </summary>
    [MetadataType(typeof(SpecialCaseLoanVwFilterMetaData))]
	public partial class SpecialCaseLoanVwFilter : Query
	{
        #region Constructors
        public SpecialCaseLoanVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[Date]");
            // Select.Columns.Add("[LoanTypeProductTypeId]");
            Select.Columns.Add("[LoanTypeProductTypeName]");
            // Select.Columns.Add("[LoanTypeProductTypeRate]");
            // Select.Columns.Add("[LoanTypeProductTypeGuarantorsCount]");
            // Select.Columns.Add("[LoanTypeProductTypeAccountNumber]");
            // Select.Columns.Add("[LoanTypeProductTypePrintLabel]");
            // Select.Columns.Add("[LoanTypeProductTypeProfitStrategyId]");
            // Select.Columns.Add("[LoanTypeProductTypeProfitStrategyName]");
            // Select.Columns.Add("[LoanTypeProductTypePaymentGroupId]");
            // Select.Columns.Add("[LoanTypeProductTypePaymentGroupName]");
            // Select.Columns.Add("[LoanTypeProductTypeIsActive]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[SpecialCaseLoanVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinDate { get; set; }
		public Nullable<DateTime> MaxDate { get; set; }
		public Nullable<short> LoanTypeProductTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add DateDateBetween criterion
			criterion = new DateBetweenCriterion("[Date]", SqlDbType.Date, new Parameter("@MinDate", MinDate), new Parameter("@MaxDate", MaxDate));
			Criteria.Add(criterion);

			// Add LoanTypeProductTypeId criterion
			criterion = new SimpleCriterion("[LoanTypeProductTypeId]", SqlDbType.SmallInt, OperatorType.Equals, new Parameter("@LoanTypeProductTypeId", LoanTypeProductTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region SubscriptionVwFilter class definition
	/// <summary>
    /// Filter class for SubscriptionVw
	/// </summary>
    [MetadataType(typeof(SubscriptionVwFilterMetaData))]
	public partial class SubscriptionVwFilter : Query
	{
        #region Constructors
        public SubscriptionVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[Month]");
            // Select.Columns.Add("[DepartmentId]");
            // Select.Columns.Add("[DepartmentName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[DepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[SubscriptionTypeId]");
            Select.Columns.Add("[SubscriptionTypeName]");
            Select.Columns.Add("[Amount]");
            // Select.Columns.Add("[Notes]");
            Select.Columns.Add("[IsFixed]");
            FromClause = "[dbo].[SubscriptionVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinMonth { get; set; }
		public Nullable<DateTime> MaxMonth { get; set; }
		public Nullable<byte> SubscriptionTypeId { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add MonthDateBetween criterion
			criterion = new DateBetweenCriterion("[Month]", SqlDbType.Date, new Parameter("@MinMonth", MinMonth), new Parameter("@MaxMonth", MaxMonth));
			Criteria.Add(criterion);

			// Add SubscriptionTypeId criterion
			criterion = new SimpleCriterion("[SubscriptionTypeId]", SqlDbType.TinyInt, OperatorType.Equals, new Parameter("@SubscriptionTypeId", SubscriptionTypeId));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region TransitoryIncomingLoanVwFilter class definition
	/// <summary>
    /// Filter class for TransitoryIncomingLoanVw
	/// </summary>
    [MetadataType(typeof(TransitoryIncomingLoanVwFilterMetaData))]
	public partial class TransitoryIncomingLoanVwFilter : Query
	{
        #region Constructors
        public TransitoryIncomingLoanVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            // Select.Columns.Add("[MainWorkPlaceId]");
            Select.Columns.Add("[MainWorkPlaceName]");
            Select.Columns.Add("[ApprovedAmount]");
            Select.Columns.Add("[Installment]");
            // Select.Columns.Add("[Notes]");
            // Select.Columns.Add("[IsVerified]");
            FromClause = "[dbo].[TransitoryIncomingLoanVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		public Nullable<int> MainWorkPlaceId { get; set; }
		public Nullable<bool> IsVerified { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add MainWorkPlaceId criterion
			criterion = new SimpleCriterion("[MainWorkPlaceId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@MainWorkPlaceId", MainWorkPlaceId));
			Criteria.Add(criterion);

			// Add IsVerified criterion
			criterion = new SimpleCriterion("[IsVerified]", SqlDbType.Bit, OperatorType.Equals, new Parameter("@IsVerified", IsVerified));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion

	#region WarrantVwFilter class definition
	/// <summary>
    /// Filter class for WarrantVw
	/// </summary>
    [MetadataType(typeof(WarrantVwFilterMetaData))]
	public partial class WarrantVwFilter : Query
	{
        #region Constructors
        public WarrantVwFilter()
        {

            // Fill Select clause
            Select.Columns.Add("[Id]");
            // Select.Columns.Add("[DebtId]");
            Select.Columns.Add("[DebtEmployeeId]");
            // Select.Columns.Add("[DebtEmployeeFirstName]");
            // Select.Columns.Add("[DebtEmployeeLastName]");
            Select.Columns.Add("[DebtEmployeeFullName]");
            // Select.Columns.Add("[DebtEmployeeFatherName]");
            // Select.Columns.Add("[DebtEmployeeFullName3]");
            // Select.Columns.Add("[DebtEmployeeMotherName]");
            // Select.Columns.Add("[DebtEmployeeBirthDate]");
            // Select.Columns.Add("[DebtEmployeeExpectedEndDate]");
            // Select.Columns.Add("[DebtEmployeeCersStartDate]");
            // Select.Columns.Add("[DebtEmployeeCfStartDate]");
            // Select.Columns.Add("[DebtEmployeeLeaveDate]");
            // Select.Columns.Add("[DebtEmployeeLeaveReason]");
            // Select.Columns.Add("[DebtEmployeeEmployeeStatusId]");
            // Select.Columns.Add("[DebtEmployeeEmployeeStatusName]");
            // Select.Columns.Add("[DebtEmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[DebtEmployeeDepartmentId]");
            // Select.Columns.Add("[DebtEmployeeDepartmentName]");
            // Select.Columns.Add("[DebtEmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[DebtEmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[DebtEmployeeNotes]");
            // Select.Columns.Add("[DebtEmployeeCategoryId]");
            // Select.Columns.Add("[DebtEmployeeCategoryName]");
            Select.Columns.Add("[DebtAmount]");
            // Select.Columns.Add("[DebtIssuerId]");
            Select.Columns.Add("[DebtIssuerName]");
            // Select.Columns.Add("[DebtReferenceNumber]");
            Select.Columns.Add("[DebtDate]");
            Select.Columns.Add("[DebtPeriodInMonths]");
            // Select.Columns.Add("[DebtExceptionalPayment]");
            // Select.Columns.Add("[DebtIsActive]");
            // Select.Columns.Add("[DebtNotes]");
            // Select.Columns.Add("[DebtIssueDescription]");
            Select.Columns.Add("[DebtInstallment]");
            Select.Columns.Add("[EmployeeId]");
            // Select.Columns.Add("[EmployeeFirstName]");
            // Select.Columns.Add("[EmployeeLastName]");
            Select.Columns.Add("[EmployeeFullName]");
            // Select.Columns.Add("[EmployeeFatherName]");
            // Select.Columns.Add("[EmployeeFullName3]");
            // Select.Columns.Add("[EmployeeMotherName]");
            // Select.Columns.Add("[EmployeeBirthDate]");
            // Select.Columns.Add("[EmployeeExpectedEndDate]");
            // Select.Columns.Add("[EmployeeCersStartDate]");
            // Select.Columns.Add("[EmployeeCfStartDate]");
            // Select.Columns.Add("[EmployeeLeaveDate]");
            // Select.Columns.Add("[EmployeeLeaveReason]");
            // Select.Columns.Add("[EmployeeEmployeeStatusId]");
            // Select.Columns.Add("[EmployeeEmployeeStatusName]");
            // Select.Columns.Add("[EmployeeEmployeeStatusIsActive]");
            // Select.Columns.Add("[EmployeeDepartmentId]");
            // Select.Columns.Add("[EmployeeDepartmentName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceName]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId]");
            // Select.Columns.Add("[EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName]");
            // Select.Columns.Add("[EmployeeNotes]");
            // Select.Columns.Add("[EmployeeCategoryId]");
            // Select.Columns.Add("[EmployeeCategoryName]");
            Select.Columns.Add("[IsActive]");
            // Select.Columns.Add("[Notes]");
            FromClause = "[dbo].[WarrantVw]";
        }
        #endregion

        #region Public properties

		public Nullable<int> DebtEmployeeId { get; set; }
		public string DebtEmployeeFullNameContains { get; set; }
		public Nullable<DateTime> MinDebtDate { get; set; }
		public Nullable<DateTime> MaxDebtDate { get; set; }
		public Nullable<int> EmployeeId { get; set; }
		public string EmployeeFullNameContains { get; set; }
		#endregion

        #region Overrides
        protected override void ResetCriteria()
        {
            // Clear Criteria
            Criteria.Clear();

            CriterionBase criterion;
            // If you need to use parameters, please uncomment the following line
            // Parameter[] parameters;

			// Add DebtEmployeeId criterion
			criterion = new SimpleCriterion("[DebtEmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@DebtEmployeeId", DebtEmployeeId));
			Criteria.Add(criterion);

			// Add DebtEmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[DebtEmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@DebtEmployeeFullNameContains", DebtEmployeeFullNameContains));
			Criteria.Add(criterion);

			// Add DebtDateDateBetween criterion
			criterion = new DateBetweenCriterion("[DebtDate]", SqlDbType.Date, new Parameter("@MinDebtDate", MinDebtDate), new Parameter("@MaxDebtDate", MaxDebtDate));
			Criteria.Add(criterion);

			// Add EmployeeId criterion
			criterion = new SimpleCriterion("[EmployeeId]", SqlDbType.Int, OperatorType.Equals, new Parameter("@EmployeeId", EmployeeId));
			Criteria.Add(criterion);

			// Add EmployeeFullNameContains criterion
			criterion = new SimpleCriterion("[EmployeeFullName]", SqlDbType.VarChar, OperatorType.Contains, new Parameter("@EmployeeFullNameContains", EmployeeFullNameContains));
			Criteria.Add(criterion);

        }
        #endregion
    }
	#endregion
}
