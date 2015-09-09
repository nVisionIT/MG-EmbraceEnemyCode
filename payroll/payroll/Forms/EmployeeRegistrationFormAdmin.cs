using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;
using PayrollSystem.Data.Repository;
using PayrollSystem.DataAccess;
using PayrollSystem.Interfaces.Injection;
using PayrollSystem.Interfaces.Repositories;

namespace payroll
{
    public partial class EmployeeRegistrationFormAdmin : Form
    {

        string connectionString = "";
        private Admin admin;
        private Attendnces attendances;
        public EmployeeRegistrationFormAdmin()
        {
            InitializeComponent();
            admin = new Admin();
            attendances = new Attendnces();
        }


        private void GenerateID()
        {
            textBox2.Text = new EmployeeData(new EmployeeRepository()).GenerateId();


            // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True");
            //conn.Open();
            //SqlCommand comm = new SqlCommand("SELECT COUNT(ID) FROM tblEmployee", conn);
            //Int32 count = (Int32)comm.ExecuteScalar();
            //if (count == 0)
            //{
            //    string newId = "EMP-10001";
            //    textBox2.Text = newId; //ito ung paglalagyan  mo ng new generated id
            //}
            //else
            //{
            //    SqlCommand comm1 = new SqlCommand("SELECT Max(ID) FROM tblEmployee", conn);
            //    Object returnvalue = (Object)comm1.ExecuteScalar();
            //    string strReturn = returnvalue.ToString(); //convert object to string	

            //    string Id = strReturn.Substring(4, 5); //icucut nya un USG-10001 bali ang value ng Id = 10001
            //    // REVIEW: MOOAS GANI – 4 – Do error handling around this string to int conversion
            //    int increment = Convert.ToInt32(Id) + 1; //tapos convert ung string to int.. value ng increment= 10001 + 1
            //    string newId = "EMP-" + increment; // tapos to magiging USG-10002
            //    textBox2.Text = newId;
            //}

            //// REVIEW: MOOAS GANI – 5 – Replace this connection close as the above statement allows it not be reached
            //conn.Close();


        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // REVIEW: MOOAS GANI – 5 – Refactor these statement into its own Validate Method
            try
            {
                if (txtLastName.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    txtLastName.Focus();
                    return;
                }
                if (txtFirstName.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    txtFirstName.Focus();
                    return;
                }
                if (txtMiddleName.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    txtMiddleName.Focus();
                    return;
                }
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox1.Focus();
                    return;
                }
                if (comboBox3.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    comboBox3.Focus();
                    return;
                }
                if (comboBox.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    comboBox.Focus();
                    return;
                }
                if (textBox4.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox4.Focus();
                    return;
                }
                if (textBox5.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox5.Focus();
                    return;
                }
                if (comboBox1.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    comboBox1.Focus();
                    return;
                }
                if (comboBox4.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    comboBox4.Focus();
                    return;
                }
                if (textBox7.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox7.Focus();
                    return;
                }
                if (textBox8.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox8.Focus();
                    return;
                }
                if (textBox9.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox9.Focus();
                    return;
                }
                if (comboBox2.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    comboBox2.Focus();
                    return;
                }
                if (textBox10.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox10.Focus();
                    return;
                }
                if (textBox11.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox11.Focus();
                    return;
                }
                if (textBox12.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox12.Focus();
                    return;
                }
                if (textBox13.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox13.Focus();
                    return;
                }
                if (textBox14.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox14.Focus();
                    return;
                }
                if (textBox15.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBox15.Focus();
                    return;
                }
                if (textBoxSalary.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBoxSalary.Focus();
                    return;
                }
                if (textBoxDependent.Text.Length == 0)
                {
                    MessageBox.Show("please enter all fields.");
                    textBoxDependent.Focus();
                    return;
                }
                AddEmployee();

                MessageBox.Show("record successfully save.");

                // REVIEW: MOOAS GANI – 3 – Refactor the below into a reset/cleanup method
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";
                textBox1.Text = "";
                comboBox3.Text = "";
                comboBox.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox4.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                comboBox2.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";

                //REVIEW: MOOSA GANI – 3 – Apply error handling and fail safe fallover for images that are not found
                //REVIEW: MOOSA GANI – 2 – Use configurable resources
                EmpPic.Image = System.Drawing.Image.FromFile(Application.StartupPath.ToString() + "\\Image\\personal.PNG");

                GenerateID();

                txtLastName.Focus();

                PopulateEmployeeList();


            }
            catch (Exception)
            {
                // REVIEW: MOOAS GANI – 5 – Handle error. Log it and provide a meaningful error message and application continuity here
                throw;
            }
            finally
            { }
        }

