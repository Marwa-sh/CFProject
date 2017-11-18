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
    public partial class FormEndWorkGrantBracketView : System.Windows.Forms.Form
    {
        public FormEndWorkGrantBracketView()
        {
            InitializeComponent();
        }

        private void FormEndWorkGrantBracketView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EndWorkGrantBracketVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EndWorkGrantBracketVw> dataSource = null;
        public List<EndWorkGrantBracketVw> DataSource
        {
            set
            {
                dataSource = value;
                endWorkGrantBracketVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

