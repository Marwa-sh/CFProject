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
    public partial class FormLoanDecisionView : System.Windows.Forms.Form
    {
        public FormLoanDecisionView()
        {
            InitializeComponent();
        }

        private void FormLoanDecisionView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanDecisionVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanDecisionVw> dataSource = null;
        public List<LoanDecisionVw> DataSource
        {
            set
            {
                dataSource = value;
                loanDecisionVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

