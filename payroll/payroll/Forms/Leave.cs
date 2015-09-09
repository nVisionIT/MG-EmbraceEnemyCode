using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace payroll
{
    public partial class Leave : Form
    {
        private Admin admin;
        private Leaves leave;
        // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
        private SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True");
        public Leave()
        {
            InitializeComponent();
            admin = new Admin();
            leave = new Leaves();
            //FillComboInstructor();
        }


        // REVIEW: MOOAS GANI – 2 – IF CODE NOT BEING USED REMOVE. IT IS IN SOURCE CONTROL. YOU CAN RETRIEVE IT IF NECESSARY
        //void FillComboInstructor()
        //{

        //    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True"))
        //    {
        //        try
        //        {
        //            string query = "SELECT fldLastName+', '+fldFirstName+' '+fldMiddleName  AS [Name],ID  FROM tblEmployee";
        //            // query ang ginagawa nito pag pinindot yung combo box makikita as Name or isa nalang yung mga fields na yan sa database
        //            SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //            conn.Open();
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "tblEmployee");

        //            comboBoxName.DisplayMember = "ID";
        //            comboBoxName.ValueMember = "ID";
        //            comboBoxName.DataSource = ds.Tables["tblEmployee"];
        //        }

        //        catch (Exception)
        //        {
        //            // write exception info to log or anything else
        //            MessageBox.Show("Error occured!");
        //        }
        //    }
        //}


        private void Leave_Load(object sender, EventArgs e)
        {
            dataGridViewLeave.DataSource = admin.DataSet.Tables["JoinEmployeeLeave"];
            dataGridViewLeave.AllowUserToAddRows = false;
            dataGridViewLeave.ClearSelection();
            comboBoxName.DataSource = admin.Dt.Tables["LeaveEmployee"];

            //display DepartmentName
            comboBoxName.DisplayMember = "fullname";

            //assign DepartmentID as the value
            comboBoxName.ValueMember = "ID";
        }
        # region Validation
        private void ClearControls()
        {
            textBoxLeaveID.Clear();
            dateTimePickerStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateTimePickerEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            textBoxNoOFDays.Clear();
            comboBoxReason.Text = "Select One";
            comboBoxName.Text = "Select One";
        }

        private bool ValidateControls()
        {
            DateTime date1 = Convert.ToDateTime(dateTimePickerStartDate.Text);
            DateTime date2 = DateTime.Now;
            DateTime date3 = Convert.ToDateTime(dateTimePickerEndDate.Text);
            if (date1 <= date2 || date3 <= date2)
            {
                MessageBox.Show("Please Input Correct Format only character will be accepted.", "Input Correct Format.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePickerStartDate.Focus();
                return false;
            }
            if (date1 > date3)
            {
                MessageBox.Show("Please Input Correct Format only character will be accepted.", "Input Correct Format.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePickerEndDate.Focus();
                return false;
            }
            if (comboBoxReason.Text == "Select One")
            {
                MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxReason.Focus();
                return false;
            }
            if (comboBoxName.Text == "Select One")
            {
                MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxName.Focus();
                return false;
            }
            return true;
        }
        #endregion
        # region tranfer data
        private void TransferToObject()
        {

            //assign values from the controls to the object
            leave.Employee.EmoloyeeID =  comboBoxName.SelectedValue.ToString();
            leave.LeaveID = textBoxLeaveID.Text;
            leave.StartDate = dateTimePickerStartDate.Text;
            leave.EndDate = dateTimePickerEndDate.Text;
            leave.NoOfDays = textBoxNoOFDays.Text;
            leave.Reason = comboBoxReason.Text;
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewLeave.SelectedRows[0];
            //assign values from the selectedRow to the controls
            comboBoxName.Text = selectedRow.Cells["fullname"].Value.ToString();
            textBoxLeaveID.Text = selectedRow.Cells["LeaveID"].Value.ToString();
            dateTimePickerStartDate.Text = selectedRow.Cells["StartDate"].Value.ToString();
            dateTimePickerEndDate.Text = selectedRow.Cells["EndDate"].Value.ToString();
            textBoxNoOFDays.Text = selectedRow.Cells["NoOfDays"].Value.ToString();
            comboBoxReason.Text = selectedRow.Cells["Reason"].Value.ToString();
        }
        private void NoOfLeave()
        {
            leave.NoOfDays = textBoxNoOFDays.Text;
            int remain = 0;
            int leaveno = 0;
            foreach (DataRow dataRow in admin.DataSet.Tables["JoinEmployeeNoOfLeave"].Rows)
            {
                MessageBox.Show("fuck you :))");
                if (comboBoxName.Text == dataRow["fullname"].ToString())
                {
                    MessageBox.Show("fuck you");
                    leaveno = Int32.Parse(dataRow["LeaveNo"].ToString());
                    if (comboBoxReason.Text == "Maternity")
                    {
                        remain = Int32.Parse(dataRow["Maternity"].ToString());
                        MessageBox.Show("fuck you :)");
                    }
                    else if (comboBoxReason.Text == "Paternity")
                    {
                        remain = Int32.Parse(dataRow["Paternity"].ToString());
                    }
                    else if (comboBoxReason.Text == "SickLeave")
                    {
                        remain = Int32.Parse(dataRow["SickLeave"].ToString());
                    }
                    else if (comboBoxReason.Text == "VacationLeave")
                    {
                        remain = Int32.Parse(dataRow["VacationLeave"].ToString());
                    }
                }
            }
            
            remain = remain - Int32.Parse(leave.NoOfDays);
            if (comboBoxReason.Text == "Maternity")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("trocedureUpdateMaternity", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@remain", remain);
                cmd.Parameters.AddWithValue("@leave", leaveno);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (comboBoxReason.Text == "Paternity")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("trocedureUpdatePaternity", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@remain", remain);
                cmd.Parameters.AddWithValue("@leave", leaveno);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (comboBoxReason.Text == "SickLeave")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("trocedureUpdateSickLeave", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@remain", remain);
                cmd.Parameters.AddWithValue("@leave", leaveno);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (comboBoxReason.Text == "VacationLeave")
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("trocedureUpdateVacationLeave", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@remain", remain);
                cmd.Parameters.AddWithValue("@leave", leaveno);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStartDate.Value;
            DateTime end = dateTimePickerEndDate.Value;
            DateTime tmp = start;
            int counte = 0;
            while (tmp <= end)
            {
                if (tmp.DayOfWeek != DayOfWeek.Saturday && tmp.DayOfWeek != DayOfWeek.Sunday)
                {
                    counte++;
                }
                tmp = tmp.AddDays(1);
            }

            textBoxNoOFDays.Text = counte.ToString();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStartDate.Value;
            DateTime end = dateTimePickerEndDate.Value;
            DateTime tmp = start;
            int counte = 0;
            while (tmp <= end)
            {
                if (tmp.DayOfWeek != DayOfWeek.Saturday && tmp.DayOfWeek != DayOfWeek.Sunday)
                {
                    counte++;
                }
                tmp = tmp.AddDays(1);
            }

            textBoxNoOFDays.Text = counte.ToString();
        }

        private void dataGridViewLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLeave.SelectedRows.Count >= 0)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                comboBoxName.Enabled = false;
                TransferToControls();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordLeave(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordLeave(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            if (ValidateControls())
            {
                TransferToObject();
                NoOfLeave();
                admin.AddRecord(leave);
                admin.RefreshRecordNoOfLeave();
                foreach (DataRow dataRow in admin.DataSet.Tables["JoinEmployeeNoOfLeave"].Rows)
                {
                    if (comboBoxName.Text == dataRow["fullname"].ToString())
                    {
                        a = dataRow["Maternity"].ToString();
                        b = dataRow["Paternity"].ToString();
                        c = dataRow["SickLeave"].ToString();
                        d = dataRow["VacationLeave"].ToString();
                    }
                }
                admin.RefreshRecordELeave();
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(@"Remaining Leave of" + "\n\nName :" + comboBoxName.Text + "\n\nMaternity :" + a + "\n\nPaternity :" + b + "\n\nSick Leave :" + c + "\n\nVacation Leave:" + d);
                ClearControls();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLeave.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewLeave.SelectedRows[0].Index;

                    admin.EditRow(leave, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewLeave.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewLeave.SelectedRows[0].Index;
                        admin.DeleteRow(leave, selectedIndex);
                        MessageBox.Show("Record Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewLeave.ClearSelection();
            comboBoxName.Enabled = true;
            ClearControls();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
             string constring = @"Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True";
            string Query = "SELECT fldLastName+', '+fldFirstName+' '+fldMiddleName  AS [Name],ID  FROM tblEmployee WHERE ID='" + comboBoxName.Text + "' ;";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string sfldID = myReader.GetString(myReader.GetOrdinal("Name"));

                    textBoxLeaveID.Text = sfldID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        
    
        }
    }
}
