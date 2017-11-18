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
    public partial class FormProductView : System.Windows.Forms.Form
    {
        public FormProductView()
        {
            InitializeComponent();
        }

        private void FormProductView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ProductVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ProductVw> dataSource = null;
        public List<ProductVw> DataSource
        {
            set
            {
                dataSource = value;
                productVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

