using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll.Class
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Position
    {
        private string positionID;
        private string positionName;
        private int salary;
        public string PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }

        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
}
