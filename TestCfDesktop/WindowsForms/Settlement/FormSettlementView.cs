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
    public partial class FormSettlementView : System.Windows.Forms.Form
    {
        public FormSettlementView()
        {
            InitializeComponent();
        }

        private void FormSettlementView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SettlementVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SettlementVw> dataSource = null;
        public List<SettlementVw> DataSource
        {
            set
            {
                dataSource = value;
                settlementVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

