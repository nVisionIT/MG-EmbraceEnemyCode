namespace payroll
{
    partial class FormAttendanceReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAttendance = new payroll.DataSetAttendance();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.dateTimePickerReportStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReportEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new payroll.DataSetAttendanceTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetAttendance;
            // 
            // DataSetAttendance
            // 
            this.DataSetAttendance.DataSetName = "DataSetAttendance";
            this.DataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompute.Location = new System.Drawing.Point(535, 34);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(90, 30);
            this.buttonCompute.TabIndex = 88;
            this.buttonCompute.Text = "View";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // dateTimePickerReportStart
            // 
            this.dateTimePickerReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReportStart.Location = new System.Drawing.Point(170, 37);
            this.dateTimePickerReportStart.Name = "dateTimePickerReportStart";
            this.dateTimePickerReportStart.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerReportStart.TabIndex = 87;
            // 
            // dateTimePickerReportEnd
            // 
            this.dateTimePickerReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReportEnd.Location = new System.Drawing.Point(388, 38);
            this.dateTimePickerReportEnd.Name = "dateTimePickerReportEnd";
            this.dateTimePickerReportEnd.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerReportEnd.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(312, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Report End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(95, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Report Start";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report17.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(98, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(527, 311);
            this.reportViewer1.TabIndex = 89;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FormAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 426);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.dateTimePickerReportStart);
            this.Controls.Add(this.dateTimePickerReportEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "FormAttendanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAttendanceReport";
            this.Load += new System.EventHandler(this.FormAttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetAttendance DataSetAttendance;
        private DataSetAttendanceTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}