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
    public partial class LoanReport : Form
    {
        public LoanReport()
        {
            InitializeComponent();
        }

        private void LoanReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet5.Loan' table. You can move, or remove it, as needed.
            this.LoanTableAdapter.Fill(this.DataSet5.Loan);

            this.reportViewer1.RefreshReport();
        }
    }
}
