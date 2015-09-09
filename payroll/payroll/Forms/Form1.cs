using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.Sql;

using System.Data.Odbc;
using System.Diagnostics;
using System.IO;

namespace payroll
{
    // REVIEW: MOOAS GANI – 5 – Rename Form1 to a Meaningful Form like frmLogin
    public partial class Form1 : Form
    {

         public Form1()
        {
            InitializeComponent();
           
        }
         private string User = "";
        private bool isvalid = false;
   
        public bool isValid
        {
            get { return isvalid; }
        }

        public string getUser
        {
            get { return User; }
        }


        private void sValidate()
        {


            if (Strings.Len(Strings.Trim(TxtAdminUserName.Text)) == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAdminUserName.Focus();
                return;
            }
            if (Strings.Len(Strings.Trim(TxtAdminPassword.Text)) == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtAdminPassword.Focus();
                return;
            }

            try
            {
                // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
                SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True");

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                // REVIEW: MOOAS GANI – 5 – Refactor this into a Security/Autentication module that does authentication
                SqlDataReader dr1 = null;
                SqlCommand com = new SqlCommand();
                com.CommandText = "select [UserName],[Pass] from AdminInfo where UserName = @UName";

            
                SqlParameter UName = new SqlParameter("@UName", SqlDbType.VarChar, 20);
                UName.Value = Strings.UCase(TxtAdminUserName.Text.ToString());
                com.Parameters.Add(UName);
                com.Connection = cn;

                dr1 = com.ExecuteReader();
                if (dr1.Read())
                {
                    if (Strings.UCase(dr1["Pass"].ToString()) == Strings.UCase(TxtAdminPassword.Text.ToString()))
                    {
                        cn.Close();

                        // REVIEW: MOOAS GANI – 1 – Remove this commented code below
                            //Program.FrmState = "Admin";
                            //Program.UserName = Strings.UCase(TxtAdminUserName.Text.ToString());
                        //this.Hide();
                        //MessageBox.Show("Have A Nice Day", ":)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Menu obj = new Menu();
                        //obj.Show();
                       
                        
                            isvalid = true;
                            User = TxtAdminUserName.Text;
                            MessageBox.Show("Login Success", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Close();
                            return;
                        

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            sValidate();
        }
           


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // REVIEW: MOOAS GANI – 5 – Duplicate code 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        // REVIEW: MOOAS GANI – 5 – Duplicate code 
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void textboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        // REVIEW: MOOAS GANI – 5 – Rename this method and associated button to a meaningful and more descriptive name i.e. [btnTimeAttendance]
        private void button1_Click(object sender, EventArgs e)
        {
            // REVIEW: MOOAS GANI – 1 – Remove commented code below
            //AttendanceTimeOut attendanceTimeOut;
            //attendanceTimeOut = new AttendanceTimeOut();
            //attendanceTimeOut.MdiParent = this;
            //attendanceTimeOut.Show();

            AttendanceTimeOut obj = new AttendanceTimeOut();
            obj.Show();
        }

    }
}
