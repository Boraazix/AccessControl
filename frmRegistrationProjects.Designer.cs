namespace AccessControl
{
    partial class frmRegistrationProjects
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.grpRegistration = new System.Windows.Forms.GroupBox();
            this.chkFinish = new System.Windows.Forms.CheckBox();
            this.lblPlannedFinish = new System.Windows.Forms.Label();
            this.dtpPlannedFinish = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.grpRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSaveChanges);
            this.pnlMain.Controls.Add(this.btnDeleteProject);
            this.pnlMain.Controls.Add(this.btnEditProject);
            this.pnlMain.Controls.Add(this.lstProjects);
            this.pnlMain.Controls.Add(this.grpRegistration);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(442, 331);
            this.pnlMain.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(292, 299);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(135, 21);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(151, 299);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(135, 21);
            this.btnDeleteProject.TabIndex = 9;
            this.btnDeleteProject.Text = "Delete project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Enabled = false;
            this.btnEditProject.Location = new System.Drawing.Point(11, 299);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(135, 21);
            this.btnEditProject.TabIndex = 8;
            this.btnEditProject.Text = "Edit project";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // lstProjects
            // 
            this.lstProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(12, 124);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(416, 166);
            this.lstProjects.TabIndex = 2;
            this.lstProjects.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstProject_MouseMove);
            // 
            // grpRegistration
            // 
            this.grpRegistration.Controls.Add(this.chkFinish);
            this.grpRegistration.Controls.Add(this.lblPlannedFinish);
            this.grpRegistration.Controls.Add(this.dtpPlannedFinish);
            this.grpRegistration.Controls.Add(this.lblStart);
            this.grpRegistration.Controls.Add(this.dtpStart);
            this.grpRegistration.Controls.Add(this.lblName);
            this.grpRegistration.Controls.Add(this.btnRegister);
            this.grpRegistration.Controls.Add(this.txtName);
            this.grpRegistration.Controls.Add(this.lblFinish);
            this.grpRegistration.Controls.Add(this.dtpFinish);
            this.grpRegistration.Location = new System.Drawing.Point(12, 12);
            this.grpRegistration.Name = "grpRegistration";
            this.grpRegistration.Size = new System.Drawing.Size(416, 106);
            this.grpRegistration.TabIndex = 1;
            this.grpRegistration.TabStop = false;
            this.grpRegistration.Text = "Registration";
            // 
            // chkFinish
            // 
            this.chkFinish.AutoSize = true;
            this.chkFinish.Location = new System.Drawing.Point(217, 33);
            this.chkFinish.Name = "chkFinish";
            this.chkFinish.Size = new System.Drawing.Size(86, 17);
            this.chkFinish.TabIndex = 2;
            this.chkFinish.Text = "Enable finish";
            this.chkFinish.UseVisualStyleBackColor = true;
            this.chkFinish.CheckedChanged += new System.EventHandler(this.chkFinish_CheckedChanged);
            // 
            // lblPlannedFinish
            // 
            this.lblPlannedFinish.AutoSize = true;
            this.lblPlannedFinish.Location = new System.Drawing.Point(121, 55);
            this.lblPlannedFinish.Name = "lblPlannedFinish";
            this.lblPlannedFinish.Size = new System.Drawing.Size(76, 13);
            this.lblPlannedFinish.TabIndex = 12;
            this.lblPlannedFinish.Text = "Planned finish:";
            // 
            // dtpPlannedFinish
            // 
            this.dtpPlannedFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlannedFinish.Location = new System.Drawing.Point(124, 71);
            this.dtpPlannedFinish.Name = "dtpPlannedFinish";
            this.dtpPlannedFinish.Size = new System.Drawing.Size(100, 20);
            this.dtpPlannedFinish.TabIndex = 5;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 55);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(32, 13);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Start:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(9, 71);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(100, 20);
            this.dtpStart.TabIndex = 4;
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
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(242, 70);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 21);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 31);
            this.txtName.MaxLength = 35;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(300, 15);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(37, 13);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Finish:";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Enabled = false;
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinish.Location = new System.Drawing.Point(303, 31);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(100, 20);
            this.dtpFinish.TabIndex = 3;
            // 
            // frmRegistrationProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 331);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 370);
            this.MinimumSize = new System.Drawing.Size(458, 370);
            this.Name = "frmRegistrationProjects";
            this.Text = "Projects Registration";
            this.pnlMain.ResumeLayout(false);
            this.grpRegistration.ResumeLayout(false);
            this.grpRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.GroupBox grpRegistration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblPlannedFinish;
        private System.Windows.Forms.DateTimePicker dtpPlannedFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox chkFinish;
        private System.Windows.Forms.ToolTip ttMain;
    }
}