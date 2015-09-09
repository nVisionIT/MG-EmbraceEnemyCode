using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll.Class
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Bonus
    {
       private string bonusID;
       private string date;
       private decimal amount;
       private string type;
       private Employee employee;
       public Bonus()
       {
           employee = new Employee();
       }
       public Employee Employee
       {
           get { return employee;}
           set { employee = value; }
       }
       public string BonusID
       {
           get { return bonusID; }
           set { bonusID = value; }
       }
       public decimal Amount
       {
           get { return amount; }
           set { amount = value; }
       }
       public string Date
       {
           get { return date; }
           set { date = value; }
       }
       public string Type
       {
           get { return type; }
           set { type = value; }
       }
    }
}
