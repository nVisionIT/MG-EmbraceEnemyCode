using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mime;
using PayrollSystem.Entities;

namespace PayrollSystem.Interfaces.Repositories
{
    public interface IEmployeeRepository 
    {
        string GenerateEmployeeId();
        
        void ClearDatabase();

        DataSet GetAllEmployees();

        DataSet GetAllTax();

        //string AddNewEmployee(PictureBox imageBox);
    }
}