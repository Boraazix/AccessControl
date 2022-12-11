namespace AccessControl
{
    partial class frmRegistrationDevelopers
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnTipLevel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chkAdministrator = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lstDevelopers = new System.Windows.Forms.ListBox();
            this.btnEditDeveloper = new System.Windows.Forms.Button();
            this.btnDeleteDeveloper = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnChangePassword);
            this.pnlMain.Controls.Add(this.btnSaveChanges);
            this.pnlMain.Controls.Add(this.btnDeleteDeveloper);
            this.pnlMain.Controls.Add(this.btnEditDeveloper);
            this.pnlMain.Controls.Add(this.lstDevelopers);
            this.pnlMain.Controls.Add(this.grpData);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(457, 371);
            this.pnlMain.TabIndex = 0;
            // 
            // btnTipLevel
            // 
            this.btnTipLevel.Location = new System.Drawing.Point(100, 115);
            this.btnTipLevel.Name = "btnTipLevel";
            this.btnTipLevel.Size = new System.Drawing.Size(19, 20);
            this.btnTipLevel.TabIndex = 6;
            this.btnTipLevel.Text = "?";
            this.btnTipLevel.UseVisualStyleBackColor = true;
            this.btnTipLevel.Click += new System.EventHandler(this.btnTipLevel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(286, 115);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 21);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(244, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // chkAdministrator
            // 
            this.chkAdministrator.AutoSize = true;
            this.chkAdministrator.Location = new System.Drawing.Point(193, 117);
            this.chkAdministrator.Name = "chkAdministrator";
            this.chkAdministrator.Size = new System.Drawing.Size(86, 17);
            this.chkAdministrator.TabIndex = 8;
            this.chkAdministrator.Text = "Administrator";
            this.chkAdministrator.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(131, 117);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 98);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level:";
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(9, 114);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(85, 21);
            this.cmbLevel.TabIndex = 5;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(286, 31);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(141, 20);
            this.dtpBirth.TabIndex = 2;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(283, 15);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(55, 13);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "Birth date:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtPassword);
            this.grpData.Controls.Add(this.btnTipLevel);
            this.grpData.Controls.Add(this.lblName);
            this.grpData.Controls.Add(this.btnRegister);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.Controls.Add(this.lblBirth);
            this.grpData.Controls.Add(this.lblPassword);
            this.grpData.Controls.Add(this.dtpBirth);
            this.grpData.Controls.Add(this.txtEmail);
            this.grpData.Controls.Add(this.cmbLevel);
            this.grpData.Controls.Add(this.lblEmail);
            this.grpData.Controls.Add(this.lblLevel);
            this.grpData.Controls.Add(this.chkAdministrator);
            this.grpData.Controls.Add(this.chkActive);
            this.grpData.Location = new System.Drawing.Point(12, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(433, 143);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // lstDevelopers
            // 
            this.lstDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDevelopers.FormattingEnabled = true;
            this.lstDevelopers.ItemHeight = 18;
            this.lstDevelopers.Location = new System.Drawing.Point(12, 161);
            this.lstDevelopers.Name = "lstDevelopers";
            this.lstDevelopers.Size = new System.Drawing.Size(433, 166);
            this.lstDevelopers.TabIndex = 2;
            // 
            // btnEditDeveloper
            // 
            this.btnEditDeveloper.Location = new System.Drawing.Point(12, 338);
            this.btnEditDeveloper.Name = "btnEditDeveloper";
            this.btnEditDeveloper.Size = new System.Drawing.Size(104, 21);
            this.btnEditDeveloper.TabIndex = 3;
            this.btnEditDeveloper.Text = "Edit developer";
            this.btnEditDeveloper.UseVisualStyleBackColor = true;
            this.btnEditDeveloper.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteDeveloper
            // 
            this.btnDeleteDeveloper.Location = new System.Drawing.Point(121, 338);
            this.btnDeleteDeveloper.Name = "btnDeleteDeveloper";
            this.btnDeleteDeveloper.Size = new System.Drawing.Size(104, 21);
            this.btnDeleteDeveloper.TabIndex = 4;
            this.btnDeleteDeveloper.Text = "Delete developer";
            this.btnDeleteDeveloper.UseVisualStyleBackColor = true;
            this.btnDeleteDeveloper.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(341, 338);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(104, 21);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(231, 338);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(104, 21);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmRegistrationDevelopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 371);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "frmRegistrationDevelopers";
            this.Text = "Developer Registration";
            this.pnlMain.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.CheckBox chkAdministrator;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnTipLevel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteDeveloper;
        private System.Windows.Forms.Button btnEditDeveloper;
        private System.Windows.Forms.ListBox lstDevelopers;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnChangePassword;
    }
}