using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Attendnces
    {
        private string timeIn;
        private string date;
        private string timeOut;
        private int totalNoOfWork;
        private int totalNoOfLate;
        private Employee employee;
        public Attendnces()
        {
            employee = new Employee();
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public string TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }
        public string TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int TotalNoOfWork
        {
            get { return totalNoOfWork; }
            set { totalNoOfWork = value; }
        }
        public int TotalNoOfLate
        {
            get { return totalNoOfLate; }
            set { totalNoOfLate = value; }
        }
        
    }
}
