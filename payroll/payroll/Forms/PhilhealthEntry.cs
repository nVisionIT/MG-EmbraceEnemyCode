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
    public partial class PhilhealthEntry : Form
    {
        SqlCommand cmd;
        DataSet myDataSet;
        public PhilhealthEntry()
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

                cmd = new SqlCommand("SELECT (PhilHealthSalaryBracetNo)as [PhilHealth Salary BracetNo.],(SalaryRangeFrom)as [Salary Range From],(SalaryRangeTo) as [Salary Range To],(SalaryBase)as [Salary Base], (EmployeeShare) as [Employee Share], (EmployerShare)as [EmployerShare], (TotalMonthlyPremium)as [Total Monthly Premium] FROM Philhealth ", cn);
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
        private void PhilhealthEntry_Load(object sender, EventArgs e)
        {
            DataSetFill();
        }
    }
}
