using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using payroll.Class;

namespace payroll.Forms
{
    public partial class FormPosition : Form
    {
        private Admin admin;
        private Position positions;
        public FormPosition()
        {
            InitializeComponent();
            admin = new Admin();
            positions = new Position();
            
        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            dataGridViewPosition.DataSource = admin.DataSet.Tables["JoinPosition"];
            
        }
        #region Validation Methods

        private void ClearControls()
        {
            textBoxPositionID.Clear();
            textBoxPositionName.Clear();
            textBoxSalary.Clear();
            //comboBoxDepartment.Text = "Select One";
        }

        private bool ValidateControls()
        {
            if (textBoxPositionName.Text == "")
            {
                MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPositionName.Focus();
                return false;
            }
            //else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPositionName.Text, "^[a-zA-Z]+$"))
            //{
            //    MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    textBoxPositionName.Focus();
            //    return false;
            //}

            //if (comboBoxDepartment.Text == "Select One")
            //{
            //    MessageBox.Show("Please fill out empty fields.", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    comboBoxDepartment.Focus();
            //    return false;
            //}

            if (textBoxSalary.Text == "0" || textBoxSalary.Text == "")
            {
                MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSalary.Focus();
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSalary.Text, "^\\£?[+-]?[\\d,]*\\.?\\d{0,2}$"))
            {
                MessageBox.Show("Please Input Correct Format only number will be accepted.", "Input Correct Format.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSalary.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region Transfer Data

        private void TransferToObject()
        {

            //assign values from the controls to the object
            positions.PositionID = textBoxPositionID.Text;
            positions.PositionName = textBoxPositionName.Text;
            positions.Salary = Int32.Parse(textBoxSalary.Text);
            //positions.Department.DepartmentID = comboBoxDepartment.SelectedValue.ToString();
            //positions.Department.DepartmentName = comboBoxDepartment.Text;
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewPosition.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxPositionID.Text = selectedRow.Cells["PositionID"].Value.ToString();
            textBoxPositionName.Text = selectedRow.Cells["PositionName"].Value.ToString();
            textBoxSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
            //comboBoxDepartment.Text = selectedRow.Cells["DepartmentName"].Value.ToString();
        }
        #endregion

        private void dataGridViewPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPosition.SelectedRows.Count >= 0)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                TransferToControls();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPosition(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPosition(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(positions);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordPosition();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPosition.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();
                    int selectedIndex = dataGridViewPosition.SelectedRows[0].Index;
                    admin.EditRow(positions, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    admin.RefreshRecordPosition();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewPosition.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewPosition.SelectedRows[0].Index;
                        admin.DeleteRow(positions, selectedIndex);
                        ClearControls();
                        admin.RefreshRecordPosition();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewPosition.ClearSelection();
            ClearControls();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

    }
}
