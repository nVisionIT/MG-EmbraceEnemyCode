namespace payroll
{
    partial class Leave
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.textBoxLeaveID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxReason = new System.Windows.Forms.ComboBox();
            this.textBoxNoOFDays = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "No Of Days:";
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.AllowUserToAddRows = false;
            this.dataGridViewLeave.AllowUserToDeleteRows = false;
            this.dataGridViewLeave.AllowUserToResizeColumns = false;
            this.dataGridViewLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLeave.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewLeave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Location = new System.Drawing.Point(17, 55);
            this.dataGridViewLeave.MultiSelect = false;
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewLeave.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeave.Size = new System.Drawing.Size(711, 196);
            this.dataGridViewLeave.TabIndex = 144;
            this.dataGridViewLeave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeave_CellContentClick);
            // 
            // textBoxLeaveID
            // 
            this.textBoxLeaveID.Enabled = false;
            this.textBoxLeaveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeaveID.Location = new System.Drawing.Point(17, 28);
            this.textBoxLeaveID.Name = "textBoxLeaveID";
            this.textBoxLeaveID.Size = new System.Drawing.Size(197, 22);
            this.textBoxLeaveID.TabIndex = 143;
            this.textBoxLeaveID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 142;
            this.label7.Text = "Employee ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 140;
            this.label12.Text = "End Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 138;
            this.label14.Text = "Start Date:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(23, 173);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(59, 16);
            this.d.TabIndex = 139;
            this.d.Text = "Reason:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(156, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 26);
            this.label15.TabIndex = 146;
            this.label15.Text = "Employee Leave Record";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::payroll.Properties.Resources.exit1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(204, 82);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 39);
            this.buttonExit.TabIndex = 135;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::payroll.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(82, 82);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 38);
            this.buttonCancel.TabIndex = 134;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::payroll.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(266, 34);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 43);
            this.buttonDelete.TabIndex = 133;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = global::payroll.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(145, 34);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 43);
            this.buttonEdit.TabIndex = 132;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::payroll.Properties.Resources.adding;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(23, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 43);
            this.buttonAdd.TabIndex = 131;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(617, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 29);
            this.buttonSearch.TabIndex = 137;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(235, 26);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(376, 22);
            this.textBoxSearch.TabIndex = 136;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxReason
            // 
            this.comboBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReason.FormattingEnabled = true;
            this.comboBoxReason.Items.AddRange(new object[] {
            "Maternity",
            "Paternity",
            "SickLeave",
            "VacationLeave"});
            this.comboBoxReason.Location = new System.Drawing.Point(113, 165);
            this.comboBoxReason.Name = "comboBoxReason";
            this.comboBoxReason.Size = new System.Drawing.Size(129, 23);
            this.comboBoxReason.TabIndex = 130;
            this.comboBoxReason.Text = "Select One";
            // 
            // textBoxNoOFDays
            // 
            this.textBoxNoOFDays.Enabled = false;
            this.textBoxNoOFDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOFDays.Location = new System.Drawing.Point(113, 132);
            this.textBoxNoOFDays.Name = "textBoxNoOFDays";
            this.textBoxNoOFDays.Size = new System.Drawing.Size(58, 21);
            this.textBoxNoOFDays.TabIndex = 129;
            this.textBoxNoOFDays.Text = "0";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(113, 101);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(129, 21);
            this.dateTimePickerEndDate.TabIndex = 128;
            this.dateTimePickerEndDate.Value = new System.DateTime(2014, 2, 20, 0, 0, 0, 0);
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(114, 68);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(129, 21);
            this.dateTimePickerStartDate.TabIndex = 127;
            this.dateTimePickerStartDate.Value = new System.DateTime(2014, 2, 20, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(111, 32);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(158, 24);
            this.comboBoxName.TabIndex = 145;
            this.comboBoxName.Text = "Select One";
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxNoOFDays);
            this.groupBox1.Controls.Add(this.comboBoxReason);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 212);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxLeaveID);
            this.groupBox2.Controls.Add(this.dataGridViewLeave);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 276);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonExit);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.buttonCancel);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(364, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 140);
            this.groupBox3.TabIndex = 149;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buttons";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewLeave;
        private System.Windows.Forms.TextBox textBoxLeaveID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxReason;
        private System.Windows.Forms.TextBox textBoxNoOFDays;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}