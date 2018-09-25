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
        #region AvailabilityCeilingVw procedures.
		#region List procedure
		[Function(Name = "dbo.AvailabilityCeilingVwList")]
		private ISingleResult<AvailabilityCeilingVw> _AvailabilityCeilingVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<AvailabilityCeilingVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeilingVw> AvailabilityCeilingVwList()
		{
			return _AvailabilityCeilingVwList().ToList<AvailabilityCeilingVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.AvailabilityCeilingVwGet")]
		private ISingleResult<AvailabilityCeilingVw> _AvailabilityCeilingVwGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<AvailabilityCeilingVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null.</returns>
		public AvailabilityCeilingVw AvailabilityCeilingVwGet([Parameter(Name = "@Id")] short _id)
		{
			List<AvailabilityCeilingVw> list = _AvailabilityCeilingVwGet(_id).ToList<AvailabilityCeilingVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null.</returns>
		public AvailabilityCeilingVw AvailabilityCeilingVwGetChildren([Parameter(Name = "@Id")] short _id)
		{
            return AvailabilityCeilingVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.AvailabilityCeilingVwGetByAvailabilityId")]
		private ISingleResult<AvailabilityCeilingVw> _AvailabilityCeilingVwGetByAvailabilityId([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availabilityId);
			return (result.ReturnValue as ISingleResult<AvailabilityCeilingVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeilingVw> AvailabilityCeilingVwGetByAvailabilityId([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _AvailabilityCeilingVwGetByAvailabilityId(_availabilityId).ToList<AvailabilityCeilingVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <returns>An instance of AvailabilityCeilingVw.</returns>
		public AvailabilityCeilingVw AvailabilityCeilingVwGetByAvailabilityIdFirstOrDefault([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _AvailabilityCeilingVwGetByAvailabilityId(_availabilityId).ToList<AvailabilityCeilingVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.AvailabilityCeilingVwGetByAvailabilityId_FromYear")]
		private ISingleResult<AvailabilityCeilingVw> _AvailabilityCeilingVwGetByAvailabilityId_FromYear([Parameter(Name = "@AvailabilityId")] short _availabilityId, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availabilityId, _fromYear);
			return (result.ReturnValue as ISingleResult<AvailabilityCeilingVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId_FromYear columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityCeilingVw> AvailabilityCeilingVwGetByAvailabilityId_FromYear([Parameter(Name = "@AvailabilityId")] short _availabilityId, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			return _AvailabilityCeilingVwGetByAvailabilityId_FromYear(_availabilityId, _fromYear).ToList<AvailabilityCeilingVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId_FromYear columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		/// <returns>An instance of AvailabilityCeilingVw.</returns>
		public AvailabilityCeilingVw AvailabilityCeilingVwGetByAvailabilityId_FromYearFirstOrDefault([Parameter(Name = "@AvailabilityId")] short _availabilityId, [Parameter(Name = "@FromYear")] short _fromYear)
		{
			return _AvailabilityCeilingVwGetByAvailabilityId_FromYear(_availabilityId, _fromYear).ToList<AvailabilityCeilingVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region AvailabilityVw procedures.
		#region List procedure
		[Function(Name = "dbo.AvailabilityVwList")]
		private ISingleResult<AvailabilityVw> _AvailabilityVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<AvailabilityVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.AvailabilityVw view.
		/// </summary>
		/// <returns>A list of AvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<AvailabilityVw> AvailabilityVwList()
		{
			return _AvailabilityVwList().ToList<AvailabilityVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.AvailabilityVwGet")]
		private ISingleResult<AvailabilityVw> _AvailabilityVwGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<AvailabilityVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.AvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		/// <returns>Gets an instance of AvailabilityVw or null.</returns>
		public AvailabilityVw AvailabilityVwGet([Parameter(Name = "@Id")] short _id)
		{
			List<AvailabilityVw> list = _AvailabilityVwGet(_id).ToList<AvailabilityVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.AvailabilityVwGetChildren")]
        [ResultType(typeof(AvailabilityVw))]
        [ResultType(typeof(AvailabilityCeilingVw))]
        [ResultType(typeof(ProductTypeAvailabilityVw))]
        private IMultipleResults _AvailabilityVwGetChildren([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.AvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		/// <returns>Gets an instance of AvailabilityVw or null.</returns>
		public AvailabilityVw AvailabilityVwGetChildren([Parameter(Name = "@Id")] short _id)
		{
			IMultipleResults multipleResult = _AvailabilityVwGetChildren(_id);
            AvailabilityVw result = multipleResult.GetResult<AvailabilityVw>().FirstOrDefault<AvailabilityVw>();
            if (result == null) return null;
            result.AvailabilityCeilingVwList = multipleResult.GetResult<AvailabilityCeilingVw>().ToList<AvailabilityCeilingVw>();
            result.ProductTypeAvailabilityVwList = multipleResult.GetResult<ProductTypeAvailabilityVw>().ToList<ProductTypeAvailabilityVw>();
            return result;
        }
        #endregion
		#endregion

        #region BypassStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.BypassStatusVwList")]
		private ISingleResult<BypassStatusVw> _BypassStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<BypassStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.BypassStatusVw view.
		/// </summary>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<BypassStatusVw> BypassStatusVwList()
		{
			return _BypassStatusVwList().ToList<BypassStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.BypassStatusVwGet")]
		private ISingleResult<BypassStatusVw> _BypassStatusVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<BypassStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		/// <returns>Gets an instance of BypassStatusVw or null.</returns>
		public BypassStatusVw BypassStatusVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<BypassStatusVw> list = _BypassStatusVwGet(_id).ToList<BypassStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.BypassStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		/// <returns>Gets an instance of BypassStatusVw or null.</returns>
		public BypassStatusVw BypassStatusVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return BypassStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.BypassStatusVwGetByName")]
		private ISingleResult<BypassStatusVw> _BypassStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<BypassStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<BypassStatusVw> BypassStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _BypassStatusVwGetByName(_name).ToList<BypassStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		/// <returns>An instance of BypassStatusVw.</returns>
		public BypassStatusVw BypassStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _BypassStatusVwGetByName(_name).ToList<BypassStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region CashPaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.CashPaymentVwList")]
		private ISingleResult<CashPaymentVw> _CashPaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<CashPaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.CashPaymentVw view.
		/// </summary>
		/// <returns>A list of CashPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CashPaymentVw> CashPaymentVwList()
		{
			return _CashPaymentVwList().ToList<CashPaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CashPaymentVwGet")]
		private ISingleResult<CashPaymentVw> _CashPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentId);
			return (result.ReturnValue as ISingleResult<CashPaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.CashPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of CashPaymentVw or null.</returns>
		public CashPaymentVw CashPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			List<CashPaymentVw> list = _CashPaymentVwGet(_paymentId).ToList<CashPaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.CashPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of CashPaymentVw or null.</returns>
		public CashPaymentVw CashPaymentVwGetChildren([Parameter(Name = "@PaymentId")] int _paymentId)
		{
            return CashPaymentVwGet(_paymentId);
        }
        #endregion
		#endregion

        #region CategoryVw procedures.
		#region List procedure
		[Function(Name = "dbo.CategoryVwList")]
		private ISingleResult<CategoryVw> _CategoryVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<CategoryVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.CategoryVw view.
		/// </summary>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CategoryVw> CategoryVwList()
		{
			return _CategoryVwList().ToList<CategoryVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CategoryVwGet")]
		private ISingleResult<CategoryVw> _CategoryVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<CategoryVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.CategoryVw view.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		/// <returns>Gets an instance of CategoryVw or null.</returns>
		public CategoryVw CategoryVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<CategoryVw> list = _CategoryVwGet(_id).ToList<CategoryVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.CategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		/// <returns>Gets an instance of CategoryVw or null.</returns>
		public CategoryVw CategoryVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return CategoryVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.CategoryVwGetByName")]
		private ISingleResult<CategoryVw> _CategoryVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<CategoryVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CategoryVw> CategoryVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _CategoryVwGetByName(_name).ToList<CategoryVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		/// <returns>An instance of CategoryVw.</returns>
		public CategoryVw CategoryVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _CategoryVwGetByName(_name).ToList<CategoryVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region CollectOrderVw procedures.
		#region List procedure
		[Function(Name = "dbo.CollectOrderVwList")]
		private ISingleResult<CollectOrderVw> _CollectOrderVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<CollectOrderVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.CollectOrderVw view.
		/// </summary>
		/// <returns>A list of CollectOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<CollectOrderVw> CollectOrderVwList()
		{
			return _CollectOrderVwList().ToList<CollectOrderVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.CollectOrderVwGet")]
		private ISingleResult<CollectOrderVw> _CollectOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<CollectOrderVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.CollectOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		/// <returns>Gets an instance of CollectOrderVw or null.</returns>
		public CollectOrderVw CollectOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<CollectOrderVw> list = _CollectOrderVwGet(_id).ToList<CollectOrderVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.CollectOrderVwGetChildren")]
        [ResultType(typeof(CollectOrderVw))]
        [ResultType(typeof(PaymentVw))]
        private IMultipleResults _CollectOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.CollectOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		/// <returns>Gets an instance of CollectOrderVw or null.</returns>
		public CollectOrderVw CollectOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _CollectOrderVwGetChildren(_id);
            CollectOrderVw result = multipleResult.GetResult<CollectOrderVw>().FirstOrDefault<CollectOrderVw>();
            if (result == null) return null;
            result.PaymentVwList = multipleResult.GetResult<PaymentVw>().ToList<PaymentVw>();
            return result;
        }
        #endregion
		#endregion

        #region DebtVw procedures.
		#region List procedure
		[Function(Name = "dbo.DebtVwList")]
		private ISingleResult<DebtVw> _DebtVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.DebtVw view.
		/// </summary>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DebtVw> DebtVwList()
		{
			return _DebtVwList().ToList<DebtVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DebtVwGet")]
		private ISingleResult<DebtVw> _DebtVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.DebtVw view.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		/// <returns>Gets an instance of DebtVw or null.</returns>
		public DebtVw DebtVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<DebtVw> list = _DebtVwGet(_id).ToList<DebtVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.DebtVwGetChildren")]
        [ResultType(typeof(DebtVw))]
        [ResultType(typeof(WarrantVw))]
        private IMultipleResults _DebtVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.DebtVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		/// <returns>Gets an instance of DebtVw or null.</returns>
		public DebtVw DebtVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _DebtVwGetChildren(_id);
            DebtVw result = multipleResult.GetResult<DebtVw>().FirstOrDefault<DebtVw>();
            if (result == null) return null;
            result.WarrantVwList = multipleResult.GetResult<WarrantVw>().ToList<WarrantVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DebtVwGetByDate")]
		private ISingleResult<DebtVw> _DebtVwGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DebtVw> DebtVwGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _DebtVwGetByDate(_date).ToList<DebtVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		/// <returns>An instance of DebtVw.</returns>
		public DebtVw DebtVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _DebtVwGetByDate(_date).ToList<DebtVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.DebtVwGetByEmployeeId")]
		private ISingleResult<DebtVw> _DebtVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DebtVw> DebtVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _DebtVwGetByEmployeeId(_employeeId).ToList<DebtVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>An instance of DebtVw.</returns>
		public DebtVw DebtVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _DebtVwGetByEmployeeId(_employeeId).ToList<DebtVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.DebtVwGetByIsActive")]
		private ISingleResult<DebtVw> _DebtVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DebtVw> DebtVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _DebtVwGetByIsActive(_isActive).ToList<DebtVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		/// <returns>An instance of DebtVw.</returns>
		public DebtVw DebtVwGetByIsActiveFirstOrDefault([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _DebtVwGetByIsActive(_isActive).ToList<DebtVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.DebtVwGetByIssuerId")]
		private ISingleResult<DebtVw> _DebtVwGetByIssuerId([Parameter(Name = "@IssuerId")] byte _issuerId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _issuerId);
			return (result.ReturnValue as ISingleResult<DebtVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DebtVw> DebtVwGetByIssuerId([Parameter(Name = "@IssuerId")] byte _issuerId)
		{
			return _DebtVwGetByIssuerId(_issuerId).ToList<DebtVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		/// <returns>An instance of DebtVw.</returns>
		public DebtVw DebtVwGetByIssuerIdFirstOrDefault([Parameter(Name = "@IssuerId")] byte _issuerId)
		{
			return _DebtVwGetByIssuerId(_issuerId).ToList<DebtVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region DepartmentVw procedures.
		#region List procedure
		[Function(Name = "dbo.DepartmentVwList")]
		private ISingleResult<DepartmentVw> _DepartmentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<DepartmentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.DepartmentVw view.
		/// </summary>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DepartmentVw> DepartmentVwList()
		{
			return _DepartmentVwList().ToList<DepartmentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DepartmentVwGet")]
		private ISingleResult<DepartmentVw> _DepartmentVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<DepartmentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		/// <returns>Gets an instance of DepartmentVw or null.</returns>
		public DepartmentVw DepartmentVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<DepartmentVw> list = _DepartmentVwGet(_id).ToList<DepartmentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.DepartmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		/// <returns>Gets an instance of DepartmentVw or null.</returns>
		public DepartmentVw DepartmentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return DepartmentVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DepartmentVwGetByName")]
		private ISingleResult<DepartmentVw> _DepartmentVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<DepartmentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DepartmentVw> DepartmentVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _DepartmentVwGetByName(_name).ToList<DepartmentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		/// <returns>An instance of DepartmentVw.</returns>
		public DepartmentVw DepartmentVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _DepartmentVwGetByName(_name).ToList<DepartmentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.DepartmentVwGetBySalaryWorkPlaceId")]
		private ISingleResult<DepartmentVw> _DepartmentVwGetBySalaryWorkPlaceId([Parameter(Name = "@SalaryWorkPlaceId")] int _salaryWorkPlaceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _salaryWorkPlaceId);
			return (result.ReturnValue as ISingleResult<DepartmentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DepartmentVw> DepartmentVwGetBySalaryWorkPlaceId([Parameter(Name = "@SalaryWorkPlaceId")] int _salaryWorkPlaceId)
		{
			return _DepartmentVwGetBySalaryWorkPlaceId(_salaryWorkPlaceId).ToList<DepartmentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		/// <returns>An instance of DepartmentVw.</returns>
		public DepartmentVw DepartmentVwGetBySalaryWorkPlaceIdFirstOrDefault([Parameter(Name = "@SalaryWorkPlaceId")] int _salaryWorkPlaceId)
		{
			return _DepartmentVwGetBySalaryWorkPlaceId(_salaryWorkPlaceId).ToList<DepartmentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region DownPaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.DownPaymentVwList")]
		private ISingleResult<DownPaymentVw> _DownPaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<DownPaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.DownPaymentVw view.
		/// </summary>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DownPaymentVw> DownPaymentVwList()
		{
			return _DownPaymentVwList().ToList<DownPaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.DownPaymentVwGet")]
		private ISingleResult<DownPaymentVw> _DownPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentId);
			return (result.ReturnValue as ISingleResult<DownPaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of DownPaymentVw or null.</returns>
		public DownPaymentVw DownPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			List<DownPaymentVw> list = _DownPaymentVwGet(_paymentId).ToList<DownPaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.DownPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of DownPaymentVw or null.</returns>
		public DownPaymentVw DownPaymentVwGetChildren([Parameter(Name = "@PaymentId")] int _paymentId)
		{
            return DownPaymentVwGet(_paymentId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.DownPaymentVwGetByRequestProductId")]
		private ISingleResult<DownPaymentVw> _DownPaymentVwGetByRequestProductId([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as ISingleResult<DownPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<DownPaymentVw> DownPaymentVwGetByRequestProductId([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			return _DownPaymentVwGetByRequestProductId(_requestProductId).ToList<DownPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		/// <returns>An instance of DownPaymentVw.</returns>
		public DownPaymentVw DownPaymentVwGetByRequestProductIdFirstOrDefault([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			return _DownPaymentVwGetByRequestProductId(_requestProductId).ToList<DownPaymentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EmployeeDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeDetailVwList")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeDetailVw view.
		/// </summary>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeDetailVw> EmployeeDetailVwList()
		{
			return _EmployeeDetailVwList().ToList<EmployeeDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeDetailVwGet")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeDetailVw or null.</returns>
		public EmployeeDetailVw EmployeeDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<EmployeeDetailVw> list = _EmployeeDetailVwGet(_id).ToList<EmployeeDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EmployeeDetailVwGetByCategoryId")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwGetByCategoryId([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _categoryId);
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeDetailVw> EmployeeDetailVwGetByCategoryId([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			return _EmployeeDetailVwGetByCategoryId(_categoryId).ToList<EmployeeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>An instance of EmployeeDetailVw.</returns>
		public EmployeeDetailVw EmployeeDetailVwGetByCategoryIdFirstOrDefault([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			return _EmployeeDetailVwGetByCategoryId(_categoryId).ToList<EmployeeDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeDetailVwGetByDepartmentId")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _departmentId);
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeDetailVw> EmployeeDetailVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _EmployeeDetailVwGetByDepartmentId(_departmentId).ToList<EmployeeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>An instance of EmployeeDetailVw.</returns>
		public EmployeeDetailVw EmployeeDetailVwGetByDepartmentIdFirstOrDefault([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _EmployeeDetailVwGetByDepartmentId(_departmentId).ToList<EmployeeDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeDetailVwGetByEmployeeStatusId")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwGetByEmployeeStatusId([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeStatusId);
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeDetailVw> EmployeeDetailVwGetByEmployeeStatusId([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			return _EmployeeDetailVwGetByEmployeeStatusId(_employeeStatusId).ToList<EmployeeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>An instance of EmployeeDetailVw.</returns>
		public EmployeeDetailVw EmployeeDetailVwGetByEmployeeStatusIdFirstOrDefault([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			return _EmployeeDetailVwGetByEmployeeStatusId(_employeeStatusId).ToList<EmployeeDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeDetailVwGetByFirstName_LastName")]
		private ISingleResult<EmployeeDetailVw> _EmployeeDetailVwGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstName, _lastName);
			return (result.ReturnValue as ISingleResult<EmployeeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeDetailVw> EmployeeDetailVwGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			return _EmployeeDetailVwGetByFirstName_LastName(_firstName, _lastName).ToList<EmployeeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>An instance of EmployeeDetailVw.</returns>
		public EmployeeDetailVw EmployeeDetailVwGetByFirstName_LastNameFirstOrDefault([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			return _EmployeeDetailVwGetByFirstName_LastName(_firstName, _lastName).ToList<EmployeeDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EmployeeRefundableProductRollupVw procedures.
		#endregion
        #region EmployeeSeniorityVw procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeSeniorityVwList")]
		private ISingleResult<EmployeeSeniorityVw> _EmployeeSeniorityVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeSeniorityVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <returns>A list of EmployeeSeniorityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeSeniorityVw> EmployeeSeniorityVwList()
		{
			return _EmployeeSeniorityVwList().ToList<EmployeeSeniorityVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeSeniorityVwGet")]
		private ISingleResult<EmployeeSeniorityVw> _EmployeeSeniorityVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<EmployeeSeniorityVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null.</returns>
		public EmployeeSeniorityVw EmployeeSeniorityVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			List<EmployeeSeniorityVw> list = _EmployeeSeniorityVwGet(_employeeId).ToList<EmployeeSeniorityVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null.</returns>
		public EmployeeSeniorityVw EmployeeSeniorityVwGetChildren([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
            return EmployeeSeniorityVwGet(_employeeId);
        }
        #endregion
		#endregion

        #region EmployeeStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeStatusVwList")]
		private ISingleResult<EmployeeStatusVw> _EmployeeStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeStatusVw view.
		/// </summary>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatusVw> EmployeeStatusVwList()
		{
			return _EmployeeStatusVwList().ToList<EmployeeStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeStatusVwGet")]
		private ISingleResult<EmployeeStatusVw> _EmployeeStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EmployeeStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null.</returns>
		public EmployeeStatusVw EmployeeStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<EmployeeStatusVw> list = _EmployeeStatusVwGet(_id).ToList<EmployeeStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null.</returns>
		public EmployeeStatusVw EmployeeStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return EmployeeStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EmployeeStatusVwGetByIsActive")]
		private ISingleResult<EmployeeStatusVw> _EmployeeStatusVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<EmployeeStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatusVw> EmployeeStatusVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _EmployeeStatusVwGetByIsActive(_isActive).ToList<EmployeeStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		/// <returns>An instance of EmployeeStatusVw.</returns>
		public EmployeeStatusVw EmployeeStatusVwGetByIsActiveFirstOrDefault([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _EmployeeStatusVwGetByIsActive(_isActive).ToList<EmployeeStatusVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeStatusVwGetByName")]
		private ISingleResult<EmployeeStatusVw> _EmployeeStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EmployeeStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeStatusVw> EmployeeStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EmployeeStatusVwGetByName(_name).ToList<EmployeeStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		/// <returns>An instance of EmployeeStatusVw.</returns>
		public EmployeeStatusVw EmployeeStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _EmployeeStatusVwGetByName(_name).ToList<EmployeeStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EmployeeVw procedures.
		#region List procedure
		[Function(Name = "dbo.EmployeeVwList")]
		private ISingleResult<EmployeeVw> _EmployeeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EmployeeVw view.
		/// </summary>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeVw> EmployeeVwList()
		{
			return _EmployeeVwList().ToList<EmployeeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EmployeeVwGet")]
		private ISingleResult<EmployeeVw> _EmployeeVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeVw or null.</returns>
		public EmployeeVw EmployeeVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<EmployeeVw> list = _EmployeeVwGet(_id).ToList<EmployeeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.EmployeeVwGetChildren")]
        [ResultType(typeof(EmployeeVw))]
        [ResultType(typeof(DebtVw))]
        [ResultType(typeof(GuarantorVw))]
        [ResultType(typeof(MonthlyBalanceVw))]
        [ResultType(typeof(PaymentVw))]
        [ResultType(typeof(PayOrderVw))]
        [ResultType(typeof(ProductVw))]
        [ResultType(typeof(ProfileVw))]
        [ResultType(typeof(SubscriptionVw))]
        private IMultipleResults _EmployeeVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.EmployeeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeVw or null.</returns>
		public EmployeeVw EmployeeVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _EmployeeVwGetChildren(_id);
            EmployeeVw result = multipleResult.GetResult<EmployeeVw>().FirstOrDefault<EmployeeVw>();
            if (result == null) return null;
            result.DebtVwList = multipleResult.GetResult<DebtVw>().ToList<DebtVw>();
            result.GuarantorVwList = multipleResult.GetResult<GuarantorVw>().ToList<GuarantorVw>();
            result.MonthlyBalanceVwList = multipleResult.GetResult<MonthlyBalanceVw>().ToList<MonthlyBalanceVw>();
            result.PaymentVwList = multipleResult.GetResult<PaymentVw>().ToList<PaymentVw>();
            result.PayOrderVwList = multipleResult.GetResult<PayOrderVw>().ToList<PayOrderVw>();
            result.ProductVwList = multipleResult.GetResult<ProductVw>().ToList<ProductVw>();
            result.ProfileVw = multipleResult.GetResult<ProfileVw>().FirstOrDefault<ProfileVw>();
            result.SubscriptionVwList = multipleResult.GetResult<SubscriptionVw>().ToList<SubscriptionVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EmployeeVwGetByCategoryId")]
		private ISingleResult<EmployeeVw> _EmployeeVwGetByCategoryId([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _categoryId);
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeVw> EmployeeVwGetByCategoryId([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			return _EmployeeVwGetByCategoryId(_categoryId).ToList<EmployeeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>An instance of EmployeeVw.</returns>
		public EmployeeVw EmployeeVwGetByCategoryIdFirstOrDefault([Parameter(Name = "@CategoryId")] byte _categoryId)
		{
			return _EmployeeVwGetByCategoryId(_categoryId).ToList<EmployeeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeVwGetByDepartmentId")]
		private ISingleResult<EmployeeVw> _EmployeeVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _departmentId);
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeVw> EmployeeVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _EmployeeVwGetByDepartmentId(_departmentId).ToList<EmployeeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>An instance of EmployeeVw.</returns>
		public EmployeeVw EmployeeVwGetByDepartmentIdFirstOrDefault([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _EmployeeVwGetByDepartmentId(_departmentId).ToList<EmployeeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeVwGetByEmployeeStatusId")]
		private ISingleResult<EmployeeVw> _EmployeeVwGetByEmployeeStatusId([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeStatusId);
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeVw> EmployeeVwGetByEmployeeStatusId([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			return _EmployeeVwGetByEmployeeStatusId(_employeeStatusId).ToList<EmployeeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>An instance of EmployeeVw.</returns>
		public EmployeeVw EmployeeVwGetByEmployeeStatusIdFirstOrDefault([Parameter(Name = "@EmployeeStatusId")] byte _employeeStatusId)
		{
			return _EmployeeVwGetByEmployeeStatusId(_employeeStatusId).ToList<EmployeeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EmployeeVwGetByFirstName_LastName")]
		private ISingleResult<EmployeeVw> _EmployeeVwGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _firstName, _lastName);
			return (result.ReturnValue as ISingleResult<EmployeeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EmployeeVw> EmployeeVwGetByFirstName_LastName([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			return _EmployeeVwGetByFirstName_LastName(_firstName, _lastName).ToList<EmployeeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>An instance of EmployeeVw.</returns>
		public EmployeeVw EmployeeVwGetByFirstName_LastNameFirstOrDefault([Parameter(Name = "@FirstName")] string _firstName, [Parameter(Name = "@LastName")] string _lastName)
		{
			return _EmployeeVwGetByFirstName_LastName(_firstName, _lastName).ToList<EmployeeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EndWorkGrantBracketVw procedures.
		#region List procedure
		[Function(Name = "dbo.EndWorkGrantBracketVwList")]
		private ISingleResult<EndWorkGrantBracketVw> _EndWorkGrantBracketVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EndWorkGrantBracketVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		/// <returns>A list of EndWorkGrantBracketVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EndWorkGrantBracketVw> EndWorkGrantBracketVwList()
		{
			return _EndWorkGrantBracketVwList().ToList<EndWorkGrantBracketVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EndWorkGrantBracketVwGet")]
		private ISingleResult<EndWorkGrantBracketVw> _EndWorkGrantBracketVwGet([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromYear);
			return (result.ReturnValue as ISingleResult<EndWorkGrantBracketVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null.</returns>
		public EndWorkGrantBracketVw EndWorkGrantBracketVwGet([Parameter(Name = "@FromYear")] byte _fromYear)
		{
			List<EndWorkGrantBracketVw> list = _EndWorkGrantBracketVwGet(_fromYear).ToList<EndWorkGrantBracketVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view with related objects from children.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null.</returns>
		public EndWorkGrantBracketVw EndWorkGrantBracketVwGetChildren([Parameter(Name = "@FromYear")] byte _fromYear)
		{
            return EndWorkGrantBracketVwGet(_fromYear);
        }
        #endregion
		#endregion

        #region ErrorDefinitionVw procedures.
		#region List procedure
		[Function(Name = "dbo.ErrorDefinitionVwList")]
		private ISingleResult<ErrorDefinitionVw> _ErrorDefinitionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ErrorDefinitionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ErrorDefinitionVw> ErrorDefinitionVwList()
		{
			return _ErrorDefinitionVwList().ToList<ErrorDefinitionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ErrorDefinitionVwGet")]
		private ISingleResult<ErrorDefinitionVw> _ErrorDefinitionVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ErrorDefinitionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null.</returns>
		public ErrorDefinitionVw ErrorDefinitionVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ErrorDefinitionVw> list = _ErrorDefinitionVwGet(_id).ToList<ErrorDefinitionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null.</returns>
		public ErrorDefinitionVw ErrorDefinitionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return ErrorDefinitionVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ErrorDefinitionVwGetByLikeExpression")]
		private ISingleResult<ErrorDefinitionVw> _ErrorDefinitionVwGetByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _likeExpression);
			return (result.ReturnValue as ISingleResult<ErrorDefinitionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ErrorDefinitionVw> ErrorDefinitionVwGetByLikeExpression([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			return _ErrorDefinitionVwGetByLikeExpression(_likeExpression).ToList<ErrorDefinitionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		/// <returns>An instance of ErrorDefinitionVw.</returns>
		public ErrorDefinitionVw ErrorDefinitionVwGetByLikeExpressionFirstOrDefault([Parameter(Name = "@LikeExpression")] string _likeExpression)
		{
			return _ErrorDefinitionVwGetByLikeExpression(_likeExpression).ToList<ErrorDefinitionVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EventCategoryVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventCategoryVwList")]
		private ISingleResult<EventCategoryVw> _EventCategoryVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventCategoryVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventCategoryVw view.
		/// </summary>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventCategoryVw> EventCategoryVwList()
		{
			return _EventCategoryVwList().ToList<EventCategoryVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventCategoryVwGet")]
		private ISingleResult<EventCategoryVw> _EventCategoryVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventCategoryVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		/// <returns>Gets an instance of EventCategoryVw or null.</returns>
		public EventCategoryVw EventCategoryVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventCategoryVw> list = _EventCategoryVwGet(_id).ToList<EventCategoryVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EventCategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		/// <returns>Gets an instance of EventCategoryVw or null.</returns>
		public EventCategoryVw EventCategoryVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return EventCategoryVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventCategoryVwGetByName")]
		private ISingleResult<EventCategoryVw> _EventCategoryVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventCategoryVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventCategoryVw> EventCategoryVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventCategoryVwGetByName(_name).ToList<EventCategoryVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		/// <returns>An instance of EventCategoryVw.</returns>
		public EventCategoryVw EventCategoryVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _EventCategoryVwGetByName(_name).ToList<EventCategoryVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EventLogDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventLogDetailVwList")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventLogDetailVw view.
		/// </summary>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwList()
		{
			return _EventLogDetailVwList().ToList<EventLogDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventLogDetailVwGet")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGet([Parameter(Name = "@Id")] long _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogDetailVw or null.</returns>
		public EventLogDetailVw EventLogDetailVwGet([Parameter(Name = "@Id")] long _id)
		{
			List<EventLogDetailVw> list = _EventLogDetailVwGet(_id).ToList<EventLogDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventLogDetailVwGetByDate")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _EventLogDetailVwGetByDate(_date).ToList<EventLogDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>An instance of EventLogDetailVw.</returns>
		public EventLogDetailVw EventLogDetailVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _EventLogDetailVwGetByDate(_date).ToList<EventLogDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogDetailVwGetByEventCategoryId")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGetByEventCategoryId([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventCategoryId);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwGetByEventCategoryId([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			return _EventLogDetailVwGetByEventCategoryId(_eventCategoryId).ToList<EventLogDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>An instance of EventLogDetailVw.</returns>
		public EventLogDetailVw EventLogDetailVwGetByEventCategoryIdFirstOrDefault([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			return _EventLogDetailVwGetByEventCategoryId(_eventCategoryId).ToList<EventLogDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogDetailVwGetByEventSourceId")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGetByEventSourceId([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventSourceId);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwGetByEventSourceId([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			return _EventLogDetailVwGetByEventSourceId(_eventSourceId).ToList<EventLogDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>An instance of EventLogDetailVw.</returns>
		public EventLogDetailVw EventLogDetailVwGetByEventSourceIdFirstOrDefault([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			return _EventLogDetailVwGetByEventSourceId(_eventSourceId).ToList<EventLogDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogDetailVwGetByEventStatusId")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGetByEventStatusId([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventStatusId);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwGetByEventStatusId([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			return _EventLogDetailVwGetByEventStatusId(_eventStatusId).ToList<EventLogDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>An instance of EventLogDetailVw.</returns>
		public EventLogDetailVw EventLogDetailVwGetByEventStatusIdFirstOrDefault([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			return _EventLogDetailVwGetByEventStatusId(_eventStatusId).ToList<EventLogDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogDetailVwGetByUser")]
		private ISingleResult<EventLogDetailVw> _EventLogDetailVwGetByUser([Parameter(Name = "@User")] int _user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _user);
			return (result.ReturnValue as ISingleResult<EventLogDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogDetailVw> EventLogDetailVwGetByUser([Parameter(Name = "@User")] int _user)
		{
			return _EventLogDetailVwGetByUser(_user).ToList<EventLogDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>An instance of EventLogDetailVw.</returns>
		public EventLogDetailVw EventLogDetailVwGetByUserFirstOrDefault([Parameter(Name = "@User")] int _user)
		{
			return _EventLogDetailVwGetByUser(_user).ToList<EventLogDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EventLogErrorVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventLogErrorVwList")]
		private ISingleResult<EventLogErrorVw> _EventLogErrorVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventLogErrorVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventLogErrorVw view.
		/// </summary>
		/// <returns>A list of EventLogErrorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogErrorVw> EventLogErrorVwList()
		{
			return _EventLogErrorVwList().ToList<EventLogErrorVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventLogErrorVwGet")]
		private ISingleResult<EventLogErrorVw> _EventLogErrorVwGet([Parameter(Name = "@EventLogId")] long _eventLogId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventLogId);
			return (result.ReturnValue as ISingleResult<EventLogErrorVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogErrorVw or null.</returns>
		public EventLogErrorVw EventLogErrorVwGet([Parameter(Name = "@EventLogId")] long _eventLogId)
		{
			List<EventLogErrorVw> list = _EventLogErrorVwGet(_eventLogId).ToList<EventLogErrorVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view with related objects from children.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogErrorVw or null.</returns>
		public EventLogErrorVw EventLogErrorVwGetChildren([Parameter(Name = "@EventLogId")] long _eventLogId)
		{
            return EventLogErrorVwGet(_eventLogId);
        }
        #endregion
		#endregion

        #region EventLogVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventLogVwList")]
		private ISingleResult<EventLogVw> _EventLogVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventLogVw view.
		/// </summary>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwList()
		{
			return _EventLogVwList().ToList<EventLogVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventLogVwGet")]
		private ISingleResult<EventLogVw> _EventLogVwGet([Parameter(Name = "@Id")] long _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventLogVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogVw or null.</returns>
		public EventLogVw EventLogVwGet([Parameter(Name = "@Id")] long _id)
		{
			List<EventLogVw> list = _EventLogVwGet(_id).ToList<EventLogVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogVw or null.</returns>
		public EventLogVw EventLogVwGetChildren([Parameter(Name = "@Id")] long _id)
		{
            return EventLogVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventLogVwGetByDate")]
		private ISingleResult<EventLogVw> _EventLogVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _EventLogVwGetByDate(_date).ToList<EventLogVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>An instance of EventLogVw.</returns>
		public EventLogVw EventLogVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _EventLogVwGetByDate(_date).ToList<EventLogVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogVwGetByEventCategoryId")]
		private ISingleResult<EventLogVw> _EventLogVwGetByEventCategoryId([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventCategoryId);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwGetByEventCategoryId([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			return _EventLogVwGetByEventCategoryId(_eventCategoryId).ToList<EventLogVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>An instance of EventLogVw.</returns>
		public EventLogVw EventLogVwGetByEventCategoryIdFirstOrDefault([Parameter(Name = "@EventCategoryId")] int _eventCategoryId)
		{
			return _EventLogVwGetByEventCategoryId(_eventCategoryId).ToList<EventLogVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogVwGetByEventSourceId")]
		private ISingleResult<EventLogVw> _EventLogVwGetByEventSourceId([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventSourceId);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwGetByEventSourceId([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			return _EventLogVwGetByEventSourceId(_eventSourceId).ToList<EventLogVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>An instance of EventLogVw.</returns>
		public EventLogVw EventLogVwGetByEventSourceIdFirstOrDefault([Parameter(Name = "@EventSourceId")] int _eventSourceId)
		{
			return _EventLogVwGetByEventSourceId(_eventSourceId).ToList<EventLogVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogVwGetByEventStatusId")]
		private ISingleResult<EventLogVw> _EventLogVwGetByEventStatusId([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _eventStatusId);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwGetByEventStatusId([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			return _EventLogVwGetByEventStatusId(_eventStatusId).ToList<EventLogVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>An instance of EventLogVw.</returns>
		public EventLogVw EventLogVwGetByEventStatusIdFirstOrDefault([Parameter(Name = "@EventStatusId")] int _eventStatusId)
		{
			return _EventLogVwGetByEventStatusId(_eventStatusId).ToList<EventLogVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.EventLogVwGetByUser")]
		private ISingleResult<EventLogVw> _EventLogVwGetByUser([Parameter(Name = "@User")] int _user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _user);
			return (result.ReturnValue as ISingleResult<EventLogVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventLogVw> EventLogVwGetByUser([Parameter(Name = "@User")] int _user)
		{
			return _EventLogVwGetByUser(_user).ToList<EventLogVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>An instance of EventLogVw.</returns>
		public EventLogVw EventLogVwGetByUserFirstOrDefault([Parameter(Name = "@User")] int _user)
		{
			return _EventLogVwGetByUser(_user).ToList<EventLogVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EventSourceVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventSourceVwList")]
		private ISingleResult<EventSourceVw> _EventSourceVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventSourceVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventSourceVw view.
		/// </summary>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventSourceVw> EventSourceVwList()
		{
			return _EventSourceVwList().ToList<EventSourceVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventSourceVwGet")]
		private ISingleResult<EventSourceVw> _EventSourceVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventSourceVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		/// <returns>Gets an instance of EventSourceVw or null.</returns>
		public EventSourceVw EventSourceVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventSourceVw> list = _EventSourceVwGet(_id).ToList<EventSourceVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EventSourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		/// <returns>Gets an instance of EventSourceVw or null.</returns>
		public EventSourceVw EventSourceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return EventSourceVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventSourceVwGetByName")]
		private ISingleResult<EventSourceVw> _EventSourceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventSourceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventSourceVw> EventSourceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventSourceVwGetByName(_name).ToList<EventSourceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		/// <returns>An instance of EventSourceVw.</returns>
		public EventSourceVw EventSourceVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _EventSourceVwGetByName(_name).ToList<EventSourceVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region EventStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.EventStatusVwList")]
		private ISingleResult<EventStatusVw> _EventStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<EventStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.EventStatusVw view.
		/// </summary>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventStatusVw> EventStatusVwList()
		{
			return _EventStatusVwList().ToList<EventStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.EventStatusVwGet")]
		private ISingleResult<EventStatusVw> _EventStatusVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<EventStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		/// <returns>Gets an instance of EventStatusVw or null.</returns>
		public EventStatusVw EventStatusVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<EventStatusVw> list = _EventStatusVwGet(_id).ToList<EventStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.EventStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		/// <returns>Gets an instance of EventStatusVw or null.</returns>
		public EventStatusVw EventStatusVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return EventStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.EventStatusVwGetByName")]
		private ISingleResult<EventStatusVw> _EventStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<EventStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<EventStatusVw> EventStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _EventStatusVwGetByName(_name).ToList<EventStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		/// <returns>An instance of EventStatusVw.</returns>
		public EventStatusVw EventStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _EventStatusVwGetByName(_name).ToList<EventStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ExceptionalAmountTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.ExceptionalAmountTypeVwList")]
		private ISingleResult<ExceptionalAmountTypeVw> _ExceptionalAmountTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExceptionalAmountTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		/// <returns>A list of ExceptionalAmountTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmountTypeVw> ExceptionalAmountTypeVwList()
		{
			return _ExceptionalAmountTypeVwList().ToList<ExceptionalAmountTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExceptionalAmountTypeVwGet")]
		private ISingleResult<ExceptionalAmountTypeVw> _ExceptionalAmountTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExceptionalAmountTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null.</returns>
		public ExceptionalAmountTypeVw ExceptionalAmountTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<ExceptionalAmountTypeVw> list = _ExceptionalAmountTypeVwGet(_id).ToList<ExceptionalAmountTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null.</returns>
		public ExceptionalAmountTypeVw ExceptionalAmountTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return ExceptionalAmountTypeVwGet(_id);
        }
        #endregion
		#endregion

        #region ExceptionalAmountVw procedures.
		#region List procedure
		[Function(Name = "dbo.ExceptionalAmountVwList")]
		private ISingleResult<ExceptionalAmountVw> _ExceptionalAmountVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExceptionalAmountVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmountVw> ExceptionalAmountVwList()
		{
			return _ExceptionalAmountVwList().ToList<ExceptionalAmountVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExceptionalAmountVwGet")]
		private ISingleResult<ExceptionalAmountVw> _ExceptionalAmountVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExceptionalAmountVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null.</returns>
		public ExceptionalAmountVw ExceptionalAmountVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ExceptionalAmountVw> list = _ExceptionalAmountVwGet(_id).ToList<ExceptionalAmountVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null.</returns>
		public ExceptionalAmountVw ExceptionalAmountVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return ExceptionalAmountVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ExceptionalAmountVwGetByExceptionalAmountTypeId")]
		private ISingleResult<ExceptionalAmountVw> _ExceptionalAmountVwGetByExceptionalAmountTypeId([Parameter(Name = "@ExceptionalAmountTypeId")] byte _exceptionalAmountTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _exceptionalAmountTypeId);
			return (result.ReturnValue as ISingleResult<ExceptionalAmountVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmountVw> ExceptionalAmountVwGetByExceptionalAmountTypeId([Parameter(Name = "@ExceptionalAmountTypeId")] byte _exceptionalAmountTypeId)
		{
			return _ExceptionalAmountVwGetByExceptionalAmountTypeId(_exceptionalAmountTypeId).ToList<ExceptionalAmountVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		/// <returns>An instance of ExceptionalAmountVw.</returns>
		public ExceptionalAmountVw ExceptionalAmountVwGetByExceptionalAmountTypeIdFirstOrDefault([Parameter(Name = "@ExceptionalAmountTypeId")] byte _exceptionalAmountTypeId)
		{
			return _ExceptionalAmountVwGetByExceptionalAmountTypeId(_exceptionalAmountTypeId).ToList<ExceptionalAmountVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ExceptionalAmountVwGetByLoanRequestRequestProductId")]
		private ISingleResult<ExceptionalAmountVw> _ExceptionalAmountVwGetByLoanRequestRequestProductId([Parameter(Name = "@LoanRequestRequestProductId")] int _loanRequestRequestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequestRequestProductId);
			return (result.ReturnValue as ISingleResult<ExceptionalAmountVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExceptionalAmountVw> ExceptionalAmountVwGetByLoanRequestRequestProductId([Parameter(Name = "@LoanRequestRequestProductId")] int _loanRequestRequestProductId)
		{
			return _ExceptionalAmountVwGetByLoanRequestRequestProductId(_loanRequestRequestProductId).ToList<ExceptionalAmountVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		/// <returns>An instance of ExceptionalAmountVw.</returns>
		public ExceptionalAmountVw ExceptionalAmountVwGetByLoanRequestRequestProductIdFirstOrDefault([Parameter(Name = "@LoanRequestRequestProductId")] int _loanRequestRequestProductId)
		{
			return _ExceptionalAmountVwGetByLoanRequestRequestProductId(_loanRequestRequestProductId).ToList<ExceptionalAmountVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ExternalGrantVw procedures.
		#region List procedure
		[Function(Name = "dbo.ExternalGrantVwList")]
		private ISingleResult<ExternalGrantVw> _ExternalGrantVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ExternalGrantVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ExternalGrantVw view.
		/// </summary>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrantVw> ExternalGrantVwList()
		{
			return _ExternalGrantVwList().ToList<ExternalGrantVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ExternalGrantVwGet")]
		private ISingleResult<ExternalGrantVw> _ExternalGrantVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ExternalGrantVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		/// <returns>Gets an instance of ExternalGrantVw or null.</returns>
		public ExternalGrantVw ExternalGrantVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ExternalGrantVw> list = _ExternalGrantVwGet(_id).ToList<ExternalGrantVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		/// <returns>Gets an instance of ExternalGrantVw or null.</returns>
		public ExternalGrantVw ExternalGrantVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return ExternalGrantVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ExternalGrantVwGetByEmployeeId")]
		private ISingleResult<ExternalGrantVw> _ExternalGrantVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<ExternalGrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrantVw> ExternalGrantVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ExternalGrantVwGetByEmployeeId(_employeeId).ToList<ExternalGrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of ExternalGrantVw.</returns>
		public ExternalGrantVw ExternalGrantVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ExternalGrantVwGetByEmployeeId(_employeeId).ToList<ExternalGrantVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ExternalGrantVwGetByGrantTypeId")]
		private ISingleResult<ExternalGrantVw> _ExternalGrantVwGetByGrantTypeId([Parameter(Name = "@GrantTypeId")] byte _grantTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeId);
			return (result.ReturnValue as ISingleResult<ExternalGrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ExternalGrantVw> ExternalGrantVwGetByGrantTypeId([Parameter(Name = "@GrantTypeId")] byte _grantTypeId)
		{
			return _ExternalGrantVwGetByGrantTypeId(_grantTypeId).ToList<ExternalGrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		/// <returns>An instance of ExternalGrantVw.</returns>
		public ExternalGrantVw ExternalGrantVwGetByGrantTypeIdFirstOrDefault([Parameter(Name = "@GrantTypeId")] byte _grantTypeId)
		{
			return _ExternalGrantVwGetByGrantTypeId(_grantTypeId).ToList<ExternalGrantVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantDecisionVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantDecisionVwList")]
		private ISingleResult<GrantDecisionVw> _GrantDecisionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantDecisionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantDecisionVw view.
		/// </summary>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecisionVw> GrantDecisionVwList()
		{
			return _GrantDecisionVwList().ToList<GrantDecisionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantDecisionVwGet")]
		private ISingleResult<GrantDecisionVw> _GrantDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantDecisionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		/// <returns>Gets an instance of GrantDecisionVw or null.</returns>
		public GrantDecisionVw GrantDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantDecisionVw> list = _GrantDecisionVwGet(_id).ToList<GrantDecisionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GrantDecisionVwGetChildren")]
        [ResultType(typeof(GrantDecisionVw))]
        [ResultType(typeof(GrantVw))]
        private IMultipleResults _GrantDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		/// <returns>Gets an instance of GrantDecisionVw or null.</returns>
		public GrantDecisionVw GrantDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _GrantDecisionVwGetChildren(_id);
            GrantDecisionVw result = multipleResult.GetResult<GrantDecisionVw>().FirstOrDefault<GrantDecisionVw>();
            if (result == null) return null;
            result.GrantVwList = multipleResult.GetResult<GrantVw>().ToList<GrantVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantDecisionVwGetByGrantTypeGroupId")]
		private ISingleResult<GrantDecisionVw> _GrantDecisionVwGetByGrantTypeGroupId([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroupId);
			return (result.ReturnValue as ISingleResult<GrantDecisionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecisionVw> GrantDecisionVwGetByGrantTypeGroupId([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			return _GrantDecisionVwGetByGrantTypeGroupId(_grantTypeGroupId).ToList<GrantDecisionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		/// <returns>An instance of GrantDecisionVw.</returns>
		public GrantDecisionVw GrantDecisionVwGetByGrantTypeGroupIdFirstOrDefault([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			return _GrantDecisionVwGetByGrantTypeGroupId(_grantTypeGroupId).ToList<GrantDecisionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GrantDecisionVwGetByNumber_Year")]
		private ISingleResult<GrantDecisionVw> _GrantDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<GrantDecisionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDecisionVw> GrantDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantDecisionVwGetByNumber_Year(_number, _year).ToList<GrantDecisionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>An instance of GrantDecisionVw.</returns>
		public GrantDecisionVw GrantDecisionVwGetByNumber_YearFirstOrDefault([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantDecisionVwGetByNumber_Year(_number, _year).ToList<GrantDecisionVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantDeductionVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantDeductionVwList")]
		private ISingleResult<GrantDeductionVw> _GrantDeductionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantDeductionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantDeductionVw view.
		/// </summary>
		/// <returns>A list of GrantDeductionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDeductionVw> GrantDeductionVwList()
		{
			return _GrantDeductionVwList().ToList<GrantDeductionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantDeductionVwGet")]
		private ISingleResult<GrantDeductionVw> _GrantDeductionVwGet([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantProductId);
			return (result.ReturnValue as ISingleResult<GrantDeductionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantDeductionVw or null.</returns>
		public GrantDeductionVw GrantDeductionVwGet([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
			List<GrantDeductionVw> list = _GrantDeductionVwGet(_grantProductId).ToList<GrantDeductionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view with related objects from children.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantDeductionVw or null.</returns>
		public GrantDeductionVw GrantDeductionVwGetChildren([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
            return GrantDeductionVwGet(_grantProductId);
        }
        #endregion
		#endregion

        #region GrantDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantDetailVwList")]
		private ISingleResult<GrantDetailVw> _GrantDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantDetailVw view.
		/// </summary>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDetailVw> GrantDetailVwList()
		{
			return _GrantDetailVwList().ToList<GrantDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantDetailVwGet")]
		private ISingleResult<GrantDetailVw> _GrantDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<GrantDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantDetailVw or null.</returns>
		public GrantDetailVw GrantDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<GrantDetailVw> list = _GrantDetailVwGet(_productId).ToList<GrantDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantDetailVwGetByGrantDecisionId")]
		private ISingleResult<GrantDetailVw> _GrantDetailVwGetByGrantDecisionId([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantDecisionId);
			return (result.ReturnValue as ISingleResult<GrantDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantDetailVw> GrantDetailVwGetByGrantDecisionId([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			return _GrantDetailVwGetByGrantDecisionId(_grantDecisionId).ToList<GrantDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>An instance of GrantDetailVw.</returns>
		public GrantDetailVw GrantDetailVwGetByGrantDecisionIdFirstOrDefault([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			return _GrantDetailVwGetByGrantDecisionId(_grantDecisionId).ToList<GrantDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantPaymentOrderVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantPaymentOrderVwList")]
		private ISingleResult<GrantPaymentOrderVw> _GrantPaymentOrderVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantPaymentOrderVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrderVw> GrantPaymentOrderVwList()
		{
			return _GrantPaymentOrderVwList().ToList<GrantPaymentOrderVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantPaymentOrderVwGet")]
		private ISingleResult<GrantPaymentOrderVw> _GrantPaymentOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrderVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null.</returns>
		public GrantPaymentOrderVw GrantPaymentOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantPaymentOrderVw> list = _GrantPaymentOrderVwGet(_id).ToList<GrantPaymentOrderVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GrantPaymentOrderVwGetChildren")]
        [ResultType(typeof(GrantPaymentOrderVw))]
        [ResultType(typeof(GrantPaymentVw))]
        private IMultipleResults _GrantPaymentOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null.</returns>
		public GrantPaymentOrderVw GrantPaymentOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _GrantPaymentOrderVwGetChildren(_id);
            GrantPaymentOrderVw result = multipleResult.GetResult<GrantPaymentOrderVw>().FirstOrDefault<GrantPaymentOrderVw>();
            if (result == null) return null;
            result.GrantPaymentVwList = multipleResult.GetResult<GrantPaymentVw>().ToList<GrantPaymentVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantPaymentOrderVwGetByDate")]
		private ISingleResult<GrantPaymentOrderVw> _GrantPaymentOrderVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrderVw> GrantPaymentOrderVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _GrantPaymentOrderVwGetByDate(_date).ToList<GrantPaymentOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		/// <returns>An instance of GrantPaymentOrderVw.</returns>
		public GrantPaymentOrderVw GrantPaymentOrderVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _GrantPaymentOrderVwGetByDate(_date).ToList<GrantPaymentOrderVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GrantPaymentOrderVwGetByNumber_Year")]
		private ISingleResult<GrantPaymentOrderVw> _GrantPaymentOrderVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<GrantPaymentOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentOrderVw> GrantPaymentOrderVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantPaymentOrderVwGetByNumber_Year(_number, _year).ToList<GrantPaymentOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		/// <returns>An instance of GrantPaymentOrderVw.</returns>
		public GrantPaymentOrderVw GrantPaymentOrderVwGetByNumber_YearFirstOrDefault([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _GrantPaymentOrderVwGetByNumber_Year(_number, _year).ToList<GrantPaymentOrderVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantPaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantPaymentVwList")]
		private ISingleResult<GrantPaymentVw> _GrantPaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantPaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantPaymentVw view.
		/// </summary>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentVw> GrantPaymentVwList()
		{
			return _GrantPaymentVwList().ToList<GrantPaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantPaymentVwGet")]
		private ISingleResult<GrantPaymentVw> _GrantPaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantPaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		/// <returns>Gets an instance of GrantPaymentVw or null.</returns>
		public GrantPaymentVw GrantPaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<GrantPaymentVw> list = _GrantPaymentVwGet(_id).ToList<GrantPaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		/// <returns>Gets an instance of GrantPaymentVw or null.</returns>
		public GrantPaymentVw GrantPaymentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return GrantPaymentVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantPaymentVwGetByGrantPaymentOrderId")]
		private ISingleResult<GrantPaymentVw> _GrantPaymentVwGetByGrantPaymentOrderId([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrderId);
			return (result.ReturnValue as ISingleResult<GrantPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentVw> GrantPaymentVwGetByGrantPaymentOrderId([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId)
		{
			return _GrantPaymentVwGetByGrantPaymentOrderId(_grantPaymentOrderId).ToList<GrantPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <returns>An instance of GrantPaymentVw.</returns>
		public GrantPaymentVw GrantPaymentVwGetByGrantPaymentOrderIdFirstOrDefault([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId)
		{
			return _GrantPaymentVwGetByGrantPaymentOrderId(_grantPaymentOrderId).ToList<GrantPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GrantPaymentVwGetByGrantPaymentOrderId_SubNumber")]
		private ISingleResult<GrantPaymentVw> _GrantPaymentVwGetByGrantPaymentOrderId_SubNumber([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantPaymentOrderId, _subNumber);
			return (result.ReturnValue as ISingleResult<GrantPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId_SubNumber columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentVw> GrantPaymentVwGetByGrantPaymentOrderId_SubNumber([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GrantPaymentVwGetByGrantPaymentOrderId_SubNumber(_grantPaymentOrderId, _subNumber).ToList<GrantPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId_SubNumber columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		/// <returns>An instance of GrantPaymentVw.</returns>
		public GrantPaymentVw GrantPaymentVwGetByGrantPaymentOrderId_SubNumberFirstOrDefault([Parameter(Name = "@GrantPaymentOrderId")] int _grantPaymentOrderId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GrantPaymentVwGetByGrantPaymentOrderId_SubNumber(_grantPaymentOrderId, _subNumber).ToList<GrantPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GrantPaymentVwGetByGrantProductId")]
		private ISingleResult<GrantPaymentVw> _GrantPaymentVwGetByGrantProductId([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantProductId);
			return (result.ReturnValue as ISingleResult<GrantPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantPaymentVw> GrantPaymentVwGetByGrantProductId([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
			return _GrantPaymentVwGetByGrantProductId(_grantProductId).ToList<GrantPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>An instance of GrantPaymentVw.</returns>
		public GrantPaymentVw GrantPaymentVwGetByGrantProductIdFirstOrDefault([Parameter(Name = "@GrantProductId")] int _grantProductId)
		{
			return _GrantPaymentVwGetByGrantProductId(_grantProductId).ToList<GrantPaymentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantRequestDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantRequestDetailVwList")]
		private ISingleResult<GrantRequestDetailVw> _GrantRequestDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantRequestDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantRequestDetailVw view.
		/// </summary>
		/// <returns>A list of GrantRequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantRequestDetailVw> GrantRequestDetailVwList()
		{
			return _GrantRequestDetailVwList().ToList<GrantRequestDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantRequestDetailVwGet")]
		private ISingleResult<GrantRequestDetailVw> _GrantRequestDetailVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as ISingleResult<GrantRequestDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantRequestDetailVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestDetailVw or null.</returns>
		public GrantRequestDetailVw GrantRequestDetailVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			List<GrantRequestDetailVw> list = _GrantRequestDetailVwGet(_requestProductId).ToList<GrantRequestDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		#endregion

        #region GrantRequestVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantRequestVwList")]
		private ISingleResult<GrantRequestVw> _GrantRequestVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantRequestVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantRequestVw view.
		/// </summary>
		/// <returns>A list of GrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantRequestVw> GrantRequestVwList()
		{
			return _GrantRequestVwList().ToList<GrantRequestVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantRequestVwGet")]
		private ISingleResult<GrantRequestVw> _GrantRequestVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as ISingleResult<GrantRequestVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestVw or null.</returns>
		public GrantRequestVw GrantRequestVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			List<GrantRequestVw> list = _GrantRequestVwGet(_requestProductId).ToList<GrantRequestVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GrantRequestVwGetChildren")]
        [ResultType(typeof(GrantRequestVw))]
        [ResultType(typeof(ServiceEndGrantRequestVw))]
        private IMultipleResults _GrantRequestVwGetChildren([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestVw or null.</returns>
		public GrantRequestVw GrantRequestVwGetChildren([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IMultipleResults multipleResult = _GrantRequestVwGetChildren(_requestProductId);
            GrantRequestVw result = multipleResult.GetResult<GrantRequestVw>().FirstOrDefault<GrantRequestVw>();
            if (result == null) return null;
            result.ServiceEndGrantRequestVw = multipleResult.GetResult<ServiceEndGrantRequestVw>().FirstOrDefault<ServiceEndGrantRequestVw>();
            return result;
        }
        #endregion
		#endregion

        #region GrantTypeGroupVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantTypeGroupVwList")]
		private ISingleResult<GrantTypeGroupVw> _GrantTypeGroupVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantTypeGroupVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeGroupVw> GrantTypeGroupVwList()
		{
			return _GrantTypeGroupVwList().ToList<GrantTypeGroupVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantTypeGroupVwGet")]
		private ISingleResult<GrantTypeGroupVw> _GrantTypeGroupVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantTypeGroupVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null.</returns>
		public GrantTypeGroupVw GrantTypeGroupVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GrantTypeGroupVw> list = _GrantTypeGroupVwGet(_id).ToList<GrantTypeGroupVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GrantTypeGroupVwGetChildren")]
        [ResultType(typeof(GrantTypeGroupVw))]
        [ResultType(typeof(GrantTypeVw))]
        private IMultipleResults _GrantTypeGroupVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null.</returns>
		public GrantTypeGroupVw GrantTypeGroupVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IMultipleResults multipleResult = _GrantTypeGroupVwGetChildren(_id);
            GrantTypeGroupVw result = multipleResult.GetResult<GrantTypeGroupVw>().FirstOrDefault<GrantTypeGroupVw>();
            if (result == null) return null;
            result.GrantTypeVwList = multipleResult.GetResult<GrantTypeVw>().ToList<GrantTypeVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantTypeGroupVwGetByName")]
		private ISingleResult<GrantTypeGroupVw> _GrantTypeGroupVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GrantTypeGroupVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeGroupVw> GrantTypeGroupVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeGroupVwGetByName(_name).ToList<GrantTypeGroupVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		/// <returns>An instance of GrantTypeGroupVw.</returns>
		public GrantTypeGroupVw GrantTypeGroupVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeGroupVwGetByName(_name).ToList<GrantTypeGroupVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantTypeVwList")]
		private ISingleResult<GrantTypeVw> _GrantTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantTypeVw view.
		/// </summary>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeVw> GrantTypeVwList()
		{
			return _GrantTypeVwList().ToList<GrantTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantTypeVwGet")]
		private ISingleResult<GrantTypeVw> _GrantTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GrantTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		/// <returns>Gets an instance of GrantTypeVw or null.</returns>
		public GrantTypeVw GrantTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GrantTypeVw> list = _GrantTypeVwGet(_id).ToList<GrantTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		/// <returns>Gets an instance of GrantTypeVw or null.</returns>
		public GrantTypeVw GrantTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return GrantTypeVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantTypeVwGetByGrantTypeGroupId")]
		private ISingleResult<GrantTypeVw> _GrantTypeVwGetByGrantTypeGroupId([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantTypeGroupId);
			return (result.ReturnValue as ISingleResult<GrantTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeVw> GrantTypeVwGetByGrantTypeGroupId([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			return _GrantTypeVwGetByGrantTypeGroupId(_grantTypeGroupId).ToList<GrantTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		/// <returns>An instance of GrantTypeVw.</returns>
		public GrantTypeVw GrantTypeVwGetByGrantTypeGroupIdFirstOrDefault([Parameter(Name = "@GrantTypeGroupId")] byte _grantTypeGroupId)
		{
			return _GrantTypeVwGetByGrantTypeGroupId(_grantTypeGroupId).ToList<GrantTypeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GrantTypeVwGetByName")]
		private ISingleResult<GrantTypeVw> _GrantTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GrantTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantTypeVw> GrantTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeVwGetByName(_name).ToList<GrantTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		/// <returns>An instance of GrantTypeVw.</returns>
		public GrantTypeVw GrantTypeVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _GrantTypeVwGetByName(_name).ToList<GrantTypeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GrantVw procedures.
		#region List procedure
		[Function(Name = "dbo.GrantVwList")]
		private ISingleResult<GrantVw> _GrantVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GrantVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GrantVw view.
		/// </summary>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantVw> GrantVwList()
		{
			return _GrantVwList().ToList<GrantVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GrantVwGet")]
		private ISingleResult<GrantVw> _GrantVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<GrantVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantVw or null.</returns>
		public GrantVw GrantVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<GrantVw> list = _GrantVwGet(_productId).ToList<GrantVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GrantVwGetChildren")]
        [ResultType(typeof(GrantVw))]
        [ResultType(typeof(GrantDeductionVw))]
        [ResultType(typeof(GrantPaymentVw))]
        private IMultipleResults _GrantVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GrantVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantVw or null.</returns>
		public GrantVw GrantVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IMultipleResults multipleResult = _GrantVwGetChildren(_productId);
            GrantVw result = multipleResult.GetResult<GrantVw>().FirstOrDefault<GrantVw>();
            if (result == null) return null;
            result.GrantDeductionVw = multipleResult.GetResult<GrantDeductionVw>().FirstOrDefault<GrantDeductionVw>();
            result.GrantPaymentVwList = multipleResult.GetResult<GrantPaymentVw>().ToList<GrantPaymentVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GrantVwGetByGrantDecisionId")]
		private ISingleResult<GrantVw> _GrantVwGetByGrantDecisionId([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantDecisionId);
			return (result.ReturnValue as ISingleResult<GrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GrantVw> GrantVwGetByGrantDecisionId([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			return _GrantVwGetByGrantDecisionId(_grantDecisionId).ToList<GrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>An instance of GrantVw.</returns>
		public GrantVw GrantVwGetByGrantDecisionIdFirstOrDefault([Parameter(Name = "@GrantDecisionId")] int _grantDecisionId)
		{
			return _GrantVwGetByGrantDecisionId(_grantDecisionId).ToList<GrantVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GuarantorDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorDetailVwList")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorDetailVw view.
		/// </summary>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorDetailVw> GuarantorDetailVwList()
		{
			return _GuarantorDetailVwList().ToList<GuarantorDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorDetailVwGet")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorDetailVw or null.</returns>
		public GuarantorDetailVw GuarantorDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<GuarantorDetailVw> list = _GuarantorDetailVwGet(_id).ToList<GuarantorDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GuarantorDetailVwGetByEmployeeId")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorDetailVw> GuarantorDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorDetailVwGetByEmployeeId(_employeeId).ToList<GuarantorDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>An instance of GuarantorDetailVw.</returns>
		public GuarantorDetailVw GuarantorDetailVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorDetailVwGetByEmployeeId(_employeeId).ToList<GuarantorDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorDetailVwGetByGuarantorStatusId")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwGetByGuarantorStatusId([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantorStatusId);
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorDetailVw> GuarantorDetailVwGetByGuarantorStatusId([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			return _GuarantorDetailVwGetByGuarantorStatusId(_guarantorStatusId).ToList<GuarantorDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>An instance of GuarantorDetailVw.</returns>
		public GuarantorDetailVw GuarantorDetailVwGetByGuarantorStatusIdFirstOrDefault([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			return _GuarantorDetailVwGetByGuarantorStatusId(_guarantorStatusId).ToList<GuarantorDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorDetailVwGetByRefundableProductProductId")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId);
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorDetailVw> GuarantorDetailVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _GuarantorDetailVwGetByRefundableProductProductId(_refundableProductProductId).ToList<GuarantorDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>An instance of GuarantorDetailVw.</returns>
		public GuarantorDetailVw GuarantorDetailVwGetByRefundableProductProductIdFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _GuarantorDetailVwGetByRefundableProductProductId(_refundableProductProductId).ToList<GuarantorDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorDetailVwGetByRefundableProductProductId_SubNumber")]
		private ISingleResult<GuarantorDetailVw> _GuarantorDetailVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId, _subNumber);
			return (result.ReturnValue as ISingleResult<GuarantorDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorDetailVw> GuarantorDetailVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GuarantorDetailVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<GuarantorDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>An instance of GuarantorDetailVw.</returns>
		public GuarantorDetailVw GuarantorDetailVwGetByRefundableProductProductId_SubNumberFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GuarantorDetailVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<GuarantorDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GuarantorStatementVw procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorStatementVwList")]
		private ISingleResult<GuarantorStatementVw> _GuarantorStatementVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorStatementVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorStatementVw view.
		/// </summary>
		/// <returns>A list of GuarantorStatementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatementVw> GuarantorStatementVwList()
		{
			return _GuarantorStatementVwList().ToList<GuarantorStatementVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorStatementVwGet")]
		private ISingleResult<GuarantorStatementVw> _GuarantorStatementVwGet([Parameter(Name = "@GuarantorId")] int _guarantorId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantorId);
			return (result.ReturnValue as ISingleResult<GuarantorStatementVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null.</returns>
		public GuarantorStatementVw GuarantorStatementVwGet([Parameter(Name = "@GuarantorId")] int _guarantorId)
		{
			List<GuarantorStatementVw> list = _GuarantorStatementVwGet(_guarantorId).ToList<GuarantorStatementVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view with related objects from children.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null.</returns>
		public GuarantorStatementVw GuarantorStatementVwGetChildren([Parameter(Name = "@GuarantorId")] int _guarantorId)
		{
            return GuarantorStatementVwGet(_guarantorId);
        }
        #endregion
		#endregion

        #region GuarantorStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorStatusVwList")]
		private ISingleResult<GuarantorStatusVw> _GuarantorStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorStatusVw view.
		/// </summary>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatusVw> GuarantorStatusVwList()
		{
			return _GuarantorStatusVwList().ToList<GuarantorStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorStatusVwGet")]
		private ISingleResult<GuarantorStatusVw> _GuarantorStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GuarantorStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null.</returns>
		public GuarantorStatusVw GuarantorStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<GuarantorStatusVw> list = _GuarantorStatusVwGet(_id).ToList<GuarantorStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null.</returns>
		public GuarantorStatusVw GuarantorStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return GuarantorStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GuarantorStatusVwGetByName")]
		private ISingleResult<GuarantorStatusVw> _GuarantorStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<GuarantorStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorStatusVw> GuarantorStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _GuarantorStatusVwGetByName(_name).ToList<GuarantorStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		/// <returns>An instance of GuarantorStatusVw.</returns>
		public GuarantorStatusVw GuarantorStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _GuarantorStatusVwGetByName(_name).ToList<GuarantorStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region GuarantorVw procedures.
		#region List procedure
		[Function(Name = "dbo.GuarantorVwList")]
		private ISingleResult<GuarantorVw> _GuarantorVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.GuarantorVw view.
		/// </summary>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwList()
		{
			return _GuarantorVwList().ToList<GuarantorVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.GuarantorVwGet")]
		private ISingleResult<GuarantorVw> _GuarantorVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorVw or null.</returns>
		public GuarantorVw GuarantorVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<GuarantorVw> list = _GuarantorVwGet(_id).ToList<GuarantorVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.GuarantorVwGetChildren")]
        [ResultType(typeof(GuarantorVw))]
        [ResultType(typeof(GuarantorStatementVw))]
        private IMultipleResults _GuarantorVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.GuarantorVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorVw or null.</returns>
		public GuarantorVw GuarantorVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _GuarantorVwGetChildren(_id);
            GuarantorVw result = multipleResult.GetResult<GuarantorVw>().FirstOrDefault<GuarantorVw>();
            if (result == null) return null;
            result.GuarantorStatementVw = multipleResult.GetResult<GuarantorStatementVw>().FirstOrDefault<GuarantorStatementVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.GuarantorVwGetByEmployeeId")]
		private ISingleResult<GuarantorVw> _GuarantorVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorVwGetByEmployeeId(_employeeId).ToList<GuarantorVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>An instance of GuarantorVw.</returns>
		public GuarantorVw GuarantorVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorVwGetByEmployeeId(_employeeId).ToList<GuarantorVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorVwGetByGuarantorStatusId")]
		private ISingleResult<GuarantorVw> _GuarantorVwGetByGuarantorStatusId([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _guarantorStatusId);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwGetByGuarantorStatusId([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			return _GuarantorVwGetByGuarantorStatusId(_guarantorStatusId).ToList<GuarantorVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>An instance of GuarantorVw.</returns>
		public GuarantorVw GuarantorVwGetByGuarantorStatusIdFirstOrDefault([Parameter(Name = "@GuarantorStatusId")] byte _guarantorStatusId)
		{
			return _GuarantorVwGetByGuarantorStatusId(_guarantorStatusId).ToList<GuarantorVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorVwGetByRefundableProductProductId")]
		private ISingleResult<GuarantorVw> _GuarantorVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _GuarantorVwGetByRefundableProductProductId(_refundableProductProductId).ToList<GuarantorVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>An instance of GuarantorVw.</returns>
		public GuarantorVw GuarantorVwGetByRefundableProductProductIdFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _GuarantorVwGetByRefundableProductProductId(_refundableProductProductId).ToList<GuarantorVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorVwGetByRefundableProductProductId_EmployeeId")]
		private ISingleResult<GuarantorVw> _GuarantorVwGetByRefundableProductProductId_EmployeeId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId, _employeeId);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwGetByRefundableProductProductId_EmployeeId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorVwGetByRefundableProductProductId_EmployeeId(_refundableProductProductId, _employeeId).ToList<GuarantorVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>An instance of GuarantorVw.</returns>
		public GuarantorVw GuarantorVwGetByRefundableProductProductId_EmployeeIdFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _GuarantorVwGetByRefundableProductProductId_EmployeeId(_refundableProductProductId, _employeeId).ToList<GuarantorVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.GuarantorVwGetByRefundableProductProductId_SubNumber")]
		private ISingleResult<GuarantorVw> _GuarantorVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId, _subNumber);
			return (result.ReturnValue as ISingleResult<GuarantorVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<GuarantorVw> GuarantorVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GuarantorVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<GuarantorVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>An instance of GuarantorVw.</returns>
		public GuarantorVw GuarantorVwGetByRefundableProductProductId_SubNumberFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] byte _subNumber)
		{
			return _GuarantorVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<GuarantorVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region HealthLoanDecisionFirstPaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwList")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwList()
		{
			return _HealthLoanDecisionFirstPaymentVwList().ToList<HealthLoanDecisionFirstPaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGet")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<HealthLoanDecisionFirstPaymentVw> list = _HealthLoanDecisionFirstPaymentVwGet(_id).ToList<HealthLoanDecisionFirstPaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return HealthLoanDecisionFirstPaymentVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByDepartment")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _department);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByDepartment([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByDepartment(_department).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByDepartmentFirstOrDefault([Parameter(Name = "@Department")] Nullable<int> _department)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByDepartment(_department).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByEmployeeId")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByEmployeeId(_employeeId).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByEmployeeId(_employeeId).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _paymentDate);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentDate columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate(_employeeId, _paymentDate).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentDate columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDateFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentDate")] DateTime _paymentDate)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate(_employeeId, _paymentDate).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId([Parameter(Name = "@HealthLoanDecisionId")] Nullable<int> _healthLoanDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _healthLoanDecisionId);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId([Parameter(Name = "@HealthLoanDecisionId")] Nullable<int> _healthLoanDecisionId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId(_healthLoanDecisionId).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionIdFirstOrDefault([Parameter(Name = "@HealthLoanDecisionId")] Nullable<int> _healthLoanDecisionId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId(_healthLoanDecisionId).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId([Parameter(Name = "@InsuranceTypeId")] Nullable<byte> _insuranceTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _insuranceTypeId);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId([Parameter(Name = "@InsuranceTypeId")] Nullable<byte> _insuranceTypeId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId(_insuranceTypeId).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeIdFirstOrDefault([Parameter(Name = "@InsuranceTypeId")] Nullable<byte> _insuranceTypeId)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId(_insuranceTypeId).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByLoanRequest")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanRequest);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByLoanRequest([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByLoanRequest(_loanRequest).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByLoanRequestFirstOrDefault([Parameter(Name = "@LoanRequest")] Nullable<int> _loanRequest)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByLoanRequest(_loanRequest).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionFirstPaymentVwGetByPaymentStatus")]
		private ISingleResult<HealthLoanDecisionFirstPaymentVw> _HealthLoanDecisionFirstPaymentVwGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatus);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionFirstPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwGetByPaymentStatus([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByPaymentStatus(_paymentStatus).ToList<HealthLoanDecisionFirstPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		/// <returns>An instance of HealthLoanDecisionFirstPaymentVw.</returns>
		public HealthLoanDecisionFirstPaymentVw HealthLoanDecisionFirstPaymentVwGetByPaymentStatusFirstOrDefault([Parameter(Name = "@PaymentStatus")] Nullable<byte> _paymentStatus)
		{
			return _HealthLoanDecisionFirstPaymentVwGetByPaymentStatus(_paymentStatus).ToList<HealthLoanDecisionFirstPaymentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region HealthLoanDecisionVw procedures.
		#region List procedure
		[Function(Name = "dbo.HealthLoanDecisionVwList")]
		private ISingleResult<HealthLoanDecisionVw> _HealthLoanDecisionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionVw> HealthLoanDecisionVwList()
		{
			return _HealthLoanDecisionVwList().ToList<HealthLoanDecisionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.HealthLoanDecisionVwGet")]
		private ISingleResult<HealthLoanDecisionVw> _HealthLoanDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null.</returns>
		public HealthLoanDecisionVw HealthLoanDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<HealthLoanDecisionVw> list = _HealthLoanDecisionVwGet(_id).ToList<HealthLoanDecisionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.HealthLoanDecisionVwGetChildren")]
        [ResultType(typeof(HealthLoanDecisionVw))]
        [ResultType(typeof(HealthLoanDecisionFirstPaymentVw))]
        private IMultipleResults _HealthLoanDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null.</returns>
		public HealthLoanDecisionVw HealthLoanDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _HealthLoanDecisionVwGetChildren(_id);
            HealthLoanDecisionVw result = multipleResult.GetResult<HealthLoanDecisionVw>().FirstOrDefault<HealthLoanDecisionVw>();
            if (result == null) return null;
            result.HealthLoanDecisionFirstPaymentVwList = multipleResult.GetResult<HealthLoanDecisionFirstPaymentVw>().ToList<HealthLoanDecisionFirstPaymentVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.HealthLoanDecisionVwGetByDate")]
		private ISingleResult<HealthLoanDecisionVw> _HealthLoanDecisionVwGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionVw> HealthLoanDecisionVwGetByDate([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _HealthLoanDecisionVwGetByDate(_date).ToList<HealthLoanDecisionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		/// <returns>An instance of HealthLoanDecisionVw.</returns>
		public HealthLoanDecisionVw HealthLoanDecisionVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			return _HealthLoanDecisionVwGetByDate(_date).ToList<HealthLoanDecisionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.HealthLoanDecisionVwGetByNumber_Year")]
		private ISingleResult<HealthLoanDecisionVw> _HealthLoanDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<HealthLoanDecisionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<HealthLoanDecisionVw> HealthLoanDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _HealthLoanDecisionVwGetByNumber_Year(_number, _year).ToList<HealthLoanDecisionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		/// <returns>An instance of HealthLoanDecisionVw.</returns>
		public HealthLoanDecisionVw HealthLoanDecisionVwGetByNumber_YearFirstOrDefault([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _HealthLoanDecisionVwGetByNumber_Year(_number, _year).ToList<HealthLoanDecisionVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region IncomingLoanVw procedures.
		#region List procedure
		[Function(Name = "dbo.IncomingLoanVwList")]
		private ISingleResult<IncomingLoanVw> _IncomingLoanVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<IncomingLoanVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.IncomingLoanVw view.
		/// </summary>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IncomingLoanVw> IncomingLoanVwList()
		{
			return _IncomingLoanVwList().ToList<IncomingLoanVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.IncomingLoanVwGet")]
		private ISingleResult<IncomingLoanVw> _IncomingLoanVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanProductId);
			return (result.ReturnValue as ISingleResult<IncomingLoanVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of IncomingLoanVw or null.</returns>
		public IncomingLoanVw IncomingLoanVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			List<IncomingLoanVw> list = _IncomingLoanVwGet(_loanProductId).ToList<IncomingLoanVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of IncomingLoanVw or null.</returns>
		public IncomingLoanVw IncomingLoanVwGetChildren([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
            return IncomingLoanVwGet(_loanProductId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.IncomingLoanVwGetByMainWorkPlaceId")]
		private ISingleResult<IncomingLoanVw> _IncomingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlaceId);
			return (result.ReturnValue as ISingleResult<IncomingLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IncomingLoanVw> IncomingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _IncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<IncomingLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>An instance of IncomingLoanVw.</returns>
		public IncomingLoanVw IncomingLoanVwGetByMainWorkPlaceIdFirstOrDefault([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _IncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<IncomingLoanVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region InstallmentDecreaseOrderVw procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderVwList")]
		private ISingleResult<InstallmentDecreaseOrderVw> _InstallmentDecreaseOrderVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrderVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseOrderVw> InstallmentDecreaseOrderVwList()
		{
			return _InstallmentDecreaseOrderVwList().ToList<InstallmentDecreaseOrderVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentDecreaseOrderVwGet")]
		private ISingleResult<InstallmentDecreaseOrderVw> _InstallmentDecreaseOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrderVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null.</returns>
		public InstallmentDecreaseOrderVw InstallmentDecreaseOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<InstallmentDecreaseOrderVw> list = _InstallmentDecreaseOrderVwGet(_id).ToList<InstallmentDecreaseOrderVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.InstallmentDecreaseOrderVwGetChildren")]
        [ResultType(typeof(InstallmentDecreaseOrderVw))]
        [ResultType(typeof(InstallmentDecreaseVw))]
        private IMultipleResults _InstallmentDecreaseOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null.</returns>
		public InstallmentDecreaseOrderVw InstallmentDecreaseOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _InstallmentDecreaseOrderVwGetChildren(_id);
            InstallmentDecreaseOrderVw result = multipleResult.GetResult<InstallmentDecreaseOrderVw>().FirstOrDefault<InstallmentDecreaseOrderVw>();
            if (result == null) return null;
            result.InstallmentDecreaseVwList = multipleResult.GetResult<InstallmentDecreaseVw>().ToList<InstallmentDecreaseVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentDecreaseOrderVwGetByMonth")]
		private ISingleResult<InstallmentDecreaseOrderVw> _InstallmentDecreaseOrderVwGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseOrderVw> InstallmentDecreaseOrderVwGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			return _InstallmentDecreaseOrderVwGetByMonth(_month).ToList<InstallmentDecreaseOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		/// <returns>An instance of InstallmentDecreaseOrderVw.</returns>
		public InstallmentDecreaseOrderVw InstallmentDecreaseOrderVwGetByMonthFirstOrDefault([Parameter(Name = "@Month")] DateTime _month)
		{
			return _InstallmentDecreaseOrderVwGetByMonth(_month).ToList<InstallmentDecreaseOrderVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region InstallmentDecreaseVw procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentDecreaseVwList")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwList()
		{
			return _InstallmentDecreaseVwList().ToList<InstallmentDecreaseVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentDecreaseVwGet")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<InstallmentDecreaseVw> list = _InstallmentDecreaseVwGet(_id).ToList<InstallmentDecreaseVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return InstallmentDecreaseVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentDecreaseVwGetByDepartmentId")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] Nullable<int> _departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _departmentId);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] Nullable<int> _departmentId)
		{
			return _InstallmentDecreaseVwGetByDepartmentId(_departmentId).ToList<InstallmentDecreaseVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>An instance of InstallmentDecreaseVw.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGetByDepartmentIdFirstOrDefault([Parameter(Name = "@DepartmentId")] Nullable<int> _departmentId)
		{
			return _InstallmentDecreaseVwGetByDepartmentId(_departmentId).ToList<InstallmentDecreaseVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.InstallmentDecreaseVwGetByEmployeeId")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _InstallmentDecreaseVwGetByEmployeeId(_employeeId).ToList<InstallmentDecreaseVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of InstallmentDecreaseVw.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _InstallmentDecreaseVwGetByEmployeeId(_employeeId).ToList<InstallmentDecreaseVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrderId);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwGetByInstallmentDecreaseOrderId([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId)
		{
			return _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId(_installmentDecreaseOrderId).ToList<InstallmentDecreaseVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <returns>An instance of InstallmentDecreaseVw.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGetByInstallmentDecreaseOrderIdFirstOrDefault([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId)
		{
			return _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId(_installmentDecreaseOrderId).ToList<InstallmentDecreaseVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId")]
		private ISingleResult<InstallmentDecreaseVw> _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentDecreaseOrderId, _employeeId);
			return (result.ReturnValue as ISingleResult<InstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId_EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId(_installmentDecreaseOrderId, _employeeId).ToList<InstallmentDecreaseVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId_EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of InstallmentDecreaseVw.</returns>
		public InstallmentDecreaseVw InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeIdFirstOrDefault([Parameter(Name = "@InstallmentDecreaseOrderId")] int _installmentDecreaseOrderId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId(_installmentDecreaseOrderId, _employeeId).ToList<InstallmentDecreaseVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region InstallmentVw procedures.
		#region List procedure
		[Function(Name = "dbo.InstallmentVwList")]
		private ISingleResult<InstallmentVw> _InstallmentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InstallmentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InstallmentVw view.
		/// </summary>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentVw> InstallmentVwList()
		{
			return _InstallmentVwList().ToList<InstallmentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InstallmentVwGet")]
		private ISingleResult<InstallmentVw> _InstallmentVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InstallmentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		/// <returns>Gets an instance of InstallmentVw or null.</returns>
		public InstallmentVw InstallmentVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<InstallmentVw> list = _InstallmentVwGet(_id).ToList<InstallmentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.InstallmentVwGetChildren")]
        [ResultType(typeof(InstallmentVw))]
        [ResultType(typeof(SettlementVw))]
        private IMultipleResults _InstallmentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.InstallmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		/// <returns>Gets an instance of InstallmentVw or null.</returns>
		public InstallmentVw InstallmentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _InstallmentVwGetChildren(_id);
            InstallmentVw result = multipleResult.GetResult<InstallmentVw>().FirstOrDefault<InstallmentVw>();
            if (result == null) return null;
            result.SettlementVwList = multipleResult.GetResult<SettlementVw>().ToList<SettlementVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InstallmentVwGetByDueDate")]
		private ISingleResult<InstallmentVw> _InstallmentVwGetByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _dueDate);
			return (result.ReturnValue as ISingleResult<InstallmentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentVw> InstallmentVwGetByDueDate([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			return _InstallmentVwGetByDueDate(_dueDate).ToList<InstallmentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		/// <returns>An instance of InstallmentVw.</returns>
		public InstallmentVw InstallmentVwGetByDueDateFirstOrDefault([Parameter(Name = "@DueDate")] DateTime _dueDate)
		{
			return _InstallmentVwGetByDueDate(_dueDate).ToList<InstallmentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.InstallmentVwGetByRefundableProductProductId")]
		private ISingleResult<InstallmentVw> _InstallmentVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId);
			return (result.ReturnValue as ISingleResult<InstallmentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentVw> InstallmentVwGetByRefundableProductProductId([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _InstallmentVwGetByRefundableProductProductId(_refundableProductProductId).ToList<InstallmentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <returns>An instance of InstallmentVw.</returns>
		public InstallmentVw InstallmentVwGetByRefundableProductProductIdFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId)
		{
			return _InstallmentVwGetByRefundableProductProductId(_refundableProductProductId).ToList<InstallmentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.InstallmentVwGetByRefundableProductProductId_SubNumber")]
		private ISingleResult<InstallmentVw> _InstallmentVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _refundableProductProductId, _subNumber);
			return (result.ReturnValue as ISingleResult<InstallmentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InstallmentVw> InstallmentVwGetByRefundableProductProductId_SubNumber([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			return _InstallmentVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<InstallmentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		/// <returns>An instance of InstallmentVw.</returns>
		public InstallmentVw InstallmentVwGetByRefundableProductProductId_SubNumberFirstOrDefault([Parameter(Name = "@RefundableProductProductId")] int _refundableProductProductId, [Parameter(Name = "@SubNumber")] short _subNumber)
		{
			return _InstallmentVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber).ToList<InstallmentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region InsuranceTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.InsuranceTypeVwList")]
		private ISingleResult<InsuranceTypeVw> _InsuranceTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<InsuranceTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.InsuranceTypeVw view.
		/// </summary>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InsuranceTypeVw> InsuranceTypeVwList()
		{
			return _InsuranceTypeVwList().ToList<InsuranceTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.InsuranceTypeVwGet")]
		private ISingleResult<InsuranceTypeVw> _InsuranceTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<InsuranceTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null.</returns>
		public InsuranceTypeVw InsuranceTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<InsuranceTypeVw> list = _InsuranceTypeVwGet(_id).ToList<InsuranceTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.InsuranceTypeVwGetChildren")]
        [ResultType(typeof(InsuranceTypeVw))]
        [ResultType(typeof(HealthLoanDecisionFirstPaymentVw))]
        private IMultipleResults _InsuranceTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null.</returns>
		public InsuranceTypeVw InsuranceTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IMultipleResults multipleResult = _InsuranceTypeVwGetChildren(_id);
            InsuranceTypeVw result = multipleResult.GetResult<InsuranceTypeVw>().FirstOrDefault<InsuranceTypeVw>();
            if (result == null) return null;
            result.HealthLoanDecisionFirstPaymentVwList = multipleResult.GetResult<HealthLoanDecisionFirstPaymentVw>().ToList<HealthLoanDecisionFirstPaymentVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.InsuranceTypeVwGetByName")]
		private ISingleResult<InsuranceTypeVw> _InsuranceTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<InsuranceTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<InsuranceTypeVw> InsuranceTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _InsuranceTypeVwGetByName(_name).ToList<InsuranceTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		/// <returns>An instance of InsuranceTypeVw.</returns>
		public InsuranceTypeVw InsuranceTypeVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _InsuranceTypeVwGetByName(_name).ToList<InsuranceTypeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region IssuerVw procedures.
		#region List procedure
		[Function(Name = "dbo.IssuerVwList")]
		private ISingleResult<IssuerVw> _IssuerVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<IssuerVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.IssuerVw view.
		/// </summary>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IssuerVw> IssuerVwList()
		{
			return _IssuerVwList().ToList<IssuerVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.IssuerVwGet")]
		private ISingleResult<IssuerVw> _IssuerVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<IssuerVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.IssuerVw view.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of IssuerVw or null.</returns>
		public IssuerVw IssuerVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<IssuerVw> list = _IssuerVwGet(_id).ToList<IssuerVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.IssuerVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of IssuerVw or null.</returns>
		public IssuerVw IssuerVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return IssuerVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.IssuerVwGetByName")]
		private ISingleResult<IssuerVw> _IssuerVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<IssuerVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<IssuerVw> IssuerVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _IssuerVwGetByName(_name).ToList<IssuerVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		/// <returns>An instance of IssuerVw.</returns>
		public IssuerVw IssuerVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _IssuerVwGetByName(_name).ToList<IssuerVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanChangeVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanChangeVwList")]
		private ISingleResult<LoanChangeVw> _LoanChangeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanChangeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanChangeVw view.
		/// </summary>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanChangeVw> LoanChangeVwList()
		{
			return _LoanChangeVwList().ToList<LoanChangeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanChangeVwGet")]
		private ISingleResult<LoanChangeVw> _LoanChangeVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanProductId);
			return (result.ReturnValue as ISingleResult<LoanChangeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>Gets an instance of LoanChangeVw or null.</returns>
		public LoanChangeVw LoanChangeVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			List<LoanChangeVw> list = _LoanChangeVwGet(_loanProductId).ToList<LoanChangeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanChangeVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>Gets an instance of LoanChangeVw or null.</returns>
		public LoanChangeVw LoanChangeVwGetChildren([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
            return LoanChangeVwGet(_loanProductId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanChangeVwGetByFromLoanProductId")]
		private ISingleResult<LoanChangeVw> _LoanChangeVwGetByFromLoanProductId([Parameter(Name = "@FromLoanProductId")] int _fromLoanProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _fromLoanProductId);
			return (result.ReturnValue as ISingleResult<LoanChangeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanChangeVw> LoanChangeVwGetByFromLoanProductId([Parameter(Name = "@FromLoanProductId")] int _fromLoanProductId)
		{
			return _LoanChangeVwGetByFromLoanProductId(_fromLoanProductId).ToList<LoanChangeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		/// <returns>An instance of LoanChangeVw.</returns>
		public LoanChangeVw LoanChangeVwGetByFromLoanProductIdFirstOrDefault([Parameter(Name = "@FromLoanProductId")] int _fromLoanProductId)
		{
			return _LoanChangeVwGetByFromLoanProductId(_fromLoanProductId).ToList<LoanChangeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanChangeVwGetByLoanProductId")]
		private ISingleResult<LoanChangeVw> _LoanChangeVwGetByLoanProductId([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanProductId);
			return (result.ReturnValue as ISingleResult<LoanChangeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanChangeVw> LoanChangeVwGetByLoanProductId([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			return _LoanChangeVwGetByLoanProductId(_loanProductId).ToList<LoanChangeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>An instance of LoanChangeVw.</returns>
		public LoanChangeVw LoanChangeVwGetByLoanProductIdFirstOrDefault([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			return _LoanChangeVwGetByLoanProductId(_loanProductId).ToList<LoanChangeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanDecisionTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanDecisionTypeVwList")]
		private ISingleResult<LoanDecisionTypeVw> _LoanDecisionTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanDecisionTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionTypeVw> LoanDecisionTypeVwList()
		{
			return _LoanDecisionTypeVwList().ToList<LoanDecisionTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanDecisionTypeVwGet")]
		private ISingleResult<LoanDecisionTypeVw> _LoanDecisionTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanDecisionTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null.</returns>
		public LoanDecisionTypeVw LoanDecisionTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanDecisionTypeVw> list = _LoanDecisionTypeVwGet(_id).ToList<LoanDecisionTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null.</returns>
		public LoanDecisionTypeVw LoanDecisionTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return LoanDecisionTypeVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanDecisionTypeVwGetByName")]
		private ISingleResult<LoanDecisionTypeVw> _LoanDecisionTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanDecisionTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionTypeVw> LoanDecisionTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanDecisionTypeVwGetByName(_name).ToList<LoanDecisionTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		/// <returns>An instance of LoanDecisionTypeVw.</returns>
		public LoanDecisionTypeVw LoanDecisionTypeVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _LoanDecisionTypeVwGetByName(_name).ToList<LoanDecisionTypeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanDecisionVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanDecisionVwList")]
		private ISingleResult<LoanDecisionVw> _LoanDecisionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanDecisionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanDecisionVw view.
		/// </summary>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionVw> LoanDecisionVwList()
		{
			return _LoanDecisionVwList().ToList<LoanDecisionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanDecisionVwGet")]
		private ISingleResult<LoanDecisionVw> _LoanDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanDecisionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionVw or null.</returns>
		public LoanDecisionVw LoanDecisionVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<LoanDecisionVw> list = _LoanDecisionVwGet(_id).ToList<LoanDecisionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.LoanDecisionVwGetChildren")]
        [ResultType(typeof(LoanDecisionVw))]
        [ResultType(typeof(LoanVw))]
        [ResultType(typeof(OutgoingLoanVw))]
        private IMultipleResults _LoanDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionVw or null.</returns>
		public LoanDecisionVw LoanDecisionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _LoanDecisionVwGetChildren(_id);
            LoanDecisionVw result = multipleResult.GetResult<LoanDecisionVw>().FirstOrDefault<LoanDecisionVw>();
            if (result == null) return null;
            result.LoanVwList = multipleResult.GetResult<LoanVw>().ToList<LoanVw>();
            result.OutgoingLoanVwList = multipleResult.GetResult<OutgoingLoanVw>().ToList<OutgoingLoanVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanDecisionVwGetByNumber_Year")]
		private ISingleResult<LoanDecisionVw> _LoanDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _number, _year);
			return (result.ReturnValue as ISingleResult<LoanDecisionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDecisionVw> LoanDecisionVwGetByNumber_Year([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _LoanDecisionVwGetByNumber_Year(_number, _year).ToList<LoanDecisionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>An instance of LoanDecisionVw.</returns>
		public LoanDecisionVw LoanDecisionVwGetByNumber_YearFirstOrDefault([Parameter(Name = "@Number")] short _number, [Parameter(Name = "@Year")] short _year)
		{
			return _LoanDecisionVwGetByNumber_Year(_number, _year).ToList<LoanDecisionVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanDetailVwList")]
		private ISingleResult<LoanDetailVw> _LoanDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanDetailVw view.
		/// </summary>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDetailVw> LoanDetailVwList()
		{
			return _LoanDetailVwList().ToList<LoanDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanDetailVwGet")]
		private ISingleResult<LoanDetailVw> _LoanDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<LoanDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanDetailVw or null.</returns>
		public LoanDetailVw LoanDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<LoanDetailVw> list = _LoanDetailVwGet(_productId).ToList<LoanDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanDetailVwGetByLoanDecisionId")]
		private ISingleResult<LoanDetailVw> _LoanDetailVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecisionId);
			return (result.ReturnValue as ISingleResult<LoanDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDetailVw> LoanDetailVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _LoanDetailVwGetByLoanDecisionId(_loanDecisionId).ToList<LoanDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>An instance of LoanDetailVw.</returns>
		public LoanDetailVw LoanDetailVwGetByLoanDecisionIdFirstOrDefault([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _LoanDetailVwGetByLoanDecisionId(_loanDecisionId).ToList<LoanDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanDetailVwGetByLoanGenerationStatusId")]
		private ISingleResult<LoanDetailVw> _LoanDetailVwGetByLoanGenerationStatusId([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanGenerationStatusId);
			return (result.ReturnValue as ISingleResult<LoanDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDetailVw> LoanDetailVwGetByLoanGenerationStatusId([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			return _LoanDetailVwGetByLoanGenerationStatusId(_loanGenerationStatusId).ToList<LoanDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>An instance of LoanDetailVw.</returns>
		public LoanDetailVw LoanDetailVwGetByLoanGenerationStatusIdFirstOrDefault([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			return _LoanDetailVwGetByLoanGenerationStatusId(_loanGenerationStatusId).ToList<LoanDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanDetailVwGetByLoanStatusId")]
		private ISingleResult<LoanDetailVw> _LoanDetailVwGetByLoanStatusId([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanStatusId);
			return (result.ReturnValue as ISingleResult<LoanDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanDetailVw> LoanDetailVwGetByLoanStatusId([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			return _LoanDetailVwGetByLoanStatusId(_loanStatusId).ToList<LoanDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>An instance of LoanDetailVw.</returns>
		public LoanDetailVw LoanDetailVwGetByLoanStatusIdFirstOrDefault([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			return _LoanDetailVwGetByLoanStatusId(_loanStatusId).ToList<LoanDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanExtendedVw procedures.
		#endregion
        #region LoanGenerationStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanGenerationStatusVwList")]
		private ISingleResult<LoanGenerationStatusVw> _LoanGenerationStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanGenerationStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanGenerationStatusVw> LoanGenerationStatusVwList()
		{
			return _LoanGenerationStatusVwList().ToList<LoanGenerationStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanGenerationStatusVwGet")]
		private ISingleResult<LoanGenerationStatusVw> _LoanGenerationStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanGenerationStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null.</returns>
		public LoanGenerationStatusVw LoanGenerationStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanGenerationStatusVw> list = _LoanGenerationStatusVwGet(_id).ToList<LoanGenerationStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null.</returns>
		public LoanGenerationStatusVw LoanGenerationStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return LoanGenerationStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanGenerationStatusVwGetByName")]
		private ISingleResult<LoanGenerationStatusVw> _LoanGenerationStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanGenerationStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanGenerationStatusVw> LoanGenerationStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanGenerationStatusVwGetByName(_name).ToList<LoanGenerationStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		/// <returns>An instance of LoanGenerationStatusVw.</returns>
		public LoanGenerationStatusVw LoanGenerationStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _LoanGenerationStatusVwGetByName(_name).ToList<LoanGenerationStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanRequestVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanRequestVwList")]
		private ISingleResult<LoanRequestVw> _LoanRequestVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanRequestVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanRequestVw view.
		/// </summary>
		/// <returns>A list of LoanRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanRequestVw> LoanRequestVwList()
		{
			return _LoanRequestVwList().ToList<LoanRequestVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanRequestVwGet")]
		private ISingleResult<LoanRequestVw> _LoanRequestVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as ISingleResult<LoanRequestVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		/// <returns>Gets an instance of LoanRequestVw or null.</returns>
		public LoanRequestVw LoanRequestVwGet([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			List<LoanRequestVw> list = _LoanRequestVwGet(_requestProductId).ToList<LoanRequestVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.LoanRequestVwGetChildren")]
        [ResultType(typeof(LoanRequestVw))]
        [ResultType(typeof(ExceptionalAmountVw))]
        private IMultipleResults _LoanRequestVwGetChildren([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestProductId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		/// <returns>Gets an instance of LoanRequestVw or null.</returns>
		public LoanRequestVw LoanRequestVwGetChildren([Parameter(Name = "@RequestProductId")] int _requestProductId)
		{
			IMultipleResults multipleResult = _LoanRequestVwGetChildren(_requestProductId);
            LoanRequestVw result = multipleResult.GetResult<LoanRequestVw>().FirstOrDefault<LoanRequestVw>();
            if (result == null) return null;
            result.ExceptionalAmountVwList = multipleResult.GetResult<ExceptionalAmountVw>().ToList<ExceptionalAmountVw>();
            return result;
        }
        #endregion
		#endregion

        #region LoanStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanStatusVwList")]
		private ISingleResult<LoanStatusVw> _LoanStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanStatusVw view.
		/// </summary>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanStatusVw> LoanStatusVwList()
		{
			return _LoanStatusVwList().ToList<LoanStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanStatusVwGet")]
		private ISingleResult<LoanStatusVw> _LoanStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatusVw or null.</returns>
		public LoanStatusVw LoanStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<LoanStatusVw> list = _LoanStatusVwGet(_id).ToList<LoanStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatusVw or null.</returns>
		public LoanStatusVw LoanStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return LoanStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanStatusVwGetByName")]
		private ISingleResult<LoanStatusVw> _LoanStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<LoanStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanStatusVw> LoanStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _LoanStatusVwGetByName(_name).ToList<LoanStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		/// <returns>An instance of LoanStatusVw.</returns>
		public LoanStatusVw LoanStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _LoanStatusVwGetByName(_name).ToList<LoanStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanTypeClosureVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanTypeClosureVwList")]
		private ISingleResult<LoanTypeClosureVw> _LoanTypeClosureVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanTypeClosureVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosureVw> LoanTypeClosureVwList()
		{
			return _LoanTypeClosureVwList().ToList<LoanTypeClosureVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanTypeClosureVwGet")]
		private ISingleResult<LoanTypeClosureVw> _LoanTypeClosureVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<LoanTypeClosureVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null.</returns>
		public LoanTypeClosureVw LoanTypeClosureVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<LoanTypeClosureVw> list = _LoanTypeClosureVwGet(_id).ToList<LoanTypeClosureVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null.</returns>
		public LoanTypeClosureVw LoanTypeClosureVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return LoanTypeClosureVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanTypeClosureVwGetByClosingLoanTypeProductTypeId")]
		private ISingleResult<LoanTypeClosureVw> _LoanTypeClosureVwGetByClosingLoanTypeProductTypeId([Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _closingLoanTypeProductTypeId);
			return (result.ReturnValue as ISingleResult<LoanTypeClosureVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosureVw> LoanTypeClosureVwGetByClosingLoanTypeProductTypeId([Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByClosingLoanTypeProductTypeId(_closingLoanTypeProductTypeId).ToList<LoanTypeClosureVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>An instance of LoanTypeClosureVw.</returns>
		public LoanTypeClosureVw LoanTypeClosureVwGetByClosingLoanTypeProductTypeIdFirstOrDefault([Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByClosingLoanTypeProductTypeId(_closingLoanTypeProductTypeId).ToList<LoanTypeClosureVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanTypeClosureVwGetByLoanTypeProductTypeId")]
		private ISingleResult<LoanTypeClosureVw> _LoanTypeClosureVwGetByLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanTypeProductTypeId);
			return (result.ReturnValue as ISingleResult<LoanTypeClosureVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosureVw> LoanTypeClosureVwGetByLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId).ToList<LoanTypeClosureVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <returns>An instance of LoanTypeClosureVw.</returns>
		public LoanTypeClosureVw LoanTypeClosureVwGetByLoanTypeProductTypeIdFirstOrDefault([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId).ToList<LoanTypeClosureVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId")]
		private ISingleResult<LoanTypeClosureVw> _LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId, [Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanTypeProductTypeId, _closingLoanTypeProductTypeId);
			return (result.ReturnValue as ISingleResult<LoanTypeClosureVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId_ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeClosureVw> LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId, [Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(_loanTypeProductTypeId, _closingLoanTypeProductTypeId).ToList<LoanTypeClosureVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId_ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>An instance of LoanTypeClosureVw.</returns>
		public LoanTypeClosureVw LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeIdFirstOrDefault([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId, [Parameter(Name = "@ClosingLoanTypeProductTypeId")] short _closingLoanTypeProductTypeId)
		{
			return _LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(_loanTypeProductTypeId, _closingLoanTypeProductTypeId).ToList<LoanTypeClosureVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region LoanTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanTypeVwList")]
		private ISingleResult<LoanTypeVw> _LoanTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanTypeVw view.
		/// </summary>
		/// <returns>A list of LoanTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanTypeVw> LoanTypeVwList()
		{
			return _LoanTypeVwList().ToList<LoanTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanTypeVwGet")]
		private ISingleResult<LoanTypeVw> _LoanTypeVwGet([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId);
			return (result.ReturnValue as ISingleResult<LoanTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanTypeVw view.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		/// <returns>Gets an instance of LoanTypeVw or null.</returns>
		public LoanTypeVw LoanTypeVwGet([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			List<LoanTypeVw> list = _LoanTypeVwGet(_productTypeId).ToList<LoanTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.LoanTypeVwGetChildren")]
        [ResultType(typeof(LoanTypeVw))]
        [ResultType(typeof(LoanTypeClosureVw))]
        [ResultType(typeof(LoanTypeClosureVw))]
        private IMultipleResults _LoanTypeVwGetChildren([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		/// <returns>Gets an instance of LoanTypeVw or null.</returns>
		public LoanTypeVw LoanTypeVwGetChildren([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IMultipleResults multipleResult = _LoanTypeVwGetChildren(_productTypeId);
            LoanTypeVw result = multipleResult.GetResult<LoanTypeVw>().FirstOrDefault<LoanTypeVw>();
            if (result == null) return null;
            result.ClosingLoanTypeClosureVwList = multipleResult.GetResult<LoanTypeClosureVw>().ToList<LoanTypeClosureVw>();
            result.LoanTypeClosureVwList = multipleResult.GetResult<LoanTypeClosureVw>().ToList<LoanTypeClosureVw>();
            return result;
        }
        #endregion
		#endregion

        #region LoanVw procedures.
		#region List procedure
		[Function(Name = "dbo.LoanVwList")]
		private ISingleResult<LoanVw> _LoanVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<LoanVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.LoanVw view.
		/// </summary>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanVw> LoanVwList()
		{
			return _LoanVwList().ToList<LoanVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.LoanVwGet")]
		private ISingleResult<LoanVw> _LoanVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<LoanVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanVw or null.</returns>
		public LoanVw LoanVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<LoanVw> list = _LoanVwGet(_productId).ToList<LoanVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.LoanVwGetChildren")]
        [ResultType(typeof(LoanVw))]
        [ResultType(typeof(IncomingLoanVw))]
        [ResultType(typeof(LoanChangeVw))]
        [ResultType(typeof(LoanChangeVw))]
        [ResultType(typeof(OutgoingLoanVw))]
        private IMultipleResults _LoanVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.LoanVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanVw or null.</returns>
		public LoanVw LoanVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IMultipleResults multipleResult = _LoanVwGetChildren(_productId);
            LoanVw result = multipleResult.GetResult<LoanVw>().FirstOrDefault<LoanVw>();
            if (result == null) return null;
            result.IncomingLoanVw = multipleResult.GetResult<IncomingLoanVw>().FirstOrDefault<IncomingLoanVw>();
            result.LoanChangeVw = multipleResult.GetResult<LoanChangeVw>().FirstOrDefault<LoanChangeVw>();
            result.FromLoanChangeVwList = multipleResult.GetResult<LoanChangeVw>().ToList<LoanChangeVw>();
            result.OutgoingLoanVw = multipleResult.GetResult<OutgoingLoanVw>().FirstOrDefault<OutgoingLoanVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.LoanVwGetByLoanDecisionId")]
		private ISingleResult<LoanVw> _LoanVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecisionId);
			return (result.ReturnValue as ISingleResult<LoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanVw> LoanVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _LoanVwGetByLoanDecisionId(_loanDecisionId).ToList<LoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>An instance of LoanVw.</returns>
		public LoanVw LoanVwGetByLoanDecisionIdFirstOrDefault([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _LoanVwGetByLoanDecisionId(_loanDecisionId).ToList<LoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanVwGetByLoanGenerationStatusId")]
		private ISingleResult<LoanVw> _LoanVwGetByLoanGenerationStatusId([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanGenerationStatusId);
			return (result.ReturnValue as ISingleResult<LoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanVw> LoanVwGetByLoanGenerationStatusId([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			return _LoanVwGetByLoanGenerationStatusId(_loanGenerationStatusId).ToList<LoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>An instance of LoanVw.</returns>
		public LoanVw LoanVwGetByLoanGenerationStatusIdFirstOrDefault([Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
		{
			return _LoanVwGetByLoanGenerationStatusId(_loanGenerationStatusId).ToList<LoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.LoanVwGetByLoanStatusId")]
		private ISingleResult<LoanVw> _LoanVwGetByLoanStatusId([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanStatusId);
			return (result.ReturnValue as ISingleResult<LoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<LoanVw> LoanVwGetByLoanStatusId([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			return _LoanVwGetByLoanStatusId(_loanStatusId).ToList<LoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>An instance of LoanVw.</returns>
		public LoanVw LoanVwGetByLoanStatusIdFirstOrDefault([Parameter(Name = "@LoanStatusId")] byte _loanStatusId)
		{
			return _LoanVwGetByLoanStatusId(_loanStatusId).ToList<LoanVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region MainWorkPlaceVw procedures.
		#region List procedure
		[Function(Name = "dbo.MainWorkPlaceVwList")]
		private ISingleResult<MainWorkPlaceVw> _MainWorkPlaceVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MainWorkPlaceVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MainWorkPlaceVw> MainWorkPlaceVwList()
		{
			return _MainWorkPlaceVwList().ToList<MainWorkPlaceVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MainWorkPlaceVwGet")]
		private ISingleResult<MainWorkPlaceVw> _MainWorkPlaceVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<MainWorkPlaceVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null.</returns>
		public MainWorkPlaceVw MainWorkPlaceVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<MainWorkPlaceVw> list = _MainWorkPlaceVwGet(_id).ToList<MainWorkPlaceVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.MainWorkPlaceVwGetChildren")]
        [ResultType(typeof(MainWorkPlaceVw))]
        [ResultType(typeof(SalaryWorkPlaceVw))]
        private IMultipleResults _MainWorkPlaceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null.</returns>
		public MainWorkPlaceVw MainWorkPlaceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _MainWorkPlaceVwGetChildren(_id);
            MainWorkPlaceVw result = multipleResult.GetResult<MainWorkPlaceVw>().FirstOrDefault<MainWorkPlaceVw>();
            if (result == null) return null;
            result.SalaryWorkPlaceVwList = multipleResult.GetResult<SalaryWorkPlaceVw>().ToList<SalaryWorkPlaceVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.MainWorkPlaceVwGetByName")]
		private ISingleResult<MainWorkPlaceVw> _MainWorkPlaceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<MainWorkPlaceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MainWorkPlaceVw> MainWorkPlaceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _MainWorkPlaceVwGetByName(_name).ToList<MainWorkPlaceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		/// <returns>An instance of MainWorkPlaceVw.</returns>
		public MainWorkPlaceVw MainWorkPlaceVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _MainWorkPlaceVwGetByName(_name).ToList<MainWorkPlaceVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region MissingInstallmentDecreaseVw procedures.
		#region List procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseVwList")]
		private ISingleResult<MissingInstallmentDecreaseVw> _MissingInstallmentDecreaseVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MissingInstallmentDecreaseVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		/// <returns>A list of MissingInstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MissingInstallmentDecreaseVw> MissingInstallmentDecreaseVwList()
		{
			return _MissingInstallmentDecreaseVwList().ToList<MissingInstallmentDecreaseVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MissingInstallmentDecreaseVwGet")]
		private ISingleResult<MissingInstallmentDecreaseVw> _MissingInstallmentDecreaseVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<MissingInstallmentDecreaseVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null.</returns>
		public MissingInstallmentDecreaseVw MissingInstallmentDecreaseVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			List<MissingInstallmentDecreaseVw> list = _MissingInstallmentDecreaseVwGet(_employeeId).ToList<MissingInstallmentDecreaseVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null.</returns>
		public MissingInstallmentDecreaseVw MissingInstallmentDecreaseVwGetChildren([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
            return MissingInstallmentDecreaseVwGet(_employeeId);
        }
        #endregion
		#endregion

        #region MonthlyBalanceVw procedures.
		#region List procedure
		[Function(Name = "dbo.MonthlyBalanceVwList")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceVw> MonthlyBalanceVwList()
		{
			return _MonthlyBalanceVwList().ToList<MonthlyBalanceVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.MonthlyBalanceVwGet")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<MonthlyBalanceVw> list = _MonthlyBalanceVwGet(_id).ToList<MonthlyBalanceVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return MonthlyBalanceVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.MonthlyBalanceVwGetByEmployeeId")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceVw> MonthlyBalanceVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _MonthlyBalanceVwGetByEmployeeId(_employeeId).ToList<MonthlyBalanceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of MonthlyBalanceVw.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _MonthlyBalanceVwGetByEmployeeId(_employeeId).ToList<MonthlyBalanceVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId, [Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _paymentGroupId, _month);
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentGroupId_Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceVw> MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId, [Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month(_employeeId, _paymentGroupId, _month).ToList<MonthlyBalanceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentGroupId_Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		/// <returns>An instance of MonthlyBalanceVw.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_MonthFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId, [Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month(_employeeId, _paymentGroupId, _month).ToList<MonthlyBalanceVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.MonthlyBalanceVwGetByMonth")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _month);
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceVw> MonthlyBalanceVwGetByMonth([Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceVwGetByMonth(_month).ToList<MonthlyBalanceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		/// <returns>An instance of MonthlyBalanceVw.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGetByMonthFirstOrDefault([Parameter(Name = "@Month")] DateTime _month)
		{
			return _MonthlyBalanceVwGetByMonth(_month).ToList<MonthlyBalanceVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.MonthlyBalanceVwGetByPaymentGroupId")]
		private ISingleResult<MonthlyBalanceVw> _MonthlyBalanceVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<MonthlyBalanceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<MonthlyBalanceVw> MonthlyBalanceVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _MonthlyBalanceVwGetByPaymentGroupId(_paymentGroupId).ToList<MonthlyBalanceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>An instance of MonthlyBalanceVw.</returns>
		public MonthlyBalanceVw MonthlyBalanceVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _MonthlyBalanceVwGetByPaymentGroupId(_paymentGroupId).ToList<MonthlyBalanceVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region OutgoingLoanVw procedures.
		#region List procedure
		[Function(Name = "dbo.OutgoingLoanVwList")]
		private ISingleResult<OutgoingLoanVw> _OutgoingLoanVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<OutgoingLoanVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.OutgoingLoanVw view.
		/// </summary>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoanVw> OutgoingLoanVwList()
		{
			return _OutgoingLoanVwList().ToList<OutgoingLoanVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.OutgoingLoanVwGet")]
		private ISingleResult<OutgoingLoanVw> _OutgoingLoanVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanProductId);
			return (result.ReturnValue as ISingleResult<OutgoingLoanVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null.</returns>
		public OutgoingLoanVw OutgoingLoanVwGet([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
			List<OutgoingLoanVw> list = _OutgoingLoanVwGet(_loanProductId).ToList<OutgoingLoanVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null.</returns>
		public OutgoingLoanVw OutgoingLoanVwGetChildren([Parameter(Name = "@LoanProductId")] int _loanProductId)
		{
            return OutgoingLoanVwGet(_loanProductId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.OutgoingLoanVwGetByLoanDecisionId")]
		private ISingleResult<OutgoingLoanVw> _OutgoingLoanVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanDecisionId);
			return (result.ReturnValue as ISingleResult<OutgoingLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoanVw> OutgoingLoanVwGetByLoanDecisionId([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _OutgoingLoanVwGetByLoanDecisionId(_loanDecisionId).ToList<OutgoingLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		/// <returns>An instance of OutgoingLoanVw.</returns>
		public OutgoingLoanVw OutgoingLoanVwGetByLoanDecisionIdFirstOrDefault([Parameter(Name = "@LoanDecisionId")] int _loanDecisionId)
		{
			return _OutgoingLoanVwGetByLoanDecisionId(_loanDecisionId).ToList<OutgoingLoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.OutgoingLoanVwGetByMainWorkPlaceId")]
		private ISingleResult<OutgoingLoanVw> _OutgoingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlaceId);
			return (result.ReturnValue as ISingleResult<OutgoingLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<OutgoingLoanVw> OutgoingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _OutgoingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<OutgoingLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		/// <returns>An instance of OutgoingLoanVw.</returns>
		public OutgoingLoanVw OutgoingLoanVwGetByMainWorkPlaceIdFirstOrDefault([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _OutgoingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<OutgoingLoanVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region PaymentDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentDetailVwList")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentDetailVw view.
		/// </summary>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwList()
		{
			return _PaymentDetailVwList().ToList<PaymentDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentDetailVwGet")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentDetailVw or null.</returns>
		public PaymentDetailVw PaymentDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<PaymentDetailVw> list = _PaymentDetailVwGet(_id).ToList<PaymentDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PaymentDetailVwGetByCollectOrderId")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGetByCollectOrderId([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _collectOrderId);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwGetByCollectOrderId([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			return _PaymentDetailVwGetByCollectOrderId(_collectOrderId).ToList<PaymentDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>An instance of PaymentDetailVw.</returns>
		public PaymentDetailVw PaymentDetailVwGetByCollectOrderIdFirstOrDefault([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			return _PaymentDetailVwGetByCollectOrderId(_collectOrderId).ToList<PaymentDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentDetailVwGetByDate")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PaymentDetailVwGetByDate(_date).ToList<PaymentDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>An instance of PaymentDetailVw.</returns>
		public PaymentDetailVw PaymentDetailVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PaymentDetailVwGetByDate(_date).ToList<PaymentDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentDetailVwGetByEmployeeId")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PaymentDetailVwGetByEmployeeId(_employeeId).ToList<PaymentDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of PaymentDetailVw.</returns>
		public PaymentDetailVw PaymentDetailVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PaymentDetailVwGetByEmployeeId(_employeeId).ToList<PaymentDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentDetailVwGetByPaymentGroupId")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PaymentDetailVwGetByPaymentGroupId(_paymentGroupId).ToList<PaymentDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>An instance of PaymentDetailVw.</returns>
		public PaymentDetailVw PaymentDetailVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PaymentDetailVwGetByPaymentGroupId(_paymentGroupId).ToList<PaymentDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentDetailVwGetByPaymentStatusId")]
		private ISingleResult<PaymentDetailVw> _PaymentDetailVwGetByPaymentStatusId([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatusId);
			return (result.ReturnValue as ISingleResult<PaymentDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentDetailVw> PaymentDetailVwGetByPaymentStatusId([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			return _PaymentDetailVwGetByPaymentStatusId(_paymentStatusId).ToList<PaymentDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>An instance of PaymentDetailVw.</returns>
		public PaymentDetailVw PaymentDetailVwGetByPaymentStatusIdFirstOrDefault([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			return _PaymentDetailVwGetByPaymentStatusId(_paymentStatusId).ToList<PaymentDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region PaymentGroupVw procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentGroupVwList")]
		private ISingleResult<PaymentGroupVw> _PaymentGroupVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentGroupVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentGroupVw view.
		/// </summary>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentGroupVw> PaymentGroupVwList()
		{
			return _PaymentGroupVwList().ToList<PaymentGroupVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentGroupVwGet")]
		private ISingleResult<PaymentGroupVw> _PaymentGroupVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentGroupVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroupVw or null.</returns>
		public PaymentGroupVw PaymentGroupVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<PaymentGroupVw> list = _PaymentGroupVwGet(_id).ToList<PaymentGroupVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.PaymentGroupVwGetChildren")]
        [ResultType(typeof(PaymentGroupVw))]
        [ResultType(typeof(ProductTypeVw))]
        private IMultipleResults _PaymentGroupVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroupVw or null.</returns>
		public PaymentGroupVw PaymentGroupVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IMultipleResults multipleResult = _PaymentGroupVwGetChildren(_id);
            PaymentGroupVw result = multipleResult.GetResult<PaymentGroupVw>().FirstOrDefault<PaymentGroupVw>();
            if (result == null) return null;
            result.ProductTypeVwList = multipleResult.GetResult<ProductTypeVw>().ToList<ProductTypeVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PaymentGroupVwGetByName")]
		private ISingleResult<PaymentGroupVw> _PaymentGroupVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<PaymentGroupVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentGroupVw> PaymentGroupVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _PaymentGroupVwGetByName(_name).ToList<PaymentGroupVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		/// <returns>An instance of PaymentGroupVw.</returns>
		public PaymentGroupVw PaymentGroupVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _PaymentGroupVwGetByName(_name).ToList<PaymentGroupVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region PaymentStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentStatusVwList")]
		private ISingleResult<PaymentStatusVw> _PaymentStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentStatusVw view.
		/// </summary>
		/// <returns>A list of PaymentStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentStatusVw> PaymentStatusVwList()
		{
			return _PaymentStatusVwList().ToList<PaymentStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentStatusVwGet")]
		private ISingleResult<PaymentStatusVw> _PaymentStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		/// <returns>Gets an instance of PaymentStatusVw or null.</returns>
		public PaymentStatusVw PaymentStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<PaymentStatusVw> list = _PaymentStatusVwGet(_id).ToList<PaymentStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		/// <returns>Gets an instance of PaymentStatusVw or null.</returns>
		public PaymentStatusVw PaymentStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return PaymentStatusVwGet(_id);
        }
        #endregion
		#endregion

        #region PaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.PaymentVwList")]
		private ISingleResult<PaymentVw> _PaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PaymentVw view.
		/// </summary>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwList()
		{
			return _PaymentVwList().ToList<PaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PaymentVwGet")]
		private ISingleResult<PaymentVw> _PaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentVw or null.</returns>
		public PaymentVw PaymentVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<PaymentVw> list = _PaymentVwGet(_id).ToList<PaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.PaymentVwGetChildren")]
        [ResultType(typeof(PaymentVw))]
        [ResultType(typeof(CashPaymentVw))]
        [ResultType(typeof(DownPaymentVw))]
        [ResultType(typeof(SalaryPaymentVw))]
        [ResultType(typeof(SettlementVw))]
        private IMultipleResults _PaymentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.PaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentVw or null.</returns>
		public PaymentVw PaymentVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _PaymentVwGetChildren(_id);
            PaymentVw result = multipleResult.GetResult<PaymentVw>().FirstOrDefault<PaymentVw>();
            if (result == null) return null;
            result.CashPaymentVw = multipleResult.GetResult<CashPaymentVw>().FirstOrDefault<CashPaymentVw>();
            result.DownPaymentVw = multipleResult.GetResult<DownPaymentVw>().FirstOrDefault<DownPaymentVw>();
            result.SalaryPaymentVw = multipleResult.GetResult<SalaryPaymentVw>().FirstOrDefault<SalaryPaymentVw>();
            result.SettlementVwList = multipleResult.GetResult<SettlementVw>().ToList<SettlementVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PaymentVwGetByCollectOrderId")]
		private ISingleResult<PaymentVw> _PaymentVwGetByCollectOrderId([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _collectOrderId);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwGetByCollectOrderId([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			return _PaymentVwGetByCollectOrderId(_collectOrderId).ToList<PaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>An instance of PaymentVw.</returns>
		public PaymentVw PaymentVwGetByCollectOrderIdFirstOrDefault([Parameter(Name = "@CollectOrderId")] Nullable<int> _collectOrderId)
		{
			return _PaymentVwGetByCollectOrderId(_collectOrderId).ToList<PaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentVwGetByDate")]
		private ISingleResult<PaymentVw> _PaymentVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PaymentVwGetByDate(_date).ToList<PaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>An instance of PaymentVw.</returns>
		public PaymentVw PaymentVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PaymentVwGetByDate(_date).ToList<PaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentVwGetByEmployeeId")]
		private ISingleResult<PaymentVw> _PaymentVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PaymentVwGetByEmployeeId(_employeeId).ToList<PaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of PaymentVw.</returns>
		public PaymentVw PaymentVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PaymentVwGetByEmployeeId(_employeeId).ToList<PaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentVwGetByPaymentGroupId")]
		private ISingleResult<PaymentVw> _PaymentVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PaymentVwGetByPaymentGroupId(_paymentGroupId).ToList<PaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>An instance of PaymentVw.</returns>
		public PaymentVw PaymentVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PaymentVwGetByPaymentGroupId(_paymentGroupId).ToList<PaymentVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PaymentVwGetByPaymentStatusId")]
		private ISingleResult<PaymentVw> _PaymentVwGetByPaymentStatusId([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentStatusId);
			return (result.ReturnValue as ISingleResult<PaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PaymentVw> PaymentVwGetByPaymentStatusId([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			return _PaymentVwGetByPaymentStatusId(_paymentStatusId).ToList<PaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>An instance of PaymentVw.</returns>
		public PaymentVw PaymentVwGetByPaymentStatusIdFirstOrDefault([Parameter(Name = "@PaymentStatusId")] Nullable<byte> _paymentStatusId)
		{
			return _PaymentVwGetByPaymentStatusId(_paymentStatusId).ToList<PaymentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region PayOrderVw procedures.
		#region List procedure
		[Function(Name = "dbo.PayOrderVwList")]
		private ISingleResult<PayOrderVw> _PayOrderVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.PayOrderVw view.
		/// </summary>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrderVw> PayOrderVwList()
		{
			return _PayOrderVwList().ToList<PayOrderVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.PayOrderVwGet")]
		private ISingleResult<PayOrderVw> _PayOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		/// <returns>Gets an instance of PayOrderVw or null.</returns>
		public PayOrderVw PayOrderVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<PayOrderVw> list = _PayOrderVwGet(_id).ToList<PayOrderVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.PayOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		/// <returns>Gets an instance of PayOrderVw or null.</returns>
		public PayOrderVw PayOrderVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return PayOrderVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.PayOrderVwGetByDate")]
		private ISingleResult<PayOrderVw> _PayOrderVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrderVw> PayOrderVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PayOrderVwGetByDate(_date).ToList<PayOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		/// <returns>An instance of PayOrderVw.</returns>
		public PayOrderVw PayOrderVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _PayOrderVwGetByDate(_date).ToList<PayOrderVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PayOrderVwGetByEmployeeId")]
		private ISingleResult<PayOrderVw> _PayOrderVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrderVw> PayOrderVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PayOrderVwGetByEmployeeId(_employeeId).ToList<PayOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of PayOrderVw.</returns>
		public PayOrderVw PayOrderVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _PayOrderVwGetByEmployeeId(_employeeId).ToList<PayOrderVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PayOrderVwGetByIsFixed")]
		private ISingleResult<PayOrderVw> _PayOrderVwGetByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrderVw> PayOrderVwGetByIsFixed([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			return _PayOrderVwGetByIsFixed(_isFixed).ToList<PayOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		/// <returns>An instance of PayOrderVw.</returns>
		public PayOrderVw PayOrderVwGetByIsFixedFirstOrDefault([Parameter(Name = "@IsFixed")] byte _isFixed)
		{
			return _PayOrderVwGetByIsFixed(_isFixed).ToList<PayOrderVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.PayOrderVwGetByPaymentGroupId")]
		private ISingleResult<PayOrderVw> _PayOrderVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<PayOrderVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<PayOrderVw> PayOrderVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PayOrderVwGetByPaymentGroupId(_paymentGroupId).ToList<PayOrderVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>An instance of PayOrderVw.</returns>
		public PayOrderVw PayOrderVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] byte _paymentGroupId)
		{
			return _PayOrderVwGetByPaymentGroupId(_paymentGroupId).ToList<PayOrderVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProductDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProductDetailVwList")]
		private ISingleResult<ProductDetailVw> _ProductDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductDetailVw view.
		/// </summary>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductDetailVw> ProductDetailVwList()
		{
			return _ProductDetailVwList().ToList<ProductDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductDetailVwGet")]
		private ISingleResult<ProductDetailVw> _ProductDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductDetailVw or null.</returns>
		public ProductDetailVw ProductDetailVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ProductDetailVw> list = _ProductDetailVwGet(_id).ToList<ProductDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductDetailVwGetByEmployeeId")]
		private ISingleResult<ProductDetailVw> _ProductDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<ProductDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductDetailVw> ProductDetailVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ProductDetailVwGetByEmployeeId(_employeeId).ToList<ProductDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of ProductDetailVw.</returns>
		public ProductDetailVw ProductDetailVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ProductDetailVwGetByEmployeeId(_employeeId).ToList<ProductDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductDetailVwGetByProductTypeId")]
		private ISingleResult<ProductDetailVw> _ProductDetailVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId);
			return (result.ReturnValue as ISingleResult<ProductDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductDetailVw> ProductDetailVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductDetailVwGetByProductTypeId(_productTypeId).ToList<ProductDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>An instance of ProductDetailVw.</returns>
		public ProductDetailVw ProductDetailVwGetByProductTypeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductDetailVwGetByProductTypeId(_productTypeId).ToList<ProductDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProductTypeAvailabilityVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProductTypeAvailabilityVwList")]
		private ISingleResult<ProductTypeAvailabilityVw> _ProductTypeAvailabilityVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductTypeAvailabilityVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwList()
		{
			return _ProductTypeAvailabilityVwList().ToList<ProductTypeAvailabilityVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductTypeAvailabilityVwGet")]
		private ISingleResult<ProductTypeAvailabilityVw> _ProductTypeAvailabilityVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailabilityVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null.</returns>
		public ProductTypeAvailabilityVw ProductTypeAvailabilityVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ProductTypeAvailabilityVw> list = _ProductTypeAvailabilityVwGet(_id).ToList<ProductTypeAvailabilityVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null.</returns>
		public ProductTypeAvailabilityVw ProductTypeAvailabilityVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return ProductTypeAvailabilityVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductTypeAvailabilityVwGetByAvailabilityId")]
		private ISingleResult<ProductTypeAvailabilityVw> _ProductTypeAvailabilityVwGetByAvailabilityId([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _availabilityId);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailabilityVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwGetByAvailabilityId([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _ProductTypeAvailabilityVwGetByAvailabilityId(_availabilityId).ToList<ProductTypeAvailabilityVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>An instance of ProductTypeAvailabilityVw.</returns>
		public ProductTypeAvailabilityVw ProductTypeAvailabilityVwGetByAvailabilityIdFirstOrDefault([Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _ProductTypeAvailabilityVwGetByAvailabilityId(_availabilityId).ToList<ProductTypeAvailabilityVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeAvailabilityVwGetByProductTypeId")]
		private ISingleResult<ProductTypeAvailabilityVw> _ProductTypeAvailabilityVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailabilityVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductTypeAvailabilityVwGetByProductTypeId(_productTypeId).ToList<ProductTypeAvailabilityVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>An instance of ProductTypeAvailabilityVw.</returns>
		public ProductTypeAvailabilityVw ProductTypeAvailabilityVwGetByProductTypeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductTypeAvailabilityVwGetByProductTypeId(_productTypeId).ToList<ProductTypeAvailabilityVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId")]
		private ISingleResult<ProductTypeAvailabilityVw> _ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId([Parameter(Name = "@ProductTypeId")] short _productTypeId, [Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId, _availabilityId);
			return (result.ReturnValue as ISingleResult<ProductTypeAvailabilityVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId_AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId([Parameter(Name = "@ProductTypeId")] short _productTypeId, [Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId(_productTypeId, _availabilityId).ToList<ProductTypeAvailabilityVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId_AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>An instance of ProductTypeAvailabilityVw.</returns>
		public ProductTypeAvailabilityVw ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] short _productTypeId, [Parameter(Name = "@AvailabilityId")] short _availabilityId)
		{
			return _ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId(_productTypeId, _availabilityId).ToList<ProductTypeAvailabilityVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProductTypeDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProductTypeDetailVwList")]
		private ISingleResult<ProductTypeDetailVw> _ProductTypeDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductTypeDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeDetailVw> ProductTypeDetailVwList()
		{
			return _ProductTypeDetailVwList().ToList<ProductTypeDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductTypeDetailVwGet")]
		private ISingleResult<ProductTypeDetailVw> _ProductTypeDetailVwGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductTypeDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeDetailVw or null.</returns>
		public ProductTypeDetailVw ProductTypeDetailVwGet([Parameter(Name = "@Id")] short _id)
		{
			List<ProductTypeDetailVw> list = _ProductTypeDetailVwGet(_id).ToList<ProductTypeDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductTypeDetailVwGetByName")]
		private ISingleResult<ProductTypeDetailVw> _ProductTypeDetailVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<ProductTypeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeDetailVw> ProductTypeDetailVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _ProductTypeDetailVwGetByName(_name).ToList<ProductTypeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>An instance of ProductTypeDetailVw.</returns>
		public ProductTypeDetailVw ProductTypeDetailVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _ProductTypeDetailVwGetByName(_name).ToList<ProductTypeDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeDetailVwGetByPaymentGroupId")]
		private ISingleResult<ProductTypeDetailVw> _ProductTypeDetailVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<ProductTypeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeDetailVw> ProductTypeDetailVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			return _ProductTypeDetailVwGetByPaymentGroupId(_paymentGroupId).ToList<ProductTypeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>An instance of ProductTypeDetailVw.</returns>
		public ProductTypeDetailVw ProductTypeDetailVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			return _ProductTypeDetailVwGetByPaymentGroupId(_paymentGroupId).ToList<ProductTypeDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeDetailVwGetByProfitStrategyId")]
		private ISingleResult<ProductTypeDetailVw> _ProductTypeDetailVwGetByProfitStrategyId([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _profitStrategyId);
			return (result.ReturnValue as ISingleResult<ProductTypeDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeDetailVw> ProductTypeDetailVwGetByProfitStrategyId([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			return _ProductTypeDetailVwGetByProfitStrategyId(_profitStrategyId).ToList<ProductTypeDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>An instance of ProductTypeDetailVw.</returns>
		public ProductTypeDetailVw ProductTypeDetailVwGetByProfitStrategyIdFirstOrDefault([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			return _ProductTypeDetailVwGetByProfitStrategyId(_profitStrategyId).ToList<ProductTypeDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProductTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProductTypeVwList")]
		private ISingleResult<ProductTypeVw> _ProductTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductTypeVw view.
		/// </summary>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeVw> ProductTypeVwList()
		{
			return _ProductTypeVwList().ToList<ProductTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductTypeVwGet")]
		private ISingleResult<ProductTypeVw> _ProductTypeVwGet([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeVw or null.</returns>
		public ProductTypeVw ProductTypeVwGet([Parameter(Name = "@Id")] short _id)
		{
			List<ProductTypeVw> list = _ProductTypeVwGet(_id).ToList<ProductTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.ProductTypeVwGetChildren")]
        [ResultType(typeof(ProductTypeVw))]
        [ResultType(typeof(LoanTypeVw))]
        [ResultType(typeof(ProductTypeAvailabilityVw))]
        private IMultipleResults _ProductTypeVwGetChildren([Parameter(Name = "@Id")] short _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeVw or null.</returns>
		public ProductTypeVw ProductTypeVwGetChildren([Parameter(Name = "@Id")] short _id)
		{
			IMultipleResults multipleResult = _ProductTypeVwGetChildren(_id);
            ProductTypeVw result = multipleResult.GetResult<ProductTypeVw>().FirstOrDefault<ProductTypeVw>();
            if (result == null) return null;
            result.LoanTypeVw = multipleResult.GetResult<LoanTypeVw>().FirstOrDefault<LoanTypeVw>();
            result.ProductTypeAvailabilityVwList = multipleResult.GetResult<ProductTypeAvailabilityVw>().ToList<ProductTypeAvailabilityVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductTypeVwGetByName")]
		private ISingleResult<ProductTypeVw> _ProductTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<ProductTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeVw> ProductTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _ProductTypeVwGetByName(_name).ToList<ProductTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>An instance of ProductTypeVw.</returns>
		public ProductTypeVw ProductTypeVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _ProductTypeVwGetByName(_name).ToList<ProductTypeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeVwGetByPaymentGroupId")]
		private ISingleResult<ProductTypeVw> _ProductTypeVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentGroupId);
			return (result.ReturnValue as ISingleResult<ProductTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeVw> ProductTypeVwGetByPaymentGroupId([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			return _ProductTypeVwGetByPaymentGroupId(_paymentGroupId).ToList<ProductTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>An instance of ProductTypeVw.</returns>
		public ProductTypeVw ProductTypeVwGetByPaymentGroupIdFirstOrDefault([Parameter(Name = "@PaymentGroupId")] Nullable<byte> _paymentGroupId)
		{
			return _ProductTypeVwGetByPaymentGroupId(_paymentGroupId).ToList<ProductTypeVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductTypeVwGetByProfitStrategyId")]
		private ISingleResult<ProductTypeVw> _ProductTypeVwGetByProfitStrategyId([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _profitStrategyId);
			return (result.ReturnValue as ISingleResult<ProductTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductTypeVw> ProductTypeVwGetByProfitStrategyId([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			return _ProductTypeVwGetByProfitStrategyId(_profitStrategyId).ToList<ProductTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>An instance of ProductTypeVw.</returns>
		public ProductTypeVw ProductTypeVwGetByProfitStrategyIdFirstOrDefault([Parameter(Name = "@ProfitStrategyId")] Nullable<byte> _profitStrategyId)
		{
			return _ProductTypeVwGetByProfitStrategyId(_profitStrategyId).ToList<ProductTypeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProductVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProductVwList")]
		private ISingleResult<ProductVw> _ProductVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProductVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProductVw view.
		/// </summary>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductVw> ProductVwList()
		{
			return _ProductVwList().ToList<ProductVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProductVwGet")]
		private ISingleResult<ProductVw> _ProductVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProductVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductVw or null.</returns>
		public ProductVw ProductVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ProductVw> list = _ProductVwGet(_id).ToList<ProductVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.ProductVwGetChildren")]
        [ResultType(typeof(ProductVw))]
        [ResultType(typeof(GrantVw))]
        [ResultType(typeof(LoanVw))]
        [ResultType(typeof(RefundableProductVw))]
        [ResultType(typeof(RequestVw))]
        private IMultipleResults _ProductVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.ProductVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductVw or null.</returns>
		public ProductVw ProductVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _ProductVwGetChildren(_id);
            ProductVw result = multipleResult.GetResult<ProductVw>().FirstOrDefault<ProductVw>();
            if (result == null) return null;
            result.GrantVw = multipleResult.GetResult<GrantVw>().FirstOrDefault<GrantVw>();
            result.LoanVw = multipleResult.GetResult<LoanVw>().FirstOrDefault<LoanVw>();
            result.RefundableProductVw = multipleResult.GetResult<RefundableProductVw>().FirstOrDefault<RefundableProductVw>();
            result.RequestVw = multipleResult.GetResult<RequestVw>().FirstOrDefault<RequestVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProductVwGetByEmployeeId")]
		private ISingleResult<ProductVw> _ProductVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<ProductVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductVw> ProductVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ProductVwGetByEmployeeId(_employeeId).ToList<ProductVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of ProductVw.</returns>
		public ProductVw ProductVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _ProductVwGetByEmployeeId(_employeeId).ToList<ProductVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ProductVwGetByProductTypeId")]
		private ISingleResult<ProductVw> _ProductVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productTypeId);
			return (result.ReturnValue as ISingleResult<ProductVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProductVw> ProductVwGetByProductTypeId([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductVwGetByProductTypeId(_productTypeId).ToList<ProductVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>An instance of ProductVw.</returns>
		public ProductVw ProductVwGetByProductTypeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] short _productTypeId)
		{
			return _ProductVwGetByProductTypeId(_productTypeId).ToList<ProductVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ProfileVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProfileVwList")]
		private ISingleResult<ProfileVw> _ProfileVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProfileVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProfileVw view.
		/// </summary>
		/// <returns>A list of ProfileVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProfileVw> ProfileVwList()
		{
			return _ProfileVwList().ToList<ProfileVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProfileVwGet")]
		private ISingleResult<ProfileVw> _ProfileVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<ProfileVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProfileVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of ProfileVw or null.</returns>
		public ProfileVw ProfileVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			List<ProfileVw> list = _ProfileVwGet(_employeeId).ToList<ProfileVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ProfileVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of ProfileVw or null.</returns>
		public ProfileVw ProfileVwGetChildren([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
            return ProfileVwGet(_employeeId);
        }
        #endregion
		#endregion

        #region ProfitStrategyVw procedures.
		#region List procedure
		[Function(Name = "dbo.ProfitStrategyVwList")]
		private ISingleResult<ProfitStrategyVw> _ProfitStrategyVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ProfitStrategyVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ProfitStrategyVw view.
		/// </summary>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProfitStrategyVw> ProfitStrategyVwList()
		{
			return _ProfitStrategyVwList().ToList<ProfitStrategyVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ProfitStrategyVwGet")]
		private ISingleResult<ProfitStrategyVw> _ProfitStrategyVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ProfitStrategyVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null.</returns>
		public ProfitStrategyVw ProfitStrategyVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<ProfitStrategyVw> list = _ProfitStrategyVwGet(_id).ToList<ProfitStrategyVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.ProfitStrategyVwGetChildren")]
        [ResultType(typeof(ProfitStrategyVw))]
        [ResultType(typeof(ProductTypeVw))]
        private IMultipleResults _ProfitStrategyVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null.</returns>
		public ProfitStrategyVw ProfitStrategyVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
			IMultipleResults multipleResult = _ProfitStrategyVwGetChildren(_id);
            ProfitStrategyVw result = multipleResult.GetResult<ProfitStrategyVw>().FirstOrDefault<ProfitStrategyVw>();
            if (result == null) return null;
            result.ProductTypeVwList = multipleResult.GetResult<ProductTypeVw>().ToList<ProductTypeVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ProfitStrategyVwGetByName")]
		private ISingleResult<ProfitStrategyVw> _ProfitStrategyVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<ProfitStrategyVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ProfitStrategyVw> ProfitStrategyVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _ProfitStrategyVwGetByName(_name).ToList<ProfitStrategyVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		/// <returns>An instance of ProfitStrategyVw.</returns>
		public ProfitStrategyVw ProfitStrategyVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _ProfitStrategyVwGetByName(_name).ToList<ProfitStrategyVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region RefundableProductVw procedures.
		#region List procedure
		[Function(Name = "dbo.RefundableProductVwList")]
		private ISingleResult<RefundableProductVw> _RefundableProductVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RefundableProductVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RefundableProductVw view.
		/// </summary>
		/// <returns>A list of RefundableProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RefundableProductVw> RefundableProductVwList()
		{
			return _RefundableProductVwList().ToList<RefundableProductVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RefundableProductVwGet")]
		private ISingleResult<RefundableProductVw> _RefundableProductVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<RefundableProductVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.RefundableProductVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RefundableProductVw or null.</returns>
		public RefundableProductVw RefundableProductVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<RefundableProductVw> list = _RefundableProductVwGet(_productId).ToList<RefundableProductVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.RefundableProductVwGetChildren")]
        [ResultType(typeof(RefundableProductVw))]
        [ResultType(typeof(GuarantorVw))]
        [ResultType(typeof(InstallmentVw))]
        private IMultipleResults _RefundableProductVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.RefundableProductVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RefundableProductVw or null.</returns>
		public RefundableProductVw RefundableProductVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IMultipleResults multipleResult = _RefundableProductVwGetChildren(_productId);
            RefundableProductVw result = multipleResult.GetResult<RefundableProductVw>().FirstOrDefault<RefundableProductVw>();
            if (result == null) return null;
            result.GuarantorVwList = multipleResult.GetResult<GuarantorVw>().ToList<GuarantorVw>();
            result.InstallmentVwList = multipleResult.GetResult<InstallmentVw>().ToList<InstallmentVw>();
            return result;
        }
        #endregion
		#endregion

        #region RequestDetailVw procedures.
		#region List procedure
		[Function(Name = "dbo.RequestDetailVwList")]
		private ISingleResult<RequestDetailVw> _RequestDetailVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RequestDetailVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RequestDetailVw view.
		/// </summary>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestDetailVw> RequestDetailVwList()
		{
			return _RequestDetailVwList().ToList<RequestDetailVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RequestDetailVwGet")]
		private ISingleResult<RequestDetailVw> _RequestDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<RequestDetailVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestDetailVw or null.</returns>
		public RequestDetailVw RequestDetailVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<RequestDetailVw> list = _RequestDetailVwGet(_productId).ToList<RequestDetailVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion
		
		#region Get by procedures
		[Function(Name = "dbo.RequestDetailVwGetByBypassStatusId")]
		private ISingleResult<RequestDetailVw> _RequestDetailVwGetByBypassStatusId([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _bypassStatusId);
			return (result.ReturnValue as ISingleResult<RequestDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestDetailVw> RequestDetailVwGetByBypassStatusId([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			return _RequestDetailVwGetByBypassStatusId(_bypassStatusId).ToList<RequestDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>An instance of RequestDetailVw.</returns>
		public RequestDetailVw RequestDetailVwGetByBypassStatusIdFirstOrDefault([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			return _RequestDetailVwGetByBypassStatusId(_bypassStatusId).ToList<RequestDetailVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.RequestDetailVwGetByRequestStatusId")]
		private ISingleResult<RequestDetailVw> _RequestDetailVwGetByRequestStatusId([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestStatusId);
			return (result.ReturnValue as ISingleResult<RequestDetailVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestDetailVw> RequestDetailVwGetByRequestStatusId([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			return _RequestDetailVwGetByRequestStatusId(_requestStatusId).ToList<RequestDetailVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>An instance of RequestDetailVw.</returns>
		public RequestDetailVw RequestDetailVwGetByRequestStatusIdFirstOrDefault([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			return _RequestDetailVwGetByRequestStatusId(_requestStatusId).ToList<RequestDetailVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region RequestStatusVw procedures.
		#region List procedure
		[Function(Name = "dbo.RequestStatusVwList")]
		private ISingleResult<RequestStatusVw> _RequestStatusVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RequestStatusVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RequestStatusVw view.
		/// </summary>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatusVw> RequestStatusVwList()
		{
			return _RequestStatusVwList().ToList<RequestStatusVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RequestStatusVwGet")]
		private ISingleResult<RequestStatusVw> _RequestStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<RequestStatusVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatusVw or null.</returns>
		public RequestStatusVw RequestStatusVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<RequestStatusVw> list = _RequestStatusVwGet(_id).ToList<RequestStatusVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.RequestStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatusVw or null.</returns>
		public RequestStatusVw RequestStatusVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return RequestStatusVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.RequestStatusVwGetByName")]
		private ISingleResult<RequestStatusVw> _RequestStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<RequestStatusVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestStatusVw> RequestStatusVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _RequestStatusVwGetByName(_name).ToList<RequestStatusVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		/// <returns>An instance of RequestStatusVw.</returns>
		public RequestStatusVw RequestStatusVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _RequestStatusVwGetByName(_name).ToList<RequestStatusVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region RequestVw procedures.
		#region List procedure
		[Function(Name = "dbo.RequestVwList")]
		private ISingleResult<RequestVw> _RequestVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<RequestVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.RequestVw view.
		/// </summary>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestVw> RequestVwList()
		{
			return _RequestVwList().ToList<RequestVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.RequestVwGet")]
		private ISingleResult<RequestVw> _RequestVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as ISingleResult<RequestVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.RequestVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestVw or null.</returns>
		public RequestVw RequestVwGet([Parameter(Name = "@ProductId")] int _productId)
		{
			List<RequestVw> list = _RequestVwGet(_productId).ToList<RequestVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.RequestVwGetChildren")]
        [ResultType(typeof(RequestVw))]
        [ResultType(typeof(DownPaymentVw))]
        [ResultType(typeof(GrantRequestVw))]
        [ResultType(typeof(LoanRequestVw))]
        private IMultipleResults _RequestVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.RequestVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestVw or null.</returns>
		public RequestVw RequestVwGetChildren([Parameter(Name = "@ProductId")] int _productId)
		{
			IMultipleResults multipleResult = _RequestVwGetChildren(_productId);
            RequestVw result = multipleResult.GetResult<RequestVw>().FirstOrDefault<RequestVw>();
            if (result == null) return null;
            result.DownPaymentVwList = multipleResult.GetResult<DownPaymentVw>().ToList<DownPaymentVw>();
            result.GrantRequestVw = multipleResult.GetResult<GrantRequestVw>().FirstOrDefault<GrantRequestVw>();
            result.LoanRequestVw = multipleResult.GetResult<LoanRequestVw>().FirstOrDefault<LoanRequestVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.RequestVwGetByBypassStatusId")]
		private ISingleResult<RequestVw> _RequestVwGetByBypassStatusId([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _bypassStatusId);
			return (result.ReturnValue as ISingleResult<RequestVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestVw> RequestVwGetByBypassStatusId([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			return _RequestVwGetByBypassStatusId(_bypassStatusId).ToList<RequestVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>An instance of RequestVw.</returns>
		public RequestVw RequestVwGetByBypassStatusIdFirstOrDefault([Parameter(Name = "@BypassStatusId")] int _bypassStatusId)
		{
			return _RequestVwGetByBypassStatusId(_bypassStatusId).ToList<RequestVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.RequestVwGetByRequestStatusId")]
		private ISingleResult<RequestVw> _RequestVwGetByRequestStatusId([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _requestStatusId);
			return (result.ReturnValue as ISingleResult<RequestVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<RequestVw> RequestVwGetByRequestStatusId([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			return _RequestVwGetByRequestStatusId(_requestStatusId).ToList<RequestVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>An instance of RequestVw.</returns>
		public RequestVw RequestVwGetByRequestStatusIdFirstOrDefault([Parameter(Name = "@RequestStatusId")] Nullable<byte> _requestStatusId)
		{
			return _RequestVwGetByRequestStatusId(_requestStatusId).ToList<RequestVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ResourceVw procedures.
		#region List procedure
		[Function(Name = "dbo.ResourceVwList")]
		private ISingleResult<ResourceVw> _ResourceVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ResourceVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ResourceVw view.
		/// </summary>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ResourceVw> ResourceVwList()
		{
			return _ResourceVwList().ToList<ResourceVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ResourceVwGet")]
		private ISingleResult<ResourceVw> _ResourceVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<ResourceVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ResourceVw view.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		/// <returns>Gets an instance of ResourceVw or null.</returns>
		public ResourceVw ResourceVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<ResourceVw> list = _ResourceVwGet(_id).ToList<ResourceVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ResourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		/// <returns>Gets an instance of ResourceVw or null.</returns>
		public ResourceVw ResourceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return ResourceVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.ResourceVwGetByLanguage_Module_Key")]
		private ISingleResult<ResourceVw> _ResourceVwGetByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _language, _module, _key);
			return (result.ReturnValue as ISingleResult<ResourceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Language_Module_Key columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ResourceVw> ResourceVwGetByLanguage_Module_Key([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			return _ResourceVwGetByLanguage_Module_Key(_language, _module, _key).ToList<ResourceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Language_Module_Key columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		/// <returns>An instance of ResourceVw.</returns>
		public ResourceVw ResourceVwGetByLanguage_Module_KeyFirstOrDefault([Parameter(Name = "@Language")] string _language, [Parameter(Name = "@Module")] string _module, [Parameter(Name = "@Key")] string _key)
		{
			return _ResourceVwGetByLanguage_Module_Key(_language, _module, _key).ToList<ResourceVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.ResourceVwGetByModule")]
		private ISingleResult<ResourceVw> _ResourceVwGetByModule([Parameter(Name = "@Module")] string _module)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _module);
			return (result.ReturnValue as ISingleResult<ResourceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ResourceVw> ResourceVwGetByModule([Parameter(Name = "@Module")] string _module)
		{
			return _ResourceVwGetByModule(_module).ToList<ResourceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		/// <returns>An instance of ResourceVw.</returns>
		public ResourceVw ResourceVwGetByModuleFirstOrDefault([Parameter(Name = "@Module")] string _module)
		{
			return _ResourceVwGetByModule(_module).ToList<ResourceVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region SalaryPaymentVw procedures.
		#region List procedure
		[Function(Name = "dbo.SalaryPaymentVwList")]
		private ISingleResult<SalaryPaymentVw> _SalaryPaymentVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SalaryPaymentVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SalaryPaymentVw view.
		/// </summary>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryPaymentVw> SalaryPaymentVwList()
		{
			return _SalaryPaymentVwList().ToList<SalaryPaymentVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SalaryPaymentVwGet")]
		private ISingleResult<SalaryPaymentVw> _SalaryPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentId);
			return (result.ReturnValue as ISingleResult<SalaryPaymentVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null.</returns>
		public SalaryPaymentVw SalaryPaymentVwGet([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			List<SalaryPaymentVw> list = _SalaryPaymentVwGet(_paymentId).ToList<SalaryPaymentVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null.</returns>
		public SalaryPaymentVw SalaryPaymentVwGetChildren([Parameter(Name = "@PaymentId")] int _paymentId)
		{
            return SalaryPaymentVwGet(_paymentId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SalaryPaymentVwGetByDepartmentId")]
		private ISingleResult<SalaryPaymentVw> _SalaryPaymentVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _departmentId);
			return (result.ReturnValue as ISingleResult<SalaryPaymentVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryPaymentVw> SalaryPaymentVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _SalaryPaymentVwGetByDepartmentId(_departmentId).ToList<SalaryPaymentVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>An instance of SalaryPaymentVw.</returns>
		public SalaryPaymentVw SalaryPaymentVwGetByDepartmentIdFirstOrDefault([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _SalaryPaymentVwGetByDepartmentId(_departmentId).ToList<SalaryPaymentVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region SalaryWorkPlaceVw procedures.
		#region List procedure
		[Function(Name = "dbo.SalaryWorkPlaceVwList")]
		private ISingleResult<SalaryWorkPlaceVw> _SalaryWorkPlaceVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SalaryWorkPlaceVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlaceVw> SalaryWorkPlaceVwList()
		{
			return _SalaryWorkPlaceVwList().ToList<SalaryWorkPlaceVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SalaryWorkPlaceVwGet")]
		private ISingleResult<SalaryWorkPlaceVw> _SalaryWorkPlaceVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlaceVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null.</returns>
		public SalaryWorkPlaceVw SalaryWorkPlaceVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<SalaryWorkPlaceVw> list = _SalaryWorkPlaceVwGet(_id).ToList<SalaryWorkPlaceVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        [Function(Name = "dbo.SalaryWorkPlaceVwGetChildren")]
        [ResultType(typeof(SalaryWorkPlaceVw))]
        [ResultType(typeof(DepartmentVw))]
        private IMultipleResults _SalaryWorkPlaceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as IMultipleResults);
		}

		/// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null.</returns>
		public SalaryWorkPlaceVw SalaryWorkPlaceVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
			IMultipleResults multipleResult = _SalaryWorkPlaceVwGetChildren(_id);
            SalaryWorkPlaceVw result = multipleResult.GetResult<SalaryWorkPlaceVw>().FirstOrDefault<SalaryWorkPlaceVw>();
            if (result == null) return null;
            result.DepartmentVwList = multipleResult.GetResult<DepartmentVw>().ToList<DepartmentVw>();
            return result;
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SalaryWorkPlaceVwGetByMainWorkPlaceId")]
		private ISingleResult<SalaryWorkPlaceVw> _SalaryWorkPlaceVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlaceId);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlaceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlaceVw> SalaryWorkPlaceVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _SalaryWorkPlaceVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<SalaryWorkPlaceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		/// <returns>An instance of SalaryWorkPlaceVw.</returns>
		public SalaryWorkPlaceVw SalaryWorkPlaceVwGetByMainWorkPlaceIdFirstOrDefault([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _SalaryWorkPlaceVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<SalaryWorkPlaceVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SalaryWorkPlaceVwGetByName")]
		private ISingleResult<SalaryWorkPlaceVw> _SalaryWorkPlaceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<SalaryWorkPlaceVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SalaryWorkPlaceVw> SalaryWorkPlaceVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _SalaryWorkPlaceVwGetByName(_name).ToList<SalaryWorkPlaceVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		/// <returns>An instance of SalaryWorkPlaceVw.</returns>
		public SalaryWorkPlaceVw SalaryWorkPlaceVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _SalaryWorkPlaceVwGetByName(_name).ToList<SalaryWorkPlaceVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region ServiceEndGrantRequestVw procedures.
		#region List procedure
		[Function(Name = "dbo.ServiceEndGrantRequestVwList")]
		private ISingleResult<ServiceEndGrantRequestVw> _ServiceEndGrantRequestVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<ServiceEndGrantRequestVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		/// <returns>A list of ServiceEndGrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<ServiceEndGrantRequestVw> ServiceEndGrantRequestVwList()
		{
			return _ServiceEndGrantRequestVwList().ToList<ServiceEndGrantRequestVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.ServiceEndGrantRequestVwGet")]
		private ISingleResult<ServiceEndGrantRequestVw> _ServiceEndGrantRequestVwGet([Parameter(Name = "@GrantRequestRequestProductId")] int _grantRequestRequestProductId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _grantRequestRequestProductId);
			return (result.ReturnValue as ISingleResult<ServiceEndGrantRequestVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null.</returns>
		public ServiceEndGrantRequestVw ServiceEndGrantRequestVwGet([Parameter(Name = "@GrantRequestRequestProductId")] int _grantRequestRequestProductId)
		{
			List<ServiceEndGrantRequestVw> list = _ServiceEndGrantRequestVwGet(_grantRequestRequestProductId).ToList<ServiceEndGrantRequestVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null.</returns>
		public ServiceEndGrantRequestVw ServiceEndGrantRequestVwGetChildren([Parameter(Name = "@GrantRequestRequestProductId")] int _grantRequestRequestProductId)
		{
            return ServiceEndGrantRequestVwGet(_grantRequestRequestProductId);
        }
        #endregion
		#endregion

        #region SettlementVw procedures.
		#region List procedure
		[Function(Name = "dbo.SettlementVwList")]
		private ISingleResult<SettlementVw> _SettlementVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SettlementVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SettlementVw view.
		/// </summary>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SettlementVw> SettlementVwList()
		{
			return _SettlementVwList().ToList<SettlementVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SettlementVwGet")]
		private ISingleResult<SettlementVw> _SettlementVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SettlementVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SettlementVw view.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		/// <returns>Gets an instance of SettlementVw or null.</returns>
		public SettlementVw SettlementVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<SettlementVw> list = _SettlementVwGet(_id).ToList<SettlementVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.SettlementVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		/// <returns>Gets an instance of SettlementVw or null.</returns>
		public SettlementVw SettlementVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return SettlementVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SettlementVwGetByInstallmentId")]
		private ISingleResult<SettlementVw> _SettlementVwGetByInstallmentId([Parameter(Name = "@InstallmentId")] int _installmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentId);
			return (result.ReturnValue as ISingleResult<SettlementVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SettlementVw> SettlementVwGetByInstallmentId([Parameter(Name = "@InstallmentId")] int _installmentId)
		{
			return _SettlementVwGetByInstallmentId(_installmentId).ToList<SettlementVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <returns>An instance of SettlementVw.</returns>
		public SettlementVw SettlementVwGetByInstallmentIdFirstOrDefault([Parameter(Name = "@InstallmentId")] int _installmentId)
		{
			return _SettlementVwGetByInstallmentId(_installmentId).ToList<SettlementVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SettlementVwGetByInstallmentId_PaymentId")]
		private ISingleResult<SettlementVw> _SettlementVwGetByInstallmentId_PaymentId([Parameter(Name = "@InstallmentId")] int _installmentId, [Parameter(Name = "@PaymentId")] int _paymentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _installmentId, _paymentId);
			return (result.ReturnValue as ISingleResult<SettlementVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentId_PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SettlementVw> SettlementVwGetByInstallmentId_PaymentId([Parameter(Name = "@InstallmentId")] int _installmentId, [Parameter(Name = "@PaymentId")] int _paymentId)
		{
			return _SettlementVwGetByInstallmentId_PaymentId(_installmentId, _paymentId).ToList<SettlementVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of InstallmentId_PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>An instance of SettlementVw.</returns>
		public SettlementVw SettlementVwGetByInstallmentId_PaymentIdFirstOrDefault([Parameter(Name = "@InstallmentId")] int _installmentId, [Parameter(Name = "@PaymentId")] int _paymentId)
		{
			return _SettlementVwGetByInstallmentId_PaymentId(_installmentId, _paymentId).ToList<SettlementVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SettlementVwGetByPaymentId")]
		private ISingleResult<SettlementVw> _SettlementVwGetByPaymentId([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _paymentId);
			return (result.ReturnValue as ISingleResult<SettlementVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SettlementVw> SettlementVwGetByPaymentId([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			return _SettlementVwGetByPaymentId(_paymentId).ToList<SettlementVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>An instance of SettlementVw.</returns>
		public SettlementVw SettlementVwGetByPaymentIdFirstOrDefault([Parameter(Name = "@PaymentId")] int _paymentId)
		{
			return _SettlementVwGetByPaymentId(_paymentId).ToList<SettlementVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region SpecialCaseLoanVw procedures.
		#region List procedure
		[Function(Name = "dbo.SpecialCaseLoanVwList")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwList()
		{
			return _SpecialCaseLoanVwList().ToList<SpecialCaseLoanVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SpecialCaseLoanVwGet")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<SpecialCaseLoanVw> list = _SpecialCaseLoanVwGet(_id).ToList<SpecialCaseLoanVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return SpecialCaseLoanVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SpecialCaseLoanVwGetByDate")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _date);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwGetByDate([Parameter(Name = "@Date")] DateTime _date)
		{
			return _SpecialCaseLoanVwGetByDate(_date).ToList<SpecialCaseLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		/// <returns>An instance of SpecialCaseLoanVw.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGetByDateFirstOrDefault([Parameter(Name = "@Date")] DateTime _date)
		{
			return _SpecialCaseLoanVwGetByDate(_date).ToList<SpecialCaseLoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SpecialCaseLoanVwGetByEmployeeId")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _SpecialCaseLoanVwGetByEmployeeId(_employeeId).ToList<SpecialCaseLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of SpecialCaseLoanVw.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _SpecialCaseLoanVwGetByEmployeeId(_employeeId).ToList<SpecialCaseLoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _date, _loanTypeProductTypeId);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_Date_LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId(_employeeId, _date, _loanTypeProductTypeId).ToList<SpecialCaseLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_Date_LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		/// <returns>An instance of SpecialCaseLoanVw.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Date")] DateTime _date, [Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId(_employeeId, _date, _loanTypeProductTypeId).ToList<SpecialCaseLoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SpecialCaseLoanVwGetByLoanTypeProductTypeId")]
		private ISingleResult<SpecialCaseLoanVw> _SpecialCaseLoanVwGetByLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _loanTypeProductTypeId);
			return (result.ReturnValue as ISingleResult<SpecialCaseLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwGetByLoanTypeProductTypeId([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _SpecialCaseLoanVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId).ToList<SpecialCaseLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		/// <returns>An instance of SpecialCaseLoanVw.</returns>
		public SpecialCaseLoanVw SpecialCaseLoanVwGetByLoanTypeProductTypeIdFirstOrDefault([Parameter(Name = "@LoanTypeProductTypeId")] short _loanTypeProductTypeId)
		{
			return _SpecialCaseLoanVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId).ToList<SpecialCaseLoanVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region SubscriptionTypeVw procedures.
		#region List procedure
		[Function(Name = "dbo.SubscriptionTypeVwList")]
		private ISingleResult<SubscriptionTypeVw> _SubscriptionTypeVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SubscriptionTypeVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionTypeVw> SubscriptionTypeVwList()
		{
			return _SubscriptionTypeVwList().ToList<SubscriptionTypeVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SubscriptionTypeVwGet")]
		private ISingleResult<SubscriptionTypeVw> _SubscriptionTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SubscriptionTypeVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null.</returns>
		public SubscriptionTypeVw SubscriptionTypeVwGet([Parameter(Name = "@Id")] byte _id)
		{
			List<SubscriptionTypeVw> list = _SubscriptionTypeVwGet(_id).ToList<SubscriptionTypeVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null.</returns>
		public SubscriptionTypeVw SubscriptionTypeVwGetChildren([Parameter(Name = "@Id")] byte _id)
		{
            return SubscriptionTypeVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SubscriptionTypeVwGetByName")]
		private ISingleResult<SubscriptionTypeVw> _SubscriptionTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _name);
			return (result.ReturnValue as ISingleResult<SubscriptionTypeVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionTypeVw> SubscriptionTypeVwGetByName([Parameter(Name = "@Name")] string _name)
		{
			return _SubscriptionTypeVwGetByName(_name).ToList<SubscriptionTypeVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		/// <returns>An instance of SubscriptionTypeVw.</returns>
		public SubscriptionTypeVw SubscriptionTypeVwGetByNameFirstOrDefault([Parameter(Name = "@Name")] string _name)
		{
			return _SubscriptionTypeVwGetByName(_name).ToList<SubscriptionTypeVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region SubscriptionVw procedures.
		#region List procedure
		[Function(Name = "dbo.SubscriptionVwList")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.SubscriptionVw view.
		/// </summary>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwList()
		{
			return _SubscriptionVwList().ToList<SubscriptionVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.SubscriptionVwGet")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionVw or null.</returns>
		public SubscriptionVw SubscriptionVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<SubscriptionVw> list = _SubscriptionVwGet(_id).ToList<SubscriptionVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionVw or null.</returns>
		public SubscriptionVw SubscriptionVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return SubscriptionVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.SubscriptionVwGetByDepartmentId")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _departmentId);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwGetByDepartmentId([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _SubscriptionVwGetByDepartmentId(_departmentId).ToList<SubscriptionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>An instance of SubscriptionVw.</returns>
		public SubscriptionVw SubscriptionVwGetByDepartmentIdFirstOrDefault([Parameter(Name = "@DepartmentId")] int _departmentId)
		{
			return _SubscriptionVwGetByDepartmentId(_departmentId).ToList<SubscriptionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SubscriptionVwGetByEmployeeId")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _SubscriptionVwGetByEmployeeId(_employeeId).ToList<SubscriptionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of SubscriptionVw.</returns>
		public SubscriptionVw SubscriptionVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _SubscriptionVwGetByEmployeeId(_employeeId).ToList<SubscriptionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@DepartmentId")] int _departmentId, [Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId, _month, _departmentId, _subscriptionTypeId);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_Month_DepartmentId_SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_departmentId">الفعالية</param>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@DepartmentId")] int _departmentId, [Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			return _SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(_employeeId, _month, _departmentId, _subscriptionTypeId).ToList<SubscriptionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_Month_DepartmentId_SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_departmentId">الفعالية</param>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		/// <returns>An instance of SubscriptionVw.</returns>
		public SubscriptionVw SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId, [Parameter(Name = "@Month")] DateTime _month, [Parameter(Name = "@DepartmentId")] int _departmentId, [Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			return _SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(_employeeId, _month, _departmentId, _subscriptionTypeId).ToList<SubscriptionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SubscriptionVwGetByIsFixed")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGetByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isFixed);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwGetByIsFixed([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			return _SubscriptionVwGetByIsFixed(_isFixed).ToList<SubscriptionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		/// <returns>An instance of SubscriptionVw.</returns>
		public SubscriptionVw SubscriptionVwGetByIsFixedFirstOrDefault([Parameter(Name = "@IsFixed")] bool _isFixed)
		{
			return _SubscriptionVwGetByIsFixed(_isFixed).ToList<SubscriptionVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.SubscriptionVwGetBySubscriptionTypeId")]
		private ISingleResult<SubscriptionVw> _SubscriptionVwGetBySubscriptionTypeId([Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _subscriptionTypeId);
			return (result.ReturnValue as ISingleResult<SubscriptionVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<SubscriptionVw> SubscriptionVwGetBySubscriptionTypeId([Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			return _SubscriptionVwGetBySubscriptionTypeId(_subscriptionTypeId).ToList<SubscriptionVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		/// <returns>An instance of SubscriptionVw.</returns>
		public SubscriptionVw SubscriptionVwGetBySubscriptionTypeIdFirstOrDefault([Parameter(Name = "@SubscriptionTypeId")] byte _subscriptionTypeId)
		{
			return _SubscriptionVwGetBySubscriptionTypeId(_subscriptionTypeId).ToList<SubscriptionVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region TransitoryIncomingLoanVw procedures.
		#region List procedure
		[Function(Name = "dbo.TransitoryIncomingLoanVwList")]
		private ISingleResult<TransitoryIncomingLoanVw> _TransitoryIncomingLoanVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoanVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoanVw> TransitoryIncomingLoanVwList()
		{
			return _TransitoryIncomingLoanVwList().ToList<TransitoryIncomingLoanVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.TransitoryIncomingLoanVwGet")]
		private ISingleResult<TransitoryIncomingLoanVw> _TransitoryIncomingLoanVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoanVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null.</returns>
		public TransitoryIncomingLoanVw TransitoryIncomingLoanVwGet([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			List<TransitoryIncomingLoanVw> list = _TransitoryIncomingLoanVwGet(_employeeId).ToList<TransitoryIncomingLoanVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null.</returns>
		public TransitoryIncomingLoanVw TransitoryIncomingLoanVwGetChildren([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
            return TransitoryIncomingLoanVwGet(_employeeId);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.TransitoryIncomingLoanVwGetByIsVerified")]
		private ISingleResult<TransitoryIncomingLoanVw> _TransitoryIncomingLoanVwGetByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isVerified);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoanVw> TransitoryIncomingLoanVwGetByIsVerified([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			return _TransitoryIncomingLoanVwGetByIsVerified(_isVerified).ToList<TransitoryIncomingLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		/// <returns>An instance of TransitoryIncomingLoanVw.</returns>
		public TransitoryIncomingLoanVw TransitoryIncomingLoanVwGetByIsVerifiedFirstOrDefault([Parameter(Name = "@IsVerified")] bool _isVerified)
		{
			return _TransitoryIncomingLoanVwGetByIsVerified(_isVerified).ToList<TransitoryIncomingLoanVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.TransitoryIncomingLoanVwGetByMainWorkPlaceId")]
		private ISingleResult<TransitoryIncomingLoanVw> _TransitoryIncomingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _mainWorkPlaceId);
			return (result.ReturnValue as ISingleResult<TransitoryIncomingLoanVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<TransitoryIncomingLoanVw> TransitoryIncomingLoanVwGetByMainWorkPlaceId([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _TransitoryIncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<TransitoryIncomingLoanVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>An instance of TransitoryIncomingLoanVw.</returns>
		public TransitoryIncomingLoanVw TransitoryIncomingLoanVwGetByMainWorkPlaceIdFirstOrDefault([Parameter(Name = "@MainWorkPlaceId")] int _mainWorkPlaceId)
		{
			return _TransitoryIncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId).ToList<TransitoryIncomingLoanVw>().FirstOrDefault();
		}
		#endregion
		#endregion

        #region WarrantVw procedures.
		#region List procedure
		[Function(Name = "dbo.WarrantVwList")]
		private ISingleResult<WarrantVw> _WarrantVwList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Selects all rows from the dbo.WarrantVw view.
		/// </summary>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<WarrantVw> WarrantVwList()
		{
			return _WarrantVwList().ToList<WarrantVw>();
		}
		#endregion

		#region Get procedure
		[Function(Name = "dbo.WarrantVwGet")]
		private ISingleResult<WarrantVw> _WarrantVwGet([Parameter(Name = "@Id")] int _id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _id);
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Gets one row from the dbo.WarrantVw view.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		/// <returns>Gets an instance of WarrantVw or null.</returns>
		public WarrantVw WarrantVwGet([Parameter(Name = "@Id")] int _id)
		{
			List<WarrantVw> list = _WarrantVwGet(_id).ToList<WarrantVw>();
			if (list.Count > 0) return list[0];
			return null;
		}
		#endregion

		#region GetChidlren procedure
        /// <summary>
		/// Gets one row from the dbo.WarrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		/// <returns>Gets an instance of WarrantVw or null.</returns>
		public WarrantVw WarrantVwGetChildren([Parameter(Name = "@Id")] int _id)
		{
            return WarrantVwGet(_id);
        }
        #endregion
		
		#region Get by procedures
		[Function(Name = "dbo.WarrantVwGetByDebtId")]
		private ISingleResult<WarrantVw> _WarrantVwGetByDebtId([Parameter(Name = "@DebtId")] int _debtId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debtId);
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<WarrantVw> WarrantVwGetByDebtId([Parameter(Name = "@DebtId")] int _debtId)
		{
			return _WarrantVwGetByDebtId(_debtId).ToList<WarrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <returns>An instance of WarrantVw.</returns>
		public WarrantVw WarrantVwGetByDebtIdFirstOrDefault([Parameter(Name = "@DebtId")] int _debtId)
		{
			return _WarrantVwGetByDebtId(_debtId).ToList<WarrantVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.WarrantVwGetByDebtId_EmployeeId")]
		private ISingleResult<WarrantVw> _WarrantVwGetByDebtId_EmployeeId([Parameter(Name = "@DebtId")] int _debtId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _debtId, _employeeId);
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of DebtId_EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<WarrantVw> WarrantVwGetByDebtId_EmployeeId([Parameter(Name = "@DebtId")] int _debtId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _WarrantVwGetByDebtId_EmployeeId(_debtId, _employeeId).ToList<WarrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of DebtId_EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of WarrantVw.</returns>
		public WarrantVw WarrantVwGetByDebtId_EmployeeIdFirstOrDefault([Parameter(Name = "@DebtId")] int _debtId, [Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _WarrantVwGetByDebtId_EmployeeId(_debtId, _employeeId).ToList<WarrantVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.WarrantVwGetByEmployeeId")]
		private ISingleResult<WarrantVw> _WarrantVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _employeeId);
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<WarrantVw> WarrantVwGetByEmployeeId([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _WarrantVwGetByEmployeeId(_employeeId).ToList<WarrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>An instance of WarrantVw.</returns>
		public WarrantVw WarrantVwGetByEmployeeIdFirstOrDefault([Parameter(Name = "@EmployeeId")] int _employeeId)
		{
			return _WarrantVwGetByEmployeeId(_employeeId).ToList<WarrantVw>().FirstOrDefault();
		}		

		[Function(Name = "dbo.WarrantVwGetByIsActive")]
		private ISingleResult<WarrantVw> _WarrantVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _isActive);
			return (result.ReturnValue as ISingleResult<WarrantVw>);
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<WarrantVw> WarrantVwGetByIsActive([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _WarrantVwGetByIsActive(_isActive).ToList<WarrantVw>();
		}

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		/// <returns>An instance of WarrantVw.</returns>
		public WarrantVw WarrantVwGetByIsActiveFirstOrDefault([Parameter(Name = "@IsActive")] bool _isActive)
		{
			return _WarrantVwGetByIsActive(_isActive).ToList<WarrantVw>().FirstOrDefault();
		}
		#endregion
		#endregion
	}
	#endregion
}
