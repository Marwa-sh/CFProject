using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
	#region Db class definition
	///<summary>
	/// A custom data context for the Cf database.
	/// قاعدة المعطيات المركزية لنظام معلومات الصندوق التعاوني
	///</summary>
	public partial class Db
	{
		#region Availability procedures.
		#region List procedure
		[Function(Name = "dbo.AvailabilityList")]
		private ISingleResult<Availability> _AvailabilityList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Availability>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Availability table.
		/// </summary>
		/// <returns>A list of Availability instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Availability> AvailabilityList()
		{
			return _AvailabilityList().ToList<Availability>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.AvailabilityGet")]
		private ISingleResult<Availability> _AvailabilityGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Availability>);
		}

		/// <summary>
		/// Gets one row from the dbo.Availability table.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		/// <returns>Gets an instance of Availability or null.</returns>
		public Availability AvailabilityGet([Parameter(Name = "@Id")] short _id)
		{
			List<Availability> list = _AvailabilityGet(_id).ToList<Availability>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.AvailabilityInsert")]
		private ISingleResult<Availability> _AvailabilityInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@MinSeniority")] byte _minSeniority, [Parameter(Name = "@MinReusePeriod")] byte _minReusePeriod)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _minSeniority, _minReusePeriod);
			return (result.ReturnValue) as ISingleResult<Availability>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Availability] table.
		/// </summary>
		/// <param name="instance">An instance of Availability to be inserted.</param>
		/// <returns>The inserted Availability</returns>
		public Availability AvailabilityInsert(Availability instance)
		{
            List<Availability> list = _AvailabilityInsert(instance.Name, instance.MinSeniority, instance.MinReusePeriod).ToList<Availability>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.AvailabilityUpdate")]
		private int _AvailabilityUpdate([Parameter(Name = "@Id")] short _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@MinSeniority")] byte _minSeniority, [Parameter(Name = "@MinReusePeriod")] byte _minReusePeriod)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _minSeniority, _minReusePeriod);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Availability] table.
		/// </summary>
		/// <param name="instance">An instance of Availability whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void AvailabilityUpdate(Availability instance)
		{
			_AvailabilityUpdate(instance.Id, instance.Name, instance.MinSeniority, instance.MinReusePeriod);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.AvailabilityDelete")]
		private int _AvailabilityDelete([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Availability] table.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		public void AvailabilityDelete([Parameter(Name = "@Id")] short _id)
		{
			_AvailabilityDelete(_id);
		}
		#endregion
        #endregion

		#region AvailabilityCeiling procedures.
		#region List procedure
		[Function(Name = "dbo.AvailabilityCeilingList")]
		private ISingleResult<AvailabilityCeiling> _AvailabilityCeilingList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<AvailabilityCeiling>);
		}

		/// <summary>
		/// Selects all rows from the dbo.AvailabilityCeiling table.
		/// </summary>
		/// <returns>A list of AvailabilityCeiling instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeiling> AvailabilityCeilingList()
		{
			return _AvailabilityCeilingList().ToList<AvailabilityCeiling>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.AvailabilityCeilingGet")]
		private ISingleResult<AvailabilityCeiling> _AvailabilityCeilingGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<AvailabilityCeiling>);
		}

		/// <summary>
		/// Gets one row from the dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		/// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
		public AvailabilityCeiling AvailabilityCeilingGet([Parameter(Name = "@Id")] short _id)
		{
			List<AvailabilityCeiling> list = _AvailabilityCeilingGet(_id).ToList<AvailabilityCeiling>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.AvailabilityCeilingInsert")]
		private ISingleResult<AvailabilityCeiling> _AvailabilityCeilingInsert([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear, [Parameter(Name = "@MaxAmount")] decimal _maxAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability, _fromYear, _maxAmount);
			return (result.ReturnValue) as ISingleResult<AvailabilityCeiling>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[AvailabilityCeiling] table.
		/// </summary>
		/// <param name="instance">An instance of AvailabilityCeiling to be inserted.</param>
		/// <returns>The inserted AvailabilityCeiling</returns>
		public AvailabilityCeiling AvailabilityCeilingInsert(AvailabilityCeiling instance)
		{
            List<AvailabilityCeiling> list = _AvailabilityCeilingInsert(instance.Availability, instance.FromYear, instance.MaxAmount).ToList<AvailabilityCeiling>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.AvailabilityCeilingUpdate")]
		private int _AvailabilityCeilingUpdate([Parameter(Name = "@Id")] short _id, [Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear, [Parameter(Name = "@MaxAmount")] decimal _maxAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _availability, _fromYear, _maxAmount);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[AvailabilityCeiling] table.
		/// </summary>
		/// <param name="instance">An instance of AvailabilityCeiling whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void AvailabilityCeilingUpdate(AvailabilityCeiling instance)
		{
			_AvailabilityCeilingUpdate(instance.Id, instance.Availability, instance.FromYear, instance.MaxAmount);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.AvailabilityCeilingDelete")]
		private int _AvailabilityCeilingDelete([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[AvailabilityCeiling] table.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		public void AvailabilityCeilingDelete([Parameter(Name = "@Id")] short _id)
		{
			_AvailabilityCeilingDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.AvailabilityCeilingGetByAvailability")]
		private ISingleResult<AvailabilityCeiling> _AvailabilityCeilingGetByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability);
			return (result.ReturnValue as ISingleResult<AvailabilityCeiling>);
		}

		/// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <returns>A list of AvailabilityCeiling instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeiling> AvailabilityCeilingGetByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			return _AvailabilityCeilingGetByAvailability(_availability).ToList<AvailabilityCeiling>();
		}

		/// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
		public AvailabilityCeiling AvailabilityCeilingGetByAvailabilityFirstOrNull([Parameter(Name = "@Availability")] short _availability)
		{
			List<AvailabilityCeiling> list = _AvailabilityCeilingGetByAvailability(_availability).ToList<AvailabilityCeiling>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.AvailabilityCeilingGetByAvailability_FromYear")]
		private ISingleResult<AvailabilityCeiling> _AvailabilityCeilingGetByAvailability_FromYear([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability, _fromYear);
			return (result.ReturnValue as ISingleResult<AvailabilityCeiling>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		/// <returns>A list of AvailabilityCeiling instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeiling> AvailabilityCeilingGetByAvailability_FromYear([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			return _AvailabilityCeilingGetByAvailability_FromYear(_availability, _fromYear).ToList<AvailabilityCeiling>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		/// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
		public AvailabilityCeiling AvailabilityCeilingGetByAvailability_FromYearFirstOrNull([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			List<AvailabilityCeiling> list = _AvailabilityCeilingGetByAvailability_FromYear(_availability, _fromYear).ToList<AvailabilityCeiling>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.AvailabilityCeilingDeleteByAvailability")]
		private int _AvailabilityCeilingDeleteByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Availability from the dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		public void AvailabilityCeilingDeleteByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			_AvailabilityCeilingDeleteByAvailability(_availability);
		}		

        [Function(Name = "dbo.AvailabilityCeilingDeleteByAvailability_FromYear")]
		private int _AvailabilityCeilingDeleteByAvailability_FromYear([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability, _fromYear);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Availability, FromYear columns in the  dbo.AvailabilityCeiling table.
		/// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		public void AvailabilityCeilingDeleteByAvailability_FromYear([Parameter(Name = "@Availability")] short _availability, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			_AvailabilityCeilingDeleteByAvailability_FromYear(_availability, _fromYear);
		}
		#endregion
        #endregion

		#region BypassStatus procedures.
		#region List procedure
		[Function(Name = "dbo.BypassStatusList")]
		private ISingleResult<BypassStatus> _BypassStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<BypassStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.BypassStatus table.
		/// </summary>
		/// <returns>A list of BypassStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<BypassStatus> BypassStatusList()
		{
			return _BypassStatusList().ToList<BypassStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.BypassStatusGet")]
		private ISingleResult<BypassStatus> _BypassStatusGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<BypassStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.BypassStatus table.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		/// <returns>Gets an instance of BypassStatus or null.</returns>
		public BypassStatus BypassStatusGet([Parameter(Name = "@Id")] int _id)
		{
			List<BypassStatus> list = _BypassStatusGet(_id).ToList<BypassStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.BypassStatusInsert")]
		private ISingleResult<BypassStatus> _BypassStatusInsert([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<BypassStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[BypassStatus] table.
		/// </summary>
		/// <param name="instance">An instance of BypassStatus to be inserted.</param>
		/// <returns>The inserted BypassStatus</returns>
		public BypassStatus BypassStatusInsert(BypassStatus instance)
		{
            List<BypassStatus> list = _BypassStatusInsert(instance.Id, instance.Name).ToList<BypassStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.BypassStatusUpdate")]
		private int _BypassStatusUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[BypassStatus] table.
		/// </summary>
		/// <param name="instance">An instance of BypassStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void BypassStatusUpdate(BypassStatus instance)
		{
			_BypassStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.BypassStatusDelete")]
		private int _BypassStatusDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[BypassStatus] table.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		public void BypassStatusDelete([Parameter(Name = "@Id")] int _id)
		{
			_BypassStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.BypassStatusGetByName")]
		private ISingleResult<BypassStatus> _BypassStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<BypassStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		/// <returns>A list of BypassStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<BypassStatus> BypassStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _BypassStatusGetByName(_name).ToList<BypassStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		/// <returns>Gets an instance of BypassStatus or null.</returns>
		public BypassStatus BypassStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<BypassStatus> list = _BypassStatusGetByName(_name).ToList<BypassStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.BypassStatusDeleteByName")]
		private int _BypassStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.BypassStatus table.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		public void BypassStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_BypassStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region CashPayment procedures.
		#region List procedure
		[Function(Name = "dbo.CashPaymentList")]
		private ISingleResult<CashPayment> _CashPaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<CashPayment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.CashPayment table.
		/// </summary>
		/// <returns>A list of CashPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CashPayment> CashPaymentList()
		{
			return _CashPaymentList().ToList<CashPayment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CashPaymentGet")]
		private ISingleResult<CashPayment> _CashPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return (result.ReturnValue as ISingleResult<CashPayment>);
		}

		/// <summary>
		/// Gets one row from the dbo.CashPayment table.
		/// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		/// <returns>Gets an instance of CashPayment or null.</returns>
		public CashPayment CashPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			List<CashPayment> list = _CashPaymentGet(_payment).ToList<CashPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.CashPaymentInsert")]
		private ISingleResult<CashPayment> _CashPaymentInsert([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@ReceiptNumber")] Nullable<int> _receiptNumber, [Parameter(Name = "@ReceiptDate")] Nullable<DateTime> _receiptDate, [Parameter(Name = "@FeeAmount")] decimal _feeAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _number, _receiptNumber, _receiptDate, _feeAmount);
			return (result.ReturnValue) as ISingleResult<CashPayment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[CashPayment] table.
		/// </summary>
		/// <param name="instance">An instance of CashPayment to be inserted.</param>
		/// <returns>The inserted CashPayment</returns>
		public CashPayment CashPaymentInsert(CashPayment instance)
		{
            List<CashPayment> list = _CashPaymentInsert(instance.Payment, instance.Number, instance.ReceiptNumber, instance.ReceiptDate, instance.FeeAmount).ToList<CashPayment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.CashPaymentUpdate")]
		private int _CashPaymentUpdate([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@ReceiptNumber")] Nullable<int> _receiptNumber, [Parameter(Name = "@ReceiptDate")] Nullable<DateTime> _receiptDate, [Parameter(Name = "@FeeAmount")] decimal _feeAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _number, _receiptNumber, _receiptDate, _feeAmount);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[CashPayment] table.
		/// </summary>
		/// <param name="instance">An instance of CashPayment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void CashPaymentUpdate(CashPayment instance)
		{
			_CashPaymentUpdate(instance.Payment, instance.Number, instance.ReceiptNumber, instance.ReceiptDate, instance.FeeAmount);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.CashPaymentDelete")]
		private int _CashPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[CashPayment] table.
		/// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		public void CashPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			_CashPaymentDelete(_payment);
		}
		#endregion
        #endregion

		#region Category procedures.
		#region List procedure
		[Function(Name = "dbo.CategoryList")]
		private ISingleResult<Category> _CategoryList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Category>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Category table.
		/// </summary>
		/// <returns>A list of Category instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Category> CategoryList()
		{
			return _CategoryList().ToList<Category>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CategoryGet")]
		private ISingleResult<Category> _CategoryGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Category>);
		}

		/// <summary>
		/// Gets one row from the dbo.Category table.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		/// <returns>Gets an instance of Category or null.</returns>
		public Category CategoryGet([Parameter(Name = "@Id")] byte _id)
		{
			List<Category> list = _CategoryGet(_id).ToList<Category>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.CategoryInsert")]
		private ISingleResult<Category> _CategoryInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<Category>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Category] table.
		/// </summary>
		/// <param name="instance">An instance of Category to be inserted.</param>
		/// <returns>The inserted Category</returns>
		public Category CategoryInsert(Category instance)
		{
            List<Category> list = _CategoryInsert(instance.Id, instance.Name).ToList<Category>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.CategoryUpdate")]
		private int _CategoryUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Category] table.
		/// </summary>
		/// <param name="instance">An instance of Category whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void CategoryUpdate(Category instance)
		{
			_CategoryUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.CategoryDelete")]
		private int _CategoryDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Category] table.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		public void CategoryDelete([Parameter(Name = "@Id")] byte _id)
		{
			_CategoryDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.CategoryGetByName")]
		private ISingleResult<Category> _CategoryGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<Category>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		/// <returns>A list of Category instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Category> CategoryGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _CategoryGetByName(_name).ToList<Category>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		/// <returns>Gets an instance of Category or null.</returns>
		public Category CategoryGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<Category> list = _CategoryGetByName(_name).ToList<Category>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.CategoryDeleteByName")]
		private int _CategoryDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Category table.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		public void CategoryDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_CategoryDeleteByName(_name);
		}
		#endregion
        #endregion

		#region CollectOrder procedures.
		#region List procedure
		[Function(Name = "dbo.CollectOrderList")]
		private ISingleResult<CollectOrder> _CollectOrderList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<CollectOrder>);
		}

		/// <summary>
		/// Selects all rows from the dbo.CollectOrder table.
		/// </summary>
		/// <returns>A list of CollectOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CollectOrder> CollectOrderList()
		{
			return _CollectOrderList().ToList<CollectOrder>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CollectOrderGet")]
		private ISingleResult<CollectOrder> _CollectOrderGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<CollectOrder>);
		}

		/// <summary>
		/// Gets one row from the dbo.CollectOrder table.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		/// <returns>Gets an instance of CollectOrder or null.</returns>
		public CollectOrder CollectOrderGet([Parameter(Name = "@Id")] int _id)
		{
			List<CollectOrder> list = _CollectOrderGet(_id).ToList<CollectOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.CollectOrderInsert")]
		private ISingleResult<CollectOrder> _CollectOrderInsert([Parameter(Name = "@Number")] Nullable<short> _number, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@AccountingDocumentNumber")] Nullable<short> _accountingDocumentNumber, [Parameter(Name = "@AccountingDocumentDate")] Nullable<DateTime> _accountingDocumentDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _date, _accountingDocumentNumber, _accountingDocumentDate);
			return (result.ReturnValue) as ISingleResult<CollectOrder>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[CollectOrder] table.
		/// </summary>
		/// <param name="instance">An instance of CollectOrder to be inserted.</param>
		/// <returns>The inserted CollectOrder</returns>
		public CollectOrder CollectOrderInsert(CollectOrder instance)
		{
            List<CollectOrder> list = _CollectOrderInsert(instance.Number, instance.Date, instance.AccountingDocumentNumber, instance.AccountingDocumentDate).ToList<CollectOrder>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.CollectOrderUpdate")]
		private int _CollectOrderUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Number")] Nullable<short> _number, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@AccountingDocumentNumber")] Nullable<short> _accountingDocumentNumber, [Parameter(Name = "@AccountingDocumentDate")] Nullable<DateTime> _accountingDocumentDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _number, _date, _accountingDocumentNumber, _accountingDocumentDate);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[CollectOrder] table.
		/// </summary>
		/// <param name="instance">An instance of CollectOrder whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void CollectOrderUpdate(CollectOrder instance)
		{
			_CollectOrderUpdate(instance.Id, instance.Number, instance.Date, instance.AccountingDocumentNumber, instance.AccountingDocumentDate);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.CollectOrderDelete")]
		private int _CollectOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[CollectOrder] table.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		public void CollectOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			_CollectOrderDelete(_id);
		}
		#endregion
        #endregion

		#region Debt procedures.
		#region List procedure
		[Function(Name = "dbo.DebtList")]
		private ISingleResult<Debt> _DebtList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Debt table.
		/// </summary>
		/// <returns>A list of Debt instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Debt> DebtList()
		{
			return _DebtList().ToList<Debt>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DebtGet")]
		private ISingleResult<Debt> _DebtGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Gets one row from the dbo.Debt table.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		/// <returns>Gets an instance of Debt or null.</returns>
		public Debt DebtGet([Parameter(Name = "@Id")] int _id)
		{
			List<Debt> list = _DebtGet(_id).ToList<Debt>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.DebtInsert")]
		private ISingleResult<Debt> _DebtInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Issuer")] byte _issuer, [Parameter(Name = "@ReferenceNumber")] string _referenceNumber, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@PeriodInMonths")] Nullable<byte> _periodInMonths, [Parameter(Name = "@ExceptionalPayment")] decimal _exceptionalPayment, [Parameter(Name = "@IsActive")] bool _isActive, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IssueDescription")] string _issueDescription, [Parameter(Name = "@Installment")] decimal _installment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _amount, _issuer, _referenceNumber, _date, _periodInMonths, _exceptionalPayment, _isActive, _notes, _issueDescription, _installment);
			return (result.ReturnValue) as ISingleResult<Debt>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Debt] table.
		/// </summary>
		/// <param name="instance">An instance of Debt to be inserted.</param>
		/// <returns>The inserted Debt</returns>
		public Debt DebtInsert(Debt instance)
		{
            List<Debt> list = _DebtInsert(instance.Employee, instance.Amount, instance.Issuer, instance.ReferenceNumber, instance.Date, instance.PeriodInMonths, instance.ExceptionalPayment, instance.IsActive, instance.Notes, instance.IssueDescription, instance.Installment).ToList<Debt>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.DebtUpdate")]
		private int _DebtUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Issuer")] byte _issuer, [Parameter(Name = "@ReferenceNumber")] string _referenceNumber, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@PeriodInMonths")] Nullable<byte> _periodInMonths, [Parameter(Name = "@ExceptionalPayment")] decimal _exceptionalPayment, [Parameter(Name = "@IsActive")] bool _isActive, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IssueDescription")] string _issueDescription, [Parameter(Name = "@Installment")] decimal _installment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _amount, _issuer, _referenceNumber, _date, _periodInMonths, _exceptionalPayment, _isActive, _notes, _issueDescription, _installment);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Debt] table.
		/// </summary>
		/// <param name="instance">An instance of Debt whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void DebtUpdate(Debt instance)
		{
			_DebtUpdate(instance.Id, instance.Employee, instance.Amount, instance.Issuer, instance.ReferenceNumber, instance.Date, instance.PeriodInMonths, instance.ExceptionalPayment, instance.IsActive, instance.Notes, instance.IssueDescription, instance.Installment);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.DebtDelete")]
		private int _DebtDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Debt] table.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		public void DebtDelete([Parameter(Name = "@Id")] int _id)
		{
			_DebtDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DebtGetByDate")]
		private ISingleResult<Debt> _DebtGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		/// <returns>A list of Debt instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Debt> DebtGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _DebtGetByDate(_date).ToList<Debt>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		/// <returns>Gets an instance of Debt or null.</returns>
		public Debt DebtGetByDateFirstOrNull([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			List<Debt> list = _DebtGetByDate(_date).ToList<Debt>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.DebtGetByEmployee")]
		private ISingleResult<Debt> _DebtGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		/// <returns>A list of Debt instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Debt> DebtGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _DebtGetByEmployee(_employee).ToList<Debt>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of Debt or null.</returns>
		public Debt DebtGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Debt> list = _DebtGetByEmployee(_employee).ToList<Debt>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.DebtGetByIsActive")]
		private ISingleResult<Debt> _DebtGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		/// <returns>A list of Debt instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Debt> DebtGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _DebtGetByIsActive(_isActive).ToList<Debt>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		/// <returns>Gets an instance of Debt or null.</returns>
		public Debt DebtGetByIsActiveFirstOrNull([Parameter(Name = "@IsActive")] bool _isActive)
		{
			List<Debt> list = _DebtGetByIsActive(_isActive).ToList<Debt>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.DebtGetByIssuer")]
		private ISingleResult<Debt> _DebtGetByIssuer([Parameter(Name = "@Issuer")] byte _issuer)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _issuer);
			return (result.ReturnValue as ISingleResult<Debt>);
		}

		/// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
		/// </summary>
		/// <param name="_issuer">جهة المنح</param>
		/// <returns>A list of Debt instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Debt> DebtGetByIssuer([Parameter(Name = "@Issuer")] byte _issuer)
		{
			return _DebtGetByIssuer(_issuer).ToList<Debt>();
		}

		/// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
		/// </summary>
		/// <param name="_issuer">جهة المنح</param>
		/// <returns>Gets an instance of Debt or null.</returns>
		public Debt DebtGetByIssuerFirstOrNull([Parameter(Name = "@Issuer")] byte _issuer)
		{
			List<Debt> list = _DebtGetByIssuer(_issuer).ToList<Debt>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.DebtDeleteByDate")]
		private int _DebtDeleteByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Debt table.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		public void DebtDeleteByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			_DebtDeleteByDate(_date);
		}		

        [Function(Name = "dbo.DebtDeleteByEmployee")]
		private int _DebtDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Debt table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		public void DebtDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_DebtDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.DebtDeleteByIsActive")]
		private int _DebtDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Debt table.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		public void DebtDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			_DebtDeleteByIsActive(_isActive);
		}		

        [Function(Name = "dbo.DebtDeleteByIssuer")]
		private int _DebtDeleteByIssuer([Parameter(Name = "@Issuer")] byte _issuer)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _issuer);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Issuer from the dbo.Debt table.
		/// </summary>
		/// <param name="_issuer">جهة المنح</param>
		public void DebtDeleteByIssuer([Parameter(Name = "@Issuer")] byte _issuer)
		{
			_DebtDeleteByIssuer(_issuer);
		}
		#endregion
        #endregion

		#region Department procedures.
		#region List procedure
		[Function(Name = "dbo.DepartmentList")]
		private ISingleResult<Department> _DepartmentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Department>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Department table.
		/// </summary>
		/// <returns>A list of Department instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Department> DepartmentList()
		{
			return _DepartmentList().ToList<Department>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DepartmentGet")]
		private ISingleResult<Department> _DepartmentGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Department>);
		}

		/// <summary>
		/// Gets one row from the dbo.Department table.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		/// <returns>Gets an instance of Department or null.</returns>
		public Department DepartmentGet([Parameter(Name = "@Id")] int _id)
		{
			List<Department> list = _DepartmentGet(_id).ToList<Department>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.DepartmentInsert")]
		private ISingleResult<Department> _DepartmentInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _salaryWorkPlace);
			return (result.ReturnValue) as ISingleResult<Department>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Department] table.
		/// </summary>
		/// <param name="instance">An instance of Department to be inserted.</param>
		/// <returns>The inserted Department</returns>
		public Department DepartmentInsert(Department instance)
		{
            List<Department> list = _DepartmentInsert(instance.Name, instance.SalaryWorkPlace).ToList<Department>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.DepartmentUpdate")]
		private int _DepartmentUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _salaryWorkPlace);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Department] table.
		/// </summary>
		/// <param name="instance">An instance of Department whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void DepartmentUpdate(Department instance)
		{
			_DepartmentUpdate(instance.Id, instance.Name, instance.SalaryWorkPlace);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.DepartmentDelete")]
		private int _DepartmentDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Department] table.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		public void DepartmentDelete([Parameter(Name = "@Id")] int _id)
		{
			_DepartmentDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DepartmentGetByName")]
		private ISingleResult<Department> _DepartmentGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<Department>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		/// <returns>A list of Department instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Department> DepartmentGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _DepartmentGetByName(_name).ToList<Department>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		/// <returns>Gets an instance of Department or null.</returns>
		public Department DepartmentGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<Department> list = _DepartmentGetByName(_name).ToList<Department>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.DepartmentGetBySalaryWorkPlace")]
		private ISingleResult<Department> _DepartmentGetBySalaryWorkPlace([Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _salaryWorkPlace);
			return (result.ReturnValue as ISingleResult<Department>);
		}

		/// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
		/// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		/// <returns>A list of Department instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Department> DepartmentGetBySalaryWorkPlace([Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			return _DepartmentGetBySalaryWorkPlace(_salaryWorkPlace).ToList<Department>();
		}

		/// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
		/// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		/// <returns>Gets an instance of Department or null.</returns>
		public Department DepartmentGetBySalaryWorkPlaceFirstOrNull([Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			List<Department> list = _DepartmentGetBySalaryWorkPlace(_salaryWorkPlace).ToList<Department>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.DepartmentDeleteByName")]
		private int _DepartmentDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Department table.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		public void DepartmentDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_DepartmentDeleteByName(_name);
		}		

        [Function(Name = "dbo.DepartmentDeleteBySalaryWorkPlace")]
		private int _DepartmentDeleteBySalaryWorkPlace([Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _salaryWorkPlace);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one SalaryWorkPlace from the dbo.Department table.
		/// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		public void DepartmentDeleteBySalaryWorkPlace([Parameter(Name = "@SalaryWorkPlace")] int _salaryWorkPlace)
		{
			_DepartmentDeleteBySalaryWorkPlace(_salaryWorkPlace);
		}
		#endregion
        #endregion

		#region DownPayment procedures.
		#region List procedure
		[Function(Name = "dbo.DownPaymentList")]
		private ISingleResult<DownPayment> _DownPaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<DownPayment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.DownPayment table.
		/// </summary>
		/// <returns>A list of DownPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DownPayment> DownPaymentList()
		{
			return _DownPaymentList().ToList<DownPayment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DownPaymentGet")]
		private ISingleResult<DownPayment> _DownPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return (result.ReturnValue as ISingleResult<DownPayment>);
		}

		/// <summary>
		/// Gets one row from the dbo.DownPayment table.
		/// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		/// <returns>Gets an instance of DownPayment or null.</returns>
		public DownPayment DownPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			List<DownPayment> list = _DownPaymentGet(_payment).ToList<DownPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.DownPaymentInsert")]
		private ISingleResult<DownPayment> _DownPaymentInsert([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _request);
			return (result.ReturnValue) as ISingleResult<DownPayment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[DownPayment] table.
		/// </summary>
		/// <param name="instance">An instance of DownPayment to be inserted.</param>
		/// <returns>The inserted DownPayment</returns>
		public DownPayment DownPaymentInsert(DownPayment instance)
		{
            List<DownPayment> list = _DownPaymentInsert(instance.Payment, instance.Request).ToList<DownPayment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.DownPaymentUpdate")]
		private int _DownPaymentUpdate([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _request);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[DownPayment] table.
		/// </summary>
		/// <param name="instance">An instance of DownPayment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void DownPaymentUpdate(DownPayment instance)
		{
			_DownPaymentUpdate(instance.Payment, instance.Request);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.DownPaymentDelete")]
		private int _DownPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[DownPayment] table.
		/// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		public void DownPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			_DownPaymentDelete(_payment);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DownPaymentGetByRequest")]
		private ISingleResult<DownPayment> _DownPaymentGetByRequest([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return (result.ReturnValue as ISingleResult<DownPayment>);
		}

		/// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
		/// </summary>
		/// <param name="_request">رقم الطلب</param>
		/// <returns>A list of DownPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DownPayment> DownPaymentGetByRequest([Parameter(Name = "@Request")] int _request)
		{
			return _DownPaymentGetByRequest(_request).ToList<DownPayment>();
		}

		/// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
		/// </summary>
		/// <param name="_request">رقم الطلب</param>
		/// <returns>Gets an instance of DownPayment or null.</returns>
		public DownPayment DownPaymentGetByRequestFirstOrNull([Parameter(Name = "@Request")] int _request)
		{
			List<DownPayment> list = _DownPaymentGetByRequest(_request).ToList<DownPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.DownPaymentDeleteByRequest")]
		private int _DownPaymentDeleteByRequest([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Request from the dbo.DownPayment table.
		/// </summary>
		/// <param name="_request">رقم الطلب</param>
		public void DownPaymentDeleteByRequest([Parameter(Name = "@Request")] int _request)
		{
			_DownPaymentDeleteByRequest(_request);
		}
		#endregion
        #endregion

		#region Employee procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeList")]
		private ISingleResult<Employee> _EmployeeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Employee table.
		/// </summary>
		/// <returns>A list of Employee instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Employee> EmployeeList()
		{
			return _EmployeeList().ToList<Employee>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeGet")]
		private ISingleResult<Employee> _EmployeeGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Gets one row from the dbo.Employee table.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of Employee or null.</returns>
		public Employee EmployeeGet([Parameter(Name = "@Id")] int _id)
		{
			List<Employee> list = _EmployeeGet(_id).ToList<Employee>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EmployeeInsert")]
		private ISingleResult<Employee> _EmployeeInsert([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName, [Parameter(Name = "@FatherName")] string _fatherName, [Parameter(Name = "@MotherName")] string _motherName, [Parameter(Name = "@BirthDate")] Nullable<DateTime> _birthDate, [Parameter(Name = "@ExpectedEndDate")] Nullable<DateTime> _expectedEndDate, [Parameter(Name = "@CersStartDate")] Nullable<DateTime> _cersStartDate, [Parameter(Name = "@CfStartDate")] Nullable<DateTime> _cfStartDate, [Parameter(Name = "@LeaveDate")] Nullable<DateTime> _leaveDate, [Parameter(Name = "@LeaveReason")] string _leaveReason, [Parameter(Name = "@EmployeeStatus")] byte _employeeStatus, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@Category")] byte _category)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _firstName, _lastName, _fatherName, _motherName, _birthDate, _expectedEndDate, _cersStartDate, _cfStartDate, _leaveDate, _leaveReason, _employeeStatus, _department, _notes, _category);
			return (result.ReturnValue) as ISingleResult<Employee>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Employee] table.
		/// </summary>
		/// <param name="instance">An instance of Employee to be inserted.</param>
		/// <returns>The inserted Employee</returns>
		public Employee EmployeeInsert(Employee instance)
		{
            List<Employee> list = _EmployeeInsert(instance.Id, instance.FirstName, instance.LastName, instance.FatherName, instance.MotherName, instance.BirthDate, instance.ExpectedEndDate, instance.CersStartDate, instance.CfStartDate, instance.LeaveDate, instance.LeaveReason, instance.EmployeeStatus, instance.Department, instance.Notes, instance.Category).ToList<Employee>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EmployeeUpdate")]
		private int _EmployeeUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName, [Parameter(Name = "@FatherName")] string _fatherName, [Parameter(Name = "@MotherName")] string _motherName, [Parameter(Name = "@BirthDate")] Nullable<DateTime> _birthDate, [Parameter(Name = "@ExpectedEndDate")] Nullable<DateTime> _expectedEndDate, [Parameter(Name = "@CersStartDate")] Nullable<DateTime> _cersStartDate, [Parameter(Name = "@CfStartDate")] Nullable<DateTime> _cfStartDate, [Parameter(Name = "@LeaveDate")] Nullable<DateTime> _leaveDate, [Parameter(Name = "@LeaveReason")] string _leaveReason, [Parameter(Name = "@EmployeeStatus")] byte _employeeStatus, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@Category")] byte _category)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _firstName, _lastName, _fatherName, _motherName, _birthDate, _expectedEndDate, _cersStartDate, _cfStartDate, _leaveDate, _leaveReason, _employeeStatus, _department, _notes, _category);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Employee] table.
		/// </summary>
		/// <param name="instance">An instance of Employee whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EmployeeUpdate(Employee instance)
		{
			_EmployeeUpdate(instance.Id, instance.FirstName, instance.LastName, instance.FatherName, instance.MotherName, instance.BirthDate, instance.ExpectedEndDate, instance.CersStartDate, instance.CfStartDate, instance.LeaveDate, instance.LeaveReason, instance.EmployeeStatus, instance.Department, instance.Notes, instance.Category);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EmployeeDelete")]
		private int _EmployeeDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Employee] table.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		public void EmployeeDelete([Parameter(Name = "@Id")] int _id)
		{
			_EmployeeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EmployeeGetByCategory")]
		private ISingleResult<Employee> _EmployeeGetByCategory([Parameter(Name = "@Category")] byte _category)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _category);
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
		/// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		/// <returns>A list of Employee instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Employee> EmployeeGetByCategory([Parameter(Name = "@Category")] byte _category)
		{
			return _EmployeeGetByCategory(_category).ToList<Employee>();
		}

		/// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
		/// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		/// <returns>Gets an instance of Employee or null.</returns>
		public Employee EmployeeGetByCategoryFirstOrNull([Parameter(Name = "@Category")] byte _category)
		{
			List<Employee> list = _EmployeeGetByCategory(_category).ToList<Employee>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EmployeeGetByDepartment")]
		private ISingleResult<Employee> _EmployeeGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>A list of Employee instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Employee> EmployeeGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			return _EmployeeGetByDepartment(_department).ToList<Employee>();
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>Gets an instance of Employee or null.</returns>
		public Employee EmployeeGetByDepartmentFirstOrNull([Parameter(Name = "@Department")] int _department)
		{
			List<Employee> list = _EmployeeGetByDepartment(_department).ToList<Employee>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EmployeeGetByEmployeeStatus")]
		private ISingleResult<Employee> _EmployeeGetByEmployeeStatus([Parameter(Name = "@EmployeeStatus")] byte _employeeStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeStatus);
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
		/// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		/// <returns>A list of Employee instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Employee> EmployeeGetByEmployeeStatus([Parameter(Name = "@EmployeeStatus")] byte _employeeStatus)
		{
			return _EmployeeGetByEmployeeStatus(_employeeStatus).ToList<Employee>();
		}

		/// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
		/// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		/// <returns>Gets an instance of Employee or null.</returns>
		public Employee EmployeeGetByEmployeeStatusFirstOrNull([Parameter(Name = "@EmployeeStatus")] byte _employeeStatus)
		{
			List<Employee> list = _EmployeeGetByEmployeeStatus(_employeeStatus).ToList<Employee>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EmployeeGetByFirstName_LastName")]
		private ISingleResult<Employee> _EmployeeGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstName, _lastName);
			return (result.ReturnValue as ISingleResult<Employee>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>A list of Employee instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Employee> EmployeeGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			return _EmployeeGetByFirstName_LastName(_firstName, _lastName).ToList<Employee>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>Gets an instance of Employee or null.</returns>
		public Employee EmployeeGetByFirstName_LastNameFirstOrNull([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			List<Employee> list = _EmployeeGetByFirstName_LastName(_firstName, _lastName).ToList<Employee>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EmployeeDeleteByCategory")]
		private int _EmployeeDeleteByCategory([Parameter(Name = "@Category")] byte _category)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _category);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Category from the dbo.Employee table.
		/// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		public void EmployeeDeleteByCategory([Parameter(Name = "@Category")] byte _category)
		{
			_EmployeeDeleteByCategory(_category);
		}		

        [Function(Name = "dbo.EmployeeDeleteByDepartment")]
		private int _EmployeeDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Department from the dbo.Employee table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		public void EmployeeDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			_EmployeeDeleteByDepartment(_department);
		}		

        [Function(Name = "dbo.EmployeeDeleteByEmployeeStatus")]
		private int _EmployeeDeleteByEmployeeStatus([Parameter(Name = "@EmployeeStatus")] byte _employeeStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one EmployeeStatus from the dbo.Employee table.
		/// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		public void EmployeeDeleteByEmployeeStatus([Parameter(Name = "@EmployeeStatus")] byte _employeeStatus)
		{
			_EmployeeDeleteByEmployeeStatus(_employeeStatus);
		}		

        [Function(Name = "dbo.EmployeeDeleteByFirstName_LastName")]
		private int _EmployeeDeleteByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstName, _lastName);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of FirstName, LastName columns in the  dbo.Employee table.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		public void EmployeeDeleteByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			_EmployeeDeleteByFirstName_LastName(_firstName, _lastName);
		}
		#endregion
        #endregion

		#region EmployeeSeniority procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeSeniorityList")]
		private ISingleResult<EmployeeSeniority> _EmployeeSeniorityList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeSeniority>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeSeniority table.
		/// </summary>
		/// <returns>A list of EmployeeSeniority instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeSeniority> EmployeeSeniorityList()
		{
			return _EmployeeSeniorityList().ToList<EmployeeSeniority>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeSeniorityGet")]
		private ISingleResult<EmployeeSeniority> _EmployeeSeniorityGet([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<EmployeeSeniority>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeSeniority table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeSeniority or null.</returns>
		public EmployeeSeniority EmployeeSeniorityGet([Parameter(Name = "@Employee")] int _employee)
		{
			List<EmployeeSeniority> list = _EmployeeSeniorityGet(_employee).ToList<EmployeeSeniority>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EmployeeSeniorityInsert")]
		private ISingleResult<EmployeeSeniority> _EmployeeSeniorityInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@ServiceInDays")] short _serviceInDays)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _serviceInDays);
			return (result.ReturnValue) as ISingleResult<EmployeeSeniority>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EmployeeSeniority] table.
		/// </summary>
		/// <param name="instance">An instance of EmployeeSeniority to be inserted.</param>
		/// <returns>The inserted EmployeeSeniority</returns>
		public EmployeeSeniority EmployeeSeniorityInsert(EmployeeSeniority instance)
		{
            List<EmployeeSeniority> list = _EmployeeSeniorityInsert(instance.Employee, instance.ServiceInDays).ToList<EmployeeSeniority>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EmployeeSeniorityUpdate")]
		private int _EmployeeSeniorityUpdate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@ServiceInDays")] short _serviceInDays)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _serviceInDays);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EmployeeSeniority] table.
		/// </summary>
		/// <param name="instance">An instance of EmployeeSeniority whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EmployeeSeniorityUpdate(EmployeeSeniority instance)
		{
			_EmployeeSeniorityUpdate(instance.Employee, instance.ServiceInDays);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EmployeeSeniorityDelete")]
		private int _EmployeeSeniorityDelete([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EmployeeSeniority] table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void EmployeeSeniorityDelete([Parameter(Name = "@Employee")] int _employee)
		{
			_EmployeeSeniorityDelete(_employee);
		}
		#endregion
        #endregion

		#region EmployeeStatus procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeStatusList")]
		private ISingleResult<EmployeeStatus> _EmployeeStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeStatus table.
		/// </summary>
		/// <returns>A list of EmployeeStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatus> EmployeeStatusList()
		{
			return _EmployeeStatusList().ToList<EmployeeStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeStatusGet")]
		private ISingleResult<EmployeeStatus> _EmployeeStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EmployeeStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatus or null.</returns>
		public EmployeeStatus EmployeeStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<EmployeeStatus> list = _EmployeeStatusGet(_id).ToList<EmployeeStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EmployeeStatusInsert")]
		private ISingleResult<EmployeeStatus> _EmployeeStatusInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _isActive);
			return (result.ReturnValue) as ISingleResult<EmployeeStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EmployeeStatus] table.
		/// </summary>
		/// <param name="instance">An instance of EmployeeStatus to be inserted.</param>
		/// <returns>The inserted EmployeeStatus</returns>
		public EmployeeStatus EmployeeStatusInsert(EmployeeStatus instance)
		{
            List<EmployeeStatus> list = _EmployeeStatusInsert(instance.Name, instance.IsActive).ToList<EmployeeStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EmployeeStatusUpdate")]
		private int _EmployeeStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _isActive);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EmployeeStatus] table.
		/// </summary>
		/// <param name="instance">An instance of EmployeeStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EmployeeStatusUpdate(EmployeeStatus instance)
		{
			_EmployeeStatusUpdate(instance.Id, instance.Name, instance.IsActive);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EmployeeStatusDelete")]
		private int _EmployeeStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EmployeeStatus] table.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		public void EmployeeStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_EmployeeStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EmployeeStatusGetByIsActive")]
		private ISingleResult<EmployeeStatus> _EmployeeStatusGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<EmployeeStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		/// <returns>A list of EmployeeStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatus> EmployeeStatusGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _EmployeeStatusGetByIsActive(_isActive).ToList<EmployeeStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		/// <returns>Gets an instance of EmployeeStatus or null.</returns>
		public EmployeeStatus EmployeeStatusGetByIsActiveFirstOrNull([Parameter(Name = "@IsActive")] bool _isActive)
		{
			List<EmployeeStatus> list = _EmployeeStatusGetByIsActive(_isActive).ToList<EmployeeStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EmployeeStatusGetByName")]
		private ISingleResult<EmployeeStatus> _EmployeeStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EmployeeStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		/// <returns>A list of EmployeeStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatus> EmployeeStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EmployeeStatusGetByName(_name).ToList<EmployeeStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatus or null.</returns>
		public EmployeeStatus EmployeeStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<EmployeeStatus> list = _EmployeeStatusGetByName(_name).ToList<EmployeeStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EmployeeStatusDeleteByIsActive")]
		private int _EmployeeStatusDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		public void EmployeeStatusDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			_EmployeeStatusDeleteByIsActive(_isActive);
		}		

        [Function(Name = "dbo.EmployeeStatusDeleteByName")]
		private int _EmployeeStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EmployeeStatus table.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		public void EmployeeStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_EmployeeStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region EndWorkGrantBracket procedures.
		#region List procedure
		[Function(Name = "dbo.EndWorkGrantBracketList")]
		private ISingleResult<EndWorkGrantBracket> _EndWorkGrantBracketList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EndWorkGrantBracket>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracket table.
		/// </summary>
		/// <returns>A list of EndWorkGrantBracket instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EndWorkGrantBracket> EndWorkGrantBracketList()
		{
			return _EndWorkGrantBracketList().ToList<EndWorkGrantBracket>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EndWorkGrantBracketGet")]
		private ISingleResult<EndWorkGrantBracket> _EndWorkGrantBracketGet([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromYear);
			return (result.ReturnValue as ISingleResult<EndWorkGrantBracket>);
		}

		/// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracket table.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		/// <returns>Gets an instance of EndWorkGrantBracket or null.</returns>
		public EndWorkGrantBracket EndWorkGrantBracketGet([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			List<EndWorkGrantBracket> list = _EndWorkGrantBracketGet(_fromYear).ToList<EndWorkGrantBracket>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EndWorkGrantBracketInsert")]
		private ISingleResult<EndWorkGrantBracket> _EndWorkGrantBracketInsert([Parameter(Name = "@FromYear")] byte _fromYear, [Parameter(Name = "@Percentage")] decimal _percentage)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromYear, _percentage);
			return (result.ReturnValue) as ISingleResult<EndWorkGrantBracket>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EndWorkGrantBracket] table.
		/// </summary>
		/// <param name="instance">An instance of EndWorkGrantBracket to be inserted.</param>
		/// <returns>The inserted EndWorkGrantBracket</returns>
		public EndWorkGrantBracket EndWorkGrantBracketInsert(EndWorkGrantBracket instance)
		{
            List<EndWorkGrantBracket> list = _EndWorkGrantBracketInsert(instance.FromYear, instance.Percentage).ToList<EndWorkGrantBracket>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EndWorkGrantBracketUpdate")]
		private int _EndWorkGrantBracketUpdate([Parameter(Name = "@FromYear")] byte _fromYear, [Parameter(Name = "@Percentage")] decimal _percentage)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromYear, _percentage);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EndWorkGrantBracket] table.
		/// </summary>
		/// <param name="instance">An instance of EndWorkGrantBracket whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EndWorkGrantBracketUpdate(EndWorkGrantBracket instance)
		{
			_EndWorkGrantBracketUpdate(instance.FromYear, instance.Percentage);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EndWorkGrantBracketDelete")]
		private int _EndWorkGrantBracketDelete([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromYear);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EndWorkGrantBracket] table.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		public void EndWorkGrantBracketDelete([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			_EndWorkGrantBracketDelete(_fromYear);
		}
		#endregion
        #endregion

		#region ErrorDefinition procedures.
		#region List procedure
		[Function(Name = "dbo.ErrorDefinitionList")]
		private ISingleResult<ErrorDefinition> _ErrorDefinitionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ErrorDefinition>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ErrorDefinition table.
		/// </summary>
		/// <returns>A list of ErrorDefinition instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ErrorDefinition> ErrorDefinitionList()
		{
			return _ErrorDefinitionList().ToList<ErrorDefinition>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ErrorDefinitionGet")]
		private ISingleResult<ErrorDefinition> _ErrorDefinitionGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ErrorDefinition>);
		}

		/// <summary>
		/// Gets one row from the dbo.ErrorDefinition table.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		/// <returns>Gets an instance of ErrorDefinition or null.</returns>
		public ErrorDefinition ErrorDefinitionGet([Parameter(Name = "@Id")] int _id)
		{
			List<ErrorDefinition> list = _ErrorDefinitionGet(_id).ToList<ErrorDefinition>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ErrorDefinitionInsert")]
		private ISingleResult<ErrorDefinition> _ErrorDefinitionInsert([Parameter(Name = "@Message")] string _message, [Parameter(Name = "@LocalizedMessage")] string _localizedMessage, [Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _message, _localizedMessage, _likeExpression);
			return (result.ReturnValue) as ISingleResult<ErrorDefinition>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ErrorDefinition] table.
		/// </summary>
		/// <param name="instance">An instance of ErrorDefinition to be inserted.</param>
		/// <returns>The inserted ErrorDefinition</returns>
		public ErrorDefinition ErrorDefinitionInsert(ErrorDefinition instance)
		{
            List<ErrorDefinition> list = _ErrorDefinitionInsert(instance.Message, instance.LocalizedMessage, instance.LikeExpression).ToList<ErrorDefinition>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ErrorDefinitionUpdate")]
		private int _ErrorDefinitionUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Message")] string _message, [Parameter(Name = "@LocalizedMessage")] string _localizedMessage, [Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _message, _localizedMessage, _likeExpression);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ErrorDefinition] table.
		/// </summary>
		/// <param name="instance">An instance of ErrorDefinition whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ErrorDefinitionUpdate(ErrorDefinition instance)
		{
			_ErrorDefinitionUpdate(instance.Id, instance.Message, instance.LocalizedMessage, instance.LikeExpression);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ErrorDefinitionDelete")]
		private int _ErrorDefinitionDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ErrorDefinition] table.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		public void ErrorDefinitionDelete([Parameter(Name = "@Id")] int _id)
		{
			_ErrorDefinitionDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ErrorDefinitionGetByLikeExpression")]
		private ISingleResult<ErrorDefinition> _ErrorDefinitionGetByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _likeExpression);
			return (result.ReturnValue as ISingleResult<ErrorDefinition>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		/// <returns>A list of ErrorDefinition instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ErrorDefinition> ErrorDefinitionGetByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			return _ErrorDefinitionGetByLikeExpression(_likeExpression).ToList<ErrorDefinition>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		/// <returns>Gets an instance of ErrorDefinition or null.</returns>
		public ErrorDefinition ErrorDefinitionGetByLikeExpressionFirstOrNull([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			List<ErrorDefinition> list = _ErrorDefinitionGetByLikeExpression(_likeExpression).ToList<ErrorDefinition>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ErrorDefinitionDeleteByLikeExpression")]
		private int _ErrorDefinitionDeleteByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _likeExpression);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinition table.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		public void ErrorDefinitionDeleteByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			_ErrorDefinitionDeleteByLikeExpression(_likeExpression);
		}
		#endregion
        #endregion

		#region EventCategory procedures.
		#region List procedure
		[Function(Name = "dbo.EventCategoryList")]
		private ISingleResult<EventCategory> _EventCategoryList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventCategory>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventCategory table.
		/// </summary>
		/// <returns>A list of EventCategory instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventCategory> EventCategoryList()
		{
			return _EventCategoryList().ToList<EventCategory>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventCategoryGet")]
		private ISingleResult<EventCategory> _EventCategoryGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventCategory>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventCategory table.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		/// <returns>Gets an instance of EventCategory or null.</returns>
		public EventCategory EventCategoryGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventCategory> list = _EventCategoryGet(_id).ToList<EventCategory>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EventCategoryInsert")]
		private ISingleResult<EventCategory> _EventCategoryInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<EventCategory>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EventCategory] table.
		/// </summary>
		/// <param name="instance">An instance of EventCategory to be inserted.</param>
		/// <returns>The inserted EventCategory</returns>
		public EventCategory EventCategoryInsert(EventCategory instance)
		{
            List<EventCategory> list = _EventCategoryInsert(instance.Name).ToList<EventCategory>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EventCategoryUpdate")]
		private int _EventCategoryUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EventCategory] table.
		/// </summary>
		/// <param name="instance">An instance of EventCategory whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EventCategoryUpdate(EventCategory instance)
		{
			_EventCategoryUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EventCategoryDelete")]
		private int _EventCategoryDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EventCategory] table.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		public void EventCategoryDelete([Parameter(Name = "@Id")] int _id)
		{
			_EventCategoryDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventCategoryGetByName")]
		private ISingleResult<EventCategory> _EventCategoryGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventCategory>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		/// <returns>A list of EventCategory instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventCategory> EventCategoryGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventCategoryGetByName(_name).ToList<EventCategory>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		/// <returns>Gets an instance of EventCategory or null.</returns>
		public EventCategory EventCategoryGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<EventCategory> list = _EventCategoryGetByName(_name).ToList<EventCategory>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EventCategoryDeleteByName")]
		private int _EventCategoryDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventCategory table.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		public void EventCategoryDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_EventCategoryDeleteByName(_name);
		}
		#endregion
        #endregion

		#region EventLog procedures.
		#region List procedure
		[Function(Name = "dbo.EventLogList")]
		private ISingleResult<EventLog> _EventLogList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventLog table.
		/// </summary>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogList()
		{
			return _EventLogList().ToList<EventLog>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventLogGet")]
		private ISingleResult<EventLog> _EventLogGet([Parameter(Name = "@Id")] long _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventLog table.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGet([Parameter(Name = "@Id")] long _id)
		{
			List<EventLog> list = _EventLogGet(_id).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EventLogInsert")]
		private ISingleResult<EventLog> _EventLogInsert([Parameter(Name = "@EventSource")] int _eventSource, [Parameter(Name = "@EventCategory")] int _eventCategory, [Parameter(Name = "@EventStatus")] int _eventStatus, [Parameter(Name = "@Parameters")] string _parameters, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@User")] int _user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventSource, _eventCategory, _eventStatus, _parameters, _date, _user);
			return (result.ReturnValue) as ISingleResult<EventLog>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EventLog] table.
		/// </summary>
		/// <param name="instance">An instance of EventLog to be inserted.</param>
		/// <returns>The inserted EventLog</returns>
		public EventLog EventLogInsert(EventLog instance)
		{
            List<EventLog> list = _EventLogInsert(instance.EventSource, instance.EventCategory, instance.EventStatus, instance.Parameters, instance.Date, instance.User).ToList<EventLog>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EventLogUpdate")]
		private int _EventLogUpdate([Parameter(Name = "@Id")] long _id, [Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _eventStatus);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EventLog] table.
		/// </summary>
		/// <param name="instance">An instance of EventLog whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EventLogUpdate(EventLog instance)
		{
			_EventLogUpdate(instance.Id, instance.EventStatus);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EventLogDelete")]
		private int _EventLogDelete([Parameter(Name = "@Id")] long _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EventLog] table.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		public void EventLogDelete([Parameter(Name = "@Id")] long _id)
		{
			_EventLogDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventLogGetByDate")]
		private ISingleResult<EventLog> _EventLogGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _EventLogGetByDate(_date).ToList<EventLog>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGetByDateFirstOrNull([Parameter(Name = "@Date")] DateTime _date)
		{
			List<EventLog> list = _EventLogGetByDate(_date).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EventLogGetByEventCategory")]
		private ISingleResult<EventLog> _EventLogGetByEventCategory([Parameter(Name = "@EventCategory")] int _eventCategory)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventCategory);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogGetByEventCategory([Parameter(Name = "@EventCategory")] int _eventCategory)
		{
			return _EventLogGetByEventCategory(_eventCategory).ToList<EventLog>();
		}

		/// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGetByEventCategoryFirstOrNull([Parameter(Name = "@EventCategory")] int _eventCategory)
		{
			List<EventLog> list = _EventLogGetByEventCategory(_eventCategory).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EventLogGetByEventSource")]
		private ISingleResult<EventLog> _EventLogGetByEventSource([Parameter(Name = "@EventSource")] int _eventSource)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventSource);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogGetByEventSource([Parameter(Name = "@EventSource")] int _eventSource)
		{
			return _EventLogGetByEventSource(_eventSource).ToList<EventLog>();
		}

		/// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGetByEventSourceFirstOrNull([Parameter(Name = "@EventSource")] int _eventSource)
		{
			List<EventLog> list = _EventLogGetByEventSource(_eventSource).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EventLogGetByEventStatus")]
		private ISingleResult<EventLog> _EventLogGetByEventStatus([Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventStatus);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogGetByEventStatus([Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			return _EventLogGetByEventStatus(_eventStatus).ToList<EventLog>();
		}

		/// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGetByEventStatusFirstOrNull([Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			List<EventLog> list = _EventLogGetByEventStatus(_eventStatus).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.EventLogGetByUser")]
		private ISingleResult<EventLog> _EventLogGetByUser([Parameter(Name = "@User")] int _user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _user);
			return (result.ReturnValue as ISingleResult<EventLog>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>A list of EventLog instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLog> EventLogGetByUser([Parameter(Name = "@User")] int _user)
		{
			return _EventLogGetByUser(_user).ToList<EventLog>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>Gets an instance of EventLog or null.</returns>
		public EventLog EventLogGetByUserFirstOrNull([Parameter(Name = "@User")] int _user)
		{
			List<EventLog> list = _EventLogGetByUser(_user).ToList<EventLog>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EventLogDeleteByDate")]
		private int _EventLogDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		public void EventLogDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			_EventLogDeleteByDate(_date);
		}		

        [Function(Name = "dbo.EventLogDeleteByEventCategory")]
		private int _EventLogDeleteByEventCategory([Parameter(Name = "@EventCategory")] int _eventCategory)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventCategory);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one EventCategory from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		public void EventLogDeleteByEventCategory([Parameter(Name = "@EventCategory")] int _eventCategory)
		{
			_EventLogDeleteByEventCategory(_eventCategory);
		}		

        [Function(Name = "dbo.EventLogDeleteByEventSource")]
		private int _EventLogDeleteByEventSource([Parameter(Name = "@EventSource")] int _eventSource)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventSource);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one EventSource from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		public void EventLogDeleteByEventSource([Parameter(Name = "@EventSource")] int _eventSource)
		{
			_EventLogDeleteByEventSource(_eventSource);
		}		

        [Function(Name = "dbo.EventLogDeleteByEventStatus")]
		private int _EventLogDeleteByEventStatus([Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one EventStatus from the dbo.EventLog table.
		/// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		public void EventLogDeleteByEventStatus([Parameter(Name = "@EventStatus")] int _eventStatus)
		{
			_EventLogDeleteByEventStatus(_eventStatus);
		}		

        [Function(Name = "dbo.EventLogDeleteByUser")]
		private int _EventLogDeleteByUser([Parameter(Name = "@User")] int _user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _user);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of User columns in the  dbo.EventLog table.
		/// </summary>
		/// <param name="_user">User identifier</param>
		public void EventLogDeleteByUser([Parameter(Name = "@User")] int _user)
		{
			_EventLogDeleteByUser(_user);
		}
		#endregion
        #endregion

		#region EventLogError procedures.
		#region List procedure
		[Function(Name = "dbo.EventLogErrorList")]
		private ISingleResult<EventLogError> _EventLogErrorList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventLogError>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventLogError table.
		/// </summary>
		/// <returns>A list of EventLogError instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogError> EventLogErrorList()
		{
			return _EventLogErrorList().ToList<EventLogError>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventLogErrorGet")]
		private ISingleResult<EventLogError> _EventLogErrorGet([Parameter(Name = "@EventLog")] long _eventLog)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventLog);
			return (result.ReturnValue as ISingleResult<EventLogError>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventLogError table.
		/// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogError or null.</returns>
		public EventLogError EventLogErrorGet([Parameter(Name = "@EventLog")] long _eventLog)
		{
			List<EventLogError> list = _EventLogErrorGet(_eventLog).ToList<EventLogError>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EventLogErrorInsert")]
		private ISingleResult<EventLogError> _EventLogErrorInsert([Parameter(Name = "@EventLog")] long _eventLog, [Parameter(Name = "@Number")] int _number, [Parameter(Name = "@Message")] string _message, [Parameter(Name = "@StackTrace")] string _stackTrace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventLog, _number, _message, _stackTrace);
			return (result.ReturnValue) as ISingleResult<EventLogError>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EventLogError] table.
		/// </summary>
		/// <param name="instance">An instance of EventLogError to be inserted.</param>
		/// <returns>The inserted EventLogError</returns>
		public EventLogError EventLogErrorInsert(EventLogError instance)
		{
            List<EventLogError> list = _EventLogErrorInsert(instance.EventLog, instance.Number, instance.Message, instance.StackTrace).ToList<EventLogError>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EventLogErrorUpdate")]
		private int _EventLogErrorUpdate([Parameter(Name = "@EventLog")] long _eventLog, [Parameter(Name = "@Number")] int _number, [Parameter(Name = "@Message")] string _message, [Parameter(Name = "@StackTrace")] string _stackTrace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventLog, _number, _message, _stackTrace);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EventLogError] table.
		/// </summary>
		/// <param name="instance">An instance of EventLogError whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EventLogErrorUpdate(EventLogError instance)
		{
			_EventLogErrorUpdate(instance.EventLog, instance.Number, instance.Message, instance.StackTrace);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EventLogErrorDelete")]
		private int _EventLogErrorDelete([Parameter(Name = "@EventLog")] long _eventLog)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventLog);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EventLogError] table.
		/// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
		public void EventLogErrorDelete([Parameter(Name = "@EventLog")] long _eventLog)
		{
			_EventLogErrorDelete(_eventLog);
		}
		#endregion
        #endregion

		#region EventSource procedures.
		#region List procedure
		[Function(Name = "dbo.EventSourceList")]
		private ISingleResult<EventSource> _EventSourceList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventSource>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventSource table.
		/// </summary>
		/// <returns>A list of EventSource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventSource> EventSourceList()
		{
			return _EventSourceList().ToList<EventSource>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventSourceGet")]
		private ISingleResult<EventSource> _EventSourceGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventSource>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventSource table.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		/// <returns>Gets an instance of EventSource or null.</returns>
		public EventSource EventSourceGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventSource> list = _EventSourceGet(_id).ToList<EventSource>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EventSourceInsert")]
		private ISingleResult<EventSource> _EventSourceInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<EventSource>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EventSource] table.
		/// </summary>
		/// <param name="instance">An instance of EventSource to be inserted.</param>
		/// <returns>The inserted EventSource</returns>
		public EventSource EventSourceInsert(EventSource instance)
		{
            List<EventSource> list = _EventSourceInsert(instance.Name).ToList<EventSource>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EventSourceUpdate")]
		private int _EventSourceUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EventSource] table.
		/// </summary>
		/// <param name="instance">An instance of EventSource whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EventSourceUpdate(EventSource instance)
		{
			_EventSourceUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EventSourceDelete")]
		private int _EventSourceDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EventSource] table.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		public void EventSourceDelete([Parameter(Name = "@Id")] int _id)
		{
			_EventSourceDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventSourceGetByName")]
		private ISingleResult<EventSource> _EventSourceGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventSource>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		/// <returns>A list of EventSource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventSource> EventSourceGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventSourceGetByName(_name).ToList<EventSource>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		/// <returns>Gets an instance of EventSource or null.</returns>
		public EventSource EventSourceGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<EventSource> list = _EventSourceGetByName(_name).ToList<EventSource>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EventSourceDeleteByName")]
		private int _EventSourceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventSource table.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		public void EventSourceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_EventSourceDeleteByName(_name);
		}
		#endregion
        #endregion

		#region EventStatus procedures.
		#region List procedure
		[Function(Name = "dbo.EventStatusList")]
		private ISingleResult<EventStatus> _EventStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventStatus table.
		/// </summary>
		/// <returns>A list of EventStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventStatus> EventStatusList()
		{
			return _EventStatusList().ToList<EventStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventStatusGet")]
		private ISingleResult<EventStatus> _EventStatusGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventStatus table.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		/// <returns>Gets an instance of EventStatus or null.</returns>
		public EventStatus EventStatusGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventStatus> list = _EventStatusGet(_id).ToList<EventStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.EventStatusInsert")]
		private ISingleResult<EventStatus> _EventStatusInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Icon")] string _icon)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _icon);
			return (result.ReturnValue) as ISingleResult<EventStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[EventStatus] table.
		/// </summary>
		/// <param name="instance">An instance of EventStatus to be inserted.</param>
		/// <returns>The inserted EventStatus</returns>
		public EventStatus EventStatusInsert(EventStatus instance)
		{
            List<EventStatus> list = _EventStatusInsert(instance.Name, instance.Icon).ToList<EventStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.EventStatusUpdate")]
		private int _EventStatusUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Icon")] string _icon)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _icon);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[EventStatus] table.
		/// </summary>
		/// <param name="instance">An instance of EventStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void EventStatusUpdate(EventStatus instance)
		{
			_EventStatusUpdate(instance.Id, instance.Name, instance.Icon);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.EventStatusDelete")]
		private int _EventStatusDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[EventStatus] table.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		public void EventStatusDelete([Parameter(Name = "@Id")] int _id)
		{
			_EventStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventStatusGetByName")]
		private ISingleResult<EventStatus> _EventStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		/// <returns>A list of EventStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventStatus> EventStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventStatusGetByName(_name).ToList<EventStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		/// <returns>Gets an instance of EventStatus or null.</returns>
		public EventStatus EventStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<EventStatus> list = _EventStatusGetByName(_name).ToList<EventStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.EventStatusDeleteByName")]
		private int _EventStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventStatus table.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		public void EventStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_EventStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region ExceptionalAmount procedures.
		#region List procedure
		[Function(Name = "dbo.ExceptionalAmountList")]
		private ISingleResult<ExceptionalAmount> _ExceptionalAmountList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExceptionalAmount>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <returns>A list of ExceptionalAmount instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmount> ExceptionalAmountList()
		{
			return _ExceptionalAmountList().ToList<ExceptionalAmount>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExceptionalAmountGet")]
		private ISingleResult<ExceptionalAmount> _ExceptionalAmountGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExceptionalAmount>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmount or null.</returns>
		public ExceptionalAmount ExceptionalAmountGet([Parameter(Name = "@Id")] int _id)
		{
			List<ExceptionalAmount> list = _ExceptionalAmountGet(_id).ToList<ExceptionalAmount>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ExceptionalAmountInsert")]
		private ISingleResult<ExceptionalAmount> _ExceptionalAmountInsert([Parameter(Name = "@LoanRequest")] int _loanRequest, [Parameter(Name = "@SubNumber")] decimal _subNumber, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest, _subNumber, _amount, _notes, _exceptionalAmountType);
			return (result.ReturnValue) as ISingleResult<ExceptionalAmount>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmount] table.
		/// </summary>
		/// <param name="instance">An instance of ExceptionalAmount to be inserted.</param>
		/// <returns>The inserted ExceptionalAmount</returns>
		public ExceptionalAmount ExceptionalAmountInsert(ExceptionalAmount instance)
		{
            List<ExceptionalAmount> list = _ExceptionalAmountInsert(instance.LoanRequest, instance.SubNumber, instance.Amount, instance.Notes, instance.ExceptionalAmountType).ToList<ExceptionalAmount>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ExceptionalAmountUpdate")]
		private int _ExceptionalAmountUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@LoanRequest")] int _loanRequest, [Parameter(Name = "@SubNumber")] decimal _subNumber, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _loanRequest, _subNumber, _amount, _notes, _exceptionalAmountType);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmount] table.
		/// </summary>
		/// <param name="instance">An instance of ExceptionalAmount whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ExceptionalAmountUpdate(ExceptionalAmount instance)
		{
			_ExceptionalAmountUpdate(instance.Id, instance.LoanRequest, instance.SubNumber, instance.Amount, instance.Notes, instance.ExceptionalAmountType);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ExceptionalAmountDelete")]
		private int _ExceptionalAmountDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmount] table.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		public void ExceptionalAmountDelete([Parameter(Name = "@Id")] int _id)
		{
			_ExceptionalAmountDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ExceptionalAmountGetByExceptionalAmountType")]
		private ISingleResult<ExceptionalAmount> _ExceptionalAmountGetByExceptionalAmountType([Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _exceptionalAmountType);
			return (result.ReturnValue as ISingleResult<ExceptionalAmount>);
		}

		/// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		/// <returns>A list of ExceptionalAmount instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmount> ExceptionalAmountGetByExceptionalAmountType([Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			return _ExceptionalAmountGetByExceptionalAmountType(_exceptionalAmountType).ToList<ExceptionalAmount>();
		}

		/// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmount or null.</returns>
		public ExceptionalAmount ExceptionalAmountGetByExceptionalAmountTypeFirstOrNull([Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			List<ExceptionalAmount> list = _ExceptionalAmountGetByExceptionalAmountType(_exceptionalAmountType).ToList<ExceptionalAmount>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ExceptionalAmountGetByLoanRequest")]
		private ISingleResult<ExceptionalAmount> _ExceptionalAmountGetByLoanRequest([Parameter(Name = "@LoanRequest")] int _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest);
			return (result.ReturnValue as ISingleResult<ExceptionalAmount>);
		}

		/// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		/// <returns>A list of ExceptionalAmount instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmount> ExceptionalAmountGetByLoanRequest([Parameter(Name = "@LoanRequest")] int _loanRequest)
		{
			return _ExceptionalAmountGetByLoanRequest(_loanRequest).ToList<ExceptionalAmount>();
		}

		/// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		/// <returns>Gets an instance of ExceptionalAmount or null.</returns>
		public ExceptionalAmount ExceptionalAmountGetByLoanRequestFirstOrNull([Parameter(Name = "@LoanRequest")] int _loanRequest)
		{
			List<ExceptionalAmount> list = _ExceptionalAmountGetByLoanRequest(_loanRequest).ToList<ExceptionalAmount>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ExceptionalAmountDeleteByExceptionalAmountType")]
		private int _ExceptionalAmountDeleteByExceptionalAmountType([Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _exceptionalAmountType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		public void ExceptionalAmountDeleteByExceptionalAmountType([Parameter(Name = "@ExceptionalAmountType")] byte _exceptionalAmountType)
		{
			_ExceptionalAmountDeleteByExceptionalAmountType(_exceptionalAmountType);
		}		

        [Function(Name = "dbo.ExceptionalAmountDeleteByLoanRequest")]
		private int _ExceptionalAmountDeleteByLoanRequest([Parameter(Name = "@LoanRequest")] int _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanRequest from the dbo.ExceptionalAmount table.
		/// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		public void ExceptionalAmountDeleteByLoanRequest([Parameter(Name = "@LoanRequest")] int _loanRequest)
		{
			_ExceptionalAmountDeleteByLoanRequest(_loanRequest);
		}
		#endregion
        #endregion

		#region ExceptionalAmountType procedures.
		#region List procedure
		[Function(Name = "dbo.ExceptionalAmountTypeList")]
		private ISingleResult<ExceptionalAmountType> _ExceptionalAmountTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExceptionalAmountType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountType table.
		/// </summary>
		/// <returns>A list of ExceptionalAmountType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmountType> ExceptionalAmountTypeList()
		{
			return _ExceptionalAmountTypeList().ToList<ExceptionalAmountType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExceptionalAmountTypeGet")]
		private ISingleResult<ExceptionalAmountType> _ExceptionalAmountTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExceptionalAmountType>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountType table.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountType or null.</returns>
		public ExceptionalAmountType ExceptionalAmountTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			List<ExceptionalAmountType> list = _ExceptionalAmountTypeGet(_id).ToList<ExceptionalAmountType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ExceptionalAmountTypeInsert")]
		private ISingleResult<ExceptionalAmountType> _ExceptionalAmountTypeInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@IsIncome")] bool _isIncome)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _isIncome);
			return (result.ReturnValue) as ISingleResult<ExceptionalAmountType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmountType] table.
		/// </summary>
		/// <param name="instance">An instance of ExceptionalAmountType to be inserted.</param>
		/// <returns>The inserted ExceptionalAmountType</returns>
		public ExceptionalAmountType ExceptionalAmountTypeInsert(ExceptionalAmountType instance)
		{
            List<ExceptionalAmountType> list = _ExceptionalAmountTypeInsert(instance.Id, instance.Name, instance.IsIncome).ToList<ExceptionalAmountType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ExceptionalAmountTypeUpdate")]
		private int _ExceptionalAmountTypeUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@IsIncome")] bool _isIncome)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _isIncome);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmountType] table.
		/// </summary>
		/// <param name="instance">An instance of ExceptionalAmountType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ExceptionalAmountTypeUpdate(ExceptionalAmountType instance)
		{
			_ExceptionalAmountTypeUpdate(instance.Id, instance.Name, instance.IsIncome);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ExceptionalAmountTypeDelete")]
		private int _ExceptionalAmountTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmountType] table.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		public void ExceptionalAmountTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			_ExceptionalAmountTypeDelete(_id);
		}
		#endregion
        #endregion

		#region ExternalGrant procedures.
		#region List procedure
		[Function(Name = "dbo.ExternalGrantList")]
		private ISingleResult<ExternalGrant> _ExternalGrantList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExternalGrant>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExternalGrant table.
		/// </summary>
		/// <returns>A list of ExternalGrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrant> ExternalGrantList()
		{
			return _ExternalGrantList().ToList<ExternalGrant>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExternalGrantGet")]
		private ISingleResult<ExternalGrant> _ExternalGrantGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExternalGrant>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		/// <returns>Gets an instance of ExternalGrant or null.</returns>
		public ExternalGrant ExternalGrantGet([Parameter(Name = "@Id")] int _id)
		{
			List<ExternalGrant> list = _ExternalGrantGet(_id).ToList<ExternalGrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ExternalGrantInsert")]
		private ISingleResult<ExternalGrant> _ExternalGrantInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@RequestDate")] Nullable<DateTime> _requestDate, [Parameter(Name = "@GrantType")] byte _grantType, [Parameter(Name = "@Description")] string _description, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] Nullable<short> _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _requestDate, _grantType, _description, _amount, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes);
			return (result.ReturnValue) as ISingleResult<ExternalGrant>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ExternalGrant] table.
		/// </summary>
		/// <param name="instance">An instance of ExternalGrant to be inserted.</param>
		/// <returns>The inserted ExternalGrant</returns>
		public ExternalGrant ExternalGrantInsert(ExternalGrant instance)
		{
            List<ExternalGrant> list = _ExternalGrantInsert(instance.Employee, instance.RequestDate, instance.GrantType, instance.Description, instance.Amount, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes).ToList<ExternalGrant>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ExternalGrantUpdate")]
		private int _ExternalGrantUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@RequestDate")] Nullable<DateTime> _requestDate, [Parameter(Name = "@GrantType")] byte _grantType, [Parameter(Name = "@Description")] string _description, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] Nullable<short> _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _requestDate, _grantType, _description, _amount, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ExternalGrant] table.
		/// </summary>
		/// <param name="instance">An instance of ExternalGrant whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ExternalGrantUpdate(ExternalGrant instance)
		{
			_ExternalGrantUpdate(instance.Id, instance.Employee, instance.RequestDate, instance.GrantType, instance.Description, instance.Amount, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ExternalGrantDelete")]
		private int _ExternalGrantDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ExternalGrant] table.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		public void ExternalGrantDelete([Parameter(Name = "@Id")] int _id)
		{
			_ExternalGrantDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ExternalGrantGetByEmployee")]
		private ISingleResult<ExternalGrant> _ExternalGrantGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<ExternalGrant>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of ExternalGrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrant> ExternalGrantGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _ExternalGrantGetByEmployee(_employee).ToList<ExternalGrant>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of ExternalGrant or null.</returns>
		public ExternalGrant ExternalGrantGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<ExternalGrant> list = _ExternalGrantGetByEmployee(_employee).ToList<ExternalGrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ExternalGrantGetByGrantType")]
		private ISingleResult<ExternalGrant> _ExternalGrantGetByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantType);
			return (result.ReturnValue as ISingleResult<ExternalGrant>);
		}

		/// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		/// <returns>A list of ExternalGrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrant> ExternalGrantGetByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			return _ExternalGrantGetByGrantType(_grantType).ToList<ExternalGrant>();
		}

		/// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		/// <returns>Gets an instance of ExternalGrant or null.</returns>
		public ExternalGrant ExternalGrantGetByGrantTypeFirstOrNull([Parameter(Name = "@GrantType")] byte _grantType)
		{
			List<ExternalGrant> list = _ExternalGrantGetByGrantType(_grantType).ToList<ExternalGrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ExternalGrantDeleteByEmployee")]
		private int _ExternalGrantDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void ExternalGrantDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_ExternalGrantDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.ExternalGrantDeleteByGrantType")]
		private int _ExternalGrantDeleteByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantType from the dbo.ExternalGrant table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		public void ExternalGrantDeleteByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			_ExternalGrantDeleteByGrantType(_grantType);
		}
		#endregion
        #endregion

		#region Grant procedures.
		#region List procedure
		[Function(Name = "dbo.GrantList")]
		private ISingleResult<Grant> _GrantList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Grant>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Grant table.
		/// </summary>
		/// <returns>A list of Grant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Grant> GrantList()
		{
			return _GrantList().ToList<Grant>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantGet")]
		private ISingleResult<Grant> _GrantGet([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return (result.ReturnValue as ISingleResult<Grant>);
		}

		/// <summary>
		/// Gets one row from the dbo.Grant table.
		/// </summary>
		/// <param name="_product">المنتج</param>
		/// <returns>Gets an instance of Grant or null.</returns>
		public Grant GrantGet([Parameter(Name = "@Product")] int _product)
		{
			List<Grant> list = _GrantGet(_product).ToList<Grant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantInsert")]
		private ISingleResult<Grant> _GrantInsert([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@GrantDecision")] int _grantDecision, [Parameter(Name = "@Amount")] decimal _amount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _grantDecision, _amount);
			return (result.ReturnValue) as ISingleResult<Grant>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Grant] table.
		/// </summary>
		/// <param name="instance">An instance of Grant to be inserted.</param>
		/// <returns>The inserted Grant</returns>
		public Grant GrantInsert(Grant instance)
		{
            List<Grant> list = _GrantInsert(instance.Product, instance.GrantDecision, instance.Amount).ToList<Grant>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantUpdate")]
		private int _GrantUpdate([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@GrantDecision")] int _grantDecision, [Parameter(Name = "@Amount")] decimal _amount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _grantDecision, _amount);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Grant] table.
		/// </summary>
		/// <param name="instance">An instance of Grant whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantUpdate(Grant instance)
		{
			_GrantUpdate(instance.Product, instance.GrantDecision, instance.Amount);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantDelete")]
		private int _GrantDelete([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Grant] table.
		/// </summary>
		/// <param name="_product">المنتج</param>
		public void GrantDelete([Parameter(Name = "@Product")] int _product)
		{
			_GrantDelete(_product);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantGetByGrantDecision")]
		private ISingleResult<Grant> _GrantGetByGrantDecision([Parameter(Name = "@GrantDecision")] int _grantDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantDecision);
			return (result.ReturnValue as ISingleResult<Grant>);
		}

		/// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
		/// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		/// <returns>A list of Grant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Grant> GrantGetByGrantDecision([Parameter(Name = "@GrantDecision")] int _grantDecision)
		{
			return _GrantGetByGrantDecision(_grantDecision).ToList<Grant>();
		}

		/// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
		/// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		/// <returns>Gets an instance of Grant or null.</returns>
		public Grant GrantGetByGrantDecisionFirstOrNull([Parameter(Name = "@GrantDecision")] int _grantDecision)
		{
			List<Grant> list = _GrantGetByGrantDecision(_grantDecision).ToList<Grant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantDeleteByGrantDecision")]
		private int _GrantDeleteByGrantDecision([Parameter(Name = "@GrantDecision")] int _grantDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantDecision);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantDecision from the dbo.Grant table.
		/// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		public void GrantDeleteByGrantDecision([Parameter(Name = "@GrantDecision")] int _grantDecision)
		{
			_GrantDeleteByGrantDecision(_grantDecision);
		}
		#endregion
        #endregion

		#region GrantDecision procedures.
		#region List procedure
		[Function(Name = "dbo.GrantDecisionList")]
		private ISingleResult<GrantDecision> _GrantDecisionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantDecision>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantDecision table.
		/// </summary>
		/// <returns>A list of GrantDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecision> GrantDecisionList()
		{
			return _GrantDecisionList().ToList<GrantDecision>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantDecisionGet")]
		private ISingleResult<GrantDecision> _GrantDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantDecision>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDecision table.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		/// <returns>Gets an instance of GrantDecision or null.</returns>
		public GrantDecision GrantDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantDecision> list = _GrantDecisionGet(_id).ToList<GrantDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantDecisionInsert")]
		private ISingleResult<GrantDecision> _GrantDecisionInsert([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@TableNumber")] string _tableNumber, [Parameter(Name = "@TableDate")] Nullable<DateTime> _tableDate, [Parameter(Name = "@BaseNumber")] string _baseNumber, [Parameter(Name = "@BaseDate")] Nullable<DateTime> _baseDate, [Parameter(Name = "@AdditionalClause")] string _additionalClause, [Parameter(Name = "@AdditionalIntroduction")] string _additionalIntroduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year, _grantTypeGroup, _date, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes, _tableNumber, _tableDate, _baseNumber, _baseDate, _additionalClause, _additionalIntroduction);
			return (result.ReturnValue) as ISingleResult<GrantDecision>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantDecision] table.
		/// </summary>
		/// <param name="instance">An instance of GrantDecision to be inserted.</param>
		/// <returns>The inserted GrantDecision</returns>
		public GrantDecision GrantDecisionInsert(GrantDecision instance)
		{
            List<GrantDecision> list = _GrantDecisionInsert(instance.Number, instance.Year, instance.GrantTypeGroup, instance.Date, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes, instance.TableNumber, instance.TableDate, instance.BaseNumber, instance.BaseDate, instance.AdditionalClause, instance.AdditionalIntroduction).ToList<GrantDecision>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantDecisionUpdate")]
		private int _GrantDecisionUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@TableNumber")] string _tableNumber, [Parameter(Name = "@TableDate")] Nullable<DateTime> _tableDate, [Parameter(Name = "@BaseNumber")] string _baseNumber, [Parameter(Name = "@BaseDate")] Nullable<DateTime> _baseDate, [Parameter(Name = "@AdditionalClause")] string _additionalClause, [Parameter(Name = "@AdditionalIntroduction")] string _additionalIntroduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _number, _year, _grantTypeGroup, _date, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes, _tableNumber, _tableDate, _baseNumber, _baseDate, _additionalClause, _additionalIntroduction);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantDecision] table.
		/// </summary>
		/// <param name="instance">An instance of GrantDecision whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantDecisionUpdate(GrantDecision instance)
		{
			_GrantDecisionUpdate(instance.Id, instance.Number, instance.Year, instance.GrantTypeGroup, instance.Date, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes, instance.TableNumber, instance.TableDate, instance.BaseNumber, instance.BaseDate, instance.AdditionalClause, instance.AdditionalIntroduction);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantDecisionDelete")]
		private int _GrantDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantDecision] table.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		public void GrantDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			_GrantDecisionDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantDecisionGetByGrantTypeGroup")]
		private ISingleResult<GrantDecision> _GrantDecisionGetByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroup);
			return (result.ReturnValue as ISingleResult<GrantDecision>);
		}

		/// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		/// <returns>A list of GrantDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecision> GrantDecisionGetByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			return _GrantDecisionGetByGrantTypeGroup(_grantTypeGroup).ToList<GrantDecision>();
		}

		/// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		/// <returns>Gets an instance of GrantDecision or null.</returns>
		public GrantDecision GrantDecisionGetByGrantTypeGroupFirstOrNull([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			List<GrantDecision> list = _GrantDecisionGetByGrantTypeGroup(_grantTypeGroup).ToList<GrantDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GrantDecisionGetByNumber_Year")]
		private ISingleResult<GrantDecision> _GrantDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<GrantDecision>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of GrantDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecision> GrantDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantDecisionGetByNumber_Year(_number, _year).ToList<GrantDecision>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>Gets an instance of GrantDecision or null.</returns>
		public GrantDecision GrantDecisionGetByNumber_YearFirstOrNull([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			List<GrantDecision> list = _GrantDecisionGetByNumber_Year(_number, _year).ToList<GrantDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantDecisionDeleteByGrantTypeGroup")]
		private int _GrantDecisionDeleteByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantDecision table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		public void GrantDecisionDeleteByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			_GrantDecisionDeleteByGrantTypeGroup(_grantTypeGroup);
		}		

        [Function(Name = "dbo.GrantDecisionDeleteByNumber_Year")]
		private int _GrantDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		public void GrantDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			_GrantDecisionDeleteByNumber_Year(_number, _year);
		}
		#endregion
        #endregion

		#region GrantDeduction procedures.
		#region List procedure
		[Function(Name = "dbo.GrantDeductionList")]
		private ISingleResult<GrantDeduction> _GrantDeductionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantDeduction>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantDeduction table.
		/// </summary>
		/// <returns>A list of GrantDeduction instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDeduction> GrantDeductionList()
		{
			return _GrantDeductionList().ToList<GrantDeduction>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantDeductionGet")]
		private ISingleResult<GrantDeduction> _GrantDeductionGet([Parameter(Name = "@Grant")] int _grant)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant);
			return (result.ReturnValue as ISingleResult<GrantDeduction>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDeduction table.
		/// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantDeduction or null.</returns>
		public GrantDeduction GrantDeductionGet([Parameter(Name = "@Grant")] int _grant)
		{
			List<GrantDeduction> list = _GrantDeductionGet(_grant).ToList<GrantDeduction>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantDeductionInsert")]
		private ISingleResult<GrantDeduction> _GrantDeductionInsert([Parameter(Name = "@Grant")] int _grant, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Description")] string _description)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant, _amount, _description);
			return (result.ReturnValue) as ISingleResult<GrantDeduction>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantDeduction] table.
		/// </summary>
		/// <param name="instance">An instance of GrantDeduction to be inserted.</param>
		/// <returns>The inserted GrantDeduction</returns>
		public GrantDeduction GrantDeductionInsert(GrantDeduction instance)
		{
            List<GrantDeduction> list = _GrantDeductionInsert(instance.Grant, instance.Amount, instance.Description).ToList<GrantDeduction>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantDeductionUpdate")]
		private int _GrantDeductionUpdate([Parameter(Name = "@Grant")] int _grant, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Description")] string _description)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant, _amount, _description);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantDeduction] table.
		/// </summary>
		/// <param name="instance">An instance of GrantDeduction whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantDeductionUpdate(GrantDeduction instance)
		{
			_GrantDeductionUpdate(instance.Grant, instance.Amount, instance.Description);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantDeductionDelete")]
		private int _GrantDeductionDelete([Parameter(Name = "@Grant")] int _grant)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantDeduction] table.
		/// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		public void GrantDeductionDelete([Parameter(Name = "@Grant")] int _grant)
		{
			_GrantDeductionDelete(_grant);
		}
		#endregion
        #endregion

		#region GrantPayment procedures.
		#region List procedure
		[Function(Name = "dbo.GrantPaymentList")]
		private ISingleResult<GrantPayment> _GrantPaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantPayment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantPayment table.
		/// </summary>
		/// <returns>A list of GrantPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPayment> GrantPaymentList()
		{
			return _GrantPaymentList().ToList<GrantPayment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantPaymentGet")]
		private ISingleResult<GrantPayment> _GrantPaymentGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantPayment>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		/// <returns>Gets an instance of GrantPayment or null.</returns>
		public GrantPayment GrantPaymentGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantPayment> list = _GrantPaymentGet(_id).ToList<GrantPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantPaymentInsert")]
		private ISingleResult<GrantPayment> _GrantPaymentInsert([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber, [Parameter(Name = "@Grant")] int _grant, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrder, _subNumber, _grant, _amount, _notes);
			return (result.ReturnValue) as ISingleResult<GrantPayment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantPayment] table.
		/// </summary>
		/// <param name="instance">An instance of GrantPayment to be inserted.</param>
		/// <returns>The inserted GrantPayment</returns>
		public GrantPayment GrantPaymentInsert(GrantPayment instance)
		{
            List<GrantPayment> list = _GrantPaymentInsert(instance.GrantPaymentOrder, instance.SubNumber, instance.Grant, instance.Amount, instance.Notes).ToList<GrantPayment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantPaymentUpdate")]
		private int _GrantPaymentUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber, [Parameter(Name = "@Grant")] int _grant, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _grantPaymentOrder, _subNumber, _grant, _amount, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantPayment] table.
		/// </summary>
		/// <param name="instance">An instance of GrantPayment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantPaymentUpdate(GrantPayment instance)
		{
			_GrantPaymentUpdate(instance.Id, instance.GrantPaymentOrder, instance.SubNumber, instance.Grant, instance.Amount, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantPaymentDelete")]
		private int _GrantPaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantPayment] table.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		public void GrantPaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			_GrantPaymentDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantPaymentGetByGrant")]
		private ISingleResult<GrantPayment> _GrantPaymentGetByGrant([Parameter(Name = "@Grant")] int _grant)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant);
			return (result.ReturnValue as ISingleResult<GrantPayment>);
		}

		/// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		/// <returns>A list of GrantPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPayment> GrantPaymentGetByGrant([Parameter(Name = "@Grant")] int _grant)
		{
			return _GrantPaymentGetByGrant(_grant).ToList<GrantPayment>();
		}

		/// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantPayment or null.</returns>
		public GrantPayment GrantPaymentGetByGrantFirstOrNull([Parameter(Name = "@Grant")] int _grant)
		{
			List<GrantPayment> list = _GrantPaymentGetByGrant(_grant).ToList<GrantPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GrantPaymentGetByGrantPaymentOrder")]
		private ISingleResult<GrantPayment> _GrantPaymentGetByGrantPaymentOrder([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrder);
			return (result.ReturnValue as ISingleResult<GrantPayment>);
		}

		/// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <returns>A list of GrantPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPayment> GrantPaymentGetByGrantPaymentOrder([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder)
		{
			return _GrantPaymentGetByGrantPaymentOrder(_grantPaymentOrder).ToList<GrantPayment>();
		}

		/// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <returns>Gets an instance of GrantPayment or null.</returns>
		public GrantPayment GrantPaymentGetByGrantPaymentOrderFirstOrNull([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder)
		{
			List<GrantPayment> list = _GrantPaymentGetByGrantPaymentOrder(_grantPaymentOrder).ToList<GrantPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GrantPaymentGetByGrantPaymentOrder_SubNumber")]
		private ISingleResult<GrantPayment> _GrantPaymentGetByGrantPaymentOrder_SubNumber([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrder, _subNumber);
			return (result.ReturnValue as ISingleResult<GrantPayment>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		/// <returns>A list of GrantPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPayment> GrantPaymentGetByGrantPaymentOrder_SubNumber([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GrantPaymentGetByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber).ToList<GrantPayment>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		/// <returns>Gets an instance of GrantPayment or null.</returns>
		public GrantPayment GrantPaymentGetByGrantPaymentOrder_SubNumberFirstOrNull([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			List<GrantPayment> list = _GrantPaymentGetByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber).ToList<GrantPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantPaymentDeleteByGrant")]
		private int _GrantPaymentDeleteByGrant([Parameter(Name = "@Grant")] int _grant)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grant);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Grant from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		public void GrantPaymentDeleteByGrant([Parameter(Name = "@Grant")] int _grant)
		{
			_GrantPaymentDeleteByGrant(_grant);
		}		

        [Function(Name = "dbo.GrantPaymentDeleteByGrantPaymentOrder")]
		private int _GrantPaymentDeleteByGrantPaymentOrder([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrder);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		public void GrantPaymentDeleteByGrantPaymentOrder([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder)
		{
			_GrantPaymentDeleteByGrantPaymentOrder(_grantPaymentOrder);
		}		

        [Function(Name = "dbo.GrantPaymentDeleteByGrantPaymentOrder_SubNumber")]
		private int _GrantPaymentDeleteByGrantPaymentOrder_SubNumber([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrder, _subNumber);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of GrantPaymentOrder, SubNumber columns in the  dbo.GrantPayment table.
		/// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		public void GrantPaymentDeleteByGrantPaymentOrder_SubNumber([Parameter(Name = "@GrantPaymentOrder")] int _grantPaymentOrder, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			_GrantPaymentDeleteByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber);
		}
		#endregion
        #endregion

		#region GrantPaymentOrder procedures.
		#region List procedure
		[Function(Name = "dbo.GrantPaymentOrderList")]
		private ISingleResult<GrantPaymentOrder> _GrantPaymentOrderList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantPaymentOrder>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrder table.
		/// </summary>
		/// <returns>A list of GrantPaymentOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrder> GrantPaymentOrderList()
		{
			return _GrantPaymentOrderList().ToList<GrantPaymentOrder>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantPaymentOrderGet")]
		private ISingleResult<GrantPaymentOrder> _GrantPaymentOrderGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrder>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		/// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
		public GrantPaymentOrder GrantPaymentOrderGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantPaymentOrder> list = _GrantPaymentOrderGet(_id).ToList<GrantPaymentOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantPaymentOrderInsert")]
		private ISingleResult<GrantPaymentOrder> _GrantPaymentOrderInsert([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year, _date, _notes);
			return (result.ReturnValue) as ISingleResult<GrantPaymentOrder>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantPaymentOrder] table.
		/// </summary>
		/// <param name="instance">An instance of GrantPaymentOrder to be inserted.</param>
		/// <returns>The inserted GrantPaymentOrder</returns>
		public GrantPaymentOrder GrantPaymentOrderInsert(GrantPaymentOrder instance)
		{
            List<GrantPaymentOrder> list = _GrantPaymentOrderInsert(instance.Number, instance.Year, instance.Date, instance.Notes).ToList<GrantPaymentOrder>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantPaymentOrderUpdate")]
		private int _GrantPaymentOrderUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _number, _year, _date, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantPaymentOrder] table.
		/// </summary>
		/// <param name="instance">An instance of GrantPaymentOrder whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantPaymentOrderUpdate(GrantPaymentOrder instance)
		{
			_GrantPaymentOrderUpdate(instance.Id, instance.Number, instance.Year, instance.Date, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantPaymentOrderDelete")]
		private int _GrantPaymentOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantPaymentOrder] table.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		public void GrantPaymentOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			_GrantPaymentOrderDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantPaymentOrderGetByDate")]
		private ISingleResult<GrantPaymentOrder> _GrantPaymentOrderGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrder>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrder> GrantPaymentOrderGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _GrantPaymentOrderGetByDate(_date).ToList<GrantPaymentOrder>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		/// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
		public GrantPaymentOrder GrantPaymentOrderGetByDateFirstOrNull([Parameter(Name = "@Date")] DateTime _date)
		{
			List<GrantPaymentOrder> list = _GrantPaymentOrderGetByDate(_date).ToList<GrantPaymentOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GrantPaymentOrderGetByNumber_Year")]
		private ISingleResult<GrantPaymentOrder> _GrantPaymentOrderGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrder>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrder> GrantPaymentOrderGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantPaymentOrderGetByNumber_Year(_number, _year).ToList<GrantPaymentOrder>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		/// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
		public GrantPaymentOrder GrantPaymentOrderGetByNumber_YearFirstOrNull([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			List<GrantPaymentOrder> list = _GrantPaymentOrderGetByNumber_Year(_number, _year).ToList<GrantPaymentOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantPaymentOrderDeleteByDate")]
		private int _GrantPaymentOrderDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		public void GrantPaymentOrderDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			_GrantPaymentOrderDeleteByDate(_date);
		}		

        [Function(Name = "dbo.GrantPaymentOrderDeleteByNumber_Year")]
		private int _GrantPaymentOrderDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantPaymentOrder table.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		public void GrantPaymentOrderDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			_GrantPaymentOrderDeleteByNumber_Year(_number, _year);
		}
		#endregion
        #endregion

		#region GrantRequest procedures.
		#region List procedure
		[Function(Name = "dbo.GrantRequestList")]
		private ISingleResult<GrantRequest> _GrantRequestList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantRequest>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantRequest table.
		/// </summary>
		/// <returns>A list of GrantRequest instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantRequest> GrantRequestList()
		{
			return _GrantRequestList().ToList<GrantRequest>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantRequestGet")]
		private ISingleResult<GrantRequest> _GrantRequestGet([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return (result.ReturnValue as ISingleResult<GrantRequest>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantRequest table.
		/// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequest or null.</returns>
		public GrantRequest GrantRequestGet([Parameter(Name = "@Request")] int _request)
		{
			List<GrantRequest> list = _GrantRequestGet(_request).ToList<GrantRequest>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantRequestInsert")]
		private ISingleResult<GrantRequest> _GrantRequestInsert([Parameter(Name = "@Request")] int _request, [Parameter(Name = "@GrantType")] byte _grantType, [Parameter(Name = "@Description")] string _description, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@EventDate")] DateTime _eventDate, [Parameter(Name = "@IsFromOtherBranch")] bool _isFromOtherBranch)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request, _grantType, _description, _amount, _notes, _eventDate, _isFromOtherBranch);
			return (result.ReturnValue) as ISingleResult<GrantRequest>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantRequest] table.
		/// </summary>
		/// <param name="instance">An instance of GrantRequest to be inserted.</param>
		/// <returns>The inserted GrantRequest</returns>
		public GrantRequest GrantRequestInsert(GrantRequest instance)
		{
            List<GrantRequest> list = _GrantRequestInsert(instance.Request, instance.GrantType, instance.Description, instance.Amount, instance.Notes, instance.EventDate, instance.IsFromOtherBranch).ToList<GrantRequest>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantRequestUpdate")]
		private int _GrantRequestUpdate([Parameter(Name = "@Request")] int _request, [Parameter(Name = "@GrantType")] byte _grantType, [Parameter(Name = "@Description")] string _description, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@EventDate")] DateTime _eventDate, [Parameter(Name = "@IsFromOtherBranch")] bool _isFromOtherBranch)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request, _grantType, _description, _amount, _notes, _eventDate, _isFromOtherBranch);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantRequest] table.
		/// </summary>
		/// <param name="instance">An instance of GrantRequest whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantRequestUpdate(GrantRequest instance)
		{
			_GrantRequestUpdate(instance.Request, instance.GrantType, instance.Description, instance.Amount, instance.Notes, instance.EventDate, instance.IsFromOtherBranch);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantRequestDelete")]
		private int _GrantRequestDelete([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantRequest] table.
		/// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
		public void GrantRequestDelete([Parameter(Name = "@Request")] int _request)
		{
			_GrantRequestDelete(_request);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantRequestGetByGrantType")]
		private ISingleResult<GrantRequest> _GrantRequestGetByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantType);
			return (result.ReturnValue as ISingleResult<GrantRequest>);
		}

		/// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		/// <returns>A list of GrantRequest instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantRequest> GrantRequestGetByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			return _GrantRequestGetByGrantType(_grantType).ToList<GrantRequest>();
		}

		/// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		/// <returns>Gets an instance of GrantRequest or null.</returns>
		public GrantRequest GrantRequestGetByGrantTypeFirstOrNull([Parameter(Name = "@GrantType")] byte _grantType)
		{
			List<GrantRequest> list = _GrantRequestGetByGrantType(_grantType).ToList<GrantRequest>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantRequestDeleteByGrantType")]
		private int _GrantRequestDeleteByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantType from the dbo.GrantRequest table.
		/// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		public void GrantRequestDeleteByGrantType([Parameter(Name = "@GrantType")] byte _grantType)
		{
			_GrantRequestDeleteByGrantType(_grantType);
		}
		#endregion
        #endregion

		#region GrantType procedures.
		#region List procedure
		[Function(Name = "dbo.GrantTypeList")]
		private ISingleResult<GrantType> _GrantTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantType table.
		/// </summary>
		/// <returns>A list of GrantType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantType> GrantTypeList()
		{
			return _GrantTypeList().ToList<GrantType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantTypeGet")]
		private ISingleResult<GrantType> _GrantTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantType>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantType table.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		/// <returns>Gets an instance of GrantType or null.</returns>
		public GrantType GrantTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GrantType> list = _GrantTypeGet(_id).ToList<GrantType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantTypeInsert")]
		private ISingleResult<GrantType> _GrantTypeInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _amount, _grantTypeGroup);
			return (result.ReturnValue) as ISingleResult<GrantType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantType] table.
		/// </summary>
		/// <param name="instance">An instance of GrantType to be inserted.</param>
		/// <returns>The inserted GrantType</returns>
		public GrantType GrantTypeInsert(GrantType instance)
		{
            List<GrantType> list = _GrantTypeInsert(instance.Name, instance.Amount, instance.GrantTypeGroup).ToList<GrantType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantTypeUpdate")]
		private int _GrantTypeUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _amount, _grantTypeGroup);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantType] table.
		/// </summary>
		/// <param name="instance">An instance of GrantType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantTypeUpdate(GrantType instance)
		{
			_GrantTypeUpdate(instance.Id, instance.Name, instance.Amount, instance.GrantTypeGroup);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantTypeDelete")]
		private int _GrantTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantType] table.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		public void GrantTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			_GrantTypeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantTypeGetByGrantTypeGroup")]
		private ISingleResult<GrantType> _GrantTypeGetByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroup);
			return (result.ReturnValue as ISingleResult<GrantType>);
		}

		/// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantType> GrantTypeGetByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			return _GrantTypeGetByGrantTypeGroup(_grantTypeGroup).ToList<GrantType>();
		}

		/// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantType or null.</returns>
		public GrantType GrantTypeGetByGrantTypeGroupFirstOrNull([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			List<GrantType> list = _GrantTypeGetByGrantTypeGroup(_grantTypeGroup).ToList<GrantType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GrantTypeGetByName")]
		private ISingleResult<GrantType> _GrantTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GrantType>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		/// <returns>A list of GrantType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantType> GrantTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeGetByName(_name).ToList<GrantType>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		/// <returns>Gets an instance of GrantType or null.</returns>
		public GrantType GrantTypeGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<GrantType> list = _GrantTypeGetByName(_name).ToList<GrantType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantTypeDeleteByGrantTypeGroup")]
		private int _GrantTypeDeleteByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantType table.
		/// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		public void GrantTypeDeleteByGrantTypeGroup([Parameter(Name = "@GrantTypeGroup")] byte _grantTypeGroup)
		{
			_GrantTypeDeleteByGrantTypeGroup(_grantTypeGroup);
		}		

        [Function(Name = "dbo.GrantTypeDeleteByName")]
		private int _GrantTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantType table.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		public void GrantTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_GrantTypeDeleteByName(_name);
		}
		#endregion
        #endregion

		#region GrantTypeGroup procedures.
		#region List procedure
		[Function(Name = "dbo.GrantTypeGroupList")]
		private ISingleResult<GrantTypeGroup> _GrantTypeGroupList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantTypeGroup>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantTypeGroup table.
		/// </summary>
		/// <returns>A list of GrantTypeGroup instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeGroup> GrantTypeGroupList()
		{
			return _GrantTypeGroupList().ToList<GrantTypeGroup>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantTypeGroupGet")]
		private ISingleResult<GrantTypeGroup> _GrantTypeGroupGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantTypeGroup>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantTypeGroup table.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroup or null.</returns>
		public GrantTypeGroup GrantTypeGroupGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GrantTypeGroup> list = _GrantTypeGroupGet(_id).ToList<GrantTypeGroup>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GrantTypeGroupInsert")]
		private ISingleResult<GrantTypeGroup> _GrantTypeGroupInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<GrantTypeGroup>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GrantTypeGroup] table.
		/// </summary>
		/// <param name="instance">An instance of GrantTypeGroup to be inserted.</param>
		/// <returns>The inserted GrantTypeGroup</returns>
		public GrantTypeGroup GrantTypeGroupInsert(GrantTypeGroup instance)
		{
            List<GrantTypeGroup> list = _GrantTypeGroupInsert(instance.Name).ToList<GrantTypeGroup>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GrantTypeGroupUpdate")]
		private int _GrantTypeGroupUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GrantTypeGroup] table.
		/// </summary>
		/// <param name="instance">An instance of GrantTypeGroup whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GrantTypeGroupUpdate(GrantTypeGroup instance)
		{
			_GrantTypeGroupUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GrantTypeGroupDelete")]
		private int _GrantTypeGroupDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GrantTypeGroup] table.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		public void GrantTypeGroupDelete([Parameter(Name = "@Id")] byte _id)
		{
			_GrantTypeGroupDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantTypeGroupGetByName")]
		private ISingleResult<GrantTypeGroup> _GrantTypeGroupGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GrantTypeGroup>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantTypeGroup instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeGroup> GrantTypeGroupGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeGroupGetByName(_name).ToList<GrantTypeGroup>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroup or null.</returns>
		public GrantTypeGroup GrantTypeGroupGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<GrantTypeGroup> list = _GrantTypeGroupGetByName(_name).ToList<GrantTypeGroup>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GrantTypeGroupDeleteByName")]
		private int _GrantTypeGroupDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantTypeGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		public void GrantTypeGroupDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_GrantTypeGroupDeleteByName(_name);
		}
		#endregion
        #endregion

		#region Guarantor procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorList")]
		private ISingleResult<Guarantor> _GuarantorList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Guarantor table.
		/// </summary>
		/// <returns>A list of Guarantor instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Guarantor> GuarantorList()
		{
			return _GuarantorList().ToList<Guarantor>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorGet")]
		private ISingleResult<Guarantor> _GuarantorGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Gets one row from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of Guarantor or null.</returns>
		public Guarantor GuarantorGet([Parameter(Name = "@Id")] int _id)
		{
			List<Guarantor> list = _GuarantorGet(_id).ToList<Guarantor>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GuarantorInsert")]
		private ISingleResult<Guarantor> _GuarantorInsert([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber, _employee, _guarantorStatus, _notes);
			return (result.ReturnValue) as ISingleResult<Guarantor>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Guarantor] table.
		/// </summary>
		/// <param name="instance">An instance of Guarantor to be inserted.</param>
		/// <returns>The inserted Guarantor</returns>
		public Guarantor GuarantorInsert(Guarantor instance)
		{
            List<Guarantor> list = _GuarantorInsert(instance.RefundableProduct, instance.SubNumber, instance.Employee, instance.GuarantorStatus, instance.Notes).ToList<Guarantor>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GuarantorUpdate")]
		private int _GuarantorUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _refundableProduct, _subNumber, _employee, _guarantorStatus, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Guarantor] table.
		/// </summary>
		/// <param name="instance">An instance of Guarantor whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GuarantorUpdate(Guarantor instance)
		{
			_GuarantorUpdate(instance.Id, instance.RefundableProduct, instance.SubNumber, instance.Employee, instance.GuarantorStatus, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GuarantorDelete")]
		private int _GuarantorDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Guarantor] table.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		public void GuarantorDelete([Parameter(Name = "@Id")] int _id)
		{
			_GuarantorDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GuarantorGetByEmployee")]
		private ISingleResult<Guarantor> _GuarantorGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		/// <returns>A list of Guarantor instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Guarantor> GuarantorGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _GuarantorGetByEmployee(_employee).ToList<Guarantor>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		/// <returns>Gets an instance of Guarantor or null.</returns>
		public Guarantor GuarantorGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Guarantor> list = _GuarantorGetByEmployee(_employee).ToList<Guarantor>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GuarantorGetByGuarantorStatus")]
		private ISingleResult<Guarantor> _GuarantorGetByGuarantorStatus([Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantorStatus);
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		/// <returns>A list of Guarantor instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Guarantor> GuarantorGetByGuarantorStatus([Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus)
		{
			return _GuarantorGetByGuarantorStatus(_guarantorStatus).ToList<Guarantor>();
		}

		/// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		/// <returns>Gets an instance of Guarantor or null.</returns>
		public Guarantor GuarantorGetByGuarantorStatusFirstOrNull([Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus)
		{
			List<Guarantor> list = _GuarantorGetByGuarantorStatus(_guarantorStatus).ToList<Guarantor>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GuarantorGetByRefundableProduct")]
		private ISingleResult<Guarantor> _GuarantorGetByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct);
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <returns>A list of Guarantor instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Guarantor> GuarantorGetByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			return _GuarantorGetByRefundableProduct(_refundableProduct).ToList<Guarantor>();
		}

		/// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <returns>Gets an instance of Guarantor or null.</returns>
		public Guarantor GuarantorGetByRefundableProductFirstOrNull([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			List<Guarantor> list = _GuarantorGetByRefundableProduct(_refundableProduct).ToList<Guarantor>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.GuarantorGetByRefundableProduct_SubNumber")]
		private ISingleResult<Guarantor> _GuarantorGetByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber);
			return (result.ReturnValue as ISingleResult<Guarantor>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>A list of Guarantor instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Guarantor> GuarantorGetByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GuarantorGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber).ToList<Guarantor>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>Gets an instance of Guarantor or null.</returns>
		public Guarantor GuarantorGetByRefundableProduct_SubNumberFirstOrNull([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			List<Guarantor> list = _GuarantorGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber).ToList<Guarantor>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GuarantorDeleteByEmployee")]
		private int _GuarantorDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		public void GuarantorDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_GuarantorDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.GuarantorDeleteByGuarantorStatus")]
		private int _GuarantorDeleteByGuarantorStatus([Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantorStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one GuarantorStatus from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		public void GuarantorDeleteByGuarantorStatus([Parameter(Name = "@GuarantorStatus")] byte _guarantorStatus)
		{
			_GuarantorDeleteByGuarantorStatus(_guarantorStatus);
		}		

        [Function(Name = "dbo.GuarantorDeleteByRefundableProduct")]
		private int _GuarantorDeleteByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		public void GuarantorDeleteByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			_GuarantorDeleteByRefundableProduct(_refundableProduct);
		}		

        [Function(Name = "dbo.GuarantorDeleteByRefundableProduct_SubNumber")]
		private int _GuarantorDeleteByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Guarantor table.
		/// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		public void GuarantorDeleteByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			_GuarantorDeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
		}
		#endregion
        #endregion

		#region GuarantorStatement procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorStatementList")]
		private ISingleResult<GuarantorStatement> _GuarantorStatementList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorStatement>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorStatement table.
		/// </summary>
		/// <returns>A list of GuarantorStatement instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatement> GuarantorStatementList()
		{
			return _GuarantorStatementList().ToList<GuarantorStatement>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorStatementGet")]
		private ISingleResult<GuarantorStatement> _GuarantorStatementGet([Parameter(Name = "@Guarantor")] int _guarantor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantor);
			return (result.ReturnValue as ISingleResult<GuarantorStatement>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorStatement table.
		/// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatement or null.</returns>
		public GuarantorStatement GuarantorStatementGet([Parameter(Name = "@Guarantor")] int _guarantor)
		{
			List<GuarantorStatement> list = _GuarantorStatementGet(_guarantor).ToList<GuarantorStatement>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GuarantorStatementInsert")]
		private ISingleResult<GuarantorStatement> _GuarantorStatementInsert([Parameter(Name = "@Guarantor")] int _guarantor, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@DeductionsAmount")] Nullable<decimal> _deductionsAmount, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary, [Parameter(Name = "@ExceptionalIncome")] Nullable<decimal> _exceptionalIncome)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantor, _grossSalary, _deductionsAmount, _netSalary, _exceptionalIncome);
			return (result.ReturnValue) as ISingleResult<GuarantorStatement>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatement] table.
		/// </summary>
		/// <param name="instance">An instance of GuarantorStatement to be inserted.</param>
		/// <returns>The inserted GuarantorStatement</returns>
		public GuarantorStatement GuarantorStatementInsert(GuarantorStatement instance)
		{
            List<GuarantorStatement> list = _GuarantorStatementInsert(instance.Guarantor, instance.GrossSalary, instance.DeductionsAmount, instance.NetSalary, instance.ExceptionalIncome).ToList<GuarantorStatement>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GuarantorStatementUpdate")]
		private int _GuarantorStatementUpdate([Parameter(Name = "@Guarantor")] int _guarantor, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@DeductionsAmount")] Nullable<decimal> _deductionsAmount, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary, [Parameter(Name = "@ExceptionalIncome")] Nullable<decimal> _exceptionalIncome)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantor, _grossSalary, _deductionsAmount, _netSalary, _exceptionalIncome);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GuarantorStatement] table.
		/// </summary>
		/// <param name="instance">An instance of GuarantorStatement whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GuarantorStatementUpdate(GuarantorStatement instance)
		{
			_GuarantorStatementUpdate(instance.Guarantor, instance.GrossSalary, instance.DeductionsAmount, instance.NetSalary, instance.ExceptionalIncome);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GuarantorStatementDelete")]
		private int _GuarantorStatementDelete([Parameter(Name = "@Guarantor")] int _guarantor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantor);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatement] table.
		/// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
		public void GuarantorStatementDelete([Parameter(Name = "@Guarantor")] int _guarantor)
		{
			_GuarantorStatementDelete(_guarantor);
		}
		#endregion
        #endregion

		#region GuarantorStatus procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorStatusList")]
		private ISingleResult<GuarantorStatus> _GuarantorStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorStatus table.
		/// </summary>
		/// <returns>A list of GuarantorStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatus> GuarantorStatusList()
		{
			return _GuarantorStatusList().ToList<GuarantorStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorStatusGet")]
		private ISingleResult<GuarantorStatus> _GuarantorStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GuarantorStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorStatus table.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatus or null.</returns>
		public GuarantorStatus GuarantorStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GuarantorStatus> list = _GuarantorStatusGet(_id).ToList<GuarantorStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.GuarantorStatusInsert")]
		private ISingleResult<GuarantorStatus> _GuarantorStatusInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<GuarantorStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatus] table.
		/// </summary>
		/// <param name="instance">An instance of GuarantorStatus to be inserted.</param>
		/// <returns>The inserted GuarantorStatus</returns>
		public GuarantorStatus GuarantorStatusInsert(GuarantorStatus instance)
		{
            List<GuarantorStatus> list = _GuarantorStatusInsert(instance.Id, instance.Name).ToList<GuarantorStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.GuarantorStatusUpdate")]
		private int _GuarantorStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[GuarantorStatus] table.
		/// </summary>
		/// <param name="instance">An instance of GuarantorStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void GuarantorStatusUpdate(GuarantorStatus instance)
		{
			_GuarantorStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.GuarantorStatusDelete")]
		private int _GuarantorStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatus] table.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		public void GuarantorStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_GuarantorStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GuarantorStatusGetByName")]
		private ISingleResult<GuarantorStatus> _GuarantorStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GuarantorStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		/// <returns>A list of GuarantorStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatus> GuarantorStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GuarantorStatusGetByName(_name).ToList<GuarantorStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatus or null.</returns>
		public GuarantorStatus GuarantorStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<GuarantorStatus> list = _GuarantorStatusGetByName(_name).ToList<GuarantorStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.GuarantorStatusDeleteByName")]
		private int _GuarantorStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GuarantorStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		public void GuarantorStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_GuarantorStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region HealthLoanDecision procedures.
		#region List procedure
		[Function(Name = "dbo.HealthLoanDecisionList")]
		private ISingleResult<HealthLoanDecision> _HealthLoanDecisionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<HealthLoanDecision>);
		}

		/// <summary>
		/// Selects all rows from the dbo.HealthLoanDecision table.
		/// </summary>
		/// <returns>A list of HealthLoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecision> HealthLoanDecisionList()
		{
			return _HealthLoanDecisionList().ToList<HealthLoanDecision>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.HealthLoanDecisionGet")]
		private ISingleResult<HealthLoanDecision> _HealthLoanDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<HealthLoanDecision>);
		}

		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		/// <returns>Gets an instance of HealthLoanDecision or null.</returns>
		public HealthLoanDecision HealthLoanDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			List<HealthLoanDecision> list = _HealthLoanDecisionGet(_id).ToList<HealthLoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.HealthLoanDecisionInsert")]
		private ISingleResult<HealthLoanDecision> _HealthLoanDecisionInsert([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year, _date, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes);
			return (result.ReturnValue) as ISingleResult<HealthLoanDecision>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecision] table.
		/// </summary>
		/// <param name="instance">An instance of HealthLoanDecision to be inserted.</param>
		/// <returns>The inserted HealthLoanDecision</returns>
		public HealthLoanDecision HealthLoanDecisionInsert(HealthLoanDecision instance)
		{
            List<HealthLoanDecision> list = _HealthLoanDecisionInsert(instance.Number, instance.Year, instance.Date, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes).ToList<HealthLoanDecision>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.HealthLoanDecisionUpdate")]
		private int _HealthLoanDecisionUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _number, _year, _date, _cersNumber, _cersDate, _paymentNumber, _paymentDate, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecision] table.
		/// </summary>
		/// <param name="instance">An instance of HealthLoanDecision whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void HealthLoanDecisionUpdate(HealthLoanDecision instance)
		{
			_HealthLoanDecisionUpdate(instance.Id, instance.Number, instance.Year, instance.Date, instance.CersNumber, instance.CersDate, instance.PaymentNumber, instance.PaymentDate, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.HealthLoanDecisionDelete")]
		private int _HealthLoanDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecision] table.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		public void HealthLoanDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			_HealthLoanDecisionDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.HealthLoanDecisionGetByDate")]
		private ISingleResult<HealthLoanDecision> _HealthLoanDecisionGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<HealthLoanDecision>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		/// <returns>A list of HealthLoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecision> HealthLoanDecisionGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _HealthLoanDecisionGetByDate(_date).ToList<HealthLoanDecision>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		/// <returns>Gets an instance of HealthLoanDecision or null.</returns>
		public HealthLoanDecision HealthLoanDecisionGetByDateFirstOrNull([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			List<HealthLoanDecision> list = _HealthLoanDecisionGetByDate(_date).ToList<HealthLoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionGetByNumber_Year")]
		private ISingleResult<HealthLoanDecision> _HealthLoanDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<HealthLoanDecision>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		/// <returns>A list of HealthLoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecision> HealthLoanDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _HealthLoanDecisionGetByNumber_Year(_number, _year).ToList<HealthLoanDecision>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		/// <returns>Gets an instance of HealthLoanDecision or null.</returns>
		public HealthLoanDecision HealthLoanDecisionGetByNumber_YearFirstOrNull([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			List<HealthLoanDecision> list = _HealthLoanDecisionGetByNumber_Year(_number, _year).ToList<HealthLoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.HealthLoanDecisionDeleteByDate")]
		private int _HealthLoanDecisionDeleteByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		public void HealthLoanDecisionDeleteByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			_HealthLoanDecisionDeleteByDate(_date);
		}		

        [Function(Name = "dbo.HealthLoanDecisionDeleteByNumber_Year")]
		private int _HealthLoanDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.HealthLoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		public void HealthLoanDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			_HealthLoanDecisionDeleteByNumber_Year(_number, _year);
		}
		#endregion
        #endregion

		#region HealthLoanDecisionFirstPayment procedures.
		#region List procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentList")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentList()
		{
			return _HealthLoanDecisionFirstPaymentList().ToList<HealthLoanDecisionFirstPayment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGet")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGet([Parameter(Name = "@Id")] int _id)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGet(_id).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentInsert")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate, [Parameter(Name = "@PaymentAmount")] Nullable<decimal> _paymentAmount, [Parameter(Name = "@PaymentNotes")] string _paymentNotes, [Parameter(Name = "@InvoiceDate")] Nullable<DateTime> _invoiceDate, [Parameter(Name = "@InvoiceAmount")] Nullable<decimal> _invoiceAmount, [Parameter(Name = "@InvoiceNotes")] string _invoiceNotes, [Parameter(Name = "@InsuranceDate")] Nullable<DateTime> _insuranceDate, [Parameter(Name = "@InsuranceAmount")] Nullable<decimal> _insuranceAmount, [Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType, [Parameter(Name = "@InsuranceNotes")] string _insuranceNotes, [Parameter(Name = "@BoardDate")] Nullable<DateTime> _boardDate, [Parameter(Name = "@BoardAmount")] Nullable<decimal> _boardAmount, [Parameter(Name = "@BoardType")] Nullable<byte> _boardType, [Parameter(Name = "@BoardNotes")] string _boardNotes, [Parameter(Name = "@DirectPaymentDate")] Nullable<DateTime> _directPaymentDate, [Parameter(Name = "@DirectPaymentAmount")] Nullable<decimal> _directPaymentAmount, [Parameter(Name = "@DirectPaymentNotes")] string _directPaymentNotes, [Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@Department")] Nullable<int> _department, [Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision, [Parameter(Name = "@RequestCost")] Nullable<decimal> _requestCost, [Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentDate, _paymentAmount, _paymentNotes, _invoiceDate, _invoiceAmount, _invoiceNotes, _insuranceDate, _insuranceAmount, _insuranceType, _insuranceNotes, _boardDate, _boardAmount, _boardType, _boardNotes, _directPaymentDate, _directPaymentAmount, _directPaymentNotes, _paymentStatus, _notes, _department, _healthLoanDecision, _requestCost, _loanRequest);
			return (result.ReturnValue) as ISingleResult<HealthLoanDecisionFirstPayment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecisionFirstPayment] table.
		/// </summary>
		/// <param name="instance">An instance of HealthLoanDecisionFirstPayment to be inserted.</param>
		/// <returns>The inserted HealthLoanDecisionFirstPayment</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentInsert(HealthLoanDecisionFirstPayment instance)
		{
            List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentInsert(instance.Employee, instance.PaymentDate, instance.PaymentAmount, instance.PaymentNotes, instance.InvoiceDate, instance.InvoiceAmount, instance.InvoiceNotes, instance.InsuranceDate, instance.InsuranceAmount, instance.InsuranceType, instance.InsuranceNotes, instance.BoardDate, instance.BoardAmount, instance.BoardType, instance.BoardNotes, instance.DirectPaymentDate, instance.DirectPaymentAmount, instance.DirectPaymentNotes, instance.PaymentStatus, instance.Notes, instance.Department, instance.HealthLoanDecision, instance.RequestCost, instance.LoanRequest).ToList<HealthLoanDecisionFirstPayment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentUpdate")]
		private int _HealthLoanDecisionFirstPaymentUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate, [Parameter(Name = "@PaymentAmount")] Nullable<decimal> _paymentAmount, [Parameter(Name = "@PaymentNotes")] string _paymentNotes, [Parameter(Name = "@InvoiceDate")] Nullable<DateTime> _invoiceDate, [Parameter(Name = "@InvoiceAmount")] Nullable<decimal> _invoiceAmount, [Parameter(Name = "@InvoiceNotes")] string _invoiceNotes, [Parameter(Name = "@InsuranceDate")] Nullable<DateTime> _insuranceDate, [Parameter(Name = "@InsuranceAmount")] Nullable<decimal> _insuranceAmount, [Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType, [Parameter(Name = "@InsuranceNotes")] string _insuranceNotes, [Parameter(Name = "@BoardDate")] Nullable<DateTime> _boardDate, [Parameter(Name = "@BoardAmount")] Nullable<decimal> _boardAmount, [Parameter(Name = "@BoardType")] Nullable<byte> _boardType, [Parameter(Name = "@BoardNotes")] string _boardNotes, [Parameter(Name = "@DirectPaymentDate")] Nullable<DateTime> _directPaymentDate, [Parameter(Name = "@DirectPaymentAmount")] Nullable<decimal> _directPaymentAmount, [Parameter(Name = "@DirectPaymentNotes")] string _directPaymentNotes, [Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@Department")] Nullable<int> _department, [Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision, [Parameter(Name = "@RequestCost")] Nullable<decimal> _requestCost, [Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _paymentDate, _paymentAmount, _paymentNotes, _invoiceDate, _invoiceAmount, _invoiceNotes, _insuranceDate, _insuranceAmount, _insuranceType, _insuranceNotes, _boardDate, _boardAmount, _boardType, _boardNotes, _directPaymentDate, _directPaymentAmount, _directPaymentNotes, _paymentStatus, _notes, _department, _healthLoanDecision, _requestCost, _loanRequest);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecisionFirstPayment] table.
		/// </summary>
		/// <param name="instance">An instance of HealthLoanDecisionFirstPayment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void HealthLoanDecisionFirstPaymentUpdate(HealthLoanDecisionFirstPayment instance)
		{
			_HealthLoanDecisionFirstPaymentUpdate(instance.Id, instance.Employee, instance.PaymentDate, instance.PaymentAmount, instance.PaymentNotes, instance.InvoiceDate, instance.InvoiceAmount, instance.InvoiceNotes, instance.InsuranceDate, instance.InsuranceAmount, instance.InsuranceType, instance.InsuranceNotes, instance.BoardDate, instance.BoardAmount, instance.BoardType, instance.BoardNotes, instance.DirectPaymentDate, instance.DirectPaymentAmount, instance.DirectPaymentNotes, instance.PaymentStatus, instance.Notes, instance.Department, instance.HealthLoanDecision, instance.RequestCost, instance.LoanRequest);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentDelete")]
		private int _HealthLoanDecisionFirstPaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecisionFirstPayment] table.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		public void HealthLoanDecisionFirstPaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			_HealthLoanDecisionFirstPaymentDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByDepartment")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			return _HealthLoanDecisionFirstPaymentGetByDepartment(_department).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByDepartmentFirstOrNull([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByDepartment(_department).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByEmployee")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _HealthLoanDecisionFirstPaymentGetByEmployee(_employee).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByEmployee(_employee).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentDate);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			return _HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate(_employee, _paymentDate).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDateFirstOrNull([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate(_employee, _paymentDate).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByHealthLoanDecision")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByHealthLoanDecision([Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _healthLoanDecision);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByHealthLoanDecision([Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision)
		{
			return _HealthLoanDecisionFirstPaymentGetByHealthLoanDecision(_healthLoanDecision).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByHealthLoanDecisionFirstOrNull([Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByHealthLoanDecision(_healthLoanDecision).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByInsuranceType")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByInsuranceType([Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _insuranceType);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByInsuranceType([Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType)
		{
			return _HealthLoanDecisionFirstPaymentGetByInsuranceType(_insuranceType).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByInsuranceTypeFirstOrNull([Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByInsuranceType(_insuranceType).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByLoanRequest")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			return _HealthLoanDecisionFirstPaymentGetByLoanRequest(_loanRequest).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByLoanRequestFirstOrNull([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByLoanRequest(_loanRequest).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentGetByPaymentStatus")]
		private ISingleResult<HealthLoanDecisionFirstPayment> _HealthLoanDecisionFirstPaymentGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatus);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPayment>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		/// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			return _HealthLoanDecisionFirstPaymentGetByPaymentStatus(_paymentStatus).ToList<HealthLoanDecisionFirstPayment>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
		public HealthLoanDecisionFirstPayment HealthLoanDecisionFirstPaymentGetByPaymentStatusFirstOrNull([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			List<HealthLoanDecisionFirstPayment> list = _HealthLoanDecisionFirstPaymentGetByPaymentStatus(_paymentStatus).ToList<HealthLoanDecisionFirstPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByDepartment")]
		private int _HealthLoanDecisionFirstPaymentDeleteByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		public void HealthLoanDecisionFirstPaymentDeleteByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			_HealthLoanDecisionFirstPaymentDeleteByDepartment(_department);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByEmployee")]
		private int _HealthLoanDecisionFirstPaymentDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void HealthLoanDecisionFirstPaymentDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_HealthLoanDecisionFirstPaymentDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByEmployee_PaymentDate")]
		private int _HealthLoanDecisionFirstPaymentDeleteByEmployee_PaymentDate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentDate);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Employee, PaymentDate columns in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		public void HealthLoanDecisionFirstPaymentDeleteByEmployee_PaymentDate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			_HealthLoanDecisionFirstPaymentDeleteByEmployee_PaymentDate(_employee, _paymentDate);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByHealthLoanDecision")]
		private int _HealthLoanDecisionFirstPaymentDeleteByHealthLoanDecision([Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _healthLoanDecision);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		public void HealthLoanDecisionFirstPaymentDeleteByHealthLoanDecision([Parameter(Name = "@HealthLoanDecision")] Nullable<int> _healthLoanDecision)
		{
			_HealthLoanDecisionFirstPaymentDeleteByHealthLoanDecision(_healthLoanDecision);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByInsuranceType")]
		private int _HealthLoanDecisionFirstPaymentDeleteByInsuranceType([Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _insuranceType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		public void HealthLoanDecisionFirstPaymentDeleteByInsuranceType([Parameter(Name = "@InsuranceType")] Nullable<byte> _insuranceType)
		{
			_HealthLoanDecisionFirstPaymentDeleteByInsuranceType(_insuranceType);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByLoanRequest")]
		private int _HealthLoanDecisionFirstPaymentDeleteByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		public void HealthLoanDecisionFirstPaymentDeleteByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			_HealthLoanDecisionFirstPaymentDeleteByLoanRequest(_loanRequest);
		}		

        [Function(Name = "dbo.HealthLoanDecisionFirstPaymentDeleteByPaymentStatus")]
		private int _HealthLoanDecisionFirstPaymentDeleteByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPayment table.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		public void HealthLoanDecisionFirstPaymentDeleteByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			_HealthLoanDecisionFirstPaymentDeleteByPaymentStatus(_paymentStatus);
		}
		#endregion
        #endregion

		#region IncomingLoan procedures.
		#region List procedure
		[Function(Name = "dbo.IncomingLoanList")]
		private ISingleResult<IncomingLoan> _IncomingLoanList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<IncomingLoan>);
		}

		/// <summary>
		/// Selects all rows from the dbo.IncomingLoan table.
		/// </summary>
		/// <returns>A list of IncomingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IncomingLoan> IncomingLoanList()
		{
			return _IncomingLoanList().ToList<IncomingLoan>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.IncomingLoanGet")]
		private ISingleResult<IncomingLoan> _IncomingLoanGet([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return (result.ReturnValue as ISingleResult<IncomingLoan>);
		}

		/// <summary>
		/// Gets one row from the dbo.IncomingLoan table.
		/// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of IncomingLoan or null.</returns>
		public IncomingLoan IncomingLoanGet([Parameter(Name = "@Loan")] int _loan)
		{
			List<IncomingLoan> list = _IncomingLoanGet(_loan).ToList<IncomingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.IncomingLoanInsert")]
		private ISingleResult<IncomingLoan> _IncomingLoanInsert([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _mainWorkPlace);
			return (result.ReturnValue) as ISingleResult<IncomingLoan>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[IncomingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of IncomingLoan to be inserted.</param>
		/// <returns>The inserted IncomingLoan</returns>
		public IncomingLoan IncomingLoanInsert(IncomingLoan instance)
		{
            List<IncomingLoan> list = _IncomingLoanInsert(instance.Loan, instance.MainWorkPlace).ToList<IncomingLoan>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.IncomingLoanUpdate")]
		private int _IncomingLoanUpdate([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _mainWorkPlace);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[IncomingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of IncomingLoan whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void IncomingLoanUpdate(IncomingLoan instance)
		{
			_IncomingLoanUpdate(instance.Loan, instance.MainWorkPlace);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.IncomingLoanDelete")]
		private int _IncomingLoanDelete([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[IncomingLoan] table.
		/// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		public void IncomingLoanDelete([Parameter(Name = "@Loan")] int _loan)
		{
			_IncomingLoanDelete(_loan);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.IncomingLoanGetByMainWorkPlace")]
		private ISingleResult<IncomingLoan> _IncomingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (result.ReturnValue as ISingleResult<IncomingLoan>);
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of IncomingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IncomingLoan> IncomingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			return _IncomingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<IncomingLoan>();
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		/// <returns>Gets an instance of IncomingLoan or null.</returns>
		public IncomingLoan IncomingLoanGetByMainWorkPlaceFirstOrNull([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			List<IncomingLoan> list = _IncomingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<IncomingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.IncomingLoanDeleteByMainWorkPlace")]
		private int _IncomingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.IncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		public void IncomingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			_IncomingLoanDeleteByMainWorkPlace(_mainWorkPlace);
		}
		#endregion
        #endregion

		#region Installment procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentList")]
		private ISingleResult<Installment> _InstallmentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Installment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Installment table.
		/// </summary>
		/// <returns>A list of Installment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Installment> InstallmentList()
		{
			return _InstallmentList().ToList<Installment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentGet")]
		private ISingleResult<Installment> _InstallmentGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Installment>);
		}

		/// <summary>
		/// Gets one row from the dbo.Installment table.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		/// <returns>Gets an instance of Installment or null.</returns>
		public Installment InstallmentGet([Parameter(Name = "@Id")] int _id)
		{
			List<Installment> list = _InstallmentGet(_id).ToList<Installment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.InstallmentInsert")]
		private ISingleResult<Installment> _InstallmentInsert([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber, [Parameter(Name = "@DueDate")] DateTime _dueDate, [Parameter(Name = "@DueCapital")] decimal _dueCapital, [Parameter(Name = "@DueProfit")] decimal _dueProfit, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber, _dueDate, _dueCapital, _dueProfit, _notes);
			return (result.ReturnValue) as ISingleResult<Installment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Installment] table.
		/// </summary>
		/// <param name="instance">An instance of Installment to be inserted.</param>
		/// <returns>The inserted Installment</returns>
		public Installment InstallmentInsert(Installment instance)
		{
            List<Installment> list = _InstallmentInsert(instance.RefundableProduct, instance.SubNumber, instance.DueDate, instance.DueCapital, instance.DueProfit, instance.Notes).ToList<Installment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.InstallmentUpdate")]
		private int _InstallmentUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber, [Parameter(Name = "@DueDate")] DateTime _dueDate, [Parameter(Name = "@DueCapital")] decimal _dueCapital, [Parameter(Name = "@DueProfit")] decimal _dueProfit, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _refundableProduct, _subNumber, _dueDate, _dueCapital, _dueProfit, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Installment] table.
		/// </summary>
		/// <param name="instance">An instance of Installment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void InstallmentUpdate(Installment instance)
		{
			_InstallmentUpdate(instance.Id, instance.RefundableProduct, instance.SubNumber, instance.DueDate, instance.DueCapital, instance.DueProfit, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.InstallmentDelete")]
		private int _InstallmentDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Installment] table.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		public void InstallmentDelete([Parameter(Name = "@Id")] int _id)
		{
			_InstallmentDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentGetByDueDate")]
		private ISingleResult<Installment> _InstallmentGetByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _dueDate);
			return (result.ReturnValue as ISingleResult<Installment>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		/// <returns>A list of Installment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Installment> InstallmentGetByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			return _InstallmentGetByDueDate(_dueDate).ToList<Installment>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		/// <returns>Gets an instance of Installment or null.</returns>
		public Installment InstallmentGetByDueDateFirstOrNull([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			List<Installment> list = _InstallmentGetByDueDate(_dueDate).ToList<Installment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.InstallmentGetByRefundableProduct")]
		private ISingleResult<Installment> _InstallmentGetByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct);
			return (result.ReturnValue as ISingleResult<Installment>);
		}

		/// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <returns>A list of Installment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Installment> InstallmentGetByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			return _InstallmentGetByRefundableProduct(_refundableProduct).ToList<Installment>();
		}

		/// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <returns>Gets an instance of Installment or null.</returns>
		public Installment InstallmentGetByRefundableProductFirstOrNull([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			List<Installment> list = _InstallmentGetByRefundableProduct(_refundableProduct).ToList<Installment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.InstallmentGetByRefundableProduct_SubNumber")]
		private ISingleResult<Installment> _InstallmentGetByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber);
			return (result.ReturnValue as ISingleResult<Installment>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		/// <returns>A list of Installment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Installment> InstallmentGetByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			return _InstallmentGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber).ToList<Installment>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		/// <returns>Gets an instance of Installment or null.</returns>
		public Installment InstallmentGetByRefundableProduct_SubNumberFirstOrNull([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			List<Installment> list = _InstallmentGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber).ToList<Installment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.InstallmentDeleteByDueDate")]
		private int _InstallmentDeleteByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _dueDate);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of DueDate columns in the  dbo.Installment table.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		public void InstallmentDeleteByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			_InstallmentDeleteByDueDate(_dueDate);
		}		

        [Function(Name = "dbo.InstallmentDeleteByRefundableProduct")]
		private int _InstallmentDeleteByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		public void InstallmentDeleteByRefundableProduct([Parameter(Name = "@RefundableProduct")] int _refundableProduct)
		{
			_InstallmentDeleteByRefundableProduct(_refundableProduct);
		}		

        [Function(Name = "dbo.InstallmentDeleteByRefundableProduct_SubNumber")]
		private int _InstallmentDeleteByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProduct, _subNumber);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Installment table.
		/// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		public void InstallmentDeleteByRefundableProduct_SubNumber([Parameter(Name = "@RefundableProduct")] int _refundableProduct, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			_InstallmentDeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
		}
		#endregion
        #endregion

		#region InstallmentDecrease procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentDecreaseList")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <returns>A list of InstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecrease> InstallmentDecreaseList()
		{
			return _InstallmentDecreaseList().ToList<InstallmentDecrease>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentDecreaseGet")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		/// <returns>Gets an instance of InstallmentDecrease or null.</returns>
		public InstallmentDecrease InstallmentDecreaseGet([Parameter(Name = "@Id")] int _id)
		{
			List<InstallmentDecrease> list = _InstallmentDecreaseGet(_id).ToList<InstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.InstallmentDecreaseInsert")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseInsert([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Department")] Nullable<int> _department, [Parameter(Name = "@DecreaseAmount")] decimal _decreaseAmount, [Parameter(Name = "@NewInstallmentAmount")] decimal _newInstallmentAmount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrder, _employee, _department, _decreaseAmount, _newInstallmentAmount, _notes);
			return (result.ReturnValue) as ISingleResult<InstallmentDecrease>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecrease] table.
		/// </summary>
		/// <param name="instance">An instance of InstallmentDecrease to be inserted.</param>
		/// <returns>The inserted InstallmentDecrease</returns>
		public InstallmentDecrease InstallmentDecreaseInsert(InstallmentDecrease instance)
		{
            List<InstallmentDecrease> list = _InstallmentDecreaseInsert(instance.InstallmentDecreaseOrder, instance.Employee, instance.Department, instance.DecreaseAmount, instance.NewInstallmentAmount, instance.Notes).ToList<InstallmentDecrease>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.InstallmentDecreaseUpdate")]
		private int _InstallmentDecreaseUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Department")] Nullable<int> _department, [Parameter(Name = "@DecreaseAmount")] decimal _decreaseAmount, [Parameter(Name = "@NewInstallmentAmount")] decimal _newInstallmentAmount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _installmentDecreaseOrder, _employee, _department, _decreaseAmount, _newInstallmentAmount, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[InstallmentDecrease] table.
		/// </summary>
		/// <param name="instance">An instance of InstallmentDecrease whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void InstallmentDecreaseUpdate(InstallmentDecrease instance)
		{
			_InstallmentDecreaseUpdate(instance.Id, instance.InstallmentDecreaseOrder, instance.Employee, instance.Department, instance.DecreaseAmount, instance.NewInstallmentAmount, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.InstallmentDecreaseDelete")]
		private int _InstallmentDecreaseDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecrease] table.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		public void InstallmentDecreaseDelete([Parameter(Name = "@Id")] int _id)
		{
			_InstallmentDecreaseDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentDecreaseGetByDepartment")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>A list of InstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecrease> InstallmentDecreaseGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			return _InstallmentDecreaseGetByDepartment(_department).ToList<InstallmentDecrease>();
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>Gets an instance of InstallmentDecrease or null.</returns>
		public InstallmentDecrease InstallmentDecreaseGetByDepartmentFirstOrNull([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			List<InstallmentDecrease> list = _InstallmentDecreaseGetByDepartment(_department).ToList<InstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.InstallmentDecreaseGetByEmployee")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecrease> InstallmentDecreaseGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _InstallmentDecreaseGetByEmployee(_employee).ToList<InstallmentDecrease>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of InstallmentDecrease or null.</returns>
		public InstallmentDecrease InstallmentDecreaseGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<InstallmentDecrease> list = _InstallmentDecreaseGetByEmployee(_employee).ToList<InstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.InstallmentDecreaseGetByInstallmentDecreaseOrder")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseGetByInstallmentDecreaseOrder([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrder);
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <returns>A list of InstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecrease> InstallmentDecreaseGetByInstallmentDecreaseOrder([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder)
		{
			return _InstallmentDecreaseGetByInstallmentDecreaseOrder(_installmentDecreaseOrder).ToList<InstallmentDecrease>();
		}

		/// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecrease or null.</returns>
		public InstallmentDecrease InstallmentDecreaseGetByInstallmentDecreaseOrderFirstOrNull([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder)
		{
			List<InstallmentDecrease> list = _InstallmentDecreaseGetByInstallmentDecreaseOrder(_installmentDecreaseOrder).ToList<InstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee")]
		private ISingleResult<InstallmentDecrease> _InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrder, _employee);
			return (result.ReturnValue as ISingleResult<InstallmentDecrease>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecrease> InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee)
		{
			return _InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee).ToList<InstallmentDecrease>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of InstallmentDecrease or null.</returns>
		public InstallmentDecrease InstallmentDecreaseGetByInstallmentDecreaseOrder_EmployeeFirstOrNull([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee)
		{
			List<InstallmentDecrease> list = _InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee).ToList<InstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.InstallmentDecreaseDeleteByDepartment")]
		private int _InstallmentDecreaseDeleteByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Department from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		public void InstallmentDecreaseDeleteByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			_InstallmentDecreaseDeleteByDepartment(_department);
		}		

        [Function(Name = "dbo.InstallmentDecreaseDeleteByEmployee")]
		private int _InstallmentDecreaseDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void InstallmentDecreaseDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_InstallmentDecreaseDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.InstallmentDecreaseDeleteByInstallmentDecreaseOrder")]
		private int _InstallmentDecreaseDeleteByInstallmentDecreaseOrder([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrder);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		public void InstallmentDecreaseDeleteByInstallmentDecreaseOrder([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder)
		{
			_InstallmentDecreaseDeleteByInstallmentDecreaseOrder(_installmentDecreaseOrder);
		}		

        [Function(Name = "dbo.InstallmentDecreaseDeleteByInstallmentDecreaseOrder_Employee")]
		private int _InstallmentDecreaseDeleteByInstallmentDecreaseOrder_Employee([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrder, _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of InstallmentDecreaseOrder, Employee columns in the  dbo.InstallmentDecrease table.
		/// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		public void InstallmentDecreaseDeleteByInstallmentDecreaseOrder_Employee([Parameter(Name = "@InstallmentDecreaseOrder")] int _installmentDecreaseOrder, [Parameter(Name = "@Employee")] int _employee)
		{
			_InstallmentDecreaseDeleteByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee);
		}
		#endregion
        #endregion

		#region InstallmentDecreaseOrder procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderList")]
		private ISingleResult<InstallmentDecreaseOrder> _InstallmentDecreaseOrderList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrder>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrder table.
		/// </summary>
		/// <returns>A list of InstallmentDecreaseOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseOrder> InstallmentDecreaseOrderList()
		{
			return _InstallmentDecreaseOrderList().ToList<InstallmentDecreaseOrder>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderGet")]
		private ISingleResult<InstallmentDecreaseOrder> _InstallmentDecreaseOrderGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrder>);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrder table.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
		public InstallmentDecreaseOrder InstallmentDecreaseOrderGet([Parameter(Name = "@Id")] int _id)
		{
			List<InstallmentDecreaseOrder> list = _InstallmentDecreaseOrderGet(_id).ToList<InstallmentDecreaseOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderInsert")]
		private ISingleResult<InstallmentDecreaseOrder> _InstallmentDecreaseOrderInsert([Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month, _cersNumber, _cersDate, _notes);
			return (result.ReturnValue) as ISingleResult<InstallmentDecreaseOrder>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecreaseOrder] table.
		/// </summary>
		/// <param name="instance">An instance of InstallmentDecreaseOrder to be inserted.</param>
		/// <returns>The inserted InstallmentDecreaseOrder</returns>
		public InstallmentDecreaseOrder InstallmentDecreaseOrderInsert(InstallmentDecreaseOrder instance)
		{
            List<InstallmentDecreaseOrder> list = _InstallmentDecreaseOrderInsert(instance.Month, instance.CersNumber, instance.CersDate, instance.Notes).ToList<InstallmentDecreaseOrder>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderUpdate")]
		private int _InstallmentDecreaseOrderUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _month, _cersNumber, _cersDate, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[InstallmentDecreaseOrder] table.
		/// </summary>
		/// <param name="instance">An instance of InstallmentDecreaseOrder whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void InstallmentDecreaseOrderUpdate(InstallmentDecreaseOrder instance)
		{
			_InstallmentDecreaseOrderUpdate(instance.Id, instance.Month, instance.CersNumber, instance.CersDate, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderDelete")]
		private int _InstallmentDecreaseOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecreaseOrder] table.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		public void InstallmentDecreaseOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			_InstallmentDecreaseOrderDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentDecreaseOrderGetByMonth")]
		private ISingleResult<InstallmentDecreaseOrder> _InstallmentDecreaseOrderGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrder>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		/// <returns>A list of InstallmentDecreaseOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseOrder> InstallmentDecreaseOrderGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			return _InstallmentDecreaseOrderGetByMonth(_month).ToList<InstallmentDecreaseOrder>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
		public InstallmentDecreaseOrder InstallmentDecreaseOrderGetByMonthFirstOrNull([Parameter(Name = "@Month")] DateTime _month)
		{
			List<InstallmentDecreaseOrder> list = _InstallmentDecreaseOrderGetByMonth(_month).ToList<InstallmentDecreaseOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.InstallmentDecreaseOrderDeleteByMonth")]
		private int _InstallmentDecreaseOrderDeleteByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrder table.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		public void InstallmentDecreaseOrderDeleteByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			_InstallmentDecreaseOrderDeleteByMonth(_month);
		}
		#endregion
        #endregion

		#region InsuranceType procedures.
		#region List procedure
		[Function(Name = "dbo.InsuranceTypeList")]
		private ISingleResult<InsuranceType> _InsuranceTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InsuranceType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InsuranceType table.
		/// </summary>
		/// <returns>A list of InsuranceType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InsuranceType> InsuranceTypeList()
		{
			return _InsuranceTypeList().ToList<InsuranceType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InsuranceTypeGet")]
		private ISingleResult<InsuranceType> _InsuranceTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InsuranceType>);
		}

		/// <summary>
		/// Gets one row from the dbo.InsuranceType table.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		/// <returns>Gets an instance of InsuranceType or null.</returns>
		public InsuranceType InsuranceTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			List<InsuranceType> list = _InsuranceTypeGet(_id).ToList<InsuranceType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.InsuranceTypeInsert")]
		private ISingleResult<InsuranceType> _InsuranceTypeInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<InsuranceType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[InsuranceType] table.
		/// </summary>
		/// <param name="instance">An instance of InsuranceType to be inserted.</param>
		/// <returns>The inserted InsuranceType</returns>
		public InsuranceType InsuranceTypeInsert(InsuranceType instance)
		{
            List<InsuranceType> list = _InsuranceTypeInsert(instance.Id, instance.Name).ToList<InsuranceType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.InsuranceTypeUpdate")]
		private int _InsuranceTypeUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[InsuranceType] table.
		/// </summary>
		/// <param name="instance">An instance of InsuranceType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void InsuranceTypeUpdate(InsuranceType instance)
		{
			_InsuranceTypeUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.InsuranceTypeDelete")]
		private int _InsuranceTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[InsuranceType] table.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		public void InsuranceTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			_InsuranceTypeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InsuranceTypeGetByName")]
		private ISingleResult<InsuranceType> _InsuranceTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<InsuranceType>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		/// <returns>A list of InsuranceType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InsuranceType> InsuranceTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _InsuranceTypeGetByName(_name).ToList<InsuranceType>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		/// <returns>Gets an instance of InsuranceType or null.</returns>
		public InsuranceType InsuranceTypeGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<InsuranceType> list = _InsuranceTypeGetByName(_name).ToList<InsuranceType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.InsuranceTypeDeleteByName")]
		private int _InsuranceTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.InsuranceType table.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		public void InsuranceTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_InsuranceTypeDeleteByName(_name);
		}
		#endregion
        #endregion

		#region Issuer procedures.
		#region List procedure
		[Function(Name = "dbo.IssuerList")]
		private ISingleResult<Issuer> _IssuerList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Issuer>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Issuer table.
		/// </summary>
		/// <returns>A list of Issuer instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Issuer> IssuerList()
		{
			return _IssuerList().ToList<Issuer>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.IssuerGet")]
		private ISingleResult<Issuer> _IssuerGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Issuer>);
		}

		/// <summary>
		/// Gets one row from the dbo.Issuer table.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of Issuer or null.</returns>
		public Issuer IssuerGet([Parameter(Name = "@Id")] byte _id)
		{
			List<Issuer> list = _IssuerGet(_id).ToList<Issuer>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.IssuerInsert")]
		private ISingleResult<Issuer> _IssuerInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<Issuer>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Issuer] table.
		/// </summary>
		/// <param name="instance">An instance of Issuer to be inserted.</param>
		/// <returns>The inserted Issuer</returns>
		public Issuer IssuerInsert(Issuer instance)
		{
            List<Issuer> list = _IssuerInsert(instance.Name).ToList<Issuer>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.IssuerUpdate")]
		private int _IssuerUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Issuer] table.
		/// </summary>
		/// <param name="instance">An instance of Issuer whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void IssuerUpdate(Issuer instance)
		{
			_IssuerUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.IssuerDelete")]
		private int _IssuerDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Issuer] table.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		public void IssuerDelete([Parameter(Name = "@Id")] byte _id)
		{
			_IssuerDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.IssuerGetByName")]
		private ISingleResult<Issuer> _IssuerGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<Issuer>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		/// <returns>A list of Issuer instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Issuer> IssuerGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _IssuerGetByName(_name).ToList<Issuer>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of Issuer or null.</returns>
		public Issuer IssuerGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<Issuer> list = _IssuerGetByName(_name).ToList<Issuer>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.IssuerDeleteByName")]
		private int _IssuerDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Issuer table.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		public void IssuerDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_IssuerDeleteByName(_name);
		}
		#endregion
        #endregion

		#region Loan procedures.
		#region List procedure
		[Function(Name = "dbo.LoanList")]
		private ISingleResult<Loan> _LoanList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Loan table.
		/// </summary>
		/// <returns>A list of Loan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Loan> LoanList()
		{
			return _LoanList().ToList<Loan>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanGet")]
		private ISingleResult<Loan> _LoanGet([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Gets one row from the dbo.Loan table.
		/// </summary>
		/// <param name="_product">معرف السلفة</param>
		/// <returns>Gets an instance of Loan or null.</returns>
		public Loan LoanGet([Parameter(Name = "@Product")] int _product)
		{
			List<Loan> list = _LoanGet(_product).ToList<Loan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanInsert")]
		private ISingleResult<Loan> _LoanInsert([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@LoanDecision")] int _loanDecision, [Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus, [Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _loanDecision, _loanType, _loanGenerationStatus, _loanStatus);
			return (result.ReturnValue) as ISingleResult<Loan>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Loan] table.
		/// </summary>
		/// <param name="instance">An instance of Loan to be inserted.</param>
		/// <returns>The inserted Loan</returns>
		public Loan LoanInsert(Loan instance)
		{
            List<Loan> list = _LoanInsert(instance.Product, instance.LoanDecision, instance.LoanType, instance.LoanGenerationStatus, instance.LoanStatus).ToList<Loan>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanUpdate")]
		private int _LoanUpdate([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@LoanDecision")] int _loanDecision, [Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus, [Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _loanDecision, _loanType, _loanGenerationStatus, _loanStatus);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Loan] table.
		/// </summary>
		/// <param name="instance">An instance of Loan whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanUpdate(Loan instance)
		{
			_LoanUpdate(instance.Product, instance.LoanDecision, instance.LoanType, instance.LoanGenerationStatus, instance.LoanStatus);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanDelete")]
		private int _LoanDelete([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Loan] table.
		/// </summary>
		/// <param name="_product">معرف السلفة</param>
		public void LoanDelete([Parameter(Name = "@Product")] int _product)
		{
			_LoanDelete(_product);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanGetByLoanDecision")]
		private ISingleResult<Loan> _LoanGetByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecision);
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		/// <returns>A list of Loan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Loan> LoanGetByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			return _LoanGetByLoanDecision(_loanDecision).ToList<Loan>();
		}

		/// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		/// <returns>Gets an instance of Loan or null.</returns>
		public Loan LoanGetByLoanDecisionFirstOrNull([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			List<Loan> list = _LoanGetByLoanDecision(_loanDecision).ToList<Loan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanGetByLoanGenerationStatus")]
		private ISingleResult<Loan> _LoanGetByLoanGenerationStatus([Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanGenerationStatus);
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		/// <returns>A list of Loan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Loan> LoanGetByLoanGenerationStatus([Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus)
		{
			return _LoanGetByLoanGenerationStatus(_loanGenerationStatus).ToList<Loan>();
		}

		/// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		/// <returns>Gets an instance of Loan or null.</returns>
		public Loan LoanGetByLoanGenerationStatusFirstOrNull([Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus)
		{
			List<Loan> list = _LoanGetByLoanGenerationStatus(_loanGenerationStatus).ToList<Loan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanGetByLoanStatus")]
		private ISingleResult<Loan> _LoanGetByLoanStatus([Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanStatus);
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		/// <returns>A list of Loan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Loan> LoanGetByLoanStatus([Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			return _LoanGetByLoanStatus(_loanStatus).ToList<Loan>();
		}

		/// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		/// <returns>Gets an instance of Loan or null.</returns>
		public Loan LoanGetByLoanStatusFirstOrNull([Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			List<Loan> list = _LoanGetByLoanStatus(_loanStatus).ToList<Loan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanGetByLoanType")]
		private ISingleResult<Loan> _LoanGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (result.ReturnValue as ISingleResult<Loan>);
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		/// <returns>A list of Loan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Loan> LoanGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			return _LoanGetByLoanType(_loanType).ToList<Loan>();
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		/// <returns>Gets an instance of Loan or null.</returns>
		public Loan LoanGetByLoanTypeFirstOrNull([Parameter(Name = "@LoanType")] short _loanType)
		{
			List<Loan> list = _LoanGetByLoanType(_loanType).ToList<Loan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanDeleteByLoanDecision")]
		private int _LoanDeleteByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecision);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		public void LoanDeleteByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			_LoanDeleteByLoanDecision(_loanDecision);
		}		

        [Function(Name = "dbo.LoanDeleteByLoanGenerationStatus")]
		private int _LoanDeleteByLoanGenerationStatus([Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanGenerationStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanGenerationStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		public void LoanDeleteByLoanGenerationStatus([Parameter(Name = "@LoanGenerationStatus")] byte _loanGenerationStatus)
		{
			_LoanDeleteByLoanGenerationStatus(_loanGenerationStatus);
		}		

        [Function(Name = "dbo.LoanDeleteByLoanStatus")]
		private int _LoanDeleteByLoanStatus([Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanStatus from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		public void LoanDeleteByLoanStatus([Parameter(Name = "@LoanStatus")] byte _loanStatus)
		{
			_LoanDeleteByLoanStatus(_loanStatus);
		}		

        [Function(Name = "dbo.LoanDeleteByLoanType")]
		private int _LoanDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanType from the dbo.Loan table.
		/// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		public void LoanDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			_LoanDeleteByLoanType(_loanType);
		}
		#endregion
        #endregion

		#region LoanChange procedures.
		#region List procedure
		[Function(Name = "dbo.LoanChangeList")]
		private ISingleResult<LoanChange> _LoanChangeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanChange>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanChange table.
		/// </summary>
		/// <returns>A list of LoanChange instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanChange> LoanChangeList()
		{
			return _LoanChangeList().ToList<LoanChange>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanChangeGet")]
		private ISingleResult<LoanChange> _LoanChangeGet([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return (result.ReturnValue as ISingleResult<LoanChange>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanChange table.
		/// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
		/// <returns>Gets an instance of LoanChange or null.</returns>
		public LoanChange LoanChangeGet([Parameter(Name = "@Loan")] int _loan)
		{
			List<LoanChange> list = _LoanChangeGet(_loan).ToList<LoanChange>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanChangeInsert")]
		private ISingleResult<LoanChange> _LoanChangeInsert([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _fromLoan);
			return (result.ReturnValue) as ISingleResult<LoanChange>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanChange] table.
		/// </summary>
		/// <param name="instance">An instance of LoanChange to be inserted.</param>
		/// <returns>The inserted LoanChange</returns>
		public LoanChange LoanChangeInsert(LoanChange instance)
		{
            List<LoanChange> list = _LoanChangeInsert(instance.Loan, instance.FromLoan).ToList<LoanChange>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanChangeUpdate")]
		private int _LoanChangeUpdate([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _fromLoan);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanChange] table.
		/// </summary>
		/// <param name="instance">An instance of LoanChange whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanChangeUpdate(LoanChange instance)
		{
			_LoanChangeUpdate(instance.Loan, instance.FromLoan);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanChangeDelete")]
		private int _LoanChangeDelete([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanChange] table.
		/// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
		public void LoanChangeDelete([Parameter(Name = "@Loan")] int _loan)
		{
			_LoanChangeDelete(_loan);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanChangeGetByFromLoan")]
		private ISingleResult<LoanChange> _LoanChangeGetByFromLoan([Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromLoan);
			return (result.ReturnValue as ISingleResult<LoanChange>);
		}

		/// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
		/// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		/// <returns>A list of LoanChange instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanChange> LoanChangeGetByFromLoan([Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			return _LoanChangeGetByFromLoan(_fromLoan).ToList<LoanChange>();
		}

		/// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
		/// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		/// <returns>Gets an instance of LoanChange or null.</returns>
		public LoanChange LoanChangeGetByFromLoanFirstOrNull([Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			List<LoanChange> list = _LoanChangeGetByFromLoan(_fromLoan).ToList<LoanChange>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanChangeDeleteByFromLoan")]
		private int _LoanChangeDeleteByFromLoan([Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromLoan);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one FromLoan from the dbo.LoanChange table.
		/// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		public void LoanChangeDeleteByFromLoan([Parameter(Name = "@FromLoan")] int _fromLoan)
		{
			_LoanChangeDeleteByFromLoan(_fromLoan);
		}
		#endregion
        #endregion

		#region LoanDecision procedures.
		#region List procedure
		[Function(Name = "dbo.LoanDecisionList")]
		private ISingleResult<LoanDecision> _LoanDecisionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanDecision>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanDecision table.
		/// </summary>
		/// <returns>A list of LoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecision> LoanDecisionList()
		{
			return _LoanDecisionList().ToList<LoanDecision>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanDecisionGet")]
		private ISingleResult<LoanDecision> _LoanDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanDecision>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDecision table.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		/// <returns>Gets an instance of LoanDecision or null.</returns>
		public LoanDecision LoanDecisionGet([Parameter(Name = "@Id")] int _id)
		{
			List<LoanDecision> list = _LoanDecisionGet(_id).ToList<LoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanDecisionInsert")]
		private ISingleResult<LoanDecision> _LoanDecisionInsert([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@DeductionStartDate")] DateTime _deductionStartDate, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@IsPaidFromSalary")] Nullable<bool> _isPaidFromSalary, [Parameter(Name = "@Reason")] string _reason, [Parameter(Name = "@AdditionalClause")] string _additionalClause, [Parameter(Name = "@AdditionalIntroduction")] string _additionalIntroduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year, _date, _deductionStartDate, _cersNumber, _cersDate, _notes, _loanDecisionType, _paymentNumber, _paymentDate, _isPaidFromSalary, _reason, _additionalClause, _additionalIntroduction);
			return (result.ReturnValue) as ISingleResult<LoanDecision>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanDecision] table.
		/// </summary>
		/// <param name="instance">An instance of LoanDecision to be inserted.</param>
		/// <returns>The inserted LoanDecision</returns>
		public LoanDecision LoanDecisionInsert(LoanDecision instance)
		{
            List<LoanDecision> list = _LoanDecisionInsert(instance.Number, instance.Year, instance.Date, instance.DeductionStartDate, instance.CersNumber, instance.CersDate, instance.Notes, instance.LoanDecisionType, instance.PaymentNumber, instance.PaymentDate, instance.IsPaidFromSalary, instance.Reason, instance.AdditionalClause, instance.AdditionalIntroduction).ToList<LoanDecision>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanDecisionUpdate")]
		private int _LoanDecisionUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@DeductionStartDate")] DateTime _deductionStartDate, [Parameter(Name = "@CersNumber")] string _cersNumber, [Parameter(Name = "@CersDate")] Nullable<DateTime> _cersDate, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType, [Parameter(Name = "@PaymentNumber")] string _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@IsPaidFromSalary")] Nullable<bool> _isPaidFromSalary, [Parameter(Name = "@Reason")] string _reason, [Parameter(Name = "@AdditionalClause")] string _additionalClause, [Parameter(Name = "@AdditionalIntroduction")] string _additionalIntroduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _number, _year, _date, _deductionStartDate, _cersNumber, _cersDate, _notes, _loanDecisionType, _paymentNumber, _paymentDate, _isPaidFromSalary, _reason, _additionalClause, _additionalIntroduction);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanDecision] table.
		/// </summary>
		/// <param name="instance">An instance of LoanDecision whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanDecisionUpdate(LoanDecision instance)
		{
			_LoanDecisionUpdate(instance.Id, instance.Number, instance.Year, instance.Date, instance.DeductionStartDate, instance.CersNumber, instance.CersDate, instance.Notes, instance.LoanDecisionType, instance.PaymentNumber, instance.PaymentDate, instance.IsPaidFromSalary, instance.Reason, instance.AdditionalClause, instance.AdditionalIntroduction);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanDecisionDelete")]
		private int _LoanDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanDecision] table.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		public void LoanDecisionDelete([Parameter(Name = "@Id")] int _id)
		{
			_LoanDecisionDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanDecisionGetByLoanDecisionType")]
		private ISingleResult<LoanDecision> _LoanDecisionGetByLoanDecisionType([Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecisionType);
			return (result.ReturnValue as ISingleResult<LoanDecision>);
		}

		/// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
		/// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		/// <returns>A list of LoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecision> LoanDecisionGetByLoanDecisionType([Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType)
		{
			return _LoanDecisionGetByLoanDecisionType(_loanDecisionType).ToList<LoanDecision>();
		}

		/// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
		/// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		/// <returns>Gets an instance of LoanDecision or null.</returns>
		public LoanDecision LoanDecisionGetByLoanDecisionTypeFirstOrNull([Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType)
		{
			List<LoanDecision> list = _LoanDecisionGetByLoanDecisionType(_loanDecisionType).ToList<LoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanDecisionGetByNumber_Year")]
		private ISingleResult<LoanDecision> _LoanDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<LoanDecision>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of LoanDecision instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecision> LoanDecisionGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _LoanDecisionGetByNumber_Year(_number, _year).ToList<LoanDecision>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>Gets an instance of LoanDecision or null.</returns>
		public LoanDecision LoanDecisionGetByNumber_YearFirstOrNull([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			List<LoanDecision> list = _LoanDecisionGetByNumber_Year(_number, _year).ToList<LoanDecision>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanDecisionDeleteByLoanDecisionType")]
		private int _LoanDecisionDeleteByLoanDecisionType([Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecisionType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanDecisionType from the dbo.LoanDecision table.
		/// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		public void LoanDecisionDeleteByLoanDecisionType([Parameter(Name = "@LoanDecisionType")] byte _loanDecisionType)
		{
			_LoanDecisionDeleteByLoanDecisionType(_loanDecisionType);
		}		

        [Function(Name = "dbo.LoanDecisionDeleteByNumber_Year")]
		private int _LoanDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.LoanDecision table.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		public void LoanDecisionDeleteByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			_LoanDecisionDeleteByNumber_Year(_number, _year);
		}
		#endregion
        #endregion

		#region LoanDecisionType procedures.
		#region List procedure
		[Function(Name = "dbo.LoanDecisionTypeList")]
		private ISingleResult<LoanDecisionType> _LoanDecisionTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanDecisionType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanDecisionType table.
		/// </summary>
		/// <returns>A list of LoanDecisionType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionType> LoanDecisionTypeList()
		{
			return _LoanDecisionTypeList().ToList<LoanDecisionType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanDecisionTypeGet")]
		private ISingleResult<LoanDecisionType> _LoanDecisionTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanDecisionType>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDecisionType table.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionType or null.</returns>
		public LoanDecisionType LoanDecisionTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanDecisionType> list = _LoanDecisionTypeGet(_id).ToList<LoanDecisionType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanDecisionTypeInsert")]
		private ISingleResult<LoanDecisionType> _LoanDecisionTypeInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<LoanDecisionType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanDecisionType] table.
		/// </summary>
		/// <param name="instance">An instance of LoanDecisionType to be inserted.</param>
		/// <returns>The inserted LoanDecisionType</returns>
		public LoanDecisionType LoanDecisionTypeInsert(LoanDecisionType instance)
		{
            List<LoanDecisionType> list = _LoanDecisionTypeInsert(instance.Id, instance.Name).ToList<LoanDecisionType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanDecisionTypeUpdate")]
		private int _LoanDecisionTypeUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanDecisionType] table.
		/// </summary>
		/// <param name="instance">An instance of LoanDecisionType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanDecisionTypeUpdate(LoanDecisionType instance)
		{
			_LoanDecisionTypeUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanDecisionTypeDelete")]
		private int _LoanDecisionTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanDecisionType] table.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		public void LoanDecisionTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			_LoanDecisionTypeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanDecisionTypeGetByName")]
		private ISingleResult<LoanDecisionType> _LoanDecisionTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanDecisionType>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		/// <returns>A list of LoanDecisionType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionType> LoanDecisionTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanDecisionTypeGetByName(_name).ToList<LoanDecisionType>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionType or null.</returns>
		public LoanDecisionType LoanDecisionTypeGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<LoanDecisionType> list = _LoanDecisionTypeGetByName(_name).ToList<LoanDecisionType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanDecisionTypeDeleteByName")]
		private int _LoanDecisionTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanDecisionType table.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		public void LoanDecisionTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_LoanDecisionTypeDeleteByName(_name);
		}
		#endregion
        #endregion

		#region LoanGenerationStatus procedures.
		#region List procedure
		[Function(Name = "dbo.LoanGenerationStatusList")]
		private ISingleResult<LoanGenerationStatus> _LoanGenerationStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanGenerationStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatus table.
		/// </summary>
		/// <returns>A list of LoanGenerationStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanGenerationStatus> LoanGenerationStatusList()
		{
			return _LoanGenerationStatusList().ToList<LoanGenerationStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanGenerationStatusGet")]
		private ISingleResult<LoanGenerationStatus> _LoanGenerationStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanGenerationStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanGenerationStatus table.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
		public LoanGenerationStatus LoanGenerationStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanGenerationStatus> list = _LoanGenerationStatusGet(_id).ToList<LoanGenerationStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanGenerationStatusInsert")]
		private ISingleResult<LoanGenerationStatus> _LoanGenerationStatusInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<LoanGenerationStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanGenerationStatus] table.
		/// </summary>
		/// <param name="instance">An instance of LoanGenerationStatus to be inserted.</param>
		/// <returns>The inserted LoanGenerationStatus</returns>
		public LoanGenerationStatus LoanGenerationStatusInsert(LoanGenerationStatus instance)
		{
            List<LoanGenerationStatus> list = _LoanGenerationStatusInsert(instance.Name).ToList<LoanGenerationStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanGenerationStatusUpdate")]
		private int _LoanGenerationStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanGenerationStatus] table.
		/// </summary>
		/// <param name="instance">An instance of LoanGenerationStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanGenerationStatusUpdate(LoanGenerationStatus instance)
		{
			_LoanGenerationStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanGenerationStatusDelete")]
		private int _LoanGenerationStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanGenerationStatus] table.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		public void LoanGenerationStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_LoanGenerationStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanGenerationStatusGetByName")]
		private ISingleResult<LoanGenerationStatus> _LoanGenerationStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanGenerationStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		/// <returns>A list of LoanGenerationStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanGenerationStatus> LoanGenerationStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanGenerationStatusGetByName(_name).ToList<LoanGenerationStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
		public LoanGenerationStatus LoanGenerationStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<LoanGenerationStatus> list = _LoanGenerationStatusGetByName(_name).ToList<LoanGenerationStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanGenerationStatusDeleteByName")]
		private int _LoanGenerationStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanGenerationStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		public void LoanGenerationStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_LoanGenerationStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region LoanRequest procedures.
		#region List procedure
		[Function(Name = "dbo.LoanRequestList")]
		private ISingleResult<LoanRequest> _LoanRequestList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanRequest>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanRequest table.
		/// </summary>
		/// <returns>A list of LoanRequest instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanRequest> LoanRequestList()
		{
			return _LoanRequestList().ToList<LoanRequest>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanRequestGet")]
		private ISingleResult<LoanRequest> _LoanRequestGet([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return (result.ReturnValue as ISingleResult<LoanRequest>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanRequest table.
		/// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
		/// <returns>Gets an instance of LoanRequest or null.</returns>
		public LoanRequest LoanRequestGet([Parameter(Name = "@Request")] int _request)
		{
			List<LoanRequest> list = _LoanRequestGet(_request).ToList<LoanRequest>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanRequestInsert")]
		private ISingleResult<LoanRequest> _LoanRequestInsert([Parameter(Name = "@Request")] int _request, [Parameter(Name = "@NetIncome")] decimal _netIncome, [Parameter(Name = "@TotalDeduction")] decimal _totalDeduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request, _netIncome, _totalDeduction);
			return (result.ReturnValue) as ISingleResult<LoanRequest>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanRequest] table.
		/// </summary>
		/// <param name="instance">An instance of LoanRequest to be inserted.</param>
		/// <returns>The inserted LoanRequest</returns>
		public LoanRequest LoanRequestInsert(LoanRequest instance)
		{
            List<LoanRequest> list = _LoanRequestInsert(instance.Request, instance.NetIncome, instance.TotalDeduction).ToList<LoanRequest>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanRequestUpdate")]
		private int _LoanRequestUpdate([Parameter(Name = "@Request")] int _request, [Parameter(Name = "@NetIncome")] decimal _netIncome, [Parameter(Name = "@TotalDeduction")] decimal _totalDeduction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request, _netIncome, _totalDeduction);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanRequest] table.
		/// </summary>
		/// <param name="instance">An instance of LoanRequest whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanRequestUpdate(LoanRequest instance)
		{
			_LoanRequestUpdate(instance.Request, instance.NetIncome, instance.TotalDeduction);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanRequestDelete")]
		private int _LoanRequestDelete([Parameter(Name = "@Request")] int _request)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _request);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanRequest] table.
		/// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
		public void LoanRequestDelete([Parameter(Name = "@Request")] int _request)
		{
			_LoanRequestDelete(_request);
		}
		#endregion
        #endregion

		#region LoanStatus procedures.
		#region List procedure
		[Function(Name = "dbo.LoanStatusList")]
		private ISingleResult<LoanStatus> _LoanStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanStatus table.
		/// </summary>
		/// <returns>A list of LoanStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanStatus> LoanStatusList()
		{
			return _LoanStatusList().ToList<LoanStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanStatusGet")]
		private ISingleResult<LoanStatus> _LoanStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanStatus table.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatus or null.</returns>
		public LoanStatus LoanStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanStatus> list = _LoanStatusGet(_id).ToList<LoanStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanStatusInsert")]
		private ISingleResult<LoanStatus> _LoanStatusInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<LoanStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanStatus] table.
		/// </summary>
		/// <param name="instance">An instance of LoanStatus to be inserted.</param>
		/// <returns>The inserted LoanStatus</returns>
		public LoanStatus LoanStatusInsert(LoanStatus instance)
		{
            List<LoanStatus> list = _LoanStatusInsert(instance.Name).ToList<LoanStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanStatusUpdate")]
		private int _LoanStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanStatus] table.
		/// </summary>
		/// <param name="instance">An instance of LoanStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanStatusUpdate(LoanStatus instance)
		{
			_LoanStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanStatusDelete")]
		private int _LoanStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanStatus] table.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		public void LoanStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_LoanStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanStatusGetByName")]
		private ISingleResult<LoanStatus> _LoanStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		/// <returns>A list of LoanStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanStatus> LoanStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanStatusGetByName(_name).ToList<LoanStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatus or null.</returns>
		public LoanStatus LoanStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<LoanStatus> list = _LoanStatusGetByName(_name).ToList<LoanStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanStatusDeleteByName")]
		private int _LoanStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		public void LoanStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_LoanStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region LoanType procedures.
		#region List procedure
		[Function(Name = "dbo.LoanTypeList")]
		private ISingleResult<LoanType> _LoanTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanType table.
		/// </summary>
		/// <returns>A list of LoanType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanType> LoanTypeList()
		{
			return _LoanTypeList().ToList<LoanType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanTypeGet")]
		private ISingleResult<LoanType> _LoanTypeGet([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (result.ReturnValue as ISingleResult<LoanType>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanType table.
		/// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
		/// <returns>Gets an instance of LoanType or null.</returns>
		public LoanType LoanTypeGet([Parameter(Name = "@ProductType")] short _productType)
		{
			List<LoanType> list = _LoanTypeGet(_productType).ToList<LoanType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanTypeInsert")]
		private ISingleResult<LoanType> _LoanTypeInsert([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (result.ReturnValue) as ISingleResult<LoanType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanType] table.
		/// </summary>
		/// <param name="instance">An instance of LoanType to be inserted.</param>
		/// <returns>The inserted LoanType</returns>
		public LoanType LoanTypeInsert(LoanType instance)
		{
            List<LoanType> list = _LoanTypeInsert(instance.ProductType).ToList<LoanType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanTypeDelete")]
		private int _LoanTypeDelete([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanType] table.
		/// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
		public void LoanTypeDelete([Parameter(Name = "@ProductType")] short _productType)
		{
			_LoanTypeDelete(_productType);
		}
		#endregion
        #endregion

		#region LoanTypeClosure procedures.
		#region List procedure
		[Function(Name = "dbo.LoanTypeClosureList")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanTypeClosure>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <returns>A list of LoanTypeClosure instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosure> LoanTypeClosureList()
		{
			return _LoanTypeClosureList().ToList<LoanTypeClosure>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanTypeClosureGet")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanTypeClosure>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		/// <returns>Gets an instance of LoanTypeClosure or null.</returns>
		public LoanTypeClosure LoanTypeClosureGet([Parameter(Name = "@Id")] int _id)
		{
			List<LoanTypeClosure> list = _LoanTypeClosureGet(_id).ToList<LoanTypeClosure>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.LoanTypeClosureInsert")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureInsert([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType, _closingLoanType);
			return (result.ReturnValue) as ISingleResult<LoanTypeClosure>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[LoanTypeClosure] table.
		/// </summary>
		/// <param name="instance">An instance of LoanTypeClosure to be inserted.</param>
		/// <returns>The inserted LoanTypeClosure</returns>
		public LoanTypeClosure LoanTypeClosureInsert(LoanTypeClosure instance)
		{
            List<LoanTypeClosure> list = _LoanTypeClosureInsert(instance.LoanType, instance.ClosingLoanType).ToList<LoanTypeClosure>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.LoanTypeClosureUpdate")]
		private int _LoanTypeClosureUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _loanType, _closingLoanType);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[LoanTypeClosure] table.
		/// </summary>
		/// <param name="instance">An instance of LoanTypeClosure whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void LoanTypeClosureUpdate(LoanTypeClosure instance)
		{
			_LoanTypeClosureUpdate(instance.Id, instance.LoanType, instance.ClosingLoanType);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.LoanTypeClosureDelete")]
		private int _LoanTypeClosureDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[LoanTypeClosure] table.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		public void LoanTypeClosureDelete([Parameter(Name = "@Id")] int _id)
		{
			_LoanTypeClosureDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanTypeClosureGetByClosingLoanType")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureGetByClosingLoanType([Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _closingLoanType);
			return (result.ReturnValue as ISingleResult<LoanTypeClosure>);
		}

		/// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosure instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosure> LoanTypeClosureGetByClosingLoanType([Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			return _LoanTypeClosureGetByClosingLoanType(_closingLoanType).ToList<LoanTypeClosure>();
		}

		/// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>Gets an instance of LoanTypeClosure or null.</returns>
		public LoanTypeClosure LoanTypeClosureGetByClosingLoanTypeFirstOrNull([Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			List<LoanTypeClosure> list = _LoanTypeClosureGetByClosingLoanType(_closingLoanType).ToList<LoanTypeClosure>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanTypeClosureGetByLoanType")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (result.ReturnValue as ISingleResult<LoanTypeClosure>);
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <returns>A list of LoanTypeClosure instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosure> LoanTypeClosureGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			return _LoanTypeClosureGetByLoanType(_loanType).ToList<LoanTypeClosure>();
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <returns>Gets an instance of LoanTypeClosure or null.</returns>
		public LoanTypeClosure LoanTypeClosureGetByLoanTypeFirstOrNull([Parameter(Name = "@LoanType")] short _loanType)
		{
			List<LoanTypeClosure> list = _LoanTypeClosureGetByLoanType(_loanType).ToList<LoanTypeClosure>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.LoanTypeClosureGetByLoanType_ClosingLoanType")]
		private ISingleResult<LoanTypeClosure> _LoanTypeClosureGetByLoanType_ClosingLoanType([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType, _closingLoanType);
			return (result.ReturnValue as ISingleResult<LoanTypeClosure>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosure instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosure> LoanTypeClosureGetByLoanType_ClosingLoanType([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			return _LoanTypeClosureGetByLoanType_ClosingLoanType(_loanType, _closingLoanType).ToList<LoanTypeClosure>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>Gets an instance of LoanTypeClosure or null.</returns>
		public LoanTypeClosure LoanTypeClosureGetByLoanType_ClosingLoanTypeFirstOrNull([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			List<LoanTypeClosure> list = _LoanTypeClosureGetByLoanType_ClosingLoanType(_loanType, _closingLoanType).ToList<LoanTypeClosure>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.LoanTypeClosureDeleteByClosingLoanType")]
		private int _LoanTypeClosureDeleteByClosingLoanType([Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _closingLoanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		public void LoanTypeClosureDeleteByClosingLoanType([Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			_LoanTypeClosureDeleteByClosingLoanType(_closingLoanType);
		}		

        [Function(Name = "dbo.LoanTypeClosureDeleteByLoanType")]
		private int _LoanTypeClosureDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanType from the dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		public void LoanTypeClosureDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			_LoanTypeClosureDeleteByLoanType(_loanType);
		}		

        [Function(Name = "dbo.LoanTypeClosureDeleteByLoanType_ClosingLoanType")]
		private int _LoanTypeClosureDeleteByLoanType_ClosingLoanType([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType, _closingLoanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of LoanType, ClosingLoanType columns in the  dbo.LoanTypeClosure table.
		/// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		public void LoanTypeClosureDeleteByLoanType_ClosingLoanType([Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@ClosingLoanType")] short _closingLoanType)
		{
			_LoanTypeClosureDeleteByLoanType_ClosingLoanType(_loanType, _closingLoanType);
		}
		#endregion
        #endregion

		#region MainWorkPlace procedures.
		#region List procedure
		[Function(Name = "dbo.MainWorkPlaceList")]
		private ISingleResult<MainWorkPlace> _MainWorkPlaceList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MainWorkPlace>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MainWorkPlace table.
		/// </summary>
		/// <returns>A list of MainWorkPlace instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MainWorkPlace> MainWorkPlaceList()
		{
			return _MainWorkPlaceList().ToList<MainWorkPlace>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MainWorkPlaceGet")]
		private ISingleResult<MainWorkPlace> _MainWorkPlaceGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<MainWorkPlace>);
		}

		/// <summary>
		/// Gets one row from the dbo.MainWorkPlace table.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlace or null.</returns>
		public MainWorkPlace MainWorkPlaceGet([Parameter(Name = "@Id")] int _id)
		{
			List<MainWorkPlace> list = _MainWorkPlaceGet(_id).ToList<MainWorkPlace>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.MainWorkPlaceInsert")]
		private ISingleResult<MainWorkPlace> _MainWorkPlaceInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<MainWorkPlace>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[MainWorkPlace] table.
		/// </summary>
		/// <param name="instance">An instance of MainWorkPlace to be inserted.</param>
		/// <returns>The inserted MainWorkPlace</returns>
		public MainWorkPlace MainWorkPlaceInsert(MainWorkPlace instance)
		{
            List<MainWorkPlace> list = _MainWorkPlaceInsert(instance.Name).ToList<MainWorkPlace>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.MainWorkPlaceUpdate")]
		private int _MainWorkPlaceUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[MainWorkPlace] table.
		/// </summary>
		/// <param name="instance">An instance of MainWorkPlace whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void MainWorkPlaceUpdate(MainWorkPlace instance)
		{
			_MainWorkPlaceUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.MainWorkPlaceDelete")]
		private int _MainWorkPlaceDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[MainWorkPlace] table.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		public void MainWorkPlaceDelete([Parameter(Name = "@Id")] int _id)
		{
			_MainWorkPlaceDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.MainWorkPlaceGetByName")]
		private ISingleResult<MainWorkPlace> _MainWorkPlaceGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<MainWorkPlace>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		/// <returns>A list of MainWorkPlace instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MainWorkPlace> MainWorkPlaceGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _MainWorkPlaceGetByName(_name).ToList<MainWorkPlace>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlace or null.</returns>
		public MainWorkPlace MainWorkPlaceGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<MainWorkPlace> list = _MainWorkPlaceGetByName(_name).ToList<MainWorkPlace>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.MainWorkPlaceDeleteByName")]
		private int _MainWorkPlaceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.MainWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		public void MainWorkPlaceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_MainWorkPlaceDeleteByName(_name);
		}
		#endregion
        #endregion

		#region MissingInstallmentDecrease procedures.
		#region List procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseList")]
		private ISingleResult<MissingInstallmentDecrease> _MissingInstallmentDecreaseList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MissingInstallmentDecrease>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecrease table.
		/// </summary>
		/// <returns>A list of MissingInstallmentDecrease instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MissingInstallmentDecrease> MissingInstallmentDecreaseList()
		{
			return _MissingInstallmentDecreaseList().ToList<MissingInstallmentDecrease>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseGet")]
		private ISingleResult<MissingInstallmentDecrease> _MissingInstallmentDecreaseGet([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<MissingInstallmentDecrease>);
		}

		/// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecrease table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of MissingInstallmentDecrease or null.</returns>
		public MissingInstallmentDecrease MissingInstallmentDecreaseGet([Parameter(Name = "@Employee")] int _employee)
		{
			List<MissingInstallmentDecrease> list = _MissingInstallmentDecreaseGet(_employee).ToList<MissingInstallmentDecrease>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseInsert")]
		private ISingleResult<MissingInstallmentDecrease> _MissingInstallmentDecreaseInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@SalaryAmount")] decimal _salaryAmount, [Parameter(Name = "@TransferMonth")] DateTime _transferMonth, [Parameter(Name = "@FinishedInstallmentsAmount")] decimal _finishedInstallmentsAmount, [Parameter(Name = "@RemainingInstallmentsAmount")] decimal _remainingInstallmentsAmount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _salaryAmount, _transferMonth, _finishedInstallmentsAmount, _remainingInstallmentsAmount, _notes);
			return (result.ReturnValue) as ISingleResult<MissingInstallmentDecrease>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[MissingInstallmentDecrease] table.
		/// </summary>
		/// <param name="instance">An instance of MissingInstallmentDecrease to be inserted.</param>
		/// <returns>The inserted MissingInstallmentDecrease</returns>
		public MissingInstallmentDecrease MissingInstallmentDecreaseInsert(MissingInstallmentDecrease instance)
		{
            List<MissingInstallmentDecrease> list = _MissingInstallmentDecreaseInsert(instance.Employee, instance.SalaryAmount, instance.TransferMonth, instance.FinishedInstallmentsAmount, instance.RemainingInstallmentsAmount, instance.Notes).ToList<MissingInstallmentDecrease>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseUpdate")]
		private int _MissingInstallmentDecreaseUpdate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@SalaryAmount")] decimal _salaryAmount, [Parameter(Name = "@TransferMonth")] DateTime _transferMonth, [Parameter(Name = "@FinishedInstallmentsAmount")] decimal _finishedInstallmentsAmount, [Parameter(Name = "@RemainingInstallmentsAmount")] decimal _remainingInstallmentsAmount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _salaryAmount, _transferMonth, _finishedInstallmentsAmount, _remainingInstallmentsAmount, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[MissingInstallmentDecrease] table.
		/// </summary>
		/// <param name="instance">An instance of MissingInstallmentDecrease whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void MissingInstallmentDecreaseUpdate(MissingInstallmentDecrease instance)
		{
			_MissingInstallmentDecreaseUpdate(instance.Employee, instance.SalaryAmount, instance.TransferMonth, instance.FinishedInstallmentsAmount, instance.RemainingInstallmentsAmount, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseDelete")]
		private int _MissingInstallmentDecreaseDelete([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[MissingInstallmentDecrease] table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		public void MissingInstallmentDecreaseDelete([Parameter(Name = "@Employee")] int _employee)
		{
			_MissingInstallmentDecreaseDelete(_employee);
		}
		#endregion
        #endregion

		#region MonthlyBalance procedures.
		#region List procedure
		[Function(Name = "dbo.MonthlyBalanceList")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MonthlyBalance table.
		/// </summary>
		/// <returns>A list of MonthlyBalance instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalance> MonthlyBalanceList()
		{
			return _MonthlyBalanceList().ToList<MonthlyBalance>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MonthlyBalanceGet")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Gets one row from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		/// <returns>Gets an instance of MonthlyBalance or null.</returns>
		public MonthlyBalance MonthlyBalanceGet([Parameter(Name = "@Id")] int _id)
		{
			List<MonthlyBalance> list = _MonthlyBalanceGet(_id).ToList<MonthlyBalance>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.MonthlyBalanceInsert")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Opening")] decimal _opening, [Parameter(Name = "@NormalLoans")] decimal _normalLoans, [Parameter(Name = "@IncomingLoans")] decimal _incomingLoans, [Parameter(Name = "@Restitution")] decimal _restitution, [Parameter(Name = "@OutgoingLoans")] decimal _outgoingLoans, [Parameter(Name = "@SalaryPayment")] decimal _salaryPayment, [Parameter(Name = "@CashPayment")] decimal _cashPayment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentGroup, _month, _opening, _normalLoans, _incomingLoans, _restitution, _outgoingLoans, _salaryPayment, _cashPayment);
			return (result.ReturnValue) as ISingleResult<MonthlyBalance>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[MonthlyBalance] table.
		/// </summary>
		/// <param name="instance">An instance of MonthlyBalance to be inserted.</param>
		/// <returns>The inserted MonthlyBalance</returns>
		public MonthlyBalance MonthlyBalanceInsert(MonthlyBalance instance)
		{
            List<MonthlyBalance> list = _MonthlyBalanceInsert(instance.Employee, instance.PaymentGroup, instance.Month, instance.Opening, instance.NormalLoans, instance.IncomingLoans, instance.Restitution, instance.OutgoingLoans, instance.SalaryPayment, instance.CashPayment).ToList<MonthlyBalance>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.MonthlyBalanceUpdate")]
		private int _MonthlyBalanceUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Opening")] decimal _opening, [Parameter(Name = "@NormalLoans")] decimal _normalLoans, [Parameter(Name = "@IncomingLoans")] decimal _incomingLoans, [Parameter(Name = "@Restitution")] decimal _restitution, [Parameter(Name = "@OutgoingLoans")] decimal _outgoingLoans, [Parameter(Name = "@SalaryPayment")] decimal _salaryPayment, [Parameter(Name = "@CashPayment")] decimal _cashPayment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _paymentGroup, _month, _opening, _normalLoans, _incomingLoans, _restitution, _outgoingLoans, _salaryPayment, _cashPayment);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[MonthlyBalance] table.
		/// </summary>
		/// <param name="instance">An instance of MonthlyBalance whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void MonthlyBalanceUpdate(MonthlyBalance instance)
		{
			_MonthlyBalanceUpdate(instance.Id, instance.Employee, instance.PaymentGroup, instance.Month, instance.Opening, instance.NormalLoans, instance.IncomingLoans, instance.Restitution, instance.OutgoingLoans, instance.SalaryPayment, instance.CashPayment);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.MonthlyBalanceDelete")]
		private int _MonthlyBalanceDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[MonthlyBalance] table.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		public void MonthlyBalanceDelete([Parameter(Name = "@Id")] int _id)
		{
			_MonthlyBalanceDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.MonthlyBalanceGetByEmployee")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of MonthlyBalance instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalance> MonthlyBalanceGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _MonthlyBalanceGetByEmployee(_employee).ToList<MonthlyBalance>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of MonthlyBalance or null.</returns>
		public MonthlyBalance MonthlyBalanceGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<MonthlyBalance> list = _MonthlyBalanceGetByEmployee(_employee).ToList<MonthlyBalance>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.MonthlyBalanceGetByEmployee_PaymentGroup_Month")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceGetByEmployee_PaymentGroup_Month([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentGroup, _month);
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentGroup, Month) columns  in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		/// <returns>A list of MonthlyBalance instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalance> MonthlyBalanceGetByEmployee_PaymentGroup_Month([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceGetByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month).ToList<MonthlyBalance>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentGroup, Month) columns  in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		/// <returns>Gets an instance of MonthlyBalance or null.</returns>
		public MonthlyBalance MonthlyBalanceGetByEmployee_PaymentGroup_MonthFirstOrNull([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month)
		{
			List<MonthlyBalance> list = _MonthlyBalanceGetByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month).ToList<MonthlyBalance>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.MonthlyBalanceGetByMonth")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_month">الشهر</param>
		/// <returns>A list of MonthlyBalance instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalance> MonthlyBalanceGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceGetByMonth(_month).ToList<MonthlyBalance>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_month">الشهر</param>
		/// <returns>Gets an instance of MonthlyBalance or null.</returns>
		public MonthlyBalance MonthlyBalanceGetByMonthFirstOrNull([Parameter(Name = "@Month")] DateTime _month)
		{
			List<MonthlyBalance> list = _MonthlyBalanceGetByMonth(_month).ToList<MonthlyBalance>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.MonthlyBalanceGetByPaymentGroup")]
		private ISingleResult<MonthlyBalance> _MonthlyBalanceGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (result.ReturnValue as ISingleResult<MonthlyBalance>);
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>A list of MonthlyBalance instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalance> MonthlyBalanceGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			return _MonthlyBalanceGetByPaymentGroup(_paymentGroup).ToList<MonthlyBalance>();
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>Gets an instance of MonthlyBalance or null.</returns>
		public MonthlyBalance MonthlyBalanceGetByPaymentGroupFirstOrNull([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			List<MonthlyBalance> list = _MonthlyBalanceGetByPaymentGroup(_paymentGroup).ToList<MonthlyBalance>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.MonthlyBalanceDeleteByEmployee")]
		private int _MonthlyBalanceDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void MonthlyBalanceDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_MonthlyBalanceDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.MonthlyBalanceDeleteByEmployee_PaymentGroup_Month")]
		private int _MonthlyBalanceDeleteByEmployee_PaymentGroup_Month([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _paymentGroup, _month);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Employee, PaymentGroup, Month columns in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		public void MonthlyBalanceDeleteByEmployee_PaymentGroup_Month([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Month")] DateTime _month)
		{
			_MonthlyBalanceDeleteByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month);
		}		

        [Function(Name = "dbo.MonthlyBalanceDeleteByMonth")]
		private int _MonthlyBalanceDeleteByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_month">الشهر</param>
		public void MonthlyBalanceDeleteByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			_MonthlyBalanceDeleteByMonth(_month);
		}		

        [Function(Name = "dbo.MonthlyBalanceDeleteByPaymentGroup")]
		private int _MonthlyBalanceDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.MonthlyBalance table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		public void MonthlyBalanceDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			_MonthlyBalanceDeleteByPaymentGroup(_paymentGroup);
		}
		#endregion
        #endregion

		#region OutgoingLoan procedures.
		#region List procedure
		[Function(Name = "dbo.OutgoingLoanList")]
		private ISingleResult<OutgoingLoan> _OutgoingLoanList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<OutgoingLoan>);
		}

		/// <summary>
		/// Selects all rows from the dbo.OutgoingLoan table.
		/// </summary>
		/// <returns>A list of OutgoingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoan> OutgoingLoanList()
		{
			return _OutgoingLoanList().ToList<OutgoingLoan>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.OutgoingLoanGet")]
		private ISingleResult<OutgoingLoan> _OutgoingLoanGet([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return (result.ReturnValue as ISingleResult<OutgoingLoan>);
		}

		/// <summary>
		/// Gets one row from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of OutgoingLoan or null.</returns>
		public OutgoingLoan OutgoingLoanGet([Parameter(Name = "@Loan")] int _loan)
		{
			List<OutgoingLoan> list = _OutgoingLoanGet(_loan).ToList<OutgoingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.OutgoingLoanInsert")]
		private ISingleResult<OutgoingLoan> _OutgoingLoanInsert([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@LoanDecision")] int _loanDecision, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace, [Parameter(Name = "@ApprovedAmount")] decimal _approvedAmount, [Parameter(Name = "@NetAmount")] decimal _netAmount, [Parameter(Name = "@ProfitAmount")] decimal _profitAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _loanDecision, _mainWorkPlace, _approvedAmount, _netAmount, _profitAmount);
			return (result.ReturnValue) as ISingleResult<OutgoingLoan>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[OutgoingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of OutgoingLoan to be inserted.</param>
		/// <returns>The inserted OutgoingLoan</returns>
		public OutgoingLoan OutgoingLoanInsert(OutgoingLoan instance)
		{
            List<OutgoingLoan> list = _OutgoingLoanInsert(instance.Loan, instance.LoanDecision, instance.MainWorkPlace, instance.ApprovedAmount, instance.NetAmount, instance.ProfitAmount).ToList<OutgoingLoan>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.OutgoingLoanUpdate")]
		private int _OutgoingLoanUpdate([Parameter(Name = "@Loan")] int _loan, [Parameter(Name = "@LoanDecision")] int _loanDecision, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace, [Parameter(Name = "@ApprovedAmount")] decimal _approvedAmount, [Parameter(Name = "@NetAmount")] decimal _netAmount, [Parameter(Name = "@ProfitAmount")] decimal _profitAmount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan, _loanDecision, _mainWorkPlace, _approvedAmount, _netAmount, _profitAmount);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[OutgoingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of OutgoingLoan whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void OutgoingLoanUpdate(OutgoingLoan instance)
		{
			_OutgoingLoanUpdate(instance.Loan, instance.LoanDecision, instance.MainWorkPlace, instance.ApprovedAmount, instance.NetAmount, instance.ProfitAmount);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.OutgoingLoanDelete")]
		private int _OutgoingLoanDelete([Parameter(Name = "@Loan")] int _loan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loan);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[OutgoingLoan] table.
		/// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		public void OutgoingLoanDelete([Parameter(Name = "@Loan")] int _loan)
		{
			_OutgoingLoanDelete(_loan);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.OutgoingLoanGetByLoanDecision")]
		private ISingleResult<OutgoingLoan> _OutgoingLoanGetByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecision);
			return (result.ReturnValue as ISingleResult<OutgoingLoan>);
		}

		/// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		/// <returns>A list of OutgoingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoan> OutgoingLoanGetByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			return _OutgoingLoanGetByLoanDecision(_loanDecision).ToList<OutgoingLoan>();
		}

		/// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		/// <returns>Gets an instance of OutgoingLoan or null.</returns>
		public OutgoingLoan OutgoingLoanGetByLoanDecisionFirstOrNull([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			List<OutgoingLoan> list = _OutgoingLoanGetByLoanDecision(_loanDecision).ToList<OutgoingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.OutgoingLoanGetByMainWorkPlace")]
		private ISingleResult<OutgoingLoan> _OutgoingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (result.ReturnValue as ISingleResult<OutgoingLoan>);
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		/// <returns>A list of OutgoingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoan> OutgoingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			return _OutgoingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<OutgoingLoan>();
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		/// <returns>Gets an instance of OutgoingLoan or null.</returns>
		public OutgoingLoan OutgoingLoanGetByMainWorkPlaceFirstOrNull([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			List<OutgoingLoan> list = _OutgoingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<OutgoingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.OutgoingLoanDeleteByLoanDecision")]
		private int _OutgoingLoanDeleteByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecision);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		public void OutgoingLoanDeleteByLoanDecision([Parameter(Name = "@LoanDecision")] int _loanDecision)
		{
			_OutgoingLoanDeleteByLoanDecision(_loanDecision);
		}		

        [Function(Name = "dbo.OutgoingLoanDeleteByMainWorkPlace")]
		private int _OutgoingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		public void OutgoingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			_OutgoingLoanDeleteByMainWorkPlace(_mainWorkPlace);
		}
		#endregion
        #endregion

		#region Payment procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentList")]
		private ISingleResult<Payment> _PaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Payment table.
		/// </summary>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentList()
		{
			return _PaymentList().ToList<Payment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentGet")]
		private ISingleResult<Payment> _PaymentGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets one row from the dbo.Payment table.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGet([Parameter(Name = "@Id")] int _id)
		{
			List<Payment> list = _PaymentGet(_id).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.PaymentInsert")]
		private ISingleResult<Payment> _PaymentInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus, [Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _date, _paymentGroup, _amount, _notes, _paymentStatus, _collectOrder);
			return (result.ReturnValue) as ISingleResult<Payment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Payment] table.
		/// </summary>
		/// <param name="instance">An instance of Payment to be inserted.</param>
		/// <returns>The inserted Payment</returns>
		public Payment PaymentInsert(Payment instance)
		{
            List<Payment> list = _PaymentInsert(instance.Employee, instance.Date, instance.PaymentGroup, instance.Amount, instance.Notes, instance.PaymentStatus, instance.CollectOrder).ToList<Payment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.PaymentUpdate")]
		private int _PaymentUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus, [Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _date, _paymentGroup, _amount, _notes, _paymentStatus, _collectOrder);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Payment] table.
		/// </summary>
		/// <param name="instance">An instance of Payment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void PaymentUpdate(Payment instance)
		{
			_PaymentUpdate(instance.Id, instance.Employee, instance.Date, instance.PaymentGroup, instance.Amount, instance.Notes, instance.PaymentStatus, instance.CollectOrder);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.PaymentDelete")]
		private int _PaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Payment] table.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		public void PaymentDelete([Parameter(Name = "@Id")] int _id)
		{
			_PaymentDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PaymentGetByCollectOrder")]
		private ISingleResult<Payment> _PaymentGetByCollectOrder([Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _collectOrder);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
		/// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentGetByCollectOrder([Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			return _PaymentGetByCollectOrder(_collectOrder).ToList<Payment>();
		}

		/// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
		/// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGetByCollectOrderFirstOrNull([Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			List<Payment> list = _PaymentGetByCollectOrder(_collectOrder).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PaymentGetByDate")]
		private ISingleResult<Payment> _PaymentGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PaymentGetByDate(_date).ToList<Payment>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGetByDateFirstOrNull([Parameter(Name = "@Date")] DateTime _date)
		{
			List<Payment> list = _PaymentGetByDate(_date).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PaymentGetByEmployee")]
		private ISingleResult<Payment> _PaymentGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _PaymentGetByEmployee(_employee).ToList<Payment>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Payment> list = _PaymentGetByEmployee(_employee).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PaymentGetByPaymentGroup")]
		private ISingleResult<Payment> _PaymentGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			return _PaymentGetByPaymentGroup(_paymentGroup).ToList<Payment>();
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGetByPaymentGroupFirstOrNull([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			List<Payment> list = _PaymentGetByPaymentGroup(_paymentGroup).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PaymentGetByPaymentStatus")]
		private ISingleResult<Payment> _PaymentGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatus);
			return (result.ReturnValue as ISingleResult<Payment>);
		}

		/// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		/// <returns>A list of Payment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Payment> PaymentGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			return _PaymentGetByPaymentStatus(_paymentStatus).ToList<Payment>();
		}

		/// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		/// <returns>Gets an instance of Payment or null.</returns>
		public Payment PaymentGetByPaymentStatusFirstOrNull([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			List<Payment> list = _PaymentGetByPaymentStatus(_paymentStatus).ToList<Payment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.PaymentDeleteByCollectOrder")]
		private int _PaymentDeleteByCollectOrder([Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _collectOrder);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one CollectOrder from the dbo.Payment table.
		/// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		public void PaymentDeleteByCollectOrder([Parameter(Name = "@CollectOrder")] Nullable<int> _collectOrder)
		{
			_PaymentDeleteByCollectOrder(_collectOrder);
		}		

        [Function(Name = "dbo.PaymentDeleteByDate")]
		private int _PaymentDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Payment table.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		public void PaymentDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			_PaymentDeleteByDate(_date);
		}		

        [Function(Name = "dbo.PaymentDeleteByEmployee")]
		private int _PaymentDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Payment table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void PaymentDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_PaymentDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.PaymentDeleteByPaymentGroup")]
		private int _PaymentDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		public void PaymentDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			_PaymentDeleteByPaymentGroup(_paymentGroup);
		}		

        [Function(Name = "dbo.PaymentDeleteByPaymentStatus")]
		private int _PaymentDeleteByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one PaymentStatus from the dbo.Payment table.
		/// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		public void PaymentDeleteByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			_PaymentDeleteByPaymentStatus(_paymentStatus);
		}
		#endregion
        #endregion

		#region PaymentGroup procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentGroupList")]
		private ISingleResult<PaymentGroup> _PaymentGroupList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentGroup>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentGroup table.
		/// </summary>
		/// <returns>A list of PaymentGroup instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentGroup> PaymentGroupList()
		{
			return _PaymentGroupList().ToList<PaymentGroup>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentGroupGet")]
		private ISingleResult<PaymentGroup> _PaymentGroupGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentGroup>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentGroup table.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroup or null.</returns>
		public PaymentGroup PaymentGroupGet([Parameter(Name = "@Id")] byte _id)
		{
			List<PaymentGroup> list = _PaymentGroupGet(_id).ToList<PaymentGroup>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.PaymentGroupInsert")]
		private ISingleResult<PaymentGroup> _PaymentGroupInsert([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue) as ISingleResult<PaymentGroup>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[PaymentGroup] table.
		/// </summary>
		/// <param name="instance">An instance of PaymentGroup to be inserted.</param>
		/// <returns>The inserted PaymentGroup</returns>
		public PaymentGroup PaymentGroupInsert(PaymentGroup instance)
		{
            List<PaymentGroup> list = _PaymentGroupInsert(instance.Name).ToList<PaymentGroup>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.PaymentGroupUpdate")]
		private int _PaymentGroupUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[PaymentGroup] table.
		/// </summary>
		/// <param name="instance">An instance of PaymentGroup whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void PaymentGroupUpdate(PaymentGroup instance)
		{
			_PaymentGroupUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.PaymentGroupDelete")]
		private int _PaymentGroupDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[PaymentGroup] table.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		public void PaymentGroupDelete([Parameter(Name = "@Id")] byte _id)
		{
			_PaymentGroupDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PaymentGroupGetByName")]
		private ISingleResult<PaymentGroup> _PaymentGroupGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<PaymentGroup>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		/// <returns>A list of PaymentGroup instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentGroup> PaymentGroupGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _PaymentGroupGetByName(_name).ToList<PaymentGroup>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroup or null.</returns>
		public PaymentGroup PaymentGroupGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<PaymentGroup> list = _PaymentGroupGetByName(_name).ToList<PaymentGroup>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.PaymentGroupDeleteByName")]
		private int _PaymentGroupDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.PaymentGroup table.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		public void PaymentGroupDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_PaymentGroupDeleteByName(_name);
		}
		#endregion
        #endregion

		#region PaymentStatus procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentStatusList")]
		private ISingleResult<PaymentStatus> _PaymentStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentStatus table.
		/// </summary>
		/// <returns>A list of PaymentStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentStatus> PaymentStatusList()
		{
			return _PaymentStatusList().ToList<PaymentStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentStatusGet")]
		private ISingleResult<PaymentStatus> _PaymentStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentStatus table.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		/// <returns>Gets an instance of PaymentStatus or null.</returns>
		public PaymentStatus PaymentStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<PaymentStatus> list = _PaymentStatusGet(_id).ToList<PaymentStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.PaymentStatusInsert")]
		private ISingleResult<PaymentStatus> _PaymentStatusInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<PaymentStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[PaymentStatus] table.
		/// </summary>
		/// <param name="instance">An instance of PaymentStatus to be inserted.</param>
		/// <returns>The inserted PaymentStatus</returns>
		public PaymentStatus PaymentStatusInsert(PaymentStatus instance)
		{
            List<PaymentStatus> list = _PaymentStatusInsert(instance.Id, instance.Name).ToList<PaymentStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.PaymentStatusUpdate")]
		private int _PaymentStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[PaymentStatus] table.
		/// </summary>
		/// <param name="instance">An instance of PaymentStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void PaymentStatusUpdate(PaymentStatus instance)
		{
			_PaymentStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.PaymentStatusDelete")]
		private int _PaymentStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[PaymentStatus] table.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		public void PaymentStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_PaymentStatusDelete(_id);
		}
		#endregion
        #endregion

		#region PayOrder procedures.
		#region List procedure
		[Function(Name = "dbo.PayOrderList")]
		private ISingleResult<PayOrder> _PayOrderList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PayOrder table.
		/// </summary>
		/// <returns>A list of PayOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrder> PayOrderList()
		{
			return _PayOrderList().ToList<PayOrder>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PayOrderGet")]
		private ISingleResult<PayOrder> _PayOrderGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Gets one row from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		/// <returns>Gets an instance of PayOrder or null.</returns>
		public PayOrder PayOrderGet([Parameter(Name = "@Id")] int _id)
		{
			List<PayOrder> list = _PayOrderGet(_id).ToList<PayOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.PayOrderInsert")]
		private ISingleResult<PayOrder> _PayOrderInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@VoucherNumber")] Nullable<short> _voucherNumber, [Parameter(Name = "@VoucherDate")] Nullable<DateTime> _voucherDate, [Parameter(Name = "@PaymentNumber")] Nullable<short> _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@AccountingDocumentNumber")] Nullable<short> _accountingDocumentNumber, [Parameter(Name = "@AccountingDocumentDate")] Nullable<DateTime> _accountingDocumentDate, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@PaidAmount")] decimal _paidAmount, [Parameter(Name = "@IsProfit")] bool _isProfit, [Parameter(Name = "@IsFixed")] byte _isFixed, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _number, _date, _voucherNumber, _voucherDate, _paymentNumber, _paymentDate, _accountingDocumentNumber, _accountingDocumentDate, _paymentGroup, _paidAmount, _isProfit, _isFixed, _notes);
			return (result.ReturnValue) as ISingleResult<PayOrder>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[PayOrder] table.
		/// </summary>
		/// <param name="instance">An instance of PayOrder to be inserted.</param>
		/// <returns>The inserted PayOrder</returns>
		public PayOrder PayOrderInsert(PayOrder instance)
		{
            List<PayOrder> list = _PayOrderInsert(instance.Employee, instance.Number, instance.Date, instance.VoucherNumber, instance.VoucherDate, instance.PaymentNumber, instance.PaymentDate, instance.AccountingDocumentNumber, instance.AccountingDocumentDate, instance.PaymentGroup, instance.PaidAmount, instance.IsProfit, instance.IsFixed, instance.Notes).ToList<PayOrder>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.PayOrderUpdate")]
		private int _PayOrderUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@VoucherNumber")] Nullable<short> _voucherNumber, [Parameter(Name = "@VoucherDate")] Nullable<DateTime> _voucherDate, [Parameter(Name = "@PaymentNumber")] Nullable<short> _paymentNumber, [Parameter(Name = "@PaymentDate")] Nullable<DateTime> _paymentDate, [Parameter(Name = "@AccountingDocumentNumber")] Nullable<short> _accountingDocumentNumber, [Parameter(Name = "@AccountingDocumentDate")] Nullable<DateTime> _accountingDocumentDate, [Parameter(Name = "@PaymentGroup")] byte _paymentGroup, [Parameter(Name = "@PaidAmount")] decimal _paidAmount, [Parameter(Name = "@IsProfit")] bool _isProfit, [Parameter(Name = "@IsFixed")] byte _isFixed, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _number, _date, _voucherNumber, _voucherDate, _paymentNumber, _paymentDate, _accountingDocumentNumber, _accountingDocumentDate, _paymentGroup, _paidAmount, _isProfit, _isFixed, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[PayOrder] table.
		/// </summary>
		/// <param name="instance">An instance of PayOrder whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void PayOrderUpdate(PayOrder instance)
		{
			_PayOrderUpdate(instance.Id, instance.Employee, instance.Number, instance.Date, instance.VoucherNumber, instance.VoucherDate, instance.PaymentNumber, instance.PaymentDate, instance.AccountingDocumentNumber, instance.AccountingDocumentDate, instance.PaymentGroup, instance.PaidAmount, instance.IsProfit, instance.IsFixed, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.PayOrderDelete")]
		private int _PayOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[PayOrder] table.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		public void PayOrderDelete([Parameter(Name = "@Id")] int _id)
		{
			_PayOrderDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PayOrderGetByDate")]
		private ISingleResult<PayOrder> _PayOrderGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		/// <returns>A list of PayOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrder> PayOrderGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PayOrderGetByDate(_date).ToList<PayOrder>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		/// <returns>Gets an instance of PayOrder or null.</returns>
		public PayOrder PayOrderGetByDateFirstOrNull([Parameter(Name = "@Date")] DateTime _date)
		{
			List<PayOrder> list = _PayOrderGetByDate(_date).ToList<PayOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PayOrderGetByEmployee")]
		private ISingleResult<PayOrder> _PayOrderGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of PayOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrder> PayOrderGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _PayOrderGetByEmployee(_employee).ToList<PayOrder>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of PayOrder or null.</returns>
		public PayOrder PayOrderGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<PayOrder> list = _PayOrderGetByEmployee(_employee).ToList<PayOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PayOrderGetByIsFixed")]
		private ISingleResult<PayOrder> _PayOrderGetByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		/// <returns>A list of PayOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrder> PayOrderGetByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			return _PayOrderGetByIsFixed(_isFixed).ToList<PayOrder>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		/// <returns>Gets an instance of PayOrder or null.</returns>
		public PayOrder PayOrderGetByIsFixedFirstOrNull([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			List<PayOrder> list = _PayOrderGetByIsFixed(_isFixed).ToList<PayOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.PayOrderGetByPaymentGroup")]
		private ISingleResult<PayOrder> _PayOrderGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (result.ReturnValue as ISingleResult<PayOrder>);
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>A list of PayOrder instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrder> PayOrderGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			return _PayOrderGetByPaymentGroup(_paymentGroup).ToList<PayOrder>();
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>Gets an instance of PayOrder or null.</returns>
		public PayOrder PayOrderGetByPaymentGroupFirstOrNull([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			List<PayOrder> list = _PayOrderGetByPaymentGroup(_paymentGroup).ToList<PayOrder>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.PayOrderDeleteByDate")]
		private int _PayOrderDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		public void PayOrderDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			_PayOrderDeleteByDate(_date);
		}		

        [Function(Name = "dbo.PayOrderDeleteByEmployee")]
		private int _PayOrderDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void PayOrderDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_PayOrderDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.PayOrderDeleteByIsFixed")]
		private int _PayOrderDeleteByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.PayOrder table.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		public void PayOrderDeleteByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			_PayOrderDeleteByIsFixed(_isFixed);
		}		

        [Function(Name = "dbo.PayOrderDeleteByPaymentGroup")]
		private int _PayOrderDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.PayOrder table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		public void PayOrderDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] byte _paymentGroup)
		{
			_PayOrderDeleteByPaymentGroup(_paymentGroup);
		}
		#endregion
        #endregion

		#region Product procedures.
		#region List procedure
		[Function(Name = "dbo.ProductList")]
		private ISingleResult<Product> _ProductList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Product>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Product table.
		/// </summary>
		/// <returns>A list of Product instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Product> ProductList()
		{
			return _ProductList().ToList<Product>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductGet")]
		private ISingleResult<Product> _ProductGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Product>);
		}

		/// <summary>
		/// Gets one row from the dbo.Product table.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of Product or null.</returns>
		public Product ProductGet([Parameter(Name = "@Id")] int _id)
		{
			List<Product> list = _ProductGet(_id).ToList<Product>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ProductInsert")]
		private ISingleResult<Product> _ProductInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _productType, _amount, _notes);
			return (result.ReturnValue) as ISingleResult<Product>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Product] table.
		/// </summary>
		/// <param name="instance">An instance of Product to be inserted.</param>
		/// <returns>The inserted Product</returns>
		public Product ProductInsert(Product instance)
		{
            List<Product> list = _ProductInsert(instance.Employee, instance.ProductType, instance.Amount, instance.Notes).ToList<Product>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ProductUpdate")]
		private int _ProductUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _productType, _amount, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Product] table.
		/// </summary>
		/// <param name="instance">An instance of Product whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ProductUpdate(Product instance)
		{
			_ProductUpdate(instance.Id, instance.Employee, instance.ProductType, instance.Amount, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ProductDelete")]
		private int _ProductDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Product] table.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		public void ProductDelete([Parameter(Name = "@Id")] int _id)
		{
			_ProductDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductGetByEmployee")]
		private ISingleResult<Product> _ProductGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Product>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of Product instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Product> ProductGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _ProductGetByEmployee(_employee).ToList<Product>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Product or null.</returns>
		public Product ProductGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Product> list = _ProductGetByEmployee(_employee).ToList<Product>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ProductGetByProductType")]
		private ISingleResult<Product> _ProductGetByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (result.ReturnValue as ISingleResult<Product>);
		}

		/// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <returns>A list of Product instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Product> ProductGetByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			return _ProductGetByProductType(_productType).ToList<Product>();
		}

		/// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <returns>Gets an instance of Product or null.</returns>
		public Product ProductGetByProductTypeFirstOrNull([Parameter(Name = "@ProductType")] short _productType)
		{
			List<Product> list = _ProductGetByProductType(_productType).ToList<Product>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ProductDeleteByEmployee")]
		private int _ProductDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Product table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void ProductDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_ProductDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.ProductDeleteByProductType")]
		private int _ProductDeleteByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one ProductType from the dbo.Product table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		public void ProductDeleteByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			_ProductDeleteByProductType(_productType);
		}
		#endregion
        #endregion

		#region ProductType procedures.
		#region List procedure
		[Function(Name = "dbo.ProductTypeList")]
		private ISingleResult<ProductType> _ProductTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductType table.
		/// </summary>
		/// <returns>A list of ProductType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductType> ProductTypeList()
		{
			return _ProductTypeList().ToList<ProductType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductTypeGet")]
		private ISingleResult<ProductType> _ProductTypeGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductType>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductType table.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductType or null.</returns>
		public ProductType ProductTypeGet([Parameter(Name = "@Id")] short _id)
		{
			List<ProductType> list = _ProductTypeGet(_id).ToList<ProductType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ProductTypeInsert")]
		private ISingleResult<ProductType> _ProductTypeInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Rate")] Nullable<decimal> _rate, [Parameter(Name = "@GuarantorsCount")] byte _guarantorsCount, [Parameter(Name = "@AccountNumber")] string _accountNumber, [Parameter(Name = "@PrintLabel")] string _printLabel, [Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy, [Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup, [Parameter(Name = "@IsActive")] Nullable<bool> _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _rate, _guarantorsCount, _accountNumber, _printLabel, _profitStrategy, _paymentGroup, _isActive);
			return (result.ReturnValue) as ISingleResult<ProductType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ProductType] table.
		/// </summary>
		/// <param name="instance">An instance of ProductType to be inserted.</param>
		/// <returns>The inserted ProductType</returns>
		public ProductType ProductTypeInsert(ProductType instance)
		{
            List<ProductType> list = _ProductTypeInsert(instance.Name, instance.Rate, instance.GuarantorsCount, instance.AccountNumber, instance.PrintLabel, instance.ProfitStrategy, instance.PaymentGroup, instance.IsActive).ToList<ProductType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ProductTypeUpdate")]
		private int _ProductTypeUpdate([Parameter(Name = "@Id")] short _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@Rate")] Nullable<decimal> _rate, [Parameter(Name = "@GuarantorsCount")] byte _guarantorsCount, [Parameter(Name = "@AccountNumber")] string _accountNumber, [Parameter(Name = "@PrintLabel")] string _printLabel, [Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy, [Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup, [Parameter(Name = "@IsActive")] Nullable<bool> _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _rate, _guarantorsCount, _accountNumber, _printLabel, _profitStrategy, _paymentGroup, _isActive);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ProductType] table.
		/// </summary>
		/// <param name="instance">An instance of ProductType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ProductTypeUpdate(ProductType instance)
		{
			_ProductTypeUpdate(instance.Id, instance.Name, instance.Rate, instance.GuarantorsCount, instance.AccountNumber, instance.PrintLabel, instance.ProfitStrategy, instance.PaymentGroup, instance.IsActive);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ProductTypeDelete")]
		private int _ProductTypeDelete([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ProductType] table.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		public void ProductTypeDelete([Parameter(Name = "@Id")] short _id)
		{
			_ProductTypeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductTypeGetByName")]
		private ISingleResult<ProductType> _ProductTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<ProductType>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>A list of ProductType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductType> ProductTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _ProductTypeGetByName(_name).ToList<ProductType>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>Gets an instance of ProductType or null.</returns>
		public ProductType ProductTypeGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<ProductType> list = _ProductTypeGetByName(_name).ToList<ProductType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ProductTypeGetByPaymentGroup")]
		private ISingleResult<ProductType> _ProductTypeGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (result.ReturnValue as ISingleResult<ProductType>);
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>A list of ProductType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductType> ProductTypeGetByPaymentGroup([Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup)
		{
			return _ProductTypeGetByPaymentGroup(_paymentGroup).ToList<ProductType>();
		}

		/// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <returns>Gets an instance of ProductType or null.</returns>
		public ProductType ProductTypeGetByPaymentGroupFirstOrNull([Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup)
		{
			List<ProductType> list = _ProductTypeGetByPaymentGroup(_paymentGroup).ToList<ProductType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ProductTypeGetByProfitStrategy")]
		private ISingleResult<ProductType> _ProductTypeGetByProfitStrategy([Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _profitStrategy);
			return (result.ReturnValue as ISingleResult<ProductType>);
		}

		/// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
		/// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProductType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductType> ProductTypeGetByProfitStrategy([Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy)
		{
			return _ProductTypeGetByProfitStrategy(_profitStrategy).ToList<ProductType>();
		}

		/// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
		/// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProductType or null.</returns>
		public ProductType ProductTypeGetByProfitStrategyFirstOrNull([Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy)
		{
			List<ProductType> list = _ProductTypeGetByProfitStrategy(_profitStrategy).ToList<ProductType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ProductTypeDeleteByName")]
		private int _ProductTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProductType table.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		public void ProductTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_ProductTypeDeleteByName(_name);
		}		

        [Function(Name = "dbo.ProductTypeDeleteByPaymentGroup")]
		private int _ProductTypeDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroup);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.ProductType table.
		/// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		public void ProductTypeDeleteByPaymentGroup([Parameter(Name = "@PaymentGroup")] Nullable<byte> _paymentGroup)
		{
			_ProductTypeDeleteByPaymentGroup(_paymentGroup);
		}		

        [Function(Name = "dbo.ProductTypeDeleteByProfitStrategy")]
		private int _ProductTypeDeleteByProfitStrategy([Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _profitStrategy);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one ProfitStrategy from the dbo.ProductType table.
		/// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		public void ProductTypeDeleteByProfitStrategy([Parameter(Name = "@ProfitStrategy")] Nullable<byte> _profitStrategy)
		{
			_ProductTypeDeleteByProfitStrategy(_profitStrategy);
		}
		#endregion
        #endregion

		#region ProductTypeAvailability procedures.
		#region List procedure
		[Function(Name = "dbo.ProductTypeAvailabilityList")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductTypeAvailability>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <returns>A list of ProductTypeAvailability instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailability> ProductTypeAvailabilityList()
		{
			return _ProductTypeAvailabilityList().ToList<ProductTypeAvailability>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductTypeAvailabilityGet")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailability>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		/// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
		public ProductTypeAvailability ProductTypeAvailabilityGet([Parameter(Name = "@Id")] int _id)
		{
			List<ProductTypeAvailability> list = _ProductTypeAvailabilityGet(_id).ToList<ProductTypeAvailability>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ProductTypeAvailabilityInsert")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityInsert([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType, _availability);
			return (result.ReturnValue) as ISingleResult<ProductTypeAvailability>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ProductTypeAvailability] table.
		/// </summary>
		/// <param name="instance">An instance of ProductTypeAvailability to be inserted.</param>
		/// <returns>The inserted ProductTypeAvailability</returns>
		public ProductTypeAvailability ProductTypeAvailabilityInsert(ProductTypeAvailability instance)
		{
            List<ProductTypeAvailability> list = _ProductTypeAvailabilityInsert(instance.ProductType, instance.Availability).ToList<ProductTypeAvailability>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ProductTypeAvailabilityUpdate")]
		private int _ProductTypeAvailabilityUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _productType, _availability);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ProductTypeAvailability] table.
		/// </summary>
		/// <param name="instance">An instance of ProductTypeAvailability whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ProductTypeAvailabilityUpdate(ProductTypeAvailability instance)
		{
			_ProductTypeAvailabilityUpdate(instance.Id, instance.ProductType, instance.Availability);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ProductTypeAvailabilityDelete")]
		private int _ProductTypeAvailabilityDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ProductTypeAvailability] table.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		public void ProductTypeAvailabilityDelete([Parameter(Name = "@Id")] int _id)
		{
			_ProductTypeAvailabilityDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductTypeAvailabilityGetByAvailability")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityGetByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailability>);
		}

		/// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailability instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailability> ProductTypeAvailabilityGetByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			return _ProductTypeAvailabilityGetByAvailability(_availability).ToList<ProductTypeAvailability>();
		}

		/// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		/// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
		public ProductTypeAvailability ProductTypeAvailabilityGetByAvailabilityFirstOrNull([Parameter(Name = "@Availability")] short _availability)
		{
			List<ProductTypeAvailability> list = _ProductTypeAvailabilityGetByAvailability(_availability).ToList<ProductTypeAvailability>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ProductTypeAvailabilityGetByProductType")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityGetByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailability>);
		}

		/// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <returns>A list of ProductTypeAvailability instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailability> ProductTypeAvailabilityGetByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			return _ProductTypeAvailabilityGetByProductType(_productType).ToList<ProductTypeAvailability>();
		}

		/// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
		public ProductTypeAvailability ProductTypeAvailabilityGetByProductTypeFirstOrNull([Parameter(Name = "@ProductType")] short _productType)
		{
			List<ProductTypeAvailability> list = _ProductTypeAvailabilityGetByProductType(_productType).ToList<ProductTypeAvailability>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ProductTypeAvailabilityGetByProductType_Availability")]
		private ISingleResult<ProductTypeAvailability> _ProductTypeAvailabilityGetByProductType_Availability([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType, _availability);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailability>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailability instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailability> ProductTypeAvailabilityGetByProductType_Availability([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			return _ProductTypeAvailabilityGetByProductType_Availability(_productType, _availability).ToList<ProductTypeAvailability>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		/// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
		public ProductTypeAvailability ProductTypeAvailabilityGetByProductType_AvailabilityFirstOrNull([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			List<ProductTypeAvailability> list = _ProductTypeAvailabilityGetByProductType_Availability(_productType, _availability).ToList<ProductTypeAvailability>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ProductTypeAvailabilityDeleteByAvailability")]
		private int _ProductTypeAvailabilityDeleteByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availability);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Availability from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		public void ProductTypeAvailabilityDeleteByAvailability([Parameter(Name = "@Availability")] short _availability)
		{
			_ProductTypeAvailabilityDeleteByAvailability(_availability);
		}		

        [Function(Name = "dbo.ProductTypeAvailabilityDeleteByProductType")]
		private int _ProductTypeAvailabilityDeleteByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one ProductType from the dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		public void ProductTypeAvailabilityDeleteByProductType([Parameter(Name = "@ProductType")] short _productType)
		{
			_ProductTypeAvailabilityDeleteByProductType(_productType);
		}		

        [Function(Name = "dbo.ProductTypeAvailabilityDeleteByProductType_Availability")]
		private int _ProductTypeAvailabilityDeleteByProductType_Availability([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productType, _availability);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of ProductType, Availability columns in the  dbo.ProductTypeAvailability table.
		/// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		public void ProductTypeAvailabilityDeleteByProductType_Availability([Parameter(Name = "@ProductType")] short _productType, [Parameter(Name = "@Availability")] short _availability)
		{
			_ProductTypeAvailabilityDeleteByProductType_Availability(_productType, _availability);
		}
		#endregion
        #endregion

		#region Profile procedures.
		#region List procedure
		[Function(Name = "dbo.ProfileList")]
		private ISingleResult<Profile> _ProfileList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Profile>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Profile table.
		/// </summary>
		/// <returns>A list of Profile instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Profile> ProfileList()
		{
			return _ProfileList().ToList<Profile>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProfileGet")]
		private ISingleResult<Profile> _ProfileGet([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Profile>);
		}

		/// <summary>
		/// Gets one row from the dbo.Profile table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Profile or null.</returns>
		public Profile ProfileGet([Parameter(Name = "@Employee")] int _employee)
		{
			List<Profile> list = _ProfileGet(_employee).ToList<Profile>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ProfileInsert")]
		private ISingleResult<Profile> _ProfileInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Extension")] string _extension, [Parameter(Name = "@HomePhone")] string _homePhone, [Parameter(Name = "@MobilePhone")] string _mobilePhone, [Parameter(Name = "@Address")] string _address)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _extension, _homePhone, _mobilePhone, _address);
			return (result.ReturnValue) as ISingleResult<Profile>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Profile] table.
		/// </summary>
		/// <param name="instance">An instance of Profile to be inserted.</param>
		/// <returns>The inserted Profile</returns>
		public Profile ProfileInsert(Profile instance)
		{
            List<Profile> list = _ProfileInsert(instance.Employee, instance.Extension, instance.HomePhone, instance.MobilePhone, instance.Address).ToList<Profile>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ProfileUpdate")]
		private int _ProfileUpdate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Extension")] string _extension, [Parameter(Name = "@HomePhone")] string _homePhone, [Parameter(Name = "@MobilePhone")] string _mobilePhone, [Parameter(Name = "@Address")] string _address)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _extension, _homePhone, _mobilePhone, _address);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Profile] table.
		/// </summary>
		/// <param name="instance">An instance of Profile whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ProfileUpdate(Profile instance)
		{
			_ProfileUpdate(instance.Employee, instance.Extension, instance.HomePhone, instance.MobilePhone, instance.Address);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ProfileDelete")]
		private int _ProfileDelete([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Profile] table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void ProfileDelete([Parameter(Name = "@Employee")] int _employee)
		{
			_ProfileDelete(_employee);
		}
		#endregion
        #endregion

		#region ProfitStrategy procedures.
		#region List procedure
		[Function(Name = "dbo.ProfitStrategyList")]
		private ISingleResult<ProfitStrategy> _ProfitStrategyList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProfitStrategy>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProfitStrategy table.
		/// </summary>
		/// <returns>A list of ProfitStrategy instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProfitStrategy> ProfitStrategyList()
		{
			return _ProfitStrategyList().ToList<ProfitStrategy>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProfitStrategyGet")]
		private ISingleResult<ProfitStrategy> _ProfitStrategyGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProfitStrategy>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProfitStrategy table.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategy or null.</returns>
		public ProfitStrategy ProfitStrategyGet([Parameter(Name = "@Id")] byte _id)
		{
			List<ProfitStrategy> list = _ProfitStrategyGet(_id).ToList<ProfitStrategy>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ProfitStrategyInsert")]
		private ISingleResult<ProfitStrategy> _ProfitStrategyInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<ProfitStrategy>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ProfitStrategy] table.
		/// </summary>
		/// <param name="instance">An instance of ProfitStrategy to be inserted.</param>
		/// <returns>The inserted ProfitStrategy</returns>
		public ProfitStrategy ProfitStrategyInsert(ProfitStrategy instance)
		{
            List<ProfitStrategy> list = _ProfitStrategyInsert(instance.Id, instance.Name).ToList<ProfitStrategy>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ProfitStrategyUpdate")]
		private int _ProfitStrategyUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ProfitStrategy] table.
		/// </summary>
		/// <param name="instance">An instance of ProfitStrategy whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ProfitStrategyUpdate(ProfitStrategy instance)
		{
			_ProfitStrategyUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ProfitStrategyDelete")]
		private int _ProfitStrategyDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ProfitStrategy] table.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		public void ProfitStrategyDelete([Parameter(Name = "@Id")] byte _id)
		{
			_ProfitStrategyDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProfitStrategyGetByName")]
		private ISingleResult<ProfitStrategy> _ProfitStrategyGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<ProfitStrategy>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProfitStrategy instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProfitStrategy> ProfitStrategyGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _ProfitStrategyGetByName(_name).ToList<ProfitStrategy>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategy or null.</returns>
		public ProfitStrategy ProfitStrategyGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<ProfitStrategy> list = _ProfitStrategyGetByName(_name).ToList<ProfitStrategy>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ProfitStrategyDeleteByName")]
		private int _ProfitStrategyDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProfitStrategy table.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		public void ProfitStrategyDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_ProfitStrategyDeleteByName(_name);
		}
		#endregion
        #endregion

		#region RefundableProduct procedures.
		#region List procedure
		[Function(Name = "dbo.RefundableProductList")]
		private ISingleResult<RefundableProduct> _RefundableProductList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RefundableProduct>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RefundableProduct table.
		/// </summary>
		/// <returns>A list of RefundableProduct instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RefundableProduct> RefundableProductList()
		{
			return _RefundableProductList().ToList<RefundableProduct>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RefundableProductGet")]
		private ISingleResult<RefundableProduct> _RefundableProductGet([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return (result.ReturnValue as ISingleResult<RefundableProduct>);
		}

		/// <summary>
		/// Gets one row from the dbo.RefundableProduct table.
		/// </summary>
		/// <param name="_product">معرف المنتج</param>
		/// <returns>Gets an instance of RefundableProduct or null.</returns>
		public RefundableProduct RefundableProductGet([Parameter(Name = "@Product")] int _product)
		{
			List<RefundableProduct> list = _RefundableProductGet(_product).ToList<RefundableProduct>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.RefundableProductInsert")]
		private ISingleResult<RefundableProduct> _RefundableProductInsert([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@PaymentPeriod")] short _paymentPeriod, [Parameter(Name = "@Installment")] decimal _installment, [Parameter(Name = "@NetAmount")] decimal _netAmount, [Parameter(Name = "@ProfitAmount")] decimal _profitAmount, [Parameter(Name = "@SyrianPoundRounds")] decimal _syrianPoundRounds)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _paymentPeriod, _installment, _netAmount, _profitAmount, _syrianPoundRounds);
			return (result.ReturnValue) as ISingleResult<RefundableProduct>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[RefundableProduct] table.
		/// </summary>
		/// <param name="instance">An instance of RefundableProduct to be inserted.</param>
		/// <returns>The inserted RefundableProduct</returns>
		public RefundableProduct RefundableProductInsert(RefundableProduct instance)
		{
            List<RefundableProduct> list = _RefundableProductInsert(instance.Product, instance.PaymentPeriod, instance.Installment, instance.NetAmount, instance.ProfitAmount, instance.SyrianPoundRounds).ToList<RefundableProduct>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.RefundableProductUpdate")]
		private int _RefundableProductUpdate([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@PaymentPeriod")] short _paymentPeriod, [Parameter(Name = "@Installment")] decimal _installment, [Parameter(Name = "@NetAmount")] decimal _netAmount, [Parameter(Name = "@ProfitAmount")] decimal _profitAmount, [Parameter(Name = "@SyrianPoundRounds")] decimal _syrianPoundRounds)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _paymentPeriod, _installment, _netAmount, _profitAmount, _syrianPoundRounds);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[RefundableProduct] table.
		/// </summary>
		/// <param name="instance">An instance of RefundableProduct whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void RefundableProductUpdate(RefundableProduct instance)
		{
			_RefundableProductUpdate(instance.Product, instance.PaymentPeriod, instance.Installment, instance.NetAmount, instance.ProfitAmount, instance.SyrianPoundRounds);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.RefundableProductDelete")]
		private int _RefundableProductDelete([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[RefundableProduct] table.
		/// </summary>
		/// <param name="_product">معرف المنتج</param>
		public void RefundableProductDelete([Parameter(Name = "@Product")] int _product)
		{
			_RefundableProductDelete(_product);
		}
		#endregion
        #endregion

		#region Request procedures.
		#region List procedure
		[Function(Name = "dbo.RequestList")]
		private ISingleResult<Request> _RequestList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Request>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Request table.
		/// </summary>
		/// <returns>A list of Request instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Request> RequestList()
		{
			return _RequestList().ToList<Request>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RequestGet")]
		private ISingleResult<Request> _RequestGet([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return (result.ReturnValue as ISingleResult<Request>);
		}

		/// <summary>
		/// Gets one row from the dbo.Request table.
		/// </summary>
		/// <param name="_product">معرف المنتج</param>
		/// <returns>Gets an instance of Request or null.</returns>
		public Request RequestGet([Parameter(Name = "@Product")] int _product)
		{
			List<Request> list = _RequestGet(_product).ToList<Request>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.RequestInsert")]
		private ISingleResult<Request> _RequestInsert([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Attachment")] string _attachment, [Parameter(Name = "@Cost")] decimal _cost, [Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus, [Parameter(Name = "@BypassStatus")] int _bypassStatus, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _date, _amount, _attachment, _cost, _requestStatus, _bypassStatus, _notes);
			return (result.ReturnValue) as ISingleResult<Request>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Request] table.
		/// </summary>
		/// <param name="instance">An instance of Request to be inserted.</param>
		/// <returns>The inserted Request</returns>
		public Request RequestInsert(Request instance)
		{
            List<Request> list = _RequestInsert(instance.Product, instance.Date, instance.Amount, instance.Attachment, instance.Cost, instance.RequestStatus, instance.BypassStatus, instance.Notes).ToList<Request>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.RequestUpdate")]
		private int _RequestUpdate([Parameter(Name = "@Product")] int _product, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Attachment")] string _attachment, [Parameter(Name = "@Cost")] decimal _cost, [Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus, [Parameter(Name = "@BypassStatus")] int _bypassStatus, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product, _date, _amount, _attachment, _cost, _requestStatus, _bypassStatus, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Request] table.
		/// </summary>
		/// <param name="instance">An instance of Request whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void RequestUpdate(Request instance)
		{
			_RequestUpdate(instance.Product, instance.Date, instance.Amount, instance.Attachment, instance.Cost, instance.RequestStatus, instance.BypassStatus, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.RequestDelete")]
		private int _RequestDelete([Parameter(Name = "@Product")] int _product)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _product);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Request] table.
		/// </summary>
		/// <param name="_product">معرف المنتج</param>
		public void RequestDelete([Parameter(Name = "@Product")] int _product)
		{
			_RequestDelete(_product);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.RequestGetByBypassStatus")]
		private ISingleResult<Request> _RequestGetByBypassStatus([Parameter(Name = "@BypassStatus")] int _bypassStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _bypassStatus);
			return (result.ReturnValue as ISingleResult<Request>);
		}

		/// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		/// <returns>A list of Request instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Request> RequestGetByBypassStatus([Parameter(Name = "@BypassStatus")] int _bypassStatus)
		{
			return _RequestGetByBypassStatus(_bypassStatus).ToList<Request>();
		}

		/// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		/// <returns>Gets an instance of Request or null.</returns>
		public Request RequestGetByBypassStatusFirstOrNull([Parameter(Name = "@BypassStatus")] int _bypassStatus)
		{
			List<Request> list = _RequestGetByBypassStatus(_bypassStatus).ToList<Request>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.RequestGetByRequestStatus")]
		private ISingleResult<Request> _RequestGetByRequestStatus([Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestStatus);
			return (result.ReturnValue as ISingleResult<Request>);
		}

		/// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		/// <returns>A list of Request instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Request> RequestGetByRequestStatus([Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus)
		{
			return _RequestGetByRequestStatus(_requestStatus).ToList<Request>();
		}

		/// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		/// <returns>Gets an instance of Request or null.</returns>
		public Request RequestGetByRequestStatusFirstOrNull([Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus)
		{
			List<Request> list = _RequestGetByRequestStatus(_requestStatus).ToList<Request>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.RequestDeleteByBypassStatus")]
		private int _RequestDeleteByBypassStatus([Parameter(Name = "@BypassStatus")] int _bypassStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _bypassStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one BypassStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		public void RequestDeleteByBypassStatus([Parameter(Name = "@BypassStatus")] int _bypassStatus)
		{
			_RequestDeleteByBypassStatus(_bypassStatus);
		}		

        [Function(Name = "dbo.RequestDeleteByRequestStatus")]
		private int _RequestDeleteByRequestStatus([Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestStatus);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one RequestStatus from the dbo.Request table.
		/// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		public void RequestDeleteByRequestStatus([Parameter(Name = "@RequestStatus")] Nullable<byte> _requestStatus)
		{
			_RequestDeleteByRequestStatus(_requestStatus);
		}
		#endregion
        #endregion

		#region RequestStatus procedures.
		#region List procedure
		[Function(Name = "dbo.RequestStatusList")]
		private ISingleResult<RequestStatus> _RequestStatusList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RequestStatus>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RequestStatus table.
		/// </summary>
		/// <returns>A list of RequestStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatus> RequestStatusList()
		{
			return _RequestStatusList().ToList<RequestStatus>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RequestStatusGet")]
		private ISingleResult<RequestStatus> _RequestStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<RequestStatus>);
		}

		/// <summary>
		/// Gets one row from the dbo.RequestStatus table.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatus or null.</returns>
		public RequestStatus RequestStatusGet([Parameter(Name = "@Id")] byte _id)
		{
			List<RequestStatus> list = _RequestStatusGet(_id).ToList<RequestStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.RequestStatusInsert")]
		private ISingleResult<RequestStatus> _RequestStatusInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<RequestStatus>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[RequestStatus] table.
		/// </summary>
		/// <param name="instance">An instance of RequestStatus to be inserted.</param>
		/// <returns>The inserted RequestStatus</returns>
		public RequestStatus RequestStatusInsert(RequestStatus instance)
		{
            List<RequestStatus> list = _RequestStatusInsert(instance.Id, instance.Name).ToList<RequestStatus>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.RequestStatusUpdate")]
		private int _RequestStatusUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[RequestStatus] table.
		/// </summary>
		/// <param name="instance">An instance of RequestStatus whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void RequestStatusUpdate(RequestStatus instance)
		{
			_RequestStatusUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.RequestStatusDelete")]
		private int _RequestStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[RequestStatus] table.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		public void RequestStatusDelete([Parameter(Name = "@Id")] byte _id)
		{
			_RequestStatusDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.RequestStatusGetByName")]
		private ISingleResult<RequestStatus> _RequestStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<RequestStatus>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		/// <returns>A list of RequestStatus instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatus> RequestStatusGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _RequestStatusGetByName(_name).ToList<RequestStatus>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatus or null.</returns>
		public RequestStatus RequestStatusGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<RequestStatus> list = _RequestStatusGetByName(_name).ToList<RequestStatus>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.RequestStatusDeleteByName")]
		private int _RequestStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.RequestStatus table.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		public void RequestStatusDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_RequestStatusDeleteByName(_name);
		}
		#endregion
        #endregion

		#region Resource procedures.
		#region List procedure
		[Function(Name = "dbo.ResourceList")]
		private ISingleResult<Resource> _ResourceList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Resource>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Resource table.
		/// </summary>
		/// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Resource> ResourceList()
		{
			return _ResourceList().ToList<Resource>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ResourceGet")]
		private ISingleResult<Resource> _ResourceGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Resource>);
		}

		/// <summary>
		/// Gets one row from the dbo.Resource table.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		/// <returns>Gets an instance of Resource or null.</returns>
		public Resource ResourceGet([Parameter(Name = "@Id")] int _id)
		{
			List<Resource> list = _ResourceGet(_id).ToList<Resource>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ResourceInsert")]
		private ISingleResult<Resource> _ResourceInsert([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key, [Parameter(Name = "@Value")] string _value, [Parameter(Name = "@IsEditable")] bool _isEditable)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _language, _module, _key, _value, _isEditable);
			return (result.ReturnValue) as ISingleResult<Resource>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Resource] table.
		/// </summary>
		/// <param name="instance">An instance of Resource to be inserted.</param>
		/// <returns>The inserted Resource</returns>
		public Resource ResourceInsert(Resource instance)
		{
            List<Resource> list = _ResourceInsert(instance.Language, instance.Module, instance.Key, instance.Value, instance.IsEditable).ToList<Resource>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ResourceUpdate")]
		private int _ResourceUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key, [Parameter(Name = "@Value")] string _value, [Parameter(Name = "@IsEditable")] bool _isEditable)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _language, _module, _key, _value, _isEditable);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Resource] table.
		/// </summary>
		/// <param name="instance">An instance of Resource whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ResourceUpdate(Resource instance)
		{
			_ResourceUpdate(instance.Id, instance.Language, instance.Module, instance.Key, instance.Value, instance.IsEditable);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ResourceDelete")]
		private int _ResourceDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Resource] table.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		public void ResourceDelete([Parameter(Name = "@Id")] int _id)
		{
			_ResourceDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ResourceGetByLanguage_Module_Key")]
		private ISingleResult<Resource> _ResourceGetByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _language, _module, _key);
			return (result.ReturnValue as ISingleResult<Resource>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		/// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Resource> ResourceGetByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			return _ResourceGetByLanguage_Module_Key(_language, _module, _key).ToList<Resource>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		/// <returns>Gets an instance of Resource or null.</returns>
		public Resource ResourceGetByLanguage_Module_KeyFirstOrNull([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			List<Resource> list = _ResourceGetByLanguage_Module_Key(_language, _module, _key).ToList<Resource>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.ResourceGetByModule")]
		private ISingleResult<Resource> _ResourceGetByModule([Parameter(Name = "@Module")] string _module)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _module);
			return (result.ReturnValue as ISingleResult<Resource>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		/// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Resource> ResourceGetByModule([Parameter(Name = "@Module")] string _module)
		{
			return _ResourceGetByModule(_module).ToList<Resource>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		/// <returns>Gets an instance of Resource or null.</returns>
		public Resource ResourceGetByModuleFirstOrNull([Parameter(Name = "@Module")] string _module)
		{
			List<Resource> list = _ResourceGetByModule(_module).ToList<Resource>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.ResourceDeleteByLanguage_Module_Key")]
		private int _ResourceDeleteByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _language, _module, _key);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Language, Module, Key columns in the  dbo.Resource table.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		public void ResourceDeleteByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			_ResourceDeleteByLanguage_Module_Key(_language, _module, _key);
		}		

        [Function(Name = "dbo.ResourceDeleteByModule")]
		private int _ResourceDeleteByModule([Parameter(Name = "@Module")] string _module)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _module);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Module columns in the  dbo.Resource table.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		public void ResourceDeleteByModule([Parameter(Name = "@Module")] string _module)
		{
			_ResourceDeleteByModule(_module);
		}
		#endregion
        #endregion

		#region SalaryPayment procedures.
		#region List procedure
		[Function(Name = "dbo.SalaryPaymentList")]
		private ISingleResult<SalaryPayment> _SalaryPaymentList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SalaryPayment>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SalaryPayment table.
		/// </summary>
		/// <returns>A list of SalaryPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryPayment> SalaryPaymentList()
		{
			return _SalaryPaymentList().ToList<SalaryPayment>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SalaryPaymentGet")]
		private ISingleResult<SalaryPayment> _SalaryPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return (result.ReturnValue as ISingleResult<SalaryPayment>);
		}

		/// <summary>
		/// Gets one row from the dbo.SalaryPayment table.
		/// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
		/// <returns>Gets an instance of SalaryPayment or null.</returns>
		public SalaryPayment SalaryPaymentGet([Parameter(Name = "@Payment")] int _payment)
		{
			List<SalaryPayment> list = _SalaryPaymentGet(_payment).ToList<SalaryPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SalaryPaymentInsert")]
		private ISingleResult<SalaryPayment> _SalaryPaymentInsert([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@Balance")] Nullable<decimal> _balance)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _department, _balance);
			return (result.ReturnValue) as ISingleResult<SalaryPayment>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[SalaryPayment] table.
		/// </summary>
		/// <param name="instance">An instance of SalaryPayment to be inserted.</param>
		/// <returns>The inserted SalaryPayment</returns>
		public SalaryPayment SalaryPaymentInsert(SalaryPayment instance)
		{
            List<SalaryPayment> list = _SalaryPaymentInsert(instance.Payment, instance.Department, instance.Balance).ToList<SalaryPayment>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SalaryPaymentUpdate")]
		private int _SalaryPaymentUpdate([Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@Balance")] Nullable<decimal> _balance)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment, _department, _balance);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[SalaryPayment] table.
		/// </summary>
		/// <param name="instance">An instance of SalaryPayment whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SalaryPaymentUpdate(SalaryPayment instance)
		{
			_SalaryPaymentUpdate(instance.Payment, instance.Department, instance.Balance);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SalaryPaymentDelete")]
		private int _SalaryPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[SalaryPayment] table.
		/// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
		public void SalaryPaymentDelete([Parameter(Name = "@Payment")] int _payment)
		{
			_SalaryPaymentDelete(_payment);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SalaryPaymentGetByDepartment")]
		private ISingleResult<SalaryPayment> _SalaryPaymentGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<SalaryPayment>);
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>A list of SalaryPayment instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryPayment> SalaryPaymentGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			return _SalaryPaymentGetByDepartment(_department).ToList<SalaryPayment>();
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>Gets an instance of SalaryPayment or null.</returns>
		public SalaryPayment SalaryPaymentGetByDepartmentFirstOrNull([Parameter(Name = "@Department")] int _department)
		{
			List<SalaryPayment> list = _SalaryPaymentGetByDepartment(_department).ToList<SalaryPayment>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SalaryPaymentDeleteByDepartment")]
		private int _SalaryPaymentDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Department from the dbo.SalaryPayment table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		public void SalaryPaymentDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			_SalaryPaymentDeleteByDepartment(_department);
		}
		#endregion
        #endregion

		#region SalaryWorkPlace procedures.
		#region List procedure
		[Function(Name = "dbo.SalaryWorkPlaceList")]
		private ISingleResult<SalaryWorkPlace> _SalaryWorkPlaceList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SalaryWorkPlace>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlace table.
		/// </summary>
		/// <returns>A list of SalaryWorkPlace instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlace> SalaryWorkPlaceList()
		{
			return _SalaryWorkPlaceList().ToList<SalaryWorkPlace>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SalaryWorkPlaceGet")]
		private ISingleResult<SalaryWorkPlace> _SalaryWorkPlaceGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlace>);
		}

		/// <summary>
		/// Gets one row from the dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
		public SalaryWorkPlace SalaryWorkPlaceGet([Parameter(Name = "@Id")] int _id)
		{
			List<SalaryWorkPlace> list = _SalaryWorkPlaceGet(_id).ToList<SalaryWorkPlace>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SalaryWorkPlaceInsert")]
		private ISingleResult<SalaryWorkPlace> _SalaryWorkPlaceInsert([Parameter(Name = "@Name")] string _name, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name, _mainWorkPlace);
			return (result.ReturnValue) as ISingleResult<SalaryWorkPlace>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[SalaryWorkPlace] table.
		/// </summary>
		/// <param name="instance">An instance of SalaryWorkPlace to be inserted.</param>
		/// <returns>The inserted SalaryWorkPlace</returns>
		public SalaryWorkPlace SalaryWorkPlaceInsert(SalaryWorkPlace instance)
		{
            List<SalaryWorkPlace> list = _SalaryWorkPlaceInsert(instance.Name, instance.MainWorkPlace).ToList<SalaryWorkPlace>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SalaryWorkPlaceUpdate")]
		private int _SalaryWorkPlaceUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Name")] string _name, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name, _mainWorkPlace);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[SalaryWorkPlace] table.
		/// </summary>
		/// <param name="instance">An instance of SalaryWorkPlace whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SalaryWorkPlaceUpdate(SalaryWorkPlace instance)
		{
			_SalaryWorkPlaceUpdate(instance.Id, instance.Name, instance.MainWorkPlace);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SalaryWorkPlaceDelete")]
		private int _SalaryWorkPlaceDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[SalaryWorkPlace] table.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		public void SalaryWorkPlaceDelete([Parameter(Name = "@Id")] int _id)
		{
			_SalaryWorkPlaceDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SalaryWorkPlaceGetByMainWorkPlace")]
		private ISingleResult<SalaryWorkPlace> _SalaryWorkPlaceGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlace>);
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		/// <returns>A list of SalaryWorkPlace instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlace> SalaryWorkPlaceGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			return _SalaryWorkPlaceGetByMainWorkPlace(_mainWorkPlace).ToList<SalaryWorkPlace>();
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
		public SalaryWorkPlace SalaryWorkPlaceGetByMainWorkPlaceFirstOrNull([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			List<SalaryWorkPlace> list = _SalaryWorkPlaceGetByMainWorkPlace(_mainWorkPlace).ToList<SalaryWorkPlace>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SalaryWorkPlaceGetByName")]
		private ISingleResult<SalaryWorkPlace> _SalaryWorkPlaceGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlace>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		/// <returns>A list of SalaryWorkPlace instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlace> SalaryWorkPlaceGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _SalaryWorkPlaceGetByName(_name).ToList<SalaryWorkPlace>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
		public SalaryWorkPlace SalaryWorkPlaceGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<SalaryWorkPlace> list = _SalaryWorkPlaceGetByName(_name).ToList<SalaryWorkPlace>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SalaryWorkPlaceDeleteByMainWorkPlace")]
		private int _SalaryWorkPlaceDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		public void SalaryWorkPlaceDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			_SalaryWorkPlaceDeleteByMainWorkPlace(_mainWorkPlace);
		}		

        [Function(Name = "dbo.SalaryWorkPlaceDeleteByName")]
		private int _SalaryWorkPlaceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SalaryWorkPlace table.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		public void SalaryWorkPlaceDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_SalaryWorkPlaceDeleteByName(_name);
		}
		#endregion
        #endregion

		#region ServiceEndGrantRequest procedures.
		#region List procedure
		[Function(Name = "dbo.ServiceEndGrantRequestList")]
		private ISingleResult<ServiceEndGrantRequest> _ServiceEndGrantRequestList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ServiceEndGrantRequest>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequest table.
		/// </summary>
		/// <returns>A list of ServiceEndGrantRequest instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ServiceEndGrantRequest> ServiceEndGrantRequestList()
		{
			return _ServiceEndGrantRequestList().ToList<ServiceEndGrantRequest>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ServiceEndGrantRequestGet")]
		private ISingleResult<ServiceEndGrantRequest> _ServiceEndGrantRequestGet([Parameter(Name = "@GrantRequest")] int _grantRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantRequest);
			return (result.ReturnValue as ISingleResult<ServiceEndGrantRequest>);
		}

		/// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequest table.
		/// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
		/// <returns>Gets an instance of ServiceEndGrantRequest or null.</returns>
		public ServiceEndGrantRequest ServiceEndGrantRequestGet([Parameter(Name = "@GrantRequest")] int _grantRequest)
		{
			List<ServiceEndGrantRequest> list = _ServiceEndGrantRequestGet(_grantRequest).ToList<ServiceEndGrantRequest>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.ServiceEndGrantRequestInsert")]
		private ISingleResult<ServiceEndGrantRequest> _ServiceEndGrantRequestInsert([Parameter(Name = "@GrantRequest")] int _grantRequest, [Parameter(Name = "@AverageIncome")] decimal _averageIncome, [Parameter(Name = "@GrantPercentage")] decimal _grantPercentage, [Parameter(Name = "@ServiceInMonthes")] short _serviceInMonthes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantRequest, _averageIncome, _grantPercentage, _serviceInMonthes);
			return (result.ReturnValue) as ISingleResult<ServiceEndGrantRequest>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[ServiceEndGrantRequest] table.
		/// </summary>
		/// <param name="instance">An instance of ServiceEndGrantRequest to be inserted.</param>
		/// <returns>The inserted ServiceEndGrantRequest</returns>
		public ServiceEndGrantRequest ServiceEndGrantRequestInsert(ServiceEndGrantRequest instance)
		{
            List<ServiceEndGrantRequest> list = _ServiceEndGrantRequestInsert(instance.GrantRequest, instance.AverageIncome, instance.GrantPercentage, instance.ServiceInMonthes).ToList<ServiceEndGrantRequest>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.ServiceEndGrantRequestUpdate")]
		private int _ServiceEndGrantRequestUpdate([Parameter(Name = "@GrantRequest")] int _grantRequest, [Parameter(Name = "@AverageIncome")] decimal _averageIncome, [Parameter(Name = "@GrantPercentage")] decimal _grantPercentage, [Parameter(Name = "@ServiceInMonthes")] short _serviceInMonthes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantRequest, _averageIncome, _grantPercentage, _serviceInMonthes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[ServiceEndGrantRequest] table.
		/// </summary>
		/// <param name="instance">An instance of ServiceEndGrantRequest whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void ServiceEndGrantRequestUpdate(ServiceEndGrantRequest instance)
		{
			_ServiceEndGrantRequestUpdate(instance.GrantRequest, instance.AverageIncome, instance.GrantPercentage, instance.ServiceInMonthes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.ServiceEndGrantRequestDelete")]
		private int _ServiceEndGrantRequestDelete([Parameter(Name = "@GrantRequest")] int _grantRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantRequest);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[ServiceEndGrantRequest] table.
		/// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
		public void ServiceEndGrantRequestDelete([Parameter(Name = "@GrantRequest")] int _grantRequest)
		{
			_ServiceEndGrantRequestDelete(_grantRequest);
		}
		#endregion
        #endregion

		#region Settlement procedures.
		#region List procedure
		[Function(Name = "dbo.SettlementList")]
		private ISingleResult<Settlement> _SettlementList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Settlement>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Settlement table.
		/// </summary>
		/// <returns>A list of Settlement instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Settlement> SettlementList()
		{
			return _SettlementList().ToList<Settlement>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SettlementGet")]
		private ISingleResult<Settlement> _SettlementGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Settlement>);
		}

		/// <summary>
		/// Gets one row from the dbo.Settlement table.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		/// <returns>Gets an instance of Settlement or null.</returns>
		public Settlement SettlementGet([Parameter(Name = "@Id")] int _id)
		{
			List<Settlement> list = _SettlementGet(_id).ToList<Settlement>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SettlementInsert")]
		private ISingleResult<Settlement> _SettlementInsert([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Amount")] decimal _amount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment, _payment, _amount);
			return (result.ReturnValue) as ISingleResult<Settlement>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Settlement] table.
		/// </summary>
		/// <param name="instance">An instance of Settlement to be inserted.</param>
		/// <returns>The inserted Settlement</returns>
		public Settlement SettlementInsert(Settlement instance)
		{
            List<Settlement> list = _SettlementInsert(instance.Installment, instance.Payment, instance.Amount).ToList<Settlement>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SettlementUpdate")]
		private int _SettlementUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment, [Parameter(Name = "@Amount")] decimal _amount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _installment, _payment, _amount);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Settlement] table.
		/// </summary>
		/// <param name="instance">An instance of Settlement whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SettlementUpdate(Settlement instance)
		{
			_SettlementUpdate(instance.Id, instance.Installment, instance.Payment, instance.Amount);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SettlementDelete")]
		private int _SettlementDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Settlement] table.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		public void SettlementDelete([Parameter(Name = "@Id")] int _id)
		{
			_SettlementDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SettlementGetByInstallment")]
		private ISingleResult<Settlement> _SettlementGetByInstallment([Parameter(Name = "@Installment")] int _installment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment);
			return (result.ReturnValue as ISingleResult<Settlement>);
		}

		/// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		/// <returns>A list of Settlement instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Settlement> SettlementGetByInstallment([Parameter(Name = "@Installment")] int _installment)
		{
			return _SettlementGetByInstallment(_installment).ToList<Settlement>();
		}

		/// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		/// <returns>Gets an instance of Settlement or null.</returns>
		public Settlement SettlementGetByInstallmentFirstOrNull([Parameter(Name = "@Installment")] int _installment)
		{
			List<Settlement> list = _SettlementGetByInstallment(_installment).ToList<Settlement>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SettlementGetByInstallment_Payment")]
		private ISingleResult<Settlement> _SettlementGetByInstallment_Payment([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment, _payment);
			return (result.ReturnValue as ISingleResult<Settlement>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		/// <returns>A list of Settlement instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Settlement> SettlementGetByInstallment_Payment([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment)
		{
			return _SettlementGetByInstallment_Payment(_installment, _payment).ToList<Settlement>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		/// <returns>Gets an instance of Settlement or null.</returns>
		public Settlement SettlementGetByInstallment_PaymentFirstOrNull([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment)
		{
			List<Settlement> list = _SettlementGetByInstallment_Payment(_installment, _payment).ToList<Settlement>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SettlementGetByPayment")]
		private ISingleResult<Settlement> _SettlementGetByPayment([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return (result.ReturnValue as ISingleResult<Settlement>);
		}

		/// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_payment">الدفعة</param>
		/// <returns>A list of Settlement instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Settlement> SettlementGetByPayment([Parameter(Name = "@Payment")] int _payment)
		{
			return _SettlementGetByPayment(_payment).ToList<Settlement>();
		}

		/// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_payment">الدفعة</param>
		/// <returns>Gets an instance of Settlement or null.</returns>
		public Settlement SettlementGetByPaymentFirstOrNull([Parameter(Name = "@Payment")] int _payment)
		{
			List<Settlement> list = _SettlementGetByPayment(_payment).ToList<Settlement>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SettlementDeleteByInstallment")]
		private int _SettlementDeleteByInstallment([Parameter(Name = "@Installment")] int _installment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Installment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		public void SettlementDeleteByInstallment([Parameter(Name = "@Installment")] int _installment)
		{
			_SettlementDeleteByInstallment(_installment);
		}		

        [Function(Name = "dbo.SettlementDeleteByInstallment_Payment")]
		private int _SettlementDeleteByInstallment_Payment([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installment, _payment);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Installment, Payment columns in the  dbo.Settlement table.
		/// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		public void SettlementDeleteByInstallment_Payment([Parameter(Name = "@Installment")] int _installment, [Parameter(Name = "@Payment")] int _payment)
		{
			_SettlementDeleteByInstallment_Payment(_installment, _payment);
		}		

        [Function(Name = "dbo.SettlementDeleteByPayment")]
		private int _SettlementDeleteByPayment([Parameter(Name = "@Payment")] int _payment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _payment);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Payment from the dbo.Settlement table.
		/// </summary>
		/// <param name="_payment">الدفعة</param>
		public void SettlementDeleteByPayment([Parameter(Name = "@Payment")] int _payment)
		{
			_SettlementDeleteByPayment(_payment);
		}
		#endregion
        #endregion

		#region SpecialCaseLoan procedures.
		#region List procedure
		[Function(Name = "dbo.SpecialCaseLoanList")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <returns>A list of SpecialCaseLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoan> SpecialCaseLoanList()
		{
			return _SpecialCaseLoanList().ToList<SpecialCaseLoan>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SpecialCaseLoanGet")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Gets one row from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		/// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
		public SpecialCaseLoan SpecialCaseLoanGet([Parameter(Name = "@Id")] int _id)
		{
			List<SpecialCaseLoan> list = _SpecialCaseLoanGet(_id).ToList<SpecialCaseLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SpecialCaseLoanInsert")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _date, _loanType, _amount, _notes);
			return (result.ReturnValue) as ISingleResult<SpecialCaseLoan>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[SpecialCaseLoan] table.
		/// </summary>
		/// <param name="instance">An instance of SpecialCaseLoan to be inserted.</param>
		/// <returns>The inserted SpecialCaseLoan</returns>
		public SpecialCaseLoan SpecialCaseLoanInsert(SpecialCaseLoan instance)
		{
            List<SpecialCaseLoan> list = _SpecialCaseLoanInsert(instance.Employee, instance.Date, instance.LoanType, instance.Amount, instance.Notes).ToList<SpecialCaseLoan>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SpecialCaseLoanUpdate")]
		private int _SpecialCaseLoanUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _date, _loanType, _amount, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[SpecialCaseLoan] table.
		/// </summary>
		/// <param name="instance">An instance of SpecialCaseLoan whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SpecialCaseLoanUpdate(SpecialCaseLoan instance)
		{
			_SpecialCaseLoanUpdate(instance.Id, instance.Employee, instance.Date, instance.LoanType, instance.Amount, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SpecialCaseLoanDelete")]
		private int _SpecialCaseLoanDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[SpecialCaseLoan] table.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		public void SpecialCaseLoanDelete([Parameter(Name = "@Id")] int _id)
		{
			_SpecialCaseLoanDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SpecialCaseLoanGetByDate")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		/// <returns>A list of SpecialCaseLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoan> SpecialCaseLoanGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _SpecialCaseLoanGetByDate(_date).ToList<SpecialCaseLoan>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		/// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
		public SpecialCaseLoan SpecialCaseLoanGetByDateFirstOrNull([Parameter(Name = "@Date")] DateTime _date)
		{
			List<SpecialCaseLoan> list = _SpecialCaseLoanGetByDate(_date).ToList<SpecialCaseLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SpecialCaseLoanGetByEmployee")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of SpecialCaseLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoan> SpecialCaseLoanGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _SpecialCaseLoanGetByEmployee(_employee).ToList<SpecialCaseLoan>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
		public SpecialCaseLoan SpecialCaseLoanGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<SpecialCaseLoan> list = _SpecialCaseLoanGetByEmployee(_employee).ToList<SpecialCaseLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SpecialCaseLoanGetByEmployee_Date_LoanType")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanGetByEmployee_Date_LoanType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _date, _loanType);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, Date, LoanType) columns  in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		/// <returns>A list of SpecialCaseLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoan> SpecialCaseLoanGetByEmployee_Date_LoanType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType)
		{
			return _SpecialCaseLoanGetByEmployee_Date_LoanType(_employee, _date, _loanType).ToList<SpecialCaseLoan>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, Date, LoanType) columns  in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		/// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
		public SpecialCaseLoan SpecialCaseLoanGetByEmployee_Date_LoanTypeFirstOrNull([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType)
		{
			List<SpecialCaseLoan> list = _SpecialCaseLoanGetByEmployee_Date_LoanType(_employee, _date, _loanType).ToList<SpecialCaseLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SpecialCaseLoanGetByLoanType")]
		private ISingleResult<SpecialCaseLoan> _SpecialCaseLoanGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoan>);
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_loanType">نوع السلف</param>
		/// <returns>A list of SpecialCaseLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoan> SpecialCaseLoanGetByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			return _SpecialCaseLoanGetByLoanType(_loanType).ToList<SpecialCaseLoan>();
		}

		/// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_loanType">نوع السلف</param>
		/// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
		public SpecialCaseLoan SpecialCaseLoanGetByLoanTypeFirstOrNull([Parameter(Name = "@LoanType")] short _loanType)
		{
			List<SpecialCaseLoan> list = _SpecialCaseLoanGetByLoanType(_loanType).ToList<SpecialCaseLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SpecialCaseLoanDeleteByDate")]
		private int _SpecialCaseLoanDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		public void SpecialCaseLoanDeleteByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			_SpecialCaseLoanDeleteByDate(_date);
		}		

        [Function(Name = "dbo.SpecialCaseLoanDeleteByEmployee")]
		private int _SpecialCaseLoanDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void SpecialCaseLoanDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_SpecialCaseLoanDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.SpecialCaseLoanDeleteByEmployee_Date_LoanType")]
		private int _SpecialCaseLoanDeleteByEmployee_Date_LoanType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _date, _loanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Employee, Date, LoanType columns in the  dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		public void SpecialCaseLoanDeleteByEmployee_Date_LoanType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanType")] short _loanType)
		{
			_SpecialCaseLoanDeleteByEmployee_Date_LoanType(_employee, _date, _loanType);
		}		

        [Function(Name = "dbo.SpecialCaseLoanDeleteByLoanType")]
		private int _SpecialCaseLoanDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one LoanType from the dbo.SpecialCaseLoan table.
		/// </summary>
		/// <param name="_loanType">نوع السلف</param>
		public void SpecialCaseLoanDeleteByLoanType([Parameter(Name = "@LoanType")] short _loanType)
		{
			_SpecialCaseLoanDeleteByLoanType(_loanType);
		}
		#endregion
        #endregion

		#region Subscription procedures.
		#region List procedure
		[Function(Name = "dbo.SubscriptionList")]
		private ISingleResult<Subscription> _SubscriptionList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Subscription table.
		/// </summary>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionList()
		{
			return _SubscriptionList().ToList<Subscription>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SubscriptionGet")]
		private ISingleResult<Subscription> _SubscriptionGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets one row from the dbo.Subscription table.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGet([Parameter(Name = "@Id")] int _id)
		{
			List<Subscription> list = _SubscriptionGet(_id).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SubscriptionInsert")]
		private ISingleResult<Subscription> _SubscriptionInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _month, _department, _subscriptionType, _amount, _notes, _isFixed);
			return (result.ReturnValue) as ISingleResult<Subscription>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Subscription] table.
		/// </summary>
		/// <param name="instance">An instance of Subscription to be inserted.</param>
		/// <returns>The inserted Subscription</returns>
		public Subscription SubscriptionInsert(Subscription instance)
		{
            List<Subscription> list = _SubscriptionInsert(instance.Employee, instance.Month, instance.Department, instance.SubscriptionType, instance.Amount, instance.Notes, instance.IsFixed).ToList<Subscription>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SubscriptionUpdate")]
		private int _SubscriptionUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType, [Parameter(Name = "@Amount")] decimal _amount, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _employee, _month, _department, _subscriptionType, _amount, _notes, _isFixed);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Subscription] table.
		/// </summary>
		/// <param name="instance">An instance of Subscription whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SubscriptionUpdate(Subscription instance)
		{
			_SubscriptionUpdate(instance.Id, instance.Employee, instance.Month, instance.Department, instance.SubscriptionType, instance.Amount, instance.Notes, instance.IsFixed);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SubscriptionDelete")]
		private int _SubscriptionDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Subscription] table.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		public void SubscriptionDelete([Parameter(Name = "@Id")] int _id)
		{
			_SubscriptionDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SubscriptionGetByDepartment")]
		private ISingleResult<Subscription> _SubscriptionGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionGetByDepartment([Parameter(Name = "@Department")] int _department)
		{
			return _SubscriptionGetByDepartment(_department).ToList<Subscription>();
		}

		/// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGetByDepartmentFirstOrNull([Parameter(Name = "@Department")] int _department)
		{
			List<Subscription> list = _SubscriptionGetByDepartment(_department).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SubscriptionGetByEmployee")]
		private ISingleResult<Subscription> _SubscriptionGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _SubscriptionGetByEmployee(_employee).ToList<Subscription>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Subscription> list = _SubscriptionGetByEmployee(_employee).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SubscriptionGetByEmployee_Month_Department_SubscriptionType")]
		private ISingleResult<Subscription> _SubscriptionGetByEmployee_Month_Department_SubscriptionType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _month, _department, _subscriptionType);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, Month, Department, SubscriptionType) columns  in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionGetByEmployee_Month_Department_SubscriptionType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			return _SubscriptionGetByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType).ToList<Subscription>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Employee, Month, Department, SubscriptionType) columns  in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGetByEmployee_Month_Department_SubscriptionTypeFirstOrNull([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			List<Subscription> list = _SubscriptionGetByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SubscriptionGetByIsFixed")]
		private ISingleResult<Subscription> _SubscriptionGetByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionGetByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			return _SubscriptionGetByIsFixed(_isFixed).ToList<Subscription>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGetByIsFixedFirstOrNull([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			List<Subscription> list = _SubscriptionGetByIsFixed(_isFixed).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.SubscriptionGetBySubscriptionType")]
		private ISingleResult<Subscription> _SubscriptionGetBySubscriptionType([Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _subscriptionType);
			return (result.ReturnValue as ISingleResult<Subscription>);
		}

		/// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
		/// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		/// <returns>A list of Subscription instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Subscription> SubscriptionGetBySubscriptionType([Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			return _SubscriptionGetBySubscriptionType(_subscriptionType).ToList<Subscription>();
		}

		/// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
		/// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		/// <returns>Gets an instance of Subscription or null.</returns>
		public Subscription SubscriptionGetBySubscriptionTypeFirstOrNull([Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			List<Subscription> list = _SubscriptionGetBySubscriptionType(_subscriptionType).ToList<Subscription>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SubscriptionDeleteByDepartment")]
		private int _SubscriptionDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Department from the dbo.Subscription table.
		/// </summary>
		/// <param name="_department">الفعالية</param>
		public void SubscriptionDeleteByDepartment([Parameter(Name = "@Department")] int _department)
		{
			_SubscriptionDeleteByDepartment(_department);
		}		

        [Function(Name = "dbo.SubscriptionDeleteByEmployee")]
		private int _SubscriptionDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void SubscriptionDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_SubscriptionDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.SubscriptionDeleteByEmployee_Month_Department_SubscriptionType")]
		private int _SubscriptionDeleteByEmployee_Month_Department_SubscriptionType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _month, _department, _subscriptionType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Employee, Month, Department, SubscriptionType columns in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		public void SubscriptionDeleteByEmployee_Month_Department_SubscriptionType([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@Department")] int _department, [Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			_SubscriptionDeleteByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType);
		}		

        [Function(Name = "dbo.SubscriptionDeleteByIsFixed")]
		private int _SubscriptionDeleteByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.Subscription table.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		public void SubscriptionDeleteByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			_SubscriptionDeleteByIsFixed(_isFixed);
		}		

        [Function(Name = "dbo.SubscriptionDeleteBySubscriptionType")]
		private int _SubscriptionDeleteBySubscriptionType([Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _subscriptionType);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one SubscriptionType from the dbo.Subscription table.
		/// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		public void SubscriptionDeleteBySubscriptionType([Parameter(Name = "@SubscriptionType")] byte _subscriptionType)
		{
			_SubscriptionDeleteBySubscriptionType(_subscriptionType);
		}
		#endregion
        #endregion

		#region SubscriptionType procedures.
		#region List procedure
		[Function(Name = "dbo.SubscriptionTypeList")]
		private ISingleResult<SubscriptionType> _SubscriptionTypeList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SubscriptionType>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SubscriptionType table.
		/// </summary>
		/// <returns>A list of SubscriptionType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionType> SubscriptionTypeList()
		{
			return _SubscriptionTypeList().ToList<SubscriptionType>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SubscriptionTypeGet")]
		private ISingleResult<SubscriptionType> _SubscriptionTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SubscriptionType>);
		}

		/// <summary>
		/// Gets one row from the dbo.SubscriptionType table.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionType or null.</returns>
		public SubscriptionType SubscriptionTypeGet([Parameter(Name = "@Id")] byte _id)
		{
			List<SubscriptionType> list = _SubscriptionTypeGet(_id).ToList<SubscriptionType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.SubscriptionTypeInsert")]
		private ISingleResult<SubscriptionType> _SubscriptionTypeInsert([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return (result.ReturnValue) as ISingleResult<SubscriptionType>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[SubscriptionType] table.
		/// </summary>
		/// <param name="instance">An instance of SubscriptionType to be inserted.</param>
		/// <returns>The inserted SubscriptionType</returns>
		public SubscriptionType SubscriptionTypeInsert(SubscriptionType instance)
		{
            List<SubscriptionType> list = _SubscriptionTypeInsert(instance.Id, instance.Name).ToList<SubscriptionType>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.SubscriptionTypeUpdate")]
		private int _SubscriptionTypeUpdate([Parameter(Name = "@Id")] byte _id, [Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _name);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[SubscriptionType] table.
		/// </summary>
		/// <param name="instance">An instance of SubscriptionType whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void SubscriptionTypeUpdate(SubscriptionType instance)
		{
			_SubscriptionTypeUpdate(instance.Id, instance.Name);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.SubscriptionTypeDelete")]
		private int _SubscriptionTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[SubscriptionType] table.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		public void SubscriptionTypeDelete([Parameter(Name = "@Id")] byte _id)
		{
			_SubscriptionTypeDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SubscriptionTypeGetByName")]
		private ISingleResult<SubscriptionType> _SubscriptionTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<SubscriptionType>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		/// <returns>A list of SubscriptionType instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionType> SubscriptionTypeGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _SubscriptionTypeGetByName(_name).ToList<SubscriptionType>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionType or null.</returns>
		public SubscriptionType SubscriptionTypeGetByNameFirstOrNull([Parameter(Name = "@Name")] string _name)
		{
			List<SubscriptionType> list = _SubscriptionTypeGetByName(_name).ToList<SubscriptionType>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.SubscriptionTypeDeleteByName")]
		private int _SubscriptionTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SubscriptionType table.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		public void SubscriptionTypeDeleteByName([Parameter(Name = "@Name")] string _name)
		{
			_SubscriptionTypeDeleteByName(_name);
		}
		#endregion
        #endregion

		#region TransitoryIncomingLoan procedures.
		#region List procedure
		[Function(Name = "dbo.TransitoryIncomingLoanList")]
		private ISingleResult<TransitoryIncomingLoan> _TransitoryIncomingLoanList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoan>);
		}

		/// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <returns>A list of TransitoryIncomingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoan> TransitoryIncomingLoanList()
		{
			return _TransitoryIncomingLoanList().ToList<TransitoryIncomingLoan>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.TransitoryIncomingLoanGet")]
		private ISingleResult<TransitoryIncomingLoan> _TransitoryIncomingLoanGet([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoan>);
		}

		/// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
		public TransitoryIncomingLoan TransitoryIncomingLoanGet([Parameter(Name = "@Employee")] int _employee)
		{
			List<TransitoryIncomingLoan> list = _TransitoryIncomingLoanGet(_employee).ToList<TransitoryIncomingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.TransitoryIncomingLoanInsert")]
		private ISingleResult<TransitoryIncomingLoan> _TransitoryIncomingLoanInsert([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace, [Parameter(Name = "@ApprovedAmount")] decimal _approvedAmount, [Parameter(Name = "@Installment")] decimal _installment, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _mainWorkPlace, _approvedAmount, _installment, _notes, _isVerified);
			return (result.ReturnValue) as ISingleResult<TransitoryIncomingLoan>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[TransitoryIncomingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of TransitoryIncomingLoan to be inserted.</param>
		/// <returns>The inserted TransitoryIncomingLoan</returns>
		public TransitoryIncomingLoan TransitoryIncomingLoanInsert(TransitoryIncomingLoan instance)
		{
            List<TransitoryIncomingLoan> list = _TransitoryIncomingLoanInsert(instance.Employee, instance.MainWorkPlace, instance.ApprovedAmount, instance.Installment, instance.Notes, instance.IsVerified).ToList<TransitoryIncomingLoan>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.TransitoryIncomingLoanUpdate")]
		private int _TransitoryIncomingLoanUpdate([Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace, [Parameter(Name = "@ApprovedAmount")] decimal _approvedAmount, [Parameter(Name = "@Installment")] decimal _installment, [Parameter(Name = "@Notes")] string _notes, [Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee, _mainWorkPlace, _approvedAmount, _installment, _notes, _isVerified);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[TransitoryIncomingLoan] table.
		/// </summary>
		/// <param name="instance">An instance of TransitoryIncomingLoan whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void TransitoryIncomingLoanUpdate(TransitoryIncomingLoan instance)
		{
			_TransitoryIncomingLoanUpdate(instance.Employee, instance.MainWorkPlace, instance.ApprovedAmount, instance.Installment, instance.Notes, instance.IsVerified);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.TransitoryIncomingLoanDelete")]
		private int _TransitoryIncomingLoanDelete([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[TransitoryIncomingLoan] table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void TransitoryIncomingLoanDelete([Parameter(Name = "@Employee")] int _employee)
		{
			_TransitoryIncomingLoanDelete(_employee);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.TransitoryIncomingLoanGetByIsVerified")]
		private ISingleResult<TransitoryIncomingLoan> _TransitoryIncomingLoanGetByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isVerified);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoan>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		/// <returns>A list of TransitoryIncomingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoan> TransitoryIncomingLoanGetByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			return _TransitoryIncomingLoanGetByIsVerified(_isVerified).ToList<TransitoryIncomingLoan>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		/// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
		public TransitoryIncomingLoan TransitoryIncomingLoanGetByIsVerifiedFirstOrNull([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			List<TransitoryIncomingLoan> list = _TransitoryIncomingLoanGetByIsVerified(_isVerified).ToList<TransitoryIncomingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.TransitoryIncomingLoanGetByMainWorkPlace")]
		private ISingleResult<TransitoryIncomingLoan> _TransitoryIncomingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoan>);
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of TransitoryIncomingLoan instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoan> TransitoryIncomingLoanGetByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			return _TransitoryIncomingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<TransitoryIncomingLoan>();
		}

		/// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		/// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
		public TransitoryIncomingLoan TransitoryIncomingLoanGetByMainWorkPlaceFirstOrNull([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			List<TransitoryIncomingLoan> list = _TransitoryIncomingLoanGetByMainWorkPlace(_mainWorkPlace).ToList<TransitoryIncomingLoan>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.TransitoryIncomingLoanDeleteByIsVerified")]
		private int _TransitoryIncomingLoanDeleteByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isVerified);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		public void TransitoryIncomingLoanDeleteByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			_TransitoryIncomingLoanDeleteByIsVerified(_isVerified);
		}		

        [Function(Name = "dbo.TransitoryIncomingLoanDeleteByMainWorkPlace")]
		private int _TransitoryIncomingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlace);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
		/// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		public void TransitoryIncomingLoanDeleteByMainWorkPlace([Parameter(Name = "@MainWorkPlace")] int _mainWorkPlace)
		{
			_TransitoryIncomingLoanDeleteByMainWorkPlace(_mainWorkPlace);
		}
		#endregion
        #endregion

		#region Warrant procedures.
		#region List procedure
		[Function(Name = "dbo.WarrantList")]
		private ISingleResult<Warrant> _WarrantList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Selects all rows from the dbo.Warrant table.
		/// </summary>
		/// <returns>A list of Warrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Warrant> WarrantList()
		{
			return _WarrantList().ToList<Warrant>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.WarrantGet")]
		private ISingleResult<Warrant> _WarrantGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Gets one row from the dbo.Warrant table.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		/// <returns>Gets an instance of Warrant or null.</returns>
		public Warrant WarrantGet([Parameter(Name = "@Id")] int _id)
		{
			List<Warrant> list = _WarrantGet(_id).ToList<Warrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region Insert procedure
		[Function(Name = "dbo.WarrantInsert")]
		private ISingleResult<Warrant> _WarrantInsert([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@IsActive")] bool _isActive, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debt, _employee, _isActive, _notes);
			return (result.ReturnValue) as ISingleResult<Warrant>;
		}

		/// <summary>
		/// Inserts one row into the [dbo].[Warrant] table.
		/// </summary>
		/// <param name="instance">An instance of Warrant to be inserted.</param>
		/// <returns>The inserted Warrant</returns>
		public Warrant WarrantInsert(Warrant instance)
		{
            List<Warrant> list = _WarrantInsert(instance.Debt, instance.Employee, instance.IsActive, instance.Notes).ToList<Warrant>();
            if (list.Count > 0) return list[0];
            return null;
		}
		#endregion

		#region Update procedure
		[Function(Name = "dbo.WarrantUpdate")]
		private int _WarrantUpdate([Parameter(Name = "@Id")] int _id, [Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee, [Parameter(Name = "@IsActive")] bool _isActive, [Parameter(Name = "@Notes")] string _notes)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id, _debt, _employee, _isActive, _notes);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Updates one row in the [dbo].[Warrant] table.
		/// </summary>
		/// <param name="instance">An instance of Warrant whitch identifies the object to be updated, 
		/// and holds its new values.</param>
		public void WarrantUpdate(Warrant instance)
		{
			_WarrantUpdate(instance.Id, instance.Debt, instance.Employee, instance.IsActive, instance.Notes);
		}
		#endregion

		#region Delete procedure
		[Function(Name = "dbo.WarrantDelete")]
		private int _WarrantDelete([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return ((int)(result.ReturnValue));
		}

		/// <summary>
		/// Deletes one row from the [dbo].[Warrant] table.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		public void WarrantDelete([Parameter(Name = "@Id")] int _id)
		{
			_WarrantDelete(_id);
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.WarrantGetByDebt")]
		private ISingleResult<Warrant> _WarrantGetByDebt([Parameter(Name = "@Debt")] int _debt)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debt);
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <returns>A list of Warrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Warrant> WarrantGetByDebt([Parameter(Name = "@Debt")] int _debt)
		{
			return _WarrantGetByDebt(_debt).ToList<Warrant>();
		}

		/// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <returns>Gets an instance of Warrant or null.</returns>
		public Warrant WarrantGetByDebtFirstOrNull([Parameter(Name = "@Debt")] int _debt)
		{
			List<Warrant> list = _WarrantGetByDebt(_debt).ToList<Warrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.WarrantGetByDebt_Employee")]
		private ISingleResult<Warrant> _WarrantGetByDebt_Employee([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debt, _employee);
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of Warrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Warrant> WarrantGetByDebt_Employee([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee)
		{
			return _WarrantGetByDebt_Employee(_debt, _employee).ToList<Warrant>();
		}

		/// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Warrant or null.</returns>
		public Warrant WarrantGetByDebt_EmployeeFirstOrNull([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee)
		{
			List<Warrant> list = _WarrantGetByDebt_Employee(_debt, _employee).ToList<Warrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.WarrantGetByEmployee")]
		private ISingleResult<Warrant> _WarrantGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>A list of Warrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Warrant> WarrantGetByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			return _WarrantGetByEmployee(_employee).ToList<Warrant>();
		}

		/// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <returns>Gets an instance of Warrant or null.</returns>
		public Warrant WarrantGetByEmployeeFirstOrNull([Parameter(Name = "@Employee")] int _employee)
		{
			List<Warrant> list = _WarrantGetByEmployee(_employee).ToList<Warrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		

		[Function(Name = "dbo.WarrantGetByIsActive")]
		private ISingleResult<Warrant> _WarrantGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<Warrant>);
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		/// <returns>A list of Warrant instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Warrant> WarrantGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _WarrantGetByIsActive(_isActive).ToList<Warrant>();
		}

		/// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		/// <returns>Gets an instance of Warrant or null.</returns>
		public Warrant WarrantGetByIsActiveFirstOrNull([Parameter(Name = "@IsActive")] bool _isActive)
		{
			List<Warrant> list = _WarrantGetByIsActive(_isActive).ToList<Warrant>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Delete by procedures
        [Function(Name = "dbo.WarrantDeleteByDebt")]
		private int _WarrantDeleteByDebt([Parameter(Name = "@Debt")] int _debt)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debt);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Debt from the dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		public void WarrantDeleteByDebt([Parameter(Name = "@Debt")] int _debt)
		{
			_WarrantDeleteByDebt(_debt);
		}		

        [Function(Name = "dbo.WarrantDeleteByDebt_Employee")]
		private int _WarrantDeleteByDebt_Employee([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debt, _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of Debt, Employee columns in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		public void WarrantDeleteByDebt_Employee([Parameter(Name = "@Debt")] int _debt, [Parameter(Name = "@Employee")] int _employee)
		{
			_WarrantDeleteByDebt_Employee(_debt, _employee);
		}		

        [Function(Name = "dbo.WarrantDeleteByEmployee")]
		private int _WarrantDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employee);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one Employee from the dbo.Warrant table.
		/// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		public void WarrantDeleteByEmployee([Parameter(Name = "@Employee")] int _employee)
		{
			_WarrantDeleteByEmployee(_employee);
		}		

        [Function(Name = "dbo.WarrantDeleteByIsActive")]
		private int _WarrantDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (int)(result.ReturnValue);
		}

		/// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Warrant table.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		public void WarrantDeleteByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			_WarrantDeleteByIsActive(_isActive);
		}
		#endregion
        #endregion
	}
	#endregion
}
