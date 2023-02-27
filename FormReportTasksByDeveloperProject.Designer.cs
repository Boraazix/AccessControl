namespace AccessControl
{
    partial class FormReportTasksByDeveloperProject
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblSelectedProject = new System.Windows.Forms.Label();
            this.lblSelectedDeveloper = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.rbtnAllocation = new System.Windows.Forms.RadioButton();
            this.rbtnProject = new System.Windows.Forms.RadioButton();
            this.rbtnDeveloper = new System.Windows.Forms.RadioButton();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpFilter);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(585, 264);
            this.pnlMain.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblSelectedProject);
            this.grpFilter.Controls.Add(this.lblSelectedDeveloper);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.lstProject);
            this.grpFilter.Controls.Add(this.lstDeveloper);
            this.grpFilter.Controls.Add(this.txtDeveloper);
            this.grpFilter.Controls.Add(this.txtProject);
            this.grpFilter.Controls.Add(this.lblDeveloper);
            this.grpFilter.Controls.Add(this.lblProject);
            this.grpFilter.Controls.Add(this.rbtnAllocation);
            this.grpFilter.Controls.Add(this.rbtnProject);
            this.grpFilter.Controls.Add(this.rbtnDeveloper);
            this.grpFilter.Controls.Add(this.lblFilterBy);
            this.grpFilter.Location = new System.Drawing.Point(12, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(560, 241);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // lblSelectedProject
            // 
            this.lblSelectedProject.AutoSize = true;
            this.lblSelectedProject.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedProject.Location = new System.Drawing.Point(289, 214);
            this.lblSelectedProject.Name = "lblSelectedProject";
            this.lblSelectedProject.Size = new System.Drawing.Size(183, 13);
            this.lblSelectedProject.TabIndex = 22;
            this.lblSelectedProject.Text = "wwwwwwwwwwwwwwwwwwwwww";
            // 
            // lblSelectedDeveloper
            // 
            this.lblSelectedDeveloper.AutoSize = true;
            this.lblSelectedDeveloper.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedDeveloper.Location = new System.Drawing.Point(10, 214);
            this.lblSelectedDeveloper.Name = "lblSelectedDeveloper";
            this.lblSelectedDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblSelectedDeveloper.TabIndex = 21;
            this.lblSelectedDeveloper.Text = "Select a Developer";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(474, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(287, 69);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(262, 134);
            this.lstProject.TabIndex = 6;
            this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.Location = new System.Drawing.Point(10, 69);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(262, 134);
            this.lstDeveloper.TabIndex = 4;
            this.lstDeveloper.SelectedIndexChanged += new System.EventHandler(this.lstDeveloper_SelectedIndexChanged);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(75, 43);
            this.txtDeveloper.MaxLength = 45;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(197, 20);
            this.txtDeveloper.TabIndex = 3;
            this.txtDeveloper.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDeveloper_KeyUp);
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(338, 43);
            this.txtProject.MaxLength = 35;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(211, 20);
            this.txtProject.TabIndex = 5;
            this.txtProject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProject_KeyUp);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(10, 46);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(59, 13);
            this.lblDeveloper.TabIndex = 15;
            this.lblDeveloper.Text = "Developer:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(289, 46);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 17;
            this.lblProject.Text = "Project:";
            // 
            // rbtnAllocation
            // 
            this.rbtnAllocation.AutoSize = true;
            this.rbtnAllocation.Checked = true;
            this.rbtnAllocation.Location = new System.Drawing.Point(206, 19);
            this.rbtnAllocation.Name = "rbtnAllocation";
            this.rbtnAllocation.Size = new System.Drawing.Size(71, 17);
            this.rbtnAllocation.TabIndex = 2;
            this.rbtnAllocation.TabStop = true;
            this.rbtnAllocation.Text = "Allocation";
            this.rbtnAllocation.UseVisualStyleBackColor = true;
            this.rbtnAllocation.CheckedChanged += new System.EventHandler(this.rbtnAllocation_CheckedChanged);
            // 
            // rbtnProject
            // 
            this.rbtnProject.AutoSize = true;
            this.rbtnProject.Location = new System.Drawing.Point(142, 19);
            this.rbtnProject.Name = "rbtnProject";
            this.rbtnProject.Size = new System.Drawing.Size(58, 17);
            this.rbtnProject.TabIndex = 1;
            this.rbtnProject.Text = "Project";
            this.rbtnProject.UseVisualStyleBackColor = true;
            this.rbtnProject.CheckedChanged += new System.EventHandler(this.rbtnProject_CheckedChanged);
            // 
            // rbtnDeveloper
            // 
            this.rbtnDeveloper.AutoSize = true;
            this.rbtnDeveloper.Location = new System.Drawing.Point(62, 19);
            this.rbtnDeveloper.Name = "rbtnDeveloper";
            this.rbtnDeveloper.Size = new System.Drawing.Size(74, 17);
            this.rbtnDeveloper.TabIndex = 0;
            this.rbtnDeveloper.Text = "Developer";
            this.rbtnDeveloper.UseVisualStyleBackColor = true;
            this.rbtnDeveloper.CheckedChanged += new System.EventHandler(this.rbtnDeveloper_CheckedChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(10, 21);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(46, 13);
            this.lblFilterBy.TabIndex = 10;
            this.lblFilterBy.Text = "Filter by:";
            // 
            // FormReportTasksByDeveloperProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 264);
            this.Controls.Add(this.pnlMain);
            this.Name = "FormReportTasksByDeveloperProject";
            this.Text = "Task Report";
            this.pnlMain.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.ListBox lstDeveloper;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.RadioButton rbtnAllocation;
        private System.Windows.Forms.RadioButton rbtnProject;
        private System.Windows.Forms.RadioButton rbtnDeveloper;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblSelectedProject;
        private System.Windows.Forms.Label lblSelectedDeveloper;
    }
}