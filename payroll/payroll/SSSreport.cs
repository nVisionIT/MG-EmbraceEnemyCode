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
    public partial class SSSreport : Form
    {
        public SSSreport()
        {
            InitializeComponent();
        }

        private void SSSreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet8.SSS' table. You can move, or remove it, as needed.
            this.SSSTableAdapter.Fill(this.DataSet8.SSS);

            this.reportViewer1.RefreshReport();
        }
    }
}
