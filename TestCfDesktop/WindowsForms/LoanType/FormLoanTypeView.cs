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
    public partial class FormLoanTypeView : System.Windows.Forms.Form
    {
        public FormLoanTypeView()
        {
            InitializeComponent();
        }

        private void FormLoanTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = LoanTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<LoanTypeVw> dataSource = null;
        public List<LoanTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                loanTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

