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
    public partial class FormRefundableProductView : System.Windows.Forms.Form
    {
        public FormRefundableProductView()
        {
            InitializeComponent();
        }

        private void FormRefundableProductView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = RefundableProductVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<RefundableProductVw> dataSource = null;
        public List<RefundableProductVw> DataSource
        {
            set
            {
                dataSource = value;
                refundableProductVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

