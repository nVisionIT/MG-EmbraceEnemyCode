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
    public partial class PagibigReport : Form
    {
        public PagibigReport()
        {
            InitializeComponent();
        }

        private void PagibigReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet6.PagIbig' table. You can move, or remove it, as needed.
            this.PagIbigTableAdapter.Fill(this.DataSet6.PagIbig);

            this.reportViewer1.RefreshReport();
        }
    }
}
