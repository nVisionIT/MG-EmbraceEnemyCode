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
    public partial class FormPrintEmployeePayroll : Form
    {
        public int b;
        public FormPrintEmployeePayroll()
        {
            InitializeComponent();
        }

        private void FormPrintEmployeePayroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPayslipEmployee.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.DataSetPayslipEmployee.DataTable1,b);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
