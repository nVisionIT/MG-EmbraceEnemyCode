namespace payroll
{
    partial class PagIbig
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
            this.textBoxMonthlyCompensationTo = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmployerShare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTotalMonthlyContribution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeeShare = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMonthlyCompensationFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPagIbig = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagIbig)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "MonthlyCompensation To";
            // 
            // textBoxMonthlyCompensationTo
            // 
            this.textBoxMonthlyCompensationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyCompensationTo.Location = new System.Drawing.Point(222, 72);
            this.textBoxMonthlyCompensationTo.MaxLength = 50;
            this.textBoxMonthlyCompensationTo.Name = "textBoxMonthlyCompensationTo";
            this.textBoxMonthlyCompensationTo.Size = new System.Drawing.Size(141, 22);
            this.textBoxMonthlyCompensationTo.TabIndex = 127;
            this.textBoxMonthlyCompensationTo.Text = "0.00";
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(567, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 25);
            this.buttonSearch.TabIndex = 126;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(193, 31);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(363, 22);
            this.textBoxSearch.TabIndex = 125;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "EmployerShare ";
            // 
            // textBoxEmployerShare
            // 
            this.textBoxEmployerShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployerShare.Location = new System.Drawing.Point(223, 125);
            this.textBoxEmployerShare.MaxLength = 50;
            this.textBoxEmployerShare.Name = "textBoxEmployerShare";
            this.textBoxEmployerShare.Size = new System.Drawing.Size(141, 22);
            this.textBoxEmployerShare.TabIndex = 123;
            this.textBoxEmployerShare.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 122;
            this.label9.Text = "TotalMonthlyContribution ";
            // 
            // textBoxTotalMonthlyContribution
            // 
            this.textBoxTotalMonthlyContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMonthlyContribution.Location = new System.Drawing.Point(222, 151);
            this.textBoxTotalMonthlyContribution.MaxLength = 50;
            this.textBoxTotalMonthlyContribution.Name = "textBoxTotalMonthlyContribution";
            this.textBoxTotalMonthlyContribution.Size = new System.Drawing.Size(141, 22);
            this.textBoxTotalMonthlyContribution.TabIndex = 121;
            this.textBoxTotalMonthlyContribution.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "EmployeeShare";
            // 
            // textBoxEmployeeShare
            // 
            this.textBoxEmployeeShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeShare.Location = new System.Drawing.Point(222, 100);
            this.textBoxEmployeeShare.MaxLength = 50;
            this.textBoxEmployeeShare.Name = "textBoxEmployeeShare";
            this.textBoxEmployeeShare.Size = new System.Drawing.Size(141, 22);
            this.textBoxEmployeeShare.TabIndex = 119;
            this.textBoxEmployeeShare.Text = "0.00";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::payroll.Properties.Resources.exit1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(220, 71);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 39);
            this.buttonExit.TabIndex = 117;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::payroll.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(95, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 39);
            this.buttonCancel.TabIndex = 116;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::payroll.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(271, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 44);
            this.buttonDelete.TabIndex = 114;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Image = global::payroll.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(161, 21);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 44);
            this.buttonEdit.TabIndex = 112;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::payroll.Properties.Resources.adding;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(40, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 44);
            this.buttonAdd.TabIndex = 111;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 115;
            this.label3.Text = "MonthlyCompensation From";
            // 
            // textBoxMonthlyCompensationFrom
            // 
            this.textBoxMonthlyCompensationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyCompensationFrom.Location = new System.Drawing.Point(222, 47);
            this.textBoxMonthlyCompensationFrom.MaxLength = 50;
            this.textBoxMonthlyCompensationFrom.Name = "textBoxMonthlyCompensationFrom";
            this.textBoxMonthlyCompensationFrom.Size = new System.Drawing.Size(141, 22);
            this.textBoxMonthlyCompensationFrom.TabIndex = 110;
            this.textBoxMonthlyCompensationFrom.Text = "0.00";
            this.textBoxMonthlyCompensationFrom.Click += new System.EventHandler(this.textBoxMonthlyCompensationFrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "PagIbig Information";
            // 
            // dataGridViewPagIbig
            // 
            this.dataGridViewPagIbig.AllowUserToAddRows = false;
            this.dataGridViewPagIbig.AllowUserToDeleteRows = false;
            this.dataGridViewPagIbig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPagIbig.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewPagIbig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPagIbig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagIbig.Location = new System.Drawing.Point(30, 59);
            this.dataGridViewPagIbig.MultiSelect = false;
            this.dataGridViewPagIbig.Name = "dataGridViewPagIbig";
            this.dataGridViewPagIbig.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewPagIbig.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPagIbig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPagIbig.Size = new System.Drawing.Size(828, 213);
            this.dataGridViewPagIbig.TabIndex = 118;
            this.dataGridViewPagIbig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPagIbig_CellContentClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(369, 50);
            this.textBoxID.MaxLength = 50;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(51, 22);
            this.textBoxID.TabIndex = 129;
            this.textBoxID.Text = "0.00";
            this.textBoxID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxMonthlyCompensationFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMonthlyCompensationTo);
            this.groupBox1.Controls.Add(this.textBoxEmployeeShare);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTotalMonthlyContribution);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxEmployerShare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 204);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PagIbig Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewPagIbig);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 289);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.buttonExit);
            this.groupBox3.Controls.Add(this.buttonCancel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(461, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 135);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buttons";
            // 
            // PagIbig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PagIbig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagIbig";
            this.Load += new System.EventHandler(this.PagIbig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagIbig)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxMonthlyCompensationTo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmployerShare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTotalMonthlyContribution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmployeeShare;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMonthlyCompensationFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPagIbig;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}