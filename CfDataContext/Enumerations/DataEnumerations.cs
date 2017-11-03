using System;

namespace Cf.Data
{
	/// <summary>
	/// حالة تجاوز شروط الحصول على المنتج
	/// </summary>
	[Flags()]
	public enum BypassStatusEnum
	{
		/// <summary>
		/// الدفعات السابقة
		/// </summary>
		PreviousLoans = 1,
		/// <summary>
		/// عدد أشهر الاشتراك
		/// </summary>
		SubscriptionMonths = 2,
		/// <summary>
		/// السقف
		/// </summary>
		Ceiling = 4
	}

	/// <summary>
	/// الهيئة الوظيفية
	/// </summary>
	public enum CategoryEnum
	{
        /// <summary>
		/// (غير محددة)
		/// </summary>
		None = 0,
		/// <summary>
		/// هيئة بحث
		/// </summary>
		Research = 1,
		/// <summary>
		/// هيئة فنية
		/// </summary>
		Technical = 2,
		/// <summary>
		/// هيئة مخبرية
		/// </summary>
		Laboratory = 3,
		/// <summary>
		/// قانون عاملين
		/// </summary>
		WorkerLaw = 4
	}

	/// <summary>
	/// الوضع الوظيفي
	/// </summary>
	public enum EmployeeStatusEnum
	{
        /// <summary>
		/// (غير محدد)
		/// </summary>
		None = 0,
		/// <summary>
		/// على رأس عمله
		/// </summary>
		Working = 1,
		/// <summary>
		/// مندب
		/// </summary>
		OutOfCers = 2,
		/// <summary>
		/// استيداع
		/// </summary>
		TemporarlyLeaving = 3,
		/// <summary>
		/// خدمة علم
		/// </summary>
		OnMilitaryService = 4,
		/// <summary>
		/// موفد خارجي
		/// </summary>
		External = 5,
		/// <summary>
		/// موفد داخلي
		/// </summary>
		Internal = 6,
		/// <summary>
		/// تارك
		/// </summary>
		Leaving = 8,
		/// <summary>
		/// عسكري
		/// </summary>
		Militery = 9,
		/// <summary>
		/// دورة خارج المركز
		/// </summary>
		OutsideCourse = 10,
		/// <summary>
		/// منتدب إدارة
		/// </summary>
		Delegate = 11,
		/// <summary>
		/// كف يد
		/// </summary>
		Forbidden = 12,
		/// <summary>
		/// ناكل
		/// </summary>
		Breaker = 13
	}

	/// <summary>
	/// نوع الإعانة
	/// </summary>
	public enum GrantTypeEnum
	{
		/// <summary>
		/// زواج
		/// </summary>
		Marriage = 1,
		/// <summary>
		/// ولادة
		/// </summary>
		NewlyBorn = 2,
		/// <summary>
		/// وفاة زوج
		/// </summary>
		DeathOfPartner = 3,
		/// <summary>
		/// وفاة ولد
		/// </summary>
		DeathOfChild = 4,
		/// <summary>
		/// وفاة احد الوالدين (الأب)
		/// </summary>
		DeathOfFather = 5,
		/// <summary>
		/// وفاة المشترك الطبيعية
		/// </summary>
		NaturalDeath = 6,
		/// <summary>
		/// وفاة المشترك الناجمة عن الخدمة
		/// </summary>
		ServiceDeath = 7,
		/// <summary>
		/// عجز كلي
		/// </summary>
		TotalDisability = 8,
		/// <summary>
		/// عجز جزئي
		/// </summary>
		PartialDisability = 9,
		/// <summary>
		/// أضرار مادية
		/// </summary>
		MaterialInjury = 10,
		/// <summary>
		/// نهاية خدمة
		/// </summary>
		EndOfService = 11,
		/// <summary>
		/// وفاة احد الوالدين (الأم)
		/// </summary>
		DeathOfMother = 12,
		/// <summary>
		/// ولادة حالة التوأم (الولد الثاني)
		/// </summary>
		TwinsSecondChild = 13
    }

	/// <summary>
	/// مجموعة أنواع الإعانات
	/// </summary>
	public enum GrantTypeGroupEnum
	{
		/// <summary>
		/// أحوال مدنية
		/// </summary>
		Civil = 1,
		/// <summary>
		/// أضار مادية
		/// </summary>
		MaterialInjury = 2,
		/// <summary>
		/// ناجمة عن الخدمة
		/// </summary>
		ResultingFromService = 3,
		/// <summary>
		/// نهاية خدمة
		/// </summary>
		EndOfService = 4,
		/// <summary>
		/// وفاة طبيعة
		/// </summary>
		NaturalDeath = 5
	}

