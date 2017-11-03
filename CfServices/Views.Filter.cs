using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilder;
using Cf.Data;

namespace Cf.Services
{
    #region CashPaymentVwServices
    public static partial class CashPaymentVwServices
    {
		public static List<CashPaymentVw> Get(CashPaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<CashPaymentVw> Get(CashPaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<CashPaymentVw> GetPage(CashPaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<CashPaymentVw> GetPage(CashPaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(CashPaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(CashPaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region CollectOrderVwServices
    public static partial class CollectOrderVwServices
    {
		public static List<CollectOrderVw> Get(CollectOrderVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<CollectOrderVw> Get(CollectOrderVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<CollectOrderVw> GetPage(CollectOrderVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<CollectOrderVw> GetPage(CollectOrderVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(CollectOrderVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(CollectOrderVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region DebtVwServices
    public static partial class DebtVwServices
    {
		public static List<DebtVw> Get(DebtVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<DebtVw> Get(DebtVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<DebtVw> GetPage(DebtVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<DebtVw> GetPage(DebtVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(DebtVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(DebtVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region DepartmentVwServices
    public static partial class DepartmentVwServices
    {
		public static List<DepartmentVw> Get(DepartmentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<DepartmentVw> Get(DepartmentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<DepartmentVw> GetPage(DepartmentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<DepartmentVw> GetPage(DepartmentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(DepartmentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(DepartmentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region DownPaymentVwServices
    public static partial class DownPaymentVwServices
    {
		public static List<DownPaymentVw> Get(DownPaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<DownPaymentVw> Get(DownPaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<DownPaymentVw> GetPage(DownPaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<DownPaymentVw> GetPage(DownPaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(DownPaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(DownPaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region EmployeeVwServices
    public static partial class EmployeeVwServices
    {
		public static List<EmployeeVw> Get(EmployeeVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<EmployeeVw> Get(EmployeeVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<EmployeeVw> GetPage(EmployeeVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<EmployeeVw> GetPage(EmployeeVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(EmployeeVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(EmployeeVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region ErrorDefinitionVwServices
    public static partial class ErrorDefinitionVwServices
    {
		public static List<ErrorDefinitionVw> Get(ErrorDefinitionVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<ErrorDefinitionVw> Get(ErrorDefinitionVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<ErrorDefinitionVw> GetPage(ErrorDefinitionVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<ErrorDefinitionVw> GetPage(ErrorDefinitionVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(ErrorDefinitionVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(ErrorDefinitionVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region EventCategoryVwServices
    public static partial class EventCategoryVwServices
    {
		public static List<EventCategoryVw> Get(EventCategoryVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<EventCategoryVw> Get(EventCategoryVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<EventCategoryVw> GetPage(EventCategoryVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<EventCategoryVw> GetPage(EventCategoryVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(EventCategoryVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(EventCategoryVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region EventLogErrorVwServices
    public static partial class EventLogErrorVwServices
    {
		public static List<EventLogErrorVw> Get(EventLogErrorVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<EventLogErrorVw> Get(EventLogErrorVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<EventLogErrorVw> GetPage(EventLogErrorVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<EventLogErrorVw> GetPage(EventLogErrorVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(EventLogErrorVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(EventLogErrorVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region EventLogVwServices
    public static partial class EventLogVwServices
    {
		public static List<EventLogVw> Get(EventLogVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<EventLogVw> Get(EventLogVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<EventLogVw> GetPage(EventLogVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<EventLogVw> GetPage(EventLogVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(EventLogVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(EventLogVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region ExternalGrantVwServices
    public static partial class ExternalGrantVwServices
    {
		public static List<ExternalGrantVw> Get(ExternalGrantVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<ExternalGrantVw> Get(ExternalGrantVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<ExternalGrantVw> GetPage(ExternalGrantVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<ExternalGrantVw> GetPage(ExternalGrantVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(ExternalGrantVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(ExternalGrantVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GrantDecisionVwServices
    public static partial class GrantDecisionVwServices
    {
		public static List<GrantDecisionVw> Get(GrantDecisionVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GrantDecisionVw> Get(GrantDecisionVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GrantDecisionVw> GetPage(GrantDecisionVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GrantDecisionVw> GetPage(GrantDecisionVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GrantDecisionVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GrantDecisionVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GrantPaymentOrderVwServices
    public static partial class GrantPaymentOrderVwServices
    {
		public static List<GrantPaymentOrderVw> Get(GrantPaymentOrderVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GrantPaymentOrderVw> Get(GrantPaymentOrderVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GrantPaymentOrderVw> GetPage(GrantPaymentOrderVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GrantPaymentOrderVw> GetPage(GrantPaymentOrderVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GrantPaymentOrderVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GrantPaymentOrderVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GrantPaymentVwServices
    public static partial class GrantPaymentVwServices
    {
		public static List<GrantPaymentVw> Get(GrantPaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GrantPaymentVw> Get(GrantPaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GrantPaymentVw> GetPage(GrantPaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GrantPaymentVw> GetPage(GrantPaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GrantPaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GrantPaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GrantRequestVwServices
    public static partial class GrantRequestVwServices
    {
		public static List<GrantRequestVw> Get(GrantRequestVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GrantRequestVw> Get(GrantRequestVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GrantRequestVw> GetPage(GrantRequestVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GrantRequestVw> GetPage(GrantRequestVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GrantRequestVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GrantRequestVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GrantVwServices
    public static partial class GrantVwServices
    {
		public static List<GrantVw> Get(GrantVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GrantVw> Get(GrantVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GrantVw> GetPage(GrantVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GrantVw> GetPage(GrantVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GrantVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GrantVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region GuarantorVwServices
    public static partial class GuarantorVwServices
    {
		public static List<GuarantorVw> Get(GuarantorVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<GuarantorVw> Get(GuarantorVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<GuarantorVw> GetPage(GuarantorVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<GuarantorVw> GetPage(GuarantorVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(GuarantorVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(GuarantorVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region HealthLoanDecisionFirstPaymentVwServices
    public static partial class HealthLoanDecisionFirstPaymentVwServices
    {
		public static List<HealthLoanDecisionFirstPaymentVw> Get(HealthLoanDecisionFirstPaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<HealthLoanDecisionFirstPaymentVw> Get(HealthLoanDecisionFirstPaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<HealthLoanDecisionFirstPaymentVw> GetPage(HealthLoanDecisionFirstPaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<HealthLoanDecisionFirstPaymentVw> GetPage(HealthLoanDecisionFirstPaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(HealthLoanDecisionFirstPaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(HealthLoanDecisionFirstPaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region HealthLoanDecisionVwServices
    public static partial class HealthLoanDecisionVwServices
    {
		public static List<HealthLoanDecisionVw> Get(HealthLoanDecisionVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<HealthLoanDecisionVw> Get(HealthLoanDecisionVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<HealthLoanDecisionVw> GetPage(HealthLoanDecisionVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<HealthLoanDecisionVw> GetPage(HealthLoanDecisionVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(HealthLoanDecisionVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(HealthLoanDecisionVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region IncomingLoanVwServices
    public static partial class IncomingLoanVwServices
    {
		public static List<IncomingLoanVw> Get(IncomingLoanVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<IncomingLoanVw> Get(IncomingLoanVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<IncomingLoanVw> GetPage(IncomingLoanVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<IncomingLoanVw> GetPage(IncomingLoanVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(IncomingLoanVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(IncomingLoanVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region InstallmentDecreaseOrderVwServices
    public static partial class InstallmentDecreaseOrderVwServices
    {
		public static List<InstallmentDecreaseOrderVw> Get(InstallmentDecreaseOrderVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<InstallmentDecreaseOrderVw> Get(InstallmentDecreaseOrderVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<InstallmentDecreaseOrderVw> GetPage(InstallmentDecreaseOrderVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<InstallmentDecreaseOrderVw> GetPage(InstallmentDecreaseOrderVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(InstallmentDecreaseOrderVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(InstallmentDecreaseOrderVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region InstallmentDecreaseVwServices
    public static partial class InstallmentDecreaseVwServices
    {
		public static List<InstallmentDecreaseVw> Get(InstallmentDecreaseVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<InstallmentDecreaseVw> Get(InstallmentDecreaseVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<InstallmentDecreaseVw> GetPage(InstallmentDecreaseVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<InstallmentDecreaseVw> GetPage(InstallmentDecreaseVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(InstallmentDecreaseVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(InstallmentDecreaseVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region InstallmentVwServices
    public static partial class InstallmentVwServices
    {
		public static List<InstallmentVw> Get(InstallmentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<InstallmentVw> Get(InstallmentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<InstallmentVw> GetPage(InstallmentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<InstallmentVw> GetPage(InstallmentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(InstallmentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(InstallmentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region LoanChangeVwServices
    public static partial class LoanChangeVwServices
    {
		public static List<LoanChangeVw> Get(LoanChangeVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<LoanChangeVw> Get(LoanChangeVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<LoanChangeVw> GetPage(LoanChangeVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<LoanChangeVw> GetPage(LoanChangeVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(LoanChangeVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(LoanChangeVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region LoanDecisionVwServices
    public static partial class LoanDecisionVwServices
    {
		public static List<LoanDecisionVw> Get(LoanDecisionVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<LoanDecisionVw> Get(LoanDecisionVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<LoanDecisionVw> GetPage(LoanDecisionVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<LoanDecisionVw> GetPage(LoanDecisionVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(LoanDecisionVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(LoanDecisionVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region LoanRequestVwServices
    public static partial class LoanRequestVwServices
    {
		public static List<LoanRequestVw> Get(LoanRequestVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<LoanRequestVw> Get(LoanRequestVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<LoanRequestVw> GetPage(LoanRequestVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<LoanRequestVw> GetPage(LoanRequestVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(LoanRequestVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(LoanRequestVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region LoanTypeVwServices
    public static partial class LoanTypeVwServices
    {
		public static List<LoanTypeVw> Get(LoanTypeVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<LoanTypeVw> Get(LoanTypeVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<LoanTypeVw> GetPage(LoanTypeVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<LoanTypeVw> GetPage(LoanTypeVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(LoanTypeVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(LoanTypeVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region LoanVwServices
    public static partial class LoanVwServices
    {
		public static List<LoanVw> Get(LoanVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<LoanVw> Get(LoanVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<LoanVw> GetPage(LoanVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<LoanVw> GetPage(LoanVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(LoanVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(LoanVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region MissingInstallmentDecreaseVwServices
    public static partial class MissingInstallmentDecreaseVwServices
    {
		public static List<MissingInstallmentDecreaseVw> Get(MissingInstallmentDecreaseVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<MissingInstallmentDecreaseVw> Get(MissingInstallmentDecreaseVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<MissingInstallmentDecreaseVw> GetPage(MissingInstallmentDecreaseVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<MissingInstallmentDecreaseVw> GetPage(MissingInstallmentDecreaseVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(MissingInstallmentDecreaseVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(MissingInstallmentDecreaseVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region MonthlyBalanceVwServices
    public static partial class MonthlyBalanceVwServices
    {
		public static List<MonthlyBalanceVw> Get(MonthlyBalanceVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<MonthlyBalanceVw> Get(MonthlyBalanceVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<MonthlyBalanceVw> GetPage(MonthlyBalanceVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<MonthlyBalanceVw> GetPage(MonthlyBalanceVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(MonthlyBalanceVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(MonthlyBalanceVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region OutgoingLoanVwServices
    public static partial class OutgoingLoanVwServices
    {
		public static List<OutgoingLoanVw> Get(OutgoingLoanVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<OutgoingLoanVw> Get(OutgoingLoanVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<OutgoingLoanVw> GetPage(OutgoingLoanVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<OutgoingLoanVw> GetPage(OutgoingLoanVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(OutgoingLoanVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(OutgoingLoanVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region PaymentVwServices
    public static partial class PaymentVwServices
    {
		public static List<PaymentVw> Get(PaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<PaymentVw> Get(PaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<PaymentVw> GetPage(PaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<PaymentVw> GetPage(PaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(PaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(PaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region PayOrderVwServices
    public static partial class PayOrderVwServices
    {
		public static List<PayOrderVw> Get(PayOrderVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<PayOrderVw> Get(PayOrderVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<PayOrderVw> GetPage(PayOrderVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<PayOrderVw> GetPage(PayOrderVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(PayOrderVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(PayOrderVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region ProductVwServices
    public static partial class ProductVwServices
    {
		public static List<ProductVw> Get(ProductVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<ProductVw> Get(ProductVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<ProductVw> GetPage(ProductVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<ProductVw> GetPage(ProductVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(ProductVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(ProductVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region RefundableProductVwServices
    public static partial class RefundableProductVwServices
    {
		public static List<RefundableProductVw> Get(RefundableProductVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<RefundableProductVw> Get(RefundableProductVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<RefundableProductVw> GetPage(RefundableProductVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<RefundableProductVw> GetPage(RefundableProductVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(RefundableProductVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(RefundableProductVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region RequestVwServices
    public static partial class RequestVwServices
    {
		public static List<RequestVw> Get(RequestVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<RequestVw> Get(RequestVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<RequestVw> GetPage(RequestVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<RequestVw> GetPage(RequestVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(RequestVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(RequestVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region ResourceVwServices
    public static partial class ResourceVwServices
    {
		public static List<ResourceVw> Get(ResourceVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<ResourceVw> Get(ResourceVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<ResourceVw> GetPage(ResourceVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<ResourceVw> GetPage(ResourceVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(ResourceVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(ResourceVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region SalaryPaymentVwServices
    public static partial class SalaryPaymentVwServices
    {
		public static List<SalaryPaymentVw> Get(SalaryPaymentVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<SalaryPaymentVw> Get(SalaryPaymentVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<SalaryPaymentVw> GetPage(SalaryPaymentVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<SalaryPaymentVw> GetPage(SalaryPaymentVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(SalaryPaymentVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(SalaryPaymentVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region SalaryWorkPlaceVwServices
    public static partial class SalaryWorkPlaceVwServices
    {
		public static List<SalaryWorkPlaceVw> Get(SalaryWorkPlaceVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<SalaryWorkPlaceVw> Get(SalaryWorkPlaceVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<SalaryWorkPlaceVw> GetPage(SalaryWorkPlaceVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<SalaryWorkPlaceVw> GetPage(SalaryWorkPlaceVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(SalaryWorkPlaceVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(SalaryWorkPlaceVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region ServiceEndGrantRequestVwServices
    public static partial class ServiceEndGrantRequestVwServices
    {
		public static List<ServiceEndGrantRequestVw> Get(ServiceEndGrantRequestVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<ServiceEndGrantRequestVw> Get(ServiceEndGrantRequestVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<ServiceEndGrantRequestVw> GetPage(ServiceEndGrantRequestVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<ServiceEndGrantRequestVw> GetPage(ServiceEndGrantRequestVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(ServiceEndGrantRequestVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(ServiceEndGrantRequestVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region SettlementVwServices
    public static partial class SettlementVwServices
    {
		public static List<SettlementVw> Get(SettlementVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<SettlementVw> Get(SettlementVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<SettlementVw> GetPage(SettlementVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<SettlementVw> GetPage(SettlementVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(SettlementVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(SettlementVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region SpecialCaseLoanVwServices
    public static partial class SpecialCaseLoanVwServices
    {
		public static List<SpecialCaseLoanVw> Get(SpecialCaseLoanVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<SpecialCaseLoanVw> Get(SpecialCaseLoanVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<SpecialCaseLoanVw> GetPage(SpecialCaseLoanVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<SpecialCaseLoanVw> GetPage(SpecialCaseLoanVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(SpecialCaseLoanVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(SpecialCaseLoanVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region SubscriptionVwServices
    public static partial class SubscriptionVwServices
    {
		public static List<SubscriptionVw> Get(SubscriptionVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<SubscriptionVw> Get(SubscriptionVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<SubscriptionVw> GetPage(SubscriptionVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<SubscriptionVw> GetPage(SubscriptionVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(SubscriptionVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(SubscriptionVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region TransitoryIncomingLoanVwServices
    public static partial class TransitoryIncomingLoanVwServices
    {
		public static List<TransitoryIncomingLoanVw> Get(TransitoryIncomingLoanVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<TransitoryIncomingLoanVw> Get(TransitoryIncomingLoanVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<TransitoryIncomingLoanVw> GetPage(TransitoryIncomingLoanVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<TransitoryIncomingLoanVw> GetPage(TransitoryIncomingLoanVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(TransitoryIncomingLoanVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(TransitoryIncomingLoanVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion

    #region WarrantVwServices
    public static partial class WarrantVwServices
    {
		public static List<WarrantVw> Get(WarrantVwFilter filter)
		{
            Db db = new Db(DbServices.ConnectionString);
			return Get(filter, db);
		}

		public static List<WarrantVw> Get(WarrantVwFilter filter, Db db)
		{
			return db.Get(filter);
		}

        public static List<WarrantVw> GetPage(WarrantVwFilter filter, int pageIndex, int pageSize)
		{
            Db db = new Db(DbServices.ConnectionString);
            return GetPage(filter, pageIndex, pageSize, db);
		}

        public static List<WarrantVw> GetPage(WarrantVwFilter filter, int pageIndex, int pageSize, Db db)
		{
			return db.GetPage(filter, pageIndex, pageSize);
		}

        public static int GetTotalRowCount(WarrantVwFilter filter)
        {
            Db db = new Db(DbServices.ConnectionString);
            return GetTotalRowCount(filter, db);
        }

        public static int GetTotalRowCount(WarrantVwFilter filter, Db db)
        {
            return db.GetTotalRowCount(filter);
        }
    }
    #endregion
}
