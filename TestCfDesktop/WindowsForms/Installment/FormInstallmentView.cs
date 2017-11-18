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
    public partial class FormInstallmentView : System.Windows.Forms.Form
    {
        public FormInstallmentView()
        {
            InitializeComponent();
        }

        private void FormInstallmentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = InstallmentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<InstallmentVw> dataSource = null;
        public List<InstallmentVw> DataSource
        {
            set
            {
                dataSource = value;
                installmentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

