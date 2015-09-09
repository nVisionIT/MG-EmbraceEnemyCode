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

namespace payroll
{
    public partial class AttendanceTimeOut : Form
    {
         string connectionString = "";
        private Admin admin;
        private Attendnces attendances;
        
        public AttendanceTimeOut()
        {
            InitializeComponent();
             admin = new Admin();
            attendances = new Attendnces();
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
          //  EnableButton();
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
                    DateTime timeOuts;
                    DateTime timeIns;
                    TimeSpan totalNoOfHours;
                    String TimeOut;
                    string TimeIn;
                    
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
                    timeOuts = Convert.ToDateTime("1/1/1900 12:00:00 PM");
                    timeIns = Convert.ToDateTime("1/1/1900 8:00:00 AM");
                    if (Convert.ToDateTime(attendances.TimeOut) > timeOuts)
                    {
                        TimeOut = attendances.TimeOut.Substring(0, 9) + " " + "12:00:00 PM";
                    }
                    else
                    {
                        TimeOut = attendances.TimeOut;
                    }
                    if (Convert.ToDateTime(attendances.TimeIn) < timeIns)
                    {
                        TimeIn = attendances.TimeIn.Substring(0, 9) + " " + "8:00:00 AM";
                    }
                    else
                    {
                        TimeIn = attendances.TimeIn;
                    }
                    timeIn = Convert.ToDateTime(TimeIn);
                    timeOut = Convert.ToDateTime(TimeOut);
                    totalNoOfHours = timeOut.Subtract(timeIn);
                    if (Int32.Parse(totalNoOfHours.Minutes.ToString()) >= 45)
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString()) + 1;
                    }
                    else
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString());
                    }
                    TotalLate = 4 - TotalHours;

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

                admin.RefreshRecordAttendances();
                admin.RefreshRecordAttendance();
              

                dataConn.Close();

            }
            catch (Exception)
            { throw; }

        }
        //public void EnableButton()
        //{
        //    DateTime asa;
        //    string a, b;
        //    asa = DateTime.Now;
        //    a = asa.ToString();
        //    b = a.Substring(0, 9) + " " + "1:00:00 PM";
        //    if (DateTime.Now <= Convert.ToDateTime(b))
        //    {
        //        cmdEmployee.Enabled = true;
        //        button1.Enabled = false; ;
        //    }
        //    else
        //    {
        //        cmdEmployee.Enabled = false;
        //        button1.Enabled = true;
        //    }
        //}
        private void AttendanceTimeOut_Load(object sender, EventArgs e)
        {

         //   EnableButton();

            admin.RefreshRecordAttendance();
            admin.RefreshRecordAttendances();
            dataGridView1.DataSource = admin.Dt.Tables["AttendanceMorning"];
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewAfterNoon.DataSource = admin.DataSet.Tables["AttendanceAfterNoon"];
            dataGridViewAfterNoon.AllowUserToAddRows = false;
            try
            {
                //connectionString = @"Data Source=(local);Initial Catalog=FP_SAMPLE;User ID=sa;Password=password";
                connectionString = @"Data Source=(local);Initial Catalog=FP_SAMPLE;Trusted_Connection=True;";
               

            }
            catch (Exception)
            { throw; }

                     
        }

        private void tmrCurTime_Tick(object sender, EventArgs e)
        {
            int strHour = Convert.ToInt32(DateTime.Now.Hour.ToString("00"));
            string strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " ";
            if (strHour > 12)
            {

                strHour = strHour - 12;
                strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " ";
            }
            label2.Text = DateTime.Now.Date.ToLongDateString();
            label1.Text = strTime;

            if (DateTime.Now.ToString("tt") == "AM")
            {
                label4.Text = "AM";
            }
            else if (DateTime.Now.ToString("tt") == "PM")
            {
                label4.Text = "PM";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EnableButton();
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

                sqlAdptr = new SqlDataAdapter("SELECT fldEmpID,fldAttendanceDate,fldTimeIn,fldTimeOut FROM tblEmployeeAttendance1 WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear), dataConn);
                sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                sqlAdptr.Fill(sqlDataset);

                if (sqlDataset.Tables[0].Rows.Count > 0)
                {
                    DateTime timeIn;
                    DateTime timeOut;
                    DateTime timeOuts;
                    DateTime timeIns;
                    TimeSpan totalNoOfHours;
                    String TimeOut;
                    string TimeIn;

                    updateQuery = "UPDATE tblEmployeeAttendance1 SET fldTimeOut=@timeOut WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear);
                    dataComm = new SqlCommand(updateQuery, dataConn);

                    dataComm.CommandType = CommandType.Text;
                    dataComm.Parameters.AddWithValue("@timeOut", string.Format("{0:hh:mm:ss tt}", DateTime.Now));

                    dataConn.Open();
                    dataComm.ExecuteNonQuery();

                    sqlDataset.Tables.Clear();

                    sqlAdptr = new SqlDataAdapter("SELECT fldEmpID,fldAttendanceDate,fldTimeIn,fldTimeOut FROM tblEmployeeAttendance1 WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear), dataConn);
                    sqlAdptr.SelectCommand.CommandType = CommandType.Text;
                    sqlAdptr.Fill(sqlDataset);

                    attendances.Employee.EmoloyeeID = sqlDataset.Tables[0].Rows[0]["fldEmpID"].ToString();
                    attendances.TimeIn = sqlDataset.Tables[0].Rows[0]["fldTimeIn"].ToString();
                    attendances.TimeOut = sqlDataset.Tables[0].Rows[0]["fldTimeOut"].ToString();
                    timeOuts = Convert.ToDateTime("1/1/1900 5:00:00 PM");
                    timeIns = Convert.ToDateTime("1/1/1900 1:00:00 PM");
                    if (Convert.ToDateTime(attendances.TimeOut) > timeOuts)
                    {
                        TimeOut = attendances.TimeOut.Substring(0, 9) + " " + "5:00:00 PM";
                    }
                    else
                    {
                        TimeOut = attendances.TimeOut;
                    }
                    if (Convert.ToDateTime(attendances.TimeIn) < timeIns)
                    {
                        TimeIn = attendances.TimeIn.Substring(0, 9) + " " + "1:00:00 PM";
                    }
                    else
                    {
                        TimeIn = attendances.TimeIn;
                    }
                    timeIn = Convert.ToDateTime(TimeIn);
                    timeOut = Convert.ToDateTime(TimeOut);
                    totalNoOfHours = timeOut.Subtract(timeIn);
                    if (Int32.Parse(totalNoOfHours.Minutes.ToString()) >= 45)
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString()) + 1;
                    }
                    else
                    {
                        TotalHours = Int32.Parse(totalNoOfHours.Hours.ToString());
                    }
                    TotalLate = 4 - TotalHours;

                    updateQuery = "UPDATE tblEmployeeAttendance1 SET TotalNoOfHours=@hours,TotalNoOfLate=@late WHERE fldEmpID='" + currentEmployeeID + "' AND MONTH(fldAttendanceDate)=" + string.Format("{0:#0}", currentMonth) + " AND DAY(fldAttendanceDate)=" + string.Format("{0:#0}", currentDay) + " AND YEAR(fldAttendanceDate)=" + string.Format("{0:0000}", currentYear);
                    dataComm = new SqlCommand(updateQuery, dataConn);

                    dataComm.CommandType = CommandType.Text;
                    dataComm.Parameters.AddWithValue("@hours", TotalHours);
                    dataComm.Parameters.AddWithValue("@late", TotalLate);


                    dataComm.ExecuteNonQuery();
                }
                else
                {
                    //if no record exist add time log

                    insertQuery = "INSERT INTO tblEmployeeAttendance1 (fldEmpID,fldAttendanceDate,fldTimeIn) SELECT @empID,@attDate,@timeIn";
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
                admin.RefreshRecordAttendance();
                admin.RefreshRecordAttendances();


                dataConn.Close();

            }
            catch (Exception)
            { throw; }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cloudDigitalClock1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        }
        
        
    }
       

