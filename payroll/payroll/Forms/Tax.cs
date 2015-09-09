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
    public partial class Tax : Form
    {
        private Admin admin;
        private Taxs tax;
        public Tax()
        {
            InitializeComponent();
            admin = new Admin();
            tax = new Taxs();
        }

        private void Tax_Load(object sender, EventArgs e)
        {
            //set up dataGridView dataSource to Tax
            dataGridViewTax.DataSource = admin.DataSet.Tables["Tax"];
        }
        #region Validation Methods

        private void ClearControls()
        {
            textBoxTaxNo.Clear();
            textBoxTaxFrom.Text = "0.00";
            textBoxTaxTo.Text = "0.00";
            textBoxPercentOver.Text = "0.00";
            textBoxTaxExemption.Text = "0.00";
            comboBoxCivilStatus.Text = "Select One";
            comboBoxDepentdent.Text = "Select One";
            comboBoxNoOfDependent.Text = "Select One";
            comboBoxNoOfDependent.Enabled = false;
        }

        private bool ValidateControls()
        {
            List<TextBox> textBoxList = new List<TextBox>();
            textBoxList.Add(textBoxTaxTo);
            textBoxList.Add(textBoxTaxFrom);
            textBoxList.Add(textBoxPercentOver);
            textBoxList.Add(textBoxTaxExemption);
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
            List<ComboBox> ComBoxList = new List<ComboBox>();
            ComBoxList.Add(comboBoxCivilStatus);
            ComBoxList.Add(comboBoxDepentdent);
            ComBoxList.Add(comboBoxNoOfDependent);
            foreach (ComboBox tempComBoBox in ComBoxList)
            {
                if (tempComBoBox.Text == "Select One" && tempComBoBox.Enabled == true)
                {
                    MessageBox.Show("Please Select one from choice", "Empty fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tempComBoBox.Focus();
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
            tax.TaxNo = textBoxTaxNo.Text;
            tax.TaxFrom = decimal.Parse(textBoxTaxFrom.Text);
            tax.TaxTo= decimal.Parse(textBoxTaxTo.Text);
            tax.PercentOver = decimal.Parse(textBoxPercentOver.Text);
            tax.TaxExemption = decimal.Parse(textBoxTaxExemption.Text);
            tax.CivilStatus = comboBoxCivilStatus.Text;
            if (comboBoxCivilStatus.Text == "Zero Exemption")
            {
                tax.Dependent = "not applicable";
            }
            else
            {
                tax.Dependent = comboBoxDepentdent.Text;
            }
            if (comboBoxDepentdent.Text == "With Out Dependent" || comboBoxDepentdent.Text == "Select One")
            {
                tax.NoOfDependent = "0";
            }
            else
            {
                tax.NoOfDependent = comboBoxNoOfDependent.Text;
            }
        }

        private void TransferToControls()
        {
            //set up selectedRow from the dataGridView
            DataGridViewRow selectedRow = dataGridViewTax.SelectedRows[0];

            //assign values from the selectedRow to the controls
            textBoxTaxNo.Text = selectedRow.Cells["TaxNo"].Value.ToString();
            textBoxTaxFrom.Text = selectedRow.Cells["TaxFrom"].Value.ToString();
            textBoxTaxTo.Text = selectedRow.Cells["TaxTo"].Value.ToString();
            textBoxPercentOver.Text = selectedRow.Cells["PercentOver"].Value.ToString();
            textBoxTaxExemption.Text = selectedRow.Cells["TaxExemption"].Value.ToString();
            comboBoxCivilStatus.Text = selectedRow.Cells["CivilStatus"].Value.ToString();
            comboBoxDepentdent.Text = selectedRow.Cells["Dependent"].Value.ToString();
            comboBoxNoOfDependent.Text = selectedRow.Cells["NoOfDependent"].Value.ToString();
        }
        #endregion
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordTax(search);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            admin.SearchRecordTax(search);
        }

        private void dataGridViewTax_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTax.SelectedRows.Count >= 0)
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                TransferToControls();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                TransferToObject();
                admin.AddRecord(tax);
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordTax();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTax.SelectedRows.Count >= 0)
            {
                TransferToObject();
                int selectedIndex = dataGridViewTax.SelectedRows[0].Index;
                admin.EditRow(tax, selectedIndex);
                MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                admin.RefreshRecordTax();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Records.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewTax.SelectedRows.Count >= 0)
                {
                    TransferToObject();
                    int selectedIndex = dataGridViewTax.SelectedRows[0].Index;
                    admin.DeleteRow(tax, selectedIndex);
                    ClearControls();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            dataGridViewTax.ClearSelection();
            ClearControls();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBoxCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCivilStatus.Text == "Zero Exemption")
            {
                comboBoxDepentdent.Enabled = false;
            }
            else
            {
                comboBoxDepentdent.Enabled = true;
            }
        }

        private void comboBoxDepentdent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepentdent.Text == "With Dependent")
            {
                comboBoxNoOfDependent.Enabled = true;
            }
            else
            {
                comboBoxNoOfDependent.Enabled = false;
                comboBoxNoOfDependent.Text = "Select One";
            }
        }

        private void comboBoxNoOfDependent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
