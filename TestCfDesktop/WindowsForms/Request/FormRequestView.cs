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
    public partial class FormRequestView : System.Windows.Forms.Form
    {
        public FormRequestView()
        {
            InitializeComponent();
        }

        private void FormRequestView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = RequestVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<RequestVw> dataSource = null;
        public List<RequestVw> DataSource
        {
            set
            {
                dataSource = value;
                requestVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

