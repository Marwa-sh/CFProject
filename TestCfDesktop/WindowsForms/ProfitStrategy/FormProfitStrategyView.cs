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
    public partial class FormProfitStrategyView : System.Windows.Forms.Form
    {
        public FormProfitStrategyView()
        {
            InitializeComponent();
        }

        private void FormProfitStrategyView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ProfitStrategyVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ProfitStrategyVw> dataSource = null;
        public List<ProfitStrategyVw> DataSource
        {
            set
            {
                dataSource = value;
                profitStrategyVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

