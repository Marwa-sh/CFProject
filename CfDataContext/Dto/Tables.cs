using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region Availability class definition
	/// <summary>
	/// قاعدة استخدام المنتجات
	/// </summary>
    [MetadataType(typeof(AvailabilityMetaData))]
	public partial class Availability
	{
		#region Public properties
		/// <summary>
		/// معرف القاعدة
		/// </summary>
		public short Id { get; set; }
		
		/// <summary>
		/// اسم القاعدة
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// عدد أشهر الخدمة اللازم
		/// </summary>
		public byte MinSeniority { get; set; }
		
		/// <summary>
		/// الحد الأدنى من عدد الأشهر لإعادة الاستفادة
		/// </summary>
		public byte MinReusePeriod { get; set; }
		#endregion
	}
	#endregion

	#region AvailabilityCeiling class definition
	/// <summary>
	/// سقف مبلغ المنتج حسب نوع المنتج وسنوات القدم
	/// </summary>
    [MetadataType(typeof(AvailabilityCeilingMetaData))]
	public partial class AvailabilityCeiling
	{
		#region Public properties
		/// <summary>
		/// معرف السقف
		/// </summary>
		public short Id { get; set; }
		
		/// <summary>
		/// نوع السلف
		/// </summary>
		public short Availability { get; set; }
		
		/// <summary>
		/// الحد الأدنى لسنوات الخدمة
		/// </summary>
		public short FromYear { get; set; }
		
		/// <summary>
		/// الحد الأقصى للمبلغ
		/// </summary>
		public decimal MaxAmount { get; set; }
		#endregion
	}
	#endregion

	#region BypassStatus class definition
	/// <summary>
	/// حالة تجاوز شروط الحصول على المنتج
	/// </summary>
    [MetadataType(typeof(BypassStatusMetaData))]
	public partial class BypassStatus
	{
		#region Public properties
		/// <summary>
		/// معرف الحالة
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// بيان الحالة
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region CashPayment class definition
	/// <summary>
	/// الدفعة النقدية
	/// </summary>
    [MetadataType(typeof(CashPaymentMetaData))]
	public partial class CashPayment
	{
		#region Public properties
		/// <summary>
		/// معرف الدفعة
		/// </summary>
		public int Payment { get; set; }
		
		/// <summary>
		/// رقم البيان
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// رقم الإيصال
		/// </summary>
		public Nullable<int> ReceiptNumber { get; set; }
		
		/// <summary>
		/// تاريخ الإيصال
		/// </summary>
		public Nullable<DateTime> ReceiptDate { get; set; }
		
		/// <summary>
		/// مبلغ الغرامة
		/// </summary>
		public decimal FeeAmount { get; set; }
		#endregion
	}
	#endregion

	#region Category class definition
	/// <summary>
	/// الهيئة الوظيفية
	/// </summary>
    [MetadataType(typeof(CategoryMetaData))]
	public partial class Category
	{
		#region Public properties
		/// <summary>
		/// معرف الهيئة
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان الهيئة
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region CollectOrder class definition
	/// <summary>
	/// أمر قبض
	/// </summary>
    [MetadataType(typeof(CollectOrderMetaData))]
	public partial class CollectOrder
	{
		#region Public properties
		/// <summary>
		/// معرف أمر القبض
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم أمر القبض
		/// </summary>
		public Nullable<short> Number { get; set; }
		
		/// <summary>
		/// تاريخ أمر القبض
		/// </summary>
		public Nullable<DateTime> Date { get; set; }
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> AccountingDocumentNumber { get; set; }
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> AccountingDocumentDate { get; set; }
		#endregion
	}
	#endregion

	#region Debt class definition
	/// <summary>
	/// المديونية
	/// </summary>
    [MetadataType(typeof(DebtMetaData))]
	public partial class Debt
	{
		#region Public properties
		/// <summary>
		/// معرف المديونية
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي للمشترك
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// المبلغ الإجمالي للمديونية
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// جهة المنح
		/// </summary>
		public byte Issuer { get; set; }
		
		/// <summary>
		/// الرقم المرجعي لدى الجهة المانحة
		/// </summary>
		public string ReferenceNumber { get; set; }
		
		/// <summary>
		/// تاريخ المديونية
		/// </summary>
		public Nullable<DateTime> Date { get; set; }
		
		/// <summary>
		/// مدة الدين
		/// </summary>
		public Nullable<byte> PeriodInMonths { get; set; }
		
		/// <summary>
		/// المبالغ المدفوعة استثنائياً
		/// </summary>
		public decimal ExceptionalPayment { get; set; }
		
		/// <summary>
		/// المديونية فعالة؟
		/// </summary>
		public bool IsActive { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// بيان الدين
		/// </summary>
		public string IssueDescription { get; set; }
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment { get; set; }
		#endregion
	}
	#endregion

	#region Department class definition
	/// <summary>
	/// الفعالية
	/// </summary>
    [MetadataType(typeof(DepartmentMetaData))]
	public partial class Department
	{
		#region Public properties
		/// <summary>
		/// معرف الفعالية
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// اسم الفعالية
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// جهة صرف الراتب
		/// </summary>
		public int SalaryWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region DownPayment class definition
	/// <summary>
	/// الدفعة الأولى
	/// </summary>
    [MetadataType(typeof(DownPaymentMetaData))]
	public partial class DownPayment
	{
		#region Public properties
		/// <summary>
		/// معرف الدفعة
		/// </summary>
		public int Payment { get; set; }
		
		/// <summary>
		/// رقم الطلب
		/// </summary>
		public int Request { get; set; }
		#endregion
	}
	#endregion

	#region Employee class definition
	/// <summary>
	/// المشترك
	/// </summary>
    [MetadataType(typeof(EmployeeMetaData))]
	public partial class Employee
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الاسم
		/// </summary>
		public string FirstName { get; set; }
		
		/// <summary>
		/// الشهرة
		/// </summary>
		public string LastName { get; set; }
		
		/// <summary>
		/// اسم الأب
		/// </summary>
		public string FatherName { get; set; }
		
		/// <summary>
		/// اسم الأم
		/// </summary>
		public string MotherName { get; set; }
		
		/// <summary>
		/// تاريخ الولادة
		/// </summary>
		public Nullable<DateTime> BirthDate { get; set; }

		/// <summary>
		/// التاريخ المتوقع للترك
		/// </summary>
		public Nullable<DateTime> ExpectedEndDate { get; set; }
		
		/// <summary>
		/// تاريخ المباشرة في المركز
		/// </summary>
		public Nullable<DateTime> CersStartDate { get; set; }
		
		/// <summary>
		/// تاريخ الانتساب إلى الصندوق
		/// </summary>
		public Nullable<DateTime> CfStartDate { get; set; }
		
		/// <summary>
		/// تاريخ الترك
		/// </summary>
		public Nullable<DateTime> LeaveDate { get; set; }
		
		/// <summary>
		/// سبب الترك
		/// </summary>
		public string LeaveReason { get; set; }
		
		/// <summary>
		/// الوضع الوظيفي
		/// </summary>
		public byte EmployeeStatus { get; set; }
		
		/// <summary>
		/// الفعالية
		/// </summary>
		public int Department { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// الهيئة الوظيفية
		/// </summary>
		public byte Category { get; set; }
		#endregion
	}
	#endregion

	#region EmployeeSeniority class definition
	/// <summary>
	/// الخدمة لغاية نهاية 2006
	/// </summary>
    [MetadataType(typeof(EmployeeSeniorityMetaData))]
	public partial class EmployeeSeniority
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// مجمل الخدمة بالأيام
		/// </summary>
		public short ServiceInDays { get; set; }
		#endregion
	}
	#endregion

	#region EmployeeStatus class definition
	/// <summary>
	/// الوضع الوظيفي
	/// </summary>
    [MetadataType(typeof(EmployeeStatusMetaData))]
	public partial class EmployeeStatus
	{
		#region Public properties
		/// <summary>
		/// معرف الوضع الوظيفي
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان الوضع الوظيفي
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public bool IsActive { get; set; }
		#endregion
	}
	#endregion

	#region EndWorkGrantBracket class definition
	/// <summary>
	/// نسبة الصرف لإعانة نهاية الخدمة
	/// </summary>
    [MetadataType(typeof(EndWorkGrantBracketMetaData))]
	public partial class EndWorkGrantBracket
	{
		#region Public properties
		/// <summary>
		/// من سنة
		/// </summary>
		public byte FromYear { get; set; }
		
		/// <summary>
		/// النسبة
		/// </summary>
		public decimal Percentage { get; set; }
		#endregion
	}
	#endregion

	#region ErrorDefinition class definition
	/// <summary>
	/// The original error message raised by the system
	/// </summary>
    [MetadataType(typeof(ErrorDefinitionMetaData))]
	public partial class ErrorDefinition
	{
		#region Public properties
		/// <summary>
		/// ErrorDefinition identifier
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// Original exception message 
		/// </summary>
		public string Message { get; set; }
		
		/// <summary>
		/// Localized Message
		/// </summary>
		public string LocalizedMessage { get; set; }
		
		/// <summary>
		/// An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.
		/// </summary>
		public string LikeExpression { get; set; }
		#endregion
	}
	#endregion

	#region EventCategory class definition
	/// <summary>
	/// Event Category
	/// </summary>
    [MetadataType(typeof(EventCategoryMetaData))]
	public partial class EventCategory
	{
		#region Public properties
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// EventCategory Name
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region EventLog class definition
	/// <summary>
	/// Event Log
	/// </summary>
    [MetadataType(typeof(EventLogMetaData))]
	public partial class EventLog
	{
		#region Public properties
		/// <summary>
		/// EventLog identifier
		/// </summary>
		public long Id { get; set; }
		
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int EventSource { get; set; }
		
		/// <summary>
		/// EventCategory identifier
		/// </summary>
		public int EventCategory { get; set; }
		
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int EventStatus { get; set; }
		
		/// <summary>
		/// EventLog XML formated parameters
		/// </summary>
		public string Parameters { get; set; }
		
		/// <summary>
		/// Date of the EventLog
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// User identifier
		/// </summary>
		public int User { get; set; }
		#endregion
	}
	#endregion

	#region EventLogError class definition
	/// <summary>
	/// EventLog details for an error
	/// </summary>
    [MetadataType(typeof(EventLogErrorMetaData))]
	public partial class EventLogError
	{
		#region Public properties
		/// <summary>
		/// EventLog identifier
		/// </summary>
		public long EventLog { get; set; }
		
		/// <summary>
		/// Error number
		/// </summary>
		public int Number { get; set; }
		
		/// <summary>
		/// Error descriptive message
		/// </summary>
		public string Message { get; set; }
		
		/// <summary>
		/// Full technical description about what is going wrong
		/// </summary>
		public string StackTrace { get; set; }
		#endregion
	}
	#endregion

	#region EventSource class definition
	/// <summary>
	/// Event source index
	/// </summary>
    [MetadataType(typeof(EventSourceMetaData))]
	public partial class EventSource
	{
		#region Public properties
		/// <summary>
		/// EventSource identifier
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// EventSource name
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region EventStatus class definition
	/// <summary>
	/// EventStatus index
	/// </summary>
    [MetadataType(typeof(EventStatusMetaData))]
	public partial class EventStatus
	{
		#region Public properties
		/// <summary>
		/// EventStatus identifier
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// EventStatus name
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// EventStatus icon
		/// </summary>
		public string Icon { get; set; }
		#endregion
	}
	#endregion

	#region ExceptionalAmount class definition
	/// <summary>
	/// المبالغ  المحسومة من صافي طلب سلفة أو المضافة إليه
	/// </summary>
    [MetadataType(typeof(ExceptionalAmountMetaData))]
	public partial class ExceptionalAmount
	{
		#region Public properties
		/// <summary>
		/// معرف المبلغ الاستثنائي
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم طلب السلفة
		/// </summary>
		public int LoanRequest { get; set; }
		
		/// <summary>
		/// مسلسل فرعي
		/// </summary>
		public decimal SubNumber { get; set; }
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// نوع المبلغ الاستثنائي
		/// </summary>
		public byte ExceptionalAmountType { get; set; }
		#endregion
	}
	#endregion

	#region ExceptionalAmountType class definition
	/// <summary>
	/// نوع المبلغ الاستثنائي
	/// </summary>
    [MetadataType(typeof(ExceptionalAmountTypeMetaData))]
	public partial class ExceptionalAmountType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المبلغ الاستثنائي
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان نوع المبلغ الاستثنائي
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// دخل؟
		/// </summary>
		public bool IsIncome { get; set; }
		#endregion
	}
	#endregion

	#region ExternalGrant class definition
	/// <summary>
	/// إعانة من خارج النظام
	/// </summary>
    [MetadataType(typeof(ExternalGrantMetaData))]
	public partial class ExternalGrant
	{
		#region Public properties
		/// <summary>
		/// معرف الإعانة
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public Nullable<DateTime> RequestDate { get; set; }
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public byte GrantType { get; set; }
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber { get; set; }
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate { get; set; }
		
		/// <summary>
		/// رقم قرار الدفع
		/// </summary>
		public Nullable<short> PaymentNumber { get; set; }
		
		/// <summary>
		/// تاريخ قرار الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Grant class definition
	/// <summary>
	/// الإعانة
	/// </summary>
    [MetadataType(typeof(GrantMetaData))]
	public partial class Grant
	{
		#region Public properties
		/// <summary>
		/// المنتج
		/// </summary>
		public int Product { get; set; }
		
		/// <summary>
		/// قرار المنح
		/// </summary>
		public int GrantDecision { get; set; }
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount { get; set; }
		#endregion
	}
	#endregion

	#region GrantDecision class definition
	/// <summary>
	/// قرار منح الإعانات
	/// </summary>
    [MetadataType(typeof(GrantDecisionMetaData))]
	public partial class GrantDecision
	{
		#region Public properties
		/// <summary>
		/// معرف قرار الإعانات
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// العام
		/// </summary>
		public short Year { get; set; }
		
		/// <summary>
		/// مجموعة أنواع القرارات
		/// </summary>
		public byte GrantTypeGroup { get; set; }
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber { get; set; }
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate { get; set; }
		
		/// <summary>
		/// مرجع أمر الصرف
		/// </summary>
		public string PaymentNumber { get; set; }
		
		/// <summary>
		/// تاريخ أمر الصرف
		/// </summary>
		public Nullable<DateTime> PaymentDate { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// مرجع جدول المقبوضات
		/// </summary>
		public string TableNumber { get; set; }
		
		/// <summary>
		/// تاريخ جدول المقبوضات
		/// </summary>
		public Nullable<DateTime> TableDate { get; set; }
		
		/// <summary>
		/// مرجع القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public string BaseNumber { get; set; }
		
		/// <summary>
		/// تاريخ القرار الإداري المنشئ لقرار الإعانة
		/// </summary>
		public Nullable<DateTime> BaseDate { get; set; }
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string AdditionalClause { get; set; }
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string AdditionalIntroduction { get; set; }
		#endregion
	}
	#endregion

	#region GrantDeduction class definition
	/// <summary>
	/// الحسم من الإعانة
	/// </summary>
    [MetadataType(typeof(GrantDeductionMetaData))]
	public partial class GrantDeduction
	{
		#region Public properties
		/// <summary>
		/// معرف الإعانة
		/// </summary>
		public int Grant { get; set; }
		
		/// <summary>
		/// مبلغ الحسم
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// بيان الحسم
		/// </summary>
		public string Description { get; set; }
		#endregion
	}
	#endregion

	#region GrantPayment class definition
	/// <summary>
	/// تفاصيل أمر الدفع لطلبات الإعانات
	/// </summary>
    [MetadataType(typeof(GrantPaymentMetaData))]
	public partial class GrantPayment
	{
		#region Public properties
		/// <summary>
		/// معرف دفع الإعانة
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم مستند الدفع
		/// </summary>
		public int GrantPaymentOrder { get; set; }
		
		/// <summary>
		/// الرقم المتسلسل للدفعة
		/// </summary>
		public byte SubNumber { get; set; }
		
		/// <summary>
		/// معرف الإعانة
		/// </summary>
		public int Grant { get; set; }
		
		/// <summary>
		/// المبلغ المدفوع
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GrantPaymentOrder class definition
	/// <summary>
	/// أمر دفع طلبات الإعانات
	/// </summary>
    [MetadataType(typeof(GrantPaymentOrderMetaData))]
	public partial class GrantPaymentOrder
	{
		#region Public properties
		/// <summary>
		/// معرف أمر دفع الإعانات
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم مستند الدفع
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// عام مستند الدفع
		/// </summary>
		public short Year { get; set; }
		
		/// <summary>
		/// تاريخ مستند الدفع
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GrantRequest class definition
	/// <summary>
	/// جدول طلبات الإعانات
	/// </summary>
    [MetadataType(typeof(GrantRequestMetaData))]
	public partial class GrantRequest
	{
		#region Public properties
		/// <summary>
		/// معرف طلب الإعانة
		/// </summary>
		public int Request { get; set; }
		
		/// <summary>
		/// نوع الإعانة
		/// </summary>
		public byte GrantType { get; set; }
		
		/// <summary>
		/// بيان الإعانة
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// تاريخ الواقعة
		/// </summary>
		public DateTime EventDate { get; set; }
		
		/// <summary>
		/// من فرع آخر؟
		/// </summary>
		public bool IsFromOtherBranch { get; set; }
		#endregion
	}
	#endregion

	#region GrantType class definition
	/// <summary>
	/// نوع الإعانة
	/// </summary>
    [MetadataType(typeof(GrantTypeMetaData))]
	public partial class GrantType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع الإعانة
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان نوع الإعانة
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// مبلغ الإعانة
		/// </summary>
		public Nullable<decimal> Amount { get; set; }
		
		/// <summary>
		/// مجموعة أنواع الإعانات
		/// </summary>
		public byte GrantTypeGroup { get; set; }
		#endregion
	}
	#endregion

	#region GrantTypeGroup class definition
	/// <summary>
	/// مجموعة أنواع الإعانات
	/// </summary>
    [MetadataType(typeof(GrantTypeGroupMetaData))]
	public partial class GrantTypeGroup
	{
		#region Public properties
		/// <summary>
		/// معرف مجموعة أنواع الإعانات
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان مجموعة أنواع الإعانات
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Guarantor class definition
	/// <summary>
	/// الكفيل
	/// </summary>
    [MetadataType(typeof(GuarantorMetaData))]
	public partial class Guarantor
	{
		#region Public properties
		/// <summary>
		/// معرف الكفيل
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// المنتج
		/// </summary>
		public int RefundableProduct { get; set; }
		
		/// <summary>
		/// مسلسل فرعي للكفيل
		/// </summary>
		public byte SubNumber { get; set; }
		
		/// <summary>
		/// الرقم الذاتي للكفيل
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// حالة الكفيل
		/// </summary>
		public byte GuarantorStatus { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GuarantorStatement class definition
	/// <summary>
	/// بيان راتب الكفيل
	/// </summary>
    [MetadataType(typeof(GuarantorStatementMetaData))]
	public partial class GuarantorStatement
	{
		#region Public properties
		/// <summary>
		/// معرف الكفيل
		/// </summary>
		public int Guarantor { get; set; }
		
		/// <summary>
		/// الدخل المقطوع
		/// </summary>
		public Nullable<decimal> GrossSalary { get; set; }
		
		/// <summary>
		/// الاستقطاعات
		/// </summary>
		public Nullable<decimal> DeductionsAmount { get; set; }
		
		/// <summary>
		/// الراتب المقبوض
		/// </summary>
		public Nullable<decimal> NetSalary { get; set; }
		
		/// <summary>
		/// المستحقات الطارئة
		/// </summary>
		public Nullable<decimal> ExceptionalIncome { get; set; }
		#endregion
	}
	#endregion

	#region GuarantorStatus class definition
	/// <summary>
	/// حالة الكفيل
	/// </summary>
    [MetadataType(typeof(GuarantorStatusMetaData))]
	public partial class GuarantorStatus
	{
		#region Public properties
		/// <summary>
		/// معرف حالة الكفيل
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان حالة الكفيل
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region HealthLoanDecision class definition
	/// <summary>
	/// قرار منح سلف علاجية
	/// </summary>
    [MetadataType(typeof(HealthLoanDecisionMetaData))]
	public partial class HealthLoanDecision
	{
		#region Public properties
		/// <summary>
		/// معرف القرار
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// عام القرار
		/// </summary>
		public short Year { get; set; }
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public Nullable<DateTime> Date { get; set; }
		
		/// <summary>
		/// رقم القرار المرجعي لدى المركز
		/// </summary>
		public string CersNumber { get; set; }
		
		/// <summary>
		/// تاريخ القرار المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate { get; set; }
		
		/// <summary>
		/// رقم قرار الدفع
		/// </summary>
		public string PaymentNumber { get; set; }
		
		/// <summary>
		/// تاريخ قرار الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region HealthLoanDecisionFirstPayment class definition
	/// <summary>
	/// السلفة العلاجية المسبقة
	/// </summary>
    [MetadataType(typeof(HealthLoanDecisionFirstPaymentMetaData))]
	public partial class HealthLoanDecisionFirstPayment
	{
		#region Public properties
		/// <summary>
		/// معرف السلفة العلاجية المسبقة
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// تاريخ الدفعة
		/// </summary>
		public DateTime PaymentDate { get; set; }
		
		/// <summary>
		/// مبلغ الدفعة
		/// </summary>
		public Nullable<decimal> PaymentAmount { get; set; }
		
		/// <summary>
		/// ملاحظات الدفعة
		/// </summary>
		public string PaymentNotes { get; set; }
		
		/// <summary>
		/// تاريخ الفاتورة
		/// </summary>
		public Nullable<DateTime> InvoiceDate { get; set; }
		
		/// <summary>
		/// مبلغ الفاتورة
		/// </summary>
		public Nullable<decimal> InvoiceAmount { get; set; }
		
		/// <summary>
		/// ملاحظات الفاتورة
		/// </summary>
		public string InvoiceNotes { get; set; }
		
		/// <summary>
		/// تاريخ قبض مبلغ التأمين الصحي
		/// </summary>
		public Nullable<DateTime> InsuranceDate { get; set; }
		
		/// <summary>
		/// مبلغ التأمين الصحي
		/// </summary>
		public Nullable<decimal> InsuranceAmount { get; set; }
		
		/// <summary>
		/// معرف طريقة قبض التأمين
		/// </summary>
		public Nullable<byte> InsuranceType { get; set; }
		
		/// <summary>
		/// ملاحظات التأمين الصحي
		/// </summary>
		public string InsuranceNotes { get; set; }
		
		/// <summary>
		/// تاريخ قبض مبلغ اللجنة الطبية
		/// </summary>
		public Nullable<DateTime> BoardDate { get; set; }
		
		/// <summary>
		/// مبلغ اللجنة الطبية
		/// </summary>
		public Nullable<decimal> BoardAmount { get; set; }
		
		/// <summary>
		/// نقداً=1   تحويل=2        طريقة قبض اللجنة الطبية
		/// </summary>
		public Nullable<byte> BoardType { get; set; }
		
		/// <summary>
		/// ملاحظات اللجنة الطبية
		/// </summary>
		public string BoardNotes { get; set; }
		
		/// <summary>
		/// تاريخ قبض مبلغ السداد المباشر
		/// </summary>
		public Nullable<DateTime> DirectPaymentDate { get; set; }
		
		/// <summary>
		/// مبلغ السداد المباشر
		/// </summary>
		public Nullable<decimal> DirectPaymentAmount { get; set; }
		
		/// <summary>
		/// ملاحظات السداد المباشر
		/// </summary>
		public string DirectPaymentNotes { get; set; }
		
		/// <summary>
		/// الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4
		/// </summary>
		public Nullable<byte> PaymentStatus { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// مكان العمل
		/// </summary>
		public Nullable<int> Department { get; set; }
		
		/// <summary>
		/// رقم قرار التسليف
		/// </summary>
		public Nullable<int> HealthLoanDecision { get; set; }
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public Nullable<decimal> RequestCost { get; set; }
		
		/// <summary>
		/// معرف طلب السلفة
		/// </summary>
		public Nullable<int> LoanRequest { get; set; }
		#endregion
	}
	#endregion

	#region IncomingLoan class definition
	/// <summary>
	/// سلفة منقولة إلى الفرع
	/// </summary>
    [MetadataType(typeof(IncomingLoanMetaData))]
	public partial class IncomingLoan
	{
		#region Public properties
		/// <summary>
		/// رقم بطاقة السلف المحولة
		/// </summary>
		public int Loan { get; set; }
		
		/// <summary>
		/// الفرع المنقولة منه السلفة
		/// </summary>
		public int MainWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region Installment class definition
	/// <summary>
	/// القسط الشهري
	/// </summary>
    [MetadataType(typeof(InstallmentMetaData))]
	public partial class Installment
	{
		#region Public properties
		/// <summary>
		/// معرف القسط
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int RefundableProduct { get; set; }
		
		/// <summary>
		/// مسلسل القسط
		/// </summary>
		public short SubNumber { get; set; }
		
		/// <summary>
		/// تاريخ الاستحقاق
		/// </summary>
		public DateTime DueDate { get; set; }
		
		/// <summary>
		/// رأس المال ضمن القسط
		/// </summary>
		public decimal DueCapital { get; set; }
		
		/// <summary>
		/// الأرباح ضمن القسط
		/// </summary>
		public decimal DueProfit { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InstallmentDecrease class definition
	/// <summary>
	///  تخفيض القسط الشهري
	/// </summary>
    [MetadataType(typeof(InstallmentDecreaseMetaData))]
	public partial class InstallmentDecrease
	{
		#region Public properties
		/// <summary>
		/// معرف تخفيض القسط الشهري
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم الكتاب الداخلي
		/// </summary>
		public int InstallmentDecreaseOrder { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// الفعالية
		/// </summary>
		public Nullable<int> Department { get; set; }
		
		/// <summary>
		/// مقدار التخفيض على القسط
		/// </summary>
		public decimal DecreaseAmount { get; set; }
		
		/// <summary>
		/// القيمة الجديدة للقسط
		/// </summary>
		public decimal NewInstallmentAmount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InstallmentDecreaseOrder class definition
	/// <summary>
	/// كتاب تخفيض الأقساط الشهرية
	/// </summary>
    [MetadataType(typeof(InstallmentDecreaseOrderMetaData))]
	public partial class InstallmentDecreaseOrder
	{
		#region Public properties
		/// <summary>
		/// رقم الكتاب الداخلي
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الشهر الجاري توزيعه عند إنشاء الكتاب
		/// </summary>
		public DateTime Month { get; set; }
		
		/// <summary>
		/// مرجع الكتاب في المركز
		/// </summary>
		public string CersNumber { get; set; }
		
		/// <summary>
		/// تاريخ الكتاب في المركز
		/// </summary>
		public Nullable<DateTime> CersDate { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InsuranceType class definition
	/// <summary>
	/// طريقة قبض التأمين
	/// </summary>
    [MetadataType(typeof(InsuranceTypeMetaData))]
	public partial class InsuranceType
	{
		#region Public properties
		/// <summary>
		/// معرف طريقة القبض
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان طريقة قبض التأمين
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Issuer class definition
	/// <summary>
	/// الجهة المصدرة للمديونية
	/// </summary>
    [MetadataType(typeof(IssuerMetaData))]
	public partial class Issuer
	{
		#region Public properties
		/// <summary>
		/// معرف الجهة المصدرة للمديونية
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان الجهة المصدرة للمديونية
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Loan class definition
	/// <summary>
	/// بطاقة السلفة
	/// </summary>
    [MetadataType(typeof(LoanMetaData))]
	public partial class Loan
	{
		#region Public properties
		/// <summary>
		/// معرف السلفة
		/// </summary>
		public int Product { get; set; }
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int LoanDecision { get; set; }
		
		/// <summary>
		/// نوع السلفة
		/// </summary>
		public short LoanType { get; set; }
		
		/// <summary>
		/// حالة توليد البطاقة
		/// </summary>
		public byte LoanGenerationStatus { get; set; }
		
		/// <summary>
		/// حالة البطاقة
		/// </summary>
		public byte LoanStatus { get; set; }
		#endregion
	}
	#endregion

	#region LoanChange class definition
	/// <summary>
	/// نقل السلفة
	/// </summary>
    [MetadataType(typeof(LoanChangeMetaData))]
	public partial class LoanChange
	{
		#region Public properties
		/// <summary>
		/// معرف بطاقة السلفة الجديدة
		/// </summary>
		public int Loan { get; set; }
		
		/// <summary>
		/// معرف بطاقة السلفة المنقولة
		/// </summary>
		public int FromLoan { get; set; }
		#endregion
	}
	#endregion

	#region LoanDecision class definition
	/// <summary>
	/// قرار منح السلف
	/// </summary>
    [MetadataType(typeof(LoanDecisionMetaData))]
	public partial class LoanDecision
	{
		#region Public properties
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// رقم القرار
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// العام
		/// </summary>
		public short Year { get; set; }
		
		/// <summary>
		/// تاريخ القرار
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// تاريخ بداية الأقساط
		/// </summary>
		public DateTime DeductionStartDate { get; set; }
		
		/// <summary>
		/// الرقم المرجعي لدى المركز
		/// </summary>
		public string CersNumber { get; set; }
		
		/// <summary>
		/// التاريخ المرجعي لدى المركز
		/// </summary>
		public Nullable<DateTime> CersDate { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// نوع القرار
		/// </summary>
		public byte LoanDecisionType { get; set; }
		
		/// <summary>
		/// مرجع أمر الدفع
		/// </summary>
		public string PaymentNumber { get; set; }
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate { get; set; }
		
		/// <summary>
		/// الدفع من الرواتب  NO=0; YES=1
		/// </summary>
		public Nullable<bool> IsPaidFromSalary { get; set; }
		
		/// <summary>
		/// سبب إصدار القرار
		/// </summary>
		public string Reason { get; set; }
		
		/// <summary>
		/// مادة إضافية
		/// </summary>
		public string AdditionalClause { get; set; }
		
		/// <summary>
		/// حيثية إضافية
		/// </summary>
		public string AdditionalIntroduction { get; set; }
		#endregion
	}
	#endregion

	#region LoanDecisionType class definition
	/// <summary>
	/// نوع قرار السلف
	/// </summary>
    [MetadataType(typeof(LoanDecisionTypeMetaData))]
	public partial class LoanDecisionType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع قرار السلف
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان نوع قرار السلف
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanGenerationStatus class definition
	/// <summary>
	/// حالة توليد بطاقة السلفة
	/// </summary>
    [MetadataType(typeof(LoanGenerationStatusMetaData))]
	public partial class LoanGenerationStatus
	{
		#region Public properties
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان حالة توليد البطاقة
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanRequest class definition
	/// <summary>
	/// طلب السلفة
	/// </summary>
    [MetadataType(typeof(LoanRequestMetaData))]
	public partial class LoanRequest
	{
		#region Public properties
		/// <summary>
		/// معرف طلب السلفة
		/// </summary>
		public int Request { get; set; }
		
		/// <summary>
		/// صافي الدخل
		/// </summary>
		public decimal NetIncome { get; set; }
		
		/// <summary>
		/// الحسميات
		/// </summary>
		public decimal TotalDeduction { get; set; }
		#endregion
	}
	#endregion

	#region LoanStatus class definition
	/// <summary>
	/// حالة بطاقة السلفة
	/// </summary>
    [MetadataType(typeof(LoanStatusMetaData))]
	public partial class LoanStatus
	{
		#region Public properties
		/// <summary>
		/// معرف حالة البطاقة
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان حالة البطاقة
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanType class definition
	/// <summary>
	/// نوع السلفة
	/// </summary>
    [MetadataType(typeof(LoanTypeMetaData))]
	public partial class LoanType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع السلفة
		/// </summary>
		public short ProductType { get; set; }
		#endregion
	}
	#endregion

	#region LoanTypeClosure class definition
	/// <summary>
	/// الإغلاق الآلي للسلف وفق أنواعها
	/// </summary>
    [MetadataType(typeof(LoanTypeClosureMetaData))]
	public partial class LoanTypeClosure
	{
		#region Public properties
		/// <summary>
		/// معرف آلية إغلاق السلف
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// نوع السلف المغلَقة
		/// </summary>
		public short LoanType { get; set; }
		
		/// <summary>
		/// نوع السلفة التي تؤدي إلى الإغلاق
		/// </summary>
		public short ClosingLoanType { get; set; }
		#endregion
	}
	#endregion

	#region MainWorkPlace class definition
	/// <summary>
	/// مكان العمل الرئيسي
	/// </summary>
    [MetadataType(typeof(MainWorkPlaceMetaData))]
	public partial class MainWorkPlace
	{
		#region Public properties
		/// <summary>
		/// معرف مكان العمل الرئيسي
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// بيان مكان العمل الرئيسي
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region MissingInstallmentDecrease class definition
	/// <summary>
	/// حالة عدم إنشاء كتاب تخفيض القسط الشهري
	/// </summary>
    [MetadataType(typeof(MissingInstallmentDecreaseMetaData))]
	public partial class MissingInstallmentDecrease
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي للمشترك
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// المبلغ المحول من الرواتب
		/// </summary>
		public decimal SalaryAmount { get; set; }
		
		/// <summary>
		/// شهر التحويل
		/// </summary>
		public DateTime TransferMonth { get; set; }
		
		/// <summary>
		/// قيمة الأقساط المنتهية
		/// </summary>
		public decimal FinishedInstallmentsAmount { get; set; }
		
		/// <summary>
		/// قيمة الأقساط المتبقية
		/// </summary>
		public decimal RemainingInstallmentsAmount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region MonthlyBalance class definition
	/// <summary>
	/// الرصيد الشهري
	/// </summary>
    [MetadataType(typeof(MonthlyBalanceMetaData))]
	public partial class MonthlyBalance
	{
		#region Public properties
		/// <summary>
		/// معرف الرصيد الشهري
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// مجموعة الدفع
		/// </summary>
		public byte PaymentGroup { get; set; }
		
		/// <summary>
		/// الشهر
		/// </summary>
		public DateTime Month { get; set; }
		
		/// <summary>
		/// الرصيد الافتتاحي
		/// </summary>
		public decimal Opening { get; set; }
		
		/// <summary>
		/// مجموع السلف الممنوحة النظامية
		/// </summary>
		public decimal NormalLoans { get; set; }
		
		/// <summary>
		/// قيمة السلف المحولة إلى المشترك
		/// </summary>
		public decimal IncomingLoans { get; set; }
		
		/// <summary>
		/// المبلغ المدفوع نقداً للمشترك
		/// </summary>
		public decimal Restitution { get; set; }
		
		/// <summary>
		/// قيمة السلف المحولة من المشترك
		/// </summary>
		public decimal OutgoingLoans { get; set; }
		
		/// <summary>
		/// تحويلات الرواتب
		/// </summary>
		public decimal SalaryPayment { get; set; }
		
		/// <summary>
		/// الدفعات النقدية
		/// </summary>
		public decimal CashPayment { get; set; }
		#endregion
	}
	#endregion

	#region OutgoingLoan class definition
	/// <summary>
	/// سلفة منقولة من الفرع
	/// </summary>
    [MetadataType(typeof(OutgoingLoanMetaData))]
	public partial class OutgoingLoan
	{
		#region Public properties
		/// <summary>
		/// رقم بطاقة السلف المحولة
		/// </summary>
		public int Loan { get; set; }
		
		/// <summary>
		/// قرار منح السلف
		/// </summary>
		public int LoanDecision { get; set; }
		
		/// <summary>
		/// مكان العمل الرئيسي المحولة إليه
		/// </summary>
		public int MainWorkPlace { get; set; }
		
		/// <summary>
		/// المبلغ الإجمالي المنقول
		/// </summary>
		public decimal ApprovedAmount { get; set; }
		
		/// <summary>
		/// الصافي المنقول
		/// </summary>
		public decimal NetAmount { get; set; }
		
		/// <summary>
		/// العوائد الربحية المنقولة
		/// </summary>
		public decimal ProfitAmount { get; set; }
		#endregion
	}
	#endregion

	#region Payment class definition
	/// <summary>
	/// حركة السداد
	/// </summary>
    [MetadataType(typeof(PaymentMetaData))]
	public partial class Payment
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// تاريخ السداد
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// مجموعة أنواع الدفع
		/// </summary>
		public byte PaymentGroup { get; set; }
		
		/// <summary>
		/// مبلغ السداد
		/// </summary>
		public Nullable<decimal> Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// حالة السداد
		/// </summary>
		public Nullable<byte> PaymentStatus { get; set; }
		
		/// <summary>
		/// أمر القبض
		/// </summary>
		public Nullable<int> CollectOrder { get; set; }
		#endregion
	}
	#endregion

	#region PaymentGroup class definition
	/// <summary>
	/// مجموعة الدفع
	/// </summary>
    [MetadataType(typeof(PaymentGroupMetaData))]
	public partial class PaymentGroup
	{
		#region Public properties
		/// <summary>
		/// معرف مجموعة الدفع
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان مجموعة الدفع
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region PaymentStatus class definition
	/// <summary>
	/// حالة السداد
	/// </summary>
    [MetadataType(typeof(PaymentStatusMetaData))]
	public partial class PaymentStatus
	{
		#region Public properties
		/// <summary>
		/// معرف حالة السداد
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان حالة السداد
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region PayOrder class definition
	/// <summary>
	/// أمر الدفع
	/// </summary>
    [MetadataType(typeof(PayOrderMetaData))]
	public partial class PayOrder
	{
		#region Public properties
		/// <summary>
		/// معرف أمر الدفع
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// رقم البيان
		/// </summary>
		public short Number { get; set; }
		
		/// <summary>
		/// تاريخ البيان
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// رقم الإشعار
		/// </summary>
		public Nullable<short> VoucherNumber { get; set; }
		
		/// <summary>
		/// تاريخ الإشعار
		/// </summary>
		public Nullable<DateTime> VoucherDate { get; set; }
		
		/// <summary>
		/// رقم أمر الدفع
		/// </summary>
		public Nullable<short> PaymentNumber { get; set; }
		
		/// <summary>
		/// تاريخ أمر الدفع
		/// </summary>
		public Nullable<DateTime> PaymentDate { get; set; }
		
		/// <summary>
		/// رقم سند القيد المحاسبي
		/// </summary>
		public Nullable<short> AccountingDocumentNumber { get; set; }
		
		/// <summary>
		/// تاريخ سند القيد المحاسبي
		/// </summary>
		public Nullable<DateTime> AccountingDocumentDate { get; set; }
		
		/// <summary>
		/// مجموعة الدفع
		/// </summary>
		public byte PaymentGroup { get; set; }
		
		/// <summary>
		/// المبلغ للدفع
		/// </summary>
		public decimal PaidAmount { get; set; }
		
		/// <summary>
		/// عوائد ربحية؟
		/// </summary>
		public bool IsProfit { get; set; }
		
		/// <summary>
		/// تم تثبيت الدفع؟
		/// </summary>
		public byte IsFixed { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Product class definition
	/// <summary>
	/// المنتج
	/// </summary>
    [MetadataType(typeof(ProductMetaData))]
	public partial class Product
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// نوع المنتج
		/// </summary>
		public short ProductType { get; set; }
		
		/// <summary>
		/// قيمة المنتج
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region ProductType class definition
	/// <summary>
	/// نوع المنتج
	/// </summary>
    [MetadataType(typeof(ProductTypeMetaData))]
	public partial class ProductType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع المنتج
		/// </summary>
		public short Id { get; set; }
		
		/// <summary>
		/// بيان نوع المنتج
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// سعر الفائدة
		/// </summary>
		public Nullable<decimal> Rate { get; set; }
		
		/// <summary>
		/// عدد الكفلاء اللازم
		/// </summary>
		public byte GuarantorsCount { get; set; }
		
		/// <summary>
		/// رقم الحساب
		/// </summary>
		public string AccountNumber { get; set; }
		
		/// <summary>
		/// بيان المادة ضمن طباعة القرار
		/// </summary>
		public string PrintLabel { get; set; }
		
		/// <summary>
		/// آلية حساب العوائد الربحية
		/// </summary>
		public Nullable<byte> ProfitStrategy { get; set; }
		
		/// <summary>
		/// مجموعة الدفع
		/// </summary>
		public Nullable<byte> PaymentGroup { get; set; }
		
		/// <summary>
		/// مفعل؟
		/// </summary>
		public Nullable<bool> IsActive { get; set; }
		#endregion
	}
	#endregion

	#region ProductTypeAvailability class definition
	/// <summary>
	/// القيود على نوع منتج
	/// </summary>
    [MetadataType(typeof(ProductTypeAvailabilityMetaData))]
	public partial class ProductTypeAvailability
	{
		#region Public properties
		/// <summary>
		/// معرف القيد
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// نوع المنتج
		/// </summary>
		public short ProductType { get; set; }
		
		/// <summary>
		/// قاعدة الاستخدام
		/// </summary>
		public short Availability { get; set; }
		#endregion
	}
	#endregion

	#region Profile class definition
	/// <summary>
	/// معلومات تفصيلية عن المشترك
	/// </summary>
    [MetadataType(typeof(ProfileMetaData))]
	public partial class Profile
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// رقم هاتف العمل
		/// </summary>
		public string Extension { get; set; }
		
		/// <summary>
		/// رقم المنزل
		/// </summary>
		public string HomePhone { get; set; }
		
		/// <summary>
		/// رقم الهاتف الخلوي
		/// </summary>
		public string MobilePhone { get; set; }
		
		/// <summary>
		/// العنوان
		/// </summary>
		public string Address { get; set; }
		#endregion
	}
	#endregion

	#region ProfitStrategy class definition
	/// <summary>
	/// آلية حساب العوائد الربحية
	/// </summary>
    [MetadataType(typeof(ProfitStrategyMetaData))]
	public partial class ProfitStrategy
	{
		#region Public properties
		/// <summary>
		/// معرف آلية حساب العوائد الربحية
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان آلية حساب العوائد الربحية
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region RefundableProduct class definition
	/// <summary>
	/// المنتج الواجب السداد
	/// </summary>
    [MetadataType(typeof(RefundableProductMetaData))]
	public partial class RefundableProduct
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int Product { get; set; }
		
		/// <summary>
		/// مدة التسديد بالأشهر
		/// </summary>
		public short PaymentPeriod { get; set; }
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment { get; set; }
		
		/// <summary>
		/// صافي المبلغ المستحق
		/// </summary>
		public decimal NetAmount { get; set; }
		
		/// <summary>
		/// العوائد الربحية
		/// </summary>
		public decimal ProfitAmount { get; set; }
		
		/// <summary>
		/// كسور الليرات
		/// </summary>
		public decimal SyrianPoundRounds { get; set; }
		#endregion
	}
	#endregion

	#region Request class definition
	/// <summary>
	/// طلب الحصول على منتج
	/// </summary>
    [MetadataType(typeof(RequestMetaData))]
	public partial class Request
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public int Product { get; set; }
		
		/// <summary>
		/// تاريخ الطلب
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// المبلغ
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// المرفقات
		/// </summary>
		public string Attachment { get; set; }
		
		/// <summary>
		/// قيمة الطلب
		/// </summary>
		public decimal Cost { get; set; }
		
		/// <summary>
		/// حالة الطلب
		/// </summary>
		public Nullable<byte> RequestStatus { get; set; }
		
		/// <summary>
		/// حالة تجاوز الشروط
		/// </summary>
		public int BypassStatus { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region RequestStatus class definition
	/// <summary>
	/// حالة طلب الحصول على منتج
	/// </summary>
    [MetadataType(typeof(RequestStatusMetaData))]
	public partial class RequestStatus
	{
		#region Public properties
		/// <summary>
		/// معرف حالة طلب الحصول على منتج
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان حالة طلب الحصول على منتج
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Resource class definition
	/// <summary>
	/// مورد
	/// </summary>
    [MetadataType(typeof(ResourceMetaData))]
	public partial class Resource
	{
		#region Public properties
		/// <summary>
		/// معرف المورد
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// اللغة
		/// </summary>
		public string Language { get; set; }
		
		/// <summary>
		/// الوحدة
		/// </summary>
		public string Module { get; set; }
		
		/// <summary>
		/// المفتاح
		/// </summary>
		public string Key { get; set; }
		
		/// <summary>
		/// القيمة
		/// </summary>
		public string Value { get; set; }
		
		/// <summary>
		/// قابل للتعديل؟
		/// </summary>
		public bool IsEditable { get; set; }
		#endregion
	}
	#endregion

	#region SalaryPayment class definition
	/// <summary>
	/// القسط الشهري من الراتب
	/// </summary>
    [MetadataType(typeof(SalaryPaymentMetaData))]
	public partial class SalaryPayment
	{
		#region Public properties
		/// <summary>
		/// معرف حركة السداد
		/// </summary>
		public int Payment { get; set; }
		
		/// <summary>
		/// الفعالية
		/// </summary>
		public int Department { get; set; }
		
		/// <summary>
		/// الرصيد المستورد
		/// </summary>
		public Nullable<decimal> Balance { get; set; }
		#endregion
	}
	#endregion

	#region SalaryWorkPlace class definition
	/// <summary>
	/// جهة صرف الراتب
	/// </summary>
    [MetadataType(typeof(SalaryWorkPlaceMetaData))]
	public partial class SalaryWorkPlace
	{
		#region Public properties
		/// <summary>
		/// معرف جهة صرف الراتب
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// بيان جهة صرف الراتب
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// مكان العمل الرئيسي
		/// </summary>
		public int MainWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region ServiceEndGrantRequest class definition
	/// <summary>
	/// طلب إعانة نهاية الخدمة
	/// </summary>
    [MetadataType(typeof(ServiceEndGrantRequestMetaData))]
	public partial class ServiceEndGrantRequest
	{
		#region Public properties
		/// <summary>
		/// معرف الطلب
		/// </summary>
		public int GrantRequest { get; set; }
		
		/// <summary>
		/// متوسط الدخل الشهري
		/// </summary>
		public decimal AverageIncome { get; set; }
		
		/// <summary>
		/// نسبة الصرف
		/// </summary>
		public decimal GrantPercentage { get; set; }
		
		/// <summary>
		/// عدد أشهر الخدمة
		/// </summary>
		public short ServiceInMonthes { get; set; }
		#endregion
	}
	#endregion

	#region Settlement class definition
	/// <summary>
	/// سداد الأقساط
	/// </summary>
    [MetadataType(typeof(SettlementMetaData))]
	public partial class Settlement
	{
		#region Public properties
		/// <summary>
		/// معرف السداد
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// القسط
		/// </summary>
		public int Installment { get; set; }
		
		/// <summary>
		/// الدفعة
		/// </summary>
		public int Payment { get; set; }
		
		/// <summary>
		/// المبلغ المسدد
		/// </summary>
		public decimal Amount { get; set; }
		#endregion
	}
	#endregion

	#region SpecialCaseLoan class definition
	/// <summary>
	/// سلفة خاصة من خارج النظام
	/// </summary>
    [MetadataType(typeof(SpecialCaseLoanMetaData))]
	public partial class SpecialCaseLoan
	{
		#region Public properties
		/// <summary>
		/// معرف السلفة الخاصة
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// تاريخ السلفة
		/// </summary>
		public DateTime Date { get; set; }
		
		/// <summary>
		/// نوع السلف
		/// </summary>
		public short LoanType { get; set; }
		
		/// <summary>
		/// المبلغ الممنوح
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Subscription class definition
	/// <summary>
	/// الاشتراك الشهري
	/// </summary>
    [MetadataType(typeof(SubscriptionMetaData))]
	public partial class Subscription
	{
		#region Public properties
		/// <summary>
		/// معرف الاشتراك
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// التاريخ
		/// </summary>
		public DateTime Month { get; set; }
		
		/// <summary>
		/// الفعالية
		/// </summary>
		public int Department { get; set; }
		
		/// <summary>
		/// نوع الاشتراك
		/// </summary>
		public byte SubscriptionType { get; set; }
		
		/// <summary>
		/// مبلغ الاشتراك
		/// </summary>
		public decimal Amount { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// مثبت؟
		/// </summary>
		public bool IsFixed { get; set; }
		#endregion
	}
	#endregion

	#region SubscriptionType class definition
	/// <summary>
	/// نوع الاشتراك
	/// </summary>
    [MetadataType(typeof(SubscriptionTypeMetaData))]
	public partial class SubscriptionType
	{
		#region Public properties
		/// <summary>
		/// معرف نوع الاشتراك
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		/// بيان نوع الاشتراك
		/// </summary>
		public string Name { get; set; }
		#endregion
	}
	#endregion

	#region TransitoryIncomingLoan class definition
	/// <summary>
	/// جدول إدخالات السلف المنقولة من فرع قبل القرار. عند إصدار قرار السلف يتم حذف بيانات هذا الجدول
	/// </summary>
    [MetadataType(typeof(TransitoryIncomingLoanMetaData))]
	public partial class TransitoryIncomingLoan
	{
		#region Public properties
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// الفرع المنقولة منه السلفة
		/// </summary>
		public int MainWorkPlace { get; set; }
		
		/// <summary>
		/// السلفة الممنوحة
		/// </summary>
		public decimal ApprovedAmount { get; set; }
		
		/// <summary>
		/// القسط الشهري
		/// </summary>
		public decimal Installment { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		
		/// <summary>
		/// الحالة  non:0; verified:1; to be deleted:2
		/// </summary>
		public bool IsVerified { get; set; }
		#endregion
	}
	#endregion

	#region Warrant class definition
	/// <summary>
	/// كفيل المديونية
	/// </summary>
    [MetadataType(typeof(WarrantMetaData))]
	public partial class Warrant
	{
		#region Public properties
		/// <summary>
		/// معرف كفيل المديونية
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// معرف المديونية
		/// </summary>
		public int Debt { get; set; }
		
		/// <summary>
		/// الرقم الذاتي
		/// </summary>
		public int Employee { get; set; }
		
		/// <summary>
		/// الكفالة فعالة؟
		/// </summary>
		public bool IsActive { get; set; }
		
		/// <summary>
		/// ملاحظات
		/// </summary>
		public string Notes { get; set; }
		#endregion
	}
	#endregion
}
