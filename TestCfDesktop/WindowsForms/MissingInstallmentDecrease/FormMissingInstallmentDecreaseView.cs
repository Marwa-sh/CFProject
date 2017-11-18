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
    public partial class FormMissingInstallmentDecreaseView : System.Windows.Forms.Form
    {
        public FormMissingInstallmentDecreaseView()
        {
            InitializeComponent();
        }

        private void FormMissingInstallmentDecreaseView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = MissingInstallmentDecreaseVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<MissingInstallmentDecreaseVw> dataSource = null;
        public List<MissingInstallmentDecreaseVw> DataSource
        {
            set
            {
                dataSource = value;
                missingInstallmentDecreaseVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

