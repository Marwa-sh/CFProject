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
    public partial class FormIssuerView : System.Windows.Forms.Form
    {
        public FormIssuerView()
        {
            InitializeComponent();
        }

        private void FormIssuerView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = IssuerVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<IssuerVw> dataSource = null;
        public List<IssuerVw> DataSource
        {
            set
            {
                dataSource = value;
                issuerVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

