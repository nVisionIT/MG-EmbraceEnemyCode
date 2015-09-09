using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollSystem.Data.Models;
using PayrollSystem.Data.Repository;
using PayrollSystem.DataAccess;
using PayrollSystem.Interfaces.Injection;

namespace PayrollSystem.UnitTest
{
    [TestClass]
    public class EmployeeTests
    {
        protected IDependencyInjector DependencyInjector { get; private set; }

        [TestMethod]
        public void GivenEmptyDbThenEnsureDefaultEmployeeId()
        {
            PayrollSystem.DataAccess.EmployeeData employeeData = new EmployeeData(new MockEmployeeRepository());
            employeeData.ClearDatabase();

            var id = employeeData.GenerateId();
            Assert.IsTrue(id == "EMP-10001");
        }

        [TestMethod]
        public void GivenDatabaseWithEmployeesThenEnsureDefaultEmployeeId()
        {
            PayrollSystem.DataAccess.EmployeeData employeeData = new EmployeeData(new MockEmployeeRepository());
            employeeData.ClearDatabase();
            
            //TODO: Create Test Employee Method -> Has Create Employee on the Employee Repository
            //TODO: Finish the rest of this test method
        }

        [TestMethod]
        public void TestGetAllEmployeesReturnsADataSet()
        {
            PayrollSystem.DataAccess.EmployeeData employeeData = new EmployeeData(new MockEmployeeRepository());
            DataSet dsEmployees = employeeData.GetAllEmployees();
            Assert.IsTrue(dsEmployees.Tables.Count > 0 && dsEmployees.Tables[0].Rows.Count > 0);
        }

        [TestMethod]
        public void TestGetAllTaxDataSetHasData()
        {
            PayrollSystem.DataAccess.EmployeeData employeeData = new EmployeeData(new EmployeeRepository());
            DataSet dsTaxDetails = employeeData.GetAllTax();
            Assert.IsTrue(dsTaxDetails.Tables.Count > 0 && dsTaxDetails.Tables[0].Rows.Count > 0);
        }
    }
}
