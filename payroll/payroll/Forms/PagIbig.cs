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
    public partial class PagIbig : Form
    {
        private Admin admin;
        private PagIbigs pagIbig;
        public PagIbig()
        {
            InitializeComponent();
            admin = new Admin();
            pagIbig = new PagIbigs();
        }

        private void textBoxMonthlyCompensationFrom_Click(object sender, EventArgs e)
        {
            textBoxMonthlyCompensationFrom.Clear();
        }
        private void PagIbig_Load(object sender, EventArgs e)
        {
            dataGridViewPagIbig.DataSource = admin.DataSet.Tables["PagIbig"];
        }
        #region Validation Methods

        private void ClearControls()
        {
            textBoxID.Clear();
            textBoxEmployeeShare.Text = "0.00";
            textBoxEmployerShare.Text = "0.00";
            textBoxMonthlyCompensationFrom.Text = "0.00";
            textBoxMonthlyCompensationTo.Text = "0.00";
            textBoxTotalMonthlyContribution.Text = "0.00";
        }

        private bool ValidateControls()
        {
            List<TextBox> textBoxList = new List<TextBox>();
            textBoxList.Add(textBoxTotalMonthlyContribution);
            textBoxList.Add(textBoxEmployeeShare);
            textBoxList.Add(textBoxEmployerShare);
            textBoxList.Add(textBoxTotalMonthlyContribution);
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
            pagIbig.PagIbigSalaryBracetNo = textBoxID.Text;
            pagIbig.MonthlyCompensationFrom = decimal.Parse(textBoxMonthlyCompensationFrom.Text);
            pagIbig.MonthlyCompensationTo = decimal.Parse(textBoxMonthlyCompensationTo.Text);
            pagIbig.EmployeeShare = decimal.Parse(textBoxEmployeeShare.Text);
            pagIbig.EmployerShare = decimal.Parse(textBoxEmployerShare.Text);
            pagIbig.TotalMonthlyContribution = decimal.Parse(textBoxTotalMonthlyContribution.Text);
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewPagIbig.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxID.Text = selectedRow.Cells["PagIbigSalaryBracetNo"].Value.ToString();
            textBoxMonthlyCompensationFrom.Text = selectedRow.Cells["MonthlyCompensationFrom"].Value.ToString();
            textBoxMonthlyCompensationTo.Text = selectedRow.Cells["MonthlyCompensationTo"].Value.ToString();
            textBoxEmployeeShare.Text = selectedRow.Cells["EmployeeShare"].Value.ToString();
            textBoxEmployerShare.Text = selectedRow.Cells["EmployeeShare"].Value.ToString();
            textBoxTotalMonthlyContribution.Text = selectedRow.Cells["TotalMonthlyContribution"].Value.ToString();
        }
        #endregion
        private void dataGridViewPagIbig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPagIbig.SelectedRows.Count >= 0)
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
            admin.SearchRecordPagIbig(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordPagIbig(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(pagIbig);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordPagIbig();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagIbig.SelectedRows.Count >= 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewPagIbig.SelectedRows[0].Index;

                    admin.EditRow(pagIbig, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    admin.RefreshRecordPagIbig();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewPagIbig.SelectedRows.Count > 0)
                {
                    TransferToObject();
                    int selectedIndex = dataGridViewPagIbig.SelectedRows[0].Index;
                    admin.DeleteRow(pagIbig, selectedIndex);
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
            dataGridViewPagIbig.ClearSelection();
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
