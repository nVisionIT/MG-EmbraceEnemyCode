using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PayrollSystem.Data.Repository;
using PayrollSystem.DataAccess;

namespace payroll.Forms
{
    public partial class TaxEntry : Form
    {
        SqlCommand cmd;
        DataSet myDataSet;
        public TaxEntry()
        {
            InitializeComponent();
        }
        void DataSetFill()
        {
            DataGridView2.DataSource = new EmployeeData(new EmployeeRepository()).GetAllTax().Tables[0];

            //try
            //{
            //    SqlConnection cn = new SqlConnection(@" Data Source=JUNEBUG;Initial Catalog=FP_SAMPLE;Integrated Security=True  ");
            //    if (cn.State == ConnectionState.Open)
            //    {
            //        cn.Close();
            //    }
            //    cn.Open();

            //    cmd = new SqlCommand("SELECT (TaxNo)as [Tax Number],(TaxFrom)as [Tax From],(TaxTo) as [TaxTo],(PercentOver)as [Percent Over], (TaxExemption) as [Tax Exemption], (CivilStatus)as [Civil Status], (Dependent)as [Dependent], (NoOfDependent)as [Number of Dependent] FROM Tax ", cn);
            //    SqlDataAdapter myDA = new SqlDataAdapter(cmd);
            //    myDataSet = new DataSet();
            //    myDA.Fill(myDataSet, "UserInfo");
            //    myDataSet.Tables[0].Constraints.Add("UserID", myDataSet.Tables[0].Columns[0], true);
            //    DataGridView2.DataSource = myDataSet.Tables[0];
            //    cn.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Error");
            //    return;
            //}

        }
        private void TaxEntry_Load(object sender, EventArgs e)
        {
            DataSetFill();
        }
    }
}
