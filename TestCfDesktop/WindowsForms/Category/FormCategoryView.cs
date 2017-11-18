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
    public partial class FormCategoryView : System.Windows.Forms.Form
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = CategoryVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<CategoryVw> dataSource = null;
        public List<CategoryVw> DataSource
        {
            set
            {
                dataSource = value;
                categoryVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

