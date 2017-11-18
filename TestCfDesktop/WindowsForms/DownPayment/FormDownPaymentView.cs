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
    public partial class FormDownPaymentView : System.Windows.Forms.Form
    {
        public FormDownPaymentView()
        {
            InitializeComponent();
        }

        private void FormDownPaymentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = DownPaymentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<DownPaymentVw> dataSource = null;
        public List<DownPaymentVw> DataSource
        {
            set
            {
                dataSource = value;
                downPaymentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

