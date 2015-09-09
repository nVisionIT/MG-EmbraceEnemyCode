namespace payroll.Forms
{
    partial class SSSEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.AllowUserToOrderColumns = true;
            this.DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView2.Location = new System.Drawing.Point(12, 14);
            this.DataGridView2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DataGridView2.MultiSelect = false;
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.ShowCellErrors = false;
            this.DataGridView2.ShowRowErrors = false;
            this.DataGridView2.Size = new System.Drawing.Size(913, 218);
            this.DataGridView2.TabIndex = 141;
            // 
            // SSSEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::payroll.Properties.Resources.videos_4_background1;
            this.ClientSize = new System.Drawing.Size(953, 247);
            this.Controls.Add(this.DataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SSSEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSSEntry";
            this.Load += new System.EventHandler(this.SSSEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView2;

    }
}