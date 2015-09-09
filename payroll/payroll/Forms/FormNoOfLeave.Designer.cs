namespace payroll.Forms
{
    partial class FormNoOfLeave
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSick = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxMaternity = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPaternity = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLeaveNo = new System.Windows.Forms.TextBox();
            this.textBoxVacation = new System.Windows.Forms.TextBox();
            this.dataGridViewNoOfLeave = new System.Windows.Forms.DataGridView();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoOfLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(443, 227);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 102;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSick
            // 
            this.textBoxSick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSick.Location = new System.Drawing.Point(116, 167);
            this.textBoxSick.Name = "textBoxSick";
            this.textBoxSick.Size = new System.Drawing.Size(142, 20);
            this.textBoxSick.TabIndex = 88;
            this.textBoxSick.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(382, 26);
            this.label15.TabIndex = 103;
            this.label15.Text = " Employee Number of Leave Record";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "SickLeave";
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(524, 370);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 99;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(35, 227);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(398, 20);
            this.textBoxSearch.TabIndex = 101;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxMaternity
            // 
            this.textBoxMaternity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaternity.Location = new System.Drawing.Point(120, 114);
            this.textBoxMaternity.Name = "textBoxMaternity";
            this.textBoxMaternity.Size = new System.Drawing.Size(138, 20);
            this.textBoxMaternity.TabIndex = 86;
            this.textBoxMaternity.Text = "0";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(524, 341);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 98;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(524, 312);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 97;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Paternity Leave";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(524, 283);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 96;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Maternity Leave";
            // 
            // textBoxPaternity
            // 
            this.textBoxPaternity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaternity.Location = new System.Drawing.Point(116, 141);
            this.textBoxPaternity.Name = "textBoxPaternity";
            this.textBoxPaternity.Size = new System.Drawing.Size(142, 20);
            this.textBoxPaternity.TabIndex = 90;
            this.textBoxPaternity.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(524, 253);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 95;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "LeaveNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "VacationLeave ";
            // 
            // textBoxLeaveNo
            // 
            this.textBoxLeaveNo.Enabled = false;
            this.textBoxLeaveNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeaveNo.Location = new System.Drawing.Point(118, 88);
            this.textBoxLeaveNo.Name = "textBoxLeaveNo";
            this.textBoxLeaveNo.Size = new System.Drawing.Size(140, 20);
            this.textBoxLeaveNo.TabIndex = 94;
            // 
            // textBoxVacation
            // 
            this.textBoxVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVacation.Location = new System.Drawing.Point(120, 193);
            this.textBoxVacation.Name = "textBoxVacation";
            this.textBoxVacation.Size = new System.Drawing.Size(138, 20);
            this.textBoxVacation.TabIndex = 92;
            this.textBoxVacation.Text = "0";
            // 
            // dataGridViewNoOfLeave
            // 
            this.dataGridViewNoOfLeave.AllowUserToAddRows = false;
            this.dataGridViewNoOfLeave.AllowUserToDeleteRows = false;
            this.dataGridViewNoOfLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNoOfLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNoOfLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoOfLeave.Location = new System.Drawing.Point(35, 253);
            this.dataGridViewNoOfLeave.MultiSelect = false;
            this.dataGridViewNoOfLeave.Name = "dataGridViewNoOfLeave";
            this.dataGridViewNoOfLeave.ReadOnly = true;
            this.dataGridViewNoOfLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNoOfLeave.Size = new System.Drawing.Size(483, 140);
            this.dataGridViewNoOfLeave.TabIndex = 100;
            this.dataGridViewNoOfLeave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNoOfLeave_CellContentClick);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(120, 56);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(158, 21);
            this.comboBoxName.TabIndex = 147;
            this.comboBoxName.Text = "Select One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "Name:";
            // 
            // FormNoOfLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSick);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxMaternity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPaternity);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLeaveNo);
            this.Controls.Add(this.textBoxVacation);
            this.Controls.Add(this.dataGridViewNoOfLeave);
            this.Name = "FormNoOfLeave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNoOfLeave";
            this.Load += new System.EventHandler(this.FormNoOfLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoOfLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSick;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxMaternity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPaternity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxLeaveNo;
        private System.Windows.Forms.TextBox textBoxVacation;
        private System.Windows.Forms.DataGridView dataGridViewNoOfLeave;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
    }
}