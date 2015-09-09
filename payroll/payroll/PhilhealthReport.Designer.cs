namespace payroll
{
    partial class PhilhealthReport
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
            this.DataSet7 = new payroll.DataSet7();
            this.PhilHealthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhilHealthTableAdapter = new payroll.DataSet7TableAdapters.PhilHealthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhilHealthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhilHealthBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(706, 335);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet7
            // 
            this.DataSet7.DataSetName = "DataSet7";
            this.DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhilHealthBindingSource
            // 
            this.PhilHealthBindingSource.DataMember = "PhilHealth";
            this.PhilHealthBindingSource.DataSource = this.DataSet7;
            // 
            // PhilHealthTableAdapter
            // 
            this.PhilHealthTableAdapter.ClearBeforeFill = true;
            // 
            // PhilhealthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 335);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PhilhealthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhilhealthReport";
            this.Load += new System.EventHandler(this.PhilhealthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhilHealthBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhilHealthBindingSource;
        private DataSet7 DataSet7;
        private DataSet7TableAdapters.PhilHealthTableAdapter PhilHealthTableAdapter;
    }
}