using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Payrollsss
    {
        private string date;
        private string period;
        private string payrollID;
        private decimal[] salaryPerMonth;
        private decimal[] salaryPerDay;
        private decimal[] sSSDeduction;
        private decimal[] philHealthDeduction;
        private decimal[] taxDeduction;
        private decimal[] taxDeductiona;
        private decimal[] taxDeductions;
        private decimal[] taxDeductiond;
        private decimal[] netPay;
        private decimal[] grossPay;
        private decimal[] grossPaya;
        private decimal[] grossPays;
        private decimal[] grossPayd;
        private decimal[] grossPayq;
        private decimal[] grossPaye;
        private decimal[] pagIbigDeduction;
        private decimal[] pagIbigDeductiona;
        private decimal[] totalNoWork;
        private decimal[] totalNoLate;
        private decimal[] totalNoOvertime;
        private decimal[] overTimePay;
        private decimal[] lateDeduction;
        private decimal[] taxExemption;
        private decimal[] taxOver;
        private decimal[] taxbase;
        private string[] employeeID;
        private string[] attendanceReportNo;
        private decimal[] bonus;
        private decimal[] loan;
        private decimal[] loanSSS;
        private decimal[] loanPagIbig;
        //private AttendanceReport attendanceReport;
        //public Payroll()
        //{
        //    attendanceReport = new AttendanceReport();
        //}
        //public AttendanceReport AttendanceReport
        //{
        //    get { return attendanceReport; }
        //    set { attendanceReport = value; }
        //}
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Period
        {
            get { return period; }
            set { period = value; }
        }
        public string[] EmployeeID
        {
            get { return employeeID; }
            set { employeeID = (string[])value.Clone(); }
        }
        public string[] AttendanceReportNo
        {
            get { return attendanceReportNo; }
            set { attendanceReportNo = (string[])value.Clone(); }
        }
        public string PayrollID
        {
            get { return payrollID; }
            set { payrollID = value; }
        }
        public decimal[] SalaryPerMonth
        {
            get { return salaryPerMonth; }
            set { salaryPerMonth = value; }
        }
        public decimal[] OverTimePay
        {
            get { return overTimePay; }
            set { overTimePay = value; }
        }
        public decimal[] SalaryPerDay
        {
            get { return salaryPerDay; }
            set { salaryPerDay = value; }
        }
        public decimal[] SSSDeduction
        {
            get { return sSSDeduction; }
            set { sSSDeduction = value; }
        }
        public decimal[] PhilHealthDeduction
        {
            get { return philHealthDeduction; }
            set { philHealthDeduction = value; }
        }
        public decimal[] PagIbigDeduction
        {
            get { return pagIbigDeduction; }
            set { pagIbigDeduction = value; }
        }
        public decimal[] PagIbigDeductiona
        {
            get { return pagIbigDeductiona; }
            set { pagIbigDeductiona = value; }
        }
        public decimal[] TaxDeduction
        {
            get { return taxDeduction; }
            set { taxDeduction = value; }
        }
        public decimal[] TaxDeductiona
        {
            get { return taxDeductiona; }
            set { taxDeductiona = value; }
        }
        public decimal[] TaxDeductions
        {
            get { return taxDeductions; }
            set { taxDeductions = value; }
        }
        public decimal[] TaxDeductiond
        {
            get { return taxDeductiond; }
            set { taxDeductiond = value; }
        }
        public decimal[] NetPay
        {
            get { return netPay; }
            set { netPay = value; }
        }
        public decimal[] GrossPay
        {
            get { return grossPay; }
            set { grossPay = value; }
        }
        public decimal[] GrossPaya
        {
            get { return grossPaya; }
            set { grossPaya = value; }
        }
        public decimal[] GrossPays
        {
            get { return grossPays; }
            set { grossPays = value; }
        }
        public decimal[] GrossPayd
        {
            get { return grossPayd; }
            set { grossPayd = value; }
        }
        public decimal[] GrossPayq
        {
            get { return grossPayq; }
            set { grossPayq = value; }
        }
        public decimal[] GrossPaye
        {
            get { return grossPaye; }
            set { grossPaye = value; }
        }

        public decimal[] TotalNoWork
        {
            get { return totalNoWork; }
            set { totalNoWork = value; }
        }
        public decimal[] TotalNoLate
        {
            get { return totalNoLate; }
            set { totalNoLate = value; }
        }
        public decimal[] TotalNoOvertime
        {
            get { return totalNoOvertime; }
            set { totalNoOvertime = value; }
        }
        public decimal[] LateDeduction
        {
            get { return lateDeduction; }
            set { lateDeduction = value; }
        }
        public decimal[] Taxbase
        {
            get { return taxbase; }
            set { taxbase = value; }
        }
        public decimal[] TaxOver
        {
            get { return taxOver; }
            set { taxOver = value; }
        }
        public decimal[] TaxExemption
        {
            get { return taxExemption; }
            set { taxExemption = value; }
        }
        public decimal[] Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public decimal[] Loan
        {
            get { return loan; }
            set { loan = value; }
        }
        public decimal[] LoanSSS
        {
            get { return loanSSS; }
            set { loanSSS = value; }
        }
        public decimal[] LoanPagIbig
        {
            get { return loanPagIbig; }
            set { loanPagIbig = value; }
        }
    }
}
