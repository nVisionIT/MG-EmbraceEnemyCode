namespace payroll
{
    partial class LoanReport
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
            this.DataSet5 = new payroll.DataSet5();
            this.LoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoanTableAdapter = new payroll.DataSet5TableAdapters.LoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoanBindingSource
            // 
            this.LoanBindingSource.DataMember = "Loan";
            this.LoanBindingSource.DataSource = this.DataSet5;
            // 
            // LoanTableAdapter
            // 
            this.LoanTableAdapter.ClearBeforeFill = true;
            // 
            // LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LoanReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanReport";
            this.Load += new System.EventHandler(this.LoanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoanBindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.LoanTableAdapter LoanTableAdapter;
    }
}