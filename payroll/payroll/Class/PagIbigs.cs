﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class PagIbigs
    {
        private string pagIbigSalaryBracetNo;
        private decimal monthlyCompensationFrom;
        private decimal monthlyCompensationTo;
        private decimal employeeShare;
        private decimal employerShare;
        private decimal totalMonthlyContribution;
        public string PagIbigSalaryBracetNo
        {
            get { return pagIbigSalaryBracetNo; }
            set { pagIbigSalaryBracetNo = value; }
        }
        public decimal MonthlyCompensationFrom
        {
            get { return monthlyCompensationFrom; }
            set { monthlyCompensationFrom = value; }
        }
        public decimal MonthlyCompensationTo
        {
            get { return monthlyCompensationTo; }
            set { monthlyCompensationTo = value; }
        }
        public decimal EmployeeShare
        {
            get { return employeeShare; }
            set { employeeShare = value; }
        }
        public decimal EmployerShare
        {
            get { return employerShare; }
            set { employerShare = value; }
        }
        public decimal TotalMonthlyContribution
        {
            get { return totalMonthlyContribution; }
            set { totalMonthlyContribution = value; }
        }
    }
}