	/// <summary>
	/// حالة الكفيل
	/// </summary>
	public enum GuarantorStatusEnum
	{
		/// <summary>
		/// Temporal
		/// </summary>
		Temporal = 0,
		/// <summary>
		/// جديد
		/// </summary>
		New = 1,
		/// <summary>
		/// قيد الدراسة
		/// </summary>
		UnderStudy = 2,
		/// <summary>
		/// مقبول
		/// </summary>
		Accepted = 3,
		/// <summary>
		/// مرفوض
		/// </summary>
		Rejected = 4,
		/// <summary>
		/// كفالة نشطة
		/// </summary>
		Active = 5,
		/// <summary>
		/// كفالة ملغاة
		/// </summary>
		Canceled = 6
	}

	/// <summary>
	/// طريقة قبض التأمين
	/// </summary>
	public enum InsuranceTypeEnum
	{
		/// <summary>
		/// نقداً
		/// </summary>
		Cash = 1,
		/// <summary>
		/// تحويل
		/// </summary>
		Transfer = 2
	}

	/// <summary>
	/// نوع قرار السلف
	/// </summary>
	public enum LoanDecisionTypeEnum
	{
		/// <summary>
		/// عادي
		/// </summary>
		Normal = 1,
		/// <summary>
		/// نقل إلى مشرك آخر
		/// </summary>
		ChangeSubscriber = 2,
		/// <summary>
		/// نقل إلى فرع آخر
		/// </summary>
		OutgoingToOtherBranch = 3,
		/// <summary>
		/// نقل من فرع آخر
		/// </summary>
		IncommingFromOtherBranch = 4,
		/// <summary>
		/// نقل إلى كفيل
		/// </summary>
		ChangeToGuarantor = 5
	}

	/// <summary>
	/// حالة توليد بطاقة السلفة
	/// </summary>
	public enum LoanGenerationStatusEnum
	{
		/// <summary>
		/// طلب سلفة
		/// </summary>
		LoanRequest = 0,
		/// <summary>
		/// أرصدة 2010
		/// </summary>
		BalanceOf2010 = 1,
		/// <summary>
		/// تحويل من فرع
		/// </summary>
		IncommingFromOtherBranch = 3,
		/// <summary>
		/// تحويل من موظف
		/// </summary>
		IncommingFromOtherSubscriber = 4,
		/// <summary>
		/// تحويل من مكفول
		/// </summary>
		IncommingFromGuarantee = 5
	}

	/// <summary>
	/// حالة طلب الحصول على منتج
	/// </summary>
	public enum RequestStatusEnum
	{
		/// <summary>
		/// قيد المعالجة
		/// </summary>
		New = 1,
		/// <summary>
		/// يحقق الشروط
		/// </summary>
		Valid = 2,
		/// <summary>
		/// قيد إعداد القرار
		/// </summary>
		Approved = 3,
		/// <summary>
		/// قيد إصدار القرار
		/// </summary>
		FinanciallyApproved = 4,
		/// <summary>
		/// منفذ
		/// </summary>
		Executed = 5,
		/// <summary>
		/// لا يحقق الشروط
		/// </summary>
		Invalid = 6,
		/// <summary>
		/// مستثنى من تحقيق الشروط
		/// </summary>
		ExcludedFromValidation = 7,
		/// <summary>
		/// ملغى
		/// </summary>
		Canceled = 8
	}

	///// <summary>
	///// حالة بطاقة السلفة
	///// </summary>
	//public enum LoanStatusEnum
	//{
	//	/// <summary>
	//	/// غير منتهية
	//	/// </summary>
	//	غير منتهية = 0,
	//	/// <summary>
	//	/// منتهية نظامي
	//	/// </summary>
	//	منتهية نظامي = 1,
	//	/// <summary>
	//	/// سداد مبكر
	//	/// </summary>
	//	سداد مبكر = 2,
	//	/// <summary>
	//	/// تحويل إلى فرع
	//	/// </summary>
	//	تحويل إلى فرع = 3,
	//	/// <summary>
	//	/// تحويل إلى موظف
	//	/// </summary>
	//	تحويل إلى موظف = 4,
	//	/// <summary>
	//	/// تحويل إلى الكفلاء
	//	/// </summary>
	//	تحويل إلى الكفلاء = 5,
	//	/// <summary>
	//	/// حالة مؤقتة
	//	/// </summary>
	//	حالة مؤقتة = 9
	//}

	///// <summary>
	///// نوع السلفة
	///// </summary>
	//public enum LoanTypeEnum
	//{
	//	/// <summary>
	//	/// السلف الاستثمارية
	//	/// </summary>
	//	السلف الاستثمارية = 1,
	//	/// <summary>
	//	/// السلف الاستثمارية ( بدون فائدة)
	//	/// </summary>
	//	السلف الاستثمارية ( بدون فائدة) = 2,
	//	/// <summary>
	//	/// السلف العلاجية
	//	/// </summary>
	//	السلف العلاجية = 3,
	//	/// <summary>
	//	/// السلف السكنية
	//	/// </summary>
	//	السلف السكنية = 4,
	//	/// <summary>
	//	/// سلف الزاوج
	//	/// </summary>
	//	سلف الزاوج = 5,
	//	/// <summary>
	//	/// السلف الدراسية
	//	/// </summary>
	//	السلف الدراسية = 6,
	//	/// <summary>
	//	/// السلف السكنية المحولة إلى سلف استثمارية
	//	/// </summary>
	//	السلف السكنية المحولة إلى سلف استثمارية = 7,
	//	/// <summary>
	//	/// السلف الاستثمارية (تقويم أسنان)
	//	/// </summary>
	//	السلف الاستثمارية (تقويم أسنان) = 10,
	//	/// <summary>
	//	/// سلفة عيد (بدون فائدة)
	//	/// </summary>
	//	سلفة عيد (بدون فائدة) = 11,
	//	/// <summary>
	//	/// سلفة أضرار مادية
	//	/// </summary>
	//	سلفة أضرار مادية = 12,
	//	/// <summary>
	//	/// سلفة علاجية محولة الى استثمارية
	//	/// </summary>
	//	سلفة علاجية محولة الى استثمارية = 13,
	//	/// <summary>
	//	/// سلفة حاسب بدون فائدة
	//	/// </summary>
	//	سلفة حاسب بدون فائدة = 14,
	//	/// <summary>
	//	/// سلفة اضرار مادية (بدون تضخم)
	//	/// </summary>
	//	سلفة اضرار مادية (بدون تضخم) = 15,
	//	/// <summary>
	//	/// سلفة سكنية محولة إلى استثمارية
	//	/// </summary>
	//	سلفة سكنية محولة إلى استثمارية = 16,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى سلف استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى سلف استثمارية = 21,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 22,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 23,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 24,
	//	/// <summary>
	//	/// السلف الاستثمارية
	//	/// </summary>
	//	السلف الاستثمارية = 33,
	//	/// <summary>
	//	/// سلفة فوائد إعادة جدولة سلف سابقة
	//	/// </summary>
	//	سلفة فوائد إعادة جدولة سلف سابقة = 50,
	//	/// <summary>
	//	/// سلف الزاوج
	//	/// </summary>
	//	سلف الزاوج = 55,
	//	/// <summary>
	//	/// السلف الدراسية
	//	/// </summary>
	//	السلف الدراسية = 66,
	//	/// <summary>
	//	/// سلفة منقولة من فرع إلى دمشق
	//	/// </summary>
	//	سلفة منقولة من فرع إلى دمشق = 91,
	//	/// <summary>
	//	/// سلفة محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة محولة إلى الكفلاء = 92,
	//	/// <summary>
	//	/// سلفة علاجية محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة علاجية محولة إلى الكفلاء = 93,
	//	/// <summary>
	//	/// سلفة سكنية محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة سكنية محولة إلى الكفلاء = 94,
	//	/// <summary>
	//	/// سلفة استثنائية بدون فائدة
	//	/// </summary>
	//	سلفة استثنائية بدون فائدة = 95
	//}

	///// <summary>
	///// مجموعة الدفع
	///// </summary>
	//public enum PaymentGroupEnum
	//{
	//	/// <summary>
	//	/// استثمارية
	//	/// </summary>
	//	استثمارية = 1,
	//	/// <summary>
	//	/// علاجية
	//	/// </summary>
	//	علاجية = 2,
	//	/// <summary>
	//	/// سكنية
	//	/// </summary>
	//	سكنية = 3
	//}

	///// <summary>
	///// حالة السداد
	///// </summary>
	//public enum PaymentStatusEnum
	//{
	//	/// <summary>
	//	/// غير موزعة
	//	/// </summary>
	//	غير موزعة = 1,
	//	/// <summary>
	//	/// لا يمكن توزيعها
	//	/// </summary>
	//	لا يمكن توزيعها = 2,
	//	/// <summary>
	//	/// موزعة جزئياً
	//	/// </summary>
	//	موزعة جزئياً = 3,
	//	/// <summary>
	//	/// موزعة كلياً
	//	/// </summary>
	//	موزعة كلياً = 4
	//}

	///// <summary>
	///// نوع المنتج
	///// </summary>
	//public enum ProductTypeEnum
	//{
	//	/// <summary>
	//	/// إعانة
	//	/// </summary>
	//	إعانة = 0,
	//	/// <summary>
	//	/// السلف الاستثمارية
	//	/// </summary>
	//	السلف الاستثمارية = 1,
	//	/// <summary>
	//	/// السلف الاستثمارية ( بدون فائدة)
	//	/// </summary>
	//	السلف الاستثمارية ( بدون فائدة) = 2,
	//	/// <summary>
	//	/// السلف العلاجية
	//	/// </summary>
	//	السلف العلاجية = 3,
	//	/// <summary>
	//	/// السلف السكنية
	//	/// </summary>
	//	السلف السكنية = 4,
	//	/// <summary>
	//	/// سلف الزاوج
	//	/// </summary>
	//	سلف الزاوج = 5,
	//	/// <summary>
	//	/// السلف الدراسية
	//	/// </summary>
	//	السلف الدراسية = 6,
	//	/// <summary>
	//	/// السلف السكنية المحولة إلى سلف استثمارية
	//	/// </summary>
	//	السلف السكنية المحولة إلى سلف استثمارية = 7,
	//	/// <summary>
	//	/// السلف الاستثمارية (تقويم أسنان)
	//	/// </summary>
	//	السلف الاستثمارية (تقويم أسنان) = 10,
	//	/// <summary>
	//	/// سلفة عيد (بدون فائدة)
	//	/// </summary>
	//	سلفة عيد (بدون فائدة) = 11,
	//	/// <summary>
	//	/// سلفة أضرار مادية
	//	/// </summary>
	//	سلفة أضرار مادية = 12,
	//	/// <summary>
	//	/// سلفة علاجية محولة الى استثمارية
	//	/// </summary>
	//	سلفة علاجية محولة الى استثمارية = 13,
	//	/// <summary>
	//	/// سلفة حاسب بدون فائدة
	//	/// </summary>
	//	سلفة حاسب بدون فائدة = 14,
	//	/// <summary>
	//	/// سلفة اضرار مادية (بدون تضخم)
	//	/// </summary>
	//	سلفة اضرار مادية (بدون تضخم) = 15,
	//	/// <summary>
	//	/// سلفة سكنية محولة إلى استثمارية
	//	/// </summary>
	//	سلفة سكنية محولة إلى استثمارية = 16,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى سلف استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى سلف استثمارية = 21,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 22,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 23,
	//	/// <summary>
	//	/// السلف العلاجية المحولة إلى استثمارية
	//	/// </summary>
	//	السلف العلاجية المحولة إلى استثمارية = 24,
	//	/// <summary>
	//	/// السلف الاستثمارية
	//	/// </summary>
	//	السلف الاستثمارية = 33,
	//	/// <summary>
	//	/// سلفة فوائد إعادة جدولة سلف سابقة
	//	/// </summary>
	//	سلفة فوائد إعادة جدولة سلف سابقة = 50,
	//	/// <summary>
	//	/// سلف الزاوج
	//	/// </summary>
	//	سلف الزاوج = 55,
	//	/// <summary>
	//	/// السلف الدراسية
	//	/// </summary>
	//	السلف الدراسية = 66,
	//	/// <summary>
	//	/// سلفة منقولة من فرع إلى دمشق
	//	/// </summary>
	//	سلفة منقولة من فرع إلى دمشق = 91,
	//	/// <summary>
	//	/// سلفة محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة محولة إلى الكفلاء = 92,
	//	/// <summary>
	//	/// سلفة علاجية محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة علاجية محولة إلى الكفلاء = 93,
	//	/// <summary>
	//	/// سلفة سكنية محولة إلى الكفلاء
	//	/// </summary>
	//	سلفة سكنية محولة إلى الكفلاء = 94,
	//	/// <summary>
	//	/// سلفة استثنائية بدون فائدة
	//	/// </summary>
	//	سلفة استثنائية بدون فائدة = 95
	//}

	///// <summary>
	///// آلية حساب العوائد الربحية
	///// </summary>
	//public enum ProfitStrategyEnum
	//{
	//	/// <summary>
	//	/// طرح
	//	/// </summary>
	//	طرح = 1,
	//	/// <summary>
	//	/// إضافة
	//	/// </summary>
	//	إضافة = 2
	//}


	///// <summary>
	///// نوع الاشتراك
	///// </summary>
	//public enum SubscriptionTypeEnum
	//{
	//	/// <summary>
	//	/// إضافي
	//	/// </summary>
	//	إضافي = 4,
	//	/// <summary>
	//	/// نظامي
	//	/// </summary>
	//	نظامي = 5
	//}
}
