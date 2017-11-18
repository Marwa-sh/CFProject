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
    public partial class FormLoanDecisionTypeView : System.Windows.Forms.Form
    {
        public FormLoanDecisionTypeView()
        {
            InitializeComponent();
        }

        private void FormLoanDecisionTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanDecisionTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanDecisionTypeVw> dataSource = null;
        public List<LoanDecisionTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                loanDecisionTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

