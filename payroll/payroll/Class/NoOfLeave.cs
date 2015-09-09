using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll.Class
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class NoOfLeave
    {
        private string leaveNo;
        private int maternityLeave;
        private int paternityLeave;
        private int sickLeave;
        private int vacationLeave;
        private Employee employee;
        public NoOfLeave()
        {
            employee = new Employee();
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public string LeaveNo
        {
            get { return leaveNo; }
            set { leaveNo = value; }
        }
        public int MaternityLeave
        {
            get { return maternityLeave; }
            set { maternityLeave = value; }
        }
        public int PaternityLeave
        {
            get { return paternityLeave; }
            set { paternityLeave = value; }
        }
        public int SickLeave
        {
            get { return sickLeave; }
            set { sickLeave = value; }
        }
        public int VacationLeave
        {
            get { return vacationLeave; }
            set { vacationLeave = value; }
        }
    }
}
