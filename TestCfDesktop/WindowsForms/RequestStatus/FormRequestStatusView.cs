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
    public partial class FormRequestStatusView : System.Windows.Forms.Form
    {
        public FormRequestStatusView()
        {
            InitializeComponent();
        }

        private void FormRequestStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = RequestStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<RequestStatusVw> dataSource = null;
        public List<RequestStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                requestStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