        private void PopulateEmployeeList()
        {

            EmployeeData empoyeeData = new EmployeeData(new EmployeeRepository());
            DataSet dsEmployees = empoyeeData.GetAllEmployees();

            grdEmployee.DataSource = dsEmployees.Tables[0];
            grdEmployee.Refresh();

            //SqlConnection dataConn = new SqlConnection(connectionString);
            //SqlDataAdapter sqlAdptr = new SqlDataAdapter("SELECT ID,fldLastName,fldFirstName,fldMiddleName,fldCity,country,civilstatus,province,street,sex,religion,citizenship,child,age,birthday,datehired,position,school,yeargraduated,school1,yeargraduated1,school2,yeargraduated2,picture,salary,NoOfDependent FROM tblEmployee ORDER BY fldEmpIDAuto DESC", dataConn);
            //DataSet sqlDataset = new DataSet();

            //try
            //{

            //    sqlAdptr.SelectCommand.CommandType = CommandType.Text;
            //    sqlAdptr.Fill(sqlDataset);

            //    grdEmployee.DataSource = sqlDataset.Tables[0];
            //    grdEmployee.Refresh();


            //}
            //catch (Exception)
            //{

            //    throw;
            //}


        }
        
        private void AddEmployee()
        {
            string insertQuery = "INSERT INTO tblEmployee(ID,fldLastName,fldFirstName,fldMiddleName,fldCity,country,civilstatus,province,street,sex,religion,citizenship,child,age,birthday,datehired,position,school,yeargraduated,school1,yeargraduated1,school2,yeargraduated2,picture,salary,NoOfDependent) SELECT @ID,@lastName,@firstName,@middleName,@City,@country,@civilstatus,@province,@street,@sex,@religion,@citizenship,@child,@age,@birthday,@datehired,@position,@school,@yeargraduated,@school1,@yeargraduated1,@school2,@yeargraduated2,@picture,@salary,@NoOfDependent";
            string updateQuery = "UPDATE tblEmployee SET fldEmpIDText=@newEmployeeID WHERE fldEmpIDAuto=@empID";

            SqlConnection dataConn = new SqlConnection(connectionString);
            SqlCommand dataComm;
            SqlCommand cmd = new SqlCommand(insertQuery, dataConn);

            SqlDataAdapter sqlAdptr = new SqlDataAdapter("SELECT TOP 1 fldEmpIDAuto FROM tblEmployee ORDER BY fldEmpIDAuto DESC", dataConn);
            DataSet sqlDataset = new DataSet();


            int empID = 0;
            string newEmployeeID = "";



            try
            {
                //Insert new record
                dataComm = new SqlCommand(insertQuery, dataConn);

                dataComm.CommandType = CommandType.Text;
                dataComm.Parameters.AddWithValue("@ID", textBox2.Text);
                dataComm.Parameters.AddWithValue("@lastName", txtLastName.Text);
                dataComm.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                dataComm.Parameters.AddWithValue("@middleName", txtMiddleName.Text);
                dataComm.Parameters.AddWithValue("@City", textBox1.Text);
                dataComm.Parameters.AddWithValue("@country", comboBox3.Text);
                dataComm.Parameters.AddWithValue("@civilstatus", comboBox.Text);
                dataComm.Parameters.AddWithValue("@province", textBox4.Text);
                dataComm.Parameters.AddWithValue("@street", textBox5.Text);
                dataComm.Parameters.AddWithValue("@sex", comboBox1.Text);
                dataComm.Parameters.AddWithValue("@religion", comboBox4.Text);
                dataComm.Parameters.AddWithValue("@citizenship", textBox7.Text);
                dataComm.Parameters.AddWithValue("@child", textBox8.Text);
                dataComm.Parameters.AddWithValue("@age", textBox9.Text);
                dataComm.Parameters.AddWithValue("@birthday", dateTimePicker.Value.ToString("MM/dd/yyyy"));
                dataComm.Parameters.AddWithValue("@datehired", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                dataComm.Parameters.AddWithValue("@position", comboBox2.Text);
                dataComm.Parameters.AddWithValue("@school", textBox10.Text);
                dataComm.Parameters.AddWithValue("@yeargraduated", textBox11.Text);
                dataComm.Parameters.AddWithValue("@school1", textBox12.Text);
                dataComm.Parameters.AddWithValue("@yeargraduated1", textBox13.Text);
                dataComm.Parameters.AddWithValue("@school2", textBox14.Text);
                dataComm.Parameters.AddWithValue("@yeargraduated2", textBox15.Text);
                dataComm.Parameters.AddWithValue("@salary", textBoxSalary.Text);
                dataComm.Parameters.AddWithValue("@NoOfDependent", textBoxDependent.Text);


                MemoryStream MemStream = new MemoryStream();
                Byte[] DataPic_Update = null;

                this.EmpPic.Image.Save(MemStream, ImageFormat.Jpeg);
                DataPic_Update = MemStream.GetBuffer();
                MemStream.Read(DataPic_Update, 0, DataPic_Update.Length);
                //blah

                // image content
                SqlParameter photo = new SqlParameter("@picture", SqlDbType.Image);
                dataComm.Parameters.AddWithValue("@picture", DataPic_Update);
                photo.Value = DataPic_Update;
                cmd.Parameters.Add(photo);


                dataConn.Open();
                dataComm.ExecuteNonQuery();

                //Get the last auto number from tblEmployee 
                sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                sqlAdptr.Fill(sqlDataset);

                //Generate employee with customized format
                empID = Convert.ToInt32(sqlDataset.Tables[0].Rows[0]["fldEmpIDAuto"]);
                newEmployeeID = "EMP" + string.Format("{0:00000}", empID);

                //Update newly added record. assign the newly generated employee ID

                dataComm = new SqlCommand(updateQuery, dataConn);

                dataComm.CommandType = CommandType.Text;
                dataComm.Parameters.AddWithValue("@newEmployeeID", newEmployeeID);
                dataComm.Parameters.AddWithValue("@empID", empID);


                dataComm.ExecuteNonQuery();


            }
            catch (Exception)
            { throw; }
            finally
            {
                if (dataConn.State == ConnectionState.Open)
                { dataConn.Close(); }
            }


        }

        private void EmployeeRegistrationFormAdmin_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = admin.DataSet.Tables["JoinPosition"];
            comboBox2.DisplayMember = "PositionName";
            comboBox2.ValueMember = "PositionName";

            GenerateID();
            try
            {
                //connectionString = @"Data Source=(local);Initial Catalog=FP_SAMPLE;User ID=sa;Password=password";
                connectionString = @"Data Source=(local);Initial Catalog=FP_SAMPLE;Trusted_Connection=True;";
                PopulateEmployeeList();

            }
            catch (Exception)
            { throw; }
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Photo:";
                OpenFile.Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*";
                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.EmpPic.Image = System.Drawing.Image.FromFile(OpenFile.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");

            }
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            this.EmpPic.Image = System.Drawing.Image.FromFile(Application.StartupPath.ToString() + "\\Image\\personal.PNG");
        }

        private void cmdEnroll_Click(object sender, EventArgs e)
        {
            string currentEmployeeID = "";

            ProcessStartInfo processLaucher;
            Process fpProcess;

            try
            {

                if (grdEmployee.RowCount == 0)
                {
                    MessageBox.Show("no employee selected.");
                    return;
                }

                currentEmployeeID = grdEmployee[0, grdEmployee.CurrentRow.Index].Value.ToString();

                if (currentEmployeeID.Length == 0)
                {
                    MessageBox.Show("no employee selected.");
                    return;
                }


                UpdateEmployeeFingerPrint(currentEmployeeID);

                //REVIEW: MOOSA GANI – 3 – Apply error handling and fail safe fallover for images that are not found
                //REVIEW: MOOSA GANI – 2 – Use configurable resources
                processLaucher = new ProcessStartInfo(Application.StartupPath + @"\REGISTER_FP.exe");
                fpProcess = Process.Start(processLaucher);
                fpProcess.WaitForExit();

                DeleteReferenceTable1();


            }
            catch (Exception)
            { throw; }
        }

        private void UpdateEmployeeFingerPrint(string employeeID)
        {
            string insertReferenceTableQuery = "INSERT INTO tblReference (fldUser) SELECT @empID ";
            //string deleteFingerPrintQuery = "DELETE  FROM tblEmployeeFingerPrint WHERE fldEmpIDText='" + employeeID + "'";
            
            try
            {

                SqlConnection dataConn = new SqlConnection(connectionString);
                SqlCommand dataComm;

                dataConn.Open();

                ////Delete existing finger print data from tblEmployeeFingerPrintTable 
                //dataComm = new SqlCommand(deleteFingerPrintQuery, dataConn);
                //dataComm.CommandType = CommandType.Text;
                //dataComm.ExecuteNonQuery();

                //Insert employee to the reference table
                dataComm = new SqlCommand(insertReferenceTableQuery, dataConn);
                dataComm.CommandType = CommandType.Text;
                dataComm.Parameters.AddWithValue("@empID", employeeID);
                dataComm.ExecuteNonQuery();


            }
            catch (Exception)
            { throw; }
        }
        private void DeleteReferenceTable1()
        {
            //NICK: CODE BELOW WAS REFACTORED BUT THE OTHER PARTS WERE NOT COMMITTED AND PUSHED HENCE LEAVING A HALF JOB.

            //new EmployeeData(new EmployeeRepository()).Delete_tblReference();
            
            //string deleteReferenceTableQuery = "DELETE FROM tblReference";


            //try
            //{

            //    SqlConnection dataConn = new SqlConnection(connectionString);
            //    SqlCommand dataComm;

            //    dataConn.Open();

            //    //Clear reference table 
            //    dataComm = new SqlCommand(deleteReferenceTableQuery, dataConn);
            //    dataComm.CommandType = CommandType.Text;
            //    dataComm.ExecuteNonQuery();


            //}
            //catch (Exception)
            //{ throw; }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            textBox1.Text = "";
            comboBox3.Text = "";
            comboBox.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox2.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBoxSalary.Text = "";
            textBoxDependent.Text = "";
            EmpPic.Image = System.Drawing.Image.FromFile(Application.StartupPath.ToString() + "\\Image\\personal.PNG");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }


