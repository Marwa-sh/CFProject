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
    public partial class FormLoanRequestView : System.Windows.Forms.Form
    {
        public FormLoanRequestView()
        {
            InitializeComponent();
        }

        private void FormLoanRequestView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanRequestVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanRequestVw> dataSource = null;
        public List<LoanRequestVw> DataSource
        {
            set
            {
                dataSource = value;
                loanRequestVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

