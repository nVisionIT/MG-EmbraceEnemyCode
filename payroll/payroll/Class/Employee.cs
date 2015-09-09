using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor this class into its own C# Library as a Data.Models namespace/project name
    class Employee
    {
      private string emoloyeeID;
      private string firstName;
      private string middleName;
      private string lastName;
      private string age;
      private string birthday;
      private string sex;
      private string city;
      private string province;
      private string street;
      private string country;
      private string religion;
      private string civilStatus;
      private string noOfChild;
      private string noOfDependent;
      private string position;
      private decimal salary;
      private byte[] employeePicture;
      private string tertiarySchool;
      private string tertiaryYear;
      private string secondarySchool;
      private string secondaryYear;
      private string elementarySchool;
      private string elementaryYear;
      private string imageloc;
      private string dateHired;
      public string EmoloyeeID
      {
          get { return emoloyeeID; }
          set { emoloyeeID = value; }
      }
      public string FirstName
      {
          get { return firstName; }
          set { firstName = value; }
      }
      public string MiddleName
      {
          get { return middleName; }
          set { middleName = value; }
      }
      public string LastName
      {
          get { return lastName; }
          set { lastName = value; }
      }
      public string Age
      {
          get { return age; }
          set { age = value; }
      }
      public string Birthday
      {
          get { return birthday; }
          set { birthday = value; }
      }
      public string Sex
      {
          get { return sex; }
          set { sex = value; }
      }
      public string City
      {
          get { return city; }
          set { city = value; }
      }
      public string Province
      {
          get { return province; }
          set { province = value; }
      }
      public string Street
      {
          get { return street; }
          set { street = value; }
      }
      public string Country
      {
          get { return country; }
          set { country = value; }
      }
      public string Religion
      {
          get { return religion; }
          set { religion = value; }
      }
      public string CivilStatus
      {
          get { return civilStatus; }
          set { civilStatus = value; }
      }
      public string NoOfChild
      {
          get { return noOfChild; }
          set { noOfChild = value; }
      }
      public string NoOfDependent
      {
          get { return noOfDependent; }
          set { noOfDependent = value; }
      }
      public string Position
      {
          get { return position; }
          set { position = value; }
      }
      public decimal Salary
      {
          get { return salary; }
          set { salary = value; }
      }
      public byte[] EmployeePicture
      {
          get { return employeePicture; }
          set { employeePicture = value; }
      }
      public string TertiarySchool
      {
          get { return tertiarySchool; }
          set { tertiarySchool = value; }
      }
      public string TertiaryYear
      {
          get { return tertiaryYear; }
          set { tertiaryYear = value; }
      }
      public string SecondarySchool
      {
          get { return secondarySchool; }
          set { secondarySchool = value; }
      }
      public string SecondaryYear
      {
          get { return secondaryYear; }
          set { secondaryYear = value; }
      }
      public string ElementarySchool
      {
          get { return elementarySchool; }
          set { elementarySchool = value; }
      }
      public string ElementaryYear
      {
          get { return elementaryYear; }
          set { elementaryYear = value; }
      }
      public string ImageLoc
      {
          get { return imageloc; }
          set { imageloc = value; }
      }
      public string DateHired
      {
          get { return dateHired; }
          set { dateHired = value; }
      }
    }
}