        private void DeleteReferenceTable()
        {
            string deleteReferenceTableQuery = "DELETE FROM tblReference";


            try
            {

                SqlConnection dataConn = new SqlConnection(connectionString);
                SqlCommand dataComm;

                dataConn.Open();

                //Clear reference table 
                dataComm = new SqlCommand(deleteReferenceTableQuery, dataConn);
                dataComm.CommandType = CommandType.Text;
                dataComm.ExecuteNonQuery();


            }
            catch (Exception)
            { throw; }
        }


        private void cmdEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection dataConn = new SqlConnection(connectionString);
            SqlDataAdapter sqlAdptr;
            SqlCommand dataComm;

            DataSet sqlDataset = new DataSet();

            string currentEmployeeID = "";
            string insertQuery = "";
            string updateQuery = "";


            int currentMonth = 0;
            int currentDay = 0;
            int currentYear = 0;
            int TotalHours = 0;
            int TotalLate = 0;

            ProcessStartInfo processLaucher;
            Process fpProcess;

            try
            {
                //REVIEW: MOOSA GANI – 3 – Apply error handling and fail safe fallover for images that are not found
                //REVIEW: MOOSA GANI – 2 – Use configurable sub applications
                processLaucher = new ProcessStartInfo(Application.StartupPath + @"\VERIFY_FP.exe");
                fpProcess = Process.Start(processLaucher);
                fpProcess.WaitForExit();

                //Get employee id
                sqlAdptr = new SqlDataAdapter("SELECT fldUser FROM tblReference WHERE fldStatus='OK'", dataConn);
                sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                sqlAdptr.Fill(sqlDataset);

                if (sqlDataset.Tables[0].Rows.Count > 0)
                { currentEmployeeID = Convert.ToString(sqlDataset.Tables[0].Rows[0]["fldUser"]); }
                else
                {
                    MessageBox.Show("finger print verification was cancelled.");
                    return;
                }

                //clear up reference table
                DeleteReferenceTable();
                

                //register time logs to employee attendance table

                currentMonth = DateTime.Now.Month;
                currentDay = DateTime.Now.Day;
                currentYear = DateTime.Now.Year;

                sqlDataset.Tables.Clear();

                sqlAdptr = new SqlDataAdapter("SELECT fldEmpID,fldAttendanceDate,fldTimeIn,fldTimeOut FROM tblEmployeeAttendance WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear), dataConn);
                sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                sqlAdptr.Fill(sqlDataset);

                if (sqlDataset.Tables[0].Rows.Count > 0)
                {
                    DateTime timeIn;
                    DateTime timeOut;
                    TimeSpan totalNoOfHours;
                    
                    updateQuery = "UPDATE tblEmployeeAttendance SET fldTimeOut=@timeOut WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear);
                    dataComm = new SqlCommand(updateQuery, dataConn);

                    dataComm.CommandType = CommandType.Text;
                    dataComm.Parameters.AddWithValue("@timeOut", string.Format("{0:hh:mm:ss tt}", DateTime.Now));

                    dataConn.Open();
                    dataComm.ExecuteNonQuery();

                    sqlDataset.Tables.Clear();

                    sqlAdptr = new SqlDataAdapter("SELECT fldEmpID,fldAttendanceDate,fldTimeIn,fldTimeOut FROM tblEmployeeAttendance WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear), dataConn);
                    sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                    sqlAdptr.Fill(sqlDataset);

                    attendances.Employee.EmoloyeeID = sqlDataset.Tables[0].Rows[0]["fldEmpID"].ToString();
                    attendances.TimeIn = sqlDataset.Tables[0].Rows[0]["fldTimeIn"].ToString();
                    attendances.TimeOut = sqlDataset.Tables[0].Rows[0]["fldTimeOut"].ToString();
                    timeIn = Convert.ToDateTime(attendances.TimeIn);
                    timeOut = Convert.ToDateTime(attendances.TimeOut);
                    totalNoOfHours = timeOut.Subtract(timeIn);
                    if (Int32.Parse(totalNoOfHours.Minutes.ToString()) >= 45)
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString());
                    }
                    else
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString()) - 1;
                    }
                    TotalLate = 8 - TotalHours;

