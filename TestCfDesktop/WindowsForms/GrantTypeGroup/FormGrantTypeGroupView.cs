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
    public partial class FormGrantTypeGroupView : System.Windows.Forms.Form
    {
        public FormGrantTypeGroupView()
        {
            InitializeComponent();
        }

        private void FormGrantTypeGroupView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = GrantTypeGroupVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<GrantTypeGroupVw> dataSource = null;
        public List<GrantTypeGroupVw> DataSource
        {
            set
            {
                dataSource = value;
                grantTypeGroupVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

