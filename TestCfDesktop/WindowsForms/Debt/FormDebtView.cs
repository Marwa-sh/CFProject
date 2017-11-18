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
    public partial class FormDebtView : System.Windows.Forms.Form
    {
        public FormDebtView()
        {
            InitializeComponent();
        }

        private void FormDebtView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = DebtVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<DebtVw> dataSource = null;
        public List<DebtVw> DataSource
        {
            set
            {
                dataSource = value;
                debtVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

