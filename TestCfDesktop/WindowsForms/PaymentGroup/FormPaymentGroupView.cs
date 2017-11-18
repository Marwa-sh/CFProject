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
    public partial class FormPaymentGroupView : System.Windows.Forms.Form
    {
        public FormPaymentGroupView()
        {
            InitializeComponent();
        }

        private void FormPaymentGroupView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = PaymentGroupVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<PaymentGroupVw> dataSource = null;
        public List<PaymentGroupVw> DataSource
        {
            set
            {
                dataSource = value;
                paymentGroupVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

