using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace payroll.Forms
{
    public partial class EmployeeEntry : Form
    {
        SqlCommand cmd;
        DataSet myDataSet;

       
        public EmployeeEntry()
        {

            InitializeComponent();
        }
        void DataSetFill()
        {
            try
            {
                SqlConnection cn = new SqlConnection(@" Data Source=JUNEBUG;Initial Catalog=FP_SAMPLE;Integrated Security=True  ");
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                cmd = new SqlCommand("SELECT (ID)as [Employee ID],(fldLastName)as [Last name],(fldFirstName) as [First name],(fldMiddleName)as [Middle Name], (fldCity) as [City], (Country)as [Country], (civilstatus)as [Civil Status],(province)as [Province],(street) as [Street],(sex)as [Sex], (religion) as [Religion], (citizenship)as [Citizenship], (child)as [Children],(Age)as [Age],(birthday) as [Birth Day],(datehired)as [Date Hired], (position) as [Position], (school)as [School],(yeargraduated)as [Year Graduated],(school1)as [School],(yeargraduated1) as [Year Graduated],(school2)as [School], (yeargraduated2) as [Year Graduated], (salary)as [Salary], (NoOfDependent)as [Number Of Dependent]  FROM tblEmployee ", cn);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                myDataSet = new DataSet();
                myDA.Fill(myDataSet, "UserInfo");
                myDataSet.Tables[0].Constraints.Add("UserID", myDataSet.Tables[0].Columns[0], true);
                DataGridView2.DataSource = myDataSet.Tables[0];
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return;
            }

        }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            DataSetFill();
         
        }
    }
}
