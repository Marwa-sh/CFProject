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
    public partial class FormMonthlyBalanceView : System.Windows.Forms.Form
    {
        public FormMonthlyBalanceView()
        {
            InitializeComponent();
        }

        private void FormMonthlyBalanceView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = MonthlyBalanceVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<MonthlyBalanceVw> dataSource = null;
        public List<MonthlyBalanceVw> DataSource
        {
            set
            {
                dataSource = value;
                monthlyBalanceVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

