using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Entities;
using PayrollSystem.Interfaces.Injection;
using PayrollSystem.Interfaces.Repositories;

namespace PayrollSystem.DataAccess
{
    public class EmployeeData
    {
        //private readonly IEmployeeRepository _employeeRepository;
        private IEmployeeRepository _employeeRepository;

        public EmployeeData(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public string GenerateId()
        {
            var domainModel = _employeeRepository.GenerateEmployeeId();

            return domainModel;
        }

        public void ClearDatabase()
        {
            _employeeRepository.ClearDatabase();
        }

        public DataSet GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public DataSet GetAllTax()
        {
            return _employeeRepository.GetAllTax();
        }
        //public string AddNewEmployee(System.Windows.Forms.PictureBox imageBox)
        //{
        //    return _employeeRepository.AddNewEmployee(imageBox);
        //}
    }
}
