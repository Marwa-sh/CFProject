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
    public partial class FormGuarantorView : System.Windows.Forms.Form
    {
        public FormGuarantorView()
        {
            InitializeComponent();
        }

        private void FormGuarantorView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GuarantorVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GuarantorVw> dataSource = null;
        public List<GuarantorVw> DataSource
        {
            set
            {
                dataSource = value;
                guarantorVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

