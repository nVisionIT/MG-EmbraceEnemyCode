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
    public partial class EmployeeReportcs : Form
    {
        public EmployeeReportcs()
        {
            InitializeComponent();
        }

        private void EmployeeReportcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.DataSet1.tblEmployee);

            this.reportViewer1.RefreshReport();
        }
    }
}
