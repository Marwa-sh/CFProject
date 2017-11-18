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
    public partial class FormProfileView : System.Windows.Forms.Form
    {
        public FormProfileView()
        {
            InitializeComponent();
        }

        private void FormProfileView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ProfileVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ProfileVw> dataSource = null;
        public List<ProfileVw> DataSource
        {
            set
            {
                dataSource = value;
                profileVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

