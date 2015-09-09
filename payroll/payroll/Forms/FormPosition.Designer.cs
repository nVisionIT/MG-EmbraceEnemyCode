namespace payroll.Forms
{
    partial class FormPosition
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPositionName = new System.Windows.Forms.TextBox();
            this.textBoxPositionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(30, 150);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(368, 20);
            this.textBoxSearch.TabIndex = 137;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(404, 150);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 138;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(302, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 143;
            this.label4.Text = "Salary";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalary.Location = new System.Drawing.Point(370, 83);
            this.textBoxSalary.MaxLength = 50;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(141, 20);
            this.textBoxSalary.TabIndex = 130;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(485, 296);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 136;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(485, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 135;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(485, 238);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 134;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(485, 209);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 133;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(485, 179);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 132;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Position ID:";
            // 
            // textBoxPositionName
            // 
            this.textBoxPositionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPositionName.Location = new System.Drawing.Point(124, 109);
            this.textBoxPositionName.MaxLength = 50;
            this.textBoxPositionName.Name = "textBoxPositionName";
            this.textBoxPositionName.Size = new System.Drawing.Size(141, 20);
            this.textBoxPositionName.TabIndex = 129;
            // 
            // textBoxPositionID
            // 
            this.textBoxPositionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPositionID.Enabled = false;
            this.textBoxPositionID.Location = new System.Drawing.Point(124, 83);
            this.textBoxPositionID.MaxLength = 7;
            this.textBoxPositionID.Name = "textBoxPositionID";
            this.textBoxPositionID.Size = new System.Drawing.Size(141, 20);
            this.textBoxPositionID.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 139;
            this.label1.Text = "Position Information";
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.AllowUserToAddRows = false;
            this.dataGridViewPosition.AllowUserToDeleteRows = false;
            this.dataGridViewPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPosition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Location = new System.Drawing.Point(30, 179);
            this.dataGridViewPosition.MultiSelect = false;
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.ReadOnly = true;
            this.dataGridViewPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosition.Size = new System.Drawing.Size(449, 140);
            this.dataGridViewPosition.TabIndex = 142;
            this.dataGridViewPosition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPosition_CellContentClick);
            // 
            // FormPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPositionName);
            this.Controls.Add(this.textBoxPositionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPosition);
            this.Name = "FormPosition";
            this.Text = "FormPosition";
            this.Load += new System.EventHandler(this.FormPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPositionName;
        private System.Windows.Forms.TextBox textBoxPositionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
    }
}