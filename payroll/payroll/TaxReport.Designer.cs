namespace payroll
{
    partial class TaxReport
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
            this.DataSet9 = new payroll.DataSet9();
            this.TaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxTableAdapter = new payroll.DataSet9TableAdapters.TaxTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TaxBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report15.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet9
            // 
            this.DataSet9.DataSetName = "DataSet9";
            this.DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TaxBindingSource
            // 
            this.TaxBindingSource.DataMember = "Tax";
            this.TaxBindingSource.DataSource = this.DataSet9;
            // 
            // TaxTableAdapter
            // 
            this.TaxTableAdapter.ClearBeforeFill = true;
            // 
            // TaxReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 325);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TaxReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxReport";
            this.Load += new System.EventHandler(this.TaxReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TaxBindingSource;
        private DataSet9 DataSet9;
        private DataSet9TableAdapters.TaxTableAdapter TaxTableAdapter;
    }
}