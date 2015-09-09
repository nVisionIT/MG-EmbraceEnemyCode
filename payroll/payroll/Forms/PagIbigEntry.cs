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
    public partial class PagIbigEntry : Form
    {
        SqlCommand cmd;
        DataSet myDataSet;
        public PagIbigEntry()
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

                cmd = new SqlCommand("SELECT (PagIbigSalaryBracetNo)as [PagIbig Salary BracetNo.],(MonthlyCompensationFrom)as [Monthly Compensation From],(MonthlyCompensationTo) as [Monthly Compensation To],(EmployeeShare)as [Employee Share], (EmployerShare) as [Employer Share], (TotalMonthlyContribution)as [Total Monthly Contribution] FROM PagIbig ", cn);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                myDataSet = new DataSet();
                myDA.Fill(myDataSet, "UserInfo");
                myDataSet.Tables[0].Constraints.Add("UserID", myDataSet.Tables[0].Columns[0], true);
                dataGridView2.DataSource = myDataSet.Tables[0];
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return;
            }

        }
        private void PagIbigEntry_Load(object sender, EventArgs e)
        {
            DataSetFill();
        }
    }
}
