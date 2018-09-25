using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Cf.Data
{
    #region AvailabilityCeilingVw class definition
	/// <summary>
	/// Selects all rows from the dbo.AvailabilityCeiling table.
	/// </summary>
    public partial class AvailabilityCeilingVw
	{
		#region Public properties
		/// <summary>
		/// معرف السقف
		/// </summary>
		public short Id {get; set;}
		
		/// <summary>
		/// معرف القاعدة
		/// </summary>
		public short AvailabilityId {get; set;}
		
		/// <summary>
		/// اسم القاعدة
		/// </summary>
		public string AvailabilityName {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة اللازم
		/// </summary>
		public byte AvailabilityMinSeniority {get; set;}
		
		/// <summary>
		/// الحد الأدنى من عدد الأشهر لإعادة الاستفادة
		/// </summary>
		public byte AvailabilityMinReusePeriod {get; set;}
		
		/// <summary>
		/// الحد الأدنى لسنوات الخدمة
		/// </summary>
		public short FromYear {get; set;}
		
		/// <summary>
		/// الحد الأقصى للمبلغ
		/// </summary>
		public decimal MaxAmount {get; set;}
		#endregion
	}
	#endregion

    #region AvailabilityVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Availability table.
	/// </summary>
    public partial class AvailabilityVw
	{
		#region Public properties
		/// <summary>
		/// معرف القاعدة
		/// </summary>
		public short Id {get; set;}
		
		/// <summary>
		/// اسم القاعدة
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة اللازم
		/// </summary>
		public byte MinSeniority {get; set;}
		
		/// <summary>
		/// الحد الأدنى من عدد الأشهر لإعادة الاستفادة
		/// </summary>
		public byte MinReusePeriod {get; set;}
		#endregion
	}
	#endregion

    #region BypassStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.BypassStatus table.
	/// </summary>
    public partial class BypassStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region CashPaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.CashPayment table.
	/// </summary>
    public partial class CashPaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int PaymentId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int PaymentEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string PaymentEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string PaymentEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string PaymentEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string PaymentEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string PaymentEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string PaymentEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string PaymentEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte PaymentEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string PaymentEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool PaymentEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int PaymentEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string PaymentEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte PaymentEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string PaymentEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime PaymentDate {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentPaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentPaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> PaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentNotes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentPaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentPaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> PaymentCollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> PaymentCollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> PaymentCollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderAccountingDocumentDate {get; set;}
		
		/// <summary>
		/// رقم البيان
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// رقم الإيصال
		/// </summary>
		public Nullable<int> ReceiptNumber {get; set;}
		
		/// <summary>
		/// تاريخ الإيصال
		/// </summary>
		public Nullable<DateTime> ReceiptDate {get; set;}
		
		/// <summary>
		/// مبلغ الغرامة
		/// </summary>
		public decimal FeeAmount {get; set;}
		#endregion
	}
	#endregion

    #region CategoryVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Category table.
	/// </summary>
    public partial class CategoryVw
	{
		#region Public properties
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region CollectOrderVw class definition
	/// <summary>
	/// Selects all rows from the dbo.CollectOrder table.
	/// </summary>
    public partial class CollectOrderVw
	{
		#region Public properties
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> Number {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> Date {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> AccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> AccountingDocumentDate {get; set;}
		#endregion
	}
	#endregion

    #region DebtVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Debt table.
	/// </summary>
    public partial class DebtVw
	{
		#region Public properties
		/// <summary>
		/// معرف المديونية
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// المبلغ الإجمالي للمديونية
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// معرف الجهة المصدرة للمديونية
		/// </summary>
		public byte IssuerId {get; set;}
		
		/// <summary>
		/// بيان الجهة المصدرة للمديونية
		/// </summary>
		public string IssuerName {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى الجهة المانحة
		/// </summary>
		public string ReferenceNumber {get; set;}
		
		/// <summary>
		/// تاريخ المديونية
		/// </summary>
		public Nullable<DateTime> Date {get; set;}
		
		/// <summary>
		/// مدة الدين
		/// </summary>
		public Nullable<byte> PeriodInMonths {get; set;}
		
		/// <summary>
		/// المبالغ المدفوعة استثنائياً
		/// </summary>
		public decimal ExceptionalPayment {get; set;}
		
		/// <summary>
		/// المديونية فعالة؟
		/// </summary>
		public bool IsActive {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// بيان الدين
		/// </summary>
		public string IssueDescription {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment {get; set;}
		#endregion
	}
	#endregion

    #region DepartmentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Department table.
	/// </summary>
    public partial class DepartmentVw
	{
		#region Public properties
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int SalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string SalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int SalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string SalaryWorkPlaceMainWorkPlaceName {get; set;}
		#endregion
	}
	#endregion

    #region DownPaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.DownPayment table.
	/// </summary>
    public partial class DownPaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int PaymentId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int PaymentEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string PaymentEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string PaymentEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string PaymentEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string PaymentEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string PaymentEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string PaymentEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string PaymentEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte PaymentEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string PaymentEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool PaymentEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int PaymentEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string PaymentEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte PaymentEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string PaymentEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime PaymentDate {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentPaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentPaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> PaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentNotes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentPaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentPaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> PaymentCollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> PaymentCollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> PaymentCollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderAccountingDocumentDate {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime RequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal RequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string RequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal RequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int RequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string RequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestNotes {get; set;}
		#endregion
	}
	#endregion

    #region EmployeeDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Employee table with related data of one to one related child tables.
	/// </summary>
    public partial class EmployeeDetailVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string FirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string FullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string FatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string FullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string MotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> BirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> CersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> CfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int DepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int DepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int DepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte CategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string CategoryName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Employee is MissingInstallmentDecrease
		/// </summary>
		public Nullable<bool> IsMissingInstallmentDecrease {get; set;}
		
		/// <summary>
		/// المبلغ المحول من الرواتب
		/// </summary>
		public Nullable<decimal> MissingInstallmentDecreaseSalaryAmount {get; set;}
		
		/// <summary>
		/// شهر التحويل
		/// </summary>
		public Nullable<DateTime> MissingInstallmentDecreaseTransferMonth {get; set;}
		
		/// <summary>
		/// قيمة الأقساط المنتهية
		/// </summary>
		public Nullable<decimal> MissingInstallmentDecreaseFinishedInstallmentsAmount {get; set;}
		
		/// <summary>
		/// قيمة الأقساط المتبقية
		/// </summary>
		public Nullable<decimal> MissingInstallmentDecreaseRemainingInstallmentsAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string MissingInstallmentDecreaseNotes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Employee is EmployeeSeniority
		/// </summary>
		public Nullable<bool> IsEmployeeSeniority {get; set;}
		
		/// <summary>
		/// مجمل الخدمة بالأيام
		/// </summary>
		public Nullable<short> EmployeeSeniorityServiceInDays {get; set;}
		
		/// <summary>
		/// Specifies Whether the Employee is Profile
		/// </summary>
		public Nullable<bool> IsProfile {get; set;}
		
		/// <summary>
		/// رقم هاتف العمل
		/// </summary>
		public string ProfileExtension {get; set;}
		
		/// <summary>
		/// رقم المنزل
		/// </summary>
		public string ProfileHomePhone {get; set;}
		
		/// <summary>
		/// رقم الهاتف الخلوي
		/// </summary>
		public string ProfileMobilePhone {get; set;}
		
		/// <summary>
		/// العنوان
		/// </summary>
		public string ProfileAddress {get; set;}
		
		/// <summary>
		/// Specifies Whether the Employee is TransitoryIncomingLoan
		/// </summary>
		public Nullable<bool> IsTransitoryIncomingLoan {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> TransitoryIncomingLoanMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string TransitoryIncomingLoanMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// السلفة الممنوحة
		/// </summary>
		public Nullable<decimal> TransitoryIncomingLoanApprovedAmount {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public Nullable<decimal> TransitoryIncomingLoanInstallment {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string TransitoryIncomingLoanNotes {get; set;}
		
		/// <summary>
		/// الحالة  non:0; verified:1; to be deleted:2
		/// </summary>
		public Nullable<bool> TransitoryIncomingLoanIsVerified {get; set;}
		#endregion
	}
	#endregion

    #region EmployeeRefundableProductRollupVw class definition
	/// <summary>
	/// Needs summary!
	/// </summary>
    public partial class EmployeeRefundableProductRollupVw
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> ProductId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> DueAmount {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> PaidAmount {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte IsGroupingByProduct {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte IsGroupingByEmployee {get; set;}
		#endregion
	}
	#endregion

    #region EmployeeSeniorityVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EmployeeSeniority table.
	/// </summary>
    public partial class EmployeeSeniorityVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// مجمل الخدمة بالأيام
		/// </summary>
		public short ServiceInDays {get; set;}
		#endregion
	}
	#endregion

    #region EmployeeStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EmployeeStatus table.
	/// </summary>
    public partial class EmployeeStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool IsActive {get; set;}
		#endregion
	}
	#endregion

    #region EmployeeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Employee table.
	/// </summary>
    public partial class EmployeeVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string FirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string FullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string FatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string FullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string MotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> BirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> CersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> CfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int DepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int DepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int DepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte CategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string CategoryName {get; set;}
		#endregion
	}
	#endregion

    #region EndWorkGrantBracketVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EndWorkGrantBracket table.
	/// </summary>
    public partial class EndWorkGrantBracketVw
	{
		#region Public properties
		/// <summary>
		/// من سنة
		/// </summary>
		public byte FromYear {get; set;}
		
		/// <summary>
		/// النسبة
		/// </summary>
		public decimal Percentage {get; set;}
		#endregion
	}
	#endregion

    #region ErrorDefinitionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ErrorDefinition table.
	/// </summary>
    public partial class ErrorDefinitionVw
	{
		#region Public properties
		/// <summary>
		/// ErrorDefinition identifier
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// Original exception message 
		/// </summary>
		public string Message {get; set;}
		
		/// <summary>
		/// Localized Message
		/// </summary>
		public string LocalizedMessage {get; set;}
		
		/// <summary>
		/// An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.
		/// </summary>
		public string LikeExpression {get; set;}
		#endregion
	}
	#endregion

    #region EventCategoryVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventCategory table.
	/// </summary>
    public partial class EventCategoryVw
	{
		#region Public properties
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// EventCategory Name
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region EventLogDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventLog table with related data of one to one related child tables.
	/// </summary>
    public partial class EventLogDetailVw
	{
		#region Public properties
		/// <summary>
		/// EventLog identifier
		/// </summary>
		public long Id {get; set;}
		
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int EventSourceId {get; set;}
		
		/// <summary>
		/// EventSource name
		/// </summary>
		public string EventSourceName {get; set;}
		
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int EventCategoryId {get; set;}
		
		/// <summary>
		/// EventCategory Name
		/// </summary>
		public string EventCategoryName {get; set;}
		
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int EventStatusId {get; set;}
		
		/// <summary>
		/// EventStatus name
		/// </summary>
		public string EventStatusName {get; set;}
		
		/// <summary>
		/// EventStatus icon
		/// </summary>
		public string EventStatusIcon {get; set;}
		
		/// <summary>
		/// EventLog XML formated parameters
		/// </summary>
		public string Parameters {get; set;}
		
		/// <summary>
		/// Date of the EventLog
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// User identifier
		/// </summary>
		public int User {get; set;}
		
		/// <summary>
		/// Specifies Whether the EventLog is EventLogError
		/// </summary>
		public Nullable<bool> IsEventLogError {get; set;}
		
		/// <summary>
		/// Error number
		/// </summary>
		public Nullable<int> EventLogErrorNumber {get; set;}
		
		/// <summary>
		/// Error descriptive message
		/// </summary>
		public string EventLogErrorMessage {get; set;}
		
		/// <summary>
		/// Full technical description about what is going wrong
		/// </summary>
		public string EventLogErrorStackTrace {get; set;}
		#endregion
	}
	#endregion

    #region EventLogErrorVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventLogError table.
	/// </summary>
    public partial class EventLogErrorVw
	{
		#region Public properties
		/// <summary>
		/// EventLog identifier
		/// </summary>
		public long EventLogId {get; set;}
		
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int EventLogEventSourceId {get; set;}
		
		/// <summary>
		/// EventSource name
		/// </summary>
		public string EventLogEventSourceName {get; set;}
		
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int EventLogEventCategoryId {get; set;}
		
		/// <summary>
		/// EventCategory Name
		/// </summary>
		public string EventLogEventCategoryName {get; set;}
		
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int EventLogEventStatusId {get; set;}
		
		/// <summary>
		/// EventStatus name
		/// </summary>
		public string EventLogEventStatusName {get; set;}
		
		/// <summary>
		/// EventStatus icon
		/// </summary>
		public string EventLogEventStatusIcon {get; set;}
		
		/// <summary>
		/// EventLog XML formated parameters
		/// </summary>
		public string EventLogParameters {get; set;}
		
		/// <summary>
		/// Date of the EventLog
		/// </summary>
		public DateTime EventLogDate {get; set;}
		
		/// <summary>
		/// User identifier
		/// </summary>
		public int EventLogUser {get; set;}
		
		/// <summary>
		/// Error number
		/// </summary>
		public int Number {get; set;}
		
		/// <summary>
		/// Error descriptive message
		/// </summary>
		public string Message {get; set;}
		
		/// <summary>
		/// Full technical description about what is going wrong
		/// </summary>
		public string StackTrace {get; set;}
		#endregion
	}
	#endregion

    #region EventLogVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventLog table.
	/// </summary>
    public partial class EventLogVw
	{
		#region Public properties
		/// <summary>
		/// EventLog identifier
		/// </summary>
		public long Id {get; set;}
		
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int EventSourceId {get; set;}
		
		/// <summary>
		/// EventSource name
		/// </summary>
		public string EventSourceName {get; set;}
		
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int EventCategoryId {get; set;}
		
		/// <summary>
		/// EventCategory Name
		/// </summary>
		public string EventCategoryName {get; set;}
		
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int EventStatusId {get; set;}
		
		/// <summary>
		/// EventStatus name
		/// </summary>
		public string EventStatusName {get; set;}
		
		/// <summary>
		/// EventStatus icon
		/// </summary>
		public string EventStatusIcon {get; set;}
		
		/// <summary>
		/// Date of the EventLog
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// User identifier
		/// </summary>
		public int User {get; set;}
		
		/// <summary>
		/// EventLog XML formated parameters
		/// </summary>
		public string Parameters {get; set;}
		#endregion
	}
	#endregion

    #region EventSourceVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventSource table.
	/// </summary>
    public partial class EventSourceVw
	{
		#region Public properties
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// EventSource name
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region EventStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.EventStatus table.
	/// </summary>
    public partial class EventStatusVw
	{
		#region Public properties
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// EventStatus name
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// EventStatus icon
		/// </summary>
		public string Icon {get; set;}
		#endregion
	}
	#endregion

    #region ExceptionalAmountTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ExceptionalAmountType table.
	/// </summary>
    public partial class ExceptionalAmountTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المبلغ الاستثنائي
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان نوع المبلغ الاستثنائي
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// دخل؟
		/// </summary>
		public bool IsIncome {get; set;}
		#endregion
	}
	#endregion

    #region ExceptionalAmountVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ExceptionalAmount table.
	/// </summary>
    public partial class ExceptionalAmountVw
	{
		#region Public properties
		/// <summary>
		/// معرف المبلغ الاستثنائي
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int LoanRequestRequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int LoanRequestRequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanRequestRequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanRequestRequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanRequestRequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanRequestRequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanRequestRequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanRequestRequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanRequestRequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanRequestRequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanRequestRequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanRequestRequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanRequestRequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanRequestRequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte LoanRequestRequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanRequestRequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool LoanRequestRequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int LoanRequestRequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanRequestRequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanRequestRequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte LoanRequestRequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanRequestRequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanRequestRequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanRequestRequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanRequestRequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanRequestRequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanRequestRequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanRequestRequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanRequestRequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanRequestRequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanRequestRequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanRequestRequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanRequestRequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal LoanRequestRequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanRequestRequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime LoanRequestRequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal LoanRequestRequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string LoanRequestRequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal LoanRequestRequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> LoanRequestRequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string LoanRequestRequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int LoanRequestRequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string LoanRequestRequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanRequestRequestNotes {get; set;}
		
		/// <summary>
		/// صافي الدخل
		/// </summary>
		public decimal LoanRequestNetIncome {get; set;}
		
		/// <summary>
		/// الحسميات
		/// </summary>
		public decimal LoanRequestTotalDeduction {get; set;}
		
		/// <summary>
		/// مسلسل فرعي
		/// </summary>
		public decimal SubNumber {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف نوع المبلغ الاستثنائي
		/// </summary>
		public byte ExceptionalAmountTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المبلغ الاستثنائي
		/// </summary>
		public string ExceptionalAmountTypeName {get; set;}
		
		/// <summary>
		/// دخل؟
		/// </summary>
		public bool ExceptionalAmountTypeIsIncome {get; set;}
		#endregion
	}
	#endregion

    #region ExternalGrantVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ExternalGrant table.
	/// </summary>
    public partial class ExternalGrantVw
	{
		#region Public properties
		/// <summary>
		/// معرف الإعانة
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public Nullable<DateTime> RequestDate {get; set;}
		
		/// <summary>
		/// معرف نوع الإعانة
		/// </summary>
		public byte GrantTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع الإعانة
		/// </summary>
		public string GrantTypeName {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public Nullable<decimal> GrantTypeAmount {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantTypeGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantTypeGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string Description {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate {get; set;}
		
		/// <summary>
		/// رقم قرار الدفع
		/// </summary>
		public Nullable<short> PaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ قرار الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region GrantDecisionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantDecision table.
	/// </summary>
    public partial class GrantDecisionVw
	{
		#region Public properties
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short Year {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string PaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> PaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string TableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> TableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string BaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> BaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string AdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string AdditionalIntroduction {get; set;}
		#endregion
	}
	#endregion

    #region GrantDeductionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantDeduction table.
	/// </summary>
    public partial class GrantDeductionVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int GrantProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int GrantProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string GrantProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string GrantProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string GrantProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string GrantProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string GrantProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string GrantProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string GrantProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte GrantProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string GrantProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool GrantProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int GrantProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string GrantProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int GrantProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string GrantProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte GrantProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string GrantProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short GrantProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string GrantProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> GrantProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GrantProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string GrantProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string GrantProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> GrantProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string GrantProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> GrantProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string GrantProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> GrantProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal GrantProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int GrantGrantDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short GrantGrantDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short GrantGrantDecisionYear {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantGrantDecisionGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantGrantDecisionGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime GrantGrantDecisionDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string GrantGrantDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionCersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string GrantGrantDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantGrantDecisionNotes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string GrantGrantDecisionTableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionTableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string GrantGrantDecisionBaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionBaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal GrantAmount {get; set;}
		
		/// <summary>
		/// مبلغ الحسم
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// بيان الحسم
		/// </summary>
		public string Description {get; set;}
		#endregion
	}
	#endregion

    #region GrantDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Grant table with related data of one to one related child tables.
	/// </summary>
    public partial class GrantDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int GrantDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short GrantDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short GrantDecisionYear {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantDecisionGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantDecisionGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime GrantDecisionDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string GrantDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> GrantDecisionCersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string GrantDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> GrantDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantDecisionNotes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string GrantDecisionTableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> GrantDecisionTableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string GrantDecisionBaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> GrantDecisionBaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string GrantDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string GrantDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// Specifies Whether the Grant is GrantDeduction
		/// </summary>
		public Nullable<bool> IsGrantDeduction {get; set;}
		
		/// <summary>
		/// مبلغ الحسم
		/// </summary>
		public Nullable<decimal> GrantDeductionAmount {get; set;}
		
		/// <summary>
		/// بيان الحسم
		/// </summary>
		public string GrantDeductionDescription {get; set;}
		#endregion
	}
	#endregion

    #region GrantPaymentOrderVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantPaymentOrder table.
	/// </summary>
    public partial class GrantPaymentOrderVw
	{
		#region Public properties
		/// <summary>
		/// معرف أمر دفع الإعانات
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم مستند الدفع
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// عام مستند الدفع
		/// </summary>
		public short Year {get; set;}
		
		/// <summary>
		/// تاريخ مستند الدفع
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region GrantPaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantPayment table.
	/// </summary>
    public partial class GrantPaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف دفع الإعانة
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف أمر دفع الإعانات
		/// </summary>
		public int GrantPaymentOrderId {get; set;}
		
		/// <summary>
		/// رقم مستند الدفع
		/// </summary>
		public short GrantPaymentOrderNumber {get; set;}
		
		/// <summary>
		/// عام مستند الدفع
		/// </summary>
		public short GrantPaymentOrderYear {get; set;}
		
		/// <summary>
		/// تاريخ مستند الدفع
		/// </summary>
		public DateTime GrantPaymentOrderDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantPaymentOrderNotes {get; set;}
		
		/// <summary>
		/// الرقم المتسلسل للدفعة
		/// </summary>
		public byte SubNumber {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int GrantProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int GrantProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string GrantProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string GrantProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string GrantProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string GrantProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string GrantProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string GrantProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> GrantProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string GrantProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte GrantProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string GrantProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool GrantProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int GrantProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string GrantProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int GrantProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string GrantProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte GrantProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string GrantProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short GrantProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string GrantProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> GrantProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GrantProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string GrantProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string GrantProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> GrantProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string GrantProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> GrantProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string GrantProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> GrantProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal GrantProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int GrantGrantDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short GrantGrantDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short GrantGrantDecisionYear {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantGrantDecisionGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantGrantDecisionGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime GrantGrantDecisionDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string GrantGrantDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionCersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string GrantGrantDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantGrantDecisionNotes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string GrantGrantDecisionTableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionTableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string GrantGrantDecisionBaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionBaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal GrantAmount {get; set;}
		
		/// <summary>
		/// المبلغ المدفوع
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region GrantRequestDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantRequest table with related data of one to one related child tables.
	/// </summary>
    public partial class GrantRequestDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime RequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal RequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string RequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal RequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int RequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string RequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestNotes {get; set;}
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public byte GrantType {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string Description {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public DateTime EventDate {get; set;}
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public bool IsFromOtherBranch {get; set;}
		
		/// <summary>
		/// Specifies Whether the GrantRequest is ServiceEndGrantRequest
		/// </summary>
		public Nullable<bool> IsServiceEndGrantRequest {get; set;}
		
		/// <summary>
		/// متوسط الدخل الشهري
		/// </summary>
		public Nullable<decimal> ServiceEndGrantRequestAverageIncome {get; set;}
		
		/// <summary>
		/// نسبة الصرف
		/// </summary>
		public Nullable<decimal> ServiceEndGrantRequestGrantPercentage {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة
		/// </summary>
		public Nullable<short> ServiceEndGrantRequestServiceInMonthes {get; set;}
		#endregion
	}
	#endregion

    #region GrantRequestVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantRequest table.
	/// </summary>
    public partial class GrantRequestVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime RequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal RequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string RequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal RequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int RequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string RequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestNotes {get; set;}
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public byte GrantType {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string Description {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public DateTime EventDate {get; set;}
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public bool IsFromOtherBranch {get; set;}
		#endregion
	}
	#endregion

    #region GrantTypeGroupVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantTypeGroup table.
	/// </summary>
    public partial class GrantTypeGroupVw
	{
		#region Public properties
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region GrantTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GrantType table.
	/// </summary>
    public partial class GrantTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع الإعانة
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان نوع الإعانة
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public Nullable<decimal> Amount {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantTypeGroupName {get; set;}
		#endregion
	}
	#endregion

    #region GrantVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Grant table.
	/// </summary>
    public partial class GrantVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int GrantDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short GrantDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short GrantDecisionYear {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantDecisionGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantDecisionGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime GrantDecisionDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string GrantDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> GrantDecisionCersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string GrantDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> GrantDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantDecisionNotes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string GrantDecisionTableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> GrantDecisionTableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string GrantDecisionBaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> GrantDecisionBaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string GrantDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string GrantDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount {get; set;}
		#endregion
	}
	#endregion

    #region GuarantorDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Guarantor table with related data of one to one related child tables.
	/// </summary>
    public partial class GuarantorDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف الكفيل
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RefundableProductProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RefundableProductProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RefundableProductProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RefundableProductProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RefundableProductProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RefundableProductProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RefundableProductProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RefundableProductProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RefundableProductProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RefundableProductProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RefundableProductProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RefundableProductProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RefundableProductProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RefundableProductProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RefundableProductProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RefundableProductProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RefundableProductProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RefundableProductProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RefundableProductProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RefundableProductProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RefundableProductProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RefundableProductProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RefundableProductProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RefundableProductProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short RefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal RefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal RefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal RefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal RefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// مسلسل فرعي للكفيل
		/// </summary>
		public byte SubNumber {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف حالة الكفيل
		/// </summary>
		public byte GuarantorStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة الكفيل
		/// </summary>
		public string GuarantorStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Guarantor is GuarantorStatement
		/// </summary>
		public Nullable<bool> IsGuarantorStatement {get; set;}
		
		/// <summary>
		/// الدخل المقطوع
		/// </summary>
		public Nullable<decimal> GuarantorStatementGrossSalary {get; set;}
		
		/// <summary>
		/// الاستقطاعات
		/// </summary>
		public Nullable<decimal> GuarantorStatementDeductionsAmount {get; set;}
		
		/// <summary>
		/// الراتب المقبوض
		/// </summary>
		public Nullable<decimal> GuarantorStatementNetSalary {get; set;}
		
		/// <summary>
		/// المستحقات الطارئة
		/// </summary>
		public Nullable<decimal> GuarantorStatementExceptionalIncome {get; set;}
		#endregion
	}
	#endregion

    #region GuarantorStatementVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GuarantorStatement table.
	/// </summary>
    public partial class GuarantorStatementVw
	{
		#region Public properties
		/// <summary>
		/// معرف الكفيل
		/// </summary>
		public int GuarantorId {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int GuarantorRefundableProductProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int GuarantorRefundableProductProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> GuarantorRefundableProductProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> GuarantorRefundableProductProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> GuarantorRefundableProductProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> GuarantorRefundableProductProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> GuarantorRefundableProductProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte GuarantorRefundableProductProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool GuarantorRefundableProductProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int GuarantorRefundableProductProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte GuarantorRefundableProductProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string GuarantorRefundableProductProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short GuarantorRefundableProductProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string GuarantorRefundableProductProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> GuarantorRefundableProductProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GuarantorRefundableProductProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string GuarantorRefundableProductProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string GuarantorRefundableProductProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> GuarantorRefundableProductProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string GuarantorRefundableProductProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> GuarantorRefundableProductProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string GuarantorRefundableProductProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> GuarantorRefundableProductProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal GuarantorRefundableProductProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GuarantorRefundableProductProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short GuarantorRefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal GuarantorRefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal GuarantorRefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal GuarantorRefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal GuarantorRefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// مسلسل فرعي للكفيل
		/// </summary>
		public byte GuarantorSubNumber {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int GuarantorEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string GuarantorEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string GuarantorEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string GuarantorEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string GuarantorEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string GuarantorEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string GuarantorEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> GuarantorEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> GuarantorEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> GuarantorEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> GuarantorEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> GuarantorEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string GuarantorEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte GuarantorEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string GuarantorEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool GuarantorEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int GuarantorEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string GuarantorEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int GuarantorEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string GuarantorEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GuarantorEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte GuarantorEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string GuarantorEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف حالة الكفيل
		/// </summary>
		public byte GuarantorGuarantorStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة الكفيل
		/// </summary>
		public string GuarantorGuarantorStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GuarantorNotes {get; set;}
		
		/// <summary>
		/// الدخل المقطوع
		/// </summary>
		public Nullable<decimal> GrossSalary {get; set;}
		
		/// <summary>
		/// الاستقطاعات
		/// </summary>
		public Nullable<decimal> DeductionsAmount {get; set;}
		
		/// <summary>
		/// الراتب المقبوض
		/// </summary>
		public Nullable<decimal> NetSalary {get; set;}
		
		/// <summary>
		/// المستحقات الطارئة
		/// </summary>
		public Nullable<decimal> ExceptionalIncome {get; set;}
		#endregion
	}
	#endregion

    #region GuarantorStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.GuarantorStatus table.
	/// </summary>
    public partial class GuarantorStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف حالة الكفيل
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان حالة الكفيل
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region GuarantorVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Guarantor table.
	/// </summary>
    public partial class GuarantorVw
	{
		#region Public properties
		/// <summary>
		/// معرف الكفيل
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RefundableProductProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RefundableProductProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RefundableProductProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RefundableProductProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RefundableProductProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RefundableProductProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RefundableProductProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RefundableProductProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RefundableProductProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RefundableProductProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RefundableProductProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RefundableProductProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RefundableProductProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RefundableProductProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RefundableProductProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RefundableProductProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RefundableProductProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RefundableProductProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RefundableProductProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RefundableProductProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RefundableProductProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RefundableProductProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RefundableProductProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RefundableProductProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short RefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal RefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal RefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal RefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal RefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// مسلسل فرعي للكفيل
		/// </summary>
		public byte SubNumber {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف حالة الكفيل
		/// </summary>
		public byte GuarantorStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة الكفيل
		/// </summary>
		public string GuarantorStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.HealthLoanDecisionFirstPayment table.
	/// </summary>
    public partial class HealthLoanDecisionFirstPaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف السلفة العلاجية المسبقة
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ الدفعة
		/// </summary>
		public DateTime PaymentDate {get; set;}
		
		/// <summary>
		/// مبلغ الدفعة
		/// </summary>
		public Nullable<decimal> PaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات الدفعة
		/// </summary>
		public string PaymentNotes {get; set;}
		
		/// <summary>
		/// تاريخ الفاتورة
		/// </summary>
		public Nullable<DateTime> InvoiceDate {get; set;}
		
		/// <summary>
		/// مبلغ الفاتورة
		/// </summary>
		public Nullable<decimal> InvoiceAmount {get; set;}
		
		/// <summary>
		/// ملاحظات الفاتورة
		/// </summary>
		public string InvoiceNotes {get; set;}
		
		/// <summary>
		/// تاريخ قبض مبلغ التأمين الصحي
		/// </summary>
		public Nullable<DateTime> InsuranceDate {get; set;}
		
		/// <summary>
		/// مبلغ التأمين الصحي
		/// </summary>
		public Nullable<decimal> InsuranceAmount {get; set;}
		
		/// <summary>
		/// معرف طريقة القبض
		/// </summary>
		public Nullable<byte> InsuranceTypeId {get; set;}
		
		/// <summary>
		/// بيان طريقة قبض التأمين
		/// </summary>
		public string InsuranceTypeName {get; set;}
		
		/// <summary>
		/// ملاحظات التأمين الصحي
		/// </summary>
		public string InsuranceNotes {get; set;}
		
		/// <summary>
		/// تاريخ قبض مبلغ اللجنة الطبية
		/// </summary>
		public Nullable<DateTime> BoardDate {get; set;}
		
		/// <summary>
		/// مبلغ اللجنة الطبية
		/// </summary>
		public Nullable<decimal> BoardAmount {get; set;}
		
		/// <summary>
		/// نقداً=1   تحويل=2        طريقة قبض اللجنة الطبية
		/// </summary>
		public Nullable<byte> BoardType {get; set;}
		
		/// <summary>
		/// ملاحظات اللجنة الطبية
		/// </summary>
		public string BoardNotes {get; set;}
		
		/// <summary>
		/// تاريخ قبض مبلغ السداد المباشر
		/// </summary>
		public Nullable<DateTime> DirectPaymentDate {get; set;}
		
		/// <summary>
		/// مبلغ السداد المباشر
		/// </summary>
		public Nullable<decimal> DirectPaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات السداد المباشر
		/// </summary>
		public string DirectPaymentNotes {get; set;}
		
		/// <summary>
		/// الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4
		/// </summary>
		public Nullable<byte> PaymentStatus {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// مكان العمل
		/// </summary>
		public Nullable<int> Department {get; set;}
		
		/// <summary>
		/// معرف القرار
		/// </summary>
		public Nullable<int> HealthLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public Nullable<short> HealthLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// عام القرار
		/// </summary>
		public Nullable<short> HealthLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> HealthLoanDecisionDate {get; set;}
		
		/// <summary>
		/// رقم القرار المرجعي لدى المركز
		/// </summary>
		public string HealthLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> HealthLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// رقم قرار الدفع
		/// </summary>
		public string HealthLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ قرار الدفع
		/// </summary>
		public Nullable<DateTime> HealthLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string HealthLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public Nullable<decimal> RequestCost {get; set;}
		
		/// <summary>
		/// معرف طلب السلفة
		/// </summary>
		public Nullable<int> LoanRequest {get; set;}
		#endregion
	}
	#endregion

    #region HealthLoanDecisionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.HealthLoanDecision table.
	/// </summary>
    public partial class HealthLoanDecisionVw
	{
		#region Public properties
		/// <summary>
		/// معرف القرار
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// عام القرار
		/// </summary>
		public short Year {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> Date {get; set;}
		
		/// <summary>
		/// رقم القرار المرجعي لدى المركز
		/// </summary>
		public string CersNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate {get; set;}
		
		/// <summary>
		/// رقم قرار الدفع
		/// </summary>
		public string PaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ قرار الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region IncomingLoanVw class definition
	/// <summary>
	/// Selects all rows from the dbo.IncomingLoan table.
	/// </summary>
    public partial class IncomingLoanVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int LoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int LoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte LoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool LoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int LoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte LoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal LoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte LoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte LoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanLoanStatusName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int MainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string MainWorkPlaceName {get; set;}
		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVw class definition
	/// <summary>
	/// Selects all rows from the dbo.InstallmentDecreaseOrder table.
	/// </summary>
    public partial class InstallmentDecreaseOrderVw
	{
		#region Public properties
		/// <summary>
		/// رقم الكتاب الداخلي
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الشهر الجاري توزيعه عند إنشاء الكتاب
		/// </summary>
		public DateTime Month {get; set;}
		
		/// <summary>
		/// مرجع الكتاب في المركز
		/// </summary>
		public string CersNumber {get; set;}
		
		/// <summary>
		/// تاريخ الكتاب في المركز
		/// </summary>
		public Nullable<DateTime> CersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region InstallmentDecreaseVw class definition
	/// <summary>
	/// Selects all rows from the dbo.InstallmentDecrease table.
	/// </summary>
    public partial class InstallmentDecreaseVw
	{
		#region Public properties
		/// <summary>
		/// معرف تخفيض القسط الشهري
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم الكتاب الداخلي
		/// </summary>
		public int InstallmentDecreaseOrderId {get; set;}
		
		/// <summary>
		/// الشهر الجاري توزيعه عند إنشاء الكتاب
		/// </summary>
		public DateTime InstallmentDecreaseOrderMonth {get; set;}
		
		/// <summary>
		/// مرجع الكتاب في المركز
		/// </summary>
		public string InstallmentDecreaseOrderCersNumber {get; set;}
		
		/// <summary>
		/// تاريخ الكتاب في المركز
		/// </summary>
		public Nullable<DateTime> InstallmentDecreaseOrderCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string InstallmentDecreaseOrderNotes {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public Nullable<int> DepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public Nullable<int> DepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> DepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// مقدار التخفيض على القسط
		/// </summary>
		public decimal DecreaseAmount {get; set;}
		
		/// <summary>
		/// القيمة الجديدة للقسط
		/// </summary>
		public decimal NewInstallmentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region InstallmentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Installment table.
	/// </summary>
    public partial class InstallmentVw
	{
		#region Public properties
		/// <summary>
		/// معرف القسط
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RefundableProductProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RefundableProductProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RefundableProductProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RefundableProductProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RefundableProductProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RefundableProductProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RefundableProductProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RefundableProductProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RefundableProductProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RefundableProductProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RefundableProductProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RefundableProductProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RefundableProductProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RefundableProductProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RefundableProductProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RefundableProductProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RefundableProductProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RefundableProductProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RefundableProductProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RefundableProductProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RefundableProductProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RefundableProductProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RefundableProductProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RefundableProductProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RefundableProductProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RefundableProductProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RefundableProductProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short RefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal RefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal RefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal RefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal RefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// مسلسل القسط
		/// </summary>
		public short SubNumber {get; set;}
		
		/// <summary>
		/// تاريخ الاستحقاق
		/// </summary>
		public DateTime DueDate {get; set;}
		
		/// <summary>
		/// رأس المال ضمن القسط
		/// </summary>
		public decimal DueCapital {get; set;}
		
		/// <summary>
		/// الأرباح ضمن القسط
		/// </summary>
		public decimal DueProfit {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region InsuranceTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.InsuranceType table.
	/// </summary>
    public partial class InsuranceTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف طريقة القبض
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان طريقة قبض التأمين
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region IssuerVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Issuer table.
	/// </summary>
    public partial class IssuerVw
	{
		#region Public properties
		/// <summary>
		/// معرف الجهة المصدرة للمديونية
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان الجهة المصدرة للمديونية
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region LoanChangeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanChange table.
	/// </summary>
    public partial class LoanChangeVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int LoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int LoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte LoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool LoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int LoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte LoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal LoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte LoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte LoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanLoanStatusName {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int FromLoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int FromLoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string FromLoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string FromLoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string FromLoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string FromLoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string FromLoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string FromLoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> FromLoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> FromLoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> FromLoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> FromLoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> FromLoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string FromLoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte FromLoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string FromLoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool FromLoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int FromLoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string FromLoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int FromLoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string FromLoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int FromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string FromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string FromLoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte FromLoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string FromLoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short FromLoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string FromLoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> FromLoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte FromLoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string FromLoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string FromLoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> FromLoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string FromLoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> FromLoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string FromLoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> FromLoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal FromLoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string FromLoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int FromLoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short FromLoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short FromLoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime FromLoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime FromLoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string FromLoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> FromLoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string FromLoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte FromLoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string FromLoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string FromLoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> FromLoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> FromLoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string FromLoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string FromLoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string FromLoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short FromLoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte FromLoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string FromLoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte FromLoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string FromLoanLoanStatusName {get; set;}
		#endregion
	}
	#endregion

    #region LoanDecisionTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanDecisionType table.
	/// </summary>
    public partial class LoanDecisionTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region LoanDecisionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanDecision table.
	/// </summary>
    public partial class LoanDecisionVw
	{
		#region Public properties
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short Year {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime DeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string PaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> IsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string Reason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string AdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string AdditionalIntroduction {get; set;}
		#endregion
	}
	#endregion

    #region LoanDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Loan table with related data of one to one related child tables.
	/// </summary>
    public partial class LoanDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte LoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte LoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanStatusName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is IncomingLoan
		/// </summary>
		public Nullable<bool> IsIncomingLoan {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> IncomingLoanMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string IncomingLoanMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is LoanChange
		/// </summary>
		public Nullable<bool> IsLoanChange {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> LoanChangeFromLoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public Nullable<int> LoanChangeFromLoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanChangeFromLoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public Nullable<int> LoanChangeFromLoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public Nullable<int> LoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> LoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanChangeFromLoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public Nullable<short> LoanChangeFromLoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanChangeFromLoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanChangeFromLoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanChangeFromLoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanChangeFromLoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanChangeFromLoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanChangeFromLoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanChangeFromLoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public Nullable<decimal> LoanChangeFromLoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanChangeFromLoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanChangeFromLoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public Nullable<short> LoanChangeFromLoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public Nullable<short> LoanChangeFromLoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanChangeFromLoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanChangeFromLoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanChangeFromLoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public Nullable<short> LoanChangeFromLoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanChangeFromLoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public Nullable<byte> LoanChangeFromLoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanChangeFromLoanLoanStatusName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is OutgoingLoan
		/// </summary>
		public Nullable<bool> IsOutgoingLoan {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> OutgoingLoanMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string OutgoingLoanMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// المبلغ الإجمالي المنقول
		/// </summary>
		public Nullable<decimal> OutgoingLoanApprovedAmount {get; set;}
		
		/// <summary>
		/// الصافي المنقول
		/// </summary>
		public Nullable<decimal> OutgoingLoanNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية المنقولة
		/// </summary>
		public Nullable<decimal> OutgoingLoanProfitAmount {get; set;}
		#endregion
	}
	#endregion

    #region LoanExtendedVw class definition
	/// <summary>
	/// Needs summary!
	/// </summary>
    public partial class LoanExtendedVw
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public int LoanDecisionId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public short LoanDecisionNumber {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public short LoanDecisionYear {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public DateTime LoanDecisionDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public DateTime LoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> LoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionNotes {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte LoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> LoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> LoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionReason {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public short LoanType {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte LoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public byte LoanStatusId {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string LoanStatusName {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public decimal RefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public decimal RefundableProductNetAmount {get; set;}
		#endregion
	}
	#endregion

    #region LoanGenerationStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanGenerationStatus table.
	/// </summary>
    public partial class LoanGenerationStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region LoanRequestVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanRequest table.
	/// </summary>
    public partial class LoanRequestVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int RequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string RequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string RequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string RequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string RequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string RequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string RequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> RequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string RequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte RequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string RequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool RequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int RequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string RequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte RequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string RequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short RequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string RequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> RequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte RequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string RequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string RequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> RequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string RequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> RequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string RequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> RequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal RequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime RequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal RequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string RequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal RequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int RequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string RequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestNotes {get; set;}
		
		/// <summary>
		/// صافي الدخل
		/// </summary>
		public decimal NetIncome {get; set;}
		
		/// <summary>
		/// الحسميات
		/// </summary>
		public decimal TotalDeduction {get; set;}
		#endregion
	}
	#endregion

    #region LoanStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanStatus table.
	/// </summary>
    public partial class LoanStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region LoanTypeClosureVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanTypeClosure table.
	/// </summary>
    public partial class LoanTypeClosureVw
	{
		#region Public properties
		/// <summary>
		/// معرف آلية إغلاق السلف
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanTypeProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanTypeProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanTypeProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanTypeProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanTypeProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanTypeProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanTypeProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanTypeProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanTypeProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanTypeProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanTypeProductTypeIsActive {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ClosingLoanTypeProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ClosingLoanTypeProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ClosingLoanTypeProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ClosingLoanTypeProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ClosingLoanTypeProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ClosingLoanTypeProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ClosingLoanTypeProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ClosingLoanTypeProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ClosingLoanTypeProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ClosingLoanTypeProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ClosingLoanTypeProductTypeIsActive {get; set;}
		#endregion
	}
	#endregion

    #region LoanTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.LoanType table.
	/// </summary>
    public partial class LoanTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductTypeIsActive {get; set;}
		#endregion
	}
	#endregion

    #region LoanVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Loan table.
	/// </summary>
    public partial class LoanVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte LoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte LoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanStatusName {get; set;}
		#endregion
	}
	#endregion

    #region MainWorkPlaceVw class definition
	/// <summary>
	/// Selects all rows from the dbo.MainWorkPlace table.
	/// </summary>
    public partial class MainWorkPlaceVw
	{
		#region Public properties
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region MissingInstallmentDecreaseVw class definition
	/// <summary>
	/// Selects all rows from the dbo.MissingInstallmentDecrease table.
	/// </summary>
    public partial class MissingInstallmentDecreaseVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// المبلغ المحول من الرواتب
		/// </summary>
		public decimal SalaryAmount {get; set;}
		
		/// <summary>
		/// شهر التحويل
		/// </summary>
		public DateTime TransferMonth {get; set;}
		
		/// <summary>
		/// قيمة الأقساط المنتهية
		/// </summary>
		public decimal FinishedInstallmentsAmount {get; set;}
		
		/// <summary>
		/// قيمة الأقساط المتبقية
		/// </summary>
		public decimal RemainingInstallmentsAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region MonthlyBalanceVw class definition
	/// <summary>
	/// Selects all rows from the dbo.MonthlyBalance table.
	/// </summary>
    public partial class MonthlyBalanceVw
	{
		#region Public properties
		/// <summary>
		/// معرف الرصيد الشهري
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// الشهر
		/// </summary>
		public DateTime Month {get; set;}
		
		/// <summary>
		/// الرصيد الافتتاحي
		/// </summary>
		public decimal Opening {get; set;}
		
		/// <summary>
		/// مجموع السلف الممنوحة النظامية
		/// </summary>
		public decimal NormalLoans {get; set;}
		
		/// <summary>
		/// قيمة السلف المحولة إلى المشترك
		/// </summary>
		public decimal IncomingLoans {get; set;}
		
		/// <summary>
		/// المبلغ المدفوع نقداً للمشترك
		/// </summary>
		public decimal Restitution {get; set;}
		
		/// <summary>
		/// قيمة السلف المحولة من المشترك
		/// </summary>
		public decimal OutgoingLoans {get; set;}
		
		/// <summary>
		/// تحويلات الرواتب
		/// </summary>
		public decimal SalaryPayment {get; set;}
		
		/// <summary>
		/// الدفعات النقدية
		/// </summary>
		public decimal CashPayment {get; set;}
		#endregion
	}
	#endregion

    #region OutgoingLoanVw class definition
	/// <summary>
	/// Selects all rows from the dbo.OutgoingLoan table.
	/// </summary>
    public partial class OutgoingLoanVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int LoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int LoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte LoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool LoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int LoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte LoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal LoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte LoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte LoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanLoanStatusName {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short LoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public short LoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime LoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime LoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte LoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int MainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string MainWorkPlaceName {get; set;}
		
		/// <summary>
		/// المبلغ الإجمالي المنقول
		/// </summary>
		public decimal ApprovedAmount {get; set;}
		
		/// <summary>
		/// الصافي المنقول
		/// </summary>
		public decimal NetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية المنقولة
		/// </summary>
		public decimal ProfitAmount {get; set;}
		#endregion
	}
	#endregion

    #region PaymentDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Payment table with related data of one to one related child tables.
	/// </summary>
    public partial class PaymentDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> CollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> CollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> CollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> CollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> CollectOrderAccountingDocumentDate {get; set;}
		
		/// <summary>
		/// Specifies Whether the Payment is CashPayment
		/// </summary>
		public Nullable<bool> IsCashPayment {get; set;}
		
		/// <summary>
		/// رقم البيان
		/// </summary>
		public Nullable<short> CashPaymentNumber {get; set;}
		
		/// <summary>
		/// رقم الإيصال
		/// </summary>
		public Nullable<int> CashPaymentReceiptNumber {get; set;}
		
		/// <summary>
		/// تاريخ الإيصال
		/// </summary>
		public Nullable<DateTime> CashPaymentReceiptDate {get; set;}
		
		/// <summary>
		/// مبلغ الغرامة
		/// </summary>
		public Nullable<decimal> CashPaymentFeeAmount {get; set;}
		
		/// <summary>
		/// Specifies Whether the Payment is DownPayment
		/// </summary>
		public Nullable<bool> IsDownPayment {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> DownPaymentRequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public Nullable<int> DownPaymentRequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string DownPaymentRequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string DownPaymentRequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string DownPaymentRequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string DownPaymentRequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string DownPaymentRequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string DownPaymentRequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string DownPaymentRequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public Nullable<byte> DownPaymentRequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string DownPaymentRequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> DownPaymentRequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public Nullable<int> DownPaymentRequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DownPaymentRequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public Nullable<int> DownPaymentRequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DownPaymentRequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> DownPaymentRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DownPaymentRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string DownPaymentRequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public Nullable<byte> DownPaymentRequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string DownPaymentRequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public Nullable<short> DownPaymentRequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string DownPaymentRequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> DownPaymentRequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public Nullable<byte> DownPaymentRequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string DownPaymentRequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string DownPaymentRequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> DownPaymentRequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string DownPaymentRequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> DownPaymentRequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string DownPaymentRequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> DownPaymentRequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public Nullable<decimal> DownPaymentRequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string DownPaymentRequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public Nullable<DateTime> DownPaymentRequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public Nullable<decimal> DownPaymentRequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string DownPaymentRequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public Nullable<decimal> DownPaymentRequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> DownPaymentRequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string DownPaymentRequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public Nullable<int> DownPaymentRequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string DownPaymentRequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string DownPaymentRequestNotes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Payment is SalaryPayment
		/// </summary>
		public Nullable<bool> IsSalaryPayment {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public Nullable<int> SalaryPaymentDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string SalaryPaymentDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public Nullable<int> SalaryPaymentDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string SalaryPaymentDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> SalaryPaymentDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string SalaryPaymentDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// الرصيد المستورد
		/// </summary>
		public Nullable<decimal> SalaryPaymentBalance {get; set;}
		#endregion
	}
	#endregion

    #region PaymentGroupVw class definition
	/// <summary>
	/// Selects all rows from the dbo.PaymentGroup table.
	/// </summary>
    public partial class PaymentGroupVw
	{
		#region Public properties
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region PaymentStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.PaymentStatus table.
	/// </summary>
    public partial class PaymentStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region PaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Payment table.
	/// </summary>
    public partial class PaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> CollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> CollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> CollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> CollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> CollectOrderAccountingDocumentDate {get; set;}
		#endregion
	}
	#endregion

    #region PayOrderVw class definition
	/// <summary>
	/// Selects all rows from the dbo.PayOrder table.
	/// </summary>
    public partial class PayOrderVw
	{
		#region Public properties
		/// <summary>
		/// معرف أمر الدفع
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// رقم البيان
		/// </summary>
		public short Number {get; set;}
		
		/// <summary>
		/// تاريخ البيان
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// رقم الإشعار
		/// </summary>
		public Nullable<short> VoucherNumber {get; set;}
		
		/// <summary>
		/// تاريخ الإشعار
		/// </summary>
		public Nullable<DateTime> VoucherDate {get; set;}
		
		/// <summary>
		/// رقم أمر الدفع
		/// </summary>
		public Nullable<short> PaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> AccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> AccountingDocumentDate {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// المبلغ للدفع
		/// </summary>
		public decimal PaidAmount {get; set;}
		
		/// <summary>
		/// عوائد ربحية؟
		/// </summary>
		public bool IsProfit {get; set;}
		
		/// <summary>
		/// تم تثبيت الدفع؟
		/// </summary>
		public byte IsFixed {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region ProductDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Product table with related data of one to one related child tables.
	/// </summary>
    public partial class ProductDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Product is Grant
		/// </summary>
		public Nullable<bool> IsGrant {get; set;}
		
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public Nullable<int> GrantGrantDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public Nullable<short> GrantGrantDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public Nullable<short> GrantGrantDecisionYear {get; set;}
		
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public Nullable<byte> GrantGrantDecisionGrantTypeGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string GrantGrantDecisionGrantTypeGroupName {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string GrantGrantDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionCersDate {get; set;}
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string GrantGrantDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantGrantDecisionNotes {get; set;}
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string GrantGrantDecisionTableNumber {get; set;}
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionTableDate {get; set;}
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string GrantGrantDecisionBaseNumber {get; set;}
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> GrantGrantDecisionBaseDate {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string GrantGrantDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public Nullable<decimal> GrantAmount {get; set;}
		
		/// <summary>
		/// Specifies Whether the Grant is GrantDeduction
		/// </summary>
		public bool GrantIsGrantDeduction {get; set;}
		
		/// <summary>
		/// مبلغ الحسم
		/// </summary>
		public Nullable<decimal> GrantGrantDeductionAmount {get; set;}
		
		/// <summary>
		/// بيان الحسم
		/// </summary>
		public string GrantGrantDeductionDescription {get; set;}
		
		/// <summary>
		/// Specifies Whether the Product is Loan
		/// </summary>
		public Nullable<bool> IsLoan {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public Nullable<short> LoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public Nullable<short> LoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public Nullable<byte> LoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public Nullable<short> LoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public Nullable<byte> LoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanLoanStatusName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is IncomingLoan
		/// </summary>
		public bool LoanIsIncomingLoan {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> LoanIncomingLoanMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanIncomingLoanMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is LoanChange
		/// </summary>
		public bool LoanIsLoanChange {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanLoanChangeFromLoanProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string LoanLoanChangeFromLoanProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public Nullable<short> LoanLoanChangeFromLoanProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanLoanChangeFromLoanProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanLoanChangeFromLoanProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanLoanChangeFromLoanProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanLoanChangeFromLoanProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanLoanChangeFromLoanProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanLoanChangeFromLoanProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanLoanChangeFromLoanProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public Nullable<decimal> LoanLoanChangeFromLoanProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanChangeFromLoanProductNotes {get; set;}
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanLoanChangeFromLoanLoanDecisionId {get; set;}
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public Nullable<short> LoanLoanChangeFromLoanLoanDecisionNumber {get; set;}
		
		/// <summary>
		/// العام
		/// </summary>
		public Nullable<short> LoanLoanChangeFromLoanLoanDecisionYear {get; set;}
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanLoanDecisionDate {get; set;}
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanLoanDecisionDeductionStartDate {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionCersNumber {get; set;}
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanLoanDecisionCersDate {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionNotes {get; set;}
		
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanLoanDecisionLoanDecisionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionLoanDecisionTypeName {get; set;}
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionPaymentNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> LoanLoanChangeFromLoanLoanDecisionPaymentDate {get; set;}
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> LoanLoanChangeFromLoanLoanDecisionIsPaidFromSalary {get; set;}
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionReason {get; set;}
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionAdditionalClause {get; set;}
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string LoanLoanChangeFromLoanLoanDecisionAdditionalIntroduction {get; set;}
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public Nullable<short> LoanLoanChangeFromLoanLoanType {get; set;}
		
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanLoanGenerationStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string LoanLoanChangeFromLoanLoanGenerationStatusName {get; set;}
		
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public Nullable<byte> LoanLoanChangeFromLoanLoanStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string LoanLoanChangeFromLoanLoanStatusName {get; set;}
		
		/// <summary>
		/// Specifies Whether the Loan is OutgoingLoan
		/// </summary>
		public bool LoanIsOutgoingLoan {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public Nullable<int> LoanOutgoingLoanMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string LoanOutgoingLoanMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// المبلغ الإجمالي المنقول
		/// </summary>
		public Nullable<decimal> LoanOutgoingLoanApprovedAmount {get; set;}
		
		/// <summary>
		/// الصافي المنقول
		/// </summary>
		public Nullable<decimal> LoanOutgoingLoanNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية المنقولة
		/// </summary>
		public Nullable<decimal> LoanOutgoingLoanProfitAmount {get; set;}
		
		/// <summary>
		/// Specifies Whether the Product is RefundableProduct
		/// </summary>
		public Nullable<bool> IsRefundableProduct {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public Nullable<short> RefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public Nullable<decimal> RefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public Nullable<decimal> RefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public Nullable<decimal> RefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public Nullable<decimal> RefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// Specifies Whether the Product is Request
		/// </summary>
		public Nullable<bool> IsRequest {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public Nullable<DateTime> RequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public Nullable<decimal> RequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string RequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public Nullable<decimal> RequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public Nullable<int> RequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string RequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestNotes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Request is GrantRequest
		/// </summary>
		public bool RequestIsGrantRequest {get; set;}
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public Nullable<byte> RequestGrantRequestGrantType {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string RequestGrantRequestDescription {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public Nullable<decimal> RequestGrantRequestAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string RequestGrantRequestNotes {get; set;}
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public Nullable<DateTime> RequestGrantRequestEventDate {get; set;}
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public Nullable<bool> RequestGrantRequestIsFromOtherBranch {get; set;}
		
		/// <summary>
		/// Specifies Whether the GrantRequest is ServiceEndGrantRequest
		/// </summary>
		public bool RequestGrantRequestIsServiceEndGrantRequest {get; set;}
		
		/// <summary>
		/// متوسط الدخل الشهري
		/// </summary>
		public Nullable<decimal> RequestGrantRequestServiceEndGrantRequestAverageIncome {get; set;}
		
		/// <summary>
		/// نسبة الصرف
		/// </summary>
		public Nullable<decimal> RequestGrantRequestServiceEndGrantRequestGrantPercentage {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة
		/// </summary>
		public Nullable<short> RequestGrantRequestServiceEndGrantRequestServiceInMonthes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Request is LoanRequest
		/// </summary>
		public bool RequestIsLoanRequest {get; set;}
		
		/// <summary>
		/// صافي الدخل
		/// </summary>
		public Nullable<decimal> RequestLoanRequestNetIncome {get; set;}
		
		/// <summary>
		/// الحسميات
		/// </summary>
		public Nullable<decimal> RequestLoanRequestTotalDeduction {get; set;}
		#endregion
	}
	#endregion

    #region ProductTypeAvailabilityVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ProductTypeAvailability table.
	/// </summary>
    public partial class ProductTypeAvailabilityVw
	{
		#region Public properties
		/// <summary>
		/// معرف القيد
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductTypeIsActive {get; set;}
		
		/// <summary>
		/// معرف القاعدة
		/// </summary>
		public short AvailabilityId {get; set;}
		
		/// <summary>
		/// اسم القاعدة
		/// </summary>
		public string AvailabilityName {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة اللازم
		/// </summary>
		public byte AvailabilityMinSeniority {get; set;}
		
		/// <summary>
		/// الحد الأدنى من عدد الأشهر لإعادة الاستفادة
		/// </summary>
		public byte AvailabilityMinReusePeriod {get; set;}
		#endregion
	}
	#endregion

    #region ProductTypeDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ProductType table with related data of one to one related child tables.
	/// </summary>
    public partial class ProductTypeDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short Id {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> Rate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string AccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string PrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> IsActive {get; set;}
		
		/// <summary>
		/// Specifies Whether the ProductType is LoanType
		/// </summary>
		public Nullable<bool> IsLoanType {get; set;}
		#endregion
	}
	#endregion

    #region ProductTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ProductType table.
	/// </summary>
    public partial class ProductTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short Id {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> Rate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string AccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string PrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> PaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> IsActive {get; set;}
		#endregion
	}
	#endregion

    #region ProductVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Product table.
	/// </summary>
    public partial class ProductVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region ProfileVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Profile table.
	/// </summary>
    public partial class ProfileVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// رقم هاتف العمل
		/// </summary>
		public string Extension {get; set;}
		
		/// <summary>
		/// رقم المنزل
		/// </summary>
		public string HomePhone {get; set;}
		
		/// <summary>
		/// رقم الهاتف الخلوي
		/// </summary>
		public string MobilePhone {get; set;}
		
		/// <summary>
		/// العنوان
		/// </summary>
		public string Address {get; set;}
		#endregion
	}
	#endregion

    #region ProfitStrategyVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ProfitStrategy table.
	/// </summary>
    public partial class ProfitStrategyVw
	{
		#region Public properties
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region RefundableProductVw class definition
	/// <summary>
	/// Selects all rows from the dbo.RefundableProduct table.
	/// </summary>
    public partial class RefundableProductVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short PaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal NetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal ProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal SyrianPoundRounds {get; set;}
		#endregion
	}
	#endregion

    #region RequestDetailVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Request table with related data of one to one related child tables.
	/// </summary>
    public partial class RequestDetailVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string Attachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal Cost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int BypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string BypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Request is GrantRequest
		/// </summary>
		public Nullable<bool> IsGrantRequest {get; set;}
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public Nullable<byte> GrantRequestGrantType {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string GrantRequestDescription {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public Nullable<decimal> GrantRequestAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantRequestNotes {get; set;}
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public Nullable<DateTime> GrantRequestEventDate {get; set;}
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public Nullable<bool> GrantRequestIsFromOtherBranch {get; set;}
		
		/// <summary>
		/// Specifies Whether the GrantRequest is ServiceEndGrantRequest
		/// </summary>
		public bool GrantRequestIsServiceEndGrantRequest {get; set;}
		
		/// <summary>
		/// متوسط الدخل الشهري
		/// </summary>
		public Nullable<decimal> GrantRequestServiceEndGrantRequestAverageIncome {get; set;}
		
		/// <summary>
		/// نسبة الصرف
		/// </summary>
		public Nullable<decimal> GrantRequestServiceEndGrantRequestGrantPercentage {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة
		/// </summary>
		public Nullable<short> GrantRequestServiceEndGrantRequestServiceInMonthes {get; set;}
		
		/// <summary>
		/// Specifies Whether the Request is LoanRequest
		/// </summary>
		public Nullable<bool> IsLoanRequest {get; set;}
		
		/// <summary>
		/// صافي الدخل
		/// </summary>
		public Nullable<decimal> LoanRequestNetIncome {get; set;}
		
		/// <summary>
		/// الحسميات
		/// </summary>
		public Nullable<decimal> LoanRequestTotalDeduction {get; set;}
		#endregion
	}
	#endregion

    #region RequestStatusVw class definition
	/// <summary>
	/// Selects all rows from the dbo.RequestStatus table.
	/// </summary>
    public partial class RequestStatusVw
	{
		#region Public properties
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region RequestVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Request table.
	/// </summary>
    public partial class RequestVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int ProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int ProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string ProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string ProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string ProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string ProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string ProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string ProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> ProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> ProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> ProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string ProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte ProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string ProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool ProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int ProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string ProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte ProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string ProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short ProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string ProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> ProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte ProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string ProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string ProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string ProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> ProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string ProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> ProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal ProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string ProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string Attachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal Cost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> RequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string RequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int BypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string BypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region ResourceVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Resource table.
	/// </summary>
    public partial class ResourceVw
	{
		#region Public properties
		/// <summary>
		/// معرف المورد
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// اللغة
		/// </summary>
		public string Language {get; set;}
		
		/// <summary>
		/// الوحدة
		/// </summary>
		public string Module {get; set;}
		
		/// <summary>
		/// المفتاح
		/// </summary>
		public string Key {get; set;}
		
		/// <summary>
		/// القيمة
		/// </summary>
		public string Value {get; set;}
		
		/// <summary>
		/// قابل للتعديل؟
		/// </summary>
		public bool IsEditable {get; set;}
		#endregion
	}
	#endregion

    #region SalaryPaymentVw class definition
	/// <summary>
	/// Selects all rows from the dbo.SalaryPayment table.
	/// </summary>
    public partial class SalaryPaymentVw
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int PaymentId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int PaymentEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string PaymentEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string PaymentEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string PaymentEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string PaymentEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string PaymentEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string PaymentEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string PaymentEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte PaymentEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string PaymentEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool PaymentEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int PaymentEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string PaymentEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte PaymentEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string PaymentEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime PaymentDate {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentPaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentPaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> PaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentNotes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentPaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentPaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> PaymentCollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> PaymentCollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> PaymentCollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderAccountingDocumentDate {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int DepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int DepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int DepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// الرصيد المستورد
		/// </summary>
		public Nullable<decimal> Balance {get; set;}
		#endregion
	}
	#endregion

    #region SalaryWorkPlaceVw class definition
	/// <summary>
	/// Selects all rows from the dbo.SalaryWorkPlace table.
	/// </summary>
    public partial class SalaryWorkPlaceVw
	{
		#region Public properties
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string Name {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int MainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string MainWorkPlaceName {get; set;}
		#endregion
	}
	#endregion

    #region ServiceEndGrantRequestVw class definition
	/// <summary>
	/// Selects all rows from the dbo.ServiceEndGrantRequest table.
	/// </summary>
    public partial class ServiceEndGrantRequestVw
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int GrantRequestRequestProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int GrantRequestRequestProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string GrantRequestRequestProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string GrantRequestRequestProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string GrantRequestRequestProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string GrantRequestRequestProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string GrantRequestRequestProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string GrantRequestRequestProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> GrantRequestRequestProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> GrantRequestRequestProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> GrantRequestRequestProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> GrantRequestRequestProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> GrantRequestRequestProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string GrantRequestRequestProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte GrantRequestRequestProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string GrantRequestRequestProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool GrantRequestRequestProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int GrantRequestRequestProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string GrantRequestRequestProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantRequestRequestProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte GrantRequestRequestProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string GrantRequestRequestProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short GrantRequestRequestProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string GrantRequestRequestProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> GrantRequestRequestProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GrantRequestRequestProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string GrantRequestRequestProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string GrantRequestRequestProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> GrantRequestRequestProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string GrantRequestRequestProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> GrantRequestRequestProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string GrantRequestRequestProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> GrantRequestRequestProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal GrantRequestRequestProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantRequestRequestProductNotes {get; set;}
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime GrantRequestRequestDate {get; set;}
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal GrantRequestRequestAmount {get; set;}
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string GrantRequestRequestAttachment {get; set;}
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal GrantRequestRequestCost {get; set;}
		
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public Nullable<byte> GrantRequestRequestRequestStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string GrantRequestRequestRequestStatusName {get; set;}
		
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int GrantRequestRequestBypassStatusId {get; set;}
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string GrantRequestRequestBypassStatusName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantRequestRequestNotes {get; set;}
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public byte GrantRequestGrantType {get; set;}
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string GrantRequestDescription {get; set;}
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal GrantRequestAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string GrantRequestNotes {get; set;}
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public DateTime GrantRequestEventDate {get; set;}
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public bool GrantRequestIsFromOtherBranch {get; set;}
		
		/// <summary>
		/// متوسط الدخل الشهري
		/// </summary>
		public decimal AverageIncome {get; set;}
		
		/// <summary>
		/// نسبة الصرف
		/// </summary>
		public decimal GrantPercentage {get; set;}
		
		/// <summary>
		/// عدد أشهر الخدمة
		/// </summary>
		public short ServiceInMonthes {get; set;}
		#endregion
	}
	#endregion

    #region SettlementVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Settlement table.
	/// </summary>
    public partial class SettlementVw
	{
		#region Public properties
		/// <summary>
		/// معرف السداد
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف القسط
		/// </summary>
		public int InstallmentId {get; set;}
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int InstallmentRefundableProductProductId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int InstallmentRefundableProductProductEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> InstallmentRefundableProductProductEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> InstallmentRefundableProductProductEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> InstallmentRefundableProductProductEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> InstallmentRefundableProductProductEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> InstallmentRefundableProductProductEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte InstallmentRefundableProductProductEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool InstallmentRefundableProductProductEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int InstallmentRefundableProductProductEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte InstallmentRefundableProductProductEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string InstallmentRefundableProductProductEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short InstallmentRefundableProductProductProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string InstallmentRefundableProductProductProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> InstallmentRefundableProductProductProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte InstallmentRefundableProductProductProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string InstallmentRefundableProductProductProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string InstallmentRefundableProductProductProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> InstallmentRefundableProductProductProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string InstallmentRefundableProductProductProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> InstallmentRefundableProductProductProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string InstallmentRefundableProductProductProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> InstallmentRefundableProductProductProductTypeIsActive {get; set;}
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal InstallmentRefundableProductProductAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string InstallmentRefundableProductProductNotes {get; set;}
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short InstallmentRefundableProductPaymentPeriod {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal InstallmentRefundableProductInstallment {get; set;}
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal InstallmentRefundableProductNetAmount {get; set;}
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal InstallmentRefundableProductProfitAmount {get; set;}
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal InstallmentRefundableProductSyrianPoundRounds {get; set;}
		
		/// <summary>
		/// مسلسل القسط
		/// </summary>
		public short InstallmentSubNumber {get; set;}
		
		/// <summary>
		/// تاريخ الاستحقاق
		/// </summary>
		public DateTime InstallmentDueDate {get; set;}
		
		/// <summary>
		/// رأس المال ضمن القسط
		/// </summary>
		public decimal InstallmentDueCapital {get; set;}
		
		/// <summary>
		/// الأرباح ضمن القسط
		/// </summary>
		public decimal InstallmentDueProfit {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string InstallmentNotes {get; set;}
		
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int PaymentId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int PaymentEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string PaymentEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string PaymentEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string PaymentEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string PaymentEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string PaymentEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string PaymentEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> PaymentEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string PaymentEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte PaymentEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string PaymentEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool PaymentEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int PaymentEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string PaymentEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte PaymentEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string PaymentEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime PaymentDate {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte PaymentPaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string PaymentPaymentGroupName {get; set;}
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> PaymentAmount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string PaymentNotes {get; set;}
		
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public Nullable<byte> PaymentPaymentStatusId {get; set;}
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string PaymentPaymentStatusName {get; set;}
		
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public Nullable<int> PaymentCollectOrderId {get; set;}
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> PaymentCollectOrderNumber {get; set;}
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderDate {get; set;}
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> PaymentCollectOrderAccountingDocumentNumber {get; set;}
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> PaymentCollectOrderAccountingDocumentDate {get; set;}
		
		/// <summary>
		/// المبلغ المسدد
		/// </summary>
		public decimal Amount {get; set;}
		#endregion
	}
	#endregion

    #region SpecialCaseLoanVw class definition
	/// <summary>
	/// Selects all rows from the dbo.SpecialCaseLoan table.
	/// </summary>
    public partial class SpecialCaseLoanVw
	{
		#region Public properties
		/// <summary>
		/// معرف السلفة الخاصة
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// تاريخ السلفة
		/// </summary>
		public DateTime Date {get; set;}
		
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short LoanTypeProductTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string LoanTypeProductTypeName {get; set;}
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> LoanTypeProductTypeRate {get; set;}
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte LoanTypeProductTypeGuarantorsCount {get; set;}
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string LoanTypeProductTypeAccountNumber {get; set;}
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string LoanTypeProductTypePrintLabel {get; set;}
		
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> LoanTypeProductTypeProfitStrategyId {get; set;}
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string LoanTypeProductTypeProfitStrategyName {get; set;}
		
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public Nullable<byte> LoanTypeProductTypePaymentGroupId {get; set;}
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string LoanTypeProductTypePaymentGroupName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> LoanTypeProductTypeIsActive {get; set;}
		
		/// <summary>
		/// المبلغ الممنوح
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion

    #region SubscriptionTypeVw class definition
	/// <summary>
	/// Selects all rows from the dbo.SubscriptionType table.
	/// </summary>
    public partial class SubscriptionTypeVw
	{
		#region Public properties
		/// <summary>
		/// معرف نوع الاشتراك
		/// </summary>
		public byte Id {get; set;}
		
		/// <summary>
		/// بيان نوع الاشتراك
		/// </summary>
		public string Name {get; set;}
		#endregion
	}
	#endregion

    #region SubscriptionVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Subscription table.
	/// </summary>
    public partial class SubscriptionVw
	{
		#region Public properties
		/// <summary>
		/// معرف الاشتراك
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// التاريخ
		/// </summary>
		public DateTime Month {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int DepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int DepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int DepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف نوع الاشتراك
		/// </summary>
		public byte SubscriptionTypeId {get; set;}
		
		/// <summary>
		/// بيان نوع الاشتراك
		/// </summary>
		public string SubscriptionTypeName {get; set;}
		
		/// <summary>
		/// مبلغ الاشتراك
		/// </summary>
		public decimal Amount {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// مثبت؟
		/// </summary>
		public bool IsFixed {get; set;}
		#endregion
	}
	#endregion

    #region TransitoryIncomingLoanVw class definition
	/// <summary>
	/// Selects all rows from the dbo.TransitoryIncomingLoan table.
	/// </summary>
    public partial class TransitoryIncomingLoanVw
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int MainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string MainWorkPlaceName {get; set;}
		
		/// <summary>
		/// السلفة الممنوحة
		/// </summary>
		public decimal ApprovedAmount {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		
		/// <summary>
		/// الحالة  non:0; verified:1; to be deleted:2
		/// </summary>
		public bool IsVerified {get; set;}
		#endregion
	}
	#endregion

    #region WarrantVw class definition
	/// <summary>
	/// Selects all rows from the dbo.Warrant table.
	/// </summary>
    public partial class WarrantVw
	{
		#region Public properties
		/// <summary>
		/// معرف كفيل المديونية
		/// </summary>
		public int Id {get; set;}
		
		/// <summary>
		/// معرف المديونية
		/// </summary>
		public int DebtId {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int DebtEmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string DebtEmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string DebtEmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string DebtEmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string DebtEmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string DebtEmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string DebtEmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> DebtEmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> DebtEmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> DebtEmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> DebtEmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> DebtEmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string DebtEmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte DebtEmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string DebtEmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool DebtEmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int DebtEmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string DebtEmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int DebtEmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string DebtEmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string DebtEmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte DebtEmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string DebtEmployeeCategoryName {get; set;}
		
		/// <summary>
		/// المبلغ الإجمالي للمديونية
		/// </summary>
		public decimal DebtAmount {get; set;}
		
		/// <summary>
		/// معرف الجهة المصدرة للمديونية
		/// </summary>
		public byte DebtIssuerId {get; set;}
		
		/// <summary>
		/// بيان الجهة المصدرة للمديونية
		/// </summary>
		public string DebtIssuerName {get; set;}
		
		/// <summary>
		/// الرقم المرجعي لدى الجهة المانحة
		/// </summary>
		public string DebtReferenceNumber {get; set;}
		
		/// <summary>
		/// تاريخ المديونية
		/// </summary>
		public Nullable<DateTime> DebtDate {get; set;}
		
		/// <summary>
		/// مدة الدين
		/// </summary>
		public Nullable<byte> DebtPeriodInMonths {get; set;}
		
		/// <summary>
		/// المبالغ المدفوعة استثنائياً
		/// </summary>
		public decimal DebtExceptionalPayment {get; set;}
		
		/// <summary>
		/// المديونية فعالة؟
		/// </summary>
		public bool DebtIsActive {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string DebtNotes {get; set;}
		
		/// <summary>
		/// بيان الدين
		/// </summary>
		public string DebtIssueDescription {get; set;}
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal DebtInstallment {get; set;}
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int EmployeeId {get; set;}
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string EmployeeFirstName {get; set;}
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string EmployeeLastName {get; set;}
		
		/// <summary>
		/// الاسم الكامل
		/// </summary>
		public string EmployeeFullName {get; set;}
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string EmployeeFatherName {get; set;}
		
		/// <summary>
		/// الاسم الثلاثي
		/// </summary>
		public string EmployeeFullName3 {get; set;}
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string EmployeeMotherName {get; set;}
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> EmployeeBirthDate {get; set;}
		
		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> EmployeeExpectedEndDate {get; set;}
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> EmployeeCersStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> EmployeeCfStartDate {get; set;}
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> EmployeeLeaveDate {get; set;}
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string EmployeeLeaveReason {get; set;}
		
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte EmployeeEmployeeStatusId {get; set;}
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string EmployeeEmployeeStatusName {get; set;}
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool EmployeeEmployeeStatusIsActive {get; set;}
		
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int EmployeeDepartmentId {get; set;}
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string EmployeeDepartmentName {get; set;}
		
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceName {get; set;}
		
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId {get; set;}
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string EmployeeNotes {get; set;}
		
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte EmployeeCategoryId {get; set;}
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string EmployeeCategoryName {get; set;}
		
		/// <summary>
		/// الكفالة فعالة؟
		/// </summary>
		public bool IsActive {get; set;}
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes {get; set;}
		#endregion
	}
	#endregion
}
