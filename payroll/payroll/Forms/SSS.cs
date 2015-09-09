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
    public partial class SSS : Form
    {
        private Admin admin;
        private SSSS sSS;
        public SSS()
        {
            InitializeComponent();
            admin = new Admin();
            sSS = new SSSS();
        }
        #region Validation Methods
        private void ClearControls()
        {
            //textBoxSSSSalaryBracetNo.Clear();
            textBoxSalaryRangeFrom.Text = "0.00";
            textBoxSalaryRangeTo.Text = "0.00";
            textBoxSalaryBase.Text = "0.00"; ;
            textBoxSocialSecurityEmployeeShare.Text = "0.00"; ;
            textBoxSocialSecurityEmployerShare.Text = "0.00"; ;
            textBoxSocialSecurityTotal.Text = "0.00";
            textBoxEmployerShare.Text = "0.00";
            textBoxTotalContributionEmployeeShare.Text = "0.00";
            textBoxTotalContributionEmployerShare.Text = "0.00";
            textBoxTotalContribution.Text = "0.00";
            textBoxTotalContributionForSEVMOFW.Text = "0.00";
            textBoxID.Clear();
        }

        private bool ValidateControls()
        {
            List<TextBox> textBoxList = new List<TextBox>();
            textBoxList.Add(textBoxSalaryRangeFrom);
            textBoxList.Add(textBoxSalaryBase);
            textBoxList.Add(textBoxSocialSecurityEmployeeShare);
            textBoxList.Add(textBoxSocialSecurityEmployerShare);
            textBoxList.Add(textBoxSocialSecurityTotal);
            textBoxList.Add(textBoxEmployerShare);
            textBoxList.Add(textBoxTotalContributionEmployeeShare);
            textBoxList.Add(textBoxTotalContributionEmployerShare);
            textBoxList.Add(textBoxTotalContribution);
            textBoxList.Add(textBoxTotalContributionForSEVMOFW);
            foreach (TextBox tempTextBox in textBoxList)
            {
                if (tempTextBox.Text == "0.00" || tempTextBox.Text == "")
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
            sSS.SSSSalaryBracetNo = textBoxID.Text;
            sSS.SalaryRangeFrom = decimal.Parse(textBoxSalaryRangeFrom.Text);
            sSS.SalaryRangeTo = decimal.Parse(textBoxSalaryRangeTo.Text);
            sSS.SalaryBase = decimal.Parse(textBoxSalaryBase.Text);
            sSS.SocialSecurityEmployeeShare = decimal.Parse(textBoxSocialSecurityEmployeeShare.Text);
            sSS.SocialSecurityEmployerShare = decimal.Parse(textBoxSocialSecurityEmployerShare.Text);
            sSS.SocialSecurityTotal = decimal.Parse(textBoxSocialSecurityTotal.Text);
            sSS.EmployerShare = decimal.Parse(textBoxEmployerShare.Text);
            sSS.TotalContributionEmployeeShare = decimal.Parse(textBoxTotalContributionEmployeeShare.Text);
            sSS.TotalContributionEmployerShare = decimal.Parse(textBoxTotalContributionEmployerShare.Text);
            sSS.TotalContributionEmployeeShare = decimal.Parse(textBoxTotalContribution.Text);
            sSS.TotalContributionForSEVMOFW = decimal.Parse(textBoxTotalContributionForSEVMOFW.Text);
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewSSS.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxID.Text = selectedRow.Cells["SSSSalaryBracetNo"].Value.ToString();
            textBoxSalaryRangeFrom.Text = selectedRow.Cells["SalaryRangeFrom"].Value.ToString();
            textBoxSalaryRangeTo.Text = selectedRow.Cells["SalaryRangeTo"].Value.ToString();
            textBoxSalaryBase.Text = selectedRow.Cells["SalaryBase"].Value.ToString();
            textBoxSocialSecurityEmployeeShare.Text = selectedRow.Cells["SocialSecurityEmployeeShare"].Value.ToString();
            textBoxSocialSecurityEmployerShare.Text = selectedRow.Cells["SocialSecurityEmployerShare"].Value.ToString();
            textBoxSocialSecurityTotal.Text = selectedRow.Cells["SocialSecurityTotal"].Value.ToString(); ;
            textBoxEmployerShare.Text = selectedRow.Cells["EmployerShare"].Value.ToString(); ;
            textBoxTotalContributionEmployeeShare.Text = selectedRow.Cells["TotalContributionEmployeeShare"].Value.ToString();
            textBoxTotalContributionEmployerShare.Text = selectedRow.Cells["TotalContributionEmployerShare"].Value.ToString();
            textBoxTotalContribution.Text = selectedRow.Cells["TotalContribution"].Value.ToString();
            textBoxTotalContributionForSEVMOFW.Text = selectedRow.Cells["TotalContributionForSEVMOFW"].Value.ToString();
        }
        #endregion

        private void dataGridViewSSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSSS.SelectedRows.Count > 0)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                TransferToControls();
            }
        }

        private void SSS_Load(object sender, EventArgs e)
        {
            //set up dataGridView dataSource to SSS
            dataGridViewSSS.DataSource = admin.DataSet.Tables["SSS"];
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordSSS(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordSSS(search);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(sSS);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordSSS();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSSS.SelectedRows.Count > 0)
            {
                if (ValidateControls())
                {
                    TransferToObject();

                    //get selectedIndex from the dataGridView
                    int selectedIndex = dataGridViewSSS.SelectedRows[0].Index;

                    admin.EditRow(sSS, selectedIndex);
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    admin.RefreshRecordSSS();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewSSS.SelectedRows.Count > 0)
                {
                    TransferToObject();
                    int selectedIndex = dataGridViewSSS.SelectedRows[0].Index;
                    admin.DeleteRow(sSS, selectedIndex);
                    ClearControls();
                    admin.RefreshRecordSSS();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewSSS.ClearSelection();
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

