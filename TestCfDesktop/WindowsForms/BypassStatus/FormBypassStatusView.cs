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
    public partial class FormBypassStatusView : System.Windows.Forms.Form
    {
        public FormBypassStatusView()
        {
            InitializeComponent();
        }

        private void FormBypassStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = BypassStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<BypassStatusVw> dataSource = null;
        public List<BypassStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                bypassStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

