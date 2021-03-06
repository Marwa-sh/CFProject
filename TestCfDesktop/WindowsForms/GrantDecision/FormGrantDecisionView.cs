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
    public partial class FormGrantDecisionView : System.Windows.Forms.Form
    {
        public FormGrantDecisionView()
        {
            InitializeComponent();
        }

        private void FormGrantDecisionView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GrantDecisionVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GrantDecisionVw> dataSource = null;
        public List<GrantDecisionVw> DataSource
        {
            set
            {
                dataSource = value;
                grantDecisionVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

