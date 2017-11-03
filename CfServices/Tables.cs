using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cf.Data;

namespace Cf.Services
{
    #region AvailabilityServices
    public static partial class AvailabilityServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Availability table.
        /// </summary>
        /// <returns>A list of Availability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Availability> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Availability table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Availability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Availability> List(Db db)
        {
            return db.AvailabilityList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Availability table.
        /// </summary>
		/// <param name="_id">معرف القاعدة</param>
        /// <returns>Gets an instance of Availability or null.</returns>
        public static Availability Get(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Availability table.
        /// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Availability or null.</returns>
        public static Availability Get(short _id, Db db)
        {
            return db.AvailabilityGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Availability] table.
        /// </summary>
        /// <param name="instance">An instance of Availability to be inserted.</param>
        /// <returns>The inserted Availability</returns>
        public static Availability Insert(Availability instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Availability] table.
        /// </summary>
        /// <param name="instance">An instance of Availability to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Availability</returns>
        public static Availability Insert(Availability instance, Db db)
        {
            return db.AvailabilityInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Availability] table.
        /// </summary>
        /// <param name="instance">An instance of Availability which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Availability instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Availability] table.
        /// </summary>
        /// <param name="instance">An instance of Availability which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Availability instance, Db db)
        {
            db.AvailabilityUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Availability] table.
        /// </summary>
		/// <param name="_id">معرف القاعدة</param>
        public static void Delete(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Availability] table.
        /// </summary>
		/// <param name="_id">معرف القاعدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(short _id, Db db)
        {
            db.AvailabilityDelete(_id);
        }
        #endregion
    }
    #endregion

    #region AvailabilityCeilingServices
    public static partial class AvailabilityCeilingServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.AvailabilityCeiling table.
        /// </summary>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.AvailabilityCeiling table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> List(Db db)
        {
            return db.AvailabilityCeilingList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_id">معرف السقف</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling Get(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling Get(short _id, Db db)
        {
            return db.AvailabilityCeilingGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="instance">An instance of AvailabilityCeiling to be inserted.</param>
        /// <returns>The inserted AvailabilityCeiling</returns>
        public static AvailabilityCeiling Insert(AvailabilityCeiling instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="instance">An instance of AvailabilityCeiling to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted AvailabilityCeiling</returns>
        public static AvailabilityCeiling Insert(AvailabilityCeiling instance, Db db)
        {
            return db.AvailabilityCeilingInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(AvailabilityCeiling instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(AvailabilityCeiling instance, Db db)
        {
            db.AvailabilityCeilingUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[AvailabilityCeiling] table.
        /// </summary>
		/// <param name="_id">معرف السقف</param>
        public static void Delete(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[AvailabilityCeiling] table.
        /// </summary>
		/// <param name="_id">معرف السقف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(short _id, Db db)
        {
            db.AvailabilityCeilingDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> GetByAvailability(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailability(_availability, db);
        }
    
        /// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> GetByAvailability(short _availability, Db db)
        {
            return db.AvailabilityCeilingGetByAvailability(_availability);
        }

        /// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling GetByAvailabilityFirstOrNull(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailabilityFirstOrNull(_availability, db);
        }

        /// <summary>
		/// Gets rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling GetByAvailabilityFirstOrNull(short _availability, Db db)
        {
            return db.AvailabilityCeilingGetByAvailabilityFirstOrNull(_availability);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> GetByAvailability_FromYear(short _availability, short _fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailability_FromYear(_availability, _fromYear, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of AvailabilityCeiling instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<AvailabilityCeiling> GetByAvailability_FromYear(short _availability, short _fromYear, Db db)
        {
            return db.AvailabilityCeilingGetByAvailability_FromYear(_availability, _fromYear);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling GetByAvailability_FromYearFirstOrNull(short _availability, short _fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailability_FromYearFirstOrNull(_availability, _fromYear, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Availability, FromYear) columns  in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of AvailabilityCeiling or null.</returns>
        public static AvailabilityCeiling GetByAvailability_FromYearFirstOrNull(short _availability, short _fromYear, Db db)
        {
            return db.AvailabilityCeilingGetByAvailability_FromYearFirstOrNull(_availability, _fromYear);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
        public static void DeleteByAvailability(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByAvailability(_availability, db);
        }

        /// <summary>
		/// Deletes rows related to one Availability from the dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByAvailability(short _availability, Db db)
        {
            db.AvailabilityCeilingDeleteByAvailability(_availability);
        }

        /// <summary>
		/// Deletes rows related to one combination of Availability, FromYear columns in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
        public static void DeleteByAvailability_FromYear(short _availability, short _fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByAvailability_FromYear(_availability, _fromYear, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Availability, FromYear columns in the  dbo.AvailabilityCeiling table.
        /// </summary>
		/// <param name="_availability">نوع السلف</param>
		/// <param name="_fromYear">الحد الأدنى لسنوات الخدمة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByAvailability_FromYear(short _availability, short _fromYear, Db db)
        {
            db.AvailabilityCeilingDeleteByAvailability_FromYear(_availability, _fromYear);
        }
        #endregion
    }
    #endregion

    #region BypassStatusServices
    public static partial class BypassStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.BypassStatus table.
        /// </summary>
        /// <returns>A list of BypassStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<BypassStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.BypassStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of BypassStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<BypassStatus> List(Db db)
        {
            return db.BypassStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.BypassStatus table.
        /// </summary>
		/// <param name="_id">معرف الحالة</param>
        /// <returns>Gets an instance of BypassStatus or null.</returns>
        public static BypassStatus Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.BypassStatus table.
        /// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of BypassStatus or null.</returns>
        public static BypassStatus Get(int _id, Db db)
        {
            return db.BypassStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="instance">An instance of BypassStatus to be inserted.</param>
        /// <returns>The inserted BypassStatus</returns>
        public static BypassStatus Insert(BypassStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="instance">An instance of BypassStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted BypassStatus</returns>
        public static BypassStatus Insert(BypassStatus instance, Db db)
        {
            return db.BypassStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(BypassStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(BypassStatus instance, Db db)
        {
            db.BypassStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[BypassStatus] table.
        /// </summary>
		/// <param name="_id">معرف الحالة</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[BypassStatus] table.
        /// </summary>
		/// <param name="_id">معرف الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.BypassStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
        /// <returns>A list of BypassStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<BypassStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of BypassStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<BypassStatus> GetByName(string _name, Db db)
        {
            return db.BypassStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
        /// <returns>Gets an instance of BypassStatus or null.</returns>
        public static BypassStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of BypassStatus or null.</returns>
        public static BypassStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.BypassStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.BypassStatus table.
        /// </summary>
		/// <param name="_name">بيان الحالة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.BypassStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region CashPaymentServices
    public static partial class CashPaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.CashPayment table.
        /// </summary>
        /// <returns>A list of CashPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<CashPayment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.CashPayment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of CashPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<CashPayment> List(Db db)
        {
            return db.CashPaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.CashPayment table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
        /// <returns>Gets an instance of CashPayment or null.</returns>
        public static CashPayment Get(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_payment, db);
        }

        /// <summary>
		/// Gets one row from the dbo.CashPayment table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of CashPayment or null.</returns>
        public static CashPayment Get(int _payment, Db db)
        {
            return db.CashPaymentGet(_payment);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="instance">An instance of CashPayment to be inserted.</param>
        /// <returns>The inserted CashPayment</returns>
        public static CashPayment Insert(CashPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="instance">An instance of CashPayment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted CashPayment</returns>
        public static CashPayment Insert(CashPayment instance, Db db)
        {
            return db.CashPaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="instance">An instance of CashPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(CashPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="instance">An instance of CashPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(CashPayment instance, Db db)
        {
            db.CashPaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[CashPayment] table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
        public static void Delete(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_payment, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[CashPayment] table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _payment, Db db)
        {
            db.CashPaymentDelete(_payment);
        }
        #endregion
    }
    #endregion

    #region CategoryServices
    public static partial class CategoryServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Category table.
        /// </summary>
        /// <returns>A list of Category instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Category> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Category table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Category instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Category> List(Db db)
        {
            return db.CategoryList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Category table.
        /// </summary>
		/// <param name="_id">معرف الهيئة</param>
        /// <returns>Gets an instance of Category or null.</returns>
        public static Category Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Category table.
        /// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Category or null.</returns>
        public static Category Get(byte _id, Db db)
        {
            return db.CategoryGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Category] table.
        /// </summary>
        /// <param name="instance">An instance of Category to be inserted.</param>
        /// <returns>The inserted Category</returns>
        public static Category Insert(Category instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Category] table.
        /// </summary>
        /// <param name="instance">An instance of Category to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Category</returns>
        public static Category Insert(Category instance, Db db)
        {
            return db.CategoryInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Category] table.
        /// </summary>
        /// <param name="instance">An instance of Category which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Category instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Category] table.
        /// </summary>
        /// <param name="instance">An instance of Category which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Category instance, Db db)
        {
            db.CategoryUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Category] table.
        /// </summary>
		/// <param name="_id">معرف الهيئة</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Category] table.
        /// </summary>
		/// <param name="_id">معرف الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.CategoryDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
        /// <returns>A list of Category instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Category> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Category instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Category> GetByName(string _name, Db db)
        {
            return db.CategoryGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
        /// <returns>Gets an instance of Category or null.</returns>
        public static Category GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Category or null.</returns>
        public static Category GetByNameFirstOrNull(string _name, Db db)
        {
            return db.CategoryGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Category table.
        /// </summary>
		/// <param name="_name">بيان الهيئة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.CategoryDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region CollectOrderServices
    public static partial class CollectOrderServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.CollectOrder table.
        /// </summary>
        /// <returns>A list of CollectOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<CollectOrder> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.CollectOrder table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of CollectOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<CollectOrder> List(Db db)
        {
            return db.CollectOrderList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.CollectOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر القبض</param>
        /// <returns>Gets an instance of CollectOrder or null.</returns>
        public static CollectOrder Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.CollectOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of CollectOrder or null.</returns>
        public static CollectOrder Get(int _id, Db db)
        {
            return db.CollectOrderGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="instance">An instance of CollectOrder to be inserted.</param>
        /// <returns>The inserted CollectOrder</returns>
        public static CollectOrder Insert(CollectOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="instance">An instance of CollectOrder to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted CollectOrder</returns>
        public static CollectOrder Insert(CollectOrder instance, Db db)
        {
            return db.CollectOrderInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(CollectOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(CollectOrder instance, Db db)
        {
            db.CollectOrderUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[CollectOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر القبض</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[CollectOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.CollectOrderDelete(_id);
        }
        #endregion
    }
    #endregion

    #region DebtServices
    public static partial class DebtServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Debt table.
        /// </summary>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Debt table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> List(Db db)
        {
            return db.DebtList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Debt table.
        /// </summary>
		/// <param name="_id">معرف المديونية</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Debt table.
        /// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt Get(int _id, Db db)
        {
            return db.DebtGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Debt] table.
        /// </summary>
        /// <param name="instance">An instance of Debt to be inserted.</param>
        /// <returns>The inserted Debt</returns>
        public static Debt Insert(Debt instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Debt] table.
        /// </summary>
        /// <param name="instance">An instance of Debt to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Debt</returns>
        public static Debt Insert(Debt instance, Db db)
        {
            return db.DebtInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Debt] table.
        /// </summary>
        /// <param name="instance">An instance of Debt which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Debt instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Debt] table.
        /// </summary>
        /// <param name="instance">An instance of Debt which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Debt instance, Db db)
        {
            db.DebtUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Debt] table.
        /// </summary>
		/// <param name="_id">معرف المديونية</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Debt] table.
        /// </summary>
		/// <param name="_id">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.DebtDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByDate(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByDate(Nullable<DateTime> _date, Db db)
        {
            return db.DebtGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByDateFirstOrNull(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByDateFirstOrNull(Nullable<DateTime> _date, Db db)
        {
            return db.DebtGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByEmployee(int _employee, Db db)
        {
            return db.DebtGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.DebtGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActive(_isActive, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByIsActive(bool _isActive, Db db)
        {
            return db.DebtGetByIsActive(_isActive);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByIsActiveFirstOrNull(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActiveFirstOrNull(_isActive, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByIsActiveFirstOrNull(bool _isActive, Db db)
        {
            return db.DebtGetByIsActiveFirstOrNull(_isActive);
        }           

        /// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByIssuer(byte _issuer)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIssuer(_issuer, db);
        }
    
        /// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Debt instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Debt> GetByIssuer(byte _issuer, Db db)
        {
            return db.DebtGetByIssuer(_issuer);
        }

        /// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByIssuerFirstOrNull(byte _issuer)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIssuerFirstOrNull(_issuer, db);
        }

        /// <summary>
		/// Gets rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Debt or null.</returns>
        public static Debt GetByIssuerFirstOrNull(byte _issuer, Db db)
        {
            return db.DebtGetByIssuerFirstOrNull(_issuer);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
        public static void DeleteByDate(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Debt table.
        /// </summary>
		/// <param name="_date">تاريخ المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(Nullable<DateTime> _date, Db db)
        {
            db.DebtDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Debt table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.DebtDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
        public static void DeleteByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsActive(_isActive, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Debt table.
        /// </summary>
		/// <param name="_isActive">المديونية فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsActive(bool _isActive, Db db)
        {
            db.DebtDeleteByIsActive(_isActive);
        }

        /// <summary>
		/// Deletes rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
        public static void DeleteByIssuer(byte _issuer)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIssuer(_issuer, db);
        }

        /// <summary>
		/// Deletes rows related to one Issuer from the dbo.Debt table.
        /// </summary>
		/// <param name="_issuer">جهة المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIssuer(byte _issuer, Db db)
        {
            db.DebtDeleteByIssuer(_issuer);
        }
        #endregion
    }
    #endregion

    #region DepartmentServices
    public static partial class DepartmentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Department table.
        /// </summary>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Department table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> List(Db db)
        {
            return db.DepartmentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Department table.
        /// </summary>
		/// <param name="_id">معرف الفعالية</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Department table.
        /// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department Get(int _id, Db db)
        {
            return db.DepartmentGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Department] table.
        /// </summary>
        /// <param name="instance">An instance of Department to be inserted.</param>
        /// <returns>The inserted Department</returns>
        public static Department Insert(Department instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Department] table.
        /// </summary>
        /// <param name="instance">An instance of Department to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Department</returns>
        public static Department Insert(Department instance, Db db)
        {
            return db.DepartmentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Department] table.
        /// </summary>
        /// <param name="instance">An instance of Department which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Department instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Department] table.
        /// </summary>
        /// <param name="instance">An instance of Department which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Department instance, Db db)
        {
            db.DepartmentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Department] table.
        /// </summary>
		/// <param name="_id">معرف الفعالية</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Department] table.
        /// </summary>
		/// <param name="_id">معرف الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.DepartmentDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> GetByName(string _name, Db db)
        {
            return db.DepartmentGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department GetByNameFirstOrNull(string _name, Db db)
        {
            return db.DepartmentGetByNameFirstOrNull(_name);
        }           

        /// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> GetBySalaryWorkPlace(int _salaryWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetBySalaryWorkPlace(_salaryWorkPlace, db);
        }
    
        /// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Department instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Department> GetBySalaryWorkPlace(int _salaryWorkPlace, Db db)
        {
            return db.DepartmentGetBySalaryWorkPlace(_salaryWorkPlace);
        }

        /// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department GetBySalaryWorkPlaceFirstOrNull(int _salaryWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetBySalaryWorkPlaceFirstOrNull(_salaryWorkPlace, db);
        }

        /// <summary>
		/// Gets rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Department or null.</returns>
        public static Department GetBySalaryWorkPlaceFirstOrNull(int _salaryWorkPlace, Db db)
        {
            return db.DepartmentGetBySalaryWorkPlaceFirstOrNull(_salaryWorkPlace);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Department table.
        /// </summary>
		/// <param name="_name">اسم الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.DepartmentDeleteByName(_name);
        }

        /// <summary>
		/// Deletes rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
        public static void DeleteBySalaryWorkPlace(int _salaryWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteBySalaryWorkPlace(_salaryWorkPlace, db);
        }

        /// <summary>
		/// Deletes rows related to one SalaryWorkPlace from the dbo.Department table.
        /// </summary>
		/// <param name="_salaryWorkPlace">جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteBySalaryWorkPlace(int _salaryWorkPlace, Db db)
        {
            db.DepartmentDeleteBySalaryWorkPlace(_salaryWorkPlace);
        }
        #endregion
    }
    #endregion

    #region DownPaymentServices
    public static partial class DownPaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.DownPayment table.
        /// </summary>
        /// <returns>A list of DownPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<DownPayment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.DownPayment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of DownPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<DownPayment> List(Db db)
        {
            return db.DownPaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
        /// <returns>Gets an instance of DownPayment or null.</returns>
        public static DownPayment Get(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_payment, db);
        }

        /// <summary>
		/// Gets one row from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of DownPayment or null.</returns>
        public static DownPayment Get(int _payment, Db db)
        {
            return db.DownPaymentGet(_payment);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="instance">An instance of DownPayment to be inserted.</param>
        /// <returns>The inserted DownPayment</returns>
        public static DownPayment Insert(DownPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="instance">An instance of DownPayment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted DownPayment</returns>
        public static DownPayment Insert(DownPayment instance, Db db)
        {
            return db.DownPaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="instance">An instance of DownPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(DownPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="instance">An instance of DownPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(DownPayment instance, Db db)
        {
            db.DownPaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[DownPayment] table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
        public static void Delete(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_payment, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[DownPayment] table.
        /// </summary>
		/// <param name="_payment">معرف الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _payment, Db db)
        {
            db.DownPaymentDelete(_payment);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
        /// <returns>A list of DownPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<DownPayment> GetByRequest(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRequest(_request, db);
        }
    
        /// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of DownPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<DownPayment> GetByRequest(int _request, Db db)
        {
            return db.DownPaymentGetByRequest(_request);
        }

        /// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
        /// <returns>Gets an instance of DownPayment or null.</returns>
        public static DownPayment GetByRequestFirstOrNull(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRequestFirstOrNull(_request, db);
        }

        /// <summary>
		/// Gets rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of DownPayment or null.</returns>
        public static DownPayment GetByRequestFirstOrNull(int _request, Db db)
        {
            return db.DownPaymentGetByRequestFirstOrNull(_request);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
        public static void DeleteByRequest(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRequest(_request, db);
        }

        /// <summary>
		/// Deletes rows related to one Request from the dbo.DownPayment table.
        /// </summary>
		/// <param name="_request">رقم الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRequest(int _request, Db db)
        {
            db.DownPaymentDeleteByRequest(_request);
        }
        #endregion
    }
    #endregion

    #region EmployeeServices
    public static partial class EmployeeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Employee table.
        /// </summary>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Employee table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> List(Db db)
        {
            return db.EmployeeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Employee table.
        /// </summary>
		/// <param name="_id">الرقم الذاتي</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Employee table.
        /// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee Get(int _id, Db db)
        {
            return db.EmployeeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Employee] table.
        /// </summary>
        /// <param name="instance">An instance of Employee to be inserted.</param>
        /// <returns>The inserted Employee</returns>
        public static Employee Insert(Employee instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Employee] table.
        /// </summary>
        /// <param name="instance">An instance of Employee to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Employee</returns>
        public static Employee Insert(Employee instance, Db db)
        {
            return db.EmployeeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Employee] table.
        /// </summary>
        /// <param name="instance">An instance of Employee which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Employee instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Employee] table.
        /// </summary>
        /// <param name="instance">An instance of Employee which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Employee instance, Db db)
        {
            db.EmployeeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Employee] table.
        /// </summary>
		/// <param name="_id">الرقم الذاتي</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Employee] table.
        /// </summary>
		/// <param name="_id">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.EmployeeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByCategory(byte _category)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByCategory(_category, db);
        }
    
        /// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByCategory(byte _category, Db db)
        {
            return db.EmployeeGetByCategory(_category);
        }

        /// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByCategoryFirstOrNull(byte _category)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByCategoryFirstOrNull(_category, db);
        }

        /// <summary>
		/// Gets rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByCategoryFirstOrNull(byte _category, Db db)
        {
            return db.EmployeeGetByCategoryFirstOrNull(_category);
        }           

        /// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartment(_department, db);
        }
    
        /// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByDepartment(int _department, Db db)
        {
            return db.EmployeeGetByDepartment(_department);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByDepartmentFirstOrNull(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartmentFirstOrNull(_department, db);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByDepartmentFirstOrNull(int _department, Db db)
        {
            return db.EmployeeGetByDepartmentFirstOrNull(_department);
        }           

        /// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByEmployeeStatus(byte _employeeStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeStatus(_employeeStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByEmployeeStatus(byte _employeeStatus, Db db)
        {
            return db.EmployeeGetByEmployeeStatus(_employeeStatus);
        }

        /// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByEmployeeStatusFirstOrNull(byte _employeeStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeStatusFirstOrNull(_employeeStatus, db);
        }

        /// <summary>
		/// Gets rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByEmployeeStatusFirstOrNull(byte _employeeStatus, Db db)
        {
            return db.EmployeeGetByEmployeeStatusFirstOrNull(_employeeStatus);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByFirstName_LastName(string _firstName, string _lastName)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByFirstName_LastName(_firstName, _lastName, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Employee instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Employee> GetByFirstName_LastName(string _firstName, string _lastName, Db db)
        {
            return db.EmployeeGetByFirstName_LastName(_firstName, _lastName);
        }

        /// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByFirstName_LastNameFirstOrNull(string _firstName, string _lastName)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByFirstName_LastNameFirstOrNull(_firstName, _lastName, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (FirstName, LastName) columns  in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Employee or null.</returns>
        public static Employee GetByFirstName_LastNameFirstOrNull(string _firstName, string _lastName, Db db)
        {
            return db.EmployeeGetByFirstName_LastNameFirstOrNull(_firstName, _lastName);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
        public static void DeleteByCategory(byte _category)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByCategory(_category, db);
        }

        /// <summary>
		/// Deletes rows related to one Category from the dbo.Employee table.
        /// </summary>
		/// <param name="_category">الهيئة الوظيفية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByCategory(byte _category, Db db)
        {
            db.EmployeeDeleteByCategory(_category);
        }

        /// <summary>
		/// Deletes rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        public static void DeleteByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDepartment(_department, db);
        }

        /// <summary>
		/// Deletes rows related to one Department from the dbo.Employee table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDepartment(int _department, Db db)
        {
            db.EmployeeDeleteByDepartment(_department);
        }

        /// <summary>
		/// Deletes rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
        public static void DeleteByEmployeeStatus(byte _employeeStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployeeStatus(_employeeStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one EmployeeStatus from the dbo.Employee table.
        /// </summary>
		/// <param name="_employeeStatus">الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployeeStatus(byte _employeeStatus, Db db)
        {
            db.EmployeeDeleteByEmployeeStatus(_employeeStatus);
        }

        /// <summary>
		/// Deletes rows related to one combination of FirstName, LastName columns in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
        public static void DeleteByFirstName_LastName(string _firstName, string _lastName)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByFirstName_LastName(_firstName, _lastName, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of FirstName, LastName columns in the  dbo.Employee table.
        /// </summary>
		/// <param name="_firstName">الاسم</param>
		/// <param name="_lastName">الشهرة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByFirstName_LastName(string _firstName, string _lastName, Db db)
        {
            db.EmployeeDeleteByFirstName_LastName(_firstName, _lastName);
        }
        #endregion
    }
    #endregion

    #region EmployeeSeniorityServices
    public static partial class EmployeeSeniorityServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeSeniority table.
        /// </summary>
        /// <returns>A list of EmployeeSeniority instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeSeniority> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EmployeeSeniority table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EmployeeSeniority instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeSeniority> List(Db db)
        {
            return db.EmployeeSeniorityList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniority table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of EmployeeSeniority or null.</returns>
        public static EmployeeSeniority Get(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_employee, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EmployeeSeniority table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EmployeeSeniority or null.</returns>
        public static EmployeeSeniority Get(int _employee, Db db)
        {
            return db.EmployeeSeniorityGet(_employee);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeSeniority to be inserted.</param>
        /// <returns>The inserted EmployeeSeniority</returns>
        public static EmployeeSeniority Insert(EmployeeSeniority instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeSeniority to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EmployeeSeniority</returns>
        public static EmployeeSeniority Insert(EmployeeSeniority instance, Db db)
        {
            return db.EmployeeSeniorityInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EmployeeSeniority instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EmployeeSeniority instance, Db db)
        {
            db.EmployeeSeniorityUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeSeniority] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void Delete(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_employee, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeSeniority] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _employee, Db db)
        {
            db.EmployeeSeniorityDelete(_employee);
        }
        #endregion
    }
    #endregion

    #region EmployeeStatusServices
    public static partial class EmployeeStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EmployeeStatus table.
        /// </summary>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EmployeeStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> List(Db db)
        {
            return db.EmployeeStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus Get(byte _id, Db db)
        {
            return db.EmployeeStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeStatus to be inserted.</param>
        /// <returns>The inserted EmployeeStatus</returns>
        public static EmployeeStatus Insert(EmployeeStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EmployeeStatus</returns>
        public static EmployeeStatus Insert(EmployeeStatus instance, Db db)
        {
            return db.EmployeeStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EmployeeStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EmployeeStatus instance, Db db)
        {
            db.EmployeeStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeStatus] table.
        /// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeStatus] table.
        /// </summary>
		/// <param name="_id">معرف الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.EmployeeStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> GetByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActive(_isActive, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> GetByIsActive(bool _isActive, Db db)
        {
            return db.EmployeeStatusGetByIsActive(_isActive);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus GetByIsActiveFirstOrNull(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActiveFirstOrNull(_isActive, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus GetByIsActiveFirstOrNull(bool _isActive, Db db)
        {
            return db.EmployeeStatusGetByIsActiveFirstOrNull(_isActive);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeStatus> GetByName(string _name, Db db)
        {
            return db.EmployeeStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EmployeeStatus or null.</returns>
        public static EmployeeStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.EmployeeStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
        public static void DeleteByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsActive(_isActive, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_isActive">مفعل؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsActive(bool _isActive, Db db)
        {
            db.EmployeeStatusDeleteByIsActive(_isActive);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EmployeeStatus table.
        /// </summary>
		/// <param name="_name">بيان الوضع الوظيفي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.EmployeeStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region EndWorkGrantBracketServices
    public static partial class EndWorkGrantBracketServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracket table.
        /// </summary>
        /// <returns>A list of EndWorkGrantBracket instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EndWorkGrantBracket> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EndWorkGrantBracket table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EndWorkGrantBracket instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EndWorkGrantBracket> List(Db db)
        {
            return db.EndWorkGrantBracketList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracket table.
        /// </summary>
		/// <param name="_fromYear">من سنة</param>
        /// <returns>Gets an instance of EndWorkGrantBracket or null.</returns>
        public static EndWorkGrantBracket Get(byte _fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_fromYear, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EndWorkGrantBracket table.
        /// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EndWorkGrantBracket or null.</returns>
        public static EndWorkGrantBracket Get(byte _fromYear, Db db)
        {
            return db.EndWorkGrantBracketGet(_fromYear);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="instance">An instance of EndWorkGrantBracket to be inserted.</param>
        /// <returns>The inserted EndWorkGrantBracket</returns>
        public static EndWorkGrantBracket Insert(EndWorkGrantBracket instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="instance">An instance of EndWorkGrantBracket to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EndWorkGrantBracket</returns>
        public static EndWorkGrantBracket Insert(EndWorkGrantBracket instance, Db db)
        {
            return db.EndWorkGrantBracketInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EndWorkGrantBracket instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EndWorkGrantBracket instance, Db db)
        {
            db.EndWorkGrantBracketUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
		/// <param name="_fromYear">من سنة</param>
        public static void Delete(byte _fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_fromYear, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
		/// <param name="_fromYear">من سنة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _fromYear, Db db)
        {
            db.EndWorkGrantBracketDelete(_fromYear);
        }
        #endregion
    }
    #endregion

    #region ErrorDefinitionServices
    public static partial class ErrorDefinitionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ErrorDefinition table.
        /// </summary>
        /// <returns>A list of ErrorDefinition instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ErrorDefinition> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ErrorDefinition table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ErrorDefinition instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ErrorDefinition> List(Db db)
        {
            return db.ErrorDefinitionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
        /// <returns>Gets an instance of ErrorDefinition or null.</returns>
        public static ErrorDefinition Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ErrorDefinition or null.</returns>
        public static ErrorDefinition Get(int _id, Db db)
        {
            return db.ErrorDefinitionGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="instance">An instance of ErrorDefinition to be inserted.</param>
        /// <returns>The inserted ErrorDefinition</returns>
        public static ErrorDefinition Insert(ErrorDefinition instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="instance">An instance of ErrorDefinition to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ErrorDefinition</returns>
        public static ErrorDefinition Insert(ErrorDefinition instance, Db db)
        {
            return db.ErrorDefinitionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ErrorDefinition instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ErrorDefinition instance, Db db)
        {
            db.ErrorDefinitionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ErrorDefinition] table.
        /// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ErrorDefinition] table.
        /// </summary>
		/// <param name="_id">ErrorDefinition identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ErrorDefinitionDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
        /// <returns>A list of ErrorDefinition instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ErrorDefinition> GetByLikeExpression(string _likeExpression)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLikeExpression(_likeExpression, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ErrorDefinition instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ErrorDefinition> GetByLikeExpression(string _likeExpression, Db db)
        {
            return db.ErrorDefinitionGetByLikeExpression(_likeExpression);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
        /// <returns>Gets an instance of ErrorDefinition or null.</returns>
        public static ErrorDefinition GetByLikeExpressionFirstOrNull(string _likeExpression)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLikeExpressionFirstOrNull(_likeExpression, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ErrorDefinition or null.</returns>
        public static ErrorDefinition GetByLikeExpressionFirstOrNull(string _likeExpression, Db db)
        {
            return db.ErrorDefinitionGetByLikeExpressionFirstOrNull(_likeExpression);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
        public static void DeleteByLikeExpression(string _likeExpression)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLikeExpression(_likeExpression, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of LikeExpression columns in the  dbo.ErrorDefinition table.
        /// </summary>
		/// <param name="_likeExpression">An expresion with which messages are compared to get matches. If two messages match to the same LikeExpression they are considered identical.</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLikeExpression(string _likeExpression, Db db)
        {
            db.ErrorDefinitionDeleteByLikeExpression(_likeExpression);
        }
        #endregion
    }
    #endregion

    #region EventCategoryServices
    public static partial class EventCategoryServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventCategory table.
        /// </summary>
        /// <returns>A list of EventCategory instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventCategory> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EventCategory table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventCategory instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventCategory> List(Db db)
        {
            return db.EventCategoryList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventCategory table.
        /// </summary>
		/// <param name="_id">EventCategory identifier</param>
        /// <returns>Gets an instance of EventCategory or null.</returns>
        public static EventCategory Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EventCategory table.
        /// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventCategory or null.</returns>
        public static EventCategory Get(int _id, Db db)
        {
            return db.EventCategoryGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="instance">An instance of EventCategory to be inserted.</param>
        /// <returns>The inserted EventCategory</returns>
        public static EventCategory Insert(EventCategory instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="instance">An instance of EventCategory to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EventCategory</returns>
        public static EventCategory Insert(EventCategory instance, Db db)
        {
            return db.EventCategoryInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="instance">An instance of EventCategory which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EventCategory instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="instance">An instance of EventCategory which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EventCategory instance, Db db)
        {
            db.EventCategoryUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventCategory] table.
        /// </summary>
		/// <param name="_id">EventCategory identifier</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventCategory] table.
        /// </summary>
		/// <param name="_id">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.EventCategoryDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
        /// <returns>A list of EventCategory instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventCategory> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventCategory instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventCategory> GetByName(string _name, Db db)
        {
            return db.EventCategoryGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
        /// <returns>Gets an instance of EventCategory or null.</returns>
        public static EventCategory GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventCategory or null.</returns>
        public static EventCategory GetByNameFirstOrNull(string _name, Db db)
        {
            return db.EventCategoryGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventCategory table.
        /// </summary>
		/// <param name="_name">EventCategory Name</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.EventCategoryDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region EventLogServices
    public static partial class EventLogServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventLog table.
        /// </summary>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EventLog table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> List(Db db)
        {
            return db.EventLogList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventLog table.
        /// </summary>
		/// <param name="_id">EventLog identifier</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog Get(long _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EventLog table.
        /// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog Get(long _id, Db db)
        {
            return db.EventLogGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="instance">An instance of EventLog to be inserted.</param>
        /// <returns>The inserted EventLog</returns>
        public static EventLog Insert(EventLog instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="instance">An instance of EventLog to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EventLog</returns>
        public static EventLog Insert(EventLog instance, Db db)
        {
            return db.EventLogInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="instance">An instance of EventLog which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EventLog instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="instance">An instance of EventLog which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EventLog instance, Db db)
        {
            db.EventLogUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventLog] table.
        /// </summary>
		/// <param name="_id">EventLog identifier</param>
        public static void Delete(long _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventLog] table.
        /// </summary>
		/// <param name="_id">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(long _id, Db db)
        {
            db.EventLogDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByDate(DateTime _date, Db db)
        {
            return db.EventLogGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByDateFirstOrNull(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByDateFirstOrNull(DateTime _date, Db db)
        {
            return db.EventLogGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventCategory(int _eventCategory)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventCategory(_eventCategory, db);
        }
    
        /// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventCategory(int _eventCategory, Db db)
        {
            return db.EventLogGetByEventCategory(_eventCategory);
        }

        /// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventCategoryFirstOrNull(int _eventCategory)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventCategoryFirstOrNull(_eventCategory, db);
        }

        /// <summary>
		/// Gets rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventCategoryFirstOrNull(int _eventCategory, Db db)
        {
            return db.EventLogGetByEventCategoryFirstOrNull(_eventCategory);
        }           

        /// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventSource(int _eventSource)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventSource(_eventSource, db);
        }
    
        /// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventSource(int _eventSource, Db db)
        {
            return db.EventLogGetByEventSource(_eventSource);
        }

        /// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventSourceFirstOrNull(int _eventSource)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventSourceFirstOrNull(_eventSource, db);
        }

        /// <summary>
		/// Gets rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventSourceFirstOrNull(int _eventSource, Db db)
        {
            return db.EventLogGetByEventSourceFirstOrNull(_eventSource);
        }           

        /// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventStatus(int _eventStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventStatus(_eventStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByEventStatus(int _eventStatus, Db db)
        {
            return db.EventLogGetByEventStatus(_eventStatus);
        }

        /// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventStatusFirstOrNull(int _eventStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEventStatusFirstOrNull(_eventStatus, db);
        }

        /// <summary>
		/// Gets rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByEventStatusFirstOrNull(int _eventStatus, Db db)
        {
            return db.EventLogGetByEventStatusFirstOrNull(_eventStatus);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByUser(int _user)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByUser(_user, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLog instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLog> GetByUser(int _user, Db db)
        {
            return db.EventLogGetByUser(_user);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByUserFirstOrNull(int _user)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByUserFirstOrNull(_user, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLog or null.</returns>
        public static EventLog GetByUserFirstOrNull(int _user, Db db)
        {
            return db.EventLogGetByUserFirstOrNull(_user);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
        public static void DeleteByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_date">Date of the EventLog</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(DateTime _date, Db db)
        {
            db.EventLogDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
        public static void DeleteByEventCategory(int _eventCategory)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEventCategory(_eventCategory, db);
        }

        /// <summary>
		/// Deletes rows related to one EventCategory from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventCategory">EventCategory identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEventCategory(int _eventCategory, Db db)
        {
            db.EventLogDeleteByEventCategory(_eventCategory);
        }

        /// <summary>
		/// Deletes rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
        public static void DeleteByEventSource(int _eventSource)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEventSource(_eventSource, db);
        }

        /// <summary>
		/// Deletes rows related to one EventSource from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventSource">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEventSource(int _eventSource, Db db)
        {
            db.EventLogDeleteByEventSource(_eventSource);
        }

        /// <summary>
		/// Deletes rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
        public static void DeleteByEventStatus(int _eventStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEventStatus(_eventStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one EventStatus from the dbo.EventLog table.
        /// </summary>
		/// <param name="_eventStatus">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEventStatus(int _eventStatus, Db db)
        {
            db.EventLogDeleteByEventStatus(_eventStatus);
        }

        /// <summary>
		/// Deletes rows related to one combination of User columns in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
        public static void DeleteByUser(int _user)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByUser(_user, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of User columns in the  dbo.EventLog table.
        /// </summary>
		/// <param name="_user">User identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByUser(int _user, Db db)
        {
            db.EventLogDeleteByUser(_user);
        }
        #endregion
    }
    #endregion

    #region EventLogErrorServices
    public static partial class EventLogErrorServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventLogError table.
        /// </summary>
        /// <returns>A list of EventLogError instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLogError> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EventLogError table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventLogError instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventLogError> List(Db db)
        {
            return db.EventLogErrorList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventLogError table.
        /// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
        /// <returns>Gets an instance of EventLogError or null.</returns>
        public static EventLogError Get(long _eventLog)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_eventLog, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EventLogError table.
        /// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventLogError or null.</returns>
        public static EventLogError Get(long _eventLog, Db db)
        {
            return db.EventLogErrorGet(_eventLog);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="instance">An instance of EventLogError to be inserted.</param>
        /// <returns>The inserted EventLogError</returns>
        public static EventLogError Insert(EventLogError instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="instance">An instance of EventLogError to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EventLogError</returns>
        public static EventLogError Insert(EventLogError instance, Db db)
        {
            return db.EventLogErrorInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="instance">An instance of EventLogError which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EventLogError instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="instance">An instance of EventLogError which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EventLogError instance, Db db)
        {
            db.EventLogErrorUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventLogError] table.
        /// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
        public static void Delete(long _eventLog)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_eventLog, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventLogError] table.
        /// </summary>
		/// <param name="_eventLog">EventLog identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(long _eventLog, Db db)
        {
            db.EventLogErrorDelete(_eventLog);
        }
        #endregion
    }
    #endregion

    #region EventSourceServices
    public static partial class EventSourceServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventSource table.
        /// </summary>
        /// <returns>A list of EventSource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventSource> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EventSource table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventSource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventSource> List(Db db)
        {
            return db.EventSourceList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventSource table.
        /// </summary>
		/// <param name="_id">EventSource identifier</param>
        /// <returns>Gets an instance of EventSource or null.</returns>
        public static EventSource Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EventSource table.
        /// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventSource or null.</returns>
        public static EventSource Get(int _id, Db db)
        {
            return db.EventSourceGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="instance">An instance of EventSource to be inserted.</param>
        /// <returns>The inserted EventSource</returns>
        public static EventSource Insert(EventSource instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="instance">An instance of EventSource to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EventSource</returns>
        public static EventSource Insert(EventSource instance, Db db)
        {
            return db.EventSourceInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="instance">An instance of EventSource which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EventSource instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="instance">An instance of EventSource which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EventSource instance, Db db)
        {
            db.EventSourceUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventSource] table.
        /// </summary>
		/// <param name="_id">EventSource identifier</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventSource] table.
        /// </summary>
		/// <param name="_id">EventSource identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.EventSourceDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
        /// <returns>A list of EventSource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventSource> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventSource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventSource> GetByName(string _name, Db db)
        {
            return db.EventSourceGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
        /// <returns>Gets an instance of EventSource or null.</returns>
        public static EventSource GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventSource or null.</returns>
        public static EventSource GetByNameFirstOrNull(string _name, Db db)
        {
            return db.EventSourceGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventSource table.
        /// </summary>
		/// <param name="_name">EventSource name</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.EventSourceDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region EventStatusServices
    public static partial class EventStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.EventStatus table.
        /// </summary>
        /// <returns>A list of EventStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.EventStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventStatus> List(Db db)
        {
            return db.EventStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.EventStatus table.
        /// </summary>
		/// <param name="_id">EventStatus identifier</param>
        /// <returns>Gets an instance of EventStatus or null.</returns>
        public static EventStatus Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.EventStatus table.
        /// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventStatus or null.</returns>
        public static EventStatus Get(int _id, Db db)
        {
            return db.EventStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EventStatus to be inserted.</param>
        /// <returns>The inserted EventStatus</returns>
        public static EventStatus Insert(EventStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EventStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted EventStatus</returns>
        public static EventStatus Insert(EventStatus instance, Db db)
        {
            return db.EventStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EventStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(EventStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="instance">An instance of EventStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(EventStatus instance, Db db)
        {
            db.EventStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventStatus] table.
        /// </summary>
		/// <param name="_id">EventStatus identifier</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventStatus] table.
        /// </summary>
		/// <param name="_id">EventStatus identifier</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.EventStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
        /// <returns>A list of EventStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of EventStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EventStatus> GetByName(string _name, Db db)
        {
            return db.EventStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
        /// <returns>Gets an instance of EventStatus or null.</returns>
        public static EventStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of EventStatus or null.</returns>
        public static EventStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.EventStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.EventStatus table.
        /// </summary>
		/// <param name="_name">EventStatus name</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.EventStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region ExceptionalAmountServices
    public static partial class ExceptionalAmountServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmount table.
        /// </summary>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmount table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> List(Db db)
        {
            return db.ExceptionalAmountList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount Get(int _id, Db db)
        {
            return db.ExceptionalAmountGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmount to be inserted.</param>
        /// <returns>The inserted ExceptionalAmount</returns>
        public static ExceptionalAmount Insert(ExceptionalAmount instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmount to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ExceptionalAmount</returns>
        public static ExceptionalAmount Insert(ExceptionalAmount instance, Db db)
        {
            return db.ExceptionalAmountInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ExceptionalAmount instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ExceptionalAmount instance, Db db)
        {
            db.ExceptionalAmountUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmount] table.
        /// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmount] table.
        /// </summary>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ExceptionalAmountDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> GetByExceptionalAmountType(byte _exceptionalAmountType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByExceptionalAmountType(_exceptionalAmountType, db);
        }
    
        /// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> GetByExceptionalAmountType(byte _exceptionalAmountType, Db db)
        {
            return db.ExceptionalAmountGetByExceptionalAmountType(_exceptionalAmountType);
        }

        /// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount GetByExceptionalAmountTypeFirstOrNull(byte _exceptionalAmountType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByExceptionalAmountTypeFirstOrNull(_exceptionalAmountType, db);
        }

        /// <summary>
		/// Gets rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount GetByExceptionalAmountTypeFirstOrNull(byte _exceptionalAmountType, Db db)
        {
            return db.ExceptionalAmountGetByExceptionalAmountTypeFirstOrNull(_exceptionalAmountType);
        }           

        /// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> GetByLoanRequest(int _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanRequest(_loanRequest, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExceptionalAmount instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmount> GetByLoanRequest(int _loanRequest, Db db)
        {
            return db.ExceptionalAmountGetByLoanRequest(_loanRequest);
        }

        /// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount GetByLoanRequestFirstOrNull(int _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanRequestFirstOrNull(_loanRequest, db);
        }

        /// <summary>
		/// Gets rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExceptionalAmount or null.</returns>
        public static ExceptionalAmount GetByLoanRequestFirstOrNull(int _loanRequest, Db db)
        {
            return db.ExceptionalAmountGetByLoanRequestFirstOrNull(_loanRequest);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
        public static void DeleteByExceptionalAmountType(byte _exceptionalAmountType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByExceptionalAmountType(_exceptionalAmountType, db);
        }

        /// <summary>
		/// Deletes rows related to one ExceptionalAmountType from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_exceptionalAmountType">نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByExceptionalAmountType(byte _exceptionalAmountType, Db db)
        {
            db.ExceptionalAmountDeleteByExceptionalAmountType(_exceptionalAmountType);
        }

        /// <summary>
		/// Deletes rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
        public static void DeleteByLoanRequest(int _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanRequest(_loanRequest, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanRequest from the dbo.ExceptionalAmount table.
        /// </summary>
		/// <param name="_loanRequest">رقم طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanRequest(int _loanRequest, Db db)
        {
            db.ExceptionalAmountDeleteByLoanRequest(_loanRequest);
        }
        #endregion
    }
    #endregion

    #region ExceptionalAmountTypeServices
    public static partial class ExceptionalAmountTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountType table.
        /// </summary>
        /// <returns>A list of ExceptionalAmountType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmountType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ExceptionalAmountType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExceptionalAmountType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExceptionalAmountType> List(Db db)
        {
            return db.ExceptionalAmountTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountType table.
        /// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
        /// <returns>Gets an instance of ExceptionalAmountType or null.</returns>
        public static ExceptionalAmountType Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ExceptionalAmountType table.
        /// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExceptionalAmountType or null.</returns>
        public static ExceptionalAmountType Get(byte _id, Db db)
        {
            return db.ExceptionalAmountTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmountType to be inserted.</param>
        /// <returns>The inserted ExceptionalAmountType</returns>
        public static ExceptionalAmountType Insert(ExceptionalAmountType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmountType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ExceptionalAmountType</returns>
        public static ExceptionalAmountType Insert(ExceptionalAmountType instance, Db db)
        {
            return db.ExceptionalAmountTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ExceptionalAmountType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ExceptionalAmountType instance, Db db)
        {
            db.ExceptionalAmountTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmountType] table.
        /// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmountType] table.
        /// </summary>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.ExceptionalAmountTypeDelete(_id);
        }
        #endregion
    }
    #endregion

    #region ExternalGrantServices
    public static partial class ExternalGrantServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ExternalGrant table.
        /// </summary>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ExternalGrant table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> List(Db db)
        {
            return db.ExternalGrantList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_id">معرف الإعانة</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant Get(int _id, Db db)
        {
            return db.ExternalGrantGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="instance">An instance of ExternalGrant to be inserted.</param>
        /// <returns>The inserted ExternalGrant</returns>
        public static ExternalGrant Insert(ExternalGrant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="instance">An instance of ExternalGrant to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ExternalGrant</returns>
        public static ExternalGrant Insert(ExternalGrant instance, Db db)
        {
            return db.ExternalGrantInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ExternalGrant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ExternalGrant instance, Db db)
        {
            db.ExternalGrantUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExternalGrant] table.
        /// </summary>
		/// <param name="_id">معرف الإعانة</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExternalGrant] table.
        /// </summary>
		/// <param name="_id">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ExternalGrantDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> GetByEmployee(int _employee, Db db)
        {
            return db.ExternalGrantGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.ExternalGrantGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> GetByGrantType(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantType(_grantType, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ExternalGrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ExternalGrant> GetByGrantType(byte _grantType, Db db)
        {
            return db.ExternalGrantGetByGrantType(_grantType);
        }

        /// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant GetByGrantTypeFirstOrNull(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeFirstOrNull(_grantType, db);
        }

        /// <summary>
		/// Gets rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ExternalGrant or null.</returns>
        public static ExternalGrant GetByGrantTypeFirstOrNull(byte _grantType, Db db)
        {
            return db.ExternalGrantGetByGrantTypeFirstOrNull(_grantType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.ExternalGrantDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        public static void DeleteByGrantType(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantType(_grantType, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantType from the dbo.ExternalGrant table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantType(byte _grantType, Db db)
        {
            db.ExternalGrantDeleteByGrantType(_grantType);
        }
        #endregion
    }
    #endregion

    #region GrantServices
    public static partial class GrantServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Grant table.
        /// </summary>
        /// <returns>A list of Grant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Grant> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Grant table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Grant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Grant> List(Db db)
        {
            return db.GrantList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Grant table.
        /// </summary>
		/// <param name="_product">المنتج</param>
        /// <returns>Gets an instance of Grant or null.</returns>
        public static Grant Get(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_product, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Grant table.
        /// </summary>
		/// <param name="_product">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Grant or null.</returns>
        public static Grant Get(int _product, Db db)
        {
            return db.GrantGet(_product);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Grant] table.
        /// </summary>
        /// <param name="instance">An instance of Grant to be inserted.</param>
        /// <returns>The inserted Grant</returns>
        public static Grant Insert(Grant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Grant] table.
        /// </summary>
        /// <param name="instance">An instance of Grant to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Grant</returns>
        public static Grant Insert(Grant instance, Db db)
        {
            return db.GrantInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Grant] table.
        /// </summary>
        /// <param name="instance">An instance of Grant which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Grant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Grant] table.
        /// </summary>
        /// <param name="instance">An instance of Grant which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Grant instance, Db db)
        {
            db.GrantUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Grant] table.
        /// </summary>
		/// <param name="_product">المنتج</param>
        public static void Delete(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_product, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Grant] table.
        /// </summary>
		/// <param name="_product">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _product, Db db)
        {
            db.GrantDelete(_product);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
        /// <returns>A list of Grant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Grant> GetByGrantDecision(int _grantDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantDecision(_grantDecision, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Grant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Grant> GetByGrantDecision(int _grantDecision, Db db)
        {
            return db.GrantGetByGrantDecision(_grantDecision);
        }

        /// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
        /// <returns>Gets an instance of Grant or null.</returns>
        public static Grant GetByGrantDecisionFirstOrNull(int _grantDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantDecisionFirstOrNull(_grantDecision, db);
        }

        /// <summary>
		/// Gets rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Grant or null.</returns>
        public static Grant GetByGrantDecisionFirstOrNull(int _grantDecision, Db db)
        {
            return db.GrantGetByGrantDecisionFirstOrNull(_grantDecision);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
        public static void DeleteByGrantDecision(int _grantDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantDecision(_grantDecision, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantDecision from the dbo.Grant table.
        /// </summary>
		/// <param name="_grantDecision">قرار المنح</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantDecision(int _grantDecision, Db db)
        {
            db.GrantDeleteByGrantDecision(_grantDecision);
        }
        #endregion
    }
    #endregion

    #region GrantDecisionServices
    public static partial class GrantDecisionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantDecision table.
        /// </summary>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantDecision table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> List(Db db)
        {
            return db.GrantDecisionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision Get(int _id, Db db)
        {
            return db.GrantDecisionGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDecision to be inserted.</param>
        /// <returns>The inserted GrantDecision</returns>
        public static GrantDecision Insert(GrantDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDecision to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantDecision</returns>
        public static GrantDecision Insert(GrantDecision instance, Db db)
        {
            return db.GrantDecisionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantDecision instance, Db db)
        {
            db.GrantDecisionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantDecision] table.
        /// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantDecision] table.
        /// </summary>
		/// <param name="_id">معرف قرار الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.GrantDecisionDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> GetByGrantTypeGroup(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeGroup(_grantTypeGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> GetByGrantTypeGroup(byte _grantTypeGroup, Db db)
        {
            return db.GrantDecisionGetByGrantTypeGroup(_grantTypeGroup);
        }

        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision GetByGrantTypeGroupFirstOrNull(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeGroupFirstOrNull(_grantTypeGroup, db);
        }

        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision GetByGrantTypeGroupFirstOrNull(byte _grantTypeGroup, Db db)
        {
            return db.GrantDecisionGetByGrantTypeGroupFirstOrNull(_grantTypeGroup);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> GetByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_Year(_number, _year, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDecision> GetByNumber_Year(short _number, short _year, Db db)
        {
            return db.GrantDecisionGetByNumber_Year(_number, _year);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision GetByNumber_YearFirstOrNull(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_YearFirstOrNull(_number, _year, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantDecision or null.</returns>
        public static GrantDecision GetByNumber_YearFirstOrNull(short _number, short _year, Db db)
        {
            return db.GrantDecisionGetByNumber_YearFirstOrNull(_number, _year);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
        public static void DeleteByGrantTypeGroup(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantTypeGroup(_grantTypeGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantDecision table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع القرارات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantTypeGroup(byte _grantTypeGroup, Db db)
        {
            db.GrantDecisionDeleteByGrantTypeGroup(_grantTypeGroup);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        public static void DeleteByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByNumber_Year(_number, _year, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByNumber_Year(short _number, short _year, Db db)
        {
            db.GrantDecisionDeleteByNumber_Year(_number, _year);
        }
        #endregion
    }
    #endregion

    #region GrantDeductionServices
    public static partial class GrantDeductionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantDeduction table.
        /// </summary>
        /// <returns>A list of GrantDeduction instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDeduction> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantDeduction table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantDeduction instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantDeduction> List(Db db)
        {
            return db.GrantDeductionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantDeduction table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
        /// <returns>Gets an instance of GrantDeduction or null.</returns>
        public static GrantDeduction Get(int _grant)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_grant, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantDeduction table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantDeduction or null.</returns>
        public static GrantDeduction Get(int _grant, Db db)
        {
            return db.GrantDeductionGet(_grant);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDeduction to be inserted.</param>
        /// <returns>The inserted GrantDeduction</returns>
        public static GrantDeduction Insert(GrantDeduction instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDeduction to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantDeduction</returns>
        public static GrantDeduction Insert(GrantDeduction instance, Db db)
        {
            return db.GrantDeductionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantDeduction instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantDeduction instance, Db db)
        {
            db.GrantDeductionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantDeduction] table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
        public static void Delete(int _grant)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_grant, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantDeduction] table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _grant, Db db)
        {
            db.GrantDeductionDelete(_grant);
        }
        #endregion
    }
    #endregion

    #region GrantPaymentServices
    public static partial class GrantPaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantPayment table.
        /// </summary>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantPayment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> List(Db db)
        {
            return db.GrantPaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment Get(int _id, Db db)
        {
            return db.GrantPaymentGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPayment to be inserted.</param>
        /// <returns>The inserted GrantPayment</returns>
        public static GrantPayment Insert(GrantPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPayment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantPayment</returns>
        public static GrantPayment Insert(GrantPayment instance, Db db)
        {
            return db.GrantPaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantPayment instance, Db db)
        {
            db.GrantPaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantPayment] table.
        /// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantPayment] table.
        /// </summary>
		/// <param name="_id">معرف دفع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.GrantPaymentDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrant(int _grant)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrant(_grant, db);
        }
    
        /// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrant(int _grant, Db db)
        {
            return db.GrantPaymentGetByGrant(_grant);
        }

        /// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantFirstOrNull(int _grant)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantFirstOrNull(_grant, db);
        }

        /// <summary>
		/// Gets rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantFirstOrNull(int _grant, Db db)
        {
            return db.GrantPaymentGetByGrantFirstOrNull(_grant);
        }           

        /// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrantPaymentOrder(int _grantPaymentOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantPaymentOrder(_grantPaymentOrder, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrantPaymentOrder(int _grantPaymentOrder, Db db)
        {
            return db.GrantPaymentGetByGrantPaymentOrder(_grantPaymentOrder);
        }

        /// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantPaymentOrderFirstOrNull(int _grantPaymentOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantPaymentOrderFirstOrNull(_grantPaymentOrder, db);
        }

        /// <summary>
		/// Gets rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantPaymentOrderFirstOrNull(int _grantPaymentOrder, Db db)
        {
            return db.GrantPaymentGetByGrantPaymentOrderFirstOrNull(_grantPaymentOrder);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrantPaymentOrder_SubNumber(int _grantPaymentOrder, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPayment> GetByGrantPaymentOrder_SubNumber(int _grantPaymentOrder, byte _subNumber, Db db)
        {
            return db.GrantPaymentGetByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber);
        }

        /// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantPaymentOrder_SubNumberFirstOrNull(int _grantPaymentOrder, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantPaymentOrder_SubNumberFirstOrNull(_grantPaymentOrder, _subNumber, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (GrantPaymentOrder, SubNumber) columns  in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPayment or null.</returns>
        public static GrantPayment GetByGrantPaymentOrder_SubNumberFirstOrNull(int _grantPaymentOrder, byte _subNumber, Db db)
        {
            return db.GrantPaymentGetByGrantPaymentOrder_SubNumberFirstOrNull(_grantPaymentOrder, _subNumber);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
        public static void DeleteByGrant(int _grant)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrant(_grant, db);
        }

        /// <summary>
		/// Deletes rows related to one Grant from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grant">معرف الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrant(int _grant, Db db)
        {
            db.GrantPaymentDeleteByGrant(_grant);
        }

        /// <summary>
		/// Deletes rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
        public static void DeleteByGrantPaymentOrder(int _grantPaymentOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantPaymentOrder(_grantPaymentOrder, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantPaymentOrder from the dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantPaymentOrder(int _grantPaymentOrder, Db db)
        {
            db.GrantPaymentDeleteByGrantPaymentOrder(_grantPaymentOrder);
        }

        /// <summary>
		/// Deletes rows related to one combination of GrantPaymentOrder, SubNumber columns in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
        public static void DeleteByGrantPaymentOrder_SubNumber(int _grantPaymentOrder, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of GrantPaymentOrder, SubNumber columns in the  dbo.GrantPayment table.
        /// </summary>
		/// <param name="_grantPaymentOrder">رقم مستند الدفع</param>
		/// <param name="_subNumber">الرقم المتسلسل للدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantPaymentOrder_SubNumber(int _grantPaymentOrder, byte _subNumber, Db db)
        {
            db.GrantPaymentDeleteByGrantPaymentOrder_SubNumber(_grantPaymentOrder, _subNumber);
        }
        #endregion
    }
    #endregion

    #region GrantPaymentOrderServices
    public static partial class GrantPaymentOrderServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrder table.
        /// </summary>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantPaymentOrder table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> List(Db db)
        {
            return db.GrantPaymentOrderList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder Get(int _id, Db db)
        {
            return db.GrantPaymentOrderGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPaymentOrder to be inserted.</param>
        /// <returns>The inserted GrantPaymentOrder</returns>
        public static GrantPaymentOrder Insert(GrantPaymentOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPaymentOrder to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantPaymentOrder</returns>
        public static GrantPaymentOrder Insert(GrantPaymentOrder instance, Db db)
        {
            return db.GrantPaymentOrderInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantPaymentOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantPaymentOrder instance, Db db)
        {
            db.GrantPaymentOrderUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantPaymentOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantPaymentOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.GrantPaymentOrderDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> GetByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> GetByDate(DateTime _date, Db db)
        {
            return db.GrantPaymentOrderGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder GetByDateFirstOrNull(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder GetByDateFirstOrNull(DateTime _date, Db db)
        {
            return db.GrantPaymentOrderGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> GetByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_Year(_number, _year, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantPaymentOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantPaymentOrder> GetByNumber_Year(short _number, short _year, Db db)
        {
            return db.GrantPaymentOrderGetByNumber_Year(_number, _year);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder GetByNumber_YearFirstOrNull(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_YearFirstOrNull(_number, _year, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantPaymentOrder or null.</returns>
        public static GrantPaymentOrder GetByNumber_YearFirstOrNull(short _number, short _year, Db db)
        {
            return db.GrantPaymentOrderGetByNumber_YearFirstOrNull(_number, _year);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
        public static void DeleteByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_date">تاريخ مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(DateTime _date, Db db)
        {
            db.GrantPaymentOrderDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
        public static void DeleteByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByNumber_Year(_number, _year, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.GrantPaymentOrder table.
        /// </summary>
		/// <param name="_number">رقم مستند الدفع</param>
		/// <param name="_year">عام مستند الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByNumber_Year(short _number, short _year, Db db)
        {
            db.GrantPaymentOrderDeleteByNumber_Year(_number, _year);
        }
        #endregion
    }
    #endregion

    #region GrantRequestServices
    public static partial class GrantRequestServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantRequest table.
        /// </summary>
        /// <returns>A list of GrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantRequest> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantRequest table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantRequest> List(Db db)
        {
            return db.GrantRequestList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
        /// <returns>Gets an instance of GrantRequest or null.</returns>
        public static GrantRequest Get(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_request, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantRequest or null.</returns>
        public static GrantRequest Get(int _request, Db db)
        {
            return db.GrantRequestGet(_request);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of GrantRequest to be inserted.</param>
        /// <returns>The inserted GrantRequest</returns>
        public static GrantRequest Insert(GrantRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of GrantRequest to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantRequest</returns>
        public static GrantRequest Insert(GrantRequest instance, Db db)
        {
            return db.GrantRequestInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantRequest instance, Db db)
        {
            db.GrantRequestUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantRequest] table.
        /// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
        public static void Delete(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_request, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantRequest] table.
        /// </summary>
		/// <param name="_request">معرف طلب الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _request, Db db)
        {
            db.GrantRequestDelete(_request);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        /// <returns>A list of GrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantRequest> GetByGrantType(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantType(_grantType, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantRequest> GetByGrantType(byte _grantType, Db db)
        {
            return db.GrantRequestGetByGrantType(_grantType);
        }

        /// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        /// <returns>Gets an instance of GrantRequest or null.</returns>
        public static GrantRequest GetByGrantTypeFirstOrNull(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeFirstOrNull(_grantType, db);
        }

        /// <summary>
		/// Gets rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantRequest or null.</returns>
        public static GrantRequest GetByGrantTypeFirstOrNull(byte _grantType, Db db)
        {
            return db.GrantRequestGetByGrantTypeFirstOrNull(_grantType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
        public static void DeleteByGrantType(byte _grantType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantType(_grantType, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantType from the dbo.GrantRequest table.
        /// </summary>
		/// <param name="_grantType">نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantType(byte _grantType, Db db)
        {
            db.GrantRequestDeleteByGrantType(_grantType);
        }
        #endregion
    }
    #endregion

    #region GrantTypeServices
    public static partial class GrantTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantType table.
        /// </summary>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> List(Db db)
        {
            return db.GrantTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantType table.
        /// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantType table.
        /// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType Get(byte _id, Db db)
        {
            return db.GrantTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="instance">An instance of GrantType to be inserted.</param>
        /// <returns>The inserted GrantType</returns>
        public static GrantType Insert(GrantType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="instance">An instance of GrantType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantType</returns>
        public static GrantType Insert(GrantType instance, Db db)
        {
            return db.GrantTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="instance">An instance of GrantType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="instance">An instance of GrantType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantType instance, Db db)
        {
            db.GrantTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantType] table.
        /// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantType] table.
        /// </summary>
		/// <param name="_id">معرف نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.GrantTypeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> GetByGrantTypeGroup(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeGroup(_grantTypeGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> GetByGrantTypeGroup(byte _grantTypeGroup, Db db)
        {
            return db.GrantTypeGetByGrantTypeGroup(_grantTypeGroup);
        }

        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType GetByGrantTypeGroupFirstOrNull(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGrantTypeGroupFirstOrNull(_grantTypeGroup, db);
        }

        /// <summary>
		/// Gets rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType GetByGrantTypeGroupFirstOrNull(byte _grantTypeGroup, Db db)
        {
            return db.GrantTypeGetByGrantTypeGroupFirstOrNull(_grantTypeGroup);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantType> GetByName(string _name, Db db)
        {
            return db.GrantTypeGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantType or null.</returns>
        public static GrantType GetByNameFirstOrNull(string _name, Db db)
        {
            return db.GrantTypeGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
        public static void DeleteByGrantTypeGroup(byte _grantTypeGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGrantTypeGroup(_grantTypeGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one GrantTypeGroup from the dbo.GrantType table.
        /// </summary>
		/// <param name="_grantTypeGroup">مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGrantTypeGroup(byte _grantTypeGroup, Db db)
        {
            db.GrantTypeDeleteByGrantTypeGroup(_grantTypeGroup);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantType table.
        /// </summary>
		/// <param name="_name">بيان نوع الإعانة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.GrantTypeDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region GrantTypeGroupServices
    public static partial class GrantTypeGroupServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GrantTypeGroup table.
        /// </summary>
        /// <returns>A list of GrantTypeGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantTypeGroup> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GrantTypeGroup table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantTypeGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantTypeGroup> List(Db db)
        {
            return db.GrantTypeGroupList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
        /// <returns>Gets an instance of GrantTypeGroup or null.</returns>
        public static GrantTypeGroup Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantTypeGroup or null.</returns>
        public static GrantTypeGroup Get(byte _id, Db db)
        {
            return db.GrantTypeGroupGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="instance">An instance of GrantTypeGroup to be inserted.</param>
        /// <returns>The inserted GrantTypeGroup</returns>
        public static GrantTypeGroup Insert(GrantTypeGroup instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="instance">An instance of GrantTypeGroup to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GrantTypeGroup</returns>
        public static GrantTypeGroup Insert(GrantTypeGroup instance, Db db)
        {
            return db.GrantTypeGroupInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GrantTypeGroup instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GrantTypeGroup instance, Db db)
        {
            db.GrantTypeGroupUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantTypeGroup] table.
        /// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantTypeGroup] table.
        /// </summary>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.GrantTypeGroupDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
        /// <returns>A list of GrantTypeGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantTypeGroup> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GrantTypeGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GrantTypeGroup> GetByName(string _name, Db db)
        {
            return db.GrantTypeGroupGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
        /// <returns>Gets an instance of GrantTypeGroup or null.</returns>
        public static GrantTypeGroup GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GrantTypeGroup or null.</returns>
        public static GrantTypeGroup GetByNameFirstOrNull(string _name, Db db)
        {
            return db.GrantTypeGroupGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GrantTypeGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة أنواع الإعانات</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.GrantTypeGroupDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region GuarantorServices
    public static partial class GuarantorServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Guarantor table.
        /// </summary>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Guarantor table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> List(Db db)
        {
            return db.GuarantorList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_id">معرف الكفيل</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor Get(int _id, Db db)
        {
            return db.GuarantorGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="instance">An instance of Guarantor to be inserted.</param>
        /// <returns>The inserted Guarantor</returns>
        public static Guarantor Insert(Guarantor instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="instance">An instance of Guarantor to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Guarantor</returns>
        public static Guarantor Insert(Guarantor instance, Db db)
        {
            return db.GuarantorInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="instance">An instance of Guarantor which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Guarantor instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="instance">An instance of Guarantor which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Guarantor instance, Db db)
        {
            db.GuarantorUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Guarantor] table.
        /// </summary>
		/// <param name="_id">معرف الكفيل</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Guarantor] table.
        /// </summary>
		/// <param name="_id">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.GuarantorDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByEmployee(int _employee, Db db)
        {
            return db.GuarantorGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.GuarantorGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByGuarantorStatus(byte _guarantorStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGuarantorStatus(_guarantorStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByGuarantorStatus(byte _guarantorStatus, Db db)
        {
            return db.GuarantorGetByGuarantorStatus(_guarantorStatus);
        }

        /// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByGuarantorStatusFirstOrNull(byte _guarantorStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByGuarantorStatusFirstOrNull(_guarantorStatus, db);
        }

        /// <summary>
		/// Gets rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByGuarantorStatusFirstOrNull(byte _guarantorStatus, Db db)
        {
            return db.GuarantorGetByGuarantorStatusFirstOrNull(_guarantorStatus);
        }           

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByRefundableProduct(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct(_refundableProduct, db);
        }
    
        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByRefundableProduct(int _refundableProduct, Db db)
        {
            return db.GuarantorGetByRefundableProduct(_refundableProduct);
        }

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByRefundableProductFirstOrNull(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProductFirstOrNull(_refundableProduct, db);
        }

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByRefundableProductFirstOrNull(int _refundableProduct, Db db)
        {
            return db.GuarantorGetByRefundableProductFirstOrNull(_refundableProduct);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByRefundableProduct_SubNumber(int _refundableProduct, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct_SubNumber(_refundableProduct, _subNumber, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Guarantor instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Guarantor> GetByRefundableProduct_SubNumber(int _refundableProduct, byte _subNumber, Db db)
        {
            return db.GuarantorGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
        }

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByRefundableProduct_SubNumberFirstOrNull(int _refundableProduct, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct_SubNumberFirstOrNull(_refundableProduct, _subNumber, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Guarantor or null.</returns>
        public static Guarantor GetByRefundableProduct_SubNumberFirstOrNull(int _refundableProduct, byte _subNumber, Db db)
        {
            return db.GuarantorGetByRefundableProduct_SubNumberFirstOrNull(_refundableProduct, _subNumber);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.GuarantorDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
        public static void DeleteByGuarantorStatus(byte _guarantorStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByGuarantorStatus(_guarantorStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one GuarantorStatus from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_guarantorStatus">حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByGuarantorStatus(byte _guarantorStatus, Db db)
        {
            db.GuarantorDeleteByGuarantorStatus(_guarantorStatus);
        }

        /// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
        public static void DeleteByRefundableProduct(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRefundableProduct(_refundableProduct, db);
        }

        /// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRefundableProduct(int _refundableProduct, Db db)
        {
            db.GuarantorDeleteByRefundableProduct(_refundableProduct);
        }

        /// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
        public static void DeleteByRefundableProduct_SubNumber(int _refundableProduct, byte _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Guarantor table.
        /// </summary>
		/// <param name="_refundableProduct">المنتج</param>
		/// <param name="_subNumber">مسلسل فرعي للكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRefundableProduct_SubNumber(int _refundableProduct, byte _subNumber, Db db)
        {
            db.GuarantorDeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
        }
        #endregion
    }
    #endregion

    #region GuarantorStatementServices
    public static partial class GuarantorStatementServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatement table.
        /// </summary>
        /// <returns>A list of GuarantorStatement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatement> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatement table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GuarantorStatement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatement> List(Db db)
        {
            return db.GuarantorStatementList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatement table.
        /// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
        /// <returns>Gets an instance of GuarantorStatement or null.</returns>
        public static GuarantorStatement Get(int _guarantor)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_guarantor, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatement table.
        /// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GuarantorStatement or null.</returns>
        public static GuarantorStatement Get(int _guarantor, Db db)
        {
            return db.GuarantorStatementGet(_guarantor);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatement to be inserted.</param>
        /// <returns>The inserted GuarantorStatement</returns>
        public static GuarantorStatement Insert(GuarantorStatement instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatement to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GuarantorStatement</returns>
        public static GuarantorStatement Insert(GuarantorStatement instance, Db db)
        {
            return db.GuarantorStatementInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GuarantorStatement instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GuarantorStatement instance, Db db)
        {
            db.GuarantorStatementUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatement] table.
        /// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
        public static void Delete(int _guarantor)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_guarantor, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatement] table.
        /// </summary>
		/// <param name="_guarantor">معرف الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _guarantor, Db db)
        {
            db.GuarantorStatementDelete(_guarantor);
        }
        #endregion
    }
    #endregion

    #region GuarantorStatusServices
    public static partial class GuarantorStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatus table.
        /// </summary>
        /// <returns>A list of GuarantorStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.GuarantorStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GuarantorStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatus> List(Db db)
        {
            return db.GuarantorStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
        /// <returns>Gets an instance of GuarantorStatus or null.</returns>
        public static GuarantorStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GuarantorStatus or null.</returns>
        public static GuarantorStatus Get(byte _id, Db db)
        {
            return db.GuarantorStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatus to be inserted.</param>
        /// <returns>The inserted GuarantorStatus</returns>
        public static GuarantorStatus Insert(GuarantorStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted GuarantorStatus</returns>
        public static GuarantorStatus Insert(GuarantorStatus instance, Db db)
        {
            return db.GuarantorStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(GuarantorStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(GuarantorStatus instance, Db db)
        {
            db.GuarantorStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.GuarantorStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
        /// <returns>A list of GuarantorStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of GuarantorStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<GuarantorStatus> GetByName(string _name, Db db)
        {
            return db.GuarantorStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
        /// <returns>Gets an instance of GuarantorStatus or null.</returns>
        public static GuarantorStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of GuarantorStatus or null.</returns>
        public static GuarantorStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.GuarantorStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.GuarantorStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة الكفيل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.GuarantorStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region HealthLoanDecisionServices
    public static partial class HealthLoanDecisionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecision table.
        /// </summary>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecision table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> List(Db db)
        {
            return db.HealthLoanDecisionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_id">معرف القرار</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision Get(int _id, Db db)
        {
            return db.HealthLoanDecisionGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecision to be inserted.</param>
        /// <returns>The inserted HealthLoanDecision</returns>
        public static HealthLoanDecision Insert(HealthLoanDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecision to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted HealthLoanDecision</returns>
        public static HealthLoanDecision Insert(HealthLoanDecision instance, Db db)
        {
            return db.HealthLoanDecisionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(HealthLoanDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(HealthLoanDecision instance, Db db)
        {
            db.HealthLoanDecisionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecision] table.
        /// </summary>
		/// <param name="_id">معرف القرار</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecision] table.
        /// </summary>
		/// <param name="_id">معرف القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.HealthLoanDecisionDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> GetByDate(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> GetByDate(Nullable<DateTime> _date, Db db)
        {
            return db.HealthLoanDecisionGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision GetByDateFirstOrNull(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision GetByDateFirstOrNull(Nullable<DateTime> _date, Db db)
        {
            return db.HealthLoanDecisionGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> GetByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_Year(_number, _year, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecision> GetByNumber_Year(short _number, short _year, Db db)
        {
            return db.HealthLoanDecisionGetByNumber_Year(_number, _year);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision GetByNumber_YearFirstOrNull(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_YearFirstOrNull(_number, _year, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecision or null.</returns>
        public static HealthLoanDecision GetByNumber_YearFirstOrNull(short _number, short _year, Db db)
        {
            return db.HealthLoanDecisionGetByNumber_YearFirstOrNull(_number, _year);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
        public static void DeleteByDate(Nullable<DateTime> _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_date">تاريخ القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(Nullable<DateTime> _date, Db db)
        {
            db.HealthLoanDecisionDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
        public static void DeleteByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByNumber_Year(_number, _year, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.HealthLoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">عام القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByNumber_Year(short _number, short _year, Db db)
        {
            db.HealthLoanDecisionDeleteByNumber_Year(_number, _year);
        }
        #endregion
    }
    #endregion

    #region HealthLoanDecisionFirstPaymentServices
    public static partial class HealthLoanDecisionFirstPaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> List(Db db)
        {
            return db.HealthLoanDecisionFirstPaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment Get(int _id, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment to be inserted.</param>
        /// <returns>The inserted HealthLoanDecisionFirstPayment</returns>
        public static HealthLoanDecisionFirstPayment Insert(HealthLoanDecisionFirstPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted HealthLoanDecisionFirstPayment</returns>
        public static HealthLoanDecisionFirstPayment Insert(HealthLoanDecisionFirstPayment instance, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(HealthLoanDecisionFirstPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(HealthLoanDecisionFirstPayment instance, Db db)
        {
            db.HealthLoanDecisionFirstPaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByDepartment(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartment(_department, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByDepartment(Nullable<int> _department, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByDepartment(_department);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByDepartmentFirstOrNull(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartmentFirstOrNull(_department, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByDepartmentFirstOrNull(Nullable<int> _department, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByDepartmentFirstOrNull(_department);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByEmployee(int _employee, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByEmployee_PaymentDate(int _employee, DateTime _paymentDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_PaymentDate(_employee, _paymentDate, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByEmployee_PaymentDate(int _employee, DateTime _paymentDate, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDate(_employee, _paymentDate);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByEmployee_PaymentDateFirstOrNull(int _employee, DateTime _paymentDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_PaymentDateFirstOrNull(_employee, _paymentDate, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentDate) columns  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByEmployee_PaymentDateFirstOrNull(int _employee, DateTime _paymentDate, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByEmployee_PaymentDateFirstOrNull(_employee, _paymentDate);
        }           

        /// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByHealthLoanDecision(Nullable<int> _healthLoanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByHealthLoanDecision(_healthLoanDecision, db);
        }
    
        /// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByHealthLoanDecision(Nullable<int> _healthLoanDecision, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByHealthLoanDecision(_healthLoanDecision);
        }

        /// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByHealthLoanDecisionFirstOrNull(Nullable<int> _healthLoanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByHealthLoanDecisionFirstOrNull(_healthLoanDecision, db);
        }

        /// <summary>
		/// Gets rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByHealthLoanDecisionFirstOrNull(Nullable<int> _healthLoanDecision, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByHealthLoanDecisionFirstOrNull(_healthLoanDecision);
        }           

        /// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByInsuranceType(Nullable<byte> _insuranceType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInsuranceType(_insuranceType, db);
        }
    
        /// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByInsuranceType(Nullable<byte> _insuranceType, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByInsuranceType(_insuranceType);
        }

        /// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByInsuranceTypeFirstOrNull(Nullable<byte> _insuranceType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInsuranceTypeFirstOrNull(_insuranceType, db);
        }

        /// <summary>
		/// Gets rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByInsuranceTypeFirstOrNull(Nullable<byte> _insuranceType, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByInsuranceTypeFirstOrNull(_insuranceType);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByLoanRequest(Nullable<int> _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanRequest(_loanRequest, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByLoanRequest(Nullable<int> _loanRequest, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByLoanRequest(_loanRequest);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByLoanRequestFirstOrNull(Nullable<int> _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanRequestFirstOrNull(_loanRequest, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByLoanRequestFirstOrNull(Nullable<int> _loanRequest, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByLoanRequestFirstOrNull(_loanRequest);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByPaymentStatus(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentStatus(_paymentStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of HealthLoanDecisionFirstPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<HealthLoanDecisionFirstPayment> GetByPaymentStatus(Nullable<byte> _paymentStatus, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByPaymentStatus(_paymentStatus);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByPaymentStatusFirstOrNull(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentStatusFirstOrNull(_paymentStatus, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of HealthLoanDecisionFirstPayment or null.</returns>
        public static HealthLoanDecisionFirstPayment GetByPaymentStatusFirstOrNull(Nullable<byte> _paymentStatus, Db db)
        {
            return db.HealthLoanDecisionFirstPaymentGetByPaymentStatusFirstOrNull(_paymentStatus);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
        public static void DeleteByDepartment(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDepartment(_department, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Department columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_department">مكان العمل</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDepartment(Nullable<int> _department, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByDepartment(_department);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, PaymentDate columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
        public static void DeleteByEmployee_PaymentDate(int _employee, DateTime _paymentDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee_PaymentDate(_employee, _paymentDate, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, PaymentDate columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentDate">تاريخ الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee_PaymentDate(int _employee, DateTime _paymentDate, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByEmployee_PaymentDate(_employee, _paymentDate);
        }

        /// <summary>
		/// Deletes rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
        public static void DeleteByHealthLoanDecision(Nullable<int> _healthLoanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByHealthLoanDecision(_healthLoanDecision, db);
        }

        /// <summary>
		/// Deletes rows related to one HealthLoanDecision from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_healthLoanDecision">رقم قرار التسليف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByHealthLoanDecision(Nullable<int> _healthLoanDecision, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByHealthLoanDecision(_healthLoanDecision);
        }

        /// <summary>
		/// Deletes rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
        public static void DeleteByInsuranceType(Nullable<byte> _insuranceType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByInsuranceType(_insuranceType, db);
        }

        /// <summary>
		/// Deletes rows related to one InsuranceType from the dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_insuranceType">معرف طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByInsuranceType(Nullable<byte> _insuranceType, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByInsuranceType(_insuranceType);
        }

        /// <summary>
		/// Deletes rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
        public static void DeleteByLoanRequest(Nullable<int> _loanRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanRequest(_loanRequest, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of LoanRequest columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_loanRequest">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanRequest(Nullable<int> _loanRequest, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByLoanRequest(_loanRequest);
        }

        /// <summary>
		/// Deletes rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
        public static void DeleteByPaymentStatus(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentStatus(_paymentStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of PaymentStatus columns in the  dbo.HealthLoanDecisionFirstPayment table.
        /// </summary>
		/// <param name="_paymentStatus">الحالة non:0; checked:1; chgd2%:2; chgd14%:3; Refunded:4</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentStatus(Nullable<byte> _paymentStatus, Db db)
        {
            db.HealthLoanDecisionFirstPaymentDeleteByPaymentStatus(_paymentStatus);
        }
        #endregion
    }
    #endregion

    #region IncomingLoanServices
    public static partial class IncomingLoanServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.IncomingLoan table.
        /// </summary>
        /// <returns>A list of IncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<IncomingLoan> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.IncomingLoan table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of IncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<IncomingLoan> List(Db db)
        {
            return db.IncomingLoanList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <returns>Gets an instance of IncomingLoan or null.</returns>
        public static IncomingLoan Get(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_loan, db);
        }

        /// <summary>
		/// Gets one row from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of IncomingLoan or null.</returns>
        public static IncomingLoan Get(int _loan, Db db)
        {
            return db.IncomingLoanGet(_loan);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of IncomingLoan to be inserted.</param>
        /// <returns>The inserted IncomingLoan</returns>
        public static IncomingLoan Insert(IncomingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of IncomingLoan to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted IncomingLoan</returns>
        public static IncomingLoan Insert(IncomingLoan instance, Db db)
        {
            return db.IncomingLoanInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(IncomingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(IncomingLoan instance, Db db)
        {
            db.IncomingLoanUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[IncomingLoan] table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        public static void Delete(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_loan, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[IncomingLoan] table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _loan, Db db)
        {
            db.IncomingLoanDelete(_loan);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        /// <returns>A list of IncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<IncomingLoan> GetByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlace(_mainWorkPlace, db);
        }
    
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of IncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<IncomingLoan> GetByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            return db.IncomingLoanGetByMainWorkPlace(_mainWorkPlace);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        /// <returns>Gets an instance of IncomingLoan or null.</returns>
        public static IncomingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlaceFirstOrNull(_mainWorkPlace, db);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of IncomingLoan or null.</returns>
        public static IncomingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace, Db db)
        {
            return db.IncomingLoanGetByMainWorkPlaceFirstOrNull(_mainWorkPlace);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMainWorkPlace(_mainWorkPlace, db);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.IncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            db.IncomingLoanDeleteByMainWorkPlace(_mainWorkPlace);
        }
        #endregion
    }
    #endregion

    #region InstallmentServices
    public static partial class InstallmentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Installment table.
        /// </summary>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Installment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> List(Db db)
        {
            return db.InstallmentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Installment table.
        /// </summary>
		/// <param name="_id">معرف القسط</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Installment table.
        /// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment Get(int _id, Db db)
        {
            return db.InstallmentGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Installment] table.
        /// </summary>
        /// <param name="instance">An instance of Installment to be inserted.</param>
        /// <returns>The inserted Installment</returns>
        public static Installment Insert(Installment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Installment] table.
        /// </summary>
        /// <param name="instance">An instance of Installment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Installment</returns>
        public static Installment Insert(Installment instance, Db db)
        {
            return db.InstallmentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Installment] table.
        /// </summary>
        /// <param name="instance">An instance of Installment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Installment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Installment] table.
        /// </summary>
        /// <param name="instance">An instance of Installment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Installment instance, Db db)
        {
            db.InstallmentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Installment] table.
        /// </summary>
		/// <param name="_id">معرف القسط</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Installment] table.
        /// </summary>
		/// <param name="_id">معرف القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.InstallmentDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByDueDate(DateTime _dueDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDueDate(_dueDate, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByDueDate(DateTime _dueDate, Db db)
        {
            return db.InstallmentGetByDueDate(_dueDate);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByDueDateFirstOrNull(DateTime _dueDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDueDateFirstOrNull(_dueDate, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByDueDateFirstOrNull(DateTime _dueDate, Db db)
        {
            return db.InstallmentGetByDueDateFirstOrNull(_dueDate);
        }           

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByRefundableProduct(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct(_refundableProduct, db);
        }
    
        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByRefundableProduct(int _refundableProduct, Db db)
        {
            return db.InstallmentGetByRefundableProduct(_refundableProduct);
        }

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByRefundableProductFirstOrNull(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProductFirstOrNull(_refundableProduct, db);
        }

        /// <summary>
		/// Gets rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByRefundableProductFirstOrNull(int _refundableProduct, Db db)
        {
            return db.InstallmentGetByRefundableProductFirstOrNull(_refundableProduct);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByRefundableProduct_SubNumber(int _refundableProduct, short _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct_SubNumber(_refundableProduct, _subNumber, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Installment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Installment> GetByRefundableProduct_SubNumber(int _refundableProduct, short _subNumber, Db db)
        {
            return db.InstallmentGetByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
        }

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByRefundableProduct_SubNumberFirstOrNull(int _refundableProduct, short _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRefundableProduct_SubNumberFirstOrNull(_refundableProduct, _subNumber, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (RefundableProduct, SubNumber) columns  in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Installment or null.</returns>
        public static Installment GetByRefundableProduct_SubNumberFirstOrNull(int _refundableProduct, short _subNumber, Db db)
        {
            return db.InstallmentGetByRefundableProduct_SubNumberFirstOrNull(_refundableProduct, _subNumber);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of DueDate columns in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
        public static void DeleteByDueDate(DateTime _dueDate)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDueDate(_dueDate, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of DueDate columns in the  dbo.Installment table.
        /// </summary>
		/// <param name="_dueDate">تاريخ الاستحقاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDueDate(DateTime _dueDate, Db db)
        {
            db.InstallmentDeleteByDueDate(_dueDate);
        }

        /// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
        public static void DeleteByRefundableProduct(int _refundableProduct)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRefundableProduct(_refundableProduct, db);
        }

        /// <summary>
		/// Deletes rows related to one RefundableProduct from the dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRefundableProduct(int _refundableProduct, Db db)
        {
            db.InstallmentDeleteByRefundableProduct(_refundableProduct);
        }

        /// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
        public static void DeleteByRefundableProduct_SubNumber(int _refundableProduct, short _subNumber)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of RefundableProduct, SubNumber columns in the  dbo.Installment table.
        /// </summary>
		/// <param name="_refundableProduct">معرف المنتج</param>
		/// <param name="_subNumber">مسلسل القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRefundableProduct_SubNumber(int _refundableProduct, short _subNumber, Db db)
        {
            db.InstallmentDeleteByRefundableProduct_SubNumber(_refundableProduct, _subNumber);
        }
        #endregion
    }
    #endregion

    #region InstallmentDecreaseServices
    public static partial class InstallmentDecreaseServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecrease table.
        /// </summary>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecrease table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> List(Db db)
        {
            return db.InstallmentDecreaseList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease Get(int _id, Db db)
        {
            return db.InstallmentDecreaseGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecrease to be inserted.</param>
        /// <returns>The inserted InstallmentDecrease</returns>
        public static InstallmentDecrease Insert(InstallmentDecrease instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecrease to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted InstallmentDecrease</returns>
        public static InstallmentDecrease Insert(InstallmentDecrease instance, Db db)
        {
            return db.InstallmentDecreaseInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(InstallmentDecrease instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(InstallmentDecrease instance, Db db)
        {
            db.InstallmentDecreaseUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecrease] table.
        /// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecrease] table.
        /// </summary>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.InstallmentDecreaseDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByDepartment(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartment(_department, db);
        }
    
        /// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByDepartment(Nullable<int> _department, Db db)
        {
            return db.InstallmentDecreaseGetByDepartment(_department);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByDepartmentFirstOrNull(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartmentFirstOrNull(_department, db);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByDepartmentFirstOrNull(Nullable<int> _department, Db db)
        {
            return db.InstallmentDecreaseGetByDepartmentFirstOrNull(_department);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByEmployee(int _employee, Db db)
        {
            return db.InstallmentDecreaseGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.InstallmentDecreaseGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByInstallmentDecreaseOrder(int _installmentDecreaseOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallmentDecreaseOrder(_installmentDecreaseOrder, db);
        }
    
        /// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByInstallmentDecreaseOrder(int _installmentDecreaseOrder, Db db)
        {
            return db.InstallmentDecreaseGetByInstallmentDecreaseOrder(_installmentDecreaseOrder);
        }

        /// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByInstallmentDecreaseOrderFirstOrNull(int _installmentDecreaseOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallmentDecreaseOrderFirstOrNull(_installmentDecreaseOrder, db);
        }

        /// <summary>
		/// Gets rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByInstallmentDecreaseOrderFirstOrNull(int _installmentDecreaseOrder, Db db)
        {
            return db.InstallmentDecreaseGetByInstallmentDecreaseOrderFirstOrNull(_installmentDecreaseOrder);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByInstallmentDecreaseOrder_Employee(int _installmentDecreaseOrder, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecrease> GetByInstallmentDecreaseOrder_Employee(int _installmentDecreaseOrder, int _employee, Db db)
        {
            return db.InstallmentDecreaseGetByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee);
        }

        /// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByInstallmentDecreaseOrder_EmployeeFirstOrNull(int _installmentDecreaseOrder, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallmentDecreaseOrder_EmployeeFirstOrNull(_installmentDecreaseOrder, _employee, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (InstallmentDecreaseOrder, Employee) columns  in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecrease or null.</returns>
        public static InstallmentDecrease GetByInstallmentDecreaseOrder_EmployeeFirstOrNull(int _installmentDecreaseOrder, int _employee, Db db)
        {
            return db.InstallmentDecreaseGetByInstallmentDecreaseOrder_EmployeeFirstOrNull(_installmentDecreaseOrder, _employee);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        public static void DeleteByDepartment(Nullable<int> _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDepartment(_department, db);
        }

        /// <summary>
		/// Deletes rows related to one Department from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDepartment(Nullable<int> _department, Db db)
        {
            db.InstallmentDecreaseDeleteByDepartment(_department);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.InstallmentDecreaseDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
        public static void DeleteByInstallmentDecreaseOrder(int _installmentDecreaseOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByInstallmentDecreaseOrder(_installmentDecreaseOrder, db);
        }

        /// <summary>
		/// Deletes rows related to one InstallmentDecreaseOrder from the dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByInstallmentDecreaseOrder(int _installmentDecreaseOrder, Db db)
        {
            db.InstallmentDecreaseDeleteByInstallmentDecreaseOrder(_installmentDecreaseOrder);
        }

        /// <summary>
		/// Deletes rows related to one combination of InstallmentDecreaseOrder, Employee columns in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByInstallmentDecreaseOrder_Employee(int _installmentDecreaseOrder, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of InstallmentDecreaseOrder, Employee columns in the  dbo.InstallmentDecrease table.
        /// </summary>
		/// <param name="_installmentDecreaseOrder">رقم الكتاب الداخلي</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByInstallmentDecreaseOrder_Employee(int _installmentDecreaseOrder, int _employee, Db db)
        {
            db.InstallmentDecreaseDeleteByInstallmentDecreaseOrder_Employee(_installmentDecreaseOrder, _employee);
        }
        #endregion
    }
    #endregion

    #region InstallmentDecreaseOrderServices
    public static partial class InstallmentDecreaseOrderServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrder table.
        /// </summary>
        /// <returns>A list of InstallmentDecreaseOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecreaseOrder> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.InstallmentDecreaseOrder table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecreaseOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecreaseOrder> List(Db db)
        {
            return db.InstallmentDecreaseOrderList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
        /// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
        public static InstallmentDecreaseOrder Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
        public static InstallmentDecreaseOrder Get(int _id, Db db)
        {
            return db.InstallmentDecreaseOrderGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecreaseOrder to be inserted.</param>
        /// <returns>The inserted InstallmentDecreaseOrder</returns>
        public static InstallmentDecreaseOrder Insert(InstallmentDecreaseOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecreaseOrder to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted InstallmentDecreaseOrder</returns>
        public static InstallmentDecreaseOrder Insert(InstallmentDecreaseOrder instance, Db db)
        {
            return db.InstallmentDecreaseOrderInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(InstallmentDecreaseOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(InstallmentDecreaseOrder instance, Db db)
        {
            db.InstallmentDecreaseOrderUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
		/// <param name="_id">رقم الكتاب الداخلي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.InstallmentDecreaseOrderDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
        /// <returns>A list of InstallmentDecreaseOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecreaseOrder> GetByMonth(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMonth(_month, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InstallmentDecreaseOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InstallmentDecreaseOrder> GetByMonth(DateTime _month, Db db)
        {
            return db.InstallmentDecreaseOrderGetByMonth(_month);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
        /// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
        public static InstallmentDecreaseOrder GetByMonthFirstOrNull(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMonthFirstOrNull(_month, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InstallmentDecreaseOrder or null.</returns>
        public static InstallmentDecreaseOrder GetByMonthFirstOrNull(DateTime _month, Db db)
        {
            return db.InstallmentDecreaseOrderGetByMonthFirstOrNull(_month);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
        public static void DeleteByMonth(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMonth(_month, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.InstallmentDecreaseOrder table.
        /// </summary>
		/// <param name="_month">الشهر الجاري توزيعه عند إنشاء الكتاب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMonth(DateTime _month, Db db)
        {
            db.InstallmentDecreaseOrderDeleteByMonth(_month);
        }
        #endregion
    }
    #endregion

    #region InsuranceTypeServices
    public static partial class InsuranceTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.InsuranceType table.
        /// </summary>
        /// <returns>A list of InsuranceType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InsuranceType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.InsuranceType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InsuranceType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InsuranceType> List(Db db)
        {
            return db.InsuranceTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.InsuranceType table.
        /// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
        /// <returns>Gets an instance of InsuranceType or null.</returns>
        public static InsuranceType Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.InsuranceType table.
        /// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InsuranceType or null.</returns>
        public static InsuranceType Get(byte _id, Db db)
        {
            return db.InsuranceTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="instance">An instance of InsuranceType to be inserted.</param>
        /// <returns>The inserted InsuranceType</returns>
        public static InsuranceType Insert(InsuranceType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="instance">An instance of InsuranceType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted InsuranceType</returns>
        public static InsuranceType Insert(InsuranceType instance, Db db)
        {
            return db.InsuranceTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(InsuranceType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(InsuranceType instance, Db db)
        {
            db.InsuranceTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InsuranceType] table.
        /// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InsuranceType] table.
        /// </summary>
		/// <param name="_id">معرف طريقة القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.InsuranceTypeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
        /// <returns>A list of InsuranceType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InsuranceType> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of InsuranceType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<InsuranceType> GetByName(string _name, Db db)
        {
            return db.InsuranceTypeGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
        /// <returns>Gets an instance of InsuranceType or null.</returns>
        public static InsuranceType GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of InsuranceType or null.</returns>
        public static InsuranceType GetByNameFirstOrNull(string _name, Db db)
        {
            return db.InsuranceTypeGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.InsuranceType table.
        /// </summary>
		/// <param name="_name">بيان طريقة قبض التأمين</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.InsuranceTypeDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region IssuerServices
    public static partial class IssuerServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Issuer table.
        /// </summary>
        /// <returns>A list of Issuer instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Issuer> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Issuer table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Issuer instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Issuer> List(Db db)
        {
            return db.IssuerList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Issuer table.
        /// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
        /// <returns>Gets an instance of Issuer or null.</returns>
        public static Issuer Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Issuer table.
        /// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Issuer or null.</returns>
        public static Issuer Get(byte _id, Db db)
        {
            return db.IssuerGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="instance">An instance of Issuer to be inserted.</param>
        /// <returns>The inserted Issuer</returns>
        public static Issuer Insert(Issuer instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="instance">An instance of Issuer to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Issuer</returns>
        public static Issuer Insert(Issuer instance, Db db)
        {
            return db.IssuerInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="instance">An instance of Issuer which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Issuer instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="instance">An instance of Issuer which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Issuer instance, Db db)
        {
            db.IssuerUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Issuer] table.
        /// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Issuer] table.
        /// </summary>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.IssuerDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
        /// <returns>A list of Issuer instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Issuer> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Issuer instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Issuer> GetByName(string _name, Db db)
        {
            return db.IssuerGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
        /// <returns>Gets an instance of Issuer or null.</returns>
        public static Issuer GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Issuer or null.</returns>
        public static Issuer GetByNameFirstOrNull(string _name, Db db)
        {
            return db.IssuerGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.Issuer table.
        /// </summary>
		/// <param name="_name">بيان الجهة المصدرة للمديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.IssuerDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region LoanServices
    public static partial class LoanServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Loan table.
        /// </summary>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Loan table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> List(Db db)
        {
            return db.LoanList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Loan table.
        /// </summary>
		/// <param name="_product">معرف السلفة</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan Get(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_product, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Loan table.
        /// </summary>
		/// <param name="_product">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan Get(int _product, Db db)
        {
            return db.LoanGet(_product);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Loan] table.
        /// </summary>
        /// <param name="instance">An instance of Loan to be inserted.</param>
        /// <returns>The inserted Loan</returns>
        public static Loan Insert(Loan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Loan] table.
        /// </summary>
        /// <param name="instance">An instance of Loan to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Loan</returns>
        public static Loan Insert(Loan instance, Db db)
        {
            return db.LoanInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Loan] table.
        /// </summary>
        /// <param name="instance">An instance of Loan which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Loan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Loan] table.
        /// </summary>
        /// <param name="instance">An instance of Loan which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Loan instance, Db db)
        {
            db.LoanUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Loan] table.
        /// </summary>
		/// <param name="_product">معرف السلفة</param>
        public static void Delete(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_product, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Loan] table.
        /// </summary>
		/// <param name="_product">معرف السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _product, Db db)
        {
            db.LoanDelete(_product);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanDecision(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecision(_loanDecision, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanDecision(int _loanDecision, Db db)
        {
            return db.LoanGetByLoanDecision(_loanDecision);
        }

        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanDecisionFirstOrNull(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecisionFirstOrNull(_loanDecision, db);
        }

        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanDecisionFirstOrNull(int _loanDecision, Db db)
        {
            return db.LoanGetByLoanDecisionFirstOrNull(_loanDecision);
        }           

        /// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanGenerationStatus(byte _loanGenerationStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanGenerationStatus(_loanGenerationStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanGenerationStatus(byte _loanGenerationStatus, Db db)
        {
            return db.LoanGetByLoanGenerationStatus(_loanGenerationStatus);
        }

        /// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanGenerationStatusFirstOrNull(byte _loanGenerationStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanGenerationStatusFirstOrNull(_loanGenerationStatus, db);
        }

        /// <summary>
		/// Gets rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanGenerationStatusFirstOrNull(byte _loanGenerationStatus, Db db)
        {
            return db.LoanGetByLoanGenerationStatusFirstOrNull(_loanGenerationStatus);
        }           

        /// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanStatus(byte _loanStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanStatus(_loanStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanStatus(byte _loanStatus, Db db)
        {
            return db.LoanGetByLoanStatus(_loanStatus);
        }

        /// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanStatusFirstOrNull(byte _loanStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanStatusFirstOrNull(_loanStatus, db);
        }

        /// <summary>
		/// Gets rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanStatusFirstOrNull(byte _loanStatus, Db db)
        {
            return db.LoanGetByLoanStatusFirstOrNull(_loanStatus);
        }           

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanType(_loanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Loan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Loan> GetByLoanType(short _loanType, Db db)
        {
            return db.LoanGetByLoanType(_loanType);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanTypeFirstOrNull(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanTypeFirstOrNull(_loanType, db);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Loan or null.</returns>
        public static Loan GetByLoanTypeFirstOrNull(short _loanType, Db db)
        {
            return db.LoanGetByLoanTypeFirstOrNull(_loanType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
        public static void DeleteByLoanDecision(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanDecision(_loanDecision, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanDecision">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanDecision(int _loanDecision, Db db)
        {
            db.LoanDeleteByLoanDecision(_loanDecision);
        }

        /// <summary>
		/// Deletes rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
        public static void DeleteByLoanGenerationStatus(byte _loanGenerationStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanGenerationStatus(_loanGenerationStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanGenerationStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanGenerationStatus">حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanGenerationStatus(byte _loanGenerationStatus, Db db)
        {
            db.LoanDeleteByLoanGenerationStatus(_loanGenerationStatus);
        }

        /// <summary>
		/// Deletes rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
        public static void DeleteByLoanStatus(byte _loanStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanStatus(_loanStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanStatus from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanStatus">حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanStatus(byte _loanStatus, Db db)
        {
            db.LoanDeleteByLoanStatus(_loanStatus);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
        public static void DeleteByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanType(_loanType, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.Loan table.
        /// </summary>
		/// <param name="_loanType">نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanType(short _loanType, Db db)
        {
            db.LoanDeleteByLoanType(_loanType);
        }
        #endregion
    }
    #endregion

    #region LoanChangeServices
    public static partial class LoanChangeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanChange table.
        /// </summary>
        /// <returns>A list of LoanChange instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanChange> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanChange table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanChange instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanChange> List(Db db)
        {
            return db.LoanChangeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
        /// <returns>Gets an instance of LoanChange or null.</returns>
        public static LoanChange Get(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_loan, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanChange or null.</returns>
        public static LoanChange Get(int _loan, Db db)
        {
            return db.LoanChangeGet(_loan);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="instance">An instance of LoanChange to be inserted.</param>
        /// <returns>The inserted LoanChange</returns>
        public static LoanChange Insert(LoanChange instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="instance">An instance of LoanChange to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanChange</returns>
        public static LoanChange Insert(LoanChange instance, Db db)
        {
            return db.LoanChangeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="instance">An instance of LoanChange which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanChange instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="instance">An instance of LoanChange which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanChange instance, Db db)
        {
            db.LoanChangeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanChange] table.
        /// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
        public static void Delete(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_loan, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanChange] table.
        /// </summary>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _loan, Db db)
        {
            db.LoanChangeDelete(_loan);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
        /// <returns>A list of LoanChange instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanChange> GetByFromLoan(int _fromLoan)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByFromLoan(_fromLoan, db);
        }
    
        /// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanChange instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanChange> GetByFromLoan(int _fromLoan, Db db)
        {
            return db.LoanChangeGetByFromLoan(_fromLoan);
        }

        /// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
        /// <returns>Gets an instance of LoanChange or null.</returns>
        public static LoanChange GetByFromLoanFirstOrNull(int _fromLoan)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByFromLoanFirstOrNull(_fromLoan, db);
        }

        /// <summary>
		/// Gets rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanChange or null.</returns>
        public static LoanChange GetByFromLoanFirstOrNull(int _fromLoan, Db db)
        {
            return db.LoanChangeGetByFromLoanFirstOrNull(_fromLoan);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
        public static void DeleteByFromLoan(int _fromLoan)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByFromLoan(_fromLoan, db);
        }

        /// <summary>
		/// Deletes rows related to one FromLoan from the dbo.LoanChange table.
        /// </summary>
		/// <param name="_fromLoan">معرف بطاقة السلفة المنقولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByFromLoan(int _fromLoan, Db db)
        {
            db.LoanChangeDeleteByFromLoan(_fromLoan);
        }
        #endregion
    }
    #endregion

    #region LoanDecisionServices
    public static partial class LoanDecisionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanDecision table.
        /// </summary>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanDecision table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> List(Db db)
        {
            return db.LoanDecisionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_id">معرف قرار السلف</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision Get(int _id, Db db)
        {
            return db.LoanDecisionGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecision to be inserted.</param>
        /// <returns>The inserted LoanDecision</returns>
        public static LoanDecision Insert(LoanDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecision to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanDecision</returns>
        public static LoanDecision Insert(LoanDecision instance, Db db)
        {
            return db.LoanDecisionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanDecision instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanDecision instance, Db db)
        {
            db.LoanDecisionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecision] table.
        /// </summary>
		/// <param name="_id">معرف قرار السلف</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecision] table.
        /// </summary>
		/// <param name="_id">معرف قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.LoanDecisionDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> GetByLoanDecisionType(byte _loanDecisionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecisionType(_loanDecisionType, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> GetByLoanDecisionType(byte _loanDecisionType, Db db)
        {
            return db.LoanDecisionGetByLoanDecisionType(_loanDecisionType);
        }

        /// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision GetByLoanDecisionTypeFirstOrNull(byte _loanDecisionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecisionTypeFirstOrNull(_loanDecisionType, db);
        }

        /// <summary>
		/// Gets rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision GetByLoanDecisionTypeFirstOrNull(byte _loanDecisionType, Db db)
        {
            return db.LoanDecisionGetByLoanDecisionTypeFirstOrNull(_loanDecisionType);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> GetByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_Year(_number, _year, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanDecision instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecision> GetByNumber_Year(short _number, short _year, Db db)
        {
            return db.LoanDecisionGetByNumber_Year(_number, _year);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision GetByNumber_YearFirstOrNull(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNumber_YearFirstOrNull(_number, _year, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Number, Year) columns  in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanDecision or null.</returns>
        public static LoanDecision GetByNumber_YearFirstOrNull(short _number, short _year, Db db)
        {
            return db.LoanDecisionGetByNumber_YearFirstOrNull(_number, _year);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
        public static void DeleteByLoanDecisionType(byte _loanDecisionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanDecisionType(_loanDecisionType, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanDecisionType from the dbo.LoanDecision table.
        /// </summary>
		/// <param name="_loanDecisionType">نوع القرار</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanDecisionType(byte _loanDecisionType, Db db)
        {
            db.LoanDecisionDeleteByLoanDecisionType(_loanDecisionType);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
        public static void DeleteByNumber_Year(short _number, short _year)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByNumber_Year(_number, _year, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Number, Year columns in the  dbo.LoanDecision table.
        /// </summary>
		/// <param name="_number">رقم القرار</param>
		/// <param name="_year">العام</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByNumber_Year(short _number, short _year, Db db)
        {
            db.LoanDecisionDeleteByNumber_Year(_number, _year);
        }
        #endregion
    }
    #endregion

    #region LoanDecisionTypeServices
    public static partial class LoanDecisionTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionType table.
        /// </summary>
        /// <returns>A list of LoanDecisionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecisionType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanDecisionType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanDecisionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecisionType> List(Db db)
        {
            return db.LoanDecisionTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
        /// <returns>Gets an instance of LoanDecisionType or null.</returns>
        public static LoanDecisionType Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanDecisionType or null.</returns>
        public static LoanDecisionType Get(byte _id, Db db)
        {
            return db.LoanDecisionTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecisionType to be inserted.</param>
        /// <returns>The inserted LoanDecisionType</returns>
        public static LoanDecisionType Insert(LoanDecisionType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecisionType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanDecisionType</returns>
        public static LoanDecisionType Insert(LoanDecisionType instance, Db db)
        {
            return db.LoanDecisionTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanDecisionType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanDecisionType instance, Db db)
        {
            db.LoanDecisionTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecisionType] table.
        /// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecisionType] table.
        /// </summary>
		/// <param name="_id">معرف نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.LoanDecisionTypeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
        /// <returns>A list of LoanDecisionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecisionType> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanDecisionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanDecisionType> GetByName(string _name, Db db)
        {
            return db.LoanDecisionTypeGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
        /// <returns>Gets an instance of LoanDecisionType or null.</returns>
        public static LoanDecisionType GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanDecisionType or null.</returns>
        public static LoanDecisionType GetByNameFirstOrNull(string _name, Db db)
        {
            return db.LoanDecisionTypeGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanDecisionType table.
        /// </summary>
		/// <param name="_name">بيان نوع قرار السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.LoanDecisionTypeDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region LoanGenerationStatusServices
    public static partial class LoanGenerationStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatus table.
        /// </summary>
        /// <returns>A list of LoanGenerationStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanGenerationStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanGenerationStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanGenerationStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanGenerationStatus> List(Db db)
        {
            return db.LoanGenerationStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
        /// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
        public static LoanGenerationStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
        public static LoanGenerationStatus Get(byte _id, Db db)
        {
            return db.LoanGenerationStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanGenerationStatus to be inserted.</param>
        /// <returns>The inserted LoanGenerationStatus</returns>
        public static LoanGenerationStatus Insert(LoanGenerationStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanGenerationStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanGenerationStatus</returns>
        public static LoanGenerationStatus Insert(LoanGenerationStatus instance, Db db)
        {
            return db.LoanGenerationStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanGenerationStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanGenerationStatus instance, Db db)
        {
            db.LoanGenerationStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanGenerationStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanGenerationStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.LoanGenerationStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
        /// <returns>A list of LoanGenerationStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanGenerationStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanGenerationStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanGenerationStatus> GetByName(string _name, Db db)
        {
            return db.LoanGenerationStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
        /// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
        public static LoanGenerationStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanGenerationStatus or null.</returns>
        public static LoanGenerationStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.LoanGenerationStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanGenerationStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة توليد البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.LoanGenerationStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region LoanRequestServices
    public static partial class LoanRequestServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanRequest table.
        /// </summary>
        /// <returns>A list of LoanRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanRequest> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanRequest table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanRequest> List(Db db)
        {
            return db.LoanRequestList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanRequest table.
        /// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
        /// <returns>Gets an instance of LoanRequest or null.</returns>
        public static LoanRequest Get(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_request, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanRequest table.
        /// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanRequest or null.</returns>
        public static LoanRequest Get(int _request, Db db)
        {
            return db.LoanRequestGet(_request);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="instance">An instance of LoanRequest to be inserted.</param>
        /// <returns>The inserted LoanRequest</returns>
        public static LoanRequest Insert(LoanRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="instance">An instance of LoanRequest to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanRequest</returns>
        public static LoanRequest Insert(LoanRequest instance, Db db)
        {
            return db.LoanRequestInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanRequest instance, Db db)
        {
            db.LoanRequestUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanRequest] table.
        /// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
        public static void Delete(int _request)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_request, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanRequest] table.
        /// </summary>
		/// <param name="_request">معرف طلب السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _request, Db db)
        {
            db.LoanRequestDelete(_request);
        }
        #endregion
    }
    #endregion

    #region LoanStatusServices
    public static partial class LoanStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanStatus table.
        /// </summary>
        /// <returns>A list of LoanStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanStatus> List(Db db)
        {
            return db.LoanStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
        /// <returns>Gets an instance of LoanStatus or null.</returns>
        public static LoanStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanStatus or null.</returns>
        public static LoanStatus Get(byte _id, Db db)
        {
            return db.LoanStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanStatus to be inserted.</param>
        /// <returns>The inserted LoanStatus</returns>
        public static LoanStatus Insert(LoanStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanStatus</returns>
        public static LoanStatus Insert(LoanStatus instance, Db db)
        {
            return db.LoanStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanStatus instance, Db db)
        {
            db.LoanStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.LoanStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
        /// <returns>A list of LoanStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanStatus> GetByName(string _name, Db db)
        {
            return db.LoanStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
        /// <returns>Gets an instance of LoanStatus or null.</returns>
        public static LoanStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanStatus or null.</returns>
        public static LoanStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.LoanStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.LoanStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة البطاقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.LoanStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region LoanTypeServices
    public static partial class LoanTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanType table.
        /// </summary>
        /// <returns>A list of LoanType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanType> List(Db db)
        {
            return db.LoanTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanType table.
        /// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
        /// <returns>Gets an instance of LoanType or null.</returns>
        public static LoanType Get(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_productType, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanType table.
        /// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanType or null.</returns>
        public static LoanType Get(short _productType, Db db)
        {
            return db.LoanTypeGet(_productType);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanType to be inserted.</param>
        /// <returns>The inserted LoanType</returns>
        public static LoanType Insert(LoanType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="instance">An instance of LoanType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanType</returns>
        public static LoanType Insert(LoanType instance, Db db)
        {
            return db.LoanTypeInsert(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanType] table.
        /// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
        public static void Delete(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_productType, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanType] table.
        /// </summary>
		/// <param name="_productType">معرف نوع السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(short _productType, Db db)
        {
            db.LoanTypeDelete(_productType);
        }
        #endregion
    }
    #endregion

    #region LoanTypeClosureServices
    public static partial class LoanTypeClosureServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.LoanTypeClosure table.
        /// </summary>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.LoanTypeClosure table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> List(Db db)
        {
            return db.LoanTypeClosureList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure Get(int _id, Db db)
        {
            return db.LoanTypeClosureGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="instance">An instance of LoanTypeClosure to be inserted.</param>
        /// <returns>The inserted LoanTypeClosure</returns>
        public static LoanTypeClosure Insert(LoanTypeClosure instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="instance">An instance of LoanTypeClosure to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted LoanTypeClosure</returns>
        public static LoanTypeClosure Insert(LoanTypeClosure instance, Db db)
        {
            return db.LoanTypeClosureInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(LoanTypeClosure instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(LoanTypeClosure instance, Db db)
        {
            db.LoanTypeClosureUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanTypeClosure] table.
        /// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanTypeClosure] table.
        /// </summary>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.LoanTypeClosureDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByClosingLoanType(short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByClosingLoanType(_closingLoanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByClosingLoanType(short _closingLoanType, Db db)
        {
            return db.LoanTypeClosureGetByClosingLoanType(_closingLoanType);
        }

        /// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByClosingLoanTypeFirstOrNull(short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByClosingLoanTypeFirstOrNull(_closingLoanType, db);
        }

        /// <summary>
		/// Gets rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByClosingLoanTypeFirstOrNull(short _closingLoanType, Db db)
        {
            return db.LoanTypeClosureGetByClosingLoanTypeFirstOrNull(_closingLoanType);
        }           

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanType(_loanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByLoanType(short _loanType, Db db)
        {
            return db.LoanTypeClosureGetByLoanType(_loanType);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByLoanTypeFirstOrNull(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanTypeFirstOrNull(_loanType, db);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByLoanTypeFirstOrNull(short _loanType, Db db)
        {
            return db.LoanTypeClosureGetByLoanTypeFirstOrNull(_loanType);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByLoanType_ClosingLoanType(short _loanType, short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanType_ClosingLoanType(_loanType, _closingLoanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of LoanTypeClosure instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<LoanTypeClosure> GetByLoanType_ClosingLoanType(short _loanType, short _closingLoanType, Db db)
        {
            return db.LoanTypeClosureGetByLoanType_ClosingLoanType(_loanType, _closingLoanType);
        }

        /// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByLoanType_ClosingLoanTypeFirstOrNull(short _loanType, short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanType_ClosingLoanTypeFirstOrNull(_loanType, _closingLoanType, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (LoanType, ClosingLoanType) columns  in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of LoanTypeClosure or null.</returns>
        public static LoanTypeClosure GetByLoanType_ClosingLoanTypeFirstOrNull(short _loanType, short _closingLoanType, Db db)
        {
            return db.LoanTypeClosureGetByLoanType_ClosingLoanTypeFirstOrNull(_loanType, _closingLoanType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        public static void DeleteByClosingLoanType(short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByClosingLoanType(_closingLoanType, db);
        }

        /// <summary>
		/// Deletes rows related to one ClosingLoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByClosingLoanType(short _closingLoanType, Db db)
        {
            db.LoanTypeClosureDeleteByClosingLoanType(_closingLoanType);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
        public static void DeleteByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanType(_loanType, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanType(short _loanType, Db db)
        {
            db.LoanTypeClosureDeleteByLoanType(_loanType);
        }

        /// <summary>
		/// Deletes rows related to one combination of LoanType, ClosingLoanType columns in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
        public static void DeleteByLoanType_ClosingLoanType(short _loanType, short _closingLoanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanType_ClosingLoanType(_loanType, _closingLoanType, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of LoanType, ClosingLoanType columns in the  dbo.LoanTypeClosure table.
        /// </summary>
		/// <param name="_loanType">نوع السلف المغلَقة</param>
		/// <param name="_closingLoanType">نوع السلفة التي تؤدي إلى الإغلاق</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanType_ClosingLoanType(short _loanType, short _closingLoanType, Db db)
        {
            db.LoanTypeClosureDeleteByLoanType_ClosingLoanType(_loanType, _closingLoanType);
        }
        #endregion
    }
    #endregion

    #region MainWorkPlaceServices
    public static partial class MainWorkPlaceServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MainWorkPlace table.
        /// </summary>
        /// <returns>A list of MainWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MainWorkPlace> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.MainWorkPlace table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MainWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MainWorkPlace> List(Db db)
        {
            return db.MainWorkPlaceList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
        /// <returns>Gets an instance of MainWorkPlace or null.</returns>
        public static MainWorkPlace Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MainWorkPlace or null.</returns>
        public static MainWorkPlace Get(int _id, Db db)
        {
            return db.MainWorkPlaceGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of MainWorkPlace to be inserted.</param>
        /// <returns>The inserted MainWorkPlace</returns>
        public static MainWorkPlace Insert(MainWorkPlace instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of MainWorkPlace to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted MainWorkPlace</returns>
        public static MainWorkPlace Insert(MainWorkPlace instance, Db db)
        {
            return db.MainWorkPlaceInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(MainWorkPlace instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(MainWorkPlace instance, Db db)
        {
            db.MainWorkPlaceUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MainWorkPlace] table.
        /// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MainWorkPlace] table.
        /// </summary>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.MainWorkPlaceDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
        /// <returns>A list of MainWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MainWorkPlace> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MainWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MainWorkPlace> GetByName(string _name, Db db)
        {
            return db.MainWorkPlaceGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
        /// <returns>Gets an instance of MainWorkPlace or null.</returns>
        public static MainWorkPlace GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MainWorkPlace or null.</returns>
        public static MainWorkPlace GetByNameFirstOrNull(string _name, Db db)
        {
            return db.MainWorkPlaceGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.MainWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.MainWorkPlaceDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region MissingInstallmentDecreaseServices
    public static partial class MissingInstallmentDecreaseServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecrease table.
        /// </summary>
        /// <returns>A list of MissingInstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MissingInstallmentDecrease> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.MissingInstallmentDecrease table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MissingInstallmentDecrease instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MissingInstallmentDecrease> List(Db db)
        {
            return db.MissingInstallmentDecreaseList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        /// <returns>Gets an instance of MissingInstallmentDecrease or null.</returns>
        public static MissingInstallmentDecrease Get(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_employee, db);
        }

        /// <summary>
		/// Gets one row from the dbo.MissingInstallmentDecrease table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MissingInstallmentDecrease or null.</returns>
        public static MissingInstallmentDecrease Get(int _employee, Db db)
        {
            return db.MissingInstallmentDecreaseGet(_employee);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of MissingInstallmentDecrease to be inserted.</param>
        /// <returns>The inserted MissingInstallmentDecrease</returns>
        public static MissingInstallmentDecrease Insert(MissingInstallmentDecrease instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of MissingInstallmentDecrease to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted MissingInstallmentDecrease</returns>
        public static MissingInstallmentDecrease Insert(MissingInstallmentDecrease instance, Db db)
        {
            return db.MissingInstallmentDecreaseInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(MissingInstallmentDecrease instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(MissingInstallmentDecrease instance, Db db)
        {
            db.MissingInstallmentDecreaseUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        public static void Delete(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_employee, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _employee, Db db)
        {
            db.MissingInstallmentDecreaseDelete(_employee);
        }
        #endregion
    }
    #endregion

    #region MonthlyBalanceServices
    public static partial class MonthlyBalanceServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.MonthlyBalance table.
        /// </summary>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.MonthlyBalance table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> List(Db db)
        {
            return db.MonthlyBalanceList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance Get(int _id, Db db)
        {
            return db.MonthlyBalanceGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="instance">An instance of MonthlyBalance to be inserted.</param>
        /// <returns>The inserted MonthlyBalance</returns>
        public static MonthlyBalance Insert(MonthlyBalance instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="instance">An instance of MonthlyBalance to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted MonthlyBalance</returns>
        public static MonthlyBalance Insert(MonthlyBalance instance, Db db)
        {
            return db.MonthlyBalanceInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(MonthlyBalance instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(MonthlyBalance instance, Db db)
        {
            db.MonthlyBalanceUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MonthlyBalance] table.
        /// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MonthlyBalance] table.
        /// </summary>
		/// <param name="_id">معرف الرصيد الشهري</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.MonthlyBalanceDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByEmployee(int _employee, Db db)
        {
            return db.MonthlyBalanceGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.MonthlyBalanceGetByEmployeeFirstOrNull(_employee);
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
        public static List<MonthlyBalance> GetByEmployee_PaymentGroup_Month(int _employee, byte _paymentGroup, DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentGroup, Month) columns  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByEmployee_PaymentGroup_Month(int _employee, byte _paymentGroup, DateTime _month, Db db)
        {
            return db.MonthlyBalanceGetByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentGroup, Month) columns  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByEmployee_PaymentGroup_MonthFirstOrNull(int _employee, byte _paymentGroup, DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_PaymentGroup_MonthFirstOrNull(_employee, _paymentGroup, _month, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, PaymentGroup, Month) columns  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByEmployee_PaymentGroup_MonthFirstOrNull(int _employee, byte _paymentGroup, DateTime _month, Db db)
        {
            return db.MonthlyBalanceGetByEmployee_PaymentGroup_MonthFirstOrNull(_employee, _paymentGroup, _month);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByMonth(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMonth(_month, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByMonth(DateTime _month, Db db)
        {
            return db.MonthlyBalanceGetByMonth(_month);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByMonthFirstOrNull(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMonthFirstOrNull(_month, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByMonthFirstOrNull(DateTime _month, Db db)
        {
            return db.MonthlyBalanceGetByMonthFirstOrNull(_month);
        }           

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroup(_paymentGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of MonthlyBalance instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<MonthlyBalance> GetByPaymentGroup(byte _paymentGroup, Db db)
        {
            return db.MonthlyBalanceGetByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByPaymentGroupFirstOrNull(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroupFirstOrNull(_paymentGroup, db);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of MonthlyBalance or null.</returns>
        public static MonthlyBalance GetByPaymentGroupFirstOrNull(byte _paymentGroup, Db db)
        {
            return db.MonthlyBalanceGetByPaymentGroupFirstOrNull(_paymentGroup);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.MonthlyBalanceDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, PaymentGroup, Month columns in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
        public static void DeleteByEmployee_PaymentGroup_Month(int _employee, byte _paymentGroup, DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, PaymentGroup, Month columns in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee_PaymentGroup_Month(int _employee, byte _paymentGroup, DateTime _month, Db db)
        {
            db.MonthlyBalanceDeleteByEmployee_PaymentGroup_Month(_employee, _paymentGroup, _month);
        }

        /// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
        public static void DeleteByMonth(DateTime _month)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMonth(_month, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Month columns in the  dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_month">الشهر</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMonth(DateTime _month, Db db)
        {
            db.MonthlyBalanceDeleteByMonth(_month);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentGroup(_paymentGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.MonthlyBalance table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup, Db db)
        {
            db.MonthlyBalanceDeleteByPaymentGroup(_paymentGroup);
        }
        #endregion
    }
    #endregion

    #region OutgoingLoanServices
    public static partial class OutgoingLoanServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.OutgoingLoan table.
        /// </summary>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.OutgoingLoan table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> List(Db db)
        {
            return db.OutgoingLoanList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan Get(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_loan, db);
        }

        /// <summary>
		/// Gets one row from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan Get(int _loan, Db db)
        {
            return db.OutgoingLoanGet(_loan);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of OutgoingLoan to be inserted.</param>
        /// <returns>The inserted OutgoingLoan</returns>
        public static OutgoingLoan Insert(OutgoingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of OutgoingLoan to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted OutgoingLoan</returns>
        public static OutgoingLoan Insert(OutgoingLoan instance, Db db)
        {
            return db.OutgoingLoanInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(OutgoingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(OutgoingLoan instance, Db db)
        {
            db.OutgoingLoanUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[OutgoingLoan] table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        public static void Delete(int _loan)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_loan, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[OutgoingLoan] table.
        /// </summary>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _loan, Db db)
        {
            db.OutgoingLoanDelete(_loan);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> GetByLoanDecision(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecision(_loanDecision, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> GetByLoanDecision(int _loanDecision, Db db)
        {
            return db.OutgoingLoanGetByLoanDecision(_loanDecision);
        }

        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan GetByLoanDecisionFirstOrNull(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanDecisionFirstOrNull(_loanDecision, db);
        }

        /// <summary>
		/// Gets rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan GetByLoanDecisionFirstOrNull(int _loanDecision, Db db)
        {
            return db.OutgoingLoanGetByLoanDecisionFirstOrNull(_loanDecision);
        }           

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> GetByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlace(_mainWorkPlace, db);
        }
    
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of OutgoingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<OutgoingLoan> GetByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            return db.OutgoingLoanGetByMainWorkPlace(_mainWorkPlace);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlaceFirstOrNull(_mainWorkPlace, db);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of OutgoingLoan or null.</returns>
        public static OutgoingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace, Db db)
        {
            return db.OutgoingLoanGetByMainWorkPlaceFirstOrNull(_mainWorkPlace);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
        public static void DeleteByLoanDecision(int _loanDecision)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanDecision(_loanDecision, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanDecision from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_loanDecision">قرار منح السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanDecision(int _loanDecision, Db db)
        {
            db.OutgoingLoanDeleteByLoanDecision(_loanDecision);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMainWorkPlace(_mainWorkPlace, db);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.OutgoingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي المحولة إليه</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            db.OutgoingLoanDeleteByMainWorkPlace(_mainWorkPlace);
        }
        #endregion
    }
    #endregion

    #region PaymentServices
    public static partial class PaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Payment table.
        /// </summary>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Payment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> List(Db db)
        {
            return db.PaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Payment table.
        /// </summary>
		/// <param name="_id">معرف حركة السداد</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Payment table.
        /// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment Get(int _id, Db db)
        {
            return db.PaymentGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Payment] table.
        /// </summary>
        /// <param name="instance">An instance of Payment to be inserted.</param>
        /// <returns>The inserted Payment</returns>
        public static Payment Insert(Payment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Payment] table.
        /// </summary>
        /// <param name="instance">An instance of Payment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Payment</returns>
        public static Payment Insert(Payment instance, Db db)
        {
            return db.PaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Payment] table.
        /// </summary>
        /// <param name="instance">An instance of Payment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Payment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Payment] table.
        /// </summary>
        /// <param name="instance">An instance of Payment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Payment instance, Db db)
        {
            db.PaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Payment] table.
        /// </summary>
		/// <param name="_id">معرف حركة السداد</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Payment] table.
        /// </summary>
		/// <param name="_id">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.PaymentDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByCollectOrder(Nullable<int> _collectOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByCollectOrder(_collectOrder, db);
        }
    
        /// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByCollectOrder(Nullable<int> _collectOrder, Db db)
        {
            return db.PaymentGetByCollectOrder(_collectOrder);
        }

        /// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByCollectOrderFirstOrNull(Nullable<int> _collectOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByCollectOrderFirstOrNull(_collectOrder, db);
        }

        /// <summary>
		/// Gets rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByCollectOrderFirstOrNull(Nullable<int> _collectOrder, Db db)
        {
            return db.PaymentGetByCollectOrderFirstOrNull(_collectOrder);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByDate(DateTime _date, Db db)
        {
            return db.PaymentGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByDateFirstOrNull(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByDateFirstOrNull(DateTime _date, Db db)
        {
            return db.PaymentGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByEmployee(int _employee, Db db)
        {
            return db.PaymentGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.PaymentGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroup(_paymentGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByPaymentGroup(byte _paymentGroup, Db db)
        {
            return db.PaymentGetByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByPaymentGroupFirstOrNull(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroupFirstOrNull(_paymentGroup, db);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByPaymentGroupFirstOrNull(byte _paymentGroup, Db db)
        {
            return db.PaymentGetByPaymentGroupFirstOrNull(_paymentGroup);
        }           

        /// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByPaymentStatus(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentStatus(_paymentStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Payment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Payment> GetByPaymentStatus(Nullable<byte> _paymentStatus, Db db)
        {
            return db.PaymentGetByPaymentStatus(_paymentStatus);
        }

        /// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByPaymentStatusFirstOrNull(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentStatusFirstOrNull(_paymentStatus, db);
        }

        /// <summary>
		/// Gets rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Payment or null.</returns>
        public static Payment GetByPaymentStatusFirstOrNull(Nullable<byte> _paymentStatus, Db db)
        {
            return db.PaymentGetByPaymentStatusFirstOrNull(_paymentStatus);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
        public static void DeleteByCollectOrder(Nullable<int> _collectOrder)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByCollectOrder(_collectOrder, db);
        }

        /// <summary>
		/// Deletes rows related to one CollectOrder from the dbo.Payment table.
        /// </summary>
		/// <param name="_collectOrder">أمر القبض</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByCollectOrder(Nullable<int> _collectOrder, Db db)
        {
            db.PaymentDeleteByCollectOrder(_collectOrder);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
        public static void DeleteByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.Payment table.
        /// </summary>
		/// <param name="_date">تاريخ السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(DateTime _date, Db db)
        {
            db.PaymentDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Payment table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.PaymentDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentGroup(_paymentGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة أنواع الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup, Db db)
        {
            db.PaymentDeleteByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Deletes rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
        public static void DeleteByPaymentStatus(Nullable<byte> _paymentStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentStatus(_paymentStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one PaymentStatus from the dbo.Payment table.
        /// </summary>
		/// <param name="_paymentStatus">حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentStatus(Nullable<byte> _paymentStatus, Db db)
        {
            db.PaymentDeleteByPaymentStatus(_paymentStatus);
        }
        #endregion
    }
    #endregion

    #region PaymentGroupServices
    public static partial class PaymentGroupServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentGroup table.
        /// </summary>
        /// <returns>A list of PaymentGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentGroup> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.PaymentGroup table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PaymentGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentGroup> List(Db db)
        {
            return db.PaymentGroupList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
        /// <returns>Gets an instance of PaymentGroup or null.</returns>
        public static PaymentGroup Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PaymentGroup or null.</returns>
        public static PaymentGroup Get(byte _id, Db db)
        {
            return db.PaymentGroupGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentGroup to be inserted.</param>
        /// <returns>The inserted PaymentGroup</returns>
        public static PaymentGroup Insert(PaymentGroup instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentGroup to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted PaymentGroup</returns>
        public static PaymentGroup Insert(PaymentGroup instance, Db db)
        {
            return db.PaymentGroupInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(PaymentGroup instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(PaymentGroup instance, Db db)
        {
            db.PaymentGroupUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PaymentGroup] table.
        /// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PaymentGroup] table.
        /// </summary>
		/// <param name="_id">معرف مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.PaymentGroupDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
        /// <returns>A list of PaymentGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentGroup> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PaymentGroup instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentGroup> GetByName(string _name, Db db)
        {
            return db.PaymentGroupGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
        /// <returns>Gets an instance of PaymentGroup or null.</returns>
        public static PaymentGroup GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PaymentGroup or null.</returns>
        public static PaymentGroup GetByNameFirstOrNull(string _name, Db db)
        {
            return db.PaymentGroupGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.PaymentGroup table.
        /// </summary>
		/// <param name="_name">بيان مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.PaymentGroupDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region PaymentStatusServices
    public static partial class PaymentStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PaymentStatus table.
        /// </summary>
        /// <returns>A list of PaymentStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.PaymentStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PaymentStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PaymentStatus> List(Db db)
        {
            return db.PaymentStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PaymentStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة السداد</param>
        /// <returns>Gets an instance of PaymentStatus or null.</returns>
        public static PaymentStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.PaymentStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PaymentStatus or null.</returns>
        public static PaymentStatus Get(byte _id, Db db)
        {
            return db.PaymentStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentStatus to be inserted.</param>
        /// <returns>The inserted PaymentStatus</returns>
        public static PaymentStatus Insert(PaymentStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted PaymentStatus</returns>
        public static PaymentStatus Insert(PaymentStatus instance, Db db)
        {
            return db.PaymentStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(PaymentStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(PaymentStatus instance, Db db)
        {
            db.PaymentStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PaymentStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة السداد</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PaymentStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.PaymentStatusDelete(_id);
        }
        #endregion
    }
    #endregion

    #region PayOrderServices
    public static partial class PayOrderServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.PayOrder table.
        /// </summary>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.PayOrder table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> List(Db db)
        {
            return db.PayOrderList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder Get(int _id, Db db)
        {
            return db.PayOrderGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="instance">An instance of PayOrder to be inserted.</param>
        /// <returns>The inserted PayOrder</returns>
        public static PayOrder Insert(PayOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="instance">An instance of PayOrder to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted PayOrder</returns>
        public static PayOrder Insert(PayOrder instance, Db db)
        {
            return db.PayOrderInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="instance">An instance of PayOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(PayOrder instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="instance">An instance of PayOrder which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(PayOrder instance, Db db)
        {
            db.PayOrderUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PayOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PayOrder] table.
        /// </summary>
		/// <param name="_id">معرف أمر الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.PayOrderDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByDate(DateTime _date, Db db)
        {
            return db.PayOrderGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByDateFirstOrNull(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByDateFirstOrNull(DateTime _date, Db db)
        {
            return db.PayOrderGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByEmployee(int _employee, Db db)
        {
            return db.PayOrderGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.PayOrderGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByIsFixed(byte _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsFixed(_isFixed, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByIsFixed(byte _isFixed, Db db)
        {
            return db.PayOrderGetByIsFixed(_isFixed);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByIsFixedFirstOrNull(byte _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsFixedFirstOrNull(_isFixed, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByIsFixedFirstOrNull(byte _isFixed, Db db)
        {
            return db.PayOrderGetByIsFixedFirstOrNull(_isFixed);
        }           

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroup(_paymentGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of PayOrder instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<PayOrder> GetByPaymentGroup(byte _paymentGroup, Db db)
        {
            return db.PayOrderGetByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByPaymentGroupFirstOrNull(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroupFirstOrNull(_paymentGroup, db);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of PayOrder or null.</returns>
        public static PayOrder GetByPaymentGroupFirstOrNull(byte _paymentGroup, Db db)
        {
            return db.PayOrderGetByPaymentGroupFirstOrNull(_paymentGroup);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
        public static void DeleteByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_date">تاريخ البيان</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(DateTime _date, Db db)
        {
            db.PayOrderDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.PayOrderDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
        public static void DeleteByIsFixed(byte _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsFixed(_isFixed, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.PayOrder table.
        /// </summary>
		/// <param name="_isFixed">تم تثبيت الدفع؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsFixed(byte _isFixed, Db db)
        {
            db.PayOrderDeleteByIsFixed(_isFixed);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentGroup(_paymentGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.PayOrder table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentGroup(byte _paymentGroup, Db db)
        {
            db.PayOrderDeleteByPaymentGroup(_paymentGroup);
        }
        #endregion
    }
    #endregion

    #region ProductServices
    public static partial class ProductServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Product table.
        /// </summary>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Product table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> List(Db db)
        {
            return db.ProductList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Product table.
        /// </summary>
		/// <param name="_id">معرف المنتج</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Product table.
        /// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product Get(int _id, Db db)
        {
            return db.ProductGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Product] table.
        /// </summary>
        /// <param name="instance">An instance of Product to be inserted.</param>
        /// <returns>The inserted Product</returns>
        public static Product Insert(Product instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Product] table.
        /// </summary>
        /// <param name="instance">An instance of Product to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Product</returns>
        public static Product Insert(Product instance, Db db)
        {
            return db.ProductInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Product] table.
        /// </summary>
        /// <param name="instance">An instance of Product which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Product instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Product] table.
        /// </summary>
        /// <param name="instance">An instance of Product which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Product instance, Db db)
        {
            db.ProductUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Product] table.
        /// </summary>
		/// <param name="_id">معرف المنتج</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Product] table.
        /// </summary>
		/// <param name="_id">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ProductDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> GetByEmployee(int _employee, Db db)
        {
            return db.ProductGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.ProductGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> GetByProductType(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductType(_productType, db);
        }
    
        /// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Product instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Product> GetByProductType(short _productType, Db db)
        {
            return db.ProductGetByProductType(_productType);
        }

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product GetByProductTypeFirstOrNull(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductTypeFirstOrNull(_productType, db);
        }

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Product or null.</returns>
        public static Product GetByProductTypeFirstOrNull(short _productType, Db db)
        {
            return db.ProductGetByProductTypeFirstOrNull(_productType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Product table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.ProductDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        public static void DeleteByProductType(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByProductType(_productType, db);
        }

        /// <summary>
		/// Deletes rows related to one ProductType from the dbo.Product table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByProductType(short _productType, Db db)
        {
            db.ProductDeleteByProductType(_productType);
        }
        #endregion
    }
    #endregion

    #region ProductTypeServices
    public static partial class ProductTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductType table.
        /// </summary>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ProductType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> List(Db db)
        {
            return db.ProductTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductType table.
        /// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType Get(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ProductType table.
        /// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType Get(short _id, Db db)
        {
            return db.ProductTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="instance">An instance of ProductType to be inserted.</param>
        /// <returns>The inserted ProductType</returns>
        public static ProductType Insert(ProductType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="instance">An instance of ProductType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ProductType</returns>
        public static ProductType Insert(ProductType instance, Db db)
        {
            return db.ProductTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="instance">An instance of ProductType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ProductType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="instance">An instance of ProductType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ProductType instance, Db db)
        {
            db.ProductTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProductType] table.
        /// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
        public static void Delete(short _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProductType] table.
        /// </summary>
		/// <param name="_id">معرف نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(short _id, Db db)
        {
            db.ProductTypeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByName(string _name, Db db)
        {
            return db.ProductTypeGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByNameFirstOrNull(string _name, Db db)
        {
            return db.ProductTypeGetByNameFirstOrNull(_name);
        }           

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByPaymentGroup(Nullable<byte> _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroup(_paymentGroup, db);
        }
    
        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByPaymentGroup(Nullable<byte> _paymentGroup, Db db)
        {
            return db.ProductTypeGetByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByPaymentGroupFirstOrNull(Nullable<byte> _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentGroupFirstOrNull(_paymentGroup, db);
        }

        /// <summary>
		/// Gets rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByPaymentGroupFirstOrNull(Nullable<byte> _paymentGroup, Db db)
        {
            return db.ProductTypeGetByPaymentGroupFirstOrNull(_paymentGroup);
        }           

        /// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByProfitStrategy(Nullable<byte> _profitStrategy)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProfitStrategy(_profitStrategy, db);
        }
    
        /// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductType> GetByProfitStrategy(Nullable<byte> _profitStrategy, Db db)
        {
            return db.ProductTypeGetByProfitStrategy(_profitStrategy);
        }

        /// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByProfitStrategyFirstOrNull(Nullable<byte> _profitStrategy)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProfitStrategyFirstOrNull(_profitStrategy, db);
        }

        /// <summary>
		/// Gets rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductType or null.</returns>
        public static ProductType GetByProfitStrategyFirstOrNull(Nullable<byte> _profitStrategy, Db db)
        {
            return db.ProductTypeGetByProfitStrategyFirstOrNull(_profitStrategy);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProductType table.
        /// </summary>
		/// <param name="_name">بيان نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.ProductTypeDeleteByName(_name);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
        public static void DeleteByPaymentGroup(Nullable<byte> _paymentGroup)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPaymentGroup(_paymentGroup, db);
        }

        /// <summary>
		/// Deletes rows related to one PaymentGroup from the dbo.ProductType table.
        /// </summary>
		/// <param name="_paymentGroup">مجموعة الدفع</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPaymentGroup(Nullable<byte> _paymentGroup, Db db)
        {
            db.ProductTypeDeleteByPaymentGroup(_paymentGroup);
        }

        /// <summary>
		/// Deletes rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
        public static void DeleteByProfitStrategy(Nullable<byte> _profitStrategy)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByProfitStrategy(_profitStrategy, db);
        }

        /// <summary>
		/// Deletes rows related to one ProfitStrategy from the dbo.ProductType table.
        /// </summary>
		/// <param name="_profitStrategy">آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByProfitStrategy(Nullable<byte> _profitStrategy, Db db)
        {
            db.ProductTypeDeleteByProfitStrategy(_profitStrategy);
        }
        #endregion
    }
    #endregion

    #region ProductTypeAvailabilityServices
    public static partial class ProductTypeAvailabilityServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailability table.
        /// </summary>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ProductTypeAvailability table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> List(Db db)
        {
            return db.ProductTypeAvailabilityList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_id">معرف القيد</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability Get(int _id, Db db)
        {
            return db.ProductTypeAvailabilityGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="instance">An instance of ProductTypeAvailability to be inserted.</param>
        /// <returns>The inserted ProductTypeAvailability</returns>
        public static ProductTypeAvailability Insert(ProductTypeAvailability instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="instance">An instance of ProductTypeAvailability to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ProductTypeAvailability</returns>
        public static ProductTypeAvailability Insert(ProductTypeAvailability instance, Db db)
        {
            return db.ProductTypeAvailabilityInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ProductTypeAvailability instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ProductTypeAvailability instance, Db db)
        {
            db.ProductTypeAvailabilityUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProductTypeAvailability] table.
        /// </summary>
		/// <param name="_id">معرف القيد</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProductTypeAvailability] table.
        /// </summary>
		/// <param name="_id">معرف القيد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ProductTypeAvailabilityDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByAvailability(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailability(_availability, db);
        }
    
        /// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByAvailability(short _availability, Db db)
        {
            return db.ProductTypeAvailabilityGetByAvailability(_availability);
        }

        /// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByAvailabilityFirstOrNull(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByAvailabilityFirstOrNull(_availability, db);
        }

        /// <summary>
		/// Gets rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByAvailabilityFirstOrNull(short _availability, Db db)
        {
            return db.ProductTypeAvailabilityGetByAvailabilityFirstOrNull(_availability);
        }           

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByProductType(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductType(_productType, db);
        }
    
        /// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByProductType(short _productType, Db db)
        {
            return db.ProductTypeAvailabilityGetByProductType(_productType);
        }

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByProductTypeFirstOrNull(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductTypeFirstOrNull(_productType, db);
        }

        /// <summary>
		/// Gets rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByProductTypeFirstOrNull(short _productType, Db db)
        {
            return db.ProductTypeAvailabilityGetByProductTypeFirstOrNull(_productType);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByProductType_Availability(short _productType, short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductType_Availability(_productType, _availability, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProductTypeAvailability instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProductTypeAvailability> GetByProductType_Availability(short _productType, short _availability, Db db)
        {
            return db.ProductTypeAvailabilityGetByProductType_Availability(_productType, _availability);
        }

        /// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByProductType_AvailabilityFirstOrNull(short _productType, short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByProductType_AvailabilityFirstOrNull(_productType, _availability, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (ProductType, Availability) columns  in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProductTypeAvailability or null.</returns>
        public static ProductTypeAvailability GetByProductType_AvailabilityFirstOrNull(short _productType, short _availability, Db db)
        {
            return db.ProductTypeAvailabilityGetByProductType_AvailabilityFirstOrNull(_productType, _availability);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
        public static void DeleteByAvailability(short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByAvailability(_availability, db);
        }

        /// <summary>
		/// Deletes rows related to one Availability from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByAvailability(short _availability, Db db)
        {
            db.ProductTypeAvailabilityDeleteByAvailability(_availability);
        }

        /// <summary>
		/// Deletes rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
        public static void DeleteByProductType(short _productType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByProductType(_productType, db);
        }

        /// <summary>
		/// Deletes rows related to one ProductType from the dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByProductType(short _productType, Db db)
        {
            db.ProductTypeAvailabilityDeleteByProductType(_productType);
        }

        /// <summary>
		/// Deletes rows related to one combination of ProductType, Availability columns in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
        public static void DeleteByProductType_Availability(short _productType, short _availability)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByProductType_Availability(_productType, _availability, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of ProductType, Availability columns in the  dbo.ProductTypeAvailability table.
        /// </summary>
		/// <param name="_productType">نوع المنتج</param>
		/// <param name="_availability">قاعدة الاستخدام</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByProductType_Availability(short _productType, short _availability, Db db)
        {
            db.ProductTypeAvailabilityDeleteByProductType_Availability(_productType, _availability);
        }
        #endregion
    }
    #endregion

    #region ProfileServices
    public static partial class ProfileServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Profile table.
        /// </summary>
        /// <returns>A list of Profile instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Profile> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Profile table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Profile instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Profile> List(Db db)
        {
            return db.ProfileList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Profile table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Profile or null.</returns>
        public static Profile Get(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_employee, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Profile table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Profile or null.</returns>
        public static Profile Get(int _employee, Db db)
        {
            return db.ProfileGet(_employee);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Profile] table.
        /// </summary>
        /// <param name="instance">An instance of Profile to be inserted.</param>
        /// <returns>The inserted Profile</returns>
        public static Profile Insert(Profile instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Profile] table.
        /// </summary>
        /// <param name="instance">An instance of Profile to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Profile</returns>
        public static Profile Insert(Profile instance, Db db)
        {
            return db.ProfileInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Profile] table.
        /// </summary>
        /// <param name="instance">An instance of Profile which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Profile instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Profile] table.
        /// </summary>
        /// <param name="instance">An instance of Profile which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Profile instance, Db db)
        {
            db.ProfileUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Profile] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void Delete(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_employee, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Profile] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _employee, Db db)
        {
            db.ProfileDelete(_employee);
        }
        #endregion
    }
    #endregion

    #region ProfitStrategyServices
    public static partial class ProfitStrategyServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ProfitStrategy table.
        /// </summary>
        /// <returns>A list of ProfitStrategy instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProfitStrategy> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ProfitStrategy table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProfitStrategy instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProfitStrategy> List(Db db)
        {
            return db.ProfitStrategyList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
        /// <returns>Gets an instance of ProfitStrategy or null.</returns>
        public static ProfitStrategy Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProfitStrategy or null.</returns>
        public static ProfitStrategy Get(byte _id, Db db)
        {
            return db.ProfitStrategyGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="instance">An instance of ProfitStrategy to be inserted.</param>
        /// <returns>The inserted ProfitStrategy</returns>
        public static ProfitStrategy Insert(ProfitStrategy instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="instance">An instance of ProfitStrategy to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ProfitStrategy</returns>
        public static ProfitStrategy Insert(ProfitStrategy instance, Db db)
        {
            return db.ProfitStrategyInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ProfitStrategy instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ProfitStrategy instance, Db db)
        {
            db.ProfitStrategyUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProfitStrategy] table.
        /// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProfitStrategy] table.
        /// </summary>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.ProfitStrategyDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
        /// <returns>A list of ProfitStrategy instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProfitStrategy> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ProfitStrategy instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ProfitStrategy> GetByName(string _name, Db db)
        {
            return db.ProfitStrategyGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
        /// <returns>Gets an instance of ProfitStrategy or null.</returns>
        public static ProfitStrategy GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ProfitStrategy or null.</returns>
        public static ProfitStrategy GetByNameFirstOrNull(string _name, Db db)
        {
            return db.ProfitStrategyGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.ProfitStrategy table.
        /// </summary>
		/// <param name="_name">بيان آلية حساب العوائد الربحية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.ProfitStrategyDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region RefundableProductServices
    public static partial class RefundableProductServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RefundableProduct table.
        /// </summary>
        /// <returns>A list of RefundableProduct instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RefundableProduct> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.RefundableProduct table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of RefundableProduct instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RefundableProduct> List(Db db)
        {
            return db.RefundableProductList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RefundableProduct table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
        /// <returns>Gets an instance of RefundableProduct or null.</returns>
        public static RefundableProduct Get(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_product, db);
        }

        /// <summary>
		/// Gets one row from the dbo.RefundableProduct table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of RefundableProduct or null.</returns>
        public static RefundableProduct Get(int _product, Db db)
        {
            return db.RefundableProductGet(_product);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="instance">An instance of RefundableProduct to be inserted.</param>
        /// <returns>The inserted RefundableProduct</returns>
        public static RefundableProduct Insert(RefundableProduct instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="instance">An instance of RefundableProduct to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted RefundableProduct</returns>
        public static RefundableProduct Insert(RefundableProduct instance, Db db)
        {
            return db.RefundableProductInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(RefundableProduct instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(RefundableProduct instance, Db db)
        {
            db.RefundableProductUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[RefundableProduct] table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
        public static void Delete(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_product, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[RefundableProduct] table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _product, Db db)
        {
            db.RefundableProductDelete(_product);
        }
        #endregion
    }
    #endregion

    #region RequestServices
    public static partial class RequestServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Request table.
        /// </summary>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Request table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> List(Db db)
        {
            return db.RequestList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Request table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request Get(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_product, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Request table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request Get(int _product, Db db)
        {
            return db.RequestGet(_product);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Request] table.
        /// </summary>
        /// <param name="instance">An instance of Request to be inserted.</param>
        /// <returns>The inserted Request</returns>
        public static Request Insert(Request instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Request] table.
        /// </summary>
        /// <param name="instance">An instance of Request to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Request</returns>
        public static Request Insert(Request instance, Db db)
        {
            return db.RequestInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Request] table.
        /// </summary>
        /// <param name="instance">An instance of Request which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Request instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Request] table.
        /// </summary>
        /// <param name="instance">An instance of Request which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Request instance, Db db)
        {
            db.RequestUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Request] table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
        public static void Delete(int _product)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_product, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Request] table.
        /// </summary>
		/// <param name="_product">معرف المنتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _product, Db db)
        {
            db.RequestDelete(_product);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> GetByBypassStatus(int _bypassStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByBypassStatus(_bypassStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> GetByBypassStatus(int _bypassStatus, Db db)
        {
            return db.RequestGetByBypassStatus(_bypassStatus);
        }

        /// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request GetByBypassStatusFirstOrNull(int _bypassStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByBypassStatusFirstOrNull(_bypassStatus, db);
        }

        /// <summary>
		/// Gets rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request GetByBypassStatusFirstOrNull(int _bypassStatus, Db db)
        {
            return db.RequestGetByBypassStatusFirstOrNull(_bypassStatus);
        }           

        /// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> GetByRequestStatus(Nullable<byte> _requestStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRequestStatus(_requestStatus, db);
        }
    
        /// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Request instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Request> GetByRequestStatus(Nullable<byte> _requestStatus, Db db)
        {
            return db.RequestGetByRequestStatus(_requestStatus);
        }

        /// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request GetByRequestStatusFirstOrNull(Nullable<byte> _requestStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByRequestStatusFirstOrNull(_requestStatus, db);
        }

        /// <summary>
		/// Gets rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Request or null.</returns>
        public static Request GetByRequestStatusFirstOrNull(Nullable<byte> _requestStatus, Db db)
        {
            return db.RequestGetByRequestStatusFirstOrNull(_requestStatus);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
        public static void DeleteByBypassStatus(int _bypassStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByBypassStatus(_bypassStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one BypassStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_bypassStatus">حالة تجاوز الشروط</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByBypassStatus(int _bypassStatus, Db db)
        {
            db.RequestDeleteByBypassStatus(_bypassStatus);
        }

        /// <summary>
		/// Deletes rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
        public static void DeleteByRequestStatus(Nullable<byte> _requestStatus)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByRequestStatus(_requestStatus, db);
        }

        /// <summary>
		/// Deletes rows related to one RequestStatus from the dbo.Request table.
        /// </summary>
		/// <param name="_requestStatus">حالة الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByRequestStatus(Nullable<byte> _requestStatus, Db db)
        {
            db.RequestDeleteByRequestStatus(_requestStatus);
        }
        #endregion
    }
    #endregion

    #region RequestStatusServices
    public static partial class RequestStatusServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.RequestStatus table.
        /// </summary>
        /// <returns>A list of RequestStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RequestStatus> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.RequestStatus table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of RequestStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RequestStatus> List(Db db)
        {
            return db.RequestStatusList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.RequestStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
        /// <returns>Gets an instance of RequestStatus or null.</returns>
        public static RequestStatus Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.RequestStatus table.
        /// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of RequestStatus or null.</returns>
        public static RequestStatus Get(byte _id, Db db)
        {
            return db.RequestStatusGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="instance">An instance of RequestStatus to be inserted.</param>
        /// <returns>The inserted RequestStatus</returns>
        public static RequestStatus Insert(RequestStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="instance">An instance of RequestStatus to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted RequestStatus</returns>
        public static RequestStatus Insert(RequestStatus instance, Db db)
        {
            return db.RequestStatusInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(RequestStatus instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(RequestStatus instance, Db db)
        {
            db.RequestStatusUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[RequestStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[RequestStatus] table.
        /// </summary>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.RequestStatusDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
        /// <returns>A list of RequestStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RequestStatus> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of RequestStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<RequestStatus> GetByName(string _name, Db db)
        {
            return db.RequestStatusGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
        /// <returns>Gets an instance of RequestStatus or null.</returns>
        public static RequestStatus GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of RequestStatus or null.</returns>
        public static RequestStatus GetByNameFirstOrNull(string _name, Db db)
        {
            return db.RequestStatusGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.RequestStatus table.
        /// </summary>
		/// <param name="_name">بيان حالة طلب الحصول على منتج</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.RequestStatusDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region ResourceServices
    public static partial class ResourceServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Resource table.
        /// </summary>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Resource table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> List(Db db)
        {
            return db.ResourceList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Resource table.
        /// </summary>
		/// <param name="_id">معرف المورد</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Resource table.
        /// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource Get(int _id, Db db)
        {
            return db.ResourceGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Resource] table.
        /// </summary>
        /// <param name="instance">An instance of Resource to be inserted.</param>
        /// <returns>The inserted Resource</returns>
        public static Resource Insert(Resource instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Resource] table.
        /// </summary>
        /// <param name="instance">An instance of Resource to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Resource</returns>
        public static Resource Insert(Resource instance, Db db)
        {
            return db.ResourceInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Resource] table.
        /// </summary>
        /// <param name="instance">An instance of Resource which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Resource instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Resource] table.
        /// </summary>
        /// <param name="instance">An instance of Resource which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Resource instance, Db db)
        {
            db.ResourceUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Resource] table.
        /// </summary>
		/// <param name="_id">معرف المورد</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Resource] table.
        /// </summary>
		/// <param name="_id">معرف المورد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.ResourceDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> GetByLanguage_Module_Key(string _language, string _module, string _key)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLanguage_Module_Key(_language, _module, _key, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> GetByLanguage_Module_Key(string _language, string _module, string _key, Db db)
        {
            return db.ResourceGetByLanguage_Module_Key(_language, _module, _key);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource GetByLanguage_Module_KeyFirstOrNull(string _language, string _module, string _key)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLanguage_Module_KeyFirstOrNull(_language, _module, _key, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Language, Module, Key) columns  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource GetByLanguage_Module_KeyFirstOrNull(string _language, string _module, string _key, Db db)
        {
            return db.ResourceGetByLanguage_Module_KeyFirstOrNull(_language, _module, _key);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> GetByModule(string _module)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByModule(_module, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> GetByModule(string _module, Db db)
        {
            return db.ResourceGetByModule(_module);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource GetByModuleFirstOrNull(string _module)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByModuleFirstOrNull(_module, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Resource or null.</returns>
        public static Resource GetByModuleFirstOrNull(string _module, Db db)
        {
            return db.ResourceGetByModuleFirstOrNull(_module);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Language, Module, Key columns in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
        public static void DeleteByLanguage_Module_Key(string _language, string _module, string _key)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLanguage_Module_Key(_language, _module, _key, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Language, Module, Key columns in the  dbo.Resource table.
        /// </summary>
		/// <param name="_language">اللغة</param>
		/// <param name="_module">الوحدة</param>
		/// <param name="_key">المفتاح</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLanguage_Module_Key(string _language, string _module, string _key, Db db)
        {
            db.ResourceDeleteByLanguage_Module_Key(_language, _module, _key);
        }

        /// <summary>
		/// Deletes rows related to one combination of Module columns in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
        public static void DeleteByModule(string _module)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByModule(_module, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Module columns in the  dbo.Resource table.
        /// </summary>
		/// <param name="_module">الوحدة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByModule(string _module, Db db)
        {
            db.ResourceDeleteByModule(_module);
        }
        #endregion
    }
    #endregion

    #region SalaryPaymentServices
    public static partial class SalaryPaymentServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SalaryPayment table.
        /// </summary>
        /// <returns>A list of SalaryPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryPayment> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.SalaryPayment table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SalaryPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryPayment> List(Db db)
        {
            return db.SalaryPaymentList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
        /// <returns>Gets an instance of SalaryPayment or null.</returns>
        public static SalaryPayment Get(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_payment, db);
        }

        /// <summary>
		/// Gets one row from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SalaryPayment or null.</returns>
        public static SalaryPayment Get(int _payment, Db db)
        {
            return db.SalaryPaymentGet(_payment);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryPayment to be inserted.</param>
        /// <returns>The inserted SalaryPayment</returns>
        public static SalaryPayment Insert(SalaryPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryPayment to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted SalaryPayment</returns>
        public static SalaryPayment Insert(SalaryPayment instance, Db db)
        {
            return db.SalaryPaymentInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(SalaryPayment instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(SalaryPayment instance, Db db)
        {
            db.SalaryPaymentUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SalaryPayment] table.
        /// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
        public static void Delete(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_payment, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SalaryPayment] table.
        /// </summary>
		/// <param name="_payment">معرف حركة السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _payment, Db db)
        {
            db.SalaryPaymentDelete(_payment);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>A list of SalaryPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryPayment> GetByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartment(_department, db);
        }
    
        /// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SalaryPayment instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryPayment> GetByDepartment(int _department, Db db)
        {
            return db.SalaryPaymentGetByDepartment(_department);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>Gets an instance of SalaryPayment or null.</returns>
        public static SalaryPayment GetByDepartmentFirstOrNull(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartmentFirstOrNull(_department, db);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SalaryPayment or null.</returns>
        public static SalaryPayment GetByDepartmentFirstOrNull(int _department, Db db)
        {
            return db.SalaryPaymentGetByDepartmentFirstOrNull(_department);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        public static void DeleteByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDepartment(_department, db);
        }

        /// <summary>
		/// Deletes rows related to one Department from the dbo.SalaryPayment table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDepartment(int _department, Db db)
        {
            db.SalaryPaymentDeleteByDepartment(_department);
        }
        #endregion
    }
    #endregion

    #region SalaryWorkPlaceServices
    public static partial class SalaryWorkPlaceServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlace table.
        /// </summary>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.SalaryWorkPlace table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> List(Db db)
        {
            return db.SalaryWorkPlaceList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace Get(int _id, Db db)
        {
            return db.SalaryWorkPlaceGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryWorkPlace to be inserted.</param>
        /// <returns>The inserted SalaryWorkPlace</returns>
        public static SalaryWorkPlace Insert(SalaryWorkPlace instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryWorkPlace to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted SalaryWorkPlace</returns>
        public static SalaryWorkPlace Insert(SalaryWorkPlace instance, Db db)
        {
            return db.SalaryWorkPlaceInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(SalaryWorkPlace instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(SalaryWorkPlace instance, Db db)
        {
            db.SalaryWorkPlaceUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SalaryWorkPlace] table.
        /// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SalaryWorkPlace] table.
        /// </summary>
		/// <param name="_id">معرف جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.SalaryWorkPlaceDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> GetByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlace(_mainWorkPlace, db);
        }
    
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> GetByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            return db.SalaryWorkPlaceGetByMainWorkPlace(_mainWorkPlace);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlaceFirstOrNull(_mainWorkPlace, db);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace, Db db)
        {
            return db.SalaryWorkPlaceGetByMainWorkPlaceFirstOrNull(_mainWorkPlace);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SalaryWorkPlace instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SalaryWorkPlace> GetByName(string _name, Db db)
        {
            return db.SalaryWorkPlaceGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SalaryWorkPlace or null.</returns>
        public static SalaryWorkPlace GetByNameFirstOrNull(string _name, Db db)
        {
            return db.SalaryWorkPlaceGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMainWorkPlace(_mainWorkPlace, db);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_mainWorkPlace">مكان العمل الرئيسي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            db.SalaryWorkPlaceDeleteByMainWorkPlace(_mainWorkPlace);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SalaryWorkPlace table.
        /// </summary>
		/// <param name="_name">بيان جهة صرف الراتب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.SalaryWorkPlaceDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region ServiceEndGrantRequestServices
    public static partial class ServiceEndGrantRequestServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequest table.
        /// </summary>
        /// <returns>A list of ServiceEndGrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ServiceEndGrantRequest> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.ServiceEndGrantRequest table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of ServiceEndGrantRequest instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<ServiceEndGrantRequest> List(Db db)
        {
            return db.ServiceEndGrantRequestList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequest table.
        /// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
        /// <returns>Gets an instance of ServiceEndGrantRequest or null.</returns>
        public static ServiceEndGrantRequest Get(int _grantRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_grantRequest, db);
        }

        /// <summary>
		/// Gets one row from the dbo.ServiceEndGrantRequest table.
        /// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of ServiceEndGrantRequest or null.</returns>
        public static ServiceEndGrantRequest Get(int _grantRequest, Db db)
        {
            return db.ServiceEndGrantRequestGet(_grantRequest);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of ServiceEndGrantRequest to be inserted.</param>
        /// <returns>The inserted ServiceEndGrantRequest</returns>
        public static ServiceEndGrantRequest Insert(ServiceEndGrantRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of ServiceEndGrantRequest to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted ServiceEndGrantRequest</returns>
        public static ServiceEndGrantRequest Insert(ServiceEndGrantRequest instance, Db db)
        {
            return db.ServiceEndGrantRequestInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(ServiceEndGrantRequest instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(ServiceEndGrantRequest instance, Db db)
        {
            db.ServiceEndGrantRequestUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
        public static void Delete(int _grantRequest)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_grantRequest, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
		/// <param name="_grantRequest">معرف الطلب</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _grantRequest, Db db)
        {
            db.ServiceEndGrantRequestDelete(_grantRequest);
        }
        #endregion
    }
    #endregion

    #region SettlementServices
    public static partial class SettlementServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Settlement table.
        /// </summary>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Settlement table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> List(Db db)
        {
            return db.SettlementList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Settlement table.
        /// </summary>
		/// <param name="_id">معرف السداد</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Settlement table.
        /// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement Get(int _id, Db db)
        {
            return db.SettlementGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="instance">An instance of Settlement to be inserted.</param>
        /// <returns>The inserted Settlement</returns>
        public static Settlement Insert(Settlement instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="instance">An instance of Settlement to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Settlement</returns>
        public static Settlement Insert(Settlement instance, Db db)
        {
            return db.SettlementInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="instance">An instance of Settlement which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Settlement instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="instance">An instance of Settlement which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Settlement instance, Db db)
        {
            db.SettlementUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Settlement] table.
        /// </summary>
		/// <param name="_id">معرف السداد</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Settlement] table.
        /// </summary>
		/// <param name="_id">معرف السداد</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.SettlementDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByInstallment(int _installment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallment(_installment, db);
        }
    
        /// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByInstallment(int _installment, Db db)
        {
            return db.SettlementGetByInstallment(_installment);
        }

        /// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByInstallmentFirstOrNull(int _installment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallmentFirstOrNull(_installment, db);
        }

        /// <summary>
		/// Gets rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByInstallmentFirstOrNull(int _installment, Db db)
        {
            return db.SettlementGetByInstallmentFirstOrNull(_installment);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByInstallment_Payment(int _installment, int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallment_Payment(_installment, _payment, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByInstallment_Payment(int _installment, int _payment, Db db)
        {
            return db.SettlementGetByInstallment_Payment(_installment, _payment);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByInstallment_PaymentFirstOrNull(int _installment, int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByInstallment_PaymentFirstOrNull(_installment, _payment, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Installment, Payment) columns  in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByInstallment_PaymentFirstOrNull(int _installment, int _payment, Db db)
        {
            return db.SettlementGetByInstallment_PaymentFirstOrNull(_installment, _payment);
        }           

        /// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByPayment(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPayment(_payment, db);
        }
    
        /// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Settlement instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Settlement> GetByPayment(int _payment, Db db)
        {
            return db.SettlementGetByPayment(_payment);
        }

        /// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByPaymentFirstOrNull(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByPaymentFirstOrNull(_payment, db);
        }

        /// <summary>
		/// Gets rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Settlement or null.</returns>
        public static Settlement GetByPaymentFirstOrNull(int _payment, Db db)
        {
            return db.SettlementGetByPaymentFirstOrNull(_payment);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
        public static void DeleteByInstallment(int _installment)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByInstallment(_installment, db);
        }

        /// <summary>
		/// Deletes rows related to one Installment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByInstallment(int _installment, Db db)
        {
            db.SettlementDeleteByInstallment(_installment);
        }

        /// <summary>
		/// Deletes rows related to one combination of Installment, Payment columns in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
        public static void DeleteByInstallment_Payment(int _installment, int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByInstallment_Payment(_installment, _payment, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Installment, Payment columns in the  dbo.Settlement table.
        /// </summary>
		/// <param name="_installment">القسط</param>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByInstallment_Payment(int _installment, int _payment, Db db)
        {
            db.SettlementDeleteByInstallment_Payment(_installment, _payment);
        }

        /// <summary>
		/// Deletes rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
        public static void DeleteByPayment(int _payment)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByPayment(_payment, db);
        }

        /// <summary>
		/// Deletes rows related to one Payment from the dbo.Settlement table.
        /// </summary>
		/// <param name="_payment">الدفعة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByPayment(int _payment, Db db)
        {
            db.SettlementDeleteByPayment(_payment);
        }
        #endregion
    }
    #endregion

    #region SpecialCaseLoanServices
    public static partial class SpecialCaseLoanServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoan table.
        /// </summary>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.SpecialCaseLoan table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> List(Db db)
        {
            return db.SpecialCaseLoanList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan Get(int _id, Db db)
        {
            return db.SpecialCaseLoanGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="instance">An instance of SpecialCaseLoan to be inserted.</param>
        /// <returns>The inserted SpecialCaseLoan</returns>
        public static SpecialCaseLoan Insert(SpecialCaseLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="instance">An instance of SpecialCaseLoan to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted SpecialCaseLoan</returns>
        public static SpecialCaseLoan Insert(SpecialCaseLoan instance, Db db)
        {
            return db.SpecialCaseLoanInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(SpecialCaseLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(SpecialCaseLoan instance, Db db)
        {
            db.SpecialCaseLoanUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SpecialCaseLoan] table.
        /// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SpecialCaseLoan] table.
        /// </summary>
		/// <param name="_id">معرف السلفة الخاصة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.SpecialCaseLoanDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDate(_date, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByDate(DateTime _date, Db db)
        {
            return db.SpecialCaseLoanGetByDate(_date);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByDateFirstOrNull(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDateFirstOrNull(_date, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByDateFirstOrNull(DateTime _date, Db db)
        {
            return db.SpecialCaseLoanGetByDateFirstOrNull(_date);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByEmployee(int _employee, Db db)
        {
            return db.SpecialCaseLoanGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.SpecialCaseLoanGetByEmployeeFirstOrNull(_employee);
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
        public static List<SpecialCaseLoan> GetByEmployee_Date_LoanType(int _employee, DateTime _date, short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_Date_LoanType(_employee, _date, _loanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Employee, Date, LoanType) columns  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByEmployee_Date_LoanType(int _employee, DateTime _date, short _loanType, Db db)
        {
            return db.SpecialCaseLoanGetByEmployee_Date_LoanType(_employee, _date, _loanType);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, Date, LoanType) columns  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByEmployee_Date_LoanTypeFirstOrNull(int _employee, DateTime _date, short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_Date_LoanTypeFirstOrNull(_employee, _date, _loanType, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, Date, LoanType) columns  in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByEmployee_Date_LoanTypeFirstOrNull(int _employee, DateTime _date, short _loanType, Db db)
        {
            return db.SpecialCaseLoanGetByEmployee_Date_LoanTypeFirstOrNull(_employee, _date, _loanType);
        }           

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanType(_loanType, db);
        }
    
        /// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SpecialCaseLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SpecialCaseLoan> GetByLoanType(short _loanType, Db db)
        {
            return db.SpecialCaseLoanGetByLoanType(_loanType);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByLoanTypeFirstOrNull(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByLoanTypeFirstOrNull(_loanType, db);
        }

        /// <summary>
		/// Gets rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SpecialCaseLoan or null.</returns>
        public static SpecialCaseLoan GetByLoanTypeFirstOrNull(short _loanType, Db db)
        {
            return db.SpecialCaseLoanGetByLoanTypeFirstOrNull(_loanType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
        public static void DeleteByDate(DateTime _date)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDate(_date, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Date columns in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_date">تاريخ السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDate(DateTime _date, Db db)
        {
            db.SpecialCaseLoanDeleteByDate(_date);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.SpecialCaseLoanDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, Date, LoanType columns in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
        public static void DeleteByEmployee_Date_LoanType(int _employee, DateTime _date, short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee_Date_LoanType(_employee, _date, _loanType, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, Date, LoanType columns in the  dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_date">تاريخ السلفة</param>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee_Date_LoanType(int _employee, DateTime _date, short _loanType, Db db)
        {
            db.SpecialCaseLoanDeleteByEmployee_Date_LoanType(_employee, _date, _loanType);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
        public static void DeleteByLoanType(short _loanType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByLoanType(_loanType, db);
        }

        /// <summary>
		/// Deletes rows related to one LoanType from the dbo.SpecialCaseLoan table.
        /// </summary>
		/// <param name="_loanType">نوع السلف</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByLoanType(short _loanType, Db db)
        {
            db.SpecialCaseLoanDeleteByLoanType(_loanType);
        }
        #endregion
    }
    #endregion

    #region SubscriptionServices
    public static partial class SubscriptionServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Subscription table.
        /// </summary>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Subscription table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> List(Db db)
        {
            return db.SubscriptionList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Subscription table.
        /// </summary>
		/// <param name="_id">معرف الاشتراك</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Subscription table.
        /// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription Get(int _id, Db db)
        {
            return db.SubscriptionGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="instance">An instance of Subscription to be inserted.</param>
        /// <returns>The inserted Subscription</returns>
        public static Subscription Insert(Subscription instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="instance">An instance of Subscription to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Subscription</returns>
        public static Subscription Insert(Subscription instance, Db db)
        {
            return db.SubscriptionInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="instance">An instance of Subscription which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Subscription instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="instance">An instance of Subscription which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Subscription instance, Db db)
        {
            db.SubscriptionUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Subscription] table.
        /// </summary>
		/// <param name="_id">معرف الاشتراك</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Subscription] table.
        /// </summary>
		/// <param name="_id">معرف الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.SubscriptionDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartment(_department, db);
        }
    
        /// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByDepartment(int _department, Db db)
        {
            return db.SubscriptionGetByDepartment(_department);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByDepartmentFirstOrNull(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDepartmentFirstOrNull(_department, db);
        }

        /// <summary>
		/// Gets rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByDepartmentFirstOrNull(int _department, Db db)
        {
            return db.SubscriptionGetByDepartmentFirstOrNull(_department);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByEmployee(int _employee, Db db)
        {
            return db.SubscriptionGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.SubscriptionGetByEmployeeFirstOrNull(_employee);
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
        public static List<Subscription> GetByEmployee_Month_Department_SubscriptionType(int _employee, DateTime _month, int _department, byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Employee, Month, Department, SubscriptionType) columns  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByEmployee_Month_Department_SubscriptionType(int _employee, DateTime _month, int _department, byte _subscriptionType, Db db)
        {
            return db.SubscriptionGetByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, Month, Department, SubscriptionType) columns  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByEmployee_Month_Department_SubscriptionTypeFirstOrNull(int _employee, DateTime _month, int _department, byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee_Month_Department_SubscriptionTypeFirstOrNull(_employee, _month, _department, _subscriptionType, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Employee, Month, Department, SubscriptionType) columns  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByEmployee_Month_Department_SubscriptionTypeFirstOrNull(int _employee, DateTime _month, int _department, byte _subscriptionType, Db db)
        {
            return db.SubscriptionGetByEmployee_Month_Department_SubscriptionTypeFirstOrNull(_employee, _month, _department, _subscriptionType);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByIsFixed(bool _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsFixed(_isFixed, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetByIsFixed(bool _isFixed, Db db)
        {
            return db.SubscriptionGetByIsFixed(_isFixed);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByIsFixedFirstOrNull(bool _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsFixedFirstOrNull(_isFixed, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetByIsFixedFirstOrNull(bool _isFixed, Db db)
        {
            return db.SubscriptionGetByIsFixedFirstOrNull(_isFixed);
        }           

        /// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetBySubscriptionType(byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetBySubscriptionType(_subscriptionType, db);
        }
    
        /// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Subscription instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Subscription> GetBySubscriptionType(byte _subscriptionType, Db db)
        {
            return db.SubscriptionGetBySubscriptionType(_subscriptionType);
        }

        /// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetBySubscriptionTypeFirstOrNull(byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetBySubscriptionTypeFirstOrNull(_subscriptionType, db);
        }

        /// <summary>
		/// Gets rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Subscription or null.</returns>
        public static Subscription GetBySubscriptionTypeFirstOrNull(byte _subscriptionType, Db db)
        {
            return db.SubscriptionGetBySubscriptionTypeFirstOrNull(_subscriptionType);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
        public static void DeleteByDepartment(int _department)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDepartment(_department, db);
        }

        /// <summary>
		/// Deletes rows related to one Department from the dbo.Subscription table.
        /// </summary>
		/// <param name="_department">الفعالية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDepartment(int _department, Db db)
        {
            db.SubscriptionDeleteByDepartment(_department);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.SubscriptionDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, Month, Department, SubscriptionType columns in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
        public static void DeleteByEmployee_Month_Department_SubscriptionType(int _employee, DateTime _month, int _department, byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Employee, Month, Department, SubscriptionType columns in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		/// <param name="_month">التاريخ</param>
		/// <param name="_department">الفعالية</param>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee_Month_Department_SubscriptionType(int _employee, DateTime _month, int _department, byte _subscriptionType, Db db)
        {
            db.SubscriptionDeleteByEmployee_Month_Department_SubscriptionType(_employee, _month, _department, _subscriptionType);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
        public static void DeleteByIsFixed(bool _isFixed)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsFixed(_isFixed, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsFixed columns in the  dbo.Subscription table.
        /// </summary>
		/// <param name="_isFixed">مثبت؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsFixed(bool _isFixed, Db db)
        {
            db.SubscriptionDeleteByIsFixed(_isFixed);
        }

        /// <summary>
		/// Deletes rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
        public static void DeleteBySubscriptionType(byte _subscriptionType)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteBySubscriptionType(_subscriptionType, db);
        }

        /// <summary>
		/// Deletes rows related to one SubscriptionType from the dbo.Subscription table.
        /// </summary>
		/// <param name="_subscriptionType">نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteBySubscriptionType(byte _subscriptionType, Db db)
        {
            db.SubscriptionDeleteBySubscriptionType(_subscriptionType);
        }
        #endregion
    }
    #endregion

    #region SubscriptionTypeServices
    public static partial class SubscriptionTypeServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.SubscriptionType table.
        /// </summary>
        /// <returns>A list of SubscriptionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SubscriptionType> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.SubscriptionType table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SubscriptionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SubscriptionType> List(Db db)
        {
            return db.SubscriptionTypeList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
        /// <returns>Gets an instance of SubscriptionType or null.</returns>
        public static SubscriptionType Get(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SubscriptionType or null.</returns>
        public static SubscriptionType Get(byte _id, Db db)
        {
            return db.SubscriptionTypeGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="instance">An instance of SubscriptionType to be inserted.</param>
        /// <returns>The inserted SubscriptionType</returns>
        public static SubscriptionType Insert(SubscriptionType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="instance">An instance of SubscriptionType to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted SubscriptionType</returns>
        public static SubscriptionType Insert(SubscriptionType instance, Db db)
        {
            return db.SubscriptionTypeInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(SubscriptionType instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(SubscriptionType instance, Db db)
        {
            db.SubscriptionTypeUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SubscriptionType] table.
        /// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
        public static void Delete(byte _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SubscriptionType] table.
        /// </summary>
		/// <param name="_id">معرف نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(byte _id, Db db)
        {
            db.SubscriptionTypeDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
        /// <returns>A list of SubscriptionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SubscriptionType> GetByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByName(_name, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of SubscriptionType instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<SubscriptionType> GetByName(string _name, Db db)
        {
            return db.SubscriptionTypeGetByName(_name);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
        /// <returns>Gets an instance of SubscriptionType or null.</returns>
        public static SubscriptionType GetByNameFirstOrNull(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByNameFirstOrNull(_name, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of SubscriptionType or null.</returns>
        public static SubscriptionType GetByNameFirstOrNull(string _name, Db db)
        {
            return db.SubscriptionTypeGetByNameFirstOrNull(_name);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
        public static void DeleteByName(string _name)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByName(_name, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Name columns in the  dbo.SubscriptionType table.
        /// </summary>
		/// <param name="_name">بيان نوع الاشتراك</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByName(string _name, Db db)
        {
            db.SubscriptionTypeDeleteByName(_name);
        }
        #endregion
    }
    #endregion

    #region TransitoryIncomingLoanServices
    public static partial class TransitoryIncomingLoanServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoan table.
        /// </summary>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> List(Db db)
        {
            return db.TransitoryIncomingLoanList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan Get(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_employee, db);
        }

        /// <summary>
		/// Gets one row from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan Get(int _employee, Db db)
        {
            return db.TransitoryIncomingLoanGet(_employee);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of TransitoryIncomingLoan to be inserted.</param>
        /// <returns>The inserted TransitoryIncomingLoan</returns>
        public static TransitoryIncomingLoan Insert(TransitoryIncomingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of TransitoryIncomingLoan to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted TransitoryIncomingLoan</returns>
        public static TransitoryIncomingLoan Insert(TransitoryIncomingLoan instance, Db db)
        {
            return db.TransitoryIncomingLoanInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(TransitoryIncomingLoan instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(TransitoryIncomingLoan instance, Db db)
        {
            db.TransitoryIncomingLoanUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void Delete(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_employee, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _employee, Db db)
        {
            db.TransitoryIncomingLoanDelete(_employee);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> GetByIsVerified(bool _isVerified)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsVerified(_isVerified, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> GetByIsVerified(bool _isVerified, Db db)
        {
            return db.TransitoryIncomingLoanGetByIsVerified(_isVerified);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan GetByIsVerifiedFirstOrNull(bool _isVerified)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsVerifiedFirstOrNull(_isVerified, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan GetByIsVerifiedFirstOrNull(bool _isVerified, Db db)
        {
            return db.TransitoryIncomingLoanGetByIsVerifiedFirstOrNull(_isVerified);
        }           

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> GetByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlace(_mainWorkPlace, db);
        }
    
        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of TransitoryIncomingLoan instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<TransitoryIncomingLoan> GetByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            return db.TransitoryIncomingLoanGetByMainWorkPlace(_mainWorkPlace);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByMainWorkPlaceFirstOrNull(_mainWorkPlace, db);
        }

        /// <summary>
		/// Gets rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of TransitoryIncomingLoan or null.</returns>
        public static TransitoryIncomingLoan GetByMainWorkPlaceFirstOrNull(int _mainWorkPlace, Db db)
        {
            return db.TransitoryIncomingLoanGetByMainWorkPlaceFirstOrNull(_mainWorkPlace);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
        public static void DeleteByIsVerified(bool _isVerified)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsVerified(_isVerified, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsVerified columns in the  dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_isVerified">الحالة  non:0; verified:1; to be deleted:2</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsVerified(bool _isVerified, Db db)
        {
            db.TransitoryIncomingLoanDeleteByIsVerified(_isVerified);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByMainWorkPlace(_mainWorkPlace, db);
        }

        /// <summary>
		/// Deletes rows related to one MainWorkPlace from the dbo.TransitoryIncomingLoan table.
        /// </summary>
		/// <param name="_mainWorkPlace">الفرع المنقولة منه السلفة</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByMainWorkPlace(int _mainWorkPlace, Db db)
        {
            db.TransitoryIncomingLoanDeleteByMainWorkPlace(_mainWorkPlace);
        }
        #endregion
    }
    #endregion

    #region WarrantServices
    public static partial class WarrantServices
    {
        #region List procedure
        /// <summary>
		/// Selects all rows from the dbo.Warrant table.
        /// </summary>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> List()
        {
            Db db = new Db(DbServices.ConnectionString);
            return List(db);
        }

        /// <summary>
		/// Selects all rows from the dbo.Warrant table.
        /// </summary>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> List(Db db)
        {
            return db.WarrantList();
        }
        #endregion

        #region Get procedure
        /// <summary>
		/// Gets one row from the dbo.Warrant table.
        /// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant Get(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Get(_id, db);
        }

        /// <summary>
		/// Gets one row from the dbo.Warrant table.
        /// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant Get(int _id, Db db)
        {
            return db.WarrantGet(_id);
        }
        #endregion

        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="instance">An instance of Warrant to be inserted.</param>
        /// <returns>The inserted Warrant</returns>
        public static Warrant Insert(Warrant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(instance, db);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="instance">An instance of Warrant to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <returns>The inserted Warrant</returns>
        public static Warrant Insert(Warrant instance, Db db)
        {
            return db.WarrantInsert(instance);
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="instance">An instance of Warrant which identifies the object to be updated, 
        /// and holds its new values.</param>
        public static void Update(Warrant instance)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(instance, db);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="instance">An instance of Warrant which identifies the object to be updated, 
        /// and holds its new values.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        public static void Update(Warrant instance, Db db)
        {
            db.WarrantUpdate(instance);
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Warrant] table.
        /// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
        public static void Delete(int _id)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(_id, db);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Warrant] table.
        /// </summary>
		/// <param name="_id">معرف كفيل المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void Delete(int _id, Db db)
        {
            db.WarrantDelete(_id);
        }
        #endregion
    
        #region Get by procedures
        /// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByDebt(int _debt)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDebt(_debt, db);
        }
    
        /// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByDebt(int _debt, Db db)
        {
            return db.WarrantGetByDebt(_debt);
        }

        /// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByDebtFirstOrNull(int _debt)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDebtFirstOrNull(_debt, db);
        }

        /// <summary>
		/// Gets rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByDebtFirstOrNull(int _debt, Db db)
        {
            return db.WarrantGetByDebtFirstOrNull(_debt);
        }           

        /// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByDebt_Employee(int _debt, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDebt_Employee(_debt, _employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByDebt_Employee(int _debt, int _employee, Db db)
        {
            return db.WarrantGetByDebt_Employee(_debt, _employee);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByDebt_EmployeeFirstOrNull(int _debt, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByDebt_EmployeeFirstOrNull(_debt, _employee, db);
        }

        /// <summary>
		/// Gets rows related to one  combination of (Debt, Employee) columns  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByDebt_EmployeeFirstOrNull(int _debt, int _employee, Db db)
        {
            return db.WarrantGetByDebt_EmployeeFirstOrNull(_debt, _employee);
        }           

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployee(_employee, db);
        }
    
        /// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByEmployee(int _employee, Db db)
        {
            return db.WarrantGetByEmployee(_employee);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByEmployeeFirstOrNull(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByEmployeeFirstOrNull(_employee, db);
        }

        /// <summary>
		/// Gets rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByEmployeeFirstOrNull(int _employee, Db db)
        {
            return db.WarrantGetByEmployeeFirstOrNull(_employee);
        }           

        /// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActive(_isActive, db);
        }
    
        /// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>A list of Warrant instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Warrant> GetByIsActive(bool _isActive, Db db)
        {
            return db.WarrantGetByIsActive(_isActive);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByIsActiveFirstOrNull(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetByIsActiveFirstOrNull(_isActive, db);
        }

        /// <summary>
		/// Gets rows related to one  in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        /// <returns>Gets an instance of Warrant or null.</returns>
        public static Warrant GetByIsActiveFirstOrNull(bool _isActive, Db db)
        {
            return db.WarrantGetByIsActiveFirstOrNull(_isActive);
        }       
        #endregion

        #region Delete by procedures
        /// <summary>
		/// Deletes rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
        public static void DeleteByDebt(int _debt)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDebt(_debt, db);
        }

        /// <summary>
		/// Deletes rows related to one Debt from the dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDebt(int _debt, Db db)
        {
            db.WarrantDeleteByDebt(_debt);
        }

        /// <summary>
		/// Deletes rows related to one combination of Debt, Employee columns in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByDebt_Employee(int _debt, int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByDebt_Employee(_debt, _employee, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of Debt, Employee columns in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_debt">معرف المديونية</param>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByDebt_Employee(int _debt, int _employee, Db db)
        {
            db.WarrantDeleteByDebt_Employee(_debt, _employee);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
        public static void DeleteByEmployee(int _employee)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByEmployee(_employee, db);
        }

        /// <summary>
		/// Deletes rows related to one Employee from the dbo.Warrant table.
        /// </summary>
		/// <param name="_employee">الرقم الذاتي</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByEmployee(int _employee, Db db)
        {
            db.WarrantDeleteByEmployee(_employee);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
        public static void DeleteByIsActive(bool _isActive)
        {
            Db db = new Db(DbServices.ConnectionString);
            DeleteByIsActive(_isActive, db);
        }

        /// <summary>
		/// Deletes rows related to one combination of IsActive columns in the  dbo.Warrant table.
        /// </summary>
		/// <param name="_isActive">الكفالة فعالة؟</param>
		///<param name="db">Db object on which the command will be executed</param>
        public static void DeleteByIsActive(bool _isActive, Db db)
        {
            db.WarrantDeleteByIsActive(_isActive);
        }
        #endregion
    }
    #endregion
}
