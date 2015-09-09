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
    public partial class HolidayReport : Form
    {
        public HolidayReport()
        {
            InitializeComponent();
        }

        private void HolidayReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.Holiday' table. You can move, or remove it, as needed.
            this.HolidayTableAdapter.Fill(this.DataSet3.Holiday);

            this.reportViewer1.RefreshReport();
        }
    }
}
