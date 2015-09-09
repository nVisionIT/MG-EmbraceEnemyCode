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
    public partial class SSSEntry : Form
    {
        SqlCommand cmd;
        DataSet myDataSet;
        public SSSEntry()
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

                cmd = new SqlCommand("SELECT (SSSSalaryBracetNo)as [SSS Salary Bracet No.],(SalaryRangeFrom)as [Salary Range From],(SalaryRangeTo) as [Salary Range To],(SalaryBase)as [Salary Base], (SocialSecurityEmployerShare) as [Social Security Employer Share], (SocialSecurityEmployeeShare)as [Social Security Employee Share], (SocialSecurityTotal)as [Social Security Total], (EmployerShare)as [EmployerShare], (TotalContributionEmployeeShare)as [Total Contribution Employee Share], (TotalContributionEmployerShare)as [Total Contribution Employer Share], (TotalContribution)as [Total Contribution], (TotalContributionForSEVMOFW)as [Total Contribution For SEVMOFW] FROM SSS ", cn);
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
        private void SSSEntry_Load(object sender, EventArgs e)
        {
            DataSetFill();
        }
    }
}
