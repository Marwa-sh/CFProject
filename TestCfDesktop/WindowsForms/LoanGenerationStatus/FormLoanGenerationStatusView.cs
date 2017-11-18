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
    public partial class FormLoanGenerationStatusView : System.Windows.Forms.Form
    {
        public FormLoanGenerationStatusView()
        {
            InitializeComponent();
        }

        private void FormLoanGenerationStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanGenerationStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanGenerationStatusVw> dataSource = null;
        public List<LoanGenerationStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                loanGenerationStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

