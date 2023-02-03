namespace AccessControl
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrationDevelopers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrationProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrationAllocations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportDevelopers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrationTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRegistration,
            this.mnuReport});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuBack});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(107, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuRegistration
            // 
            this.mnuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistrationDevelopers,
            this.mnuRegistrationProjects,
            this.mnuRegistrationAllocations,
            this.mnuRegistrationTasks});
            this.mnuRegistration.Name = "mnuRegistration";
            this.mnuRegistration.Size = new System.Drawing.Size(82, 20);
            this.mnuRegistration.Text = "Registration";
            // 
            // mnuRegistrationDevelopers
            // 
            this.mnuRegistrationDevelopers.Name = "mnuRegistrationDevelopers";
            this.mnuRegistrationDevelopers.Size = new System.Drawing.Size(180, 22);
            this.mnuRegistrationDevelopers.Text = "Developers";
            this.mnuRegistrationDevelopers.Click += new System.EventHandler(this.mnuDevelopers_Click);
            // 
            // mnuRegistrationProjects
            // 
            this.mnuRegistrationProjects.Name = "mnuRegistrationProjects";
            this.mnuRegistrationProjects.Size = new System.Drawing.Size(180, 22);
            this.mnuRegistrationProjects.Text = "Projects";
            this.mnuRegistrationProjects.Click += new System.EventHandler(this.mnuProjects_Click);
            // 
            // mnuRegistrationAllocations
            // 
            this.mnuRegistrationAllocations.Name = "mnuRegistrationAllocations";
            this.mnuRegistrationAllocations.Size = new System.Drawing.Size(180, 22);
            this.mnuRegistrationAllocations.Text = "Allocations";
            this.mnuRegistrationAllocations.Click += new System.EventHandler(this.mnuRegistrationAllocations_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportDevelopers,
            this.mnuReportProjects});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(54, 20);
            this.mnuReport.Text = "Report";
            // 
            // mnuReportDevelopers
            // 
            this.mnuReportDevelopers.Name = "mnuReportDevelopers";
            this.mnuReportDevelopers.Size = new System.Drawing.Size(132, 22);
            this.mnuReportDevelopers.Text = "Developers";
            this.mnuReportDevelopers.Click += new System.EventHandler(this.mnuReportDevelopers_Click);
            // 
            // mnuReportProjects
            // 
            this.mnuReportProjects.Name = "mnuReportProjects";
            this.mnuReportProjects.Size = new System.Drawing.Size(132, 22);
            this.mnuReportProjects.Text = "Projects";
            this.mnuReportProjects.Click += new System.EventHandler(this.mnuReportProjects_Click);
            // 
            // mnuRegistrationTasks
            // 
            this.mnuRegistrationTasks.Name = "mnuRegistrationTasks";
            this.mnuRegistrationTasks.Size = new System.Drawing.Size(180, 22);
            this.mnuRegistrationTasks.Text = "Tasks";
            this.mnuRegistrationTasks.Click += new System.EventHandler(this.mnuRegistrationTasks_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.MenuStrip mnuMain;
        private global::System.Windows.Forms.ToolStripMenuItem mnuFile;
        private global::System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private global::System.Windows.Forms.ToolStripMenuItem mnuBack;
        private global::System.Windows.Forms.ToolStripMenuItem mnuRegistration;
        private global::System.Windows.Forms.ToolStripMenuItem mnuRegistrationDevelopers;
        private global::System.Windows.Forms.ToolStripMenuItem mnuRegistrationProjects;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportDevelopers;
        private System.Windows.Forms.ToolStripMenuItem mnuReportProjects;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrationAllocations;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrationTasks;
    }
}