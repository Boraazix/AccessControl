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
            this.mnuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevelopers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecord});
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
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(180, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuRecord
            // 
            this.mnuRecord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDevelopers,
            this.mnuProjects});
            this.mnuRecord.Name = "mnuRecord";
            this.mnuRecord.Size = new System.Drawing.Size(82, 20);
            this.mnuRecord.Text = "Registration";
            // 
            // mnuDevelopers
            // 
            this.mnuDevelopers.Name = "mnuDevelopers";
            this.mnuDevelopers.Size = new System.Drawing.Size(180, 22);
            this.mnuDevelopers.Text = "Developers";
            this.mnuDevelopers.Click += new System.EventHandler(this.mnuDevelopers_Click);
            // 
            // mnuProjects
            // 
            this.mnuProjects.Name = "mnuProjects";
            this.mnuProjects.Size = new System.Drawing.Size(180, 22);
            this.mnuProjects.Text = "Projects";
            this.mnuProjects.Click += new System.EventHandler(this.mnuProjects_Click);
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
        private global::System.Windows.Forms.ToolStripMenuItem mnuRecord;
        private global::System.Windows.Forms.ToolStripMenuItem mnuDevelopers;
        private global::System.Windows.Forms.ToolStripMenuItem mnuProjects;
    }
}