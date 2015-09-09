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
    public partial class FormAttendanceReport : Form
    {
        private string aaa;
        public FormAttendanceReport()
        {
            InitializeComponent();
        }

        private void FormAttendanceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAttendance.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSetAttendance.DataTable1, aaa);
            // TODO: This line of code loads data into the 'DataSetPayslipEmployee.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSetPayslipEmployee.DataTable1);
            // TODO: This line of code loads data into the 'DataSetPayslipEmployee.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSetPayslipEmployee.DataTable1, aaa);
           // this.reportViewer1.RefreshReport();
        }  

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            aaa = dateTimePickerReportStart.Value.ToShortDateString() + "-" + dateTimePickerReportEnd.Value.ToShortDateString();
           // TODO: This line of code loads data into the 'DataSetPayslipEmployee.DataTable1' table. You can move, or remove it, as needed.
           //this.DataTable1TableAdapter.Fill(this.DataSetAttendance.DataTable1,aaa);

            // TODO: This line of code loads data into the 'DataSetAttendance.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetAttendance.DataTable1, aaa);
           this.reportViewer1.RefreshReport();
            
        }
    }
}
