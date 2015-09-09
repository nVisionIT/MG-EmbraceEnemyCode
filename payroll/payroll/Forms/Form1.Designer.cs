namespace payroll
{
    partial class Form1
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
            this.TxtAdminPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdminUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAdminPassword
            // 
            this.TxtAdminPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminPassword.Location = new System.Drawing.Point(570, 342);
            this.TxtAdminPassword.Name = "TxtAdminPassword";
            this.TxtAdminPassword.Size = new System.Drawing.Size(157, 26);
            this.TxtAdminPassword.TabIndex = 37;
            this.TxtAdminPassword.UseSystemPasswordChar = true;
            this.TxtAdminPassword.TextChanged += new System.EventHandler(this.textboxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(476, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Password";
            // 
            // TxtAdminUserName
            // 
            this.TxtAdminUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAdminUserName.Location = new System.Drawing.Point(570, 310);
            this.TxtAdminUserName.Name = "TxtAdminUserName";
            this.TxtAdminUserName.Size = new System.Drawing.Size(157, 26);
            this.TxtAdminUserName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(476, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "UserName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(661, 420);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 38);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(570, 420);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(85, 38);
            this.buttonLogIn.TabIndex = 38;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.TxtAdminPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.TxtAdminUserName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Monitoring of Bemco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox TxtAdminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox TxtAdminUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

