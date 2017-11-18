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
    public partial class FormGrantView : System.Windows.Forms.Form
    {
        public FormGrantView()
        {
            InitializeComponent();
        }

        private void FormGrantView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GrantVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GrantVw> dataSource = null;
        public List<GrantVw> DataSource
        {
            set
            {
                dataSource = value;
                grantVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

