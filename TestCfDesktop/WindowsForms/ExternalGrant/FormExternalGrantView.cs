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
    public partial class FormExternalGrantView : System.Windows.Forms.Form
    {
        public FormExternalGrantView()
        {
            InitializeComponent();
        }

        private void FormExternalGrantView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ExternalGrantVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ExternalGrantVw> dataSource = null;
        public List<ExternalGrantVw> DataSource
        {
            set
            {
                dataSource = value;
                externalGrantVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

