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
    public partial class FormLoanChangeView : System.Windows.Forms.Form
    {
        public FormLoanChangeView()
        {
            InitializeComponent();
        }

        private void FormLoanChangeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanChangeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanChangeVw> dataSource = null;
        public List<LoanChangeVw> DataSource
        {
            set
            {
                dataSource = value;
                loanChangeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

