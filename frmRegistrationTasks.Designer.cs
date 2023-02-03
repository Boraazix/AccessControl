namespace AccessControl
{
    partial class frmRegistrationTasks
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
            this.brpTasks = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.grpNewTask = new System.Windows.Forms.GroupBox();
            this.lblAllocationStatic = new System.Windows.Forms.Label();
            this.lblAllocationDynamic = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteText = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ttTasks = new System.Windows.Forms.ToolTip(this.components);
            this.grpAllocation = new System.Windows.Forms.GroupBox();
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.brpTasks.SuspendLayout();
            this.grpNewTask.SuspendLayout();
            this.grpAllocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpAllocation);
            this.pnlMain.Controls.Add(this.brpTasks);
            this.pnlMain.Controls.Add(this.grpNewTask);
            this.pnlMain.Location = new System.Drawing.Point(-1, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(687, 380);
            this.pnlMain.TabIndex = 0;
            // 
            // brpTasks
            // 
            this.brpTasks.Controls.Add(this.btnSaveChanges);
            this.brpTasks.Controls.Add(this.btnDeleteTask);
            this.brpTasks.Controls.Add(this.btnEditTask);
            this.brpTasks.Controls.Add(this.lstTasks);
            this.brpTasks.Location = new System.Drawing.Point(296, 164);
            this.brpTasks.Name = "brpTasks";
            this.brpTasks.Size = new System.Drawing.Size(376, 204);
            this.brpTasks.TabIndex = 2;
            this.brpTasks.TabStop = false;
            this.brpTasks.Text = "Tasks";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(251, 172);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(116, 23);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(128, 172);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(6, 172);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(116, 23);
            this.btnEditTask.TabIndex = 1;
            this.btnEditTask.Text = "Edit task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(6, 19);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(361, 147);
            this.lstTasks.Sorted = true;
            this.lstTasks.TabIndex = 0;
            this.lstTasks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstTasks_MouseMove);
            // 
            // grpNewTask
            // 
            this.grpNewTask.Controls.Add(this.lblAllocationStatic);
            this.grpNewTask.Controls.Add(this.lblAllocationDynamic);
            this.grpNewTask.Controls.Add(this.btnAddTask);
            this.grpNewTask.Controls.Add(this.btnDeleteText);
            this.grpNewTask.Controls.Add(this.txtDescription);
            this.grpNewTask.Location = new System.Drawing.Point(296, 14);
            this.grpNewTask.Name = "grpNewTask";
            this.grpNewTask.Size = new System.Drawing.Size(376, 144);
            this.grpNewTask.TabIndex = 1;
            this.grpNewTask.TabStop = false;
            this.grpNewTask.Text = "New Task";
            // 
            // lblAllocationStatic
            // 
            this.lblAllocationStatic.AutoSize = true;
            this.lblAllocationStatic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAllocationStatic.Location = new System.Drawing.Point(6, 118);
            this.lblAllocationStatic.Name = "lblAllocationStatic";
            this.lblAllocationStatic.Size = new System.Drawing.Size(56, 13);
            this.lblAllocationStatic.TabIndex = 4;
            this.lblAllocationStatic.Text = "Allocation:";
            // 
            // lblAllocationDynamic
            // 
            this.lblAllocationDynamic.AutoSize = true;
            this.lblAllocationDynamic.ForeColor = System.Drawing.Color.Green;
            this.lblAllocationDynamic.Location = new System.Drawing.Point(59, 118);
            this.lblAllocationDynamic.Name = "lblAllocationDynamic";
            this.lblAllocationDynamic.Size = new System.Drawing.Size(10, 13);
            this.lblAllocationDynamic.TabIndex = 3;
            this.lblAllocationDynamic.Text = "‎ ";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(292, 73);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.Location = new System.Drawing.Point(292, 30);
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteText.TabIndex = 1;
            this.btnDeleteText.Text = "Delete text";
            this.btnDeleteText.UseVisualStyleBackColor = true;
            this.btnDeleteText.Click += new System.EventHandler(this.btnDeleteText_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 19);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(280, 87);
            this.txtDescription.TabIndex = 0;
            // 
            // grpAllocation
            // 
            this.grpAllocation.Controls.Add(this.lstDeveloper);
            this.grpAllocation.Controls.Add(this.lstProject);
            this.grpAllocation.Controls.Add(this.txtProject);
            this.grpAllocation.Controls.Add(this.lblProject);
            this.grpAllocation.Controls.Add(this.lblDevelopers);
            this.grpAllocation.Location = new System.Drawing.Point(13, 14);
            this.grpAllocation.Name = "grpAllocation";
            this.grpAllocation.Size = new System.Drawing.Size(277, 354);
            this.grpAllocation.TabIndex = 0;
            this.grpAllocation.TabStop = false;
            this.grpAllocation.Text = "Allocation";
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.AutoSize = true;
            this.lblDevelopers.Location = new System.Drawing.Point(6, 156);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(130, 13);
            this.lblDevelopers.TabIndex = 5;
            this.lblDevelopers.Text = "Developers in this Project:";
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(6, 45);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(260, 108);
            this.lstProject.TabIndex = 1;
            this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(55, 19);
            this.txtProject.MaxLength = 35;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(211, 20);
            this.txtProject.TabIndex = 0;
            this.txtProject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProject_KeyUp);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(6, 22);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Project:";
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.Location = new System.Drawing.Point(6, 172);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(262, 173);
            this.lstDeveloper.TabIndex = 2;
            this.lstDeveloper.SelectedIndexChanged += new System.EventHandler(this.lstDeveloper_SelectedIndexChanged);
            // 
            // frmRegistrationTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 380);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "frmRegistrationTasks";
            this.Text = "frmRegistrationTasks";
            this.pnlMain.ResumeLayout(false);
            this.brpTasks.ResumeLayout(false);
            this.grpNewTask.ResumeLayout(false);
            this.grpNewTask.PerformLayout();
            this.grpAllocation.ResumeLayout(false);
            this.grpAllocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpNewTask;
        private System.Windows.Forms.Label lblAllocationDynamic;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteText;
        private System.Windows.Forms.GroupBox brpTasks;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblAllocationStatic;
        private System.Windows.Forms.ToolTip ttTasks;
        private System.Windows.Forms.GroupBox grpAllocation;
        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox lstDeveloper;
    }
}