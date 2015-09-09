using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Data.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CivilStatus { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string Sex { get; set; }
        public string Religion { get; set; }
        public string Citizenship { get; set; }
        public string Child { get; set; }
        public string Age { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateHired { get; set; }
        public string Position { get; set; }
        public string School { get; set; }
        public string YearGradudated { get; set; }
        public string School1 { get; set; }
        public string YearGraduated1 { get; set; }
        public string School2 { get; set; }
        public string YearGraduated2 { get; set; }
        public int Salary { get; set; }
        public string NoOfDependent { get; set; }
    }
}
