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
    public partial class FormInstallmentDecreaseOrderView : System.Windows.Forms.Form
    {
        public FormInstallmentDecreaseOrderView()
        {
            InitializeComponent();
        }

        private void FormInstallmentDecreaseOrderView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = InstallmentDecreaseOrderVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<InstallmentDecreaseOrderVw> dataSource = null;
        public List<InstallmentDecreaseOrderVw> DataSource
        {
            set
            {
                dataSource = value;
                installmentDecreaseOrderVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

