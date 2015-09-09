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
    public partial class FormNoOfLeave : Form
    {
        private Admin admin;
        private NoOfLeave noOfleave;
        public FormNoOfLeave()
        {
            InitializeComponent();
            admin = new Admin();
            noOfleave = new NoOfLeave();
            
        }

        private void FormNoOfLeave_Load(object sender, EventArgs e)
        {
            dataGridViewNoOfLeave.DataSource = admin.DataSet.Tables["JoinEmployeeNoOfLeave"];
            dataGridViewNoOfLeave.AllowUserToAddRows = false;
            dataGridViewNoOfLeave.ClearSelection();
            comboBoxName.DataSource = admin.Dt.Tables["LeaveEmployee"];

            //display DepartmentName
            comboBoxName.DisplayMember = "fullname";

            //assign DepartmentID as the value
            comboBoxName.ValueMember = "ID";

        }
        # region Validation
        private void ClearControls()
        {
            textBoxLeaveNo.Clear();
            textBoxMaternity.Clear();
            textBoxPaternity.Clear();
            textBoxSick.Clear();
            textBoxVacation.Clear();
            comboBoxName.Text = "Select One";
        }

        private bool ValidateControls()
        {
            List<TextBox> textBoxList = new List<TextBox>();
            //textBoxList.Add(textBoxEmployeeID);
            textBoxList.Add(textBoxVacation);
            textBoxList.Add(textBoxSick);
            textBoxList.Add(textBoxPaternity);
            textBoxList.Add(textBoxMaternity);
            foreach (TextBox tempTextBox in textBoxList)
            {
                if (tempTextBox.Text == "")
                {
                    MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tempTextBox.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion
        # region tranfer data
        private void TransferToObject()
        {

            //assign values from the controls to the object
            noOfleave.Employee.EmoloyeeID = comboBoxName.SelectedValue.ToString();
            noOfleave.LeaveNo = textBoxLeaveNo.Text;
            noOfleave.SickLeave = Int32.Parse(textBoxSick.Text);
            noOfleave.VacationLeave = Int32.Parse(textBoxVacation.Text);
            noOfleave.PaternityLeave = Int32.Parse(textBoxPaternity.Text);
            noOfleave.MaternityLeave = Int32.Parse(textBoxMaternity.Text);

        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewNoOfLeave.SelectedRows[0];
            //assign values from the selectedRow to the controls
            comboBoxName.Text = selectedRow.Cells["fullname"].Value.ToString();
            textBoxLeaveNo.Text = selectedRow.Cells["LeaveNo"].Value.ToString();
            textBoxMaternity.Text = selectedRow.Cells["Maternity"].Value.ToString();
            textBoxPaternity.Text = selectedRow.Cells["Paternity"].Value.ToString();
            textBoxSick.Text = selectedRow.Cells["SickLeave"].Value.ToString();
            textBoxVacation.Text = selectedRow.Cells["VacationLeave"].Value.ToString();
        }
        #endregion

        private void dataGridViewNoOfLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNoOfLeave.SelectedRows.Count >= 0)
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
            admin.SearchRecordNoOfLeave(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordNoOfLeave(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(noOfleave);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordNoOfLeave();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewNoOfLeave.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewNoOfLeave.SelectedRows[0].Index;

                    admin.EditRow(noOfleave, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    admin.RefreshRecordNoOfLeave();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewNoOfLeave.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewNoOfLeave.SelectedRows[0].Index;
                        admin.DeleteRow(noOfleave, selectedIndex);
                        MessageBox.Show("Record Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                        admin.RefreshRecordNoOfLeave();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewNoOfLeave.ClearSelection();
            ClearControls();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
