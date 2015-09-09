using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using payroll.Forms;



namespace payroll
{
    public partial class Menu : Form
    {

        

        //crate a form as container

       

        public Menu()
        {
           
            InitializeComponent();
        }

        private void showForm1()
        {
            Form1 log = new Form1();
            log.ShowDialog();
            if (!log.isValid) { Application.Exit(); }

            d.Text = log.getUser;

            
        }

      
       
        

        private void button1_Click(object sender, EventArgs e)
        {
 
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leave leave;
            leave = new Leave();
            leave.MdiParent = this;
            leave.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            PagIbig obj = new PagIbig();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Philheath obj = new Philheath();
            obj.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SSS obj = new SSS();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tax obj = new Tax();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void internalMarksEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }

        private void philhealthToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pagIbigToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            showForm1();
        }

        private void tmrCurTime_Tick(object sender, EventArgs e)
        {
            int strHour = Convert.ToInt32(DateTime.Now.Hour.ToString("00"));
            string strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " AM";
            if (strHour > 12)
            {
                strHour = strHour - 12;
                strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " PM";
            }
            f.Text = DateTime.Now.Date.ToLongDateString();
            M.Text = strTime;
        }

        private void Master_entryMenu_Click(object sender, EventArgs e)
        {
            Loan loan;
            loan = new Loan();
            loan.MdiParent = this;
            loan.Show();
        }

        private void internetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void commandLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void payrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void attendanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AttendanceTimeOut obj = new AttendanceTimeOut();
            obj.Show();
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void newEmployeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void leaveRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void philhealthRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void taxRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pagIbigRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void sSSRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void holidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Holiday holiday;
            holiday = new Holiday();
            holiday.MdiParent = this;
            holiday.Show();
        }

        private void holidayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void leaveDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu obj = new Menu();
            obj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Out obj = new Out();
            obj.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void newLeaveRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newHolidayRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void newPhilhealthRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newTaxRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void newPagIbigRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newSSSRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void payrollToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntry obj = new EmployeeEntry();
            obj.Show();
        }

        private void leaveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void holidayEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void philhealthEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void taxEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pagIbigEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sSSEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Bonus obj = new Bonus();
            obj.Show();
        }

        private void toolStripStatusLabel9_Click(object sender, EventArgs e)
        {
            Loan obj = new Loan();
            obj.Show();
        }

        private void companyBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void comanyLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntry obj = new EmployeeEntry();
            obj.Show();
        }

        private void leaveRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Leave obj = new Leave();
            obj.Show();
        }

        private void leaveEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LeaveEntry obj = new LeaveEntry();
            obj.Show();
        }

        private void holidayRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Holiday obj = new Holiday();
            obj.Show();
        }

        private void holidayEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HolidayEntry obj = new HolidayEntry();
            obj.Show();
        }

        private void philhealthRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Philheath obj = new Philheath();
            obj.Show();
        }

        private void philhealthEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhilhealthEntry obj = new PhilhealthEntry();
            obj.Show();
        }

        private void taxRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tax obj = new Tax();
            obj.Show();
        }

        private void taxEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaxEntry obj = new TaxEntry();
            obj.Show();
        }

        private void pagibigRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PagIbig obj = new PagIbig();
            obj.Show();
        }

        private void pagIbigEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PagIbigEntry obj = new PagIbigEntry();
            obj.Show();
        }

        private void sSSRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SSS obj = new SSS();
            obj.Show();
        }

        private void sSSEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SSSEntry obj = new SSSEntry();
            obj.Show();
        }

        private void companyBonusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bonus obj = new Bonus();
            obj.Show();
        }

        private void companyLoanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Loan obj = new Loan();
            obj.Show();
        }

        private void companyPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll obj = new Payroll();
            obj.Show();
        }

        private void internetBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void commandLineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "C:");
        }

        private void calculatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void taskManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void wordpadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void companyLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void oneByOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewPayroll obj = new FormViewPayroll();
            obj.Show();
        }

        private void allInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayrollReport obj = new FormPayrollReport();
            obj.Show();
        }

        private void cloudDesktopButton1_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
           
        }

        private void cloudDesktopButton2_Click(object sender, EventArgs e)
        {
            //Leave obj = new Leave();
            //obj.Show();
            Leave leave;
            leave = new Leave();
            leave.MdiParent = this;
            leave.Show();
        }

        private void cloudDesktopButton3_Click(object sender, EventArgs e)
        {
            Holiday obj = new Holiday();
            obj.Show();
        }

        private void cloudDesktopButton4_Click(object sender, EventArgs e)
        {
            Payroll obj = new Payroll();
            obj.Show();
        }

        private void cloudDesktopButton6_Click(object sender, EventArgs e)
        {
            Bonus obj = new Bonus();
            obj.Show();
        }

        private void cloudDesktopButton5_Click(object sender, EventArgs e)
        {
            Loan obj = new Loan();
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

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeRegistrationFormAdmin employeeRegistrationFormAdmin;
            //employeeRegistrationFormAdmin = new EmployeeRegistrationFormAdmin();
            //employeeRegistrationFormAdmin.MdiParent = this;
            //employeeRegistrationFormAdmin.Show();

            EmployeeRegistrationFormAdmin obj = new EmployeeRegistrationFormAdmin();
            obj.Show();
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leave leave;
            leave = new Leave();
            leave.MdiParent = this;
            leave.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus bonus;
            bonus = new Bonus();
            bonus.MdiParent = this;
            bonus.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll payroll;
            payroll = new Payroll();
            payroll.MdiParent = this;
            payroll.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports;
            reports = new Reports();
            reports.MdiParent = this;
            reports.Show();
        }

        private void deductionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deduction deduction;
            deduction = new Deduction();
            deduction.MdiParent = this;
            deduction.Show();
        }

        private void menuApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuApp menuApp;
            menuApp = new MenuApp();
            menuApp.MdiParent = this;
            menuApp.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPosition formPosition;
            formPosition = new FormPosition();
            formPosition.MdiParent = this;
            formPosition.Show();
        }

        private void noOfLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoOfLeave formLeave;
            formLeave = new FormNoOfLeave();
            formLeave.MdiParent = this;
            formLeave.Show();
        }
    }
}
