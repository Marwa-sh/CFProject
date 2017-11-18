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
    public partial class FormResourceView : System.Windows.Forms.Form
    {
        public FormResourceView()
        {
            InitializeComponent();
        }

        private void FormResourceView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ResourceVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ResourceVw> dataSource = null;
        public List<ResourceVw> DataSource
        {
            set
            {
                dataSource = value;
                resourceVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

