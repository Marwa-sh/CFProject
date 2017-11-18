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
    public partial class FormPaymentView : System.Windows.Forms.Form
    {
        public FormPaymentView()
        {
            InitializeComponent();
        }

        private void FormPaymentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = PaymentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<PaymentVw> dataSource = null;
        public List<PaymentVw> DataSource
        {
            set
            {
                dataSource = value;
                paymentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

