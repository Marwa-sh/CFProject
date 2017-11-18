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
    public partial class FormProductTypeView : System.Windows.Forms.Form
    {
        public FormProductTypeView()
        {
            InitializeComponent();
        }

        private void FormProductTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ProductTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ProductTypeVw> dataSource = null;
        public List<ProductTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                productTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

