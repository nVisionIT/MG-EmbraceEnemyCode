namespace payroll
{
    partial class EmployeeReportcs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new payroll.DataSet1();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeTableAdapter = new payroll.DataSet1TableAdapters.tblEmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblEmployeeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(867, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.DataSet1;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmployeeReportcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReportcs";
            this.Load += new System.EventHandler(this.EmployeeReportcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
    }
}