namespace payroll.Forms
{
    partial class Bonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewBonus = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxBonusID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(123, 40);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(158, 24);
            this.comboBoxName.TabIndex = 162;
            this.comboBoxName.Text = "Select One";
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Name:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(278, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 47);
            this.buttonDelete.TabIndex = 155;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(123, 92);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerStart.TabIndex = 152;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(98, 73);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 46);
            this.buttonCancel.TabIndex = 156;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(158, 21);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 46);
            this.buttonEdit.TabIndex = 154;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewBonus
            // 
            this.dataGridViewBonus.AllowUserToAddRows = false;
            this.dataGridViewBonus.AllowUserToDeleteRows = false;
            this.dataGridViewBonus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBonus.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewBonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBonus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonus.Location = new System.Drawing.Point(34, 61);
            this.dataGridViewBonus.MultiSelect = false;
            this.dataGridViewBonus.Name = "dataGridViewBonus";
            this.dataGridViewBonus.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewBonus.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBonus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBonus.Size = new System.Drawing.Size(662, 191);
            this.dataGridViewBonus.TabIndex = 158;
            this.dataGridViewBonus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBonus_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(101, 29);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(398, 22);
            this.textBoxSearch.TabIndex = 159;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(509, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 34);
            this.buttonSearch.TabIndex = 160;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(38, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 46);
            this.buttonAdd.TabIndex = 153;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(218, 74);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(114, 45);
            this.buttonExit.TabIndex = 157;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxBonusID
            // 
            this.textBoxBonusID.Enabled = false;
            this.textBoxBonusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBonusID.Location = new System.Drawing.Point(201, 156);
            this.textBoxBonusID.Name = "textBoxBonusID";
            this.textBoxBonusID.Size = new System.Drawing.Size(58, 20);
            this.textBoxBonusID.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 150;
            this.label5.Text = "Month";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(121, 67);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(123, 20);
            this.textBoxAmount.TabIndex = 149;
            this.textBoxAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 148;
            this.label7.Text = "Amount Bonus";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Monthly Bonus",
            "Thirteen Month Pay"});
            this.comboBoxType.Location = new System.Drawing.Point(121, 126);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(138, 24);
            this.comboBoxType.TabIndex = 164;
            this.comboBoxType.Text = "Select One";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 163;
            this.label9.Text = "Type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBonusID);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 198);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bonus Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonCancel);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(350, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 131);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridViewBonus);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 267);
            this.groupBox3.TabIndex = 167;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // Bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus";
            this.Load += new System.EventHandler(this.Bonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewBonus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.TextBox textBoxBonusID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}