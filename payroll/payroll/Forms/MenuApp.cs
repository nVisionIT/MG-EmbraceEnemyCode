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
    public partial class MenuApp : Form
    {
        public MenuApp()
        {
            InitializeComponent();
        }

        private void cloudDesktopButton1_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void cloudDesktopButton2_Click(object sender, EventArgs e)
        {
            //obj.Show();
            Leave leave;
            leave = new Leave();
            
            leave.Show();
        }

        private void cloudDesktopButton3_Click(object sender, EventArgs e)
        {
            Holiday obj = new Holiday();
            obj.Show();
        }

        private void cloudDesktopButton6_Click(object sender, EventArgs e)
        {
            Bonus obj = new Bonus();
            obj.Show();
        }

        private void cloudDesktopButton7_Click(object sender, EventArgs e)
        {
            Deduction obj = new Deduction();
            obj.Show();
        }

        private void cloudDesktopButton8_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.Show();
        }

        private void cloudDesktopButton5_Click(object sender, EventArgs e)
        {
            Loan obj = new Loan();
            obj.Show();
        }

        private void cloudDesktopButton4_Click(object sender, EventArgs e)
        {
            Payroll obj = new Payroll();
            obj.Show();
        }
    }
}
