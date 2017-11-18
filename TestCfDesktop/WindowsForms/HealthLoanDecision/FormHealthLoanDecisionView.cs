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
    public partial class FormHealthLoanDecisionView : System.Windows.Forms.Form
    {
        public FormHealthLoanDecisionView()
        {
            InitializeComponent();
        }

        private void FormHealthLoanDecisionView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = HealthLoanDecisionVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<HealthLoanDecisionVw> dataSource = null;
        public List<HealthLoanDecisionVw> DataSource
        {
            set
            {
                dataSource = value;
                healthLoanDecisionVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

