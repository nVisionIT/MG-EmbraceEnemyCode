using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Leaves
    {
         private string leaveID;
        private string startDate;
        private string endDate;
        private string reasons;
        private string noOfDays;
        private Employee employee;
        public Leaves()
        {
            employee = new Employee();
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public string LeaveID
        {
            get { return leaveID; }
            set { leaveID = value; }
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
        public string Reason
        {
            get { return reasons; }
            set { reasons = value; }
        }
        public string NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }
    }
}
