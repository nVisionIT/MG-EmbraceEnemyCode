using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payroll.Forms
{
    public partial class Bonus : Form
    {
        private Admin admin;
        private Class.Bonus bonus;
        public Bonus()
        {
            InitializeComponent();
            admin = new Admin();
            bonus = new Class.Bonus();
        }

        private void Bonus_Load(object sender, EventArgs e)
        {
            dataGridViewBonus.DataSource = admin.DataSet.Tables["JoinEmployeeBonus"];
            dataGridViewBonus.AllowUserToAddRows = false;
            dataGridViewBonus.ClearSelection();
            comboBoxName.DataSource = admin.Dt.Tables["LeaveEmployee"];

            //display DepartmentName
            comboBoxName.DisplayMember = "fullname";

            //assign DepartmentID as the value
            comboBoxName.ValueMember = "ID";
        }
        # region Validation
        private void ClearControls()
        {
            textBoxBonusID.Clear();
            dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            textBoxAmount.Clear();
            comboBoxName.Text = "Select One";
        }

        private bool ValidateControls()
        {

            return true;
        }
        #endregion
        # region tranfer data
        private void TransferToObject()
        {

            //assign values from the controls to the object
            bonus.Employee.EmoloyeeID = comboBoxName.SelectedValue.ToString();
            bonus.BonusID = textBoxBonusID.Text;
            bonus.Date = dateTimePickerStart.Text;
            bonus.Amount = decimal.Parse(textBoxAmount.Text);
            bonus.Type = comboBoxType.Text;
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewBonus.SelectedRows[0];
            //assign values from the selectedRow to the controls
            comboBoxName.Text = selectedRow.Cells["fullname"].Value.ToString();
            textBoxBonusID.Text = selectedRow.Cells["BonusID"].Value.ToString();
            dateTimePickerStart.Text = selectedRow.Cells["Date"].Value.ToString();
            textBoxAmount.Text = selectedRow.Cells["Amount"].Value.ToString();
            comboBoxType.Text = selectedRow.Cells["Type"].Value.ToString();
        }
        #endregion
        private void dataGridViewBonus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBonus.SelectedRows.Count >= 0)
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
            admin.SearchRecordBonus(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordBonus(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(bonus);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordBonus();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBonus.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewBonus.SelectedRows[0].Index;

                    admin.EditRow(bonus, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewBonus.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewBonus.SelectedRows[0].Index;
                        admin.DeleteRow(bonus, selectedIndex);
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
            dataGridViewBonus.ClearSelection();
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

        }
    }
}
