using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Counts
    {
        private string countss;
        private string lastID;
        public string Countss
        {
            get { return countss; }
            set { countss = value; }
        }

        public string LastID
        {
            get { return lastID; }
            set { lastID = value; }
        }
    }
}
