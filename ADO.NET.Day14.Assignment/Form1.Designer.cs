namespace ADO.NET.Day14.Assignment
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
            this.LblStudCode = new System.Windows.Forms.Label();
            this.LblStudName = new System.Windows.Forms.Label();
            this.LblDeptCode = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.TxtStudCode = new System.Windows.Forms.TextBox();
            this.TxtStudName = new System.Windows.Forms.TextBox();
            this.TxtDeptCode = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DtpStudDob = new System.Windows.Forms.DateTimePicker();
            this.LblReset = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblStudCode
            // 
            this.LblStudCode.AutoSize = true;
            this.LblStudCode.Location = new System.Drawing.Point(133, 57);
            this.LblStudCode.Name = "LblStudCode";
            this.LblStudCode.Size = new System.Drawing.Size(72, 13);
            this.LblStudCode.TabIndex = 0;
            this.LblStudCode.Text = "Student Code";
            // 
            // LblStudName
            // 
            this.LblStudName.AutoSize = true;
            this.LblStudName.Location = new System.Drawing.Point(130, 88);
            this.LblStudName.Name = "LblStudName";
            this.LblStudName.Size = new System.Drawing.Size(75, 13);
            this.LblStudName.TabIndex = 1;
            this.LblStudName.Text = "Student Name";
            // 
            // LblDeptCode
            // 
            this.LblDeptCode.AutoSize = true;
            this.LblDeptCode.Location = new System.Drawing.Point(115, 129);
            this.LblDeptCode.Name = "LblDeptCode";
            this.LblDeptCode.Size = new System.Drawing.Size(90, 13);
            this.LblDeptCode.TabIndex = 2;
            this.LblDeptCode.Text = "Department Code";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(139, 170);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(66, 13);
            this.LblDOB.TabIndex = 3;
            this.LblDOB.Text = "Date of Birth";
            // 
            // TxtStudCode
            // 
            this.TxtStudCode.Location = new System.Drawing.Point(283, 50);
            this.TxtStudCode.Name = "TxtStudCode";
            this.TxtStudCode.Size = new System.Drawing.Size(100, 20);
            this.TxtStudCode.TabIndex = 4;
            // 
            // TxtStudName
            // 
            this.TxtStudName.Location = new System.Drawing.Point(283, 85);
            this.TxtStudName.Name = "TxtStudName";
            this.TxtStudName.Size = new System.Drawing.Size(100, 20);
            this.TxtStudName.TabIndex = 5;
            // 
            // TxtDeptCode
            // 
            this.TxtDeptCode.Location = new System.Drawing.Point(283, 126);
            this.TxtDeptCode.Name = "TxtDeptCode";
            this.TxtDeptCode.Size = new System.Drawing.Size(100, 20);
            this.TxtDeptCode.TabIndex = 6;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(443, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(308, 249);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 10;
            this.BtnAddNew.Text = "AddNew";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(454, 249);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DtpStudDob
            // 
            this.DtpStudDob.Location = new System.Drawing.Point(283, 175);
            this.DtpStudDob.Name = "DtpStudDob";
            this.DtpStudDob.Size = new System.Drawing.Size(132, 20);
            this.DtpStudDob.TabIndex = 12;
            // 
            // LblReset
            // 
            this.LblReset.Location = new System.Drawing.Point(161, 249);
            this.LblReset.Name = "LblReset";
            this.LblReset.Size = new System.Drawing.Size(75, 23);
            this.LblReset.TabIndex = 13;
            this.LblReset.Text = "Reset";
            this.LblReset.UseVisualStyleBackColor = true;
            this.LblReset.Click += new System.EventHandler(this.LblReset_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(574, 249);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(158, 213);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 15;
            this.LblAddress.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(283, 210);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblReset);
            this.Controls.Add(this.DtpStudDob);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtDeptCode);
            this.Controls.Add(this.TxtStudName);
            this.Controls.Add(this.TxtStudCode);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblDeptCode);
            this.Controls.Add(this.LblStudName);
            this.Controls.Add(this.LblStudCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudCode;
        private System.Windows.Forms.Label LblStudName;
        private System.Windows.Forms.Label LblDeptCode;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.TextBox TxtStudCode;
        private System.Windows.Forms.TextBox TxtStudName;
        private System.Windows.Forms.TextBox TxtDeptCode;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DateTimePicker DtpStudDob;
        private System.Windows.Forms.Button LblReset;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtAddress;
    }
}

