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
    public partial class FormPaymentStatusView : System.Windows.Forms.Form
    {
        public FormPaymentStatusView()
        {
            InitializeComponent();
        }

        private void FormPaymentStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = PaymentStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<PaymentStatusVw> dataSource = null;
        public List<PaymentStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                paymentStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

