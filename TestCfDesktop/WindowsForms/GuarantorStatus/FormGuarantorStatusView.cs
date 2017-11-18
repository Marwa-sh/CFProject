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
    public partial class FormGuarantorStatusView : System.Windows.Forms.Form
    {
        public FormGuarantorStatusView()
        {
            InitializeComponent();
        }

        private void FormGuarantorStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GuarantorStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GuarantorStatusVw> dataSource = null;
        public List<GuarantorStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                guarantorStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

