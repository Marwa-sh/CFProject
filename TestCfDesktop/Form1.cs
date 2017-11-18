using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cf.Data;
using Cf.Services;

namespace TestCfDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Db db = new Db(@"Data Source = (local); Initial Catalog = Cf; Integrated Security = True");
            // comboBox1.DataSource = db.EmployeeStatusList();

            // EmployeeStatusMapper esm = new EmployeeStatusMapper(@"Data Source = (local); Initial Catalog = Cf; Integrated Security = True");
            // comboBox1.DataSource = esm.List();
            // comboBox1.DisplayMember = "Name";

            // EmployeeStatusVwMapper esvm = new EmployeeStatusVwMapper(@"Data Source = (local); Initial Catalog = Cf; Integrated Security = True");
            // comboBox1.DataSource = esvm.List();
            // comboBox1.DisplayMember = "Name";

      
             comboBox1.DataSource = EmployeeStatusServices.List();
             comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nullable<decimal> es = comboBox1.SelectedValue as Nullable<decimal>;
            if (es != null)
                dataGridView1.DataSource = EmployeeServices.GetByEmployeeStatus(es.Value);
        }
    }
}
