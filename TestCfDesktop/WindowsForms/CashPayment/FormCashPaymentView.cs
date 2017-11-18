using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;
using Cf.Data;
using Cf.Services;

namespace Cf
{
    public partial class FormCashPaymentView : System.Windows.Forms.Form
    {
        public FormCashPaymentView()
        {
            InitializeComponent();
        }

        private void FormCashPaymentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = CashPaymentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<CashPaymentVw> dataSource = null;
        public List<CashPaymentVw> DataSource
        {
            set
            {
                dataSource = value;
                cashPaymentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

