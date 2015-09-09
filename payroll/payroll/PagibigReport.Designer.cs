namespace payroll
{
    partial class PagibigReport
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
            this.DataSet6 = new payroll.DataSet6();
            this.PagIbigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagIbigTableAdapter = new payroll.DataSet6TableAdapters.PagIbigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagIbigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PagIbigBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet6
            // 
            this.DataSet6.DataSetName = "DataSet6";
            this.DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagIbigBindingSource
            // 
            this.PagIbigBindingSource.DataMember = "PagIbig";
            this.PagIbigBindingSource.DataSource = this.DataSet6;
            // 
            // PagIbigTableAdapter
            // 
            this.PagIbigTableAdapter.ClearBeforeFill = true;
            // 
            // PagibigReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 246);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PagibigReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagibigReport";
            this.Load += new System.EventHandler(this.PagibigReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagIbigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagIbigBindingSource;
        private DataSet6 DataSet6;
        private DataSet6TableAdapters.PagIbigTableAdapter PagIbigTableAdapter;
    }
}