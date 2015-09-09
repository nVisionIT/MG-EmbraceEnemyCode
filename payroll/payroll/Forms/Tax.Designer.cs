namespace payroll
{
    partial class Tax
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTaxTo = new System.Windows.Forms.TextBox();
            this.comboBoxNoOfDependent = new System.Windows.Forms.ComboBox();
            this.comboBoxCivilStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDepentdent = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTaxExemption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPercentOver = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTaxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTaxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTax = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 162;
            this.label8.Text = "Tax To";
            // 
            // textBoxTaxTo
            // 
            this.textBoxTaxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaxTo.Location = new System.Drawing.Point(138, 58);
            this.textBoxTaxTo.MaxLength = 50;
            this.textBoxTaxTo.Name = "textBoxTaxTo";
            this.textBoxTaxTo.Size = new System.Drawing.Size(141, 22);
            this.textBoxTaxTo.TabIndex = 161;
            this.textBoxTaxTo.Text = "0.00";
            // 
            // comboBoxNoOfDependent
            // 
            this.comboBoxNoOfDependent.Enabled = false;
            this.comboBoxNoOfDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNoOfDependent.FormattingEnabled = true;
            this.comboBoxNoOfDependent.IntegralHeight = false;
            this.comboBoxNoOfDependent.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxNoOfDependent.Location = new System.Drawing.Point(138, 203);
            this.comboBoxNoOfDependent.Name = "comboBoxNoOfDependent";
            this.comboBoxNoOfDependent.Size = new System.Drawing.Size(141, 24);
            this.comboBoxNoOfDependent.TabIndex = 160;
            this.comboBoxNoOfDependent.Text = "Select One";
            this.comboBoxNoOfDependent.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoOfDependent_SelectedIndexChanged);
            // 
            // comboBoxCivilStatus
            // 
            this.comboBoxCivilStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCivilStatus.FormattingEnabled = true;
            this.comboBoxCivilStatus.IntegralHeight = false;
            this.comboBoxCivilStatus.Items.AddRange(new object[] {
            "Zero Exemption",
            "Single/Married"});
            this.comboBoxCivilStatus.Location = new System.Drawing.Point(138, 145);
            this.comboBoxCivilStatus.Name = "comboBoxCivilStatus";
            this.comboBoxCivilStatus.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCivilStatus.TabIndex = 159;
            this.comboBoxCivilStatus.Text = "Select One";
            this.comboBoxCivilStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCivilStatus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 158;
            this.label7.Text = "Civil Status";
            // 
            // comboBoxDepentdent
            // 
            this.comboBoxDepentdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepentdent.FormattingEnabled = true;
            this.comboBoxDepentdent.IntegralHeight = false;
            this.comboBoxDepentdent.Items.AddRange(new object[] {
            "With Dependent",
            "With Out Dependent"});
            this.comboBoxDepentdent.Location = new System.Drawing.Point(138, 173);
            this.comboBoxDepentdent.Name = "comboBoxDepentdent";
            this.comboBoxDepentdent.Size = new System.Drawing.Size(141, 24);
            this.comboBoxDepentdent.TabIndex = 157;
            this.comboBoxDepentdent.Text = "Select One";
            this.comboBoxDepentdent.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepentdent_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(538, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 31);
            this.buttonSearch.TabIndex = 156;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(137, 22);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(391, 22);
            this.textBoxSearch.TabIndex = 155;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 154;
            this.label9.Text = "How Many";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 153;
            this.label5.Text = "Dependent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 152;
            this.label6.Text = "Tax Exemption";
            // 
            // textBoxTaxExemption
            // 
            this.textBoxTaxExemption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaxExemption.Location = new System.Drawing.Point(138, 117);
            this.textBoxTaxExemption.MaxLength = 50;
            this.textBoxTaxExemption.Name = "textBoxTaxExemption";
            this.textBoxTaxExemption.Size = new System.Drawing.Size(141, 22);
            this.textBoxTaxExemption.TabIndex = 141;
            this.textBoxTaxExemption.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 151;
            this.label4.Text = "%over";
            // 
            // textBoxPercentOver
            // 
            this.textBoxPercentOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPercentOver.Location = new System.Drawing.Point(138, 84);
            this.textBoxPercentOver.MaxLength = 50;
            this.textBoxPercentOver.Name = "textBoxPercentOver";
            this.textBoxPercentOver.Size = new System.Drawing.Size(141, 22);
            this.textBoxPercentOver.TabIndex = 140;
            this.textBoxPercentOver.Text = "0.00";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::payroll.Properties.Resources.exit1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(229, 68);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 40);
            this.buttonExit.TabIndex = 146;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::payroll.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(114, 68);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 40);
            this.buttonCancel.TabIndex = 145;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::payroll.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(288, 22);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 40);
            this.buttonDelete.TabIndex = 144;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = global::payroll.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(164, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 40);
            this.buttonEdit.TabIndex = 143;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::payroll.Properties.Resources.adding;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(42, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 40);
            this.buttonAdd.TabIndex = 142;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 149;
            this.label3.Text = "Tax From";
            // 
            // textBoxTaxFrom
            // 
            this.textBoxTaxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaxFrom.Location = new System.Drawing.Point(138, 32);
            this.textBoxTaxFrom.MaxLength = 50;
            this.textBoxTaxFrom.Name = "textBoxTaxFrom";
            this.textBoxTaxFrom.Size = new System.Drawing.Size(141, 22);
            this.textBoxTaxFrom.TabIndex = 139;
            this.textBoxTaxFrom.Text = "0.00";
            // 
            // textBoxTaxNo
            // 
            this.textBoxTaxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaxNo.Enabled = false;
            this.textBoxTaxNo.Location = new System.Drawing.Point(619, 21);
            this.textBoxTaxNo.MaxLength = 7;
            this.textBoxTaxNo.Name = "textBoxTaxNo";
            this.textBoxTaxNo.Size = new System.Drawing.Size(31, 22);
            this.textBoxTaxNo.TabIndex = 138;
            this.textBoxTaxNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "Tax Information";
            // 
            // dataGridViewTax
            // 
            this.dataGridViewTax.AllowUserToAddRows = false;
            this.dataGridViewTax.AllowUserToDeleteRows = false;
            this.dataGridViewTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTax.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTax.Location = new System.Drawing.Point(30, 62);
            this.dataGridViewTax.MultiSelect = false;
            this.dataGridViewTax.Name = "dataGridViewTax";
            this.dataGridViewTax.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewTax.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTax.Size = new System.Drawing.Size(727, 241);
            this.dataGridViewTax.TabIndex = 150;
            this.dataGridViewTax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTax_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxTaxFrom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTaxTo);
            this.groupBox1.Controls.Add(this.textBoxPercentOver);
            this.groupBox1.Controls.Add(this.comboBoxNoOfDependent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCivilStatus);
            this.groupBox1.Controls.Add(this.textBoxTaxExemption);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxDepentdent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 243);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxTaxNo);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.dataGridViewTax);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 320);
            this.groupBox2.TabIndex = 164;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonExit);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.buttonCancel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(385, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 123);
            this.groupBox3.TabIndex = 165;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax";
            this.Load += new System.EventHandler(this.Tax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTaxTo;
        private System.Windows.Forms.ComboBox comboBoxNoOfDependent;
        private System.Windows.Forms.ComboBox comboBoxCivilStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDepentdent;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTaxExemption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPercentOver;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTaxFrom;
        private System.Windows.Forms.TextBox textBoxTaxNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}