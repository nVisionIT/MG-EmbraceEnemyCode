namespace payroll
{
    partial class LeaveReport
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
            this.DataSet4 = new payroll.DataSet4();
            this.LeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LeaveTableAdapter = new payroll.DataSet4TableAdapters.LeaveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LeaveBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 299);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LeaveBindingSource
            // 
            this.LeaveBindingSource.DataMember = "Leave";
            this.LeaveBindingSource.DataSource = this.DataSet4;
            // 
            // LeaveTableAdapter
            // 
            this.LeaveTableAdapter.ClearBeforeFill = true;
            // 
            // LeaveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 299);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LeaveReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveReport";
            this.Load += new System.EventHandler(this.LeaveReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LeaveBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.LeaveTableAdapter LeaveTableAdapter;
    }
}