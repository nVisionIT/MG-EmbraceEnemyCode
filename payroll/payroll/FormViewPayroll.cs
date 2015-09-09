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
    public partial class FormViewPayroll : Form
    {
        private Admin admin;
        private FormPrintEmployeePayroll formPrintEmployeePayroll;
        public FormViewPayroll()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void FormViewPayroll_Load(object sender, EventArgs e)
        {
            dataGridViewPayrollTable.DataSource = admin.DataSet.Tables["JoinEmployeePayroll"];
            dataGridViewPayrollTable.AllowUserToAddRows = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPayroll(search);
            dataGridViewPayrollTable.AllowUserToAddRows = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPayroll(search);
            dataGridViewPayrollTable.AllowUserToAddRows = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (formPrintEmployeePayroll == null || formPrintEmployeePayroll.IsDisposed)
            {
                formPrintEmployeePayroll = new FormPrintEmployeePayroll();
            }
            //formPrintEmployeePayroll.aa = this.dataGridViewPayrollTable.CurrentRow.Cells[3].Value.ToString();
            //formPrintEmployeePayroll.c = this.dataGridViewPayrollTable.CurrentRow.Cells[4].Value.ToString();
            formPrintEmployeePayroll.b = Int32.Parse(this.dataGridViewPayrollTable.CurrentRow.Cells[4].Value.ToString());
            //formViewAttendanceReportList.Parent = ;
            formPrintEmployeePayroll.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
