using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll.Class
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Loan
    {
        private string loanID;
        private decimal amountloan;
        private decimal totalAmorzitation;
        private string startDate;
        private string endDate;
        private Employee employee;
        private string typeLoan;
        public Loan()
        {
            employee = new Employee();
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public string LoanID
        {
            get { return loanID; }
            set { loanID = value; }
        }
        public decimal Amountloan
        {
            get { return amountloan; }
            set { amountloan = value; }
        }
        public decimal TotalAmorzitation
        {
            get { return totalAmorzitation; }
            set { totalAmorzitation = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string TypeLoan
        {
            get { return typeLoan; }
            set { typeLoan= value; }
        }
    }
}