                    updateQuery = "UPDATE tblEmployeeAttendance SET TotalNoOfHours=@hours,TotalNoOfLate=@late WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear);
                    dataComm = new SqlCommand(updateQuery, dataConn);

                    dataComm.CommandType = CommandType.Text;
                    dataComm.Parameters.AddWithValue("@hours", TotalHours);
                    dataComm.Parameters.AddWithValue("@late", TotalLate);

                   
                    dataComm.ExecuteNonQuery();
                }
                else
                {
                    //if no record exist add time log

                    insertQuery = "INSERT INTO tblEmployeeAttendance (fldEmpID,fldAttendanceDate,fldTimeIn) SELECT @empID,@attDate,@timeIn";
                    dataComm = new SqlCommand(insertQuery, dataConn);

                    dataComm.CommandType = CommandType.Text;
                    dataComm.Parameters.AddWithValue("@empID", currentEmployeeID);
                    dataComm.Parameters.AddWithValue("@attDate", string.Format("{0:MM/dd/yyyy}", DateTime.Now));
                    dataComm.Parameters.AddWithValue("@timeIn", string.Format("{0:hh:mm:ss tt}", DateTime.Now));

                    dataConn.Open();
                    dataComm.ExecuteNonQuery();

                }


                sqlDataset.Tables.Clear();

                sqlAdptr = new SqlDataAdapter("SELECT fldLastName+', '+fldFirstName  AS [Name],[position],ID  FROM tblEmployee WHERE ID='" + currentEmployeeID + "'", dataConn);
                sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                sqlAdptr.Fill(sqlDataset);

                if (sqlDataset.Tables[0].Rows.Count > 0)
                {
                    //EmployeeProfileAttendance obj = new EmployeeProfileAttendance();
                    //obj.Show();
                    MessageBox.Show(@"Verification Result." +
                                    "\n\nName :" + sqlDataset.Tables[0].Rows[0]["Name"] +
                                    "\n\nPosition :" + sqlDataset.Tables[0].Rows[0]["position"] +
                                    "\n\nDate Logged :" + string.Format("{0:MM/dd/yyyy}", DateTime.Now) +
                                    "\n\nTime Logged :" + string.Format("{0:hh:mm:ss tt}", DateTime.Now));

                                    
                }

              

                dataConn.Close();

            }
            catch (Exception)
            { throw; }

        }

        public static payroll.Menu midParent { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in admin.DataSet.Tables["JoinPosition"].Rows)
            {
                if (comboBox2.Text == dataRow["PositionName"].ToString())
                {
                    textBoxSalary.Text = dataRow["Salary"].ToString();
                }

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Today.Year - dateTimePicker.Value.Year; // CurrentYear - BirthDate

            textBox9.Text = Age.ToString();
        }
    }
    }

