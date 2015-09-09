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
    public partial class Philheath : Form
    {
        private Admin admin;
        private Philhealth philHealth;
        public Philheath()
        {
            InitializeComponent();
            admin = new Admin();
            philHealth = new Philhealth();
        }

        private void Philheath_Load(object sender, EventArgs e)
        {
            dataGridViewPhilHealth.DataSource = admin.DataSet.Tables["PhilHealth"];
        }
        #region Validation Methods

        private void ClearControls()
        {
            textBoxID.Clear();
            textBoxSalaryRangeFrom.Text = "0";
            textBoxSalaryRangeTo.Text = "0";
            textBoxSalaryBase.Text = "0";
            textBoxEmployeeShare.Text = "0";
            textBoxEmployerShare.Text = "0";
            textBoxTotalMonthlyPremium.Text = "0";
        }

        private bool ValidateControls()
        {
            List<TextBox> textBoxList = new List<TextBox>();
            textBoxList.Add(textBoxSalaryRangeFrom);
            textBoxList.Add(textBoxSalaryRangeTo);
            textBoxList.Add(textBoxSalaryBase);
            textBoxList.Add(textBoxEmployeeShare);
            textBoxList.Add(textBoxEmployerShare);
            textBoxList.Add(textBoxTotalMonthlyPremium);
            foreach (TextBox tempTextBox in textBoxList)
            {
                if (tempTextBox.Text == "")
                {
                    MessageBox.Show("Please fill out empty field(s).", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tempTextBox.Focus();
                    return false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(tempTextBox.Text, "^\\£?[+-]?[\\d,]*\\.?\\d{0,2}$"))
                {
                    MessageBox.Show("Please Input Correct Format only number will be accepted.", "Input Correct Format.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tempTextBox.Focus();
                    return false;
                }

            }
            return true;
        }
        #endregion
        #region Transfer Data

        private void TransferToObject()
        {

            //assign values from the controls to the object
            philHealth.PhilHealthSalaryBracetNo = textBoxID.Text;
            philHealth.SalaryRangeFrom = decimal.Parse(textBoxSalaryRangeFrom.Text);
            philHealth.SalaryRangeTo = decimal.Parse(textBoxSalaryRangeTo.Text);
            philHealth.SalaryBase = decimal.Parse(textBoxSalaryBase.Text);
            philHealth.EmployeeShare = decimal.Parse(textBoxEmployeeShare.Text);
            philHealth.EmployerShare = decimal.Parse(textBoxEmployerShare.Text);
            philHealth.TotalMonthlyPremium = decimal.Parse(textBoxTotalMonthlyPremium.Text);
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewPhilHealth.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxID.Text = selectedRow.Cells["PhilHealthSalaryBracetNo"].Value.ToString();
            textBoxSalaryRangeFrom.Text = selectedRow.Cells["SalaryRangeFrom"].Value.ToString();
            textBoxSalaryRangeTo.Text = selectedRow.Cells["SalaryRangeTo"].Value.ToString();
            textBoxSalaryBase.Text = selectedRow.Cells["SalaryBase"].Value.ToString();
            textBoxEmployeeShare.Text = selectedRow.Cells["EmployeeShare"].Value.ToString();
            textBoxEmployerShare.Text = selectedRow.Cells["EmployeeShare"].Value.ToString();
            textBoxTotalMonthlyPremium.Text = selectedRow.Cells["TotalMonthlyPremium"].Value.ToString();
        }

        #endregion
        private void dataGridViewPhilHealth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhilHealth.SelectedRows.Count >= 0)
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
            admin.SearchRecordPhilHealth(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPhilHealth(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(philHealth);
                admin.RefreshRecordPhilHealth();
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhilHealth.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewPhilHealth.SelectedRows[0].Index;

                    admin.EditRow(philHealth, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewPhilHealth.SelectedRows.Count >= 0)
                {
                    TransferToObject();
                    int selectedIndex = dataGridViewPhilHealth.SelectedRows[0].Index;
                    admin.DeleteRow(philHealth, selectedIndex);
                    MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewPhilHealth.ClearSelection();
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
