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
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Availability which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Availability Insert(int user, Availability instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Availability which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Availability Insert(int user, Availability instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                AvailabilityVw view = AvailabilityVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Insert, new AvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Insert, new AvailabilityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Availability", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Availability which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Availability instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Availability which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Availability instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                AvailabilityVw view = AvailabilityVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Update, new AvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Update, new AvailabilityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Availability", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القاعدة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Availability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القاعدة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, Db db, ILogErrorHandler handler = null)
        {
            AvailabilityVw view = AvailabilityVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Delete, new AvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Availability, (int)EventSourceEnum.Availability, (int)EventStatusEnum.Delete, new AvailabilityVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Availability", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region AvailabilityCeilingServices
    public static partial class AvailabilityCeilingServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static AvailabilityCeiling Insert(int user, AvailabilityCeiling instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static AvailabilityCeiling Insert(int user, AvailabilityCeiling instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                AvailabilityCeilingVw view = AvailabilityCeilingVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Insert, new AvailabilityCeilingVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Insert, new AvailabilityCeilingVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "AvailabilityCeiling", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, AvailabilityCeiling instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of AvailabilityCeiling which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, AvailabilityCeiling instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                AvailabilityCeilingVw view = AvailabilityCeilingVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Update, new AvailabilityCeilingVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Update, new AvailabilityCeilingVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "AvailabilityCeiling", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السقف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[AvailabilityCeiling] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السقف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, Db db, ILogErrorHandler handler = null)
        {
            AvailabilityCeilingVw view = AvailabilityCeilingVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Delete, new AvailabilityCeilingVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.AvailabilityCeiling, (int)EventSourceEnum.AvailabilityCeiling, (int)EventStatusEnum.Delete, new AvailabilityCeilingVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "AvailabilityCeiling", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region BypassStatusServices
    public static partial class BypassStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static BypassStatus Insert(int user, BypassStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static BypassStatus Insert(int user, BypassStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                BypassStatusVw view = BypassStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Insert, new BypassStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Insert, new BypassStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "BypassStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, BypassStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of BypassStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, BypassStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                BypassStatusVw view = BypassStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Update, new BypassStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Update, new BypassStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "BypassStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الحالة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[BypassStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الحالة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            BypassStatusVw view = BypassStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Delete, new BypassStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.BypassStatus, (int)EventSourceEnum.BypassStatus, (int)EventStatusEnum.Delete, new BypassStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "BypassStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region CashPaymentServices
    public static partial class CashPaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of CashPayment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static CashPayment Insert(int user, CashPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of CashPayment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static CashPayment Insert(int user, CashPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                CashPaymentVw view = CashPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Insert, new CashPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Insert, new CashPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CashPayment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of CashPayment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, CashPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of CashPayment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, CashPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                CashPaymentVw view = CashPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Update, new CashPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Update, new CashPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CashPayment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف الدفعة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _payment, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[CashPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف الدفعة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, Db db, ILogErrorHandler handler = null)
        {
            CashPaymentVw view = CashPaymentVwServices.Get(_payment, db);
            try
            {
                Delete(_payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Delete, new CashPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CashPayment, (int)EventSourceEnum.CashPayment, (int)EventStatusEnum.Delete, new CashPaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CashPayment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region CategoryServices
    public static partial class CategoryServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Category which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Category Insert(int user, Category instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Category which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Category Insert(int user, Category instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                CategoryVw view = CategoryVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Insert, new CategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Insert, new CategoryVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Category", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Category which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Category instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Category which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Category instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                CategoryVw view = CategoryVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Update, new CategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Update, new CategoryVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Category", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الهيئة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Category] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الهيئة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            CategoryVw view = CategoryVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Delete, new CategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Category, (int)EventSourceEnum.Category, (int)EventStatusEnum.Delete, new CategoryVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Category", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region CollectOrderServices
    public static partial class CollectOrderServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static CollectOrder Insert(int user, CollectOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static CollectOrder Insert(int user, CollectOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                CollectOrderVw view = CollectOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Insert, new CollectOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Insert, new CollectOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CollectOrder", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, CollectOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of CollectOrder which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, CollectOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                CollectOrderVw view = CollectOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Update, new CollectOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Update, new CollectOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CollectOrder", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر القبض</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[CollectOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر القبض</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            CollectOrderVw view = CollectOrderVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Delete, new CollectOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.CollectOrder, (int)EventSourceEnum.CollectOrder, (int)EventStatusEnum.Delete, new CollectOrderVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "CollectOrder", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region DebtServices
    public static partial class DebtServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Debt which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Debt Insert(int user, Debt instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Debt which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Debt Insert(int user, Debt instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                DebtVw view = DebtVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Insert, new DebtVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Insert, new DebtVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Debt", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Debt which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Debt instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Debt which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Debt instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                DebtVw view = DebtVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Update, new DebtVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Update, new DebtVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Debt", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Debt] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            DebtVw view = DebtVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Delete, new DebtVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Debt, (int)EventSourceEnum.Debt, (int)EventStatusEnum.Delete, new DebtVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Debt", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region DepartmentServices
    public static partial class DepartmentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Department which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Department Insert(int user, Department instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Department which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Department Insert(int user, Department instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                DepartmentVw view = DepartmentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Insert, new DepartmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Insert, new DepartmentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Department", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Department which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Department instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Department which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Department instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                DepartmentVw view = DepartmentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Update, new DepartmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Update, new DepartmentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Department", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الفعالية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Department] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الفعالية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            DepartmentVw view = DepartmentVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Delete, new DepartmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Delete, new DepartmentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Department", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region DownPaymentServices
    public static partial class DownPaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of DownPayment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static DownPayment Insert(int user, DownPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of DownPayment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static DownPayment Insert(int user, DownPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                DownPaymentVw view = DownPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Insert, new DownPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Insert, new DownPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "DownPayment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of DownPayment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, DownPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of DownPayment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, DownPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                DownPaymentVw view = DownPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Update, new DownPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Update, new DownPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "DownPayment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف الدفعة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _payment, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[DownPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف الدفعة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, Db db, ILogErrorHandler handler = null)
        {
            DownPaymentVw view = DownPaymentVwServices.Get(_payment, db);
            try
            {
                Delete(_payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Delete, new DownPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.DownPayment, (int)EventSourceEnum.DownPayment, (int)EventStatusEnum.Delete, new DownPaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "DownPayment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EmployeeServices
    public static partial class EmployeeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Employee which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Employee Insert(int user, Employee instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Employee which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Employee Insert(int user, Employee instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EmployeeVw view = EmployeeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Insert, new EmployeeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Insert, new EmployeeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Employee", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Employee which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Employee instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Employee which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Employee instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EmployeeVw view = EmployeeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Update, new EmployeeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Update, new EmployeeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Employee", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Employee] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            EmployeeVw view = EmployeeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Delete, new EmployeeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Employee, (int)EventSourceEnum.Employee, (int)EventStatusEnum.Delete, new EmployeeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Employee", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EmployeeSeniorityServices
    public static partial class EmployeeSeniorityServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EmployeeSeniority Insert(int user, EmployeeSeniority instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EmployeeSeniority Insert(int user, EmployeeSeniority instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EmployeeSeniorityVw view = EmployeeSeniorityVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Insert, new EmployeeSeniorityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Insert, new EmployeeSeniorityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeSeniority", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EmployeeSeniority instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EmployeeSeniority which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EmployeeSeniority instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EmployeeSeniorityVw view = EmployeeSeniorityVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Update, new EmployeeSeniorityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Update, new EmployeeSeniorityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeSeniority", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _employee, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeSeniority] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, Db db, ILogErrorHandler handler = null)
        {
            EmployeeSeniorityVw view = EmployeeSeniorityVwServices.Get(_employee, db);
            try
            {
                Delete(_employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Delete, new EmployeeSeniorityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeSeniority, (int)EventSourceEnum.EmployeeSeniority, (int)EventStatusEnum.Delete, new EmployeeSeniorityVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeSeniority", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EmployeeStatusServices
    public static partial class EmployeeStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EmployeeStatus Insert(int user, EmployeeStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EmployeeStatus Insert(int user, EmployeeStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EmployeeStatusVw view = EmployeeStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Insert, new EmployeeStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Insert, new EmployeeStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EmployeeStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EmployeeStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EmployeeStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EmployeeStatusVw view = EmployeeStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Update, new EmployeeStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Update, new EmployeeStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الوضع الوظيفي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EmployeeStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الوضع الوظيفي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            EmployeeStatusVw view = EmployeeStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Delete, new EmployeeStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EmployeeStatus, (int)EventSourceEnum.EmployeeStatus, (int)EventStatusEnum.Delete, new EmployeeStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EmployeeStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EndWorkGrantBracketServices
    public static partial class EndWorkGrantBracketServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EndWorkGrantBracket Insert(int user, EndWorkGrantBracket instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EndWorkGrantBracket Insert(int user, EndWorkGrantBracket instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EndWorkGrantBracketVw view = EndWorkGrantBracketVwServices.Get(instance.FromYear, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Insert, new EndWorkGrantBracketVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Insert, new EndWorkGrantBracketVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EndWorkGrantBracket", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EndWorkGrantBracket instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EndWorkGrantBracket which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EndWorkGrantBracket instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EndWorkGrantBracketVw view = EndWorkGrantBracketVwServices.Get(instance.FromYear, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Update, new EndWorkGrantBracketVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Update, new EndWorkGrantBracketVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EndWorkGrantBracket", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_fromYear">من سنة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _fromYear, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _fromYear, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EndWorkGrantBracket] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_fromYear">من سنة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _fromYear, Db db, ILogErrorHandler handler = null)
        {
            EndWorkGrantBracketVw view = EndWorkGrantBracketVwServices.Get(_fromYear, db);
            try
            {
                Delete(_fromYear, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Delete, new EndWorkGrantBracketVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EndWorkGrantBracket, (int)EventSourceEnum.EndWorkGrantBracket, (int)EventStatusEnum.Delete, new EndWorkGrantBracketVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EndWorkGrantBracket", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ErrorDefinitionServices
    public static partial class ErrorDefinitionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ErrorDefinition Insert(int user, ErrorDefinition instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ErrorDefinition Insert(int user, ErrorDefinition instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ErrorDefinitionVw view = ErrorDefinitionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Insert, new ErrorDefinitionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Insert, new ErrorDefinitionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ErrorDefinition", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ErrorDefinition instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ErrorDefinition which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ErrorDefinition instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ErrorDefinitionVw view = ErrorDefinitionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Update, new ErrorDefinitionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Update, new ErrorDefinitionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ErrorDefinition", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">ErrorDefinition identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ErrorDefinition] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">ErrorDefinition identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ErrorDefinitionVw view = ErrorDefinitionVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Delete, new ErrorDefinitionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ErrorDefinition, (int)EventSourceEnum.ErrorDefinition, (int)EventStatusEnum.Delete, new ErrorDefinitionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ErrorDefinition", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EventCategoryServices
    public static partial class EventCategoryServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventCategory which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventCategory Insert(int user, EventCategory instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventCategory which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventCategory Insert(int user, EventCategory instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EventCategoryVw view = EventCategoryVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Insert, new EventCategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Insert, new EventCategoryVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventCategory", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventCategory which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventCategory instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventCategory which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventCategory instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EventCategoryVw view = EventCategoryVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Update, new EventCategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Update, new EventCategoryVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventCategory", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventCategory identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventCategory] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventCategory identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            EventCategoryVw view = EventCategoryVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Delete, new EventCategoryVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventCategory, (int)EventSourceEnum.EventCategory, (int)EventStatusEnum.Delete, new EventCategoryVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventCategory", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EventLogServices
    public static partial class EventLogServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventLog which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventLog Insert(int user, EventLog instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventLog which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventLog Insert(int user, EventLog instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EventLogVw view = EventLogVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Insert, new EventLogVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Insert, new EventLogVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLog", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventLog which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventLog instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventLog which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventLog instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EventLogVw view = EventLogVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Update, new EventLogVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Update, new EventLogVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLog", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventLog identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, long _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventLog] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventLog identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, long _id, Db db, ILogErrorHandler handler = null)
        {
            EventLogVw view = EventLogVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Delete, new EventLogVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLog, (int)EventSourceEnum.EventLog, (int)EventStatusEnum.Delete, new EventLogVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLog", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EventLogErrorServices
    public static partial class EventLogErrorServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventLogError which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventLogError Insert(int user, EventLogError instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventLogError which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventLogError Insert(int user, EventLogError instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EventLogErrorVw view = EventLogErrorVwServices.Get(instance.EventLog, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Insert, new EventLogErrorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Insert, new EventLogErrorVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLogError", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventLogError which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventLogError instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventLogError which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventLogError instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EventLogErrorVw view = EventLogErrorVwServices.Get(instance.EventLog, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Update, new EventLogErrorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Update, new EventLogErrorVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLogError", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_eventLog">EventLog identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, long _eventLog, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _eventLog, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventLogError] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_eventLog">EventLog identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, long _eventLog, Db db, ILogErrorHandler handler = null)
        {
            EventLogErrorVw view = EventLogErrorVwServices.Get(_eventLog, db);
            try
            {
                Delete(_eventLog, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Delete, new EventLogErrorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventLogError, (int)EventSourceEnum.EventLogError, (int)EventStatusEnum.Delete, new EventLogErrorVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventLogError", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EventSourceServices
    public static partial class EventSourceServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventSource which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventSource Insert(int user, EventSource instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventSource which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventSource Insert(int user, EventSource instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EventSourceVw view = EventSourceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Insert, new EventSourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Insert, new EventSourceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventSource", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventSource which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventSource instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventSource which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventSource instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EventSourceVw view = EventSourceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Update, new EventSourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Update, new EventSourceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventSource", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventSource identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventSource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventSource identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            EventSourceVw view = EventSourceVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Delete, new EventSourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventSource, (int)EventSourceEnum.EventSource, (int)EventStatusEnum.Delete, new EventSourceVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventSource", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region EventStatusServices
    public static partial class EventStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventStatus Insert(int user, EventStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of EventStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static EventStatus Insert(int user, EventStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                EventStatusVw view = EventStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Insert, new EventStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Insert, new EventStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of EventStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, EventStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                EventStatusVw view = EventStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Update, new EventStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Update, new EventStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventStatus identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[EventStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">EventStatus identifier</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            EventStatusVw view = EventStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Delete, new EventStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.EventStatus, (int)EventSourceEnum.EventStatus, (int)EventStatusEnum.Delete, new EventStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "EventStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ExceptionalAmountServices
    public static partial class ExceptionalAmountServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExceptionalAmount Insert(int user, ExceptionalAmount instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExceptionalAmount Insert(int user, ExceptionalAmount instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ExceptionalAmountVw view = ExceptionalAmountVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Insert, new ExceptionalAmountVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Insert, new ExceptionalAmountVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmount", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExceptionalAmount instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExceptionalAmount which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExceptionalAmount instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ExceptionalAmountVw view = ExceptionalAmountVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Update, new ExceptionalAmountVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Update, new ExceptionalAmountVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmount", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmount] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المبلغ الاستثنائي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ExceptionalAmountVw view = ExceptionalAmountVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Delete, new ExceptionalAmountVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmount, (int)EventSourceEnum.ExceptionalAmount, (int)EventStatusEnum.Delete, new ExceptionalAmountVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmount", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ExceptionalAmountTypeServices
    public static partial class ExceptionalAmountTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExceptionalAmountType Insert(int user, ExceptionalAmountType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExceptionalAmountType Insert(int user, ExceptionalAmountType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ExceptionalAmountTypeVw view = ExceptionalAmountTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Insert, new ExceptionalAmountTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Insert, new ExceptionalAmountTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmountType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExceptionalAmountType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExceptionalAmountType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExceptionalAmountType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ExceptionalAmountTypeVw view = ExceptionalAmountTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Update, new ExceptionalAmountTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Update, new ExceptionalAmountTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmountType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExceptionalAmountType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع المبلغ الاستثنائي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            ExceptionalAmountTypeVw view = ExceptionalAmountTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Delete, new ExceptionalAmountTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExceptionalAmountType, (int)EventSourceEnum.ExceptionalAmountType, (int)EventStatusEnum.Delete, new ExceptionalAmountTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExceptionalAmountType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ExternalGrantServices
    public static partial class ExternalGrantServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExternalGrant Insert(int user, ExternalGrant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ExternalGrant Insert(int user, ExternalGrant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ExternalGrantVw view = ExternalGrantVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Insert, new ExternalGrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Insert, new ExternalGrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExternalGrant", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExternalGrant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ExternalGrant which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ExternalGrant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ExternalGrantVw view = ExternalGrantVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Update, new ExternalGrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Update, new ExternalGrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExternalGrant", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ExternalGrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ExternalGrantVw view = ExternalGrantVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Delete, new ExternalGrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ExternalGrant, (int)EventSourceEnum.ExternalGrant, (int)EventStatusEnum.Delete, new ExternalGrantVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ExternalGrant", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantServices
    public static partial class GrantServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Grant which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Grant Insert(int user, Grant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Grant which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Grant Insert(int user, Grant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantVw view = GrantVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Insert, new GrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Insert, new GrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Grant", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Grant which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Grant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Grant which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Grant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantVw view = GrantVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Update, new GrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Update, new GrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Grant", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _product, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Grant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, Db db, ILogErrorHandler handler = null)
        {
            GrantVw view = GrantVwServices.Get(_product, db);
            try
            {
                Delete(_product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Delete, new GrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Grant, (int)EventSourceEnum.Grant, (int)EventStatusEnum.Delete, new GrantVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Grant", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantDecisionServices
    public static partial class GrantDecisionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantDecision Insert(int user, GrantDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantDecision Insert(int user, GrantDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantDecisionVw view = GrantDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Insert, new GrantDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Insert, new GrantDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDecision", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantDecision which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantDecisionVw view = GrantDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Update, new GrantDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Update, new GrantDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDecision", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف قرار الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف قرار الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            GrantDecisionVw view = GrantDecisionVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Delete, new GrantDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDecision, (int)EventSourceEnum.GrantDecision, (int)EventStatusEnum.Delete, new GrantDecisionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDecision", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantDeductionServices
    public static partial class GrantDeductionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantDeduction Insert(int user, GrantDeduction instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantDeduction Insert(int user, GrantDeduction instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantDeductionVw view = GrantDeductionVwServices.Get(instance.Grant, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Insert, new GrantDeductionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Insert, new GrantDeductionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDeduction", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantDeduction instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantDeduction which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantDeduction instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantDeductionVw view = GrantDeductionVwServices.Get(instance.Grant, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Update, new GrantDeductionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Update, new GrantDeductionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDeduction", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_grant">معرف الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _grant, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _grant, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantDeduction] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_grant">معرف الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _grant, Db db, ILogErrorHandler handler = null)
        {
            GrantDeductionVw view = GrantDeductionVwServices.Get(_grant, db);
            try
            {
                Delete(_grant, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Delete, new GrantDeductionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantDeduction, (int)EventSourceEnum.GrantDeduction, (int)EventStatusEnum.Delete, new GrantDeductionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantDeduction", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantPaymentServices
    public static partial class GrantPaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantPayment Insert(int user, GrantPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantPayment Insert(int user, GrantPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantPaymentVw view = GrantPaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Insert, new GrantPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Insert, new GrantPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPayment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantPayment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantPaymentVw view = GrantPaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Update, new GrantPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Update, new GrantPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPayment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف دفع الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف دفع الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            GrantPaymentVw view = GrantPaymentVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Delete, new GrantPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPayment, (int)EventSourceEnum.GrantPayment, (int)EventStatusEnum.Delete, new GrantPaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPayment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantPaymentOrderServices
    public static partial class GrantPaymentOrderServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantPaymentOrder Insert(int user, GrantPaymentOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantPaymentOrder Insert(int user, GrantPaymentOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantPaymentOrderVw view = GrantPaymentOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Insert, new GrantPaymentOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Insert, new GrantPaymentOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPaymentOrder", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantPaymentOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantPaymentOrder which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantPaymentOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantPaymentOrderVw view = GrantPaymentOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Update, new GrantPaymentOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Update, new GrantPaymentOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPaymentOrder", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantPaymentOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر دفع الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            GrantPaymentOrderVw view = GrantPaymentOrderVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Delete, new GrantPaymentOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantPaymentOrder, (int)EventSourceEnum.GrantPaymentOrder, (int)EventStatusEnum.Delete, new GrantPaymentOrderVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantPaymentOrder", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantRequestServices
    public static partial class GrantRequestServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantRequest Insert(int user, GrantRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantRequest Insert(int user, GrantRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantRequestVw view = GrantRequestVwServices.Get(instance.Request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Insert, new GrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Insert, new GrantRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantRequest", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantRequest which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantRequestVw view = GrantRequestVwServices.Get(instance.Request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Update, new GrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Update, new GrantRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantRequest", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_request">معرف طلب الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _request, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _request, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_request">معرف طلب الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _request, Db db, ILogErrorHandler handler = null)
        {
            GrantRequestVw view = GrantRequestVwServices.Get(_request, db);
            try
            {
                Delete(_request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Delete, new GrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantRequest, (int)EventSourceEnum.GrantRequest, (int)EventStatusEnum.Delete, new GrantRequestVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantRequest", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantTypeServices
    public static partial class GrantTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantType Insert(int user, GrantType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantType Insert(int user, GrantType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantTypeVw view = GrantTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Insert, new GrantTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Insert, new GrantTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantTypeVw view = GrantTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Update, new GrantTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Update, new GrantTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع الإعانة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            GrantTypeVw view = GrantTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Delete, new GrantTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantType, (int)EventSourceEnum.GrantType, (int)EventStatusEnum.Delete, new GrantTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GrantTypeGroupServices
    public static partial class GrantTypeGroupServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantTypeGroup Insert(int user, GrantTypeGroup instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GrantTypeGroup Insert(int user, GrantTypeGroup instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GrantTypeGroupVw view = GrantTypeGroupVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Insert, new GrantTypeGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Insert, new GrantTypeGroupVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantTypeGroup", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantTypeGroup instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GrantTypeGroup which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GrantTypeGroup instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GrantTypeGroupVw view = GrantTypeGroupVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Update, new GrantTypeGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Update, new GrantTypeGroupVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantTypeGroup", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GrantTypeGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مجموعة أنواع الإعانات</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            GrantTypeGroupVw view = GrantTypeGroupVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Delete, new GrantTypeGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GrantTypeGroup, (int)EventSourceEnum.GrantTypeGroup, (int)EventStatusEnum.Delete, new GrantTypeGroupVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GrantTypeGroup", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GuarantorServices
    public static partial class GuarantorServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Guarantor which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Guarantor Insert(int user, Guarantor instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Guarantor which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Guarantor Insert(int user, Guarantor instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GuarantorVw view = GuarantorVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Insert, new GuarantorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Insert, new GuarantorVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Guarantor", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Guarantor which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Guarantor instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Guarantor which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Guarantor instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GuarantorVw view = GuarantorVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Update, new GuarantorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Update, new GuarantorVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Guarantor", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Guarantor] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            GuarantorVw view = GuarantorVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Delete, new GuarantorVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Guarantor, (int)EventSourceEnum.Guarantor, (int)EventStatusEnum.Delete, new GuarantorVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Guarantor", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GuarantorStatementServices
    public static partial class GuarantorStatementServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GuarantorStatement Insert(int user, GuarantorStatement instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GuarantorStatement Insert(int user, GuarantorStatement instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GuarantorStatementVw view = GuarantorStatementVwServices.Get(instance.Guarantor, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Insert, new GuarantorStatementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Insert, new GuarantorStatementVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatement", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GuarantorStatement instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GuarantorStatement which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GuarantorStatement instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GuarantorStatementVw view = GuarantorStatementVwServices.Get(instance.Guarantor, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Update, new GuarantorStatementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Update, new GuarantorStatementVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatement", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_guarantor">معرف الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _guarantor, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _guarantor, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_guarantor">معرف الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _guarantor, Db db, ILogErrorHandler handler = null)
        {
            GuarantorStatementVw view = GuarantorStatementVwServices.Get(_guarantor, db);
            try
            {
                Delete(_guarantor, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Delete, new GuarantorStatementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatement, (int)EventSourceEnum.GuarantorStatement, (int)EventStatusEnum.Delete, new GuarantorStatementVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatement", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region GuarantorStatusServices
    public static partial class GuarantorStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GuarantorStatus Insert(int user, GuarantorStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static GuarantorStatus Insert(int user, GuarantorStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                GuarantorStatusVw view = GuarantorStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Insert, new GuarantorStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Insert, new GuarantorStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GuarantorStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of GuarantorStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, GuarantorStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                GuarantorStatusVw view = GuarantorStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Update, new GuarantorStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Update, new GuarantorStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[GuarantorStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة الكفيل</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            GuarantorStatusVw view = GuarantorStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Delete, new GuarantorStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.GuarantorStatus, (int)EventSourceEnum.GuarantorStatus, (int)EventStatusEnum.Delete, new GuarantorStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "GuarantorStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region HealthLoanDecisionServices
    public static partial class HealthLoanDecisionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static HealthLoanDecision Insert(int user, HealthLoanDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static HealthLoanDecision Insert(int user, HealthLoanDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                HealthLoanDecisionVw view = HealthLoanDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Insert, new HealthLoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Insert, new HealthLoanDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecision", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, HealthLoanDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of HealthLoanDecision which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, HealthLoanDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                HealthLoanDecisionVw view = HealthLoanDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Update, new HealthLoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Update, new HealthLoanDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecision", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القرار</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القرار</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            HealthLoanDecisionVw view = HealthLoanDecisionVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Delete, new HealthLoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecision, (int)EventSourceEnum.HealthLoanDecision, (int)EventStatusEnum.Delete, new HealthLoanDecisionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecision", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region HealthLoanDecisionFirstPaymentServices
    public static partial class HealthLoanDecisionFirstPaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static HealthLoanDecisionFirstPayment Insert(int user, HealthLoanDecisionFirstPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static HealthLoanDecisionFirstPayment Insert(int user, HealthLoanDecisionFirstPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                HealthLoanDecisionFirstPaymentVw view = HealthLoanDecisionFirstPaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Insert, new HealthLoanDecisionFirstPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Insert, new HealthLoanDecisionFirstPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecisionFirstPayment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, HealthLoanDecisionFirstPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of HealthLoanDecisionFirstPayment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, HealthLoanDecisionFirstPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                HealthLoanDecisionFirstPaymentVw view = HealthLoanDecisionFirstPaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Update, new HealthLoanDecisionFirstPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Update, new HealthLoanDecisionFirstPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecisionFirstPayment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[HealthLoanDecisionFirstPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السلفة العلاجية المسبقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            HealthLoanDecisionFirstPaymentVw view = HealthLoanDecisionFirstPaymentVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Delete, new HealthLoanDecisionFirstPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.HealthLoanDecisionFirstPayment, (int)EventSourceEnum.HealthLoanDecisionFirstPayment, (int)EventStatusEnum.Delete, new HealthLoanDecisionFirstPaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "HealthLoanDecisionFirstPayment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region IncomingLoanServices
    public static partial class IncomingLoanServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static IncomingLoan Insert(int user, IncomingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static IncomingLoan Insert(int user, IncomingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                IncomingLoanVw view = IncomingLoanVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Insert, new IncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Insert, new IncomingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "IncomingLoan", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, IncomingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of IncomingLoan which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, IncomingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                IncomingLoanVw view = IncomingLoanVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Update, new IncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Update, new IncomingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "IncomingLoan", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _loan, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[IncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, Db db, ILogErrorHandler handler = null)
        {
            IncomingLoanVw view = IncomingLoanVwServices.Get(_loan, db);
            try
            {
                Delete(_loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Delete, new IncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.IncomingLoan, (int)EventSourceEnum.IncomingLoan, (int)EventStatusEnum.Delete, new IncomingLoanVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "IncomingLoan", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region InstallmentServices
    public static partial class InstallmentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Installment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Installment Insert(int user, Installment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Installment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Installment Insert(int user, Installment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                InstallmentVw view = InstallmentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Insert, new InstallmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Insert, new InstallmentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Installment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Installment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Installment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Installment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Installment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                InstallmentVw view = InstallmentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Update, new InstallmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Update, new InstallmentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Installment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القسط</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Installment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القسط</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            InstallmentVw view = InstallmentVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Delete, new InstallmentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Installment, (int)EventSourceEnum.Installment, (int)EventStatusEnum.Delete, new InstallmentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Installment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region InstallmentDecreaseServices
    public static partial class InstallmentDecreaseServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InstallmentDecrease Insert(int user, InstallmentDecrease instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InstallmentDecrease Insert(int user, InstallmentDecrease instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                InstallmentDecreaseVw view = InstallmentDecreaseVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Insert, new InstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Insert, new InstallmentDecreaseVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecrease", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InstallmentDecrease instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InstallmentDecrease which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InstallmentDecrease instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                InstallmentDecreaseVw view = InstallmentDecreaseVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Update, new InstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Update, new InstallmentDecreaseVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecrease", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف تخفيض القسط الشهري</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            InstallmentDecreaseVw view = InstallmentDecreaseVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Delete, new InstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecrease, (int)EventSourceEnum.InstallmentDecrease, (int)EventStatusEnum.Delete, new InstallmentDecreaseVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecrease", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region InstallmentDecreaseOrderServices
    public static partial class InstallmentDecreaseOrderServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InstallmentDecreaseOrder Insert(int user, InstallmentDecreaseOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InstallmentDecreaseOrder Insert(int user, InstallmentDecreaseOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                InstallmentDecreaseOrderVw view = InstallmentDecreaseOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Insert, new InstallmentDecreaseOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Insert, new InstallmentDecreaseOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecreaseOrder", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InstallmentDecreaseOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InstallmentDecreaseOrder which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InstallmentDecreaseOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                InstallmentDecreaseOrderVw view = InstallmentDecreaseOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Update, new InstallmentDecreaseOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Update, new InstallmentDecreaseOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecreaseOrder", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">رقم الكتاب الداخلي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InstallmentDecreaseOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">رقم الكتاب الداخلي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            InstallmentDecreaseOrderVw view = InstallmentDecreaseOrderVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Delete, new InstallmentDecreaseOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InstallmentDecreaseOrder, (int)EventSourceEnum.InstallmentDecreaseOrder, (int)EventStatusEnum.Delete, new InstallmentDecreaseOrderVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InstallmentDecreaseOrder", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region InsuranceTypeServices
    public static partial class InsuranceTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InsuranceType Insert(int user, InsuranceType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static InsuranceType Insert(int user, InsuranceType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                InsuranceTypeVw view = InsuranceTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Insert, new InsuranceTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Insert, new InsuranceTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InsuranceType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InsuranceType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of InsuranceType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, InsuranceType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                InsuranceTypeVw view = InsuranceTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Update, new InsuranceTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Update, new InsuranceTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InsuranceType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف طريقة القبض</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[InsuranceType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف طريقة القبض</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            InsuranceTypeVw view = InsuranceTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Delete, new InsuranceTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.InsuranceType, (int)EventSourceEnum.InsuranceType, (int)EventStatusEnum.Delete, new InsuranceTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "InsuranceType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region IssuerServices
    public static partial class IssuerServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Issuer which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Issuer Insert(int user, Issuer instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Issuer which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Issuer Insert(int user, Issuer instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                IssuerVw view = IssuerVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Insert, new IssuerVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Insert, new IssuerVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Issuer", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Issuer which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Issuer instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Issuer which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Issuer instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                IssuerVw view = IssuerVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Update, new IssuerVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Update, new IssuerVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Issuer", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Issuer] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الجهة المصدرة للمديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            IssuerVw view = IssuerVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Delete, new IssuerVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Issuer, (int)EventSourceEnum.Issuer, (int)EventStatusEnum.Delete, new IssuerVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Issuer", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanServices
    public static partial class LoanServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Loan which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Loan Insert(int user, Loan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Loan which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Loan Insert(int user, Loan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanVw view = LoanVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Insert, new LoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Insert, new LoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Loan", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Loan which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Loan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Loan which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Loan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanVw view = LoanVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Update, new LoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Update, new LoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Loan", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _product, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Loan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, Db db, ILogErrorHandler handler = null)
        {
            LoanVw view = LoanVwServices.Get(_product, db);
            try
            {
                Delete(_product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Delete, new LoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Loan, (int)EventSourceEnum.Loan, (int)EventStatusEnum.Delete, new LoanVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Loan", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanChangeServices
    public static partial class LoanChangeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanChange which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanChange Insert(int user, LoanChange instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanChange which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanChange Insert(int user, LoanChange instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanChangeVw view = LoanChangeVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Insert, new LoanChangeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Insert, new LoanChangeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanChange", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanChange which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanChange instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanChange which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanChange instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanChangeVw view = LoanChangeVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Update, new LoanChangeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Update, new LoanChangeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanChange", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _loan, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanChange] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">معرف بطاقة السلفة الجديدة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, Db db, ILogErrorHandler handler = null)
        {
            LoanChangeVw view = LoanChangeVwServices.Get(_loan, db);
            try
            {
                Delete(_loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Delete, new LoanChangeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanChange, (int)EventSourceEnum.LoanChange, (int)EventStatusEnum.Delete, new LoanChangeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanChange", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanDecisionServices
    public static partial class LoanDecisionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanDecision Insert(int user, LoanDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanDecision Insert(int user, LoanDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanDecisionVw view = LoanDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Insert, new LoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Insert, new LoanDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecision", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanDecision instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanDecision which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanDecision instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanDecisionVw view = LoanDecisionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Update, new LoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Update, new LoanDecisionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecision", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف قرار السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecision] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف قرار السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            LoanDecisionVw view = LoanDecisionVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Delete, new LoanDecisionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecision, (int)EventSourceEnum.LoanDecision, (int)EventStatusEnum.Delete, new LoanDecisionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecision", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanDecisionTypeServices
    public static partial class LoanDecisionTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanDecisionType Insert(int user, LoanDecisionType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanDecisionType Insert(int user, LoanDecisionType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanDecisionTypeVw view = LoanDecisionTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Insert, new LoanDecisionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Insert, new LoanDecisionTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecisionType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanDecisionType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanDecisionType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanDecisionType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanDecisionTypeVw view = LoanDecisionTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Update, new LoanDecisionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Update, new LoanDecisionTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecisionType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع قرار السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanDecisionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع قرار السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            LoanDecisionTypeVw view = LoanDecisionTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Delete, new LoanDecisionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanDecisionType, (int)EventSourceEnum.LoanDecisionType, (int)EventStatusEnum.Delete, new LoanDecisionTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanDecisionType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanGenerationStatusServices
    public static partial class LoanGenerationStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanGenerationStatus Insert(int user, LoanGenerationStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanGenerationStatus Insert(int user, LoanGenerationStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanGenerationStatusVw view = LoanGenerationStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Insert, new LoanGenerationStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Insert, new LoanGenerationStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanGenerationStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanGenerationStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanGenerationStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanGenerationStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanGenerationStatusVw view = LoanGenerationStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Update, new LoanGenerationStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Update, new LoanGenerationStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanGenerationStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanGenerationStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة توليد البطاقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            LoanGenerationStatusVw view = LoanGenerationStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Delete, new LoanGenerationStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanGenerationStatus, (int)EventSourceEnum.LoanGenerationStatus, (int)EventStatusEnum.Delete, new LoanGenerationStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanGenerationStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanRequestServices
    public static partial class LoanRequestServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanRequest Insert(int user, LoanRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanRequest Insert(int user, LoanRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanRequestVw view = LoanRequestVwServices.Get(instance.Request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Insert, new LoanRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Insert, new LoanRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanRequest", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanRequest which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanRequestVw view = LoanRequestVwServices.Get(instance.Request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Update, new LoanRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Update, new LoanRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanRequest", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_request">معرف طلب السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _request, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _request, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_request">معرف طلب السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _request, Db db, ILogErrorHandler handler = null)
        {
            LoanRequestVw view = LoanRequestVwServices.Get(_request, db);
            try
            {
                Delete(_request, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Delete, new LoanRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanRequest, (int)EventSourceEnum.LoanRequest, (int)EventStatusEnum.Delete, new LoanRequestVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanRequest", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanStatusServices
    public static partial class LoanStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanStatus Insert(int user, LoanStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanStatus Insert(int user, LoanStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanStatusVw view = LoanStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Insert, new LoanStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Insert, new LoanStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanStatusVw view = LoanStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Update, new LoanStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Update, new LoanStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة البطاقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة البطاقة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            LoanStatusVw view = LoanStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Delete, new LoanStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanStatus, (int)EventSourceEnum.LoanStatus, (int)EventStatusEnum.Delete, new LoanStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanTypeServices
    public static partial class LoanTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanType Insert(int user, LoanType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanType Insert(int user, LoanType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanTypeVw view = LoanTypeVwServices.Get(instance.ProductType, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanType, (int)EventSourceEnum.LoanType, (int)EventStatusEnum.Insert, new LoanTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanType, (int)EventSourceEnum.LoanType, (int)EventStatusEnum.Insert, new LoanTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_productType">معرف نوع السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _productType, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _productType, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_productType">معرف نوع السلفة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _productType, Db db, ILogErrorHandler handler = null)
        {
            LoanTypeVw view = LoanTypeVwServices.Get(_productType, db);
            try
            {
                Delete(_productType, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanType, (int)EventSourceEnum.LoanType, (int)EventStatusEnum.Delete, new LoanTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanType, (int)EventSourceEnum.LoanType, (int)EventStatusEnum.Delete, new LoanTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region LoanTypeClosureServices
    public static partial class LoanTypeClosureServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanTypeClosure Insert(int user, LoanTypeClosure instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static LoanTypeClosure Insert(int user, LoanTypeClosure instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                LoanTypeClosureVw view = LoanTypeClosureVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Insert, new LoanTypeClosureVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Insert, new LoanTypeClosureVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanTypeClosure", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanTypeClosure instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of LoanTypeClosure which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, LoanTypeClosure instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                LoanTypeClosureVw view = LoanTypeClosureVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Update, new LoanTypeClosureVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Update, new LoanTypeClosureVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanTypeClosure", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[LoanTypeClosure] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف آلية إغلاق السلف</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            LoanTypeClosureVw view = LoanTypeClosureVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Delete, new LoanTypeClosureVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.LoanTypeClosure, (int)EventSourceEnum.LoanTypeClosure, (int)EventStatusEnum.Delete, new LoanTypeClosureVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "LoanTypeClosure", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region MainWorkPlaceServices
    public static partial class MainWorkPlaceServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MainWorkPlace Insert(int user, MainWorkPlace instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MainWorkPlace Insert(int user, MainWorkPlace instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                MainWorkPlaceVw view = MainWorkPlaceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Insert, new MainWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Insert, new MainWorkPlaceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MainWorkPlace", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MainWorkPlace instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MainWorkPlace which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MainWorkPlace instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                MainWorkPlaceVw view = MainWorkPlaceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Update, new MainWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Update, new MainWorkPlaceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MainWorkPlace", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MainWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مكان العمل الرئيسي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            MainWorkPlaceVw view = MainWorkPlaceVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Delete, new MainWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MainWorkPlace, (int)EventSourceEnum.MainWorkPlace, (int)EventStatusEnum.Delete, new MainWorkPlaceVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MainWorkPlace", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region MissingInstallmentDecreaseServices
    public static partial class MissingInstallmentDecreaseServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MissingInstallmentDecrease Insert(int user, MissingInstallmentDecrease instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MissingInstallmentDecrease Insert(int user, MissingInstallmentDecrease instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                MissingInstallmentDecreaseVw view = MissingInstallmentDecreaseVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Insert, new MissingInstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Insert, new MissingInstallmentDecreaseVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MissingInstallmentDecrease", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MissingInstallmentDecrease instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MissingInstallmentDecrease which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MissingInstallmentDecrease instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                MissingInstallmentDecreaseVw view = MissingInstallmentDecreaseVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Update, new MissingInstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Update, new MissingInstallmentDecreaseVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MissingInstallmentDecrease", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _employee, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MissingInstallmentDecrease] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي للمشترك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, Db db, ILogErrorHandler handler = null)
        {
            MissingInstallmentDecreaseVw view = MissingInstallmentDecreaseVwServices.Get(_employee, db);
            try
            {
                Delete(_employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Delete, new MissingInstallmentDecreaseVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MissingInstallmentDecrease, (int)EventSourceEnum.MissingInstallmentDecrease, (int)EventStatusEnum.Delete, new MissingInstallmentDecreaseVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MissingInstallmentDecrease", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region MonthlyBalanceServices
    public static partial class MonthlyBalanceServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MonthlyBalance Insert(int user, MonthlyBalance instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static MonthlyBalance Insert(int user, MonthlyBalance instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                MonthlyBalanceVw view = MonthlyBalanceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Insert, new MonthlyBalanceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Insert, new MonthlyBalanceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MonthlyBalance", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MonthlyBalance instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of MonthlyBalance which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, MonthlyBalance instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                MonthlyBalanceVw view = MonthlyBalanceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Update, new MonthlyBalanceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Update, new MonthlyBalanceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MonthlyBalance", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الرصيد الشهري</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[MonthlyBalance] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الرصيد الشهري</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            MonthlyBalanceVw view = MonthlyBalanceVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Delete, new MonthlyBalanceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.MonthlyBalance, (int)EventSourceEnum.MonthlyBalance, (int)EventStatusEnum.Delete, new MonthlyBalanceVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "MonthlyBalance", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region OutgoingLoanServices
    public static partial class OutgoingLoanServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static OutgoingLoan Insert(int user, OutgoingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static OutgoingLoan Insert(int user, OutgoingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                OutgoingLoanVw view = OutgoingLoanVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Insert, new OutgoingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Insert, new OutgoingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "OutgoingLoan", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, OutgoingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of OutgoingLoan which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, OutgoingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                OutgoingLoanVw view = OutgoingLoanVwServices.Get(instance.Loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Update, new OutgoingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Update, new OutgoingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "OutgoingLoan", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _loan, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[OutgoingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_loan">رقم بطاقة السلف المحولة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _loan, Db db, ILogErrorHandler handler = null)
        {
            OutgoingLoanVw view = OutgoingLoanVwServices.Get(_loan, db);
            try
            {
                Delete(_loan, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Delete, new OutgoingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.OutgoingLoan, (int)EventSourceEnum.OutgoingLoan, (int)EventStatusEnum.Delete, new OutgoingLoanVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "OutgoingLoan", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region PaymentServices
    public static partial class PaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Payment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Payment Insert(int user, Payment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Payment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Payment Insert(int user, Payment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                PaymentVw view = PaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Insert, new PaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Insert, new PaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Payment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Payment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Payment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Payment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Payment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                PaymentVw view = PaymentVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Update, new PaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Update, new PaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Payment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حركة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Payment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حركة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            PaymentVw view = PaymentVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Delete, new PaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Payment, (int)EventSourceEnum.Payment, (int)EventStatusEnum.Delete, new PaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Payment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region PaymentGroupServices
    public static partial class PaymentGroupServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PaymentGroup Insert(int user, PaymentGroup instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PaymentGroup Insert(int user, PaymentGroup instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                PaymentGroupVw view = PaymentGroupVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Insert, new PaymentGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Insert, new PaymentGroupVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentGroup", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PaymentGroup instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PaymentGroup which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PaymentGroup instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                PaymentGroupVw view = PaymentGroupVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Update, new PaymentGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Update, new PaymentGroupVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentGroup", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مجموعة الدفع</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PaymentGroup] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف مجموعة الدفع</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            PaymentGroupVw view = PaymentGroupVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Delete, new PaymentGroupVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentGroup, (int)EventSourceEnum.PaymentGroup, (int)EventStatusEnum.Delete, new PaymentGroupVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentGroup", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region PaymentStatusServices
    public static partial class PaymentStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PaymentStatus Insert(int user, PaymentStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PaymentStatus Insert(int user, PaymentStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                PaymentStatusVw view = PaymentStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Insert, new PaymentStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Insert, new PaymentStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PaymentStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PaymentStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PaymentStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                PaymentStatusVw view = PaymentStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Update, new PaymentStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Update, new PaymentStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PaymentStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            PaymentStatusVw view = PaymentStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Delete, new PaymentStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PaymentStatus, (int)EventSourceEnum.PaymentStatus, (int)EventStatusEnum.Delete, new PaymentStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PaymentStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region PayOrderServices
    public static partial class PayOrderServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PayOrder which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PayOrder Insert(int user, PayOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of PayOrder which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static PayOrder Insert(int user, PayOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                PayOrderVw view = PayOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Insert, new PayOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Insert, new PayOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PayOrder", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PayOrder which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PayOrder instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of PayOrder which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, PayOrder instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                PayOrderVw view = PayOrderVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Update, new PayOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Update, new PayOrderVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PayOrder", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر الدفع</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[PayOrder] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف أمر الدفع</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            PayOrderVw view = PayOrderVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Delete, new PayOrderVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.PayOrder, (int)EventSourceEnum.PayOrder, (int)EventStatusEnum.Delete, new PayOrderVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "PayOrder", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ProductServices
    public static partial class ProductServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Product which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Product Insert(int user, Product instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Product which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Product Insert(int user, Product instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ProductVw view = ProductVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Insert, new ProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Insert, new ProductVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Product", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Product which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Product instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Product which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Product instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ProductVw view = ProductVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Update, new ProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Update, new ProductVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Product", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Product] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ProductVw view = ProductVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Delete, new ProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Product, (int)EventSourceEnum.Product, (int)EventStatusEnum.Delete, new ProductVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Product", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ProductTypeServices
    public static partial class ProductTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProductType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProductType Insert(int user, ProductType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProductType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProductType Insert(int user, ProductType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ProductTypeVw view = ProductTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Insert, new ProductTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Insert, new ProductTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProductType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProductType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProductType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProductType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ProductTypeVw view = ProductTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Update, new ProductTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Update, new ProductTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProductType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, short _id, Db db, ILogErrorHandler handler = null)
        {
            ProductTypeVw view = ProductTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Delete, new ProductTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductType, (int)EventSourceEnum.ProductType, (int)EventStatusEnum.Delete, new ProductTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ProductTypeAvailabilityServices
    public static partial class ProductTypeAvailabilityServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProductTypeAvailability Insert(int user, ProductTypeAvailability instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProductTypeAvailability Insert(int user, ProductTypeAvailability instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ProductTypeAvailabilityVw view = ProductTypeAvailabilityVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Insert, new ProductTypeAvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Insert, new ProductTypeAvailabilityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductTypeAvailability", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProductTypeAvailability instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProductTypeAvailability which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProductTypeAvailability instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ProductTypeAvailabilityVw view = ProductTypeAvailabilityVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Update, new ProductTypeAvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Update, new ProductTypeAvailabilityVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductTypeAvailability", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القيد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProductTypeAvailability] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف القيد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ProductTypeAvailabilityVw view = ProductTypeAvailabilityVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Delete, new ProductTypeAvailabilityVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProductTypeAvailability, (int)EventSourceEnum.ProductTypeAvailability, (int)EventStatusEnum.Delete, new ProductTypeAvailabilityVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProductTypeAvailability", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ProfileServices
    public static partial class ProfileServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Profile which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Profile Insert(int user, Profile instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Profile which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Profile Insert(int user, Profile instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ProfileVw view = ProfileVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Insert, new ProfileVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Insert, new ProfileVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Profile", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Profile which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Profile instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Profile which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Profile instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ProfileVw view = ProfileVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Update, new ProfileVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Update, new ProfileVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Profile", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _employee, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Profile] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, Db db, ILogErrorHandler handler = null)
        {
            ProfileVw view = ProfileVwServices.Get(_employee, db);
            try
            {
                Delete(_employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Delete, new ProfileVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Profile, (int)EventSourceEnum.Profile, (int)EventStatusEnum.Delete, new ProfileVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Profile", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ProfitStrategyServices
    public static partial class ProfitStrategyServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProfitStrategy Insert(int user, ProfitStrategy instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ProfitStrategy Insert(int user, ProfitStrategy instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ProfitStrategyVw view = ProfitStrategyVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Insert, new ProfitStrategyVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Insert, new ProfitStrategyVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProfitStrategy", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProfitStrategy instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ProfitStrategy which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ProfitStrategy instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ProfitStrategyVw view = ProfitStrategyVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Update, new ProfitStrategyVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Update, new ProfitStrategyVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProfitStrategy", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ProfitStrategy] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف آلية حساب العوائد الربحية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            ProfitStrategyVw view = ProfitStrategyVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Delete, new ProfitStrategyVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ProfitStrategy, (int)EventSourceEnum.ProfitStrategy, (int)EventStatusEnum.Delete, new ProfitStrategyVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ProfitStrategy", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region RefundableProductServices
    public static partial class RefundableProductServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static RefundableProduct Insert(int user, RefundableProduct instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static RefundableProduct Insert(int user, RefundableProduct instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                RefundableProductVw view = RefundableProductVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Insert, new RefundableProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Insert, new RefundableProductVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RefundableProduct", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, RefundableProduct instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of RefundableProduct which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, RefundableProduct instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                RefundableProductVw view = RefundableProductVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Update, new RefundableProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Update, new RefundableProductVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RefundableProduct", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _product, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[RefundableProduct] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, Db db, ILogErrorHandler handler = null)
        {
            RefundableProductVw view = RefundableProductVwServices.Get(_product, db);
            try
            {
                Delete(_product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Delete, new RefundableProductVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RefundableProduct, (int)EventSourceEnum.RefundableProduct, (int)EventStatusEnum.Delete, new RefundableProductVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RefundableProduct", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region RequestServices
    public static partial class RequestServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Request which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Request Insert(int user, Request instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Request which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Request Insert(int user, Request instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                RequestVw view = RequestVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Insert, new RequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Insert, new RequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Request", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Request which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Request instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Request which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Request instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                RequestVw view = RequestVwServices.Get(instance.Product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Update, new RequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Update, new RequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Request", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _product, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Request] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_product">معرف المنتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _product, Db db, ILogErrorHandler handler = null)
        {
            RequestVw view = RequestVwServices.Get(_product, db);
            try
            {
                Delete(_product, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Delete, new RequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Request, (int)EventSourceEnum.Request, (int)EventStatusEnum.Delete, new RequestVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Request", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region RequestStatusServices
    public static partial class RequestStatusServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static RequestStatus Insert(int user, RequestStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static RequestStatus Insert(int user, RequestStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                RequestStatusVw view = RequestStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Insert, new RequestStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Insert, new RequestStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RequestStatus", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, RequestStatus instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of RequestStatus which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, RequestStatus instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                RequestStatusVw view = RequestStatusVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Update, new RequestStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Update, new RequestStatusVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RequestStatus", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[RequestStatus] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف حالة طلب الحصول على منتج</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            RequestStatusVw view = RequestStatusVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Delete, new RequestStatusVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.RequestStatus, (int)EventSourceEnum.RequestStatus, (int)EventStatusEnum.Delete, new RequestStatusVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "RequestStatus", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ResourceServices
    public static partial class ResourceServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Resource which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Resource Insert(int user, Resource instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Resource which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Resource Insert(int user, Resource instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ResourceVw view = ResourceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Insert, new ResourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Insert, new ResourceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Resource", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Resource which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Resource instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Resource which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Resource instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ResourceVw view = ResourceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Update, new ResourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Update, new ResourceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Resource", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المورد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Resource] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف المورد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            ResourceVw view = ResourceVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Delete, new ResourceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Resource, (int)EventSourceEnum.Resource, (int)EventStatusEnum.Delete, new ResourceVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Resource", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SalaryPaymentServices
    public static partial class SalaryPaymentServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SalaryPayment Insert(int user, SalaryPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SalaryPayment Insert(int user, SalaryPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SalaryPaymentVw view = SalaryPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Insert, new SalaryPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Insert, new SalaryPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryPayment", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SalaryPayment instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SalaryPayment which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SalaryPayment instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SalaryPaymentVw view = SalaryPaymentVwServices.Get(instance.Payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Update, new SalaryPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Update, new SalaryPaymentVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryPayment", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف حركة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _payment, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SalaryPayment] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_payment">معرف حركة السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _payment, Db db, ILogErrorHandler handler = null)
        {
            SalaryPaymentVw view = SalaryPaymentVwServices.Get(_payment, db);
            try
            {
                Delete(_payment, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Delete, new SalaryPaymentVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryPayment, (int)EventSourceEnum.SalaryPayment, (int)EventStatusEnum.Delete, new SalaryPaymentVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryPayment", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SalaryWorkPlaceServices
    public static partial class SalaryWorkPlaceServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SalaryWorkPlace Insert(int user, SalaryWorkPlace instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SalaryWorkPlace Insert(int user, SalaryWorkPlace instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SalaryWorkPlaceVw view = SalaryWorkPlaceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Insert, new SalaryWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Insert, new SalaryWorkPlaceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryWorkPlace", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SalaryWorkPlace instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SalaryWorkPlace which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SalaryWorkPlace instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SalaryWorkPlaceVw view = SalaryWorkPlaceVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Update, new SalaryWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Update, new SalaryWorkPlaceVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryWorkPlace", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف جهة صرف الراتب</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SalaryWorkPlace] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف جهة صرف الراتب</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            SalaryWorkPlaceVw view = SalaryWorkPlaceVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Delete, new SalaryWorkPlaceVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SalaryWorkPlace, (int)EventSourceEnum.SalaryWorkPlace, (int)EventStatusEnum.Delete, new SalaryWorkPlaceVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SalaryWorkPlace", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region ServiceEndGrantRequestServices
    public static partial class ServiceEndGrantRequestServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ServiceEndGrantRequest Insert(int user, ServiceEndGrantRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static ServiceEndGrantRequest Insert(int user, ServiceEndGrantRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                ServiceEndGrantRequestVw view = ServiceEndGrantRequestVwServices.Get(instance.GrantRequest, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Insert, new ServiceEndGrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Insert, new ServiceEndGrantRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ServiceEndGrantRequest", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ServiceEndGrantRequest instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of ServiceEndGrantRequest which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, ServiceEndGrantRequest instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                ServiceEndGrantRequestVw view = ServiceEndGrantRequestVwServices.Get(instance.GrantRequest, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Update, new ServiceEndGrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Update, new ServiceEndGrantRequestVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ServiceEndGrantRequest", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_grantRequest">معرف الطلب</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _grantRequest, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _grantRequest, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[ServiceEndGrantRequest] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_grantRequest">معرف الطلب</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _grantRequest, Db db, ILogErrorHandler handler = null)
        {
            ServiceEndGrantRequestVw view = ServiceEndGrantRequestVwServices.Get(_grantRequest, db);
            try
            {
                Delete(_grantRequest, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Delete, new ServiceEndGrantRequestVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.ServiceEndGrantRequest, (int)EventSourceEnum.ServiceEndGrantRequest, (int)EventStatusEnum.Delete, new ServiceEndGrantRequestVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "ServiceEndGrantRequest", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SettlementServices
    public static partial class SettlementServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Settlement which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Settlement Insert(int user, Settlement instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Settlement which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Settlement Insert(int user, Settlement instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SettlementVw view = SettlementVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Insert, new SettlementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Insert, new SettlementVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Settlement", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Settlement which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Settlement instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Settlement which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Settlement instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SettlementVw view = SettlementVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Update, new SettlementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Update, new SettlementVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Settlement", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Settlement] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السداد</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            SettlementVw view = SettlementVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Delete, new SettlementVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Settlement, (int)EventSourceEnum.Settlement, (int)EventStatusEnum.Delete, new SettlementVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Settlement", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SpecialCaseLoanServices
    public static partial class SpecialCaseLoanServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SpecialCaseLoan Insert(int user, SpecialCaseLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SpecialCaseLoan Insert(int user, SpecialCaseLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SpecialCaseLoanVw view = SpecialCaseLoanVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Insert, new SpecialCaseLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Insert, new SpecialCaseLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SpecialCaseLoan", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SpecialCaseLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SpecialCaseLoan which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SpecialCaseLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SpecialCaseLoanVw view = SpecialCaseLoanVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Update, new SpecialCaseLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Update, new SpecialCaseLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SpecialCaseLoan", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السلفة الخاصة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SpecialCaseLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف السلفة الخاصة</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            SpecialCaseLoanVw view = SpecialCaseLoanVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Delete, new SpecialCaseLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SpecialCaseLoan, (int)EventSourceEnum.SpecialCaseLoan, (int)EventStatusEnum.Delete, new SpecialCaseLoanVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SpecialCaseLoan", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SubscriptionServices
    public static partial class SubscriptionServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Subscription which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Subscription Insert(int user, Subscription instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Subscription which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Subscription Insert(int user, Subscription instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SubscriptionVw view = SubscriptionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Insert, new SubscriptionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Insert, new SubscriptionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Subscription", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Subscription which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Subscription instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Subscription which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Subscription instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SubscriptionVw view = SubscriptionVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Update, new SubscriptionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Update, new SubscriptionVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Subscription", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الاشتراك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Subscription] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف الاشتراك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            SubscriptionVw view = SubscriptionVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Delete, new SubscriptionVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Subscription, (int)EventSourceEnum.Subscription, (int)EventStatusEnum.Delete, new SubscriptionVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Subscription", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region SubscriptionTypeServices
    public static partial class SubscriptionTypeServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SubscriptionType Insert(int user, SubscriptionType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static SubscriptionType Insert(int user, SubscriptionType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                SubscriptionTypeVw view = SubscriptionTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Insert, new SubscriptionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Insert, new SubscriptionTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SubscriptionType", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SubscriptionType instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of SubscriptionType which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, SubscriptionType instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                SubscriptionTypeVw view = SubscriptionTypeVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Update, new SubscriptionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Update, new SubscriptionTypeVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SubscriptionType", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع الاشتراك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[SubscriptionType] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف نوع الاشتراك</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, byte _id, Db db, ILogErrorHandler handler = null)
        {
            SubscriptionTypeVw view = SubscriptionTypeVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Delete, new SubscriptionTypeVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.SubscriptionType, (int)EventSourceEnum.SubscriptionType, (int)EventStatusEnum.Delete, new SubscriptionTypeVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "SubscriptionType", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region TransitoryIncomingLoanServices
    public static partial class TransitoryIncomingLoanServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static TransitoryIncomingLoan Insert(int user, TransitoryIncomingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static TransitoryIncomingLoan Insert(int user, TransitoryIncomingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                TransitoryIncomingLoanVw view = TransitoryIncomingLoanVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Insert, new TransitoryIncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Insert, new TransitoryIncomingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "TransitoryIncomingLoan", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, TransitoryIncomingLoan instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of TransitoryIncomingLoan which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, TransitoryIncomingLoan instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                TransitoryIncomingLoanVw view = TransitoryIncomingLoanVwServices.Get(instance.Employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Update, new TransitoryIncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Update, new TransitoryIncomingLoanVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "TransitoryIncomingLoan", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _employee, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[TransitoryIncomingLoan] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_employee">الرقم الذاتي</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _employee, Db db, ILogErrorHandler handler = null)
        {
            TransitoryIncomingLoanVw view = TransitoryIncomingLoanVwServices.Get(_employee, db);
            try
            {
                Delete(_employee, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Delete, new TransitoryIncomingLoanVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.TransitoryIncomingLoan, (int)EventSourceEnum.TransitoryIncomingLoan, (int)EventStatusEnum.Delete, new TransitoryIncomingLoanVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "TransitoryIncomingLoan", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion

    #region WarrantServices
    public static partial class WarrantServices
    {
        #region Insert procedure
        /// <summary>
		/// Inserts one row into the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Warrant which identifies the object to be inserted,
        /// and holds its new values.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Warrant Insert(int user, Warrant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            return Insert(user, instance, db, handler);
        }

        /// <summary>
		/// Inserts one row into the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the insertion</param>
        /// <param name="instance">An instance of Warrant which identifies the object to be inserted.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static Warrant Insert(int user, Warrant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                instance = Insert(instance, db);
                WarrantVw view = WarrantVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Insert, new WarrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Insert, new WarrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Warrant", db);
				else
					throw ex;
            }
            return instance;
        }
        #endregion

        #region Update procedure
        /// <summary>
		/// Updates one row in the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Warrant which identifies the object to be updated</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Warrant instance, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Update(user, instance, db, handler);
        }

        /// <summary>
		/// Updates one row in the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the update</param>
        /// <param name="instance">An instance of Warrant which identifies the object to be updated.</param>
        /// <param name="db">Db object on which the command will be executed.</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Update(int user, Warrant instance, Db db, ILogErrorHandler handler = null)
        {
            try
            {
                Update(instance, db);
                WarrantVw view = WarrantVwServices.Get(instance.Id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Update, new WarrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Update, new WarrantVwXmlFormatter(instance), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Warrant", db);
				else
					throw ex;
            }
        }
        #endregion

        #region Delete procedure
        /// <summary>
		/// Deletes one row from the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف كفيل المديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, ILogErrorHandler handler = null)
        {
            Db db = new Db(DbServices.ConnectionString);
            Delete(user, _id, db, handler);
        }

        /// <summary>
		/// Deletes one row from the [dbo].[Warrant] table.
        /// </summary>
        /// <param name="user">Identifier of the user who tries to execute the deletion</param>
        /// <param name="db">Db object on which the command will be executed.</param>
		/// <param name="_id">معرف كفيل المديونية</param>
        /// <param name="handler">An object that implements the ILogErrorHandler interface to handle EventLog insert failure.
        /// If the handler is null, the DefaultLogErrorHandler is called.</param>
        public static void Delete(int user, int _id, Db db, ILogErrorHandler handler = null)
        {
            WarrantVw view = WarrantVwServices.Get(_id, db);
            try
            {
                Delete(_id, db);
                DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Delete, new WarrantVwXmlFormatter(view), handler);
            }
            catch(Exception ex)
            {
                EventLog eventLog = DbServices.Log(user, db, (int)EventCategoryEnum.Warrant, (int)EventSourceEnum.Warrant, (int)EventStatusEnum.Delete, new WarrantVwXmlFormatter(view), handler);
                if (eventLog != null)
                    throw DbServices.LogError(eventLog, ex, "Warrant", db);
                else
					throw ex;
            }
        }
        #endregion
    }
    #endregion
}
