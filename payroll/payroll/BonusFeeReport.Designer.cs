namespace payroll
{
    partial class BonusFeeReport
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
            this.BonusFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new payroll.DataSet2();
            this.BonusFeeTableAdapter = new payroll.DataSet2TableAdapters.BonusFeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BonusFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BonusFeeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "payroll.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 310);
            this.reportViewer1.TabIndex = 0;
            // 
            // BonusFeeBindingSource
            // 
            this.BonusFeeBindingSource.DataMember = "BonusFee";
            this.BonusFeeBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BonusFeeTableAdapter
            // 
            this.BonusFeeTableAdapter.ClearBeforeFill = true;
            // 
            // BonusFeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 310);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BonusFeeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BonusFeeReport";
            this.Load += new System.EventHandler(this.BonusFeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BonusFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BonusFeeBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.BonusFeeTableAdapter BonusFeeTableAdapter;
    }
}