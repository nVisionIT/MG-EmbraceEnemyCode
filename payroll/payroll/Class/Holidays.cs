using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Holidays
    {

         private string holidayNo;
        private string holidayDate;
        private string holidayReason;
        private string status;
        private string holidayName;
        public string HolidayNo
        {
            get { return holidayNo; }
            set { holidayNo = value; }
        }
        public string HolidayDate
        {
            get { return holidayDate; }
            set { holidayDate = value; }
        }
        public string HolidayReason
        {
            get { return holidayReason; }
            set { holidayReason = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string HolidayName
        {
            get { return holidayName; }
            set { holidayName = value; }
        }
    
    }
}
