namespace payroll
{
    partial class Payroll
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
            this.dateTimePickerPaydate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePickerReportStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReportEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.dataGridViewAttendanceReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBonus = new System.Windows.Forms.DataGridView();
            this.dataGridViewLoanDeduction = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAttendance123 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLoanSSS = new System.Windows.Forms.DataGridView();
            this.dataGridViewLoanPagIbig = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanDeduction)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanSSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanPagIbig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerPaydate
            // 
            this.dateTimePickerPaydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPaydate.Location = new System.Drawing.Point(158, 82);
            this.dateTimePickerPaydate.Name = "dateTimePickerPaydate";
            this.dateTimePickerPaydate.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerPaydate.TabIndex = 62;
            this.dateTimePickerPaydate.Value = new System.DateTime(2014, 6, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Pay Date";
            // 
            // buttonCompute
            // 
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompute.Image = global::payroll.Properties.Resources.navigate_down_icon;
            this.buttonCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompute.Location = new System.Drawing.Point(16, 31);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(111, 42);
            this.buttonCompute.TabIndex = 60;
            this.buttonCompute.Text = "Generate";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::payroll.Properties.Resources.DeleteRed;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(133, 31);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(106, 42);
            this.buttonClose.TabIndex = 59;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateTimePickerReportStart
            // 
            this.dateTimePickerReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReportStart.Location = new System.Drawing.Point(158, 16);
            this.dateTimePickerReportStart.Name = "dateTimePickerReportStart";
            this.dateTimePickerReportStart.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerReportStart.TabIndex = 58;
            this.dateTimePickerReportStart.Value = new System.DateTime(2014, 6, 21, 0, 0, 0, 0);
            // 
            // dateTimePickerReportEnd
            // 
            this.dateTimePickerReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReportEnd.Location = new System.Drawing.Point(158, 47);
            this.dateTimePickerReportEnd.Name = "dateTimePickerReportEnd";
            this.dateTimePickerReportEnd.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerReportEnd.TabIndex = 57;
            this.dateTimePickerReportEnd.Value = new System.DateTime(2014, 6, 21, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(73, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Report End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(73, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Report Start";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(50, 23);
            this.dataGridView1.TabIndex = 63;
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Location = new System.Drawing.Point(227, 193);
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.Size = new System.Drawing.Size(50, 20);
            this.dataGridViewLeave.TabIndex = 71;
            // 
            // dataGridView12
            // 
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Location = new System.Drawing.Point(104, 188);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.Size = new System.Drawing.Size(50, 25);
            this.dataGridView12.TabIndex = 70;
            // 
            // dataGridViewAttendanceReport
            // 
            this.dataGridViewAttendanceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendanceReport.Location = new System.Drawing.Point(48, 188);
            this.dataGridViewAttendanceReport.Name = "dataGridViewAttendanceReport";
            this.dataGridViewAttendanceReport.Size = new System.Drawing.Size(50, 25);
            this.dataGridViewAttendanceReport.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePickerReportStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerReportEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerPaydate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 129);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payroll Dates";
            // 
            // dataGridViewBonus
            // 
            this.dataGridViewBonus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonus.Location = new System.Drawing.Point(397, 101);
            this.dataGridViewBonus.Name = "dataGridViewBonus";
            this.dataGridViewBonus.Size = new System.Drawing.Size(48, 25);
            this.dataGridViewBonus.TabIndex = 144;
            // 
            // dataGridViewLoanDeduction
            // 
            this.dataGridViewLoanDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanDeduction.Location = new System.Drawing.Point(502, 101);
            this.dataGridViewLoanDeduction.Name = "dataGridViewLoanDeduction";
            this.dataGridViewLoanDeduction.Size = new System.Drawing.Size(50, 24);
            this.dataGridViewLoanDeduction.TabIndex = 143;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Controls.Add(this.buttonCompute);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 113);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // dataGridViewAttendance123
            // 
            this.dataGridViewAttendance123.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance123.Location = new System.Drawing.Point(502, 291);
            this.dataGridViewAttendance123.Name = "dataGridViewAttendance123";
            this.dataGridViewAttendance123.Size = new System.Drawing.Size(69, 52);
            this.dataGridViewAttendance123.TabIndex = 146;
            this.dataGridViewAttendance123.Visible = false;
            // 
            // dataGridViewLoanSSS
            // 
            this.dataGridViewLoanSSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanSSS.Location = new System.Drawing.Point(283, 188);
            this.dataGridViewLoanSSS.Name = "dataGridViewLoanSSS";
            this.dataGridViewLoanSSS.Size = new System.Drawing.Size(46, 23);
            this.dataGridViewLoanSSS.TabIndex = 147;
            // 
            // dataGridViewLoanPagIbig
            // 
            this.dataGridViewLoanPagIbig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanPagIbig.Location = new System.Drawing.Point(335, 188);
            this.dataGridViewLoanPagIbig.Name = "dataGridViewLoanPagIbig";
            this.dataGridViewLoanPagIbig.Size = new System.Drawing.Size(44, 23);
            this.dataGridViewLoanPagIbig.TabIndex = 148;
            this.dataGridViewLoanPagIbig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 160);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(587, 183);
            this.dataGridView2.TabIndex = 149;
            // 
            // button1
            // 
            this.button1.Image = global::payroll.Properties.Resources.Misc_Misc_Box_icon1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 150;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewLoanPagIbig);
            this.Controls.Add(this.dataGridViewLoanSSS);
            this.Controls.Add(this.dataGridViewAttendance123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewBonus);
            this.Controls.Add(this.dataGridViewLoanDeduction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewLeave);
            this.Controls.Add(this.dataGridView12);
            this.Controls.Add(this.dataGridViewAttendanceReport);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanDeduction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanSSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanPagIbig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPaydate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewLeave;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.DataGridView dataGridViewAttendanceReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBonus;
        private System.Windows.Forms.DataGridView dataGridViewLoanDeduction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAttendance123;
        private System.Windows.Forms.DataGridView dataGridViewLoanSSS;
        private System.Windows.Forms.DataGridView dataGridViewLoanPagIbig;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}