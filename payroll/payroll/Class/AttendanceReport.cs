using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class AttendanceReport
    {
        private string attendanceReportNO;
        private string period;
        private int[] totalNoOfWork;
        private int[] totalNoOfLate;
        private int[] totalNoOfAbsent;
        private string[] employeeID;
        public string[] EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string AttendanceReportNO
        {
            get { return attendanceReportNO; }
            set { attendanceReportNO = value; }
        }
        public string Period
        {
            get { return period; }
            set { period = value; }
        }
        public int[] TotalNoOfWork
        {
            get { return totalNoOfWork; }
            set { totalNoOfWork = value; }
        }
        public int[] TotalNoOfLate
        {
            get { return totalNoOfLate; }
            set { totalNoOfLate = value; }
        }
        public int[] TotalNoOfAbsent
        {
            get { return totalNoOfAbsent; }
            set { totalNoOfAbsent = value; }
        }
    }
}
