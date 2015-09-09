using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payroll
{
    public partial class Holiday : Form
    {

        private Holidays holiday;
        private Counts counts;
        private Admin admin;
        public Holiday()
        {
            InitializeComponent();
            holiday = new Holidays();
            counts = new Counts();
            admin = new Admin();
        }

        private void ClearControls()
        {
            textBoxHolidayID.Clear();
            textBoxHolidayName.Clear();
            comboBoxStatus.Text = "Select One";
            richTextBoxReason.Clear();
            dateTimePickerDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        }

        private void GenerateID()
        {
            admin.GetCountHoliday(counts);
            if (Convert.ToInt32(counts.Countss) == 0)
            {
                string newID = "HOLIDAY-10001";
                textBoxHolidayID.Text = newID.ToString();

            }
            else
            {
                admin.GetLastIDHoliday(counts);
                string id = counts.LastID.Substring(8, 5);
                int increment = Convert.ToInt32(id) + 1;
                string newIDs = "HOLIDAY-" + increment;
                textBoxHolidayID.Text = newIDs.ToString();

            }
        }

        private bool ValidateControls()
        {
            //|| !System.Text.RegularExpressions.Regex.IsMatch(textBoxDepartmentName.Text, "^[a-zA-Z]+$")
            //System.Text.RegularExpressions.Regex.IsMatch(textBoxDepartmentName.Text, "^\\£?[+-]?[\\d,]*\\.?\\d{0,2}$")
            if (textBoxHolidayName.Text == "")
            {
                MessageBox.Show(textBoxHolidayName + "Please fill out empty fields.", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHolidayName.Focus();
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxHolidayName.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Input Correct Format only character will be accepted.", "Input Correct Format.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHolidayName.Focus();
                return false;
            }

            if (comboBoxStatus.Text == "" || comboBoxStatus.Text == "Select One")
            {
                MessageBox.Show(comboBoxStatus + "Please fill out empty fields.", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxStatus.Focus();
                return false;
            }

            if (richTextBoxReason.Text == "")
            {
                MessageBox.Show(richTextBoxReason + "Please fill out empty fields.", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBoxReason.Focus();
                return false;
            }

            return true;

        }


        private void TransferToObject()
        {

            //assign values from the controls to the object
            holiday.HolidayNo = textBoxHolidayID.Text;
            holiday.HolidayName = textBoxHolidayName.Text;
            holiday.HolidayReason = richTextBoxReason.Text;
            holiday.Status = comboBoxStatus.Text;
            holiday.HolidayDate = dateTimePickerDate.Text;
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewHoliday.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxHolidayID.Text = selectedRow.Cells["HolidayID"].Value.ToString();
            textBoxHolidayName.Text = selectedRow.Cells["HolidayName"].Value.ToString();
            dateTimePickerDate.Text = selectedRow.Cells["HolidayDate"].Value.ToString();
            comboBoxStatus.Text = selectedRow.Cells["Status"].Value.ToString();
            richTextBoxReason.Text = selectedRow.Cells["HolidayReason"].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordHoliday(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRow(holiday);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                GenerateID();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoliday.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewHoliday.SelectedRows[0].Index;

                    admin.EditRow(holiday, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewHoliday.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewHoliday.SelectedRows[0].Index;
                        admin.DeleteRow(holiday, selectedIndex);
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
            dataGridViewHoliday.ClearSelection();
            ClearControls();
            GenerateID();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxHolidayName_Validated(object sender, EventArgs e)
        {
            if (textBoxHolidayName.Text == "")
            {
                errorProvider1.SetError(textBoxHolidayName, "Please fill out empty fields");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxHolidayName.Text, "^[a-zA-Z]+$"))
            {
                errorProvider1.SetError(textBoxHolidayName, "Please fill input correct format");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxStatus_Validated(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text == "" || comboBoxStatus.Text == "Select One")
            {
                errorProvider1.SetError(comboBoxStatus, "Please fill out empty fields");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void richTextBoxReason_Validated(object sender, EventArgs e)
        {
              if (richTextBoxReason.Text == "")
            {
                errorProvider1.SetError(richTextBoxReason, "Please fill out empty fields");
            }
            else
            {
                errorProvider1.Clear();
            }
        
        }

        private void Holiday_Load(object sender, EventArgs e)
        {
            dataGridViewHoliday.DataSource = admin.DataSet.Tables["Holiday"];
            dataGridViewHoliday.ClearSelection();
            GenerateID();

        }

        private void dataGridViewHoliday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHoliday.SelectedRows.Count >= 0)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                TransferToControls();
            }
        }
    }
}
