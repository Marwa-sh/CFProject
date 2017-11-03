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
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> List(Db db)
		{
			return db.AvailabilityCeilingVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null.</returns>
		public static AvailabilityCeilingVw Get(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null.</returns>
		public static AvailabilityCeilingVw Get(short _id, Db db)
		{
			return db.AvailabilityCeilingVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityCeilingVw GetChildren(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeilingVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityCeilingVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityCeilingVw GetChildren(short _id, Db db)
		{
			return db.AvailabilityCeilingVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> GetByAvailabilityId(short _availabilityId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByAvailabilityId(_availabilityId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> GetByAvailabilityId(short _availabilityId, Db db)
		{
			return db.AvailabilityCeilingVwGetByAvailabilityId(_availabilityId);
		}		

		/// <summary>
		/// Gets rows related to one combination of AvailabilityId_FromYear columns in the  dbo.AvailabilityCeilingVw view.
		/// </summary>
		/// <param name="_availabilityId">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		/// <returns>A list of AvailabilityCeilingVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityCeilingVw> GetByAvailabilityId_FromYear(short _availabilityId, short _fromYear)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByAvailabilityId_FromYear(_availabilityId, _fromYear, db);
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
		public static List<AvailabilityCeilingVw> GetByAvailabilityId_FromYear(short _availabilityId, short _fromYear, Db db)
		{
			return db.AvailabilityCeilingVwGetByAvailabilityId_FromYear(_availabilityId, _fromYear);
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
		/// <returns>A list of AvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.AvailabilityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of AvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<AvailabilityVw> List(Db db)
		{
			return db.AvailabilityVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.AvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		/// <returns>Gets an instance of AvailabilityVw or null.</returns>
		public static AvailabilityVw Get(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.AvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityVw or null.</returns>
		public static AvailabilityVw Get(short _id, Db db)
		{
			return db.AvailabilityVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.AvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		/// <returns>Gets an instance of AvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityVw GetChildren(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.AvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of AvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static AvailabilityVw GetChildren(short _id, Db db)
		{
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
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.BypassStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> List(Db db)
		{
			return db.BypassStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		/// <returns>Gets an instance of BypassStatusVw or null.</returns>
		public static BypassStatusVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of BypassStatusVw or null.</returns>
		public static BypassStatusVw Get(int _id, Db db)
		{
			return db.BypassStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.BypassStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		/// <returns>Gets an instance of BypassStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static BypassStatusVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.BypassStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of BypassStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static BypassStatusVw GetChildren(int _id, Db db)
		{
			return db.BypassStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.BypassStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of BypassStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<BypassStatusVw> GetByName(string _name, Db db)
		{
			return db.BypassStatusVwGetByName(_name);
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
		/// <returns>A list of CashPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CashPaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.CashPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CashPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CashPaymentVw> List(Db db)
		{
			return db.CashPaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.CashPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of CashPaymentVw or null.</returns>
		public static CashPaymentVw Get(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CashPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CashPaymentVw or null.</returns>
		public static CashPaymentVw Get(int _paymentId, Db db)
		{
			return db.CashPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.CashPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of CashPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CashPaymentVw GetChildren(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CashPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CashPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CashPaymentVw GetChildren(int _paymentId, Db db)
		{
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
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.CategoryVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> List(Db db)
		{
			return db.CategoryVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.CategoryVw view.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		/// <returns>Gets an instance of CategoryVw or null.</returns>
		public static CategoryVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CategoryVw view.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CategoryVw or null.</returns>
		public static CategoryVw Get(byte _id, Db db)
		{
			return db.CategoryVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.CategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		/// <returns>Gets an instance of CategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CategoryVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CategoryVw GetChildren(byte _id, Db db)
		{
			return db.CategoryVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.CategoryVw view.
		/// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CategoryVw> GetByName(string _name, Db db)
		{
			return db.CategoryVwGetByName(_name);
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
		/// <returns>A list of CollectOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CollectOrderVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.CollectOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of CollectOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<CollectOrderVw> List(Db db)
		{
			return db.CollectOrderVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.CollectOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		/// <returns>Gets an instance of CollectOrderVw or null.</returns>
		public static CollectOrderVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CollectOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CollectOrderVw or null.</returns>
		public static CollectOrderVw Get(int _id, Db db)
		{
			return db.CollectOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.CollectOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		/// <returns>Gets an instance of CollectOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CollectOrderVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.CollectOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of CollectOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static CollectOrderVw GetChildren(int _id, Db db)
		{
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
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.DebtVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> List(Db db)
		{
			return db.DebtVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.DebtVw view.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		/// <returns>Gets an instance of DebtVw or null.</returns>
		public static DebtVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DebtVw view.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DebtVw or null.</returns>
		public static DebtVw Get(int _id, Db db)
		{
			return db.DebtVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.DebtVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		/// <returns>Gets an instance of DebtVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DebtVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DebtVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DebtVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DebtVw GetChildren(int _id, Db db)
		{
			return db.DebtVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByDate(Nullable<DateTime> _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByDate(Nullable<DateTime> _date, Db db)
		{
			return db.DebtVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.DebtVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIsActive(bool _isActive)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsActive(_isActive, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIsActive(bool _isActive, Db db)
		{
			return db.DebtVwGetByIsActive(_isActive);
		}		

		/// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIssuerId(byte _issuerId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIssuerId(_issuerId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IssuerId columns in the  dbo.DebtVw view.
		/// </summary>
		/// <param name="_issuerId">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DebtVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DebtVw> GetByIssuerId(byte _issuerId, Db db)
		{
			return db.DebtVwGetByIssuerId(_issuerId);
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
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.DepartmentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> List(Db db)
		{
			return db.DepartmentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		/// <returns>Gets an instance of DepartmentVw or null.</returns>
		public static DepartmentVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DepartmentVw or null.</returns>
		public static DepartmentVw Get(int _id, Db db)
		{
			return db.DepartmentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.DepartmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		/// <returns>Gets an instance of DepartmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DepartmentVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DepartmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DepartmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DepartmentVw GetChildren(int _id, Db db)
		{
			return db.DepartmentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetByName(string _name, Db db)
		{
			return db.DepartmentVwGetByName(_name);
		}		

		/// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetBySalaryWorkPlaceId(int _salaryWorkPlaceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetBySalaryWorkPlaceId(_salaryWorkPlaceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of SalaryWorkPlaceId columns in the  dbo.DepartmentVw view.
		/// </summary>
		/// <param name="_salaryWorkPlaceId">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DepartmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DepartmentVw> GetBySalaryWorkPlaceId(int _salaryWorkPlaceId, Db db)
		{
			return db.DepartmentVwGetBySalaryWorkPlaceId(_salaryWorkPlaceId);
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
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.DownPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> List(Db db)
		{
			return db.DownPaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of DownPaymentVw or null.</returns>
		public static DownPaymentVw Get(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DownPaymentVw or null.</returns>
		public static DownPaymentVw Get(int _paymentId, Db db)
		{
			return db.DownPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.DownPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		/// <returns>Gets an instance of DownPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DownPaymentVw GetChildren(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.DownPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of DownPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static DownPaymentVw GetChildren(int _paymentId, Db db)
		{
			return db.DownPaymentVwGetChildren(_paymentId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> GetByRequestProductId(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRequestProductId(_requestProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RequestProductId columns in the  dbo.DownPaymentVw view.
		/// </summary>
		/// <param name="_requestProductId">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of DownPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<DownPaymentVw> GetByRequestProductId(int _requestProductId, Db db)
		{
			return db.DownPaymentVwGetByRequestProductId(_requestProductId);
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
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EmployeeDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> List(Db db)
		{
			return db.EmployeeDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeDetailVw or null.</returns>
		public static EmployeeDetailVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeDetailVw or null.</returns>
		public static EmployeeDetailVw Get(int _id, Db db)
		{
			return db.EmployeeDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByCategoryId(byte _categoryId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByCategoryId(_categoryId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByCategoryId(byte _categoryId, Db db)
		{
			return db.EmployeeDetailVwGetByCategoryId(_categoryId);
		}		

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByDepartmentId(int _departmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartmentId(_departmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByDepartmentId(int _departmentId, Db db)
		{
			return db.EmployeeDetailVwGetByDepartmentId(_departmentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByEmployeeStatusId(byte _employeeStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeStatusId(_employeeStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByEmployeeStatusId(byte _employeeStatusId, Db db)
		{
			return db.EmployeeDetailVwGetByEmployeeStatusId(_employeeStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeDetailVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>A list of EmployeeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeDetailVw> GetByFirstName_LastName(string _firstName, string _lastName)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByFirstName_LastName(_firstName, _lastName, db);
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
		public static List<EmployeeDetailVw> GetByFirstName_LastName(string _firstName, string _lastName, Db db)
		{
			return db.EmployeeDetailVwGetByFirstName_LastName(_firstName, _lastName);
		}
		#endregion
	}
	#endregion

    #region EmployeeSeniorityVwServices
    public static partial class EmployeeSeniorityVwServices
    {
		#region List procedure
		/// <summary>
		/// Selects all rows from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <returns>A list of EmployeeSeniorityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeSeniorityVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeSeniorityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeSeniorityVw> List(Db db)
		{
			return db.EmployeeSeniorityVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null.</returns>
		public static EmployeeSeniorityVw Get(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null.</returns>
		public static EmployeeSeniorityVw Get(int _employeeId, Db db)
		{
			return db.EmployeeSeniorityVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeSeniorityVw GetChildren(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniorityVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeSeniorityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeSeniorityVw GetChildren(int _employeeId, Db db)
		{
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
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EmployeeStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> List(Db db)
		{
			return db.EmployeeStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null.</returns>
		public static EmployeeStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null.</returns>
		public static EmployeeStatusVw Get(byte _id, Db db)
		{
			return db.EmployeeStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeStatusVw GetChildren(byte _id, Db db)
		{
			return db.EmployeeStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByIsActive(bool _isActive)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsActive(_isActive, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByIsActive(bool _isActive, Db db)
		{
			return db.EmployeeStatusVwGetByIsActive(_isActive);
		}		

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EmployeeStatusVw view.
		/// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeStatusVw> GetByName(string _name, Db db)
		{
			return db.EmployeeStatusVwGetByName(_name);
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
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EmployeeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> List(Db db)
		{
			return db.EmployeeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeVw or null.</returns>
		public static EmployeeVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeVw or null.</returns>
		public static EmployeeVw Get(int _id, Db db)
		{
			return db.EmployeeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EmployeeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		/// <returns>Gets an instance of EmployeeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EmployeeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EmployeeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EmployeeVw GetChildren(int _id, Db db)
		{
			return db.EmployeeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByCategoryId(byte _categoryId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByCategoryId(_categoryId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of CategoryId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_categoryId">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByCategoryId(byte _categoryId, Db db)
		{
			return db.EmployeeVwGetByCategoryId(_categoryId);
		}		

		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByDepartmentId(int _departmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartmentId(_departmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByDepartmentId(int _departmentId, Db db)
		{
			return db.EmployeeVwGetByDepartmentId(_departmentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByEmployeeStatusId(byte _employeeStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeStatusId(_employeeStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeStatusId columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_employeeStatusId">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByEmployeeStatusId(byte _employeeStatusId, Db db)
		{
			return db.EmployeeVwGetByEmployeeStatusId(_employeeStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of FirstName_LastName columns in the  dbo.EmployeeVw view.
		/// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		/// <returns>A list of EmployeeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeVw> GetByFirstName_LastName(string _firstName, string _lastName)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByFirstName_LastName(_firstName, _lastName, db);
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
		public static List<EmployeeVw> GetByFirstName_LastName(string _firstName, string _lastName, Db db)
		{
			return db.EmployeeVwGetByFirstName_LastName(_firstName, _lastName);
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
		/// <returns>A list of EndWorkGrantBracketVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EndWorkGrantBracketVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EndWorkGrantBracketVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EndWorkGrantBracketVw> List(Db db)
		{
			return db.EndWorkGrantBracketVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null.</returns>
		public static EndWorkGrantBracketVw Get(byte _fromYear)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_fromYear, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null.</returns>
		public static EndWorkGrantBracketVw Get(byte _fromYear, Db db)
		{
			return db.EndWorkGrantBracketVwGet(_fromYear);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view with related objects from children.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EndWorkGrantBracketVw GetChildren(byte _fromYear)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_fromYear, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracketVw view with related objects from children.
		/// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EndWorkGrantBracketVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EndWorkGrantBracketVw GetChildren(byte _fromYear, Db db)
		{
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
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ErrorDefinitionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> List(Db db)
		{
			return db.ErrorDefinitionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null.</returns>
		public static ErrorDefinitionVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null.</returns>
		public static ErrorDefinitionVw Get(int _id, Db db)
		{
			return db.ErrorDefinitionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ErrorDefinitionVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ErrorDefinitionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ErrorDefinitionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ErrorDefinitionVw GetChildren(int _id, Db db)
		{
			return db.ErrorDefinitionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> GetByLikeExpression(string _likeExpression)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLikeExpression(_likeExpression, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinitionVw view.
		/// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ErrorDefinitionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ErrorDefinitionVw> GetByLikeExpression(string _likeExpression, Db db)
		{
			return db.ErrorDefinitionVwGetByLikeExpression(_likeExpression);
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
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventCategoryVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> List(Db db)
		{
			return db.EventCategoryVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		/// <returns>Gets an instance of EventCategoryVw or null.</returns>
		public static EventCategoryVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventCategoryVw or null.</returns>
		public static EventCategoryVw Get(int _id, Db db)
		{
			return db.EventCategoryVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EventCategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		/// <returns>Gets an instance of EventCategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventCategoryVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventCategoryVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventCategoryVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventCategoryVw GetChildren(int _id, Db db)
		{
			return db.EventCategoryVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventCategoryVw view.
		/// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventCategoryVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventCategoryVw> GetByName(string _name, Db db)
		{
			return db.EventCategoryVwGetByName(_name);
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
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventLogDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> List(Db db)
		{
			return db.EventLogDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogDetailVw or null.</returns>
		public static EventLogDetailVw Get(long _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogDetailVw or null.</returns>
		public static EventLogDetailVw Get(long _id, Db db)
		{
			return db.EventLogDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByDate(DateTime _date, Db db)
		{
			return db.EventLogDetailVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventCategoryId(int _eventCategoryId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventCategoryId(_eventCategoryId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventCategoryId(int _eventCategoryId, Db db)
		{
			return db.EventLogDetailVwGetByEventCategoryId(_eventCategoryId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventSourceId(int _eventSourceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventSourceId(_eventSourceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventSourceId(int _eventSourceId, Db db)
		{
			return db.EventLogDetailVwGetByEventSourceId(_eventSourceId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventStatusId(int _eventStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventStatusId(_eventStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByEventStatusId(int _eventStatusId, Db db)
		{
			return db.EventLogDetailVwGetByEventStatusId(_eventStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByUser(int _user)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByUser(_user, db);
		}

        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogDetailVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogDetailVw> GetByUser(int _user, Db db)
		{
			return db.EventLogDetailVwGetByUser(_user);
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
		/// <returns>A list of EventLogErrorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogErrorVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventLogErrorVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogErrorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogErrorVw> List(Db db)
		{
			return db.EventLogErrorVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogErrorVw or null.</returns>
		public static EventLogErrorVw Get(long _eventLogId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_eventLogId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogErrorVw or null.</returns>
		public static EventLogErrorVw Get(long _eventLogId, Db db)
		{
			return db.EventLogErrorVwGet(_eventLogId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view with related objects from children.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogErrorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogErrorVw GetChildren(long _eventLogId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_eventLogId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventLogErrorVw view with related objects from children.
		/// </summary>
		/// <param name="_eventLogId">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogErrorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogErrorVw GetChildren(long _eventLogId, Db db)
		{
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
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventLogVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> List(Db db)
		{
			return db.EventLogVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventLogVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogVw or null.</returns>
		public static EventLogVw Get(long _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventLogVw view.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogVw or null.</returns>
		public static EventLogVw Get(long _id, Db db)
		{
			return db.EventLogVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EventLogVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		/// <returns>Gets an instance of EventLogVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogVw GetChildren(long _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventLogVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventLogVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventLogVw GetChildren(long _id, Db db)
		{
			return db.EventLogVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByDate(DateTime _date, Db db)
		{
			return db.EventLogVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventCategoryId(int _eventCategoryId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventCategoryId(_eventCategoryId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventCategoryId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventCategoryId">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventCategoryId(int _eventCategoryId, Db db)
		{
			return db.EventLogVwGetByEventCategoryId(_eventCategoryId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventSourceId(int _eventSourceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventSourceId(_eventSourceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventSourceId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventSourceId">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventSourceId(int _eventSourceId, Db db)
		{
			return db.EventLogVwGetByEventSourceId(_eventSourceId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventStatusId(int _eventStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEventStatusId(_eventStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EventStatusId columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_eventStatusId">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByEventStatusId(int _eventStatusId, Db db)
		{
			return db.EventLogVwGetByEventStatusId(_eventStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByUser(int _user)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByUser(_user, db);
		}

        /// <summary>
		/// Gets rows related to one combination of User columns in the  dbo.EventLogVw view.
		/// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventLogVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventLogVw> GetByUser(int _user, Db db)
		{
			return db.EventLogVwGetByUser(_user);
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
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventSourceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> List(Db db)
		{
			return db.EventSourceVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		/// <returns>Gets an instance of EventSourceVw or null.</returns>
		public static EventSourceVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventSourceVw or null.</returns>
		public static EventSourceVw Get(int _id, Db db)
		{
			return db.EventSourceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EventSourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		/// <returns>Gets an instance of EventSourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventSourceVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventSourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventSourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventSourceVw GetChildren(int _id, Db db)
		{
			return db.EventSourceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventSourceVw view.
		/// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventSourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventSourceVw> GetByName(string _name, Db db)
		{
			return db.EventSourceVwGetByName(_name);
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
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.EventStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> List(Db db)
		{
			return db.EventStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		/// <returns>Gets an instance of EventStatusVw or null.</returns>
		public static EventStatusVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventStatusVw or null.</returns>
		public static EventStatusVw Get(int _id, Db db)
		{
			return db.EventStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.EventStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		/// <returns>Gets an instance of EventStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventStatusVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.EventStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of EventStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static EventStatusVw GetChildren(int _id, Db db)
		{
			return db.EventStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.EventStatusVw view.
		/// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of EventStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EventStatusVw> GetByName(string _name, Db db)
		{
			return db.EventStatusVwGetByName(_name);
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
		/// <returns>A list of ExceptionalAmountTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountTypeVw> List(Db db)
		{
			return db.ExceptionalAmountTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null.</returns>
		public static ExceptionalAmountTypeVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null.</returns>
		public static ExceptionalAmountTypeVw Get(byte _id, Db db)
		{
			return db.ExceptionalAmountTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountTypeVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountTypeVw GetChildren(byte _id, Db db)
		{
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
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> List(Db db)
		{
			return db.ExceptionalAmountVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null.</returns>
		public static ExceptionalAmountVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null.</returns>
		public static ExceptionalAmountVw Get(int _id, Db db)
		{
			return db.ExceptionalAmountVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExceptionalAmountVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExceptionalAmountVw GetChildren(int _id, Db db)
		{
			return db.ExceptionalAmountVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByExceptionalAmountTypeId(byte _exceptionalAmountTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByExceptionalAmountTypeId(_exceptionalAmountTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ExceptionalAmountTypeId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_exceptionalAmountTypeId">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByExceptionalAmountTypeId(byte _exceptionalAmountTypeId, Db db)
		{
			return db.ExceptionalAmountVwGetByExceptionalAmountTypeId(_exceptionalAmountTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByLoanRequestRequestProductId(int _loanRequestRequestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanRequestRequestProductId(_loanRequestRequestProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanRequestRequestProductId columns in the  dbo.ExceptionalAmountVw view.
		/// </summary>
		/// <param name="_loanRequestRequestProductId">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExceptionalAmountVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExceptionalAmountVw> GetByLoanRequestRequestProductId(int _loanRequestRequestProductId, Db db)
		{
			return db.ExceptionalAmountVwGetByLoanRequestRequestProductId(_loanRequestRequestProductId);
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
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ExternalGrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> List(Db db)
		{
			return db.ExternalGrantVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		/// <returns>Gets an instance of ExternalGrantVw or null.</returns>
		public static ExternalGrantVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExternalGrantVw or null.</returns>
		public static ExternalGrantVw Get(int _id, Db db)
		{
			return db.ExternalGrantVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		/// <returns>Gets an instance of ExternalGrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExternalGrantVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ExternalGrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ExternalGrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ExternalGrantVw GetChildren(int _id, Db db)
		{
			return db.ExternalGrantVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.ExternalGrantVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByGrantTypeId(byte _grantTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantTypeId(_grantTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantTypeId columns in the  dbo.ExternalGrantVw view.
		/// </summary>
		/// <param name="_grantTypeId">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ExternalGrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ExternalGrantVw> GetByGrantTypeId(byte _grantTypeId, Db db)
		{
			return db.ExternalGrantVwGetByGrantTypeId(_grantTypeId);
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
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> List(Db db)
		{
			return db.GrantDecisionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		/// <returns>Gets an instance of GrantDecisionVw or null.</returns>
		public static GrantDecisionVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDecisionVw or null.</returns>
		public static GrantDecisionVw Get(int _id, Db db)
		{
			return db.GrantDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		/// <returns>Gets an instance of GrantDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDecisionVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDecisionVw GetChildren(int _id, Db db)
		{
			return db.GrantDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> GetByGrantTypeGroupId(byte _grantTypeGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantTypeGroupId(_grantTypeGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> GetByGrantTypeGroupId(byte _grantTypeGroupId, Db db)
		{
			return db.GrantDecisionVwGetByGrantTypeGroupId(_grantTypeGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of GrantDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDecisionVw> GetByNumber_Year(short _number, short _year)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByNumber_Year(_number, _year, db);
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
		public static List<GrantDecisionVw> GetByNumber_Year(short _number, short _year, Db db)
		{
			return db.GrantDecisionVwGetByNumber_Year(_number, _year);
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
		/// <returns>A list of GrantDeductionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDeductionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantDeductionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDeductionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDeductionVw> List(Db db)
		{
			return db.GrantDeductionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantDeductionVw or null.</returns>
		public static GrantDeductionVw Get(int _grantProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_grantProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDeductionVw or null.</returns>
		public static GrantDeductionVw Get(int _grantProductId, Db db)
		{
			return db.GrantDeductionVwGet(_grantProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view with related objects from children.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>Gets an instance of GrantDeductionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDeductionVw GetChildren(int _grantProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_grantProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantDeductionVw view with related objects from children.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDeductionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantDeductionVw GetChildren(int _grantProductId, Db db)
		{
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
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> List(Db db)
		{
			return db.GrantDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantDetailVw or null.</returns>
		public static GrantDetailVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantDetailVw or null.</returns>
		public static GrantDetailVw Get(int _productId, Db db)
		{
			return db.GrantDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> GetByGrantDecisionId(int _grantDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantDecisionId(_grantDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantDetailVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantDetailVw> GetByGrantDecisionId(int _grantDecisionId, Db db)
		{
			return db.GrantDetailVwGetByGrantDecisionId(_grantDecisionId);
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
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> List(Db db)
		{
			return db.GrantPaymentOrderVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null.</returns>
		public static GrantPaymentOrderVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null.</returns>
		public static GrantPaymentOrderVw Get(int _id, Db db)
		{
			return db.GrantPaymentOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentOrderVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentOrderVw GetChildren(int _id, Db db)
		{
			return db.GrantPaymentOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> GetByDate(DateTime _date, Db db)
		{
			return db.GrantPaymentOrderVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.GrantPaymentOrderVw view.
		/// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		/// <returns>A list of GrantPaymentOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentOrderVw> GetByNumber_Year(short _number, short _year)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByNumber_Year(_number, _year, db);
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
		public static List<GrantPaymentOrderVw> GetByNumber_Year(short _number, short _year, Db db)
		{
			return db.GrantPaymentOrderVwGetByNumber_Year(_number, _year);
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
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> List(Db db)
		{
			return db.GrantPaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		/// <returns>Gets an instance of GrantPaymentVw or null.</returns>
		public static GrantPaymentVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentVw or null.</returns>
		public static GrantPaymentVw Get(int _id, Db db)
		{
			return db.GrantPaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		/// <returns>Gets an instance of GrantPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantPaymentVw GetChildren(int _id, Db db)
		{
			return db.GrantPaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId(int _grantPaymentOrderId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantPaymentOrderId(_grantPaymentOrderId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId(int _grantPaymentOrderId, Db db)
		{
			return db.GrantPaymentVwGetByGrantPaymentOrderId(_grantPaymentOrderId);
		}		

		/// <summary>
		/// Gets rows related to one combination of GrantPaymentOrderId_SubNumber columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantPaymentOrderId">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId_SubNumber(int _grantPaymentOrderId, byte _subNumber)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantPaymentOrderId_SubNumber(_grantPaymentOrderId, _subNumber, db);
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
		public static List<GrantPaymentVw> GetByGrantPaymentOrderId_SubNumber(int _grantPaymentOrderId, byte _subNumber, Db db)
		{
			return db.GrantPaymentVwGetByGrantPaymentOrderId_SubNumber(_grantPaymentOrderId, _subNumber);
		}		

		/// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantProductId(int _grantProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantProductId(_grantProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantProductId columns in the  dbo.GrantPaymentVw view.
		/// </summary>
		/// <param name="_grantProductId">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantPaymentVw> GetByGrantProductId(int _grantProductId, Db db)
		{
			return db.GrantPaymentVwGetByGrantProductId(_grantProductId);
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
		/// <returns>A list of GrantRequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantRequestDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantRequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestDetailVw> List(Db db)
		{
			return db.GrantRequestDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantRequestDetailVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestDetailVw or null.</returns>
		public static GrantRequestDetailVw Get(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_requestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantRequestDetailVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestDetailVw or null.</returns>
		public static GrantRequestDetailVw Get(int _requestProductId, Db db)
		{
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
		/// <returns>A list of GrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantRequestVw> List(Db db)
		{
			return db.GrantRequestVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestVw or null.</returns>
		public static GrantRequestVw Get(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_requestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestVw or null.</returns>
		public static GrantRequestVw Get(int _requestProductId, Db db)
		{
			return db.GrantRequestVwGet(_requestProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		/// <returns>Gets an instance of GrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantRequestVw GetChildren(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_requestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantRequestVw GetChildren(int _requestProductId, Db db)
		{
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
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantTypeGroupVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> List(Db db)
		{
			return db.GrantTypeGroupVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null.</returns>
		public static GrantTypeGroupVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null.</returns>
		public static GrantTypeGroupVw Get(byte _id, Db db)
		{
			return db.GrantTypeGroupVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeGroupVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeGroupVw GetChildren(byte _id, Db db)
		{
			return db.GrantTypeGroupVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeGroupVw> GetByName(string _name, Db db)
		{
			return db.GrantTypeGroupVwGetByName(_name);
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
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> List(Db db)
		{
			return db.GrantTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		/// <returns>Gets an instance of GrantTypeVw or null.</returns>
		public static GrantTypeVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeVw or null.</returns>
		public static GrantTypeVw Get(byte _id, Db db)
		{
			return db.GrantTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		/// <returns>Gets an instance of GrantTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantTypeVw GetChildren(byte _id, Db db)
		{
			return db.GrantTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByGrantTypeGroupId(byte _grantTypeGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantTypeGroupId(_grantTypeGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantTypeGroupId columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_grantTypeGroupId">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByGrantTypeGroupId(byte _grantTypeGroupId, Db db)
		{
			return db.GrantTypeVwGetByGrantTypeGroupId(_grantTypeGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GrantTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantTypeVw> GetByName(string _name, Db db)
		{
			return db.GrantTypeVwGetByName(_name);
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
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> List(Db db)
		{
			return db.GrantVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GrantVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantVw or null.</returns>
		public static GrantVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantVw view.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantVw or null.</returns>
		public static GrantVw Get(int _productId, Db db)
		{
			return db.GrantVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GrantVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		/// <returns>Gets an instance of GrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantVw GetChildren(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GrantVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GrantVw GetChildren(int _productId, Db db)
		{
			return db.GrantVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> GetByGrantDecisionId(int _grantDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGrantDecisionId(_grantDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GrantDecisionId columns in the  dbo.GrantVw view.
		/// </summary>
		/// <param name="_grantDecisionId">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GrantVw> GetByGrantDecisionId(int _grantDecisionId, Db db)
		{
			return db.GrantVwGetByGrantDecisionId(_grantDecisionId);
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
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GuarantorDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> List(Db db)
		{
			return db.GuarantorDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorDetailVw or null.</returns>
		public static GuarantorDetailVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorDetailVw or null.</returns>
		public static GuarantorDetailVw Get(int _id, Db db)
		{
			return db.GuarantorDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.GuarantorDetailVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByGuarantorStatusId(byte _guarantorStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGuarantorStatusId(_guarantorStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByGuarantorStatusId(byte _guarantorStatusId, Db db)
		{
			return db.GuarantorDetailVwGetByGuarantorStatusId(_guarantorStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByRefundableProductProductId(int _refundableProductProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId(_refundableProductProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db)
		{
			return db.GuarantorDetailVwGetByRefundableProductProductId(_refundableProductProductId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorDetailVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>A list of GuarantorDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorDetailVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber, db);
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
		public static List<GuarantorDetailVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber, Db db)
		{
			return db.GuarantorDetailVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
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
		/// <returns>A list of GuarantorStatementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatementVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatementVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatementVw> List(Db db)
		{
			return db.GuarantorStatementVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null.</returns>
		public static GuarantorStatementVw Get(int _guarantorId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_guarantorId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null.</returns>
		public static GuarantorStatementVw Get(int _guarantorId, Db db)
		{
			return db.GuarantorStatementVwGet(_guarantorId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view with related objects from children.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatementVw GetChildren(int _guarantorId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_guarantorId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatementVw view with related objects from children.
		/// </summary>
		/// <param name="_guarantorId">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatementVw GetChildren(int _guarantorId, Db db)
		{
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
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> List(Db db)
		{
			return db.GuarantorStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null.</returns>
		public static GuarantorStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null.</returns>
		public static GuarantorStatusVw Get(byte _id, Db db)
		{
			return db.GuarantorStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorStatusVw GetChildren(byte _id, Db db)
		{
			return db.GuarantorStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.GuarantorStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorStatusVw> GetByName(string _name, Db db)
		{
			return db.GuarantorStatusVwGetByName(_name);
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
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.GuarantorVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> List(Db db)
		{
			return db.GuarantorVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorVw or null.</returns>
		public static GuarantorVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorVw or null.</returns>
		public static GuarantorVw Get(int _id, Db db)
		{
			return db.GuarantorVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.GuarantorVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		/// <returns>Gets an instance of GuarantorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.GuarantorVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of GuarantorVw or null. If an instance is returned, child objects will also be returned</returns>
		public static GuarantorVw GetChildren(int _id, Db db)
		{
			return db.GuarantorVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.GuarantorVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByGuarantorStatusId(byte _guarantorStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByGuarantorStatusId(_guarantorStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of GuarantorStatusId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_guarantorStatusId">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByGuarantorStatusId(byte _guarantorStatusId, Db db)
		{
			return db.GuarantorVwGetByGuarantorStatusId(_guarantorStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId(int _refundableProductProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId(_refundableProductProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db)
		{
			return db.GuarantorVwGetByRefundableProductProductId(_refundableProductProductId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.GuarantorVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		/// <returns>A list of GuarantorVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GuarantorVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber, db);
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
		public static List<GuarantorVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, byte _subNumber, Db db)
		{
			return db.GuarantorVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
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
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> List(Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null.</returns>
		public static HealthLoanDecisionFirstPaymentVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null.</returns>
		public static HealthLoanDecisionFirstPaymentVw Get(int _id, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionFirstPaymentVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionFirstPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionFirstPaymentVw GetChildren(int _id, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByDepartment(Nullable<int> _department)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartment(_department, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByDepartment(Nullable<int> _department, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByDepartment(_department);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId_PaymentDate columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId_PaymentDate(int _employeeId, DateTime _paymentDate)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId_PaymentDate(_employeeId, _paymentDate, db);
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
		public static List<HealthLoanDecisionFirstPaymentVw> GetByEmployeeId_PaymentDate(int _employeeId, DateTime _paymentDate, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByEmployeeId_PaymentDate(_employeeId, _paymentDate);
		}		

		/// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByHealthLoanDecisionId(Nullable<int> _healthLoanDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByHealthLoanDecisionId(_healthLoanDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of HealthLoanDecisionId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_healthLoanDecisionId">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByHealthLoanDecisionId(Nullable<int> _healthLoanDecisionId, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByHealthLoanDecisionId(_healthLoanDecisionId);
		}		

		/// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByInsuranceTypeId(Nullable<byte> _insuranceTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByInsuranceTypeId(_insuranceTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of InsuranceTypeId columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_insuranceTypeId">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByInsuranceTypeId(Nullable<byte> _insuranceTypeId, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByInsuranceTypeId(_insuranceTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByLoanRequest(Nullable<int> _loanRequest)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanRequest(_loanRequest, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByLoanRequest(Nullable<int> _loanRequest, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByLoanRequest(_loanRequest);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByPaymentStatus(Nullable<byte> _paymentStatus)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentStatus(_paymentStatus, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPaymentVw view.
		/// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionFirstPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionFirstPaymentVw> GetByPaymentStatus(Nullable<byte> _paymentStatus, Db db)
		{
			return db.HealthLoanDecisionFirstPaymentVwGetByPaymentStatus(_paymentStatus);
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
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> List(Db db)
		{
			return db.HealthLoanDecisionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null.</returns>
		public static HealthLoanDecisionVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null.</returns>
		public static HealthLoanDecisionVw Get(int _id, Db db)
		{
			return db.HealthLoanDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of HealthLoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static HealthLoanDecisionVw GetChildren(int _id, Db db)
		{
			return db.HealthLoanDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> GetByDate(Nullable<DateTime> _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> GetByDate(Nullable<DateTime> _date, Db db)
		{
			return db.HealthLoanDecisionVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.HealthLoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		/// <returns>A list of HealthLoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<HealthLoanDecisionVw> GetByNumber_Year(short _number, short _year)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByNumber_Year(_number, _year, db);
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
		public static List<HealthLoanDecisionVw> GetByNumber_Year(short _number, short _year, Db db)
		{
			return db.HealthLoanDecisionVwGetByNumber_Year(_number, _year);
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
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.IncomingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> List(Db db)
		{
			return db.IncomingLoanVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of IncomingLoanVw or null.</returns>
		public static IncomingLoanVw Get(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IncomingLoanVw or null.</returns>
		public static IncomingLoanVw Get(int _loanProductId, Db db)
		{
			return db.IncomingLoanVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of IncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IncomingLoanVw GetChildren(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.IncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IncomingLoanVw GetChildren(int _loanProductId, Db db)
		{
			return db.IncomingLoanVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMainWorkPlaceId(_mainWorkPlaceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.IncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db)
		{
			return db.IncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
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
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> List(Db db)
		{
			return db.InstallmentDecreaseOrderVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null.</returns>
		public static InstallmentDecreaseOrderVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null.</returns>
		public static InstallmentDecreaseOrderVw Get(int _id, Db db)
		{
			return db.InstallmentDecreaseOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseOrderVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseOrderVw GetChildren(int _id, Db db)
		{
			return db.InstallmentDecreaseOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> GetByMonth(DateTime _month)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMonth(_month, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrderVw view.
		/// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseOrderVw> GetByMonth(DateTime _month, Db db)
		{
			return db.InstallmentDecreaseOrderVwGetByMonth(_month);
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
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> List(Db db)
		{
			return db.InstallmentDecreaseVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null.</returns>
		public static InstallmentDecreaseVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null.</returns>
		public static InstallmentDecreaseVw Get(int _id, Db db)
		{
			return db.InstallmentDecreaseVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentDecreaseVw GetChildren(int _id, Db db)
		{
			return db.InstallmentDecreaseVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByDepartmentId(Nullable<int> _departmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartmentId(_departmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByDepartmentId(Nullable<int> _departmentId, Db db)
		{
			return db.InstallmentDecreaseVwGetByDepartmentId(_departmentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.InstallmentDecreaseVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId(int _installmentDecreaseOrderId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByInstallmentDecreaseOrderId(_installmentDecreaseOrderId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId(int _installmentDecreaseOrderId, Db db)
		{
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId(_installmentDecreaseOrderId);
		}		

		/// <summary>
		/// Gets rows related to one combination of InstallmentDecreaseOrderId_EmployeeId columns in the  dbo.InstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_installmentDecreaseOrderId">رقم الكتاب الداخلي</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of InstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId_EmployeeId(int _installmentDecreaseOrderId, int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByInstallmentDecreaseOrderId_EmployeeId(_installmentDecreaseOrderId, _employeeId, db);
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
		public static List<InstallmentDecreaseVw> GetByInstallmentDecreaseOrderId_EmployeeId(int _installmentDecreaseOrderId, int _employeeId, Db db)
		{
			return db.InstallmentDecreaseVwGetByInstallmentDecreaseOrderId_EmployeeId(_installmentDecreaseOrderId, _employeeId);
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
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.InstallmentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> List(Db db)
		{
			return db.InstallmentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		/// <returns>Gets an instance of InstallmentVw or null.</returns>
		public static InstallmentVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentVw or null.</returns>
		public static InstallmentVw Get(int _id, Db db)
		{
			return db.InstallmentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.InstallmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		/// <returns>Gets an instance of InstallmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InstallmentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InstallmentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InstallmentVw GetChildren(int _id, Db db)
		{
			return db.InstallmentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByDueDate(DateTime _dueDate)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDueDate(_dueDate, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DueDate columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByDueDate(DateTime _dueDate, Db db)
		{
			return db.InstallmentVwGetByDueDate(_dueDate);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByRefundableProductProductId(int _refundableProductProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId(_refundableProductProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RefundableProductProductId columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByRefundableProductProductId(int _refundableProductProductId, Db db)
		{
			return db.InstallmentVwGetByRefundableProductProductId(_refundableProductProductId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RefundableProductProductId_SubNumber columns in the  dbo.InstallmentVw view.
		/// </summary>
		/// <param name="_refundableProductProductId">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		/// <returns>A list of InstallmentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InstallmentVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, short _subNumber)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber, db);
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
		public static List<InstallmentVw> GetByRefundableProductProductId_SubNumber(int _refundableProductProductId, short _subNumber, Db db)
		{
			return db.InstallmentVwGetByRefundableProductProductId_SubNumber(_refundableProductProductId, _subNumber);
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
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.InsuranceTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> List(Db db)
		{
			return db.InsuranceTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null.</returns>
		public static InsuranceTypeVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null.</returns>
		public static InsuranceTypeVw Get(byte _id, Db db)
		{
			return db.InsuranceTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InsuranceTypeVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.InsuranceTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of InsuranceTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static InsuranceTypeVw GetChildren(byte _id, Db db)
		{
			return db.InsuranceTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.InsuranceTypeVw view.
		/// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of InsuranceTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<InsuranceTypeVw> GetByName(string _name, Db db)
		{
			return db.InsuranceTypeVwGetByName(_name);
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
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.IssuerVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> List(Db db)
		{
			return db.IssuerVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.IssuerVw view.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of IssuerVw or null.</returns>
		public static IssuerVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.IssuerVw view.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IssuerVw or null.</returns>
		public static IssuerVw Get(byte _id, Db db)
		{
			return db.IssuerVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.IssuerVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		/// <returns>Gets an instance of IssuerVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IssuerVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.IssuerVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of IssuerVw or null. If an instance is returned, child objects will also be returned</returns>
		public static IssuerVw GetChildren(byte _id, Db db)
		{
			return db.IssuerVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.IssuerVw view.
		/// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of IssuerVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<IssuerVw> GetByName(string _name, Db db)
		{
			return db.IssuerVwGetByName(_name);
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
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanChangeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> List(Db db)
		{
			return db.LoanChangeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>Gets an instance of LoanChangeVw or null.</returns>
		public static LoanChangeVw Get(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanChangeVw or null.</returns>
		public static LoanChangeVw Get(int _loanProductId, Db db)
		{
			return db.LoanChangeVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanChangeVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>Gets an instance of LoanChangeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanChangeVw GetChildren(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanChangeVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanChangeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanChangeVw GetChildren(int _loanProductId, Db db)
		{
			return db.LoanChangeVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByFromLoanProductId(int _fromLoanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByFromLoanProductId(_fromLoanProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of FromLoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_fromLoanProductId">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByFromLoanProductId(int _fromLoanProductId, Db db)
		{
			return db.LoanChangeVwGetByFromLoanProductId(_fromLoanProductId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByLoanProductId(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanProductId(_loanProductId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanProductId columns in the  dbo.LoanChangeVw view.
		/// </summary>
		/// <param name="_loanProductId">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanChangeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanChangeVw> GetByLoanProductId(int _loanProductId, Db db)
		{
			return db.LoanChangeVwGetByLoanProductId(_loanProductId);
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
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> List(Db db)
		{
			return db.LoanDecisionTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null.</returns>
		public static LoanDecisionTypeVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null.</returns>
		public static LoanDecisionTypeVw Get(byte _id, Db db)
		{
			return db.LoanDecisionTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionTypeVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanDecisionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionTypeVw GetChildren(byte _id, Db db)
		{
			return db.LoanDecisionTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanDecisionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionTypeVw> GetByName(string _name, Db db)
		{
			return db.LoanDecisionTypeVwGetByName(_name);
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
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionVw> List(Db db)
		{
			return db.LoanDecisionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionVw or null.</returns>
		public static LoanDecisionVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionVw or null.</returns>
		public static LoanDecisionVw Get(int _id, Db db)
		{
			return db.LoanDecisionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		/// <returns>Gets an instance of LoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanDecisionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDecisionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanDecisionVw GetChildren(int _id, Db db)
		{
			return db.LoanDecisionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Number_Year columns in the  dbo.LoanDecisionVw view.
		/// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		/// <returns>A list of LoanDecisionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDecisionVw> GetByNumber_Year(short _number, short _year)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByNumber_Year(_number, _year, db);
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
		public static List<LoanDecisionVw> GetByNumber_Year(short _number, short _year, Db db)
		{
			return db.LoanDecisionVwGetByNumber_Year(_number, _year);
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
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> List(Db db)
		{
			return db.LoanDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanDetailVw or null.</returns>
		public static LoanDetailVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanDetailVw or null.</returns>
		public static LoanDetailVw Get(int _productId, Db db)
		{
			return db.LoanDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanDecisionId(int _loanDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanDecisionId(_loanDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanDecisionId(int _loanDecisionId, Db db)
		{
			return db.LoanDetailVwGetByLoanDecisionId(_loanDecisionId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanGenerationStatusId(_loanGenerationStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId, Db db)
		{
			return db.LoanDetailVwGetByLoanGenerationStatusId(_loanGenerationStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanStatusId(byte _loanStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanStatusId(_loanStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanDetailVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanDetailVw> GetByLoanStatusId(byte _loanStatusId, Db db)
		{
			return db.LoanDetailVwGetByLoanStatusId(_loanStatusId);
		}
		#endregion
	}
	#endregion

    #region LoanGenerationStatusVwServices
    public static partial class LoanGenerationStatusVwServices
    {
		#region List procedure
		/// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> List(Db db)
		{
			return db.LoanGenerationStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null.</returns>
		public static LoanGenerationStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null.</returns>
		public static LoanGenerationStatusVw Get(byte _id, Db db)
		{
			return db.LoanGenerationStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanGenerationStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanGenerationStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanGenerationStatusVw GetChildren(byte _id, Db db)
		{
			return db.LoanGenerationStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanGenerationStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanGenerationStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanGenerationStatusVw> GetByName(string _name, Db db)
		{
			return db.LoanGenerationStatusVwGetByName(_name);
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
		/// <returns>A list of LoanRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanRequestVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanRequestVw> List(Db db)
		{
			return db.LoanRequestVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		/// <returns>Gets an instance of LoanRequestVw or null.</returns>
		public static LoanRequestVw Get(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_requestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanRequestVw view.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanRequestVw or null.</returns>
		public static LoanRequestVw Get(int _requestProductId, Db db)
		{
			return db.LoanRequestVwGet(_requestProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		/// <returns>Gets an instance of LoanRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanRequestVw GetChildren(int _requestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_requestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_requestProductId">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanRequestVw GetChildren(int _requestProductId, Db db)
		{
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
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> List(Db db)
		{
			return db.LoanStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatusVw or null.</returns>
		public static LoanStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanStatusVw or null.</returns>
		public static LoanStatusVw Get(byte _id, Db db)
		{
			return db.LoanStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		/// <returns>Gets an instance of LoanStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanStatusVw GetChildren(byte _id, Db db)
		{
			return db.LoanStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.LoanStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanStatusVw> GetByName(string _name, Db db)
		{
			return db.LoanStatusVwGetByName(_name);
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
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanTypeClosureVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> List(Db db)
		{
			return db.LoanTypeClosureVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null.</returns>
		public static LoanTypeClosureVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null.</returns>
		public static LoanTypeClosureVw Get(int _id, Db db)
		{
			return db.LoanTypeClosureVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeClosureVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosureVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeClosureVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeClosureVw GetChildren(int _id, Db db)
		{
			return db.LoanTypeClosureVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByClosingLoanTypeProductTypeId(short _closingLoanTypeProductTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByClosingLoanTypeProductTypeId(_closingLoanTypeProductTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByClosingLoanTypeProductTypeId(short _closingLoanTypeProductTypeId, Db db)
		{
			return db.LoanTypeClosureVwGetByClosingLoanTypeProductTypeId(_closingLoanTypeProductTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanTypeProductTypeId(_loanTypeProductTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId, Db db)
		{
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId_ClosingLoanTypeProductTypeId columns in the  dbo.LoanTypeClosureVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanTypeProductTypeId">نوع السلفة التي تؤدي إلى الإغلاق</param>
		/// <returns>A list of LoanTypeClosureVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(short _loanTypeProductTypeId, short _closingLoanTypeProductTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(_loanTypeProductTypeId, _closingLoanTypeProductTypeId, db);
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
		public static List<LoanTypeClosureVw> GetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(short _loanTypeProductTypeId, short _closingLoanTypeProductTypeId, Db db)
		{
			return db.LoanTypeClosureVwGetByLoanTypeProductTypeId_ClosingLoanTypeProductTypeId(_loanTypeProductTypeId, _closingLoanTypeProductTypeId);
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
		/// <returns>A list of LoanTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanTypeVw> List(Db db)
		{
			return db.LoanTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanTypeVw view.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		/// <returns>Gets an instance of LoanTypeVw or null.</returns>
		public static LoanTypeVw Get(short _productTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productTypeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanTypeVw view.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeVw or null.</returns>
		public static LoanTypeVw Get(short _productTypeId, Db db)
		{
			return db.LoanTypeVwGet(_productTypeId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		/// <returns>Gets an instance of LoanTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeVw GetChildren(short _productTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_productTypeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_productTypeId">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanTypeVw GetChildren(short _productTypeId, Db db)
		{
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
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.LoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> List(Db db)
		{
			return db.LoanVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.LoanVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanVw or null.</returns>
		public static LoanVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanVw view.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanVw or null.</returns>
		public static LoanVw Get(int _productId, Db db)
		{
			return db.LoanVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.LoanVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		/// <returns>Gets an instance of LoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanVw GetChildren(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.LoanVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of LoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static LoanVw GetChildren(int _productId, Db db)
		{
			return db.LoanVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanDecisionId(int _loanDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanDecisionId(_loanDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanDecisionId(int _loanDecisionId, Db db)
		{
			return db.LoanVwGetByLoanDecisionId(_loanDecisionId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanGenerationStatusId(_loanGenerationStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanGenerationStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanGenerationStatusId">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanGenerationStatusId(byte _loanGenerationStatusId, Db db)
		{
			return db.LoanVwGetByLoanGenerationStatusId(_loanGenerationStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanStatusId(byte _loanStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanStatusId(_loanStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanStatusId columns in the  dbo.LoanVw view.
		/// </summary>
		/// <param name="_loanStatusId">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of LoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<LoanVw> GetByLoanStatusId(byte _loanStatusId, Db db)
		{
			return db.LoanVwGetByLoanStatusId(_loanStatusId);
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
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.MainWorkPlaceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> List(Db db)
		{
			return db.MainWorkPlaceVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null.</returns>
		public static MainWorkPlaceVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null.</returns>
		public static MainWorkPlaceVw Get(int _id, Db db)
		{
			return db.MainWorkPlaceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MainWorkPlaceVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MainWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MainWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MainWorkPlaceVw GetChildren(int _id, Db db)
		{
			return db.MainWorkPlaceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.MainWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MainWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MainWorkPlaceVw> GetByName(string _name, Db db)
		{
			return db.MainWorkPlaceVwGetByName(_name);
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
		/// <returns>A list of MissingInstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MissingInstallmentDecreaseVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MissingInstallmentDecreaseVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MissingInstallmentDecreaseVw> List(Db db)
		{
			return db.MissingInstallmentDecreaseVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null.</returns>
		public static MissingInstallmentDecreaseVw Get(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null.</returns>
		public static MissingInstallmentDecreaseVw Get(int _employeeId, Db db)
		{
			return db.MissingInstallmentDecreaseVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MissingInstallmentDecreaseVw GetChildren(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecreaseVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MissingInstallmentDecreaseVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MissingInstallmentDecreaseVw GetChildren(int _employeeId, Db db)
		{
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
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.MonthlyBalanceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> List(Db db)
		{
			return db.MonthlyBalanceVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null.</returns>
		public static MonthlyBalanceVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null.</returns>
		public static MonthlyBalanceVw Get(int _id, Db db)
		{
			return db.MonthlyBalanceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MonthlyBalanceVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.MonthlyBalanceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of MonthlyBalanceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static MonthlyBalanceVw GetChildren(int _id, Db db)
		{
			return db.MonthlyBalanceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.MonthlyBalanceVwGetByEmployeeId(_employeeId);
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
		public static List<MonthlyBalanceVw> GetByEmployeeId_PaymentGroupId_Month(int _employeeId, byte _paymentGroupId, DateTime _month)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId_PaymentGroupId_Month(_employeeId, _paymentGroupId, _month, db);
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
		public static List<MonthlyBalanceVw> GetByEmployeeId_PaymentGroupId_Month(int _employeeId, byte _paymentGroupId, DateTime _month, Db db)
		{
			return db.MonthlyBalanceVwGetByEmployeeId_PaymentGroupId_Month(_employeeId, _paymentGroupId, _month);
		}		

		/// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByMonth(DateTime _month)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMonth(_month, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Month columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByMonth(DateTime _month, Db db)
		{
			return db.MonthlyBalanceVwGetByMonth(_month);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByPaymentGroupId(byte _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.MonthlyBalanceVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of MonthlyBalanceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceVw> GetByPaymentGroupId(byte _paymentGroupId, Db db)
		{
			return db.MonthlyBalanceVwGetByPaymentGroupId(_paymentGroupId);
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
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.OutgoingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> List(Db db)
		{
			return db.OutgoingLoanVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null.</returns>
		public static OutgoingLoanVw Get(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null.</returns>
		public static OutgoingLoanVw Get(int _loanProductId, Db db)
		{
			return db.OutgoingLoanVwGet(_loanProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static OutgoingLoanVw GetChildren(int _loanProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_loanProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.OutgoingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_loanProductId">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of OutgoingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static OutgoingLoanVw GetChildren(int _loanProductId, Db db)
		{
			return db.OutgoingLoanVwGetChildren(_loanProductId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByLoanDecisionId(int _loanDecisionId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanDecisionId(_loanDecisionId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanDecisionId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_loanDecisionId">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByLoanDecisionId(int _loanDecisionId, Db db)
		{
			return db.OutgoingLoanVwGetByLoanDecisionId(_loanDecisionId);
		}		

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMainWorkPlaceId(_mainWorkPlaceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.OutgoingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of OutgoingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<OutgoingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db)
		{
			return db.OutgoingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
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
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.PaymentDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> List(Db db)
		{
			return db.PaymentDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentDetailVw or null.</returns>
		public static PaymentDetailVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentDetailVw or null.</returns>
		public static PaymentDetailVw Get(int _id, Db db)
		{
			return db.PaymentDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByCollectOrderId(Nullable<int> _collectOrderId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByCollectOrderId(_collectOrderId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByCollectOrderId(Nullable<int> _collectOrderId, Db db)
		{
			return db.PaymentDetailVwGetByCollectOrderId(_collectOrderId);
		}		

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByDate(DateTime _date, Db db)
		{
			return db.PaymentDetailVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.PaymentDetailVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentGroupId(byte _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentGroupId(byte _paymentGroupId, Db db)
		{
			return db.PaymentDetailVwGetByPaymentGroupId(_paymentGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentStatusId(_paymentStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentDetailVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentDetailVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId, Db db)
		{
			return db.PaymentDetailVwGetByPaymentStatusId(_paymentStatusId);
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
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.PaymentGroupVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> List(Db db)
		{
			return db.PaymentGroupVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroupVw or null.</returns>
		public static PaymentGroupVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentGroupVw or null.</returns>
		public static PaymentGroupVw Get(byte _id, Db db)
		{
			return db.PaymentGroupVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		/// <returns>Gets an instance of PaymentGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentGroupVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentGroupVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentGroupVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentGroupVw GetChildren(byte _id, Db db)
		{
			return db.PaymentGroupVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.PaymentGroupVw view.
		/// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentGroupVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentGroupVw> GetByName(string _name, Db db)
		{
			return db.PaymentGroupVwGetByName(_name);
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
		/// <returns>A list of PaymentStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.PaymentStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentStatusVw> List(Db db)
		{
			return db.PaymentStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		/// <returns>Gets an instance of PaymentStatusVw or null.</returns>
		public static PaymentStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentStatusVw or null.</returns>
		public static PaymentStatusVw Get(byte _id, Db db)
		{
			return db.PaymentStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		/// <returns>Gets an instance of PaymentStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentStatusVw GetChildren(byte _id, Db db)
		{
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
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.PaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> List(Db db)
		{
			return db.PaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentVw or null.</returns>
		public static PaymentVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentVw view.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentVw or null.</returns>
		public static PaymentVw Get(int _id, Db db)
		{
			return db.PaymentVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.PaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		/// <returns>Gets an instance of PaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PaymentVw GetChildren(int _id, Db db)
		{
			return db.PaymentVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByCollectOrderId(Nullable<int> _collectOrderId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByCollectOrderId(_collectOrderId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of CollectOrderId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_collectOrderId">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByCollectOrderId(Nullable<int> _collectOrderId, Db db)
		{
			return db.PaymentVwGetByCollectOrderId(_collectOrderId);
		}		

		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByDate(DateTime _date, Db db)
		{
			return db.PaymentVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.PaymentVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentGroupId(byte _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentGroupId(byte _paymentGroupId, Db db)
		{
			return db.PaymentVwGetByPaymentGroupId(_paymentGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentStatusId(_paymentStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentStatusId columns in the  dbo.PaymentVw view.
		/// </summary>
		/// <param name="_paymentStatusId">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentVw> GetByPaymentStatusId(Nullable<byte> _paymentStatusId, Db db)
		{
			return db.PaymentVwGetByPaymentStatusId(_paymentStatusId);
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
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.PayOrderVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> List(Db db)
		{
			return db.PayOrderVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		/// <returns>Gets an instance of PayOrderVw or null.</returns>
		public static PayOrderVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PayOrderVw or null.</returns>
		public static PayOrderVw Get(int _id, Db db)
		{
			return db.PayOrderVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.PayOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		/// <returns>Gets an instance of PayOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PayOrderVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.PayOrderVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of PayOrderVw or null. If an instance is returned, child objects will also be returned</returns>
		public static PayOrderVw GetChildren(int _id, Db db)
		{
			return db.PayOrderVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByDate(DateTime _date, Db db)
		{
			return db.PayOrderVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.PayOrderVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByIsFixed(byte _isFixed)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsFixed(_isFixed, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByIsFixed(byte _isFixed, Db db)
		{
			return db.PayOrderVwGetByIsFixed(_isFixed);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByPaymentGroupId(byte _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.PayOrderVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of PayOrderVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PayOrderVw> GetByPaymentGroupId(byte _paymentGroupId, Db db)
		{
			return db.PayOrderVwGetByPaymentGroupId(_paymentGroupId);
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
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProductDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> List(Db db)
		{
			return db.ProductDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductDetailVw or null.</returns>
		public static ProductDetailVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductDetailVw or null.</returns>
		public static ProductDetailVw Get(int _id, Db db)
		{
			return db.ProductDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.ProductDetailVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByProductTypeId(short _productTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProductTypeId(_productTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductDetailVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductDetailVw> GetByProductTypeId(short _productTypeId, Db db)
		{
			return db.ProductDetailVwGetByProductTypeId(_productTypeId);
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
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> List(Db db)
		{
			return db.ProductTypeAvailabilityVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null.</returns>
		public static ProductTypeAvailabilityVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null.</returns>
		public static ProductTypeAvailabilityVw Get(int _id, Db db)
		{
			return db.ProductTypeAvailabilityVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeAvailabilityVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailabilityVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeAvailabilityVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeAvailabilityVw GetChildren(int _id, Db db)
		{
			return db.ProductTypeAvailabilityVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByAvailabilityId(short _availabilityId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByAvailabilityId(_availabilityId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByAvailabilityId(short _availabilityId, Db db)
		{
			return db.ProductTypeAvailabilityVwGetByAvailabilityId(_availabilityId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId(short _productTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProductTypeId(_productTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId(short _productTypeId, Db db)
		{
			return db.ProductTypeAvailabilityVwGetByProductTypeId(_productTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId_AvailabilityId columns in the  dbo.ProductTypeAvailabilityVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <param name="_availabilityId">قاعدة الاستخدام</param>
		/// <returns>A list of ProductTypeAvailabilityVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId_AvailabilityId(short _productTypeId, short _availabilityId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProductTypeId_AvailabilityId(_productTypeId, _availabilityId, db);
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
		public static List<ProductTypeAvailabilityVw> GetByProductTypeId_AvailabilityId(short _productTypeId, short _availabilityId, Db db)
		{
			return db.ProductTypeAvailabilityVwGetByProductTypeId_AvailabilityId(_productTypeId, _availabilityId);
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
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProductTypeDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> List(Db db)
		{
			return db.ProductTypeDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeDetailVw or null.</returns>
		public static ProductTypeDetailVw Get(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeDetailVw or null.</returns>
		public static ProductTypeDetailVw Get(short _id, Db db)
		{
			return db.ProductTypeDetailVwGet(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByName(string _name, Db db)
		{
			return db.ProductTypeDetailVwGetByName(_name);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId, Db db)
		{
			return db.ProductTypeDetailVwGetByPaymentGroupId(_paymentGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProfitStrategyId(_profitStrategyId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeDetailVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeDetailVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId, Db db)
		{
			return db.ProductTypeDetailVwGetByProfitStrategyId(_profitStrategyId);
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
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProductTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> List(Db db)
		{
			return db.ProductTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeVw or null.</returns>
		public static ProductTypeVw Get(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeVw or null.</returns>
		public static ProductTypeVw Get(short _id, Db db)
		{
			return db.ProductTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ProductTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		/// <returns>Gets an instance of ProductTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeVw GetChildren(short _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductTypeVw GetChildren(short _id, Db db)
		{
			return db.ProductTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByName(string _name, Db db)
		{
			return db.ProductTypeVwGetByName(_name);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentGroupId(_paymentGroupId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentGroupId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_paymentGroupId">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByPaymentGroupId(Nullable<byte> _paymentGroupId, Db db)
		{
			return db.ProductTypeVwGetByPaymentGroupId(_paymentGroupId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProfitStrategyId(_profitStrategyId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ProfitStrategyId columns in the  dbo.ProductTypeVw view.
		/// </summary>
		/// <param name="_profitStrategyId">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductTypeVw> GetByProfitStrategyId(Nullable<byte> _profitStrategyId, Db db)
		{
			return db.ProductTypeVwGetByProfitStrategyId(_profitStrategyId);
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
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProductVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> List(Db db)
		{
			return db.ProductVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProductVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductVw or null.</returns>
		public static ProductVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductVw view.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductVw or null.</returns>
		public static ProductVw Get(int _id, Db db)
		{
			return db.ProductVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ProductVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		/// <returns>Gets an instance of ProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProductVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProductVw GetChildren(int _id, Db db)
		{
			return db.ProductVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.ProductVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByProductTypeId(short _productTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByProductTypeId(_productTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of ProductTypeId columns in the  dbo.ProductVw view.
		/// </summary>
		/// <param name="_productTypeId">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductVw> GetByProductTypeId(short _productTypeId, Db db)
		{
			return db.ProductVwGetByProductTypeId(_productTypeId);
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
		/// <returns>A list of ProfileVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfileVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProfileVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfileVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfileVw> List(Db db)
		{
			return db.ProfileVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProfileVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of ProfileVw or null.</returns>
		public static ProfileVw Get(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProfileVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfileVw or null.</returns>
		public static ProfileVw Get(int _employeeId, Db db)
		{
			return db.ProfileVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ProfileVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of ProfileVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfileVw GetChildren(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProfileVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfileVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfileVw GetChildren(int _employeeId, Db db)
		{
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
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ProfitStrategyVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> List(Db db)
		{
			return db.ProfitStrategyVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null.</returns>
		public static ProfitStrategyVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null.</returns>
		public static ProfitStrategyVw Get(byte _id, Db db)
		{
			return db.ProfitStrategyVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfitStrategyVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ProfitStrategyVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ProfitStrategyVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ProfitStrategyVw GetChildren(byte _id, Db db)
		{
			return db.ProfitStrategyVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.ProfitStrategyVw view.
		/// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ProfitStrategyVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProfitStrategyVw> GetByName(string _name, Db db)
		{
			return db.ProfitStrategyVwGetByName(_name);
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
		/// <returns>A list of RefundableProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RefundableProductVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.RefundableProductVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RefundableProductVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RefundableProductVw> List(Db db)
		{
			return db.RefundableProductVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.RefundableProductVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RefundableProductVw or null.</returns>
		public static RefundableProductVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RefundableProductVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RefundableProductVw or null.</returns>
		public static RefundableProductVw Get(int _productId, Db db)
		{
			return db.RefundableProductVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.RefundableProductVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RefundableProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RefundableProductVw GetChildren(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RefundableProductVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RefundableProductVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RefundableProductVw GetChildren(int _productId, Db db)
		{
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
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.RequestDetailVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> List(Db db)
		{
			return db.RequestDetailVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestDetailVw or null.</returns>
		public static RequestDetailVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestDetailVw or null.</returns>
		public static RequestDetailVw Get(int _productId, Db db)
		{
			return db.RequestDetailVwGet(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByBypassStatusId(int _bypassStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByBypassStatusId(_bypassStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByBypassStatusId(int _bypassStatusId, Db db)
		{
			return db.RequestDetailVwGetByBypassStatusId(_bypassStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByRequestStatusId(Nullable<byte> _requestStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRequestStatusId(_requestStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestDetailVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestDetailVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestDetailVw> GetByRequestStatusId(Nullable<byte> _requestStatusId, Db db)
		{
			return db.RequestDetailVwGetByRequestStatusId(_requestStatusId);
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
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.RequestStatusVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> List(Db db)
		{
			return db.RequestStatusVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatusVw or null.</returns>
		public static RequestStatusVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestStatusVw or null.</returns>
		public static RequestStatusVw Get(byte _id, Db db)
		{
			return db.RequestStatusVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.RequestStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		/// <returns>Gets an instance of RequestStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestStatusVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RequestStatusVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestStatusVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestStatusVw GetChildren(byte _id, Db db)
		{
			return db.RequestStatusVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.RequestStatusVw view.
		/// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestStatusVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatusVw> GetByName(string _name, Db db)
		{
			return db.RequestStatusVwGetByName(_name);
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
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.RequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> List(Db db)
		{
			return db.RequestVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.RequestVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestVw or null.</returns>
		public static RequestVw Get(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RequestVw view.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestVw or null.</returns>
		public static RequestVw Get(int _productId, Db db)
		{
			return db.RequestVwGet(_productId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.RequestVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <returns>Gets an instance of RequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestVw GetChildren(int _productId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_productId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.RequestVw view with related objects from children.
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of RequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static RequestVw GetChildren(int _productId, Db db)
		{
			return db.RequestVwGetChildren(_productId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByBypassStatusId(int _bypassStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByBypassStatusId(_bypassStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of BypassStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_bypassStatusId">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByBypassStatusId(int _bypassStatusId, Db db)
		{
			return db.RequestVwGetByBypassStatusId(_bypassStatusId);
		}		

		/// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByRequestStatusId(Nullable<byte> _requestStatusId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByRequestStatusId(_requestStatusId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of RequestStatusId columns in the  dbo.RequestVw view.
		/// </summary>
		/// <param name="_requestStatusId">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of RequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestVw> GetByRequestStatusId(Nullable<byte> _requestStatusId, Db db)
		{
			return db.RequestVwGetByRequestStatusId(_requestStatusId);
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
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ResourceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> List(Db db)
		{
			return db.ResourceVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ResourceVw view.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		/// <returns>Gets an instance of ResourceVw or null.</returns>
		public static ResourceVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ResourceVw view.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ResourceVw or null.</returns>
		public static ResourceVw Get(int _id, Db db)
		{
			return db.ResourceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ResourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		/// <returns>Gets an instance of ResourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ResourceVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ResourceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ResourceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ResourceVw GetChildren(int _id, Db db)
		{
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
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> GetByLanguage_Module_Key(string _language, string _module, string _key)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLanguage_Module_Key(_language, _module, _key, db);
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
		public static List<ResourceVw> GetByLanguage_Module_Key(string _language, string _module, string _key, Db db)
		{
			return db.ResourceVwGetByLanguage_Module_Key(_language, _module, _key);
		}		

		/// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> GetByModule(string _module)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByModule(_module, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Module columns in the  dbo.ResourceVw view.
		/// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ResourceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ResourceVw> GetByModule(string _module, Db db)
		{
			return db.ResourceVwGetByModule(_module);
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
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SalaryPaymentVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> List(Db db)
		{
			return db.SalaryPaymentVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null.</returns>
		public static SalaryPaymentVw Get(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null.</returns>
		public static SalaryPaymentVw Get(int _paymentId, Db db)
		{
			return db.SalaryPaymentVwGet(_paymentId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryPaymentVw GetChildren(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_paymentId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SalaryPaymentVw view with related objects from children.
		/// </summary>
		/// <param name="_paymentId">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryPaymentVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryPaymentVw GetChildren(int _paymentId, Db db)
		{
			return db.SalaryPaymentVwGetChildren(_paymentId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> GetByDepartmentId(int _departmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartmentId(_departmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SalaryPaymentVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryPaymentVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryPaymentVw> GetByDepartmentId(int _departmentId, Db db)
		{
			return db.SalaryPaymentVwGetByDepartmentId(_departmentId);
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
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> List(Db db)
		{
			return db.SalaryWorkPlaceVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null.</returns>
		public static SalaryWorkPlaceVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null.</returns>
		public static SalaryWorkPlaceVw Get(int _id, Db db)
		{
			return db.SalaryWorkPlaceVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryWorkPlaceVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlaceVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SalaryWorkPlaceVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SalaryWorkPlaceVw GetChildren(int _id, Db db)
		{
			return db.SalaryWorkPlaceVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByMainWorkPlaceId(int _mainWorkPlaceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMainWorkPlaceId(_mainWorkPlaceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db)
		{
			return db.SalaryWorkPlaceVwGetByMainWorkPlaceId(_mainWorkPlaceId);
		}		

		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SalaryWorkPlaceVw view.
		/// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SalaryWorkPlaceVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SalaryWorkPlaceVw> GetByName(string _name, Db db)
		{
			return db.SalaryWorkPlaceVwGetByName(_name);
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
		/// <returns>A list of ServiceEndGrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ServiceEndGrantRequestVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of ServiceEndGrantRequestVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ServiceEndGrantRequestVw> List(Db db)
		{
			return db.ServiceEndGrantRequestVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null.</returns>
		public static ServiceEndGrantRequestVw Get(int _grantRequestRequestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_grantRequestRequestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null.</returns>
		public static ServiceEndGrantRequestVw Get(int _grantRequestRequestProductId, Db db)
		{
			return db.ServiceEndGrantRequestVwGet(_grantRequestRequestProductId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ServiceEndGrantRequestVw GetChildren(int _grantRequestRequestProductId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_grantRequestRequestProductId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequestVw view with related objects from children.
		/// </summary>
		/// <param name="_grantRequestRequestProductId">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of ServiceEndGrantRequestVw or null. If an instance is returned, child objects will also be returned</returns>
		public static ServiceEndGrantRequestVw GetChildren(int _grantRequestRequestProductId, Db db)
		{
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
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SettlementVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> List(Db db)
		{
			return db.SettlementVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SettlementVw view.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		/// <returns>Gets an instance of SettlementVw or null.</returns>
		public static SettlementVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SettlementVw view.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SettlementVw or null.</returns>
		public static SettlementVw Get(int _id, Db db)
		{
			return db.SettlementVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SettlementVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		/// <returns>Gets an instance of SettlementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SettlementVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SettlementVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SettlementVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SettlementVw GetChildren(int _id, Db db)
		{
			return db.SettlementVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByInstallmentId(int _installmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByInstallmentId(_installmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of InstallmentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByInstallmentId(int _installmentId, Db db)
		{
			return db.SettlementVwGetByInstallmentId(_installmentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of InstallmentId_PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_installmentId">القسط</param>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByInstallmentId_PaymentId(int _installmentId, int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByInstallmentId_PaymentId(_installmentId, _paymentId, db);
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
		public static List<SettlementVw> GetByInstallmentId_PaymentId(int _installmentId, int _paymentId, Db db)
		{
			return db.SettlementVwGetByInstallmentId_PaymentId(_installmentId, _paymentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByPaymentId(int _paymentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByPaymentId(_paymentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of PaymentId columns in the  dbo.SettlementVw view.
		/// </summary>
		/// <param name="_paymentId">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SettlementVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SettlementVw> GetByPaymentId(int _paymentId, Db db)
		{
			return db.SettlementVwGetByPaymentId(_paymentId);
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
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> List(Db db)
		{
			return db.SpecialCaseLoanVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null.</returns>
		public static SpecialCaseLoanVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null.</returns>
		public static SpecialCaseLoanVw Get(int _id, Db db)
		{
			return db.SpecialCaseLoanVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SpecialCaseLoanVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SpecialCaseLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SpecialCaseLoanVw GetChildren(int _id, Db db)
		{
			return db.SpecialCaseLoanVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByDate(DateTime _date)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDate(_date, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Date columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByDate(DateTime _date, Db db)
		{
			return db.SpecialCaseLoanVwGetByDate(_date);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.SpecialCaseLoanVwGetByEmployeeId(_employeeId);
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
		public static List<SpecialCaseLoanVw> GetByEmployeeId_Date_LoanTypeProductTypeId(int _employeeId, DateTime _date, short _loanTypeProductTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId_Date_LoanTypeProductTypeId(_employeeId, _date, _loanTypeProductTypeId, db);
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
		public static List<SpecialCaseLoanVw> GetByEmployeeId_Date_LoanTypeProductTypeId(int _employeeId, DateTime _date, short _loanTypeProductTypeId, Db db)
		{
			return db.SpecialCaseLoanVwGetByEmployeeId_Date_LoanTypeProductTypeId(_employeeId, _date, _loanTypeProductTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByLoanTypeProductTypeId(_loanTypeProductTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of LoanTypeProductTypeId columns in the  dbo.SpecialCaseLoanVw view.
		/// </summary>
		/// <param name="_loanTypeProductTypeId">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SpecialCaseLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SpecialCaseLoanVw> GetByLoanTypeProductTypeId(short _loanTypeProductTypeId, Db db)
		{
			return db.SpecialCaseLoanVwGetByLoanTypeProductTypeId(_loanTypeProductTypeId);
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
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SubscriptionTypeVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> List(Db db)
		{
			return db.SubscriptionTypeVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null.</returns>
		public static SubscriptionTypeVw Get(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null.</returns>
		public static SubscriptionTypeVw Get(byte _id, Db db)
		{
			return db.SubscriptionTypeVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionTypeVw GetChildren(byte _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SubscriptionTypeVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionTypeVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionTypeVw GetChildren(byte _id, Db db)
		{
			return db.SubscriptionTypeVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> GetByName(string _name)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByName(_name, db);
		}

        /// <summary>
		/// Gets rows related to one combination of Name columns in the  dbo.SubscriptionTypeVw view.
		/// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionTypeVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionTypeVw> GetByName(string _name, Db db)
		{
			return db.SubscriptionTypeVwGetByName(_name);
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
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.SubscriptionVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> List(Db db)
		{
			return db.SubscriptionVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionVw or null.</returns>
		public static SubscriptionVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionVw or null.</returns>
		public static SubscriptionVw Get(int _id, Db db)
		{
			return db.SubscriptionVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.SubscriptionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		/// <returns>Gets an instance of SubscriptionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.SubscriptionVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of SubscriptionVw or null. If an instance is returned, child objects will also be returned</returns>
		public static SubscriptionVw GetChildren(int _id, Db db)
		{
			return db.SubscriptionVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByDepartmentId(int _departmentId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDepartmentId(_departmentId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DepartmentId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_departmentId">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByDepartmentId(int _departmentId, Db db)
		{
			return db.SubscriptionVwGetByDepartmentId(_departmentId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.SubscriptionVwGetByEmployeeId(_employeeId);
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
		public static List<SubscriptionVw> GetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(int _employeeId, DateTime _month, int _departmentId, byte _subscriptionTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(_employeeId, _month, _departmentId, _subscriptionTypeId, db);
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
		public static List<SubscriptionVw> GetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(int _employeeId, DateTime _month, int _departmentId, byte _subscriptionTypeId, Db db)
		{
			return db.SubscriptionVwGetByEmployeeId_Month_DepartmentId_SubscriptionTypeId(_employeeId, _month, _departmentId, _subscriptionTypeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByIsFixed(bool _isFixed)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsFixed(_isFixed, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsFixed columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetByIsFixed(bool _isFixed, Db db)
		{
			return db.SubscriptionVwGetByIsFixed(_isFixed);
		}		

		/// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetBySubscriptionTypeId(byte _subscriptionTypeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetBySubscriptionTypeId(_subscriptionTypeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of SubscriptionTypeId columns in the  dbo.SubscriptionVw view.
		/// </summary>
		/// <param name="_subscriptionTypeId">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of SubscriptionVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionVw> GetBySubscriptionTypeId(byte _subscriptionTypeId, Db db)
		{
			return db.SubscriptionVwGetBySubscriptionTypeId(_subscriptionTypeId);
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
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> List(Db db)
		{
			return db.TransitoryIncomingLoanVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null.</returns>
		public static TransitoryIncomingLoanVw Get(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null.</returns>
		public static TransitoryIncomingLoanVw Get(int _employeeId, Db db)
		{
			return db.TransitoryIncomingLoanVwGet(_employeeId);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static TransitoryIncomingLoanVw GetChildren(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_employeeId, db);
		}

        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoanVw view with related objects from children.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of TransitoryIncomingLoanVw or null. If an instance is returned, child objects will also be returned</returns>
		public static TransitoryIncomingLoanVw GetChildren(int _employeeId, Db db)
		{
			return db.TransitoryIncomingLoanVwGetChildren(_employeeId);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByIsVerified(bool _isVerified)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsVerified(_isVerified, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByIsVerified(bool _isVerified, Db db)
		{
			return db.TransitoryIncomingLoanVwGetByIsVerified(_isVerified);
		}		

		/// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByMainWorkPlaceId(_mainWorkPlaceId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of MainWorkPlaceId columns in the  dbo.TransitoryIncomingLoanVw view.
		/// </summary>
		/// <param name="_mainWorkPlaceId">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of TransitoryIncomingLoanVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<TransitoryIncomingLoanVw> GetByMainWorkPlaceId(int _mainWorkPlaceId, Db db)
		{
			return db.TransitoryIncomingLoanVwGetByMainWorkPlaceId(_mainWorkPlaceId);
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
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> List()
		{
            Db db = new Db(DbServices.ConnectionString);
			return List(db);
		}

        /// <summary>
		/// Selects all rows from the dbo.WarrantVw view.
		/// </summary>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> List(Db db)
		{
			return db.WarrantVwList();
		}
        #endregion

		#region Get procedure
		/// <summary>
		/// Gets one row from the dbo.WarrantVw view.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		/// <returns>Gets an instance of WarrantVw or null.</returns>
		public static WarrantVw Get(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.WarrantVw view.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of WarrantVw or null.</returns>
		public static WarrantVw Get(int _id, Db db)
		{
			return db.WarrantVwGet(_id);
		}
        #endregion

		#region GetChildren procedure
		/// <summary>
		/// Gets one row from the dbo.WarrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		/// <returns>Gets an instance of WarrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static WarrantVw GetChildren(int _id)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetChildren(_id, db);
		}

        /// <summary>
		/// Gets one row from the dbo.WarrantVw view with related objects from children.
		/// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>Gets an instance of WarrantVw or null. If an instance is returned, child objects will also be returned</returns>
		public static WarrantVw GetChildren(int _id, Db db)
		{
			return db.WarrantVwGetChildren(_id);
		}
        #endregion
		
		#region Get by procedures
		/// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByDebtId(int _debtId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDebtId(_debtId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of DebtId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByDebtId(int _debtId, Db db)
		{
			return db.WarrantVwGetByDebtId(_debtId);
		}		

		/// <summary>
		/// Gets rows related to one combination of DebtId_EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_debtId">معرف المديونية</param>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByDebtId_EmployeeId(int _debtId, int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByDebtId_EmployeeId(_debtId, _employeeId, db);
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
		public static List<WarrantVw> GetByDebtId_EmployeeId(int _debtId, int _employeeId, Db db)
		{
			return db.WarrantVwGetByDebtId_EmployeeId(_debtId, _employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByEmployeeId(int _employeeId)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByEmployeeId(_employeeId, db);
		}

        /// <summary>
		/// Gets rows related to one combination of EmployeeId columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_employeeId">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByEmployeeId(int _employeeId, Db db)
		{
			return db.WarrantVwGetByEmployeeId(_employeeId);
		}		

		/// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByIsActive(bool _isActive)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetByIsActive(_isActive, db);
		}

        /// <summary>
		/// Gets rows related to one combination of IsActive columns in the  dbo.WarrantVw view.
		/// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
		/// <returns>A list of WarrantVw instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<WarrantVw> GetByIsActive(bool _isActive, Db db)
		{
			return db.WarrantVwGetByIsActive(_isActive);
		}
		#endregion
	}
	#endregion
}
