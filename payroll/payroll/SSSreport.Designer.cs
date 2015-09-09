namespace payroll
{
    partial class SSSreport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet8 = new payroll.DataSet8();
            this.SSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SSSTableAdapter = new payroll.DataSet8TableAdapters.SSSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SSSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report14.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet8
            // 
            this.DataSet8.DataSetName = "DataSet8";
            this.DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SSSBindingSource
            // 
            this.SSSBindingSource.DataMember = "SSS";
            this.SSSBindingSource.DataSource = this.DataSet8;
            // 
            // SSSTableAdapter
            // 
            this.SSSTableAdapter.ClearBeforeFill = true;
            // 
            // SSSreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SSSreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSSreport";
            this.Load += new System.EventHandler(this.SSSreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SSSBindingSource;
        private DataSet8 DataSet8;
        private DataSet8TableAdapters.SSSTableAdapter SSSTableAdapter;
    }
}