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
    public partial class FormErrorDefinitionView : System.Windows.Forms.Form
    {
        public FormErrorDefinitionView()
        {
            InitializeComponent();
        }

        private void FormErrorDefinitionView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ErrorDefinitionVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ErrorDefinitionVw> dataSource = null;
        public List<ErrorDefinitionVw> DataSource
        {
            set
            {
                dataSource = value;
                errorDefinitionVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

