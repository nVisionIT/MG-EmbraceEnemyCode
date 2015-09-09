using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Entities;
using PayrollSystem.Interfaces.Repositories;

namespace PayrollSystem.Data.Repository
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public string GenerateEmployeeId()
        {
            string result = string.Empty;

            using (SqlConnection connection = new SqlConnection(GenerateConnectionString()))
            {
                connection.Open();

                SqlCommand comm = new SqlCommand("SELECT COUNT(ID) FROM tblEmployee", connection);
                Int32 count = (Int32)comm.ExecuteScalar();
                if (count == 0)
                {
                    result = "EMP-10001";                  
                }
                else
                {
                    SqlCommand comm1 = new SqlCommand("SELECT Max(ID) FROM tblEmployee", connection);
                    Object returnvalue = (Object)comm1.ExecuteScalar();
                    string strReturn = returnvalue.ToString(); //convert object to string	

                    string Id = strReturn.Substring(4, 5); //icucut nya un USG-10001 bali ang value ng Id = 10001
                    // REVIEW: MOOAS GANI – 4 – Do error handling around this string to int conversion
                    int increment = Convert.ToInt32(Id) + 1; //tapos convert ung string to int.. value ng increment= 10001 + 1
                    
                    result = "EMP-" + increment; // tapos to magiging USG-10002              
                }

                return result;
            }
        }

        public void ClearDatabase()
        {
            using (SqlConnection connection = new SqlConnection(GenerateConnectionString()))
            {
                connection.Open();

                SqlCommand comm = new SqlCommand("DELETE FROM tblEmployee", connection);
                comm.ExecuteNonQuery();
            }
        }

        public DataSet GetAllEmployees()
        {
            SqlConnection dataConn = new SqlConnection(GenerateConnectionString());
            SqlDataAdapter sqlAdptr = new SqlDataAdapter("SELECT ID,fldLastName,fldFirstName,fldMiddleName,fldCity,country,civilstatus,province,street,sex,religion,citizenship,child,age,birthday,datehired,position,school,yeargraduated,school1,yeargraduated1,school2,yeargraduated2,picture,salary,NoOfDependent FROM tblEmployee ORDER BY fldEmpIDAuto DESC", dataConn);
            DataSet sqlDataset = new DataSet();


            sqlAdptr.SelectCommand.CommandType = CommandType.Text;
            sqlAdptr.Fill(sqlDataset);

            return sqlDataset;
        }

        public DataSet GetAllTax()
        {
            DataSet myDataSet = null;
            SqlCommand cmd;
            try
            {
                SqlConnection cn = new SqlConnection(GenerateConnectionString());
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                cmd = new SqlCommand("SELECT (TaxNo)as [Tax Number],(TaxFrom)as [Tax From],(TaxTo) as [TaxTo],(PercentOver)as [Percent Over], (TaxExemption) as [Tax Exemption], (CivilStatus)as [Civil Status], (Dependent)as [Dependent], (NoOfDependent)as [Number of Dependent] FROM Tax ", cn);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                myDataSet = new DataSet();
                myDA.Fill(myDataSet, "UserInfo");
                myDataSet.Tables[0].Constraints.Add("UserID", myDataSet.Tables[0].Columns[0], true);
                //DataGridView2.DataSource = myDataSet.Tables[0];
                cn.Close();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting all Tax Data from database",ex);
            }

            return myDataSet;
        }

        //public string AddNewEmployee(PictureBox imageBox)
        //{
        //    string insertQuery = "INSERT INTO tblEmployee(ID,fldLastName,fldFirstName,fldMiddleName,fldCity,country,civilstatus,province,street,sex,religion,citizenship,child,age,birthday,datehired,position,school,yeargraduated,school1,yeargraduated1,school2,yeargraduated2,picture,salary,NoOfDependent) SELECT @ID,@lastName,@firstName,@middleName,@City,@country,@civilstatus,@province,@street,@sex,@religion,@citizenship,@child,@age,@birthday,@datehired,@position,@school,@yeargraduated,@school1,@yeargraduated1,@school2,@yeargraduated2,@picture,@salary,@NoOfDependent";
        //    string updateQuery = "UPDATE tblEmployee SET fldEmpIDText=@newEmployeeID WHERE fldEmpIDAuto=@empID";

        //    SqlConnection dataConn = new SqlConnection(GenerateConnectionString());
        //    SqlCommand dataComm;
        //    SqlCommand cmd = new SqlCommand(insertQuery, dataConn);

        //    SqlDataAdapter sqlAdptr = new SqlDataAdapter("SELECT TOP 1 fldEmpIDAuto FROM tblEmployee ORDER BY fldEmpIDAuto DESC", dataConn);
        //    DataSet sqlDataset = new DataSet();


        //    int empID = 0;
        //    string newEmployeeID = "";



        //    try
        //    {
        //        //Insert new record
        //        dataComm = new SqlCommand(insertQuery, dataConn);

        //        dataComm.CommandType = CommandType.Text;
        //        dataComm.Parameters.AddWithValue("@ID", textBox2.Text);
        //        dataComm.Parameters.AddWithValue("@lastName", txtLastName.Text);
        //        dataComm.Parameters.AddWithValue("@firstName", txtFirstName.Text);
        //        dataComm.Parameters.AddWithValue("@middleName", txtMiddleName.Text);
        //        dataComm.Parameters.AddWithValue("@City", textBox1.Text);
        //        dataComm.Parameters.AddWithValue("@country", comboBox3.Text);
        //        dataComm.Parameters.AddWithValue("@civilstatus", comboBox.Text);
        //        dataComm.Parameters.AddWithValue("@province", textBox4.Text);
        //        dataComm.Parameters.AddWithValue("@street", textBox5.Text);
        //        dataComm.Parameters.AddWithValue("@sex", comboBox1.Text);
        //        dataComm.Parameters.AddWithValue("@religion", comboBox4.Text);
        //        dataComm.Parameters.AddWithValue("@citizenship", textBox7.Text);
        //        dataComm.Parameters.AddWithValue("@child", textBox8.Text);
        //        dataComm.Parameters.AddWithValue("@age", textBox9.Text);
        //        dataComm.Parameters.AddWithValue("@birthday", dateTimePicker.Value.ToString("MM/dd/yyyy"));
        //        dataComm.Parameters.AddWithValue("@datehired", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
        //        dataComm.Parameters.AddWithValue("@position", comboBox2.Text);
        //        dataComm.Parameters.AddWithValue("@school", textBox10.Text);
        //        dataComm.Parameters.AddWithValue("@yeargraduated", textBox11.Text);
        //        dataComm.Parameters.AddWithValue("@school1", textBox12.Text);
        //        dataComm.Parameters.AddWithValue("@yeargraduated1", textBox13.Text);
        //        dataComm.Parameters.AddWithValue("@school2", textBox14.Text);
        //        dataComm.Parameters.AddWithValue("@yeargraduated2", textBox15.Text);
        //        dataComm.Parameters.AddWithValue("@salary", textBoxSalary.Text);
        //        dataComm.Parameters.AddWithValue("@NoOfDependent", textBoxDependent.Text);


        //        MemoryStream MemStream = new MemoryStream();
        //        Byte[] DataPic_Update = null;

        //        this.EmpPic.Image.Save(MemStream, ImageFormat.Jpeg);
        //        DataPic_Update = MemStream.GetBuffer();
        //        MemStream.Read(DataPic_Update, 0, DataPic_Update.Length);
        //        //blah

        //        // image content
        //        SqlParameter photo = new SqlParameter("@picture", SqlDbType.Image);
        //        dataComm.Parameters.AddWithValue("@picture", DataPic_Update);
        //        photo.Value = DataPic_Update;
        //        cmd.Parameters.Add(photo);


        //        dataConn.Open();
        //        dataComm.ExecuteNonQuery();

        //        //Get the last auto number from tblEmployee 
        //        sqlAdptr.SelectCommand.CommandType = CommandType.Text;
        //        sqlAdptr.Fill(sqlDataset);

        //        //Generate employee with customized format
        //        empID = Convert.ToInt32(sqlDataset.Tables[0].Rows[0]["fldEmpIDAuto"]);
        //        newEmployeeID = "EMP" + string.Format("{0:00000}", empID);

        //        //Update newly added record. assign the newly generated employee ID

        //        dataComm = new SqlCommand(updateQuery, dataConn);

        //        dataComm.CommandType = CommandType.Text;
        //        dataComm.Parameters.AddWithValue("@newEmployeeID", newEmployeeID);
        //        dataComm.Parameters.AddWithValue("@empID", empID);


        //        dataComm.ExecuteNonQuery();


        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    {
        //        if (dataConn.State == ConnectionState.Open)
        //        { dataConn.Close(); }
        //    }
        //}
    }


    public class MockEmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public string GenerateEmployeeId()
        {
            return "EMP-10001";
        }

        public void ClearDatabase()
        {
           Debug.WriteLine("I cleared the db in a mock fasion");
        }

        public DataSet GetAllEmployees()
        {
            DataSet dsTemp = new DataSet();
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("Column1", typeof (string));
            DataRow dr = dtTemp.NewRow();
            dr["Column1"] = "some value";

            dsTemp.Tables.Add(dtTemp);
            dtTemp.Rows.Add(dr);

            return dsTemp;
        }

        public DataSet GetAllTax()
        {
            return null;
        }
    }
}
