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
    public partial class BonusFeeReport : Form
    {
        public BonusFeeReport()
        {
            InitializeComponent();
        }

        private void BonusFeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.BonusFee' table. You can move, or remove it, as needed.
            this.BonusFeeTableAdapter.Fill(this.DataSet2.BonusFee);

            this.reportViewer1.RefreshReport();
        }
    }
}
