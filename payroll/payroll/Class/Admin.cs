using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using payroll.Class;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Refactor out this class into its own Project making it a Reusable Data Layer component
    class Admin
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private DataSet dt;
        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }
        public DataSet Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        public Admin()
        {
            LoadData();
        }

        // REVIEW: MOOAS GANI – 5 – Factor out each table/components loading on a need only basis. Do not load all the data up front on the application load.
        private void LoadData()
        {
            //set up connection

            // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
            string connectionString = "Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sprocedureSelectSSS";

            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            //set up dataSet for table course
            dataSet = new DataSet();
            dt = new DataSet();

            dataAdapter.Fill(dataSet, "SSS");

            //add joined tables to the dataSet
            command.CommandText = "aprocedureSelectPhilHealth";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "PhilHealth");

            command.CommandText = "bprocedureSelectPagIbig";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "PagIbig");

            command.CommandText = "cprocedureSelectTax";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Tax");


            command.CommandText = "gprocedureSelectEmployeeName";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(Dt, "LeaveEmployee");

            command.CommandText = "gprocedureJoinEmployeeLeave";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeLeave");

            command.CommandText = "hprocedureSelectAttendance";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Attendance");

            command.CommandText = "hprocedureSelectHoliday";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Holiday");

            command.CommandText = "fprocedureJoinEmployeePayroll";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeePayroll");

            command.CommandText = "iprocedureJoinEmployeeLoan";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeLoan");

            command.CommandText = "jprocedureJoinEmployeeBonus";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeBonus");

            command.CommandText = "cprocedureJoinPosition";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinPosition");

            command.CommandText = "jprocedureJoinEmployeeNoOfLeave";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeNoOfLeave");

        }


        //REVIEW: MOOSA GANI – 5 – Refactor out each method below into its own interface

        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region SSS Data
        public void AddRecord(SSSS sss)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("sprocedureInsertSSS",connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@SalaryRangeFrom", sss.SalaryRangeFrom);
            command.Parameters.AddWithValue("@SalaryRangeTo", sss.SalaryRangeTo);
            command.Parameters.AddWithValue("@SalaryBase", sss.SalaryBase);
            command.Parameters.AddWithValue("@SocialSecurityEmployeeShare", sss.SocialSecurityEmployeeShare);
            command.Parameters.AddWithValue("@SocialSecurityEmployerShare", sss.SocialSecurityEmployerShare);
            command.Parameters.AddWithValue("@SocialSecurityTotal", sss.SocialSecurityTotal);
            command.Parameters.AddWithValue("@EmployerShare", sss.EmployerShare);
            command.Parameters.AddWithValue("@TotalContributionEmployeeShare", sss.TotalContributionEmployeeShare);
            command.Parameters.AddWithValue("@TotalContributionEmployerShare", sss.TotalContributionEmployerShare);
            command.Parameters.AddWithValue("@TotalContribution", sss.TotalContribution);
            command.Parameters.AddWithValue("@TotalContributionForSEVMOFW", sss.TotalContributionForSEVMOFW);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRow(SSSS sss, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["SSS"].Rows[index];

            //replace values from course object
            selectedRow["SSSSalaryBracetNo"] = sss.SSSSalaryBracetNo;
            selectedRow["SalaryRangeFrom"] = sss.SalaryRangeFrom;
            selectedRow["SalaryRangeTo"] = sss.SalaryRangeTo;
            selectedRow["SalaryBase"] = sss.SalaryBase;
            selectedRow["SocialSecurityEmployeeShare"] = sss.SocialSecurityEmployeeShare;
            selectedRow["SocialSecurityEmployerShare"] = sss.SocialSecurityEmployerShare;
            selectedRow["SocialSecurityTotal"] = sss.SocialSecurityTotal;
            selectedRow["EmployerShare"] = sss.EmployerShare;
            selectedRow["TotalContributionEmployeeShare"] = sss.TotalContributionEmployeeShare;
            selectedRow["TotalContributionEmployerShare"] = sss.TotalContributionEmployerShare;
            selectedRow["TotalContribution"] = sss.TotalContribution;
            selectedRow["TotalContributionForSEVMOFW"] = sss.TotalContributionForSEVMOFW;
            EditRecord(sss, index);
        }

        private void EditRecord(SSSS sss, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up procedure name
            command.CommandText = "sprocedureUpdateSSS";
            dataAdapter.UpdateCommand = command;
            //set up parameters
            command.Parameters.AddWithValue("@SSSSalaryBracetNo", sss.SSSSalaryBracetNo);
            command.Parameters.AddWithValue("@SalaryRangeFrom", sss.SalaryRangeFrom);
            command.Parameters.AddWithValue("@SalaryRangeTo", sss.SalaryRangeTo);
            command.Parameters.AddWithValue("@SalaryBase", sss.SalaryBase);
            command.Parameters.AddWithValue("@SocialSecurityEmployeeShare", sss.SocialSecurityEmployeeShare);
            command.Parameters.AddWithValue("@SocialSecurityEmployerShare", sss.SocialSecurityEmployerShare);
            command.Parameters.AddWithValue("@SocialSecurityTotal", sss.SocialSecurityTotal);
            command.Parameters.AddWithValue("@EmployerShare", sss.EmployerShare);
            command.Parameters.AddWithValue("@TotalContributionEmployeeShare", sss.TotalContributionEmployeeShare);
            command.Parameters.AddWithValue("@TotalContributionEmployerShare", sss.TotalContributionEmployerShare);
            command.Parameters.AddWithValue("@TotalContribution", sss.TotalContribution);
            command.Parameters.AddWithValue("@TotalContributionForSEVMOFW", sss.TotalContributionForSEVMOFW);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "SSS");
        }

        public void DeleteRow(SSSS sss, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["SSS"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(sss, index);
        }

        private void DeleteRecord(SSSS sss, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "sprocedureDeleteSSS";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@SSSSalaryBracetNo", sss.SSSSalaryBracetNo);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "SSS");
        }
        public void SearchRecordSSS(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sprocedureSearchSSS";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "SSS");
        }
        public void RefreshRecordSSS()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sprocedureSelectSSS";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "SSS");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region PhilHealth Data
        public void AddRecord(Philhealth philHealth)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("aprocedureInsertPhilHealth", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@SalaryRangeFrom", philHealth.SalaryRangeFrom);
            command.Parameters.AddWithValue("@SalaryRangeTo", philHealth.SalaryRangeTo);
            command.Parameters.AddWithValue("@SalaryBase", philHealth.SalaryBase);
            command.Parameters.AddWithValue("@EmployeeShare", philHealth.EmployeeShare);
            command.Parameters.AddWithValue("@EmployerShare", philHealth.EmployerShare);
            command.Parameters.AddWithValue("@TotalMonthlyPremium", philHealth.TotalMonthlyPremium);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRow(Philhealth philHealth, int index)
        {
            //get selectedRow from the dataTable, PhilHealth
            DataRow selectedRow = dataSet.Tables["PhilHealth"].Rows[index];

            //replace values from course object
            selectedRow["PhilHealthSalaryBracetNo"] = philHealth.PhilHealthSalaryBracetNo;
            selectedRow["SalaryRangeFrom"] = philHealth.SalaryRangeFrom;
            selectedRow["SalaryRangeTo"] = philHealth.SalaryRangeTo;
            selectedRow["SalaryBase"] = philHealth.SalaryBase;
            selectedRow["EmployeeShare"] = philHealth.EmployeeShare;
            selectedRow["EmployerShare"] = philHealth.EmployerShare;
            selectedRow["TotalMonthlyPremium"] = philHealth.TotalMonthlyPremium;

            EditRecord(philHealth, index);
        }

        private void EditRecord(Philhealth philHealth, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "aprocedureUpdatePhilHealth";
            dataAdapter.UpdateCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@PhilHealthSalaryBracetNo", philHealth.PhilHealthSalaryBracetNo);
            command.Parameters.AddWithValue("@SalaryRangeFrom", philHealth.SalaryRangeFrom);
            command.Parameters.AddWithValue("@SalaryRangeTo", philHealth.SalaryRangeTo);
            command.Parameters.AddWithValue("@SalaryBase", philHealth.SalaryBase);
            command.Parameters.AddWithValue("@EmployeeShare", philHealth.EmployeeShare);
            command.Parameters.AddWithValue("@EmployerShare", philHealth.EmployerShare);
            command.Parameters.AddWithValue("@TotalMonthlyPremium", philHealth.TotalMonthlyPremium);

            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "PhilHealth");
        }

        public void DeleteRow(Philhealth philHealth, int index)
        {
            //get selectedRow from the dataTable, PhilHealth
            DataRow selectedRow = dataSet.Tables["PhilHealth"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(philHealth, index);
        }

        private void DeleteRecord(Philhealth philHealth, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "aprocedureDeletePhilHealth";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@PhilHealthSalaryBracetNo", philHealth.PhilHealthSalaryBracetNo);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "PhilHealth");
        }
        public void SearchRecordPhilHealth(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "aprocedureSearchPhilHealth";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "PhilHealth");
        }
        public void RefreshRecordPhilHealth()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "aprocedureSelectPhilHealth";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "PhilHealth");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region PagIbig Data
        public void AddRecord(PagIbigs pagIbig)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("bprocedureInsertPagIbig", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@MonthlyCompensationFrom", pagIbig.MonthlyCompensationFrom);
            command.Parameters.AddWithValue("@MonthlyCompensationTo", pagIbig.MonthlyCompensationTo);
            command.Parameters.AddWithValue("@EmployeeShare", pagIbig.EmployeeShare);
            command.Parameters.AddWithValue("@EmployerShare", pagIbig.EmployerShare);
            command.Parameters.AddWithValue("@TotalMonthlyContribution", pagIbig.TotalMonthlyContribution);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRow(PagIbigs pagIbig, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["PagIbig"].Rows[index];

            //replace values from course object
            selectedRow["PagIbigSalaryBracetNo"] = pagIbig.PagIbigSalaryBracetNo;
            selectedRow["MonthlyCompensationFrom"] = pagIbig.MonthlyCompensationFrom;
            selectedRow["MonthlyCompensationFrom"] = pagIbig.MonthlyCompensationTo;
            selectedRow["EmployeeShare"] = pagIbig.EmployeeShare;
            selectedRow["EmployerShare"] = pagIbig.EmployerShare;
            selectedRow["TotalMonthlyContribution"] = pagIbig.TotalMonthlyContribution;
            EditRecord(pagIbig, index);
        }

        private void EditRecord(PagIbigs pagIbig, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "bprocedureUpdatePagIbig";
            dataAdapter.UpdateCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@PagIbigSalaryBracetNo", pagIbig.PagIbigSalaryBracetNo);
            command.Parameters.AddWithValue("@MonthlyCompensationFrom", pagIbig.MonthlyCompensationFrom);
            command.Parameters.AddWithValue("@MonthlyCompensationTo", pagIbig.MonthlyCompensationTo);
            command.Parameters.AddWithValue("@EmployeeShare", pagIbig.EmployeeShare);
            command.Parameters.AddWithValue("@EmployerShare", pagIbig.EmployerShare);
            command.Parameters.AddWithValue("@TotalMonthlyContribution", pagIbig.TotalMonthlyContribution);

            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "PagIbig");
        }

        public void DeleteRow(PagIbigs pagIbig, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["PagIbig"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(pagIbig, index);
        }

        private void DeleteRecord(PagIbigs pagIbig, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "bprocedureDeletePagIbig";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@PagIbigSalaryBracetNo", pagIbig.PagIbigSalaryBracetNo);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "PagIbig");
        }
        public void SearchRecordPagIbig(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "bprocedureSearchPagIbig";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "PagIbig");
        }
        public void RefreshRecordPagIbig()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "bprocedureSelectPagIbig";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "PagIbig");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Tax Data
        public void AddRecord(Taxs tax)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("cprocedureInsertTax", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@TaxFrom", tax.TaxFrom);
            command.Parameters.AddWithValue("@TaxTo", tax.TaxTo);
            command.Parameters.AddWithValue("@PercentOver", tax.PercentOver);
            command.Parameters.AddWithValue("@TaxExemption", tax.TaxExemption);
            command.Parameters.AddWithValue("@CivilStatus", tax.CivilStatus);
            command.Parameters.AddWithValue("@Dependent", tax.Dependent);
            command.Parameters.AddWithValue("@NoOfDependent", tax.NoOfDependent);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRow(Taxs tax, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["Tax"].Rows[index];
            //replace values from course object
            selectedRow["TaxNo"] = tax.TaxNo;
            selectedRow["TaxFrom"] = tax.TaxFrom;
            selectedRow["TaxTo"] = tax.TaxTo;
            selectedRow["PercentOver"] = tax.PercentOver;
            selectedRow["TaxExemption"] = tax.TaxExemption;
            selectedRow["CivilStatus"] = tax.CivilStatus;
            selectedRow["Dependent"] = tax.Dependent;
            selectedRow["NoOfDependent"] = tax.NoOfDependent;
            EditRecord(tax, index);
        }

        private void EditRecord(Taxs tax, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "cprocedureUpdateTax";
            dataAdapter.UpdateCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@TaxNo", tax.TaxNo);
            command.Parameters.AddWithValue("@TaxFrom", tax.TaxFrom);
            command.Parameters.AddWithValue("@TaxTo", tax.TaxTo);
            command.Parameters.AddWithValue("@PercentOver", tax.PercentOver);
            command.Parameters.AddWithValue("@TaxExemption", tax.TaxExemption);
            command.Parameters.AddWithValue("@CivilStatus", tax.CivilStatus);
            command.Parameters.AddWithValue("@Dependent", tax.Dependent);
            command.Parameters.AddWithValue("@NoOfDependent", tax.NoOfDependent);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "Tax");
        }

        public void DeleteRow(Taxs tax, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["Tax"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(tax, index);
        }

        private void DeleteRecord(Taxs tax, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "cprocedureDeleteTax";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@TaxNo", tax.TaxNo);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "Tax");
        }
        public void SearchRecordTax(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureSearchTax";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Tax");
        }
        public void RefreshRecordTax()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureSelectTax";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Tax");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Employee Data
        public void GetCountEmployee(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "eprocedureCountEmployee";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.Countss = returnValue.ToString();
        }
        public void GetLastIDEmployee(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "eprocedureLastIDEmployee";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.LastID = returnValue.ToString();
        }
        public void AddRecord(Employee employee)
        {
            byte[] img = null;
            FileStream fs = new FileStream(employee.ImageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("eprocedureInsertEmployee", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@EmoloyeeID", employee.EmoloyeeID);
            command.Parameters.AddWithValue("@FirstName", employee.FirstName);
            command.Parameters.AddWithValue("@MiddleName", employee.MiddleName);
            command.Parameters.AddWithValue("@LastName", employee.LastName);
            command.Parameters.AddWithValue("@Age", employee.Age);
            command.Parameters.AddWithValue("@Birthday", employee.Birthday);
            command.Parameters.AddWithValue("@Sex", employee.Sex);
            command.Parameters.AddWithValue("@City", employee.City);
            command.Parameters.AddWithValue("@Province", employee.Province);
            command.Parameters.AddWithValue("@Street", employee.Street);
            command.Parameters.AddWithValue("@Country", employee.Country);
            command.Parameters.AddWithValue("@Religion", employee.Religion);
            command.Parameters.AddWithValue("@CivilStatus", employee.CivilStatus);
            command.Parameters.AddWithValue("@NoOfChild", employee.NoOfChild);
            command.Parameters.AddWithValue("@NoOfDependent", employee.NoOfDependent);
            command.Parameters.AddWithValue("@Position", employee.Position);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            command.Parameters.AddWithValue("@EmployeePicture", img);
            command.Parameters.AddWithValue("@TertiarySchool", employee.TertiarySchool);
            command.Parameters.AddWithValue("@TertiaryYear", employee.TertiaryYear);
            command.Parameters.AddWithValue("@SecondarySchool", employee.SecondarySchool);
            command.Parameters.AddWithValue("@SecondaryYear", employee.SecondaryYear);
            command.Parameters.AddWithValue("@ElementarySchool", employee.ElementarySchool);
            command.Parameters.AddWithValue("@ElementaryYear", employee.ElementaryYear);
            command.Parameters.AddWithValue("@DateHired", employee.DateHired);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void RefreshRecordEmployee()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "eprocedureSelectEmployee";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Employee");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Payroll Data
        public void Payroll(string Input)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSelectPayroll";
            command.Parameters.AddWithValue("@Input",Input);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeePayrolls");
        }
        public void GetCountPayroll(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureCountPayroll";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.Countss = returnValue.ToString();
        }
        public void GetLastIDPayroll(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureLastIDPayroll";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.LastID = returnValue.ToString();
        }
        public void PayrollBonusFee(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "frocedureSelectPayrollBonusFee";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeBonusFee");
        }
        public void PayrollLoanCompany(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSelectPayrollLoan";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeLoanDeduction");
        }
        public void PayrollLoanSSS(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSelectPayrollLoanSSS";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeLoanDeductionSSS");
        }
        public void PayrollLoanPagIbig(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSelectPayrollLoanPagIbig";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeLoanDeductionPagIbig");
        }
        public void SearchRecordPayroll(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSearchPayroll";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinEmployeePayroll");
        }
        public void RecordPayroll(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureSelectPayrolls";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeePayrollsss");
        }
        public bool CheckPayrollPeriod(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "fprocedureJoinEmployeePayroll";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeePayroll");
            foreach (DataRow datarow in dataSet.Tables["JoinEmployeePayroll"].Rows)
            {
                if (datarow["Period"].ToString() == input)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Leave Data
        public void AddRecord(Leaves leave)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("gprocedureInsertEmployeeLeave", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@EmployeeID", leave.Employee.EmoloyeeID);
            command.Parameters.AddWithValue("@StartDate", leave.StartDate);
            command.Parameters.AddWithValue("@EndDate", leave.EndDate);
            command.Parameters.AddWithValue("@Reason", leave.Reason);
            command.Parameters.AddWithValue("@NoOfDays", leave.NoOfDays);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditRow(Leaves leave, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeLeave"].Rows[index];
            selectedRow["StartDate"] = leave.StartDate;
            selectedRow["EndDate"] = leave.EndDate;
            selectedRow["Reason"] = leave.Reason;
            selectedRow["NoOfDays"] = leave.NoOfDays;
            EditRecord(leave, index);
        }

        private void EditRecord(Leaves leave, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "gprocedureUpdateEmployeeLeave";
            dataAdapter.UpdateCommand = command;
            command.Parameters.AddWithValue("@LeaveID", leave.LeaveID);
            command.Parameters.AddWithValue("@StartDate", leave.StartDate);
            command.Parameters.AddWithValue("@EndDate", leave.EndDate);
            command.Parameters.AddWithValue("@Reason", leave.Reason);
            command.Parameters.AddWithValue("@NoOfDays", leave.NoOfDays);
            dataAdapter.Update(dataSet, "JoinEmployeeLeave");
        }

        public void DeleteRow(Leaves leave, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeLeave"].Rows[index];
            selectedRow.Delete();

            DeleteRecord(leave, index);
        }

        private void DeleteRecord(Leaves leave, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "gprocedureDeleteEmployeeLeave";
            dataAdapter.DeleteCommand = command;

            command.Parameters.AddWithValue("@LeaveID", leave.LeaveID);
            dataAdapter.Update(dataSet, "JoinEmployeeLeave");
        }
        public void SearchRecordLeave(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "gprocedureSearchLeave";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinEmployeeLeave");
        }
        public void RefreshRecordELeave()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "gprocedureJoinEmployeeLeave";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeLeave");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Attendance
        public void RefreshRecordAttendance()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hprocedureSelectAttendance";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "AttendanceAfterNoon");
        }
        public void RefreshRecordAttendances()
        {
            dt.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hprocedureSelectAttendances";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dt, "AttendanceMorning");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region AttendanceReport Data
        public void AttendanceReport(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureSelectAttendance";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeAttendanceReport");
        }
        public void AttendanceReports(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureSelectAttendances";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeAttendanceReports");
        }
        public void AttendanceReportLeave(string input, string output)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureSelectLeave";
            command.Parameters.AddWithValue("@Input", input);
            command.Parameters.AddWithValue("@Output", output);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "EmployeeAttendanceLeave");
        }
        public void GetCountAttendanceReport(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureCountAttendanceReport";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.Countss = returnValue.ToString();
        }
        public void GetLastIDAttendanceReport(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureLastIDAttendanceReport";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.LastID = returnValue.ToString();
        }
        public void SearchRecordAttendanceReport(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "qprocedureSearchAttendanceReport";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeAttenanceReport");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Holiday Data
        public void GetCountHoliday(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hprocedureCountHoliday";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.Countss = returnValue.ToString();
        }
        public void GetLastIDHoliday(Counts counts)
        {
            SqlCommand command = new SqlCommand();
            Object returnValue;
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hprocedureLastIDHoliday";
            command.Connection = connection;
            connection.Open();
            returnValue = command.ExecuteScalar();
            connection.Close();
            counts.LastID = returnValue.ToString();
        }
        public void AddRow(Holidays holiday)
        {
            //get dataTable tableCourse
            DataTable dataTable = dataSet.Tables["Holiday"];

            //create a new dataRow
            DataRow dataRow = dataTable.NewRow();

            //assign values from course object
            dataRow["HolidayID"] = holiday.HolidayNo;
            dataRow["HolidayName"] = holiday.HolidayName;
            dataRow["HolidayDate"] = holiday.HolidayDate;
            dataRow["HolidayReason"] = holiday.HolidayReason;
            dataRow["Status"] = holiday.Status;
            //add the new dataRow to dataTable
            dataTable.Rows.Add(dataRow);

            AddRecord(holiday);
        }

        private void AddRecord(Holidays holiday)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "hprocedureInsertHoliday";
            dataAdapter.InsertCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@HolidayNo", holiday.HolidayNo);
            command.Parameters.AddWithValue("@HolidayName", holiday.HolidayName);
            command.Parameters.AddWithValue("@HolidayDate", holiday.HolidayDate);
            command.Parameters.AddWithValue("@HolidayReason", holiday.HolidayReason);
            command.Parameters.AddWithValue("@Status", holiday.Status);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "Holiday");
        }

        public void EditRow(Holidays holiday, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["Holiday"].Rows[index];

            //replace values from course object
            selectedRow["HolidayName"] = holiday.HolidayName;
            selectedRow["HolidayDate"] = holiday.HolidayDate;
            selectedRow["HolidayReason"] = holiday.HolidayReason;
            selectedRow["Status"] = holiday.Status;
            EditRecord(holiday, index);
        }

        private void EditRecord(Holidays holiday, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "hprocedureUpdateHoliday";
            dataAdapter.UpdateCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@HolidayNo", holiday.HolidayNo);
            command.Parameters.AddWithValue("@HolidayName", holiday.HolidayName);
            command.Parameters.AddWithValue("@HolidayDate", holiday.HolidayDate);
            command.Parameters.AddWithValue("@HolidayReason", holiday.HolidayReason);
            command.Parameters.AddWithValue("@Status", holiday.Status);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "Holiday");
        }

        public void DeleteRow(Holidays holiday, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["Holiday"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(holiday, index);
        }

        private void DeleteRecord(Holidays holiday, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "hprocedureDeleteHoliday";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@HolidayNo", holiday.HolidayNo);
            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "Holiday");
        }
        public void SearchRecordHoliday(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hprocedureSearchHoliday";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "Holiday");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Loan Data
        public void AddRecord(Loan loan)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("iprocedureInsertEmployeeLoan", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@EmployeeID", loan.Employee.EmoloyeeID);
            command.Parameters.AddWithValue("@StartDate", loan.StartDate);
            command.Parameters.AddWithValue("@EndDate", loan.EndDate);
            command.Parameters.AddWithValue("@AmountLoan", loan.Amountloan);
            command.Parameters.AddWithValue("@TotalAmorzitation",loan.TotalAmorzitation);
            command.Parameters.AddWithValue("@TypeLoan", loan.TypeLoan);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditRow(Loan loan, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeLoan"].Rows[index];
            selectedRow["StartDate"] = loan.StartDate;
            selectedRow["EndDate"] = loan.EndDate;
            selectedRow["TotalAmorzitation"] = loan.TotalAmorzitation;
            selectedRow["AmountLoan"] = loan.Amountloan;
            selectedRow["TypeOfLoan"] = loan.TypeLoan;
            EditRecord(loan, index);
        }

        private void EditRecord(Loan loan, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iprocedureUpdateEmployeeLoan";
            dataAdapter.UpdateCommand = command;
            command.Parameters.AddWithValue("@EmployeeID", loan.Employee.EmoloyeeID);
            command.Parameters.AddWithValue("@StartDate", loan.StartDate);
            command.Parameters.AddWithValue("@EndDate", loan.EndDate);
            command.Parameters.AddWithValue("@AmountLoan", loan.Amountloan);
            command.Parameters.AddWithValue("@TotalAmorzitation", loan.TotalAmorzitation);
            command.Parameters.AddWithValue("@LoanID", loan.LoanID);
            command.Parameters.AddWithValue("@TypeLoan", loan.TypeLoan);
            dataAdapter.Update(dataSet, "JoinEmployeeLoan");
        }

        public void DeleteRow(Loan loan, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeLoan"].Rows[index];
            selectedRow.Delete();

            DeleteRecord(loan, index);
        }

        private void DeleteRecord(Loan loan, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iprocedureDeleteEmployeeLoan";
            dataAdapter.DeleteCommand = command;

            command.Parameters.AddWithValue("@LoanID", loan.LoanID);
            dataAdapter.Update(dataSet, "JoinEmployeeLoan");
        }
        public void SearchRecordLoan(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iprocedureSearchLoan";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinEmployeeLoan");
        }
        public void RefreshRecordLoan()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "iprocedureJoinEmployeeLoan";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeLoan");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Bonus Data
        public void AddRecord(Bonus bonus)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("jprocedureInsertEmployeeBonus", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            command.Parameters.AddWithValue("@Date", bonus.Date);
            command.Parameters.AddWithValue("@Amount", bonus.Amount);
            command.Parameters.AddWithValue("@EmployeeID", bonus.Employee.EmoloyeeID);
            command.Parameters.AddWithValue("@Type", bonus.Type);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditRow(Bonus bonus, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeBonus"].Rows[index];
            selectedRow["Date"] = bonus.Date;
            selectedRow["Amount"] = bonus.Amount;
            selectedRow["Type"] = bonus.Type;
            EditRecord(bonus, index);
        }

        private void EditRecord(Bonus bonus, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureUpdateEmployeeBonus";
            dataAdapter.UpdateCommand = command;
            command.Parameters.AddWithValue("@EmployeeID", bonus.Employee.EmoloyeeID);
            command.Parameters.AddWithValue("@Date", bonus.Date);
            command.Parameters.AddWithValue("@Amount", bonus.Amount);
            command.Parameters.AddWithValue("@BonusID", bonus.BonusID);
            command.Parameters.AddWithValue("@Type", bonus.Type);
            dataAdapter.Update(dataSet, "JoinEmployeeBonus");
        }

        public void DeleteRow(Bonus bonus, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinEmployeeBonus"].Rows[index];
            selectedRow.Delete();

            DeleteRecord(bonus, index);
        }

        private void DeleteRecord(Bonus bonus, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureDeleteEmployeeBonus";
            dataAdapter.DeleteCommand = command;

            command.Parameters.AddWithValue("@BonusID",bonus.BonusID );
            dataAdapter.Update(dataSet, "JoinEmployeeBonus");
        }
        public void SearchRecordBonus(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureSearchBonus";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinEmployeeBonus");
        }
        public void RefreshRecordBonus()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureJoinEmployeeBonus";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeBonus");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region Position Data
        public void AddRecord(Position positions)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("cprocedureInsertPosition", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            
            //command.Parameters.AddWithValue("@PositionID", positions.PositionID);
            command.Parameters.AddWithValue("@PositionName", positions.PositionName);
            command.Parameters.AddWithValue("@Salary", positions.Salary);
            command.ExecuteNonQuery();
            connection.Close();
  
        }

        public void EditRow(Position positions, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinPosition"].Rows[index];
            selectedRow["PositionID"] = positions.PositionID;
            selectedRow["PositionName"] = positions.PositionName;
            selectedRow["Salary"] = positions.Salary;
            
            EditRecord(positions, index);
        }

        private void EditRecord(Position positions, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureUpdatePosition";
            dataAdapter.UpdateCommand = command;

            command.Parameters.AddWithValue("@PositionID", positions.PositionID);
            command.Parameters.AddWithValue("@PositionName", positions.PositionName);
            command.Parameters.AddWithValue("@Salary", positions.Salary);
            dataAdapter.Update(dataSet, "JoinPosition");
        }

        public void DeleteRow(Position positions, int index)
        {
            DataRow selectedRow = dataSet.Tables["JoinPosition"].Rows[index];
            selectedRow.Delete();

            DeleteRecord(positions, index);
        }

        private void DeleteRecord(Position position, int index)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureDeletePosition";
            dataAdapter.DeleteCommand = command;

            command.Parameters.AddWithValue("@PositionID", position.PositionID);
            dataAdapter.Update(dataSet, "JoinPosition");
        }
        public void SearchRecordPosition(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureSearchPosition";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinPosition");
        }
        public void RefreshRecordPosition()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "cprocedureJoinPosition";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinPosition");
        }
        #endregion
        //REVIEW: MOOSA GANI – 5 – Refactor out each section into its own implemented interface
        #region No Of Leave Data
        public void AddRecord(NoOfLeave noOfLeave)
        {
            connection.Open();
            //set up command
            SqlCommand command = new SqlCommand("jprocedureInsertNoOfLeave", connection);
            //set up commandType
            command.CommandType = CommandType.StoredProcedure;
            //set up parameters
            //command.Parameters.AddWithValue("@LeaveNo", noOfLeave.LeaveNo);
            command.Parameters.AddWithValue("@SickLeave", noOfLeave.SickLeave);
            command.Parameters.AddWithValue("@Maternity", noOfLeave.MaternityLeave);
            command.Parameters.AddWithValue("@Paternity", noOfLeave.PaternityLeave);
            command.Parameters.AddWithValue("@VacationLeave", noOfLeave.VacationLeave);
            command.Parameters.AddWithValue("@EmployeeID", noOfLeave.Employee.EmoloyeeID);
            command.ExecuteNonQuery();
            connection.Close();
  
        }

        public void EditRow(NoOfLeave noOfLeave, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["JoinEmployeeNoOfLeave"].Rows[index];

            //replace values from course object
            selectedRow["SickLeave"] = noOfLeave.SickLeave;
            selectedRow["VacationLeave"] = noOfLeave.VacationLeave;
            selectedRow["Maternity"] = noOfLeave.MaternityLeave;
            selectedRow["Paternity"] = noOfLeave.PaternityLeave;
            
            EditRecord(noOfLeave, index);
        }

        private void EditRecord(NoOfLeave noOfLeave, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "jprocedureUpdateNoOfLeave";
            dataAdapter.UpdateCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@LeaveNo", noOfLeave.LeaveNo);
            command.Parameters.AddWithValue("@SickLeave", noOfLeave.SickLeave);
            command.Parameters.AddWithValue("@Maternity", noOfLeave.MaternityLeave);
            command.Parameters.AddWithValue("@Paternity", noOfLeave.PaternityLeave);
            command.Parameters.AddWithValue("@VacationLeave", noOfLeave.VacationLeave);
            command.Parameters.AddWithValue("@EmployeeID", noOfLeave.Employee.EmoloyeeID);

            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "JoinEmployeeNoOfLeave");
        }

        public void DeleteRow(NoOfLeave noOfLeave, int index)
        {
            //get selectedRow from the dataTable, tableCourse
            DataRow selectedRow = dataSet.Tables["JoinEmployeeNoOfLeave"].Rows[index];

            //delete selected row from the dataSet
            selectedRow.Delete();

            DeleteRecord(noOfLeave, index);
        }

        private void DeleteRecord(NoOfLeave noOfLeave, int index)
        {
            //set up command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //set up commandType
            command.CommandType = CommandType.StoredProcedure;

            //set up procedure name
            command.CommandText = "jprocedureDeleteNoOfLeave";
            dataAdapter.DeleteCommand = command;

            //set up parameters
            command.Parameters.AddWithValue("@LeaveNo", noOfLeave.LeaveNo);

            //update tableCourse from the dataSet
            dataAdapter.Update(dataSet, "JoinEmployeeNoOfLeave");
        }
        public void SearchRecordNoOfLeave(string input)
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureSearchNoOfLeave";
            command.Parameters.AddWithValue("@Input", "%" + input + "%");
            dataAdapter.SelectCommand = command;

            dataAdapter.Fill(dataSet, "JoinEmployeeNoOfLeave");
        }
        public void RefreshRecordNoOfLeave()
        {
            dataSet.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jprocedureJoinEmployeeNoOfLeave";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "JoinEmployeeNoOfLeave");

        }
        #endregion
    }
}
