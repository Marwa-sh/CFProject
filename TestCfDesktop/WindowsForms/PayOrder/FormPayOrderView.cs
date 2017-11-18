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
    public partial class FormPayOrderView : System.Windows.Forms.Form
    {
        public FormPayOrderView()
        {
            InitializeComponent();
        }

        private void FormPayOrderView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = PayOrderVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<PayOrderVw> dataSource = null;
        public List<PayOrderVw> DataSource
        {
            set
            {
                dataSource = value;
                payOrderVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

