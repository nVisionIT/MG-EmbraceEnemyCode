namespace payroll
{
    partial class HolidayReport
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
            this.HolidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new payroll.DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HolidayTableAdapter = new payroll.DataSet3TableAdapters.HolidayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HolidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // HolidayBindingSource
            // 
            this.HolidayBindingSource.DataMember = "Holiday";
            this.HolidayBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HolidayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // HolidayTableAdapter
            // 
            this.HolidayTableAdapter.ClearBeforeFill = true;
            // 
            // HolidayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 352);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HolidayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HolidayReport";
            this.Load += new System.EventHandler(this.HolidayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HolidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HolidayBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.HolidayTableAdapter HolidayTableAdapter;
    }
}