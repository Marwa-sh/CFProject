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
    public partial class FormSalaryPaymentView : System.Windows.Forms.Form
    {
        public FormSalaryPaymentView()
        {
            InitializeComponent();
        }

        private void FormSalaryPaymentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SalaryPaymentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SalaryPaymentVw> dataSource = null;
        public List<SalaryPaymentVw> DataSource
        {
            set
            {
                dataSource = value;
                salaryPaymentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

