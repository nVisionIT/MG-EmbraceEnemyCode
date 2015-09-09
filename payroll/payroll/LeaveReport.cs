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
    public partial class LeaveReport : Form
    {
        public LeaveReport()
        {
            InitializeComponent();
        }

        private void LeaveReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.Leave' table. You can move, or remove it, as needed.
            this.LeaveTableAdapter.Fill(this.DataSet4.Leave);

            this.reportViewer1.RefreshReport();
        }
    }
}
