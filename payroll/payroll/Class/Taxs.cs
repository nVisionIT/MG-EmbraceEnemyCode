using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Taxs
    {
        private string taxNo;
        private decimal taxFrom;
        private decimal taxTo;
        private decimal percentOver;
        private decimal taxExemption;
        private string dependent;
        private string noOfDependent;
        private string civilStatus;
        public string TaxNo
        {
            get { return taxNo; }
            set { taxNo = value; }
        }
        public decimal TaxTo
        {
            get { return taxTo; }
            set { taxTo = value; }
        }
        public decimal TaxFrom
        {
            get { return taxFrom; }
            set { taxFrom = value; }
        }
        public decimal PercentOver
        {
            get { return percentOver; }
            set { percentOver = value; }
        }
        public decimal TaxExemption
        {
            get { return taxExemption; }
            set { taxExemption = value; }
        }
        public string Dependent
        {
            get { return dependent; }
            set { dependent = value; }
        }
        public string NoOfDependent
        {
            get { return noOfDependent; }
            set { noOfDependent = value; }
        }
        public string CivilStatus
        {
            get { return civilStatus; }
            set { civilStatus = value; }
        }
    }
}
