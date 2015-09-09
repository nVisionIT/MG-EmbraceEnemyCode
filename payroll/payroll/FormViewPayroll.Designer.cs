namespace payroll
{
    partial class FormViewPayroll
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPayrollTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayrollTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(576, 397);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(91, 43);
            this.buttonPrint.TabIndex = 105;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(689, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 43);
            this.buttonCancel.TabIndex = 104;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(713, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 43);
            this.buttonSearch.TabIndex = 103;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(448, 47);
            this.textBoxSearch.MaxLength = 7;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(259, 20);
            this.textBoxSearch.TabIndex = 102;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "Payroll Table";
            // 
            // dataGridViewPayrollTable
            // 
            this.dataGridViewPayrollTable.AllowUserToAddRows = false;
            this.dataGridViewPayrollTable.AllowUserToDeleteRows = false;
            this.dataGridViewPayrollTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayrollTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPayrollTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayrollTable.Location = new System.Drawing.Point(47, 87);
            this.dataGridViewPayrollTable.Name = "dataGridViewPayrollTable";
            this.dataGridViewPayrollTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayrollTable.Size = new System.Drawing.Size(750, 300);
            this.dataGridViewPayrollTable.TabIndex = 100;
            // 
            // FormViewPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 497);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPayrollTable);
            this.Name = "FormViewPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewPayroll";
            this.Load += new System.EventHandler(this.FormViewPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayrollTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPayrollTable;
    }
}