using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cf.Data;

namespace Cf.Services
{
    #region AvailabilityCeilingVwServices
    public static partial class AvailabilityCeilingVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null.</returns>
		public static AvailabilityCeilingVw Get(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityCeilingVw GetChildren(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> GetByAvailabilityId(short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGetByAvailabilityId(_availabilityId);
		}
        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static AvailabilityCeilingVw GetByAvailabilityIdFirstOrDefault(short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGetByAvailabilityIdFirstOrDefault(_availabilityId);
		}		

        /// <summary>
		/// Gets rows related to one combination of AvailabilityId_FromYear columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> GetByAvailabilityId_FromYear(short _availabilityId, short _fromYear, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGetByAvailabilityId_FromYear(_availabilityId, _fromYear);
		}
        /// <summary>
		/// Gets rows related to one combination of AvailabilityId_FromYear columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static AvailabilityCeilingVw GetByAvailabilityId_FromYearFirstOrDefault(short _availabilityId, short _fromYear, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityCeilingVwGetByAvailabilityId_FromYearFirstOrDefault(_availabilityId, _fromYear);
		}
		#endregion
	}
	#endregion

    #region AvailabilityVwServices
    public static partial class AvailabilityVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.AvailabilityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityVw or null.</returns>
		public static AvailabilityVw Get(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityVw GetChildren(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.AvailabilityVwGetChildren(_id);
		}
        #endregion
	}
	#endregion

    #region BypassStatusVwServices
    public static partial class BypassStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.BypassStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.BypassStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of BypassStatusVw or null.</returns>
		public static BypassStatusVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.BypassStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.BypassStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of BypassStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static BypassStatusVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.BypassStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.BypassStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static BypassStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.BypassStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region CashPaymentVwServices
    public static partial class CashPaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.CashPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CashPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CashPaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CashPaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.CashPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CashPaymentVw or null.</returns>
		public static CashPaymentVw Get(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CashPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.CashPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CashPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CashPaymentVw GetChildren(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CashPaymentVwGetChildren(_paymentId);
		}
        #endregion
	}
	#endregion

    #region CategoryVwServices
    public static partial class CategoryVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.CategoryVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CategoryVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.CategoryVw view.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CategoryVw or null.</returns>
		public static CategoryVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CategoryVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.CategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CategoryVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CategoryVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CategoryVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static CategoryVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CategoryVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region CollectOrderVwServices
    public static partial class CollectOrderVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.CollectOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CollectOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CollectOrderVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CollectOrderVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.CollectOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CollectOrderVw or null.</returns>
		public static CollectOrderVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CollectOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.CollectOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CollectOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CollectOrderVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.CollectOrderVwGetChildren(_id);
		}
        #endregion
	}
	#endregion

    #region DebtVwServices
    public static partial class DebtVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.DebtVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.DebtVw view.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DebtVw or null.</returns>
		public static DebtVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.DebtVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DebtVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DebtVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByDate(Nullable<DateTime> _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DebtVw GetByDateFirstOrDefault(Nullable<DateTime> _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DebtVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIsActive(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByIsActive(_isActive);
		}
        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DebtVw GetByIsActiveFirstOrDefault(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByIsActiveFirstOrDefault(_isActive);
		}		

        /// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIssuerId(byte _issuerId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByIssuerId(_issuerId);
		}
        /// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DebtVw GetByIssuerIdFirstOrDefault(byte _issuerId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DebtVwGetByIssuerIdFirstOrDefault(_issuerId);
		}
		#endregion
	}
	#endregion

    #region DepartmentVwServices
    public static partial class DepartmentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.DepartmentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DepartmentVw or null.</returns>
		public static DepartmentVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.DepartmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DepartmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DepartmentVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DepartmentVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGetByNameFirstOrDefault(_name);
		}		

        /// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetBySalaryWorkPlaceId(int _salaryWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGetBySalaryWorkPlaceId(_salaryWorkPlaceId);
		}
        /// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DepartmentVw GetBySalaryWorkPlaceIdFirstOrDefault(int _salaryWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DepartmentVwGetBySalaryWorkPlaceIdFirstOrDefault(_salaryWorkPlaceId);
		}
		#endregion
	}
	#endregion

    #region DownPaymentVwServices
    public static partial class DownPaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.DownPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DownPaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DownPaymentVw or null.</returns>
		public static DownPaymentVw Get(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DownPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.DownPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DownPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DownPaymentVw GetChildren(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DownPaymentVwGetChildren(_paymentId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> GetByRequestProductId(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DownPaymentVwGetByRequestProductId(_requestProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static DownPaymentVw GetByRequestProductIdFirstOrDefault(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.DownPaymentVwGetByRequestProductIdFirstOrDefault(_requestProductId);
		}
		#endregion
	}
	#endregion

    #region EmployeeDetailVwServices
    public static partial class EmployeeDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeDetailVw or null.</returns>
		public static EmployeeDetailVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByCategoryId(byte _categoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByCategoryId(_categoryId);
		}
        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeDetailVw GetByCategoryIdFirstOrDefault(byte _categoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByCategoryIdFirstOrDefault(_categoryId);
		}		

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByDepartmentId(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByDepartmentId(_departmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeDetailVw GetByDepartmentIdFirstOrDefault(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByDepartmentIdFirstOrDefault(_departmentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByEmployeeStatusId(byte _employeeStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByEmployeeStatusId(_employeeStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeDetailVw GetByEmployeeStatusIdFirstOrDefault(byte _employeeStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByEmployeeStatusIdFirstOrDefault(_employeeStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByFirstName_LastName(string _firstName, string _lastName, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByFirstName_LastName(_firstName, _lastName);
		}
        /// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeDetailVw GetByFirstName_LastNameFirstOrDefault(string _firstName, string _lastName, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeDetailVwGetByFirstName_LastNameFirstOrDefault(_firstName, _lastName);
		}
		#endregion
	}
	#endregion

    #region EmployeeRefundableProductRollupVwServices
    public static partial class EmployeeRefundableProductRollupVwServices
    {
	}
	#endregion
    #region EmployeeSeniorityVwServices
    public static partial class EmployeeSeniorityVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeSeniorityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeSeniorityVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeSeniorityVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null.</returns>
		public static EmployeeSeniorityVw Get(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeSeniorityVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeSeniorityVw GetChildren(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeSeniorityVwGetChildren(_employeeId);
		}
        #endregion
	}
	#endregion

    #region EmployeeStatusVwServices
    public static partial class EmployeeStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null.</returns>
		public static EmployeeStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByIsActive(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGetByIsActive(_isActive);
		}
        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeStatusVw GetByIsActiveFirstOrDefault(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGetByIsActiveFirstOrDefault(_isActive);
		}		

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region EmployeeVwServices
    public static partial class EmployeeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeVw or null.</returns>
		public static EmployeeVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByCategoryId(byte _categoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByCategoryId(_categoryId);
		}
        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeVw GetByCategoryIdFirstOrDefault(byte _categoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByCategoryIdFirstOrDefault(_categoryId);
		}		

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByDepartmentId(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByDepartmentId(_departmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeVw GetByDepartmentIdFirstOrDefault(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByDepartmentIdFirstOrDefault(_departmentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByEmployeeStatusId(byte _employeeStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByEmployeeStatusId(_employeeStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeVw GetByEmployeeStatusIdFirstOrDefault(byte _employeeStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByEmployeeStatusIdFirstOrDefault(_employeeStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByFirstName_LastName(string _firstName, string _lastName, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByFirstName_LastName(_firstName, _lastName);
		}
        /// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EmployeeVw GetByFirstName_LastNameFirstOrDefault(string _firstName, string _lastName, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EmployeeVwGetByFirstName_LastNameFirstOrDefault(_firstName, _lastName);
		}
		#endregion
	}
	#endregion

    #region EndWorkGrantBracketVwServices
    public static partial class EndWorkGrantBracketVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EndWorkGrantBracketVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EndWorkGrantBracketVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EndWorkGrantBracketVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null.</returns>
		public static EndWorkGrantBracketVw Get(byte _fromYear, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EndWorkGrantBracketVwGet(_fromYear);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view with related objects from children.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EndWorkGrantBracketVw GetChildren(byte _fromYear, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EndWorkGrantBracketVwGetChildren(_fromYear);
		}
        #endregion
	}
	#endregion

    #region ErrorDefinitionVwServices
    public static partial class ErrorDefinitionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ErrorDefinitionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ErrorDefinitionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null.</returns>
		public static ErrorDefinitionVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ErrorDefinitionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ErrorDefinitionVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ErrorDefinitionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> GetByLikeExpression(string _likeExpression, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ErrorDefinitionVwGetByLikeExpression(_likeExpression);
		}
        /// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ErrorDefinitionVw GetByLikeExpressionFirstOrDefault(string _likeExpression, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ErrorDefinitionVwGetByLikeExpressionFirstOrDefault(_likeExpression);
		}
		#endregion
	}
	#endregion

    #region EventCategoryVwServices
    public static partial class EventCategoryVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventCategoryVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventCategoryVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventCategoryVw or null.</returns>
		public static EventCategoryVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventCategoryVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EventCategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventCategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventCategoryVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventCategoryVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventCategoryVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventCategoryVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventCategoryVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region EventLogDetailVwServices
    public static partial class EventLogDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventLogDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogDetailVw or null.</returns>
		public static EventLogDetailVw Get(long _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogDetailVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventCategoryId(int _eventCategoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventCategoryId(_eventCategoryId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogDetailVw GetByEventCategoryIdFirstOrDefault(int _eventCategoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventCategoryIdFirstOrDefault(_eventCategoryId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventSourceId(int _eventSourceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventSourceId(_eventSourceId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogDetailVw GetByEventSourceIdFirstOrDefault(int _eventSourceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventSourceIdFirstOrDefault(_eventSourceId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventStatusId(int _eventStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventStatusId(_eventStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogDetailVw GetByEventStatusIdFirstOrDefault(int _eventStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByEventStatusIdFirstOrDefault(_eventStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByUser(int _user, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByUser(_user);
		}
        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogDetailVw GetByUserFirstOrDefault(int _user, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogDetailVwGetByUserFirstOrDefault(_user);
		}
		#endregion
	}
	#endregion

    #region EventLogErrorVwServices
    public static partial class EventLogErrorVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventLogErrorVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogErrorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogErrorVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogErrorVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogErrorVw or null.</returns>
		public static EventLogErrorVw Get(long _eventLogId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogErrorVwGet(_eventLogId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view with related objects from children.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogErrorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogErrorVw GetChildren(long _eventLogId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogErrorVwGetChildren(_eventLogId);
		}
        #endregion
	}
	#endregion

    #region EventLogVwServices
    public static partial class EventLogVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventLogVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogVw or null.</returns>
		public static EventLogVw Get(long _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogVw GetChildren(long _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventCategoryId(int _eventCategoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventCategoryId(_eventCategoryId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogVw GetByEventCategoryIdFirstOrDefault(int _eventCategoryId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventCategoryIdFirstOrDefault(_eventCategoryId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventSourceId(int _eventSourceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventSourceId(_eventSourceId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogVw GetByEventSourceIdFirstOrDefault(int _eventSourceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventSourceIdFirstOrDefault(_eventSourceId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventStatusId(int _eventStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventStatusId(_eventStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogVw GetByEventStatusIdFirstOrDefault(int _eventStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByEventStatusIdFirstOrDefault(_eventStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByUser(int _user, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByUser(_user);
		}
        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventLogVw GetByUserFirstOrDefault(int _user, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventLogVwGetByUserFirstOrDefault(_user);
		}
		#endregion
	}
	#endregion

    #region EventSourceVwServices
    public static partial class EventSourceVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventSourceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventSourceVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventSourceVw or null.</returns>
		public static EventSourceVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventSourceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EventSourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventSourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventSourceVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventSourceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventSourceVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventSourceVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventSourceVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region EventStatusVwServices
    public static partial class EventStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventStatusVw or null.</returns>
		public static EventStatusVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.EventStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventStatusVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static EventStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.EventStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region ExceptionalAmountTypeVwServices
    public static partial class ExceptionalAmountTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null.</returns>
		public static ExceptionalAmountTypeVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountTypeVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountTypeVwGetChildren(_id);
		}
        #endregion
	}
	#endregion

    #region ExceptionalAmountVwServices
    public static partial class ExceptionalAmountVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null.</returns>
		public static ExceptionalAmountVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByExceptionalAmountTypeId(byte _exceptionalAmountTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGetByExceptionalAmountTypeId(_exceptionalAmountTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ExceptionalAmountVw GetByExceptionalAmountTypeIdFirstOrDefault(byte _exceptionalAmountTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGetByExceptionalAmountTypeIdFirstOrDefault(_exceptionalAmountTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByLoanRequestRequestProductId(int _loanRequestRequestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGetByLoanRequestRequestProductId(_loanRequestRequestProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ExceptionalAmountVw GetByLoanRequestRequestProductIdFirstOrDefault(int _loanRequestRequestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExceptionalAmountVwGetByLoanRequestRequestProductIdFirstOrDefault(_loanRequestRequestProductId);
		}
		#endregion
	}
	#endregion

    #region ExternalGrantVwServices
    public static partial class ExternalGrantVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExternalGrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExternalGrantVw or null.</returns>
		public static ExternalGrantVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExternalGrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExternalGrantVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ExternalGrantVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByGrantTypeId(byte _grantTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGetByGrantTypeId(_grantTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ExternalGrantVw GetByGrantTypeIdFirstOrDefault(byte _grantTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ExternalGrantVwGetByGrantTypeIdFirstOrDefault(_grantTypeId);
		}
		#endregion
	}
	#endregion

    #region GrantDecisionVwServices
    public static partial class GrantDecisionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDecisionVw or null.</returns>
		public static GrantDecisionVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDecisionVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> GetByGrantTypeGroupId(byte _grantTypeGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGetByGrantTypeGroupId(_grantTypeGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantDecisionVw GetByGrantTypeGroupIdFirstOrDefault(byte _grantTypeGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGetByGrantTypeGroupIdFirstOrDefault(_grantTypeGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> GetByNumber_Year(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGetByNumber_Year(_number, _year);
		}
        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantDecisionVw GetByNumber_YearFirstOrDefault(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDecisionVwGetByNumber_YearFirstOrDefault(_number, _year);
		}
		#endregion
	}
	#endregion

    #region GrantDeductionVwServices
    public static partial class GrantDeductionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantDeductionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDeductionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDeductionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDeductionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDeductionVw or null.</returns>
		public static GrantDeductionVw Get(int _grantProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDeductionVwGet(_grantProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view with related objects from children.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDeductionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDeductionVw GetChildren(int _grantProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDeductionVwGetChildren(_grantProductId);
		}
        #endregion
	}
	#endregion

    #region GrantDetailVwServices
    public static partial class GrantDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDetailVw or null.</returns>
		public static GrantDetailVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> GetByGrantDecisionId(int _grantDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDetailVwGetByGrantDecisionId(_grantDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantDetailVw GetByGrantDecisionIdFirstOrDefault(int _grantDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantDetailVwGetByGrantDecisionIdFirstOrDefault(_grantDecisionId);
		}
		#endregion
	}
	#endregion

    #region GrantPaymentOrderVwServices
    public static partial class GrantPaymentOrderVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null.</returns>
		public static GrantPaymentOrderVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentOrderVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantPaymentOrderVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> GetByNumber_Year(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGetByNumber_Year(_number, _year);
		}
        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantPaymentOrderVw GetByNumber_YearFirstOrDefault(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentOrderVwGetByNumber_YearFirstOrDefault(_number, _year);
		}
		#endregion
	}
	#endregion

    #region GrantPaymentVwServices
    public static partial class GrantPaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentVw or null.</returns>
		public static GrantPaymentVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId(int _grantPaymentOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantPaymentOrderId(_grantPaymentOrderId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantPaymentVw GetByGrantPaymentOrderIdFirstOrDefault(int _grantPaymentOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantPaymentOrderIdFirstOrDefault(_grantPaymentOrderId);
		}		

        /// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId_SubNumber columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId_SubNumber(int _grantPaymentOrderId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantPaymentOrderId_SubNumber(_grantPaymentOrderId, _subNumber);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId_SubNumber columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantPaymentVw GetByGrantPaymentOrderId_SubNumberFirstOrDefault(int _grantPaymentOrderId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantPaymentOrderId_SubNumberFirstOrDefault(_grantPaymentOrderId, _subNumber);
		}		

        /// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantProductId(int _grantProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantProductId(_grantProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantPaymentVw GetByGrantProductIdFirstOrDefault(int _grantProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantPaymentVwGetByGrantProductIdFirstOrDefault(_grantProductId);
		}
		#endregion
	}
	#endregion

    #region GrantRequestDetailVwServices
    public static partial class GrantRequestDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantRequestDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantRequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantRequestDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantRequestDetailVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestDetailVw or null.</returns>
		public static GrantRequestDetailVw Get(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantRequestDetailVwGet(_requestProductId);
		}
        #endregion
	}
	#endregion

    #region GrantRequestVwServices
    public static partial class GrantRequestVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantRequestVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestVw or null.</returns>
		public static GrantRequestVw Get(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantRequestVwGet(_requestProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantRequestVw GetChildren(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantRequestVwGetChildren(_requestProductId);
		}
        #endregion
	}
	#endregion

    #region GrantTypeGroupVwServices
    public static partial class GrantTypeGroupVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantTypeGroupVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeGroupVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null.</returns>
		public static GrantTypeGroupVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeGroupVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeGroupVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeGroupVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeGroupVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantTypeGroupVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeGroupVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region GrantTypeVwServices
    public static partial class GrantTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeVw or null.</returns>
		public static GrantTypeVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByGrantTypeGroupId(byte _grantTypeGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGetByGrantTypeGroupId(_grantTypeGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantTypeVw GetByGrantTypeGroupIdFirstOrDefault(byte _grantTypeGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGetByGrantTypeGroupIdFirstOrDefault(_grantTypeGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantTypeVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantTypeVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region GrantVwServices
    public static partial class GrantVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantVw or null.</returns>
		public static GrantVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GrantVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantVw GetChildren(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> GetByGrantDecisionId(int _grantDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantVwGetByGrantDecisionId(_grantDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GrantVw GetByGrantDecisionIdFirstOrDefault(int _grantDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GrantVwGetByGrantDecisionIdFirstOrDefault(_grantDecisionId);
		}
		#endregion
	}
	#endregion

    #region GuarantorDetailVwServices
    public static partial class GuarantorDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorDetailVw or null.</returns>
		public static GuarantorDetailVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorDetailVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByGuarantorStatusId(byte _guarantorStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByGuarantorStatusId(_guarantorStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorDetailVw GetByGuarantorStatusIdFirstOrDefault(byte _guarantorStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByGuarantorStatusIdFirstOrDefault(_guarantorStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByRefundableProductProductId(_refundableProductProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorDetailVw GetByRefundableProductProductIdFirstOrDefault(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByRefundableProductProductIdFirstOrDefault(_refundableProductProductId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorDetailVw GetByRefundableProductProductId_SubNumberFirstOrDefault(int _refundableProductProductId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorDetailVwGetByRefundableProductProductId_SubNumberFirstOrDefault(_refundableProductProductId, _subNumber);
		}
		#endregion
	}
	#endregion

    #region GuarantorStatementVwServices
    public static partial class GuarantorStatementVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatementVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatementVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatementVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null.</returns>
		public static GuarantorStatementVw Get(int _guarantorId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatementVwGet(_guarantorId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view with related objects from children.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatementVw GetChildren(int _guarantorId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatementVwGetChildren(_guarantorId);
		}
        #endregion
	}
	#endregion

    #region GuarantorStatusVwServices
    public static partial class GuarantorStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null.</returns>
		public static GuarantorStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region GuarantorVwServices
    public static partial class GuarantorVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorVw or null.</returns>
		public static GuarantorVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByGuarantorStatusId(byte _guarantorStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByGuarantorStatusId(_guarantorStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorVw GetByGuarantorStatusIdFirstOrDefault(byte _guarantorStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByGuarantorStatusIdFirstOrDefault(_guarantorStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductId(_refundableProductProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorVw GetByRefundableProductProductIdFirstOrDefault(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductIdFirstOrDefault(_refundableProductProductId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId_EmployeeId(int _refundableProductProductId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductId_EmployeeId(_refundableProductProductId, _employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorVw GetByRefundableProductProductId_EmployeeIdFirstOrDefault(int _refundableProductProductId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductId_EmployeeIdFirstOrDefault(_refundableProductProductId, _employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static GuarantorVw GetByRefundableProductProductId_SubNumberFirstOrDefault(int _refundableProductProductId, byte _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.GuarantorVwGetByRefundableProductProductId_SubNumberFirstOrDefault(_refundableProductProductId, _subNumber);
		}
		#endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPaymentVwServices
    public static partial class HealthLoanDecisionFirstPaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null.</returns>
		public static HealthLoanDecisionFirstPaymentVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionFirstPaymentVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByDepartment(Nullable<int> _department, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByDepartment(_department);
		}
        /// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByDepartmentFirstOrDefault(Nullable<int> _department, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByDepartmentFirstOrDefault(_department);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentDate columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId_PaymentDate(int _employeeId, DateTime _paymentDate, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate(_employeeId, _paymentDate);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentDate columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByEmployeeId_PaymentDateFirstOrDefault(int _employeeId, DateTime _paymentDate, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDateFirstOrDefault(_employeeId, _paymentDate);
		}		

        /// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByHealthLoanDecisionId(Nullable<int> _healthLoanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId(_healthLoanDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByHealthLoanDecisionIdFirstOrDefault(Nullable<int> _healthLoanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionIdFirstOrDefault(_healthLoanDecisionId);
		}		

        /// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByInsuranceTypeId(Nullable<byte> _insuranceTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId(_insuranceTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByInsuranceTypeIdFirstOrDefault(Nullable<byte> _insuranceTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeIdFirstOrDefault(_insuranceTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByLoanRequest(Nullable<int> _loanRequest, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByLoanRequest(_loanRequest);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByLoanRequestFirstOrDefault(Nullable<int> _loanRequest, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByLoanRequestFirstOrDefault(_loanRequest);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByPaymentStatus(Nullable<byte> _paymentStatus, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByPaymentStatus(_paymentStatus);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionFirstPaymentVw GetByPaymentStatusFirstOrDefault(Nullable<byte> _paymentStatus, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionFirstPaymentVwGetByPaymentStatusFirstOrDefault(_paymentStatus);
		}
		#endregion
	}
	#endregion

    #region HealthLoanDecisionVwServices
    public static partial class HealthLoanDecisionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null.</returns>
		public static HealthLoanDecisionVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> GetByDate(Nullable<DateTime> _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionVw GetByDateFirstOrDefault(Nullable<DateTime> _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> GetByNumber_Year(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGetByNumber_Year(_number, _year);
		}
        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static HealthLoanDecisionVw GetByNumber_YearFirstOrDefault(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.HealthLoanDecisionVwGetByNumber_YearFirstOrDefault(_number, _year);
		}
		#endregion
	}
	#endregion

    #region IncomingLoanVwServices
    public static partial class IncomingLoanVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.IncomingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IncomingLoanVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IncomingLoanVw or null.</returns>
		public static IncomingLoanVw Get(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IncomingLoanVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IncomingLoanVw GetChildren(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IncomingLoanVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
		}
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static IncomingLoanVw GetByMainWorkPlaceIdFirstOrDefault(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IncomingLoanVwGetByMainWorkPlaceIdFirstOrDefault(_mainWorkPlaceId);
		}
		#endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVwServices
    public static partial class InstallmentDecreaseOrderVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseOrderVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null.</returns>
		public static InstallmentDecreaseOrderVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseOrderVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> GetByMonth(DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseOrderVwGetByMonth(_month);
		}
        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentDecreaseOrderVw GetByMonthFirstOrDefault(DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseOrderVwGetByMonthFirstOrDefault(_month);
		}
		#endregion
	}
	#endregion

    #region InstallmentDecreaseVwServices
    public static partial class InstallmentDecreaseVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null.</returns>
		public static InstallmentDecreaseVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByDepartmentId(Nullable<int> _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByDepartmentId(_departmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentDecreaseVw GetByDepartmentIdFirstOrDefault(Nullable<int> _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByDepartmentIdFirstOrDefault(_departmentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentDecreaseVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId(int _installmentDecreaseOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId(_installmentDecreaseOrderId);
		}
        /// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentDecreaseVw GetByInstallmentDecreaseOrderIdFirstOrDefault(int _installmentDecreaseOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderIdFirstOrDefault(_installmentDecreaseOrderId);
		}		

        /// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId_EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId_EmployeeId(int _installmentDecreaseOrderId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId(_installmentDecreaseOrderId, _employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId_EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentDecreaseVw GetByInstallmentDecreaseOrderId_EmployeeIdFirstOrDefault(int _installmentDecreaseOrderId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeIdFirstOrDefault(_installmentDecreaseOrderId, _employeeId);
		}
		#endregion
	}
	#endregion

    #region InstallmentVwServices
    public static partial class InstallmentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InstallmentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentVw or null.</returns>
		public static InstallmentVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByDueDate(DateTime _dueDate, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByDueDate(_dueDate);
		}
        /// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentVw GetByDueDateFirstOrDefault(DateTime _dueDate, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByDueDateFirstOrDefault(_dueDate);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByRefundableProductProductId(_refundableProductProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentVw GetByRefundableProductProductIdFirstOrDefault(int _refundableProductProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByRefundableProductProductIdFirstOrDefault(_refundableProductProductId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, short _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
		}
        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InstallmentVw GetByRefundableProductProductId_SubNumberFirstOrDefault(int _refundableProductProductId, short _subNumber, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InstallmentVwGetByRefundableProductProductId_SubNumberFirstOrDefault(_refundableProductProductId, _subNumber);
		}
		#endregion
	}
	#endregion

    #region InsuranceTypeVwServices
    public static partial class InsuranceTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InsuranceTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InsuranceTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null.</returns>
		public static InsuranceTypeVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InsuranceTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InsuranceTypeVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InsuranceTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InsuranceTypeVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static InsuranceTypeVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.InsuranceTypeVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region IssuerVwServices
    public static partial class IssuerVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.IssuerVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IssuerVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.IssuerVw view.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IssuerVw or null.</returns>
		public static IssuerVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IssuerVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.IssuerVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IssuerVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IssuerVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IssuerVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IssuerVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static IssuerVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.IssuerVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region LoanChangeVwServices
    public static partial class LoanChangeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanChangeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanChangeVw or null.</returns>
		public static LoanChangeVw Get(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanChangeVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanChangeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanChangeVw GetChildren(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByFromLoanProductId(int _fromLoanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGetByFromLoanProductId(_fromLoanProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanChangeVw GetByFromLoanProductIdFirstOrDefault(int _fromLoanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGetByFromLoanProductIdFirstOrDefault(_fromLoanProductId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByLoanProductId(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGetByLoanProductId(_loanProductId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanChangeVw GetByLoanProductIdFirstOrDefault(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanChangeVwGetByLoanProductIdFirstOrDefault(_loanProductId);
		}
		#endregion
	}
	#endregion

    #region LoanDecisionTypeVwServices
    public static partial class LoanDecisionTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null.</returns>
		public static LoanDecisionTypeVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionTypeVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionTypeVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanDecisionTypeVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionTypeVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region LoanDecisionVwServices
    public static partial class LoanDecisionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionVw or null.</returns>
		public static LoanDecisionVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionVw> GetByNumber_Year(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionVwGetByNumber_Year(_number, _year);
		}
        /// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanDecisionVw GetByNumber_YearFirstOrDefault(short _number, short _year, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDecisionVwGetByNumber_YearFirstOrDefault(_number, _year);
		}
		#endregion
	}
	#endregion

    #region LoanDetailVwServices
    public static partial class LoanDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDetailVw or null.</returns>
		public static LoanDetailVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanDecisionId(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanDecisionId(_loanDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanDetailVw GetByLoanDecisionIdFirstOrDefault(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanDecisionIdFirstOrDefault(_loanDecisionId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanGenerationStatusId(_loanGenerationStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanDetailVw GetByLoanGenerationStatusIdFirstOrDefault(byte _loanGenerationStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanGenerationStatusIdFirstOrDefault(_loanGenerationStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanStatusId(byte _loanStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanStatusId(_loanStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanDetailVw GetByLoanStatusIdFirstOrDefault(byte _loanStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanDetailVwGetByLoanStatusIdFirstOrDefault(_loanStatusId);
		}
		#endregion
	}
	#endregion

    #region LoanExtendedVwServices
    public static partial class LoanExtendedVwServices
    {
	}
	#endregion
    #region LoanGenerationStatusVwServices
    public static partial class LoanGenerationStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanGenerationStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null.</returns>
		public static LoanGenerationStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanGenerationStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanGenerationStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanGenerationStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanGenerationStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanGenerationStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanGenerationStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region LoanRequestVwServices
    public static partial class LoanRequestVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanRequestVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanRequestVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanRequestVw or null.</returns>
		public static LoanRequestVw Get(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanRequestVwGet(_requestProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanRequestVw GetChildren(int _requestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanRequestVwGetChildren(_requestProductId);
		}
        #endregion
	}
	#endregion

    #region LoanStatusVwServices
    public static partial class LoanStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanStatusVw or null.</returns>
		public static LoanStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region LoanTypeClosureVwServices
    public static partial class LoanTypeClosureVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanTypeClosureVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null.</returns>
		public static LoanTypeClosureVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeClosureVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByClosingLoanTypeProductTypeId(short _closingLoanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByClosingLoanTypeProductTypeId(_closingLoanTypeProductTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanTypeClosureVw GetByClosingLoanTypeProductTypeIdFirstOrDefault(short _closingLoanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByClosingLoanTypeProductTypeIdFirstOrDefault(_closingLoanTypeProductTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanTypeClosureVw GetByLoanTypeProductTypeIdFirstOrDefault(short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeIdFirstOrDefault(_loanTypeProductTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId_ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(short _loanTypeProductTypeId, short _closingLoanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(_loanTypeProductTypeId, _closingLoanTypeProductTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId_ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanTypeClosureVw GetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeIdFirstOrDefault(short _loanTypeProductTypeId, short _closingLoanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeIdFirstOrDefault(_loanTypeProductTypeId, _closingLoanTypeProductTypeId);
		}
		#endregion
	}
	#endregion

    #region LoanTypeVwServices
    public static partial class LoanTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeVw view.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeVw or null.</returns>
		public static LoanTypeVw Get(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeVwGet(_productTypeId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeVw GetChildren(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanTypeVwGetChildren(_productTypeId);
		}
        #endregion
	}
	#endregion

    #region LoanVwServices
    public static partial class LoanVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanVw or null.</returns>
		public static LoanVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.LoanVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanVw GetChildren(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanDecisionId(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanDecisionId(_loanDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanVw GetByLoanDecisionIdFirstOrDefault(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanDecisionIdFirstOrDefault(_loanDecisionId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanGenerationStatusId(_loanGenerationStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanVw GetByLoanGenerationStatusIdFirstOrDefault(byte _loanGenerationStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanGenerationStatusIdFirstOrDefault(_loanGenerationStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanStatusId(byte _loanStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanStatusId(_loanStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static LoanVw GetByLoanStatusIdFirstOrDefault(byte _loanStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.LoanVwGetByLoanStatusIdFirstOrDefault(_loanStatusId);
		}
		#endregion
	}
	#endregion

    #region MainWorkPlaceVwServices
    public static partial class MainWorkPlaceVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MainWorkPlaceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MainWorkPlaceVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null.</returns>
		public static MainWorkPlaceVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MainWorkPlaceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MainWorkPlaceVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MainWorkPlaceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MainWorkPlaceVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static MainWorkPlaceVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MainWorkPlaceVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region MissingInstallmentDecreaseVwServices
    public static partial class MissingInstallmentDecreaseVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MissingInstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MissingInstallmentDecreaseVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MissingInstallmentDecreaseVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null.</returns>
		public static MissingInstallmentDecreaseVw Get(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MissingInstallmentDecreaseVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MissingInstallmentDecreaseVw GetChildren(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MissingInstallmentDecreaseVwGetChildren(_employeeId);
		}
        #endregion
	}
	#endregion

    #region MonthlyBalanceVwServices
    public static partial class MonthlyBalanceVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MonthlyBalanceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null.</returns>
		public static MonthlyBalanceVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MonthlyBalanceVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static MonthlyBalanceVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentGroupId_Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByEmployeeId_PaymentGroupId_Month(int _employeeId, byte _paymentGroupId, DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month(_employeeId, _paymentGroupId, _month);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentGroupId_Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static MonthlyBalanceVw GetByEmployeeId_PaymentGroupId_MonthFirstOrDefault(int _employeeId, byte _paymentGroupId, DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_MonthFirstOrDefault(_employeeId, _paymentGroupId, _month);
		}		

        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByMonth(DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByMonth(_month);
		}
        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static MonthlyBalanceVw GetByMonthFirstOrDefault(DateTime _month, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByMonthFirstOrDefault(_month);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByPaymentGroupId(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static MonthlyBalanceVw GetByPaymentGroupIdFirstOrDefault(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}
		#endregion
	}
	#endregion

    #region OutgoingLoanVwServices
    public static partial class OutgoingLoanVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.OutgoingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null.</returns>
		public static OutgoingLoanVw Get(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static OutgoingLoanVw GetChildren(int _loanProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByLoanDecisionId(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGetByLoanDecisionId(_loanDecisionId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static OutgoingLoanVw GetByLoanDecisionIdFirstOrDefault(int _loanDecisionId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGetByLoanDecisionIdFirstOrDefault(_loanDecisionId);
		}		

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
		}
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static OutgoingLoanVw GetByMainWorkPlaceIdFirstOrDefault(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.OutgoingLoanVwGetByMainWorkPlaceIdFirstOrDefault(_mainWorkPlaceId);
		}
		#endregion
	}
	#endregion

    #region PaymentDetailVwServices
    public static partial class PaymentDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentDetailVw or null.</returns>
		public static PaymentDetailVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByCollectOrderId(Nullable<int> _collectOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByCollectOrderId(_collectOrderId);
		}
        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentDetailVw GetByCollectOrderIdFirstOrDefault(Nullable<int> _collectOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByCollectOrderIdFirstOrDefault(_collectOrderId);
		}		

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentDetailVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentDetailVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentGroupId(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentDetailVw GetByPaymentGroupIdFirstOrDefault(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByPaymentStatusId(_paymentStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentDetailVw GetByPaymentStatusIdFirstOrDefault(Nullable<byte> _paymentStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentDetailVwGetByPaymentStatusIdFirstOrDefault(_paymentStatusId);
		}
		#endregion
	}
	#endregion

    #region PaymentGroupVwServices
    public static partial class PaymentGroupVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentGroupVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentGroupVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentGroupVw or null.</returns>
		public static PaymentGroupVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentGroupVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentGroupVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentGroupVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentGroupVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentGroupVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentGroupVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region PaymentStatusVwServices
    public static partial class PaymentStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentStatusVw or null.</returns>
		public static PaymentStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentStatusVwGetChildren(_id);
		}
        #endregion
	}
	#endregion

    #region PaymentVwServices
    public static partial class PaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentVw or null.</returns>
		public static PaymentVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByCollectOrderId(Nullable<int> _collectOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByCollectOrderId(_collectOrderId);
		}
        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentVw GetByCollectOrderIdFirstOrDefault(Nullable<int> _collectOrderId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByCollectOrderIdFirstOrDefault(_collectOrderId);
		}		

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentGroupId(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentVw GetByPaymentGroupIdFirstOrDefault(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByPaymentStatusId(_paymentStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PaymentVw GetByPaymentStatusIdFirstOrDefault(Nullable<byte> _paymentStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PaymentVwGetByPaymentStatusIdFirstOrDefault(_paymentStatusId);
		}
		#endregion
	}
	#endregion

    #region PayOrderVwServices
    public static partial class PayOrderVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PayOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PayOrderVw or null.</returns>
		public static PayOrderVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.PayOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PayOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PayOrderVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PayOrderVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PayOrderVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByIsFixed(byte _isFixed, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByIsFixed(_isFixed);
		}
        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PayOrderVw GetByIsFixedFirstOrDefault(byte _isFixed, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByIsFixedFirstOrDefault(_isFixed);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByPaymentGroupId(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static PayOrderVw GetByPaymentGroupIdFirstOrDefault(byte _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.PayOrderVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}
		#endregion
	}
	#endregion

    #region ProductDetailVwServices
    public static partial class ProductDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductDetailVw or null.</returns>
		public static ProductDetailVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductDetailVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByProductTypeId(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwGetByProductTypeId(_productTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductDetailVw GetByProductTypeIdFirstOrDefault(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductDetailVwGetByProductTypeIdFirstOrDefault(_productTypeId);
		}
		#endregion
	}
	#endregion

    #region ProductTypeAvailabilityVwServices
    public static partial class ProductTypeAvailabilityVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null.</returns>
		public static ProductTypeAvailabilityVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeAvailabilityVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByAvailabilityId(short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByAvailabilityId(_availabilityId);
		}
        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeAvailabilityVw GetByAvailabilityIdFirstOrDefault(short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByAvailabilityIdFirstOrDefault(_availabilityId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByProductTypeId(_productTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeAvailabilityVw GetByProductTypeIdFirstOrDefault(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByProductTypeIdFirstOrDefault(_productTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId_AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId_AvailabilityId(short _productTypeId, short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId(_productTypeId, _availabilityId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProductTypeId_AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeAvailabilityVw GetByProductTypeId_AvailabilityIdFirstOrDefault(short _productTypeId, short _availabilityId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityIdFirstOrDefault(_productTypeId, _availabilityId);
		}
		#endregion
	}
	#endregion

    #region ProductTypeDetailVwServices
    public static partial class ProductTypeDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductTypeDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeDetailVw or null.</returns>
		public static ProductTypeDetailVw Get(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeDetailVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByNameFirstOrDefault(_name);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeDetailVw GetByPaymentGroupIdFirstOrDefault(Nullable<byte> _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByProfitStrategyId(_profitStrategyId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeDetailVw GetByProfitStrategyIdFirstOrDefault(Nullable<byte> _profitStrategyId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeDetailVwGetByProfitStrategyIdFirstOrDefault(_profitStrategyId);
		}
		#endregion
	}
	#endregion

    #region ProductTypeVwServices
    public static partial class ProductTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeVw or null.</returns>
		public static ProductTypeVw Get(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeVw GetChildren(short _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByNameFirstOrDefault(_name);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByPaymentGroupId(_paymentGroupId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeVw GetByPaymentGroupIdFirstOrDefault(Nullable<byte> _paymentGroupId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByPaymentGroupIdFirstOrDefault(_paymentGroupId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByProfitStrategyId(_profitStrategyId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductTypeVw GetByProfitStrategyIdFirstOrDefault(Nullable<byte> _profitStrategyId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductTypeVwGetByProfitStrategyIdFirstOrDefault(_profitStrategyId);
		}
		#endregion
	}
	#endregion

    #region ProductVwServices
    public static partial class ProductVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductVw or null.</returns>
		public static ProductVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ProductVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByProductTypeId(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGetByProductTypeId(_productTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProductVw GetByProductTypeIdFirstOrDefault(short _productTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProductVwGetByProductTypeIdFirstOrDefault(_productTypeId);
		}
		#endregion
	}
	#endregion

    #region ProfileVwServices
    public static partial class ProfileVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProfileVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfileVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfileVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfileVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProfileVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfileVw or null.</returns>
		public static ProfileVw Get(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfileVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ProfileVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfileVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfileVw GetChildren(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfileVwGetChildren(_employeeId);
		}
        #endregion
	}
	#endregion

    #region ProfitStrategyVwServices
    public static partial class ProfitStrategyVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProfitStrategyVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfitStrategyVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null.</returns>
		public static ProfitStrategyVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfitStrategyVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfitStrategyVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfitStrategyVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfitStrategyVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ProfitStrategyVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ProfitStrategyVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region RefundableProductVwServices
    public static partial class RefundableProductVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RefundableProductVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RefundableProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RefundableProductVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RefundableProductVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RefundableProductVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RefundableProductVw or null.</returns>
		public static RefundableProductVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RefundableProductVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.RefundableProductVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RefundableProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RefundableProductVw GetChildren(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RefundableProductVwGetChildren(_productId);
		}
        #endregion
	}
	#endregion

    #region RequestDetailVwServices
    public static partial class RequestDetailVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RequestDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestDetailVw or null.</returns>
		public static RequestDetailVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByBypassStatusId(int _bypassStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwGetByBypassStatusId(_bypassStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static RequestDetailVw GetByBypassStatusIdFirstOrDefault(int _bypassStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwGetByBypassStatusIdFirstOrDefault(_bypassStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByRequestStatusId(Nullable<byte> _requestStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwGetByRequestStatusId(_requestStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static RequestDetailVw GetByRequestStatusIdFirstOrDefault(Nullable<byte> _requestStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestDetailVwGetByRequestStatusIdFirstOrDefault(_requestStatusId);
		}
		#endregion
	}
	#endregion

    #region RequestStatusVwServices
    public static partial class RequestStatusVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RequestStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestStatusVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestStatusVw or null.</returns>
		public static RequestStatusVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.RequestStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestStatusVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestStatusVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static RequestStatusVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestStatusVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region RequestVwServices
    public static partial class RequestVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RequestVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestVw or null.</returns>
		public static RequestVw Get(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.RequestVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestVw GetChildren(int _productId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByBypassStatusId(int _bypassStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGetByBypassStatusId(_bypassStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static RequestVw GetByBypassStatusIdFirstOrDefault(int _bypassStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGetByBypassStatusIdFirstOrDefault(_bypassStatusId);
		}		

        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByRequestStatusId(Nullable<byte> _requestStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGetByRequestStatusId(_requestStatusId);
		}
        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static RequestVw GetByRequestStatusIdFirstOrDefault(Nullable<byte> _requestStatusId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.RequestVwGetByRequestStatusIdFirstOrDefault(_requestStatusId);
		}
		#endregion
	}
	#endregion

    #region ResourceVwServices
    public static partial class ResourceVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ResourceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ResourceVw view.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ResourceVw or null.</returns>
		public static ResourceVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ResourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ResourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ResourceVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Language_Module_Key columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> GetByLanguage_Module_Key(string _language, string _module, string _key, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGetByLanguage_Module_Key(_language, _module, _key);
		}
        /// <summary>
		/// Gets rows related to one combination of Language_Module_Key columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ResourceVw GetByLanguage_Module_KeyFirstOrDefault(string _language, string _module, string _key, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGetByLanguage_Module_KeyFirstOrDefault(_language, _module, _key);
		}		

        /// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> GetByModule(string _module, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGetByModule(_module);
		}
        /// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static ResourceVw GetByModuleFirstOrDefault(string _module, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ResourceVwGetByModuleFirstOrDefault(_module);
		}
		#endregion
	}
	#endregion

    #region SalaryPaymentVwServices
    public static partial class SalaryPaymentVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SalaryPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryPaymentVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null.</returns>
		public static SalaryPaymentVw Get(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryPaymentVw GetChildren(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryPaymentVwGetChildren(_paymentId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> GetByDepartmentId(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryPaymentVwGetByDepartmentId(_departmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SalaryPaymentVw GetByDepartmentIdFirstOrDefault(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryPaymentVwGetByDepartmentIdFirstOrDefault(_departmentId);
		}
		#endregion
	}
	#endregion

    #region SalaryWorkPlaceVwServices
    public static partial class SalaryWorkPlaceVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null.</returns>
		public static SalaryWorkPlaceVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryWorkPlaceVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGetByMainWorkPlaceId(_mainWorkPlaceId);
		}
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SalaryWorkPlaceVw GetByMainWorkPlaceIdFirstOrDefault(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGetByMainWorkPlaceIdFirstOrDefault(_mainWorkPlaceId);
		}		

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SalaryWorkPlaceVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SalaryWorkPlaceVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region ServiceEndGrantRequestVwServices
    public static partial class ServiceEndGrantRequestVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ServiceEndGrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ServiceEndGrantRequestVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ServiceEndGrantRequestVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null.</returns>
		public static ServiceEndGrantRequestVw Get(int _grantRequestRequestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ServiceEndGrantRequestVwGet(_grantRequestRequestProductId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ServiceEndGrantRequestVw GetChildren(int _grantRequestRequestProductId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.ServiceEndGrantRequestVwGetChildren(_grantRequestRequestProductId);
		}
        #endregion
	}
	#endregion

    #region SettlementVwServices
    public static partial class SettlementVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SettlementVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SettlementVw view.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SettlementVw or null.</returns>
		public static SettlementVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SettlementVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SettlementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SettlementVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByInstallmentId(int _installmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByInstallmentId(_installmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SettlementVw GetByInstallmentIdFirstOrDefault(int _installmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByInstallmentIdFirstOrDefault(_installmentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of InstallmentId_PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <param name="_paymentId">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByInstallmentId_PaymentId(int _installmentId, int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByInstallmentId_PaymentId(_installmentId, _paymentId);
		}
        /// <summary>
		/// Gets rows related to one combination of InstallmentId_PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <param name="_paymentId">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SettlementVw GetByInstallmentId_PaymentIdFirstOrDefault(int _installmentId, int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByInstallmentId_PaymentIdFirstOrDefault(_installmentId, _paymentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByPaymentId(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByPaymentId(_paymentId);
		}
        /// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SettlementVw GetByPaymentIdFirstOrDefault(int _paymentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SettlementVwGetByPaymentIdFirstOrDefault(_paymentId);
		}
		#endregion
	}
	#endregion

    #region SpecialCaseLoanVwServices
    public static partial class SpecialCaseLoanVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null.</returns>
		public static SpecialCaseLoanVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SpecialCaseLoanVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByDate(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByDate(_date);
		}
        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SpecialCaseLoanVw GetByDateFirstOrDefault(DateTime _date, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByDateFirstOrDefault(_date);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SpecialCaseLoanVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId_Date_LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByEmployeeId_Date_LoanTypeProductTypeId(int _employeeId, DateTime _date, short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId(_employeeId, _date, _loanTypeProductTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId_Date_LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SpecialCaseLoanVw GetByEmployeeId_Date_LoanTypeProductTypeIdFirstOrDefault(int _employeeId, DateTime _date, short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeIdFirstOrDefault(_employeeId, _date, _loanTypeProductTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SpecialCaseLoanVw GetByLoanTypeProductTypeIdFirstOrDefault(short _loanTypeProductTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SpecialCaseLoanVwGetByLoanTypeProductTypeIdFirstOrDefault(_loanTypeProductTypeId);
		}
		#endregion
	}
	#endregion

    #region SubscriptionTypeVwServices
    public static partial class SubscriptionTypeVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SubscriptionTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionTypeVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null.</returns>
		public static SubscriptionTypeVw Get(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionTypeVw GetChildren(byte _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> GetByName(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionTypeVwGetByName(_name);
		}
        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionTypeVw GetByNameFirstOrDefault(string _name, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionTypeVwGetByNameFirstOrDefault(_name);
		}
		#endregion
	}
	#endregion

    #region SubscriptionVwServices
    public static partial class SubscriptionVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SubscriptionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionVw or null.</returns>
		public static SubscriptionVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByDepartmentId(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByDepartmentId(_departmentId);
		}
        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionVw GetByDepartmentIdFirstOrDefault(int _departmentId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByDepartmentIdFirstOrDefault(_departmentId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId_Month_DepartmentId_SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_departmentId">الفعالية</param>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(int _employeeId, DateTime _month, int _departmentId, byte _subscriptionTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(_employeeId, _month, _departmentId, _subscriptionTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId_Month_DepartmentId_SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_departmentId">الفعالية</param>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionVw GetByEmployeeId_Month_DepartmentId_SubscriptionTypeIdFirstOrDefault(int _employeeId, DateTime _month, int _departmentId, byte _subscriptionTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeIdFirstOrDefault(_employeeId, _month, _departmentId, _subscriptionTypeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByIsFixed(bool _isFixed, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByIsFixed(_isFixed);
		}
        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionVw GetByIsFixedFirstOrDefault(bool _isFixed, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetByIsFixedFirstOrDefault(_isFixed);
		}		

        /// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetBySubscriptionTypeId(byte _subscriptionTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetBySubscriptionTypeId(_subscriptionTypeId);
		}
        /// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static SubscriptionVw GetBySubscriptionTypeIdFirstOrDefault(byte _subscriptionTypeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.SubscriptionVwGetBySubscriptionTypeIdFirstOrDefault(_subscriptionTypeId);
		}
		#endregion
	}
	#endregion

    #region TransitoryIncomingLoanVwServices
    public static partial class TransitoryIncomingLoanVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null.</returns>
		public static TransitoryIncomingLoanVw Get(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static TransitoryIncomingLoanVw GetChildren(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGetChildren(_employeeId);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByIsVerified(bool _isVerified, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGetByIsVerified(_isVerified);
		}
        /// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static TransitoryIncomingLoanVw GetByIsVerifiedFirstOrDefault(bool _isVerified, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGetByIsVerifiedFirstOrDefault(_isVerified);
		}		

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
		}
        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static TransitoryIncomingLoanVw GetByMainWorkPlaceIdFirstOrDefault(int _mainWorkPlaceId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.TransitoryIncomingLoanVwGetByMainWorkPlaceIdFirstOrDefault(_mainWorkPlaceId);
		}
		#endregion
	}
	#endregion

    #region WarrantVwServices
    public static partial class WarrantVwServices
    {
		#region List procedure
        /// <summary>
		/// Selects all rows from the dbo.WarrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> List(Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwList();
		}
        #endregion

		#region Get procedure
        /// <summary>
		/// Gets one row from the dbo.WarrantVw view.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of WarrantVw or null.</returns>
		public static WarrantVw Get(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
        /// <summary>
		/// Gets one row from the dbo.WarrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of WarrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static WarrantVw GetChildren(int _id, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
        /// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByDebtId(int _debtId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByDebtId(_debtId);
		}
        /// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static WarrantVw GetByDebtIdFirstOrDefault(int _debtId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByDebtIdFirstOrDefault(_debtId);
		}		

        /// <summary>
		/// Gets rows related to one combination of DebtId_EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByDebtId_EmployeeId(int _debtId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByDebtId_EmployeeId(_debtId, _employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of DebtId_EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static WarrantVw GetByDebtId_EmployeeIdFirstOrDefault(int _debtId, int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByDebtId_EmployeeIdFirstOrDefault(_debtId, _employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByEmployeeId(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByEmployeeId(_employeeId);
		}
        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static WarrantVw GetByEmployeeIdFirstOrDefault(int _employeeId, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByEmployeeIdFirstOrDefault(_employeeId);
		}		

        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByIsActive(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByIsActive(_isActive);
		}
        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static WarrantVw GetByIsActiveFirstOrDefault(bool _isActive, Db db = null)
		{
			if (db == null)
	            db = new Db(DbServices.ConnectionString);
			return db.WarrantVwGetByIsActiveFirstOrDefault(_isActive);
		}
		#endregion
	}
	#endregion
}
