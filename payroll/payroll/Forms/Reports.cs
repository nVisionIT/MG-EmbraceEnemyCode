using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payroll.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeReportcs obj = new EmployeeReportcs();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BonusFeeReport obj = new BonusFeeReport();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HolidayReport obj = new HolidayReport();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeaveReport obj = new LeaveReport();
            obj.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoanReport obj = new LoanReport();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PagibigReport obj = new PagibigReport();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PhilhealthReport obj = new PhilhealthReport();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SSSreport obj = new SSSreport();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TaxReport obj = new TaxReport();
            obj.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormPayrollReport obj = new FormPayrollReport();
            obj.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormViewPayroll obj = new FormViewPayroll();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormAttendanceReport obj = new FormAttendanceReport();
            obj.Show();
        }
    }
}
