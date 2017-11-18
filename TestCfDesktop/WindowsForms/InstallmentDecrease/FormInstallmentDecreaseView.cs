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
    public partial class FormInstallmentDecreaseView : System.Windows.Forms.Form
    {
        public FormInstallmentDecreaseView()
        {
            InitializeComponent();
        }

        private void FormInstallmentDecreaseView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = InstallmentDecreaseVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<InstallmentDecreaseVw> dataSource = null;
        public List<InstallmentDecreaseVw> DataSource
        {
            set
            {
                dataSource = value;
                installmentDecreaseVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

