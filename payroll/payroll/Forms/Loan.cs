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
    public partial class Loan : Form
    {
        private Admin admin;
        private Class.Loan loan;
        public Loan()
        {
            InitializeComponent();
            admin = new Admin();
            loan = new Class.Loan();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            dataGridViewLoan.DataSource = admin.DataSet.Tables["JoinEmployeeLoan"];
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.ClearSelection();
            comboBoxName.DataSource = admin.Dt.Tables["LeaveEmployee"];

            //display DepartmentName
            comboBoxName.DisplayMember = "fullname";

            //assign DepartmentID as the value
            comboBoxName.ValueMember = "ID";
        }
        # region Validation
        private void ClearControls()
        {
            textBoxLoanID.Clear();
            dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            textBoxAmountLoan.Clear();
            textBoxTotalAmortization.Clear();
            comboBoxName.Text = "Select One";
            comboBoxLoan.Text = "Select One";
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
            loan.Employee.EmoloyeeID = comboBoxName.SelectedValue.ToString();
            loan.LoanID = textBoxLoanID.Text;
            loan.StartDate = dateTimePickerStart.Text;
            loan.EndDate = dateTimePickerEnd.Text;
            loan.Amountloan = decimal.Parse(textBoxAmountLoan.Text);
            loan.TotalAmorzitation = decimal.Parse(textBoxTotalAmortization.Text);
            loan.TypeLoan = comboBoxLoan.Text;
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewLoan.SelectedRows[0];
            //assign values from the selectedRow to the controls
            comboBoxName.Text = selectedRow.Cells["fullname"].Value.ToString();
            textBoxLoanID.Text = selectedRow.Cells["LoanNo"].Value.ToString();
            dateTimePickerStart.Text = selectedRow.Cells["StartDate"].Value.ToString();
            dateTimePickerEnd.Text = selectedRow.Cells["EndDate"].Value.ToString();
            textBoxAmountLoan.Text = selectedRow.Cells["AmountLoan"].Value.ToString();
            textBoxTotalAmortization.Text = selectedRow.Cells["TotalAmorzitation"].Value.ToString();
            comboBoxLoan.Text = selectedRow.Cells["TypeOfLoan"].Value.ToString();
        }
        #endregion
        private void dataGridViewLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLoan.SelectedRows.Count >= 0)
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
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(loan);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordLoan();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoan.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewLoan.SelectedRows[0].Index;

                    admin.EditRow(loan, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewLoan.SelectedRows.Count >= 0)
                {
                    if (ValidateControls())
                    {
                        TransferToObject();
                        int selectedIndex = dataGridViewLoan.SelectedRows[0].Index;
                        admin.DeleteRow(loan, selectedIndex);
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
            dataGridViewLoan.ClearSelection();
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
    }
}
