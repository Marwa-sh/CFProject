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
    public partial class FormWarrantView : System.Windows.Forms.Form
    {
        public FormWarrantView()
        {
            InitializeComponent();
        }

        private void FormWarrantView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = WarrantVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<WarrantVw> dataSource = null;
        public List<WarrantVw> DataSource
        {
            set
            {
                dataSource = value;
                warrantVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

