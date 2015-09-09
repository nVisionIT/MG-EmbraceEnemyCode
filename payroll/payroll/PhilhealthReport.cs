using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payroll
{
    public partial class PhilhealthReport : Form
    {
        public PhilhealthReport()
        {
            InitializeComponent();
        }

        private void PhilhealthReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet7.PhilHealth' table. You can move, or remove it, as needed.
            this.PhilHealthTableAdapter.Fill(this.DataSet7.PhilHealth);

            this.reportViewer1.RefreshReport();
        }
    }
}
