namespace payroll
{
    partial class AttendanceTimeOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrCurTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cloudGroupBoxContainer1 = new CloudToolkitN6.CloudGroupBoxContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAfterNoon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cloudGroupBoxContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterNoon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdEmployee
            // 
            this.cmdEmployee.Location = new System.Drawing.Point(350, 587);
            this.cmdEmployee.Name = "cmdEmployee";
            this.cmdEmployee.Size = new System.Drawing.Size(204, 48);
            this.cmdEmployee.TabIndex = 383;
            this.cmdEmployee.Text = "Morning Attendance ";
            this.cmdEmployee.UseVisualStyleBackColor = true;
            this.cmdEmployee.Click += new System.EventHandler(this.cmdEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 339);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(612, 233);
            this.dataGridView1.TabIndex = 384;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(502, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 385;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(360, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 386;
            this.label2.Text = "label2";
            // 
            // tmrCurTime
            // 
            this.tmrCurTime.Enabled = true;
            this.tmrCurTime.Interval = 1000;
            this.tmrCurTime.Tick += new System.EventHandler(this.tmrCurTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 48);
            this.button1.TabIndex = 387;
            this.button1.Text = "Afternoon Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cloudGroupBoxContainer1
            // 
            this.cloudGroupBoxContainer1.AnimationEnabled = true;
            this.cloudGroupBoxContainer1.BackColor = System.Drawing.Color.Black;
            this.cloudGroupBoxContainer1.Controls.Add(this.label4);
            this.cloudGroupBoxContainer1.Controls.Add(this.label1);
            this.cloudGroupBoxContainer1.Controls.Add(this.label2);
            this.cloudGroupBoxContainer1.Location = new System.Drawing.Point(-15, 160);
            this.cloudGroupBoxContainer1.Name = "cloudGroupBoxContainer1";
            this.cloudGroupBoxContainer1.Size = new System.Drawing.Size(1329, 173);
            this.cloudGroupBoxContainer1.TabIndex = 388;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(130, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1036, 55);
            this.label3.TabIndex = 395;
            this.label3.Text = "Batelec II Multi Purpose Cooperative (BEMCO) ";
            // 
            // dataGridViewAfterNoon
            // 
            this.dataGridViewAfterNoon.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewAfterNoon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAfterNoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfterNoon.Location = new System.Drawing.Point(643, 339);
            this.dataGridViewAfterNoon.Name = "dataGridViewAfterNoon";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Aqua;
            this.dataGridViewAfterNoon.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAfterNoon.Size = new System.Drawing.Size(623, 233);
            this.dataGridViewAfterNoon.TabIndex = 396;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(707, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 55);
            this.label4.TabIndex = 387;
            this.label4.Text = "label4";
            // 
            // AttendanceTimeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 792);
            this.Controls.Add(this.dataGridViewAfterNoon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cloudGroupBoxContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AttendanceTimeOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceTimeOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AttendanceTimeOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cloudGroupBoxContainer1.ResumeLayout(false);
            this.cloudGroupBoxContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterNoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrCurTime;
        private System.Windows.Forms.Button button1;
        private CloudToolkitN6.CloudGroupBoxContainer cloudGroupBoxContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAfterNoon;
        private System.Windows.Forms.Label label4;
    }
}