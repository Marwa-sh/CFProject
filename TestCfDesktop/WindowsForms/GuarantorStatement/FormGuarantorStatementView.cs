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
    public partial class FormGuarantorStatementView : System.Windows.Forms.Form
    {
        public FormGuarantorStatementView()
        {
            InitializeComponent();
        }

        private void FormGuarantorStatementView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GuarantorStatementVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GuarantorStatementVw> dataSource = null;
        public List<GuarantorStatementVw> DataSource
        {
            set
            {
                dataSource = value;
                guarantorStatementVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

