namespace payroll.Forms
{
    partial class Loan
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewLoan = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxLoanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmountLoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalAmortization = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLoan = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::payroll.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(278, 33);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 40);
            this.buttonDelete.TabIndex = 118;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(147, 84);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerStart.TabIndex = 114;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(147, 111);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerEnd.TabIndex = 115;
            this.dateTimePickerEnd.Value = new System.DateTime(2014, 2, 25, 0, 0, 0, 0);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::payroll.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(212, 83);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 38);
            this.buttonCancel.TabIndex = 119;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = global::payroll.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(152, 32);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 40);
            this.buttonEdit.TabIndex = 117;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewLoan
            // 
            this.dataGridViewLoan.AllowUserToAddRows = false;
            this.dataGridViewLoan.AllowUserToDeleteRows = false;
            this.dataGridViewLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewLoan.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoan.Location = new System.Drawing.Point(21, 56);
            this.dataGridViewLoan.MultiSelect = false;
            this.dataGridViewLoan.Name = "dataGridViewLoan";
            this.dataGridViewLoan.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewLoan.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoan.Size = new System.Drawing.Size(708, 192);
            this.dataGridViewLoan.TabIndex = 121;
            this.dataGridViewLoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoan_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(90, 24);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(398, 22);
            this.textBoxSearch.TabIndex = 122;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(494, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 29);
            this.buttonSearch.TabIndex = 123;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::payroll.Properties.Resources.adding;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(28, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 38);
            this.buttonAdd.TabIndex = 116;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 113;
            this.label10.Text = "Payment End Date";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::payroll.Properties.Resources.exit1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(88, 84);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 37);
            this.buttonExit.TabIndex = 120;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxLoanID
            // 
            this.textBoxLoanID.Enabled = false;
            this.textBoxLoanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoanID.Location = new System.Drawing.Point(210, 165);
            this.textBoxLoanID.Name = "textBoxLoanID";
            this.textBoxLoanID.Size = new System.Drawing.Size(58, 20);
            this.textBoxLoanID.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 110;
            this.label5.Text = "Payment Start Date";
            // 
            // textBoxAmountLoan
            // 
            this.textBoxAmountLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountLoan.Location = new System.Drawing.Point(147, 58);
            this.textBoxAmountLoan.Name = "textBoxAmountLoan";
            this.textBoxAmountLoan.Size = new System.Drawing.Size(123, 20);
            this.textBoxAmountLoan.TabIndex = 109;
            this.textBoxAmountLoan.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "Amount Loan";
            // 
            // textBoxTotalAmortization
            // 
            this.textBoxTotalAmortization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmortization.Location = new System.Drawing.Point(147, 139);
            this.textBoxTotalAmortization.Name = "textBoxTotalAmortization";
            this.textBoxTotalAmortization.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalAmortization.TabIndex = 107;
            this.textBoxTotalAmortization.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Monthly Deduction: ";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(147, 28);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(158, 24);
            this.comboBoxName.TabIndex = 147;
            this.comboBoxName.Text = "Select One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxLoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxTotalAmortization);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.Add(this.textBoxAmountLoan);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxLoanID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 200);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 151;
            this.label3.Text = "Type Of Loan:";
            // 
            // comboBoxLoan
            // 
            this.comboBoxLoan.FormattingEnabled = true;
            this.comboBoxLoan.Items.AddRange(new object[] {
            "Company Loan",
            "SSS Loan",
            "PagIbig Loan"});
            this.comboBoxLoan.Location = new System.Drawing.Point(147, 165);
            this.comboBoxLoan.Name = "comboBoxLoan";
            this.comboBoxLoan.Size = new System.Drawing.Size(123, 24);
            this.comboBoxLoan.TabIndex = 148;
            this.comboBoxLoan.Text = "Select One";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(354, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 134);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewLoan);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 254);
            this.groupBox3.TabIndex = 150;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 39);
            this.label2.TabIndex = 148;
            this.label2.Text = "Loan Information";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewLoan;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.TextBox textBoxLoanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmountLoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalAmortization;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLoan;
    }
}