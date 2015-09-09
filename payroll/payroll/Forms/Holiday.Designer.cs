namespace payroll
{
    partial class Holiday
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxReason = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHolidayName = new System.Windows.Forms.TextBox();
            this.textBoxHolidayID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHoliday = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoliday)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(109, 88);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(141, 22);
            this.dateTimePickerDate.TabIndex = 84;
            // 
            // richTextBoxReason
            // 
            this.richTextBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxReason.Location = new System.Drawing.Point(109, 151);
            this.richTextBoxReason.Name = "richTextBoxReason";
            this.richTextBoxReason.Size = new System.Drawing.Size(141, 59);
            this.richTextBoxReason.TabIndex = 86;
            this.richTextBoxReason.Text = "";
            this.richTextBoxReason.Validated += new System.EventHandler(this.richTextBoxReason_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Date";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Working Holiday",
            "None Working Holiday"});
            this.comboBoxStatus.Location = new System.Drawing.Point(109, 121);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 85;
            this.comboBoxStatus.Text = "Select One";
            this.comboBoxStatus.Validated += new System.EventHandler(this.comboBoxStatus_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Status";
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(458, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 94;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(99, 35);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(353, 22);
            this.textBoxSearch.TabIndex = 93;
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::payroll.Properties.Resources.exit1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(215, 74);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 48);
            this.buttonExit.TabIndex = 91;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::payroll.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(84, 74);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 48);
            this.buttonCancel.TabIndex = 90;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::payroll.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(581, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 48);
            this.buttonDelete.TabIndex = 89;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = global::payroll.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(462, 131);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(113, 48);
            this.buttonEdit.TabIndex = 88;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Holiday Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::payroll.Properties.Resources.adding;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(343, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 48);
            this.buttonAdd.TabIndex = 87;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "HolidayID";
            // 
            // textBoxHolidayName
            // 
            this.textBoxHolidayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHolidayName.Location = new System.Drawing.Point(109, 59);
            this.textBoxHolidayName.MaxLength = 50;
            this.textBoxHolidayName.Name = "textBoxHolidayName";
            this.textBoxHolidayName.Size = new System.Drawing.Size(141, 22);
            this.textBoxHolidayName.TabIndex = 83;
            this.textBoxHolidayName.Validated += new System.EventHandler(this.textBoxHolidayName_Validated);
            // 
            // textBoxHolidayID
            // 
            this.textBoxHolidayID.Enabled = false;
            this.textBoxHolidayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHolidayID.Location = new System.Drawing.Point(109, 33);
            this.textBoxHolidayID.MaxLength = 7;
            this.textBoxHolidayID.Name = "textBoxHolidayID";
            this.textBoxHolidayID.Size = new System.Drawing.Size(141, 22);
            this.textBoxHolidayID.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Holiday Information";
            // 
            // dataGridViewHoliday
            // 
            this.dataGridViewHoliday.AllowUserToAddRows = false;
            this.dataGridViewHoliday.AllowUserToDeleteRows = false;
            this.dataGridViewHoliday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHoliday.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewHoliday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoliday.Location = new System.Drawing.Point(19, 68);
            this.dataGridViewHoliday.MultiSelect = false;
            this.dataGridViewHoliday.Name = "dataGridViewHoliday";
            this.dataGridViewHoliday.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewHoliday.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHoliday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoliday.Size = new System.Drawing.Size(666, 184);
            this.dataGridViewHoliday.TabIndex = 92;
            this.dataGridViewHoliday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoliday_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxHolidayID);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.textBoxHolidayName);
            this.groupBox1.Controls.Add(this.richTextBoxReason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 230);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Holiday Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Location = new System.Drawing.Point(303, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 137);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewHoliday);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 267);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // Holiday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 542);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Holiday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday";
            this.Load += new System.EventHandler(this.Holiday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoliday)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.RichTextBox richTextBoxReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHolidayName;
        private System.Windows.Forms.TextBox textBoxHolidayID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHoliday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}