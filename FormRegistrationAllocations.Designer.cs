namespace AccessControl
{
    partial class FormRegistrationAllocations
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
            this.lblAllocation = new System.Windows.Forms.Label();
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.lblDeveloperProject = new System.Windows.Forms.Label();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteAllocation = new System.Windows.Forms.Button();
            this.btnEditAllocation = new System.Windows.Forms.Button();
            this.lstAllocations = new System.Windows.Forms.ListBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRemuneration = new System.Windows.Forms.Label();
            this.txtRemuneration = new System.Windows.Forms.TextBox();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.numHoursPerWeek = new System.Windows.Forms.NumericUpDown();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.grpAllocation = new System.Windows.Forms.GroupBox();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblSelectedDeveloper = new System.Windows.Forms.Label();
            this.lblSelectedProject = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursPerWeek)).BeginInit();
            this.grpAllocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblAllocation);
            this.pnlMain.Controls.Add(this.txtAllocation);
            this.pnlMain.Controls.Add(this.lblDeveloperProject);
            this.pnlMain.Controls.Add(this.btnAddTasks);
            this.pnlMain.Controls.Add(this.btnSaveChanges);
            this.pnlMain.Controls.Add(this.btnDeleteAllocation);
            this.pnlMain.Controls.Add(this.btnEditAllocation);
            this.pnlMain.Controls.Add(this.lstAllocations);
            this.pnlMain.Controls.Add(this.grpData);
            this.pnlMain.Controls.Add(this.grpAllocation);
            this.pnlMain.Location = new System.Drawing.Point(0, -1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(597, 511);
            this.pnlMain.TabIndex = 0;
            // 
            // lblAllocation
            // 
            this.lblAllocation.AutoSize = true;
            this.lblAllocation.ForeColor = System.Drawing.Color.Green;
            this.lblAllocation.Location = new System.Drawing.Point(317, 317);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(95, 13);
            this.lblAllocation.TabIndex = 8;
            this.lblAllocation.Text = "Select a Allocation";
            // 
            // txtAllocation
            // 
            this.txtAllocation.Location = new System.Drawing.Point(114, 314);
            this.txtAllocation.MaxLength = 45;
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.Size = new System.Drawing.Size(197, 20);
            this.txtAllocation.TabIndex = 2;
            this.txtAllocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAllocation_KeyUp);
            // 
            // lblDeveloperProject
            // 
            this.lblDeveloperProject.AutoSize = true;
            this.lblDeveloperProject.Location = new System.Drawing.Point(11, 317);
            this.lblDeveloperProject.Name = "lblDeveloperProject";
            this.lblDeveloperProject.Size = new System.Drawing.Size(97, 13);
            this.lblDeveloperProject.TabIndex = 8;
            this.lblDeveloperProject.Text = "Developer/Project:";
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.Location = new System.Drawing.Point(300, 480);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(138, 21);
            this.btnAddTasks.TabIndex = 6;
            this.btnAddTasks.Text = "Add tasks";
            this.btnAddTasks.UseVisualStyleBackColor = true;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(444, 480);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 21);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteAllocation
            // 
            this.btnDeleteAllocation.Location = new System.Drawing.Point(156, 480);
            this.btnDeleteAllocation.Name = "btnDeleteAllocation";
            this.btnDeleteAllocation.Size = new System.Drawing.Size(138, 21);
            this.btnDeleteAllocation.TabIndex = 5;
            this.btnDeleteAllocation.Text = "Delete allocation";
            this.btnDeleteAllocation.UseVisualStyleBackColor = true;
            this.btnDeleteAllocation.Click += new System.EventHandler(this.btnDeleteAllocation_Click);
            // 
            // btnEditAllocation
            // 
            this.btnEditAllocation.Location = new System.Drawing.Point(12, 480);
            this.btnEditAllocation.Name = "btnEditAllocation";
            this.btnEditAllocation.Size = new System.Drawing.Size(138, 21);
            this.btnEditAllocation.TabIndex = 4;
            this.btnEditAllocation.Text = "Edit allocation";
            this.btnEditAllocation.UseVisualStyleBackColor = true;
            this.btnEditAllocation.Click += new System.EventHandler(this.btnEditAllocation_Click);
            // 
            // lstAllocations
            // 
            this.lstAllocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllocations.FormattingEnabled = true;
            this.lstAllocations.ItemHeight = 18;
            this.lstAllocations.Location = new System.Drawing.Point(12, 340);
            this.lstAllocations.Name = "lstAllocations";
            this.lstAllocations.Size = new System.Drawing.Size(571, 130);
            this.lstAllocations.TabIndex = 3;
            this.lstAllocations.SelectedIndexChanged += new System.EventHandler(this.lstAllocations_SelectedIndexChanged);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnSave);
            this.grpData.Controls.Add(this.lblRemuneration);
            this.grpData.Controls.Add(this.txtRemuneration);
            this.grpData.Controls.Add(this.lblHoursPerWeek);
            this.grpData.Controls.Add(this.numHoursPerWeek);
            this.grpData.Controls.Add(this.dtpFinish);
            this.grpData.Controls.Add(this.lblFinish);
            this.grpData.Controls.Add(this.dtpStart);
            this.grpData.Controls.Add(this.lblStart);
            this.grpData.Location = new System.Drawing.Point(12, 238);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(571, 70);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRemuneration
            // 
            this.lblRemuneration.AutoSize = true;
            this.lblRemuneration.Location = new System.Drawing.Point(340, 19);
            this.lblRemuneration.Name = "lblRemuneration";
            this.lblRemuneration.Size = new System.Drawing.Size(99, 13);
            this.lblRemuneration.TabIndex = 12;
            this.lblRemuneration.Text = "Remuneration (R$):";
            // 
            // txtRemuneration
            // 
            this.txtRemuneration.Location = new System.Drawing.Point(343, 35);
            this.txtRemuneration.MaxLength = 15;
            this.txtRemuneration.Name = "txtRemuneration";
            this.txtRemuneration.Size = new System.Drawing.Size(100, 20);
            this.txtRemuneration.TabIndex = 3;
            this.txtRemuneration.TextChanged += new System.EventHandler(this.txtRemuneration_TextChanged);
            this.txtRemuneration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemuneration_KeyDown);
            this.txtRemuneration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemuneration_KeyPress);
            this.txtRemuneration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRemuneration_KeyUp);
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(241, 19);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(85, 13);
            this.lblHoursPerWeek.TabIndex = 10;
            this.lblHoursPerWeek.Text = "Hours per week:";
            // 
            // numHoursPerWeek
            // 
            this.numHoursPerWeek.Location = new System.Drawing.Point(244, 35);
            this.numHoursPerWeek.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHoursPerWeek.Name = "numHoursPerWeek";
            this.numHoursPerWeek.Size = new System.Drawing.Size(82, 20);
            this.numHoursPerWeek.TabIndex = 2;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinish.Location = new System.Drawing.Point(129, 35);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(100, 20);
            this.dtpFinish.TabIndex = 1;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(126, 19);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(37, 13);
            this.lblFinish.TabIndex = 5;
            this.lblFinish.Text = "Finish:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(13, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(100, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(10, 19);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(32, 13);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Start:";
            // 
            // grpAllocation
            // 
            this.grpAllocation.Controls.Add(this.lblSelectedProject);
            this.grpAllocation.Controls.Add(this.lblSelectedDeveloper);
            this.grpAllocation.Controls.Add(this.lstProject);
            this.grpAllocation.Controls.Add(this.lstDeveloper);
            this.grpAllocation.Controls.Add(this.txtDeveloper);
            this.grpAllocation.Controls.Add(this.txtProject);
            this.grpAllocation.Controls.Add(this.lblDeveloper);
            this.grpAllocation.Controls.Add(this.lblProject);
            this.grpAllocation.Location = new System.Drawing.Point(12, 13);
            this.grpAllocation.Name = "grpAllocation";
            this.grpAllocation.Size = new System.Drawing.Size(571, 218);
            this.grpAllocation.TabIndex = 0;
            this.grpAllocation.TabStop = false;
            this.grpAllocation.Text = "Allocation";
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(292, 45);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(262, 134);
            this.lstProject.TabIndex = 3;
            this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
            this.lstProject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstProject_MouseMove);
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.Location = new System.Drawing.Point(15, 45);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(262, 134);
            this.lstDeveloper.TabIndex = 1;
            this.lstDeveloper.SelectedIndexChanged += new System.EventHandler(this.lstDeveloper_SelectedIndexChanged);
            this.lstDeveloper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstDeveloper_MouseMove);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(80, 19);
            this.txtDeveloper.MaxLength = 45;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(197, 20);
            this.txtDeveloper.TabIndex = 0;
            this.txtDeveloper.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDeveloper_KeyUp);
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(343, 19);
            this.txtProject.MaxLength = 35;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(211, 20);
            this.txtProject.TabIndex = 2;
            this.txtProject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProject_KeyUp);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(15, 22);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(59, 13);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developer:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(294, 22);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Project:";
            // 
            // lblSelectedDeveloper
            // 
            this.lblSelectedDeveloper.AutoSize = true;
            this.lblSelectedDeveloper.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedDeveloper.Location = new System.Drawing.Point(15, 191);
            this.lblSelectedDeveloper.Name = "lblSelectedDeveloper";
            this.lblSelectedDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblSelectedDeveloper.TabIndex = 6;
            this.lblSelectedDeveloper.Text = "Select a Developer";
            // 
            // lblSelectedProject
            // 
            this.lblSelectedProject.AutoSize = true;
            this.lblSelectedProject.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedProject.Location = new System.Drawing.Point(294, 191);
            this.lblSelectedProject.Name = "lblSelectedProject";
            this.lblSelectedProject.Size = new System.Drawing.Size(82, 13);
            this.lblSelectedProject.TabIndex = 7;
            this.lblSelectedProject.Text = "Select a Project";
            // 
            // frmRegistrationAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 510);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "frmRegistrationAllocations";
            this.Text = "Allocations Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegistrationAllocations_FormClosed);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursPerWeek)).EndInit();
            this.grpAllocation.ResumeLayout(false);
            this.grpAllocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpAllocation;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.ListBox lstDeveloper;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRemuneration;
        private System.Windows.Forms.TextBox txtRemuneration;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.NumericUpDown numHoursPerWeek;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ListBox lstAllocations;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteAllocation;
        private System.Windows.Forms.Button btnEditAllocation;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.TextBox txtAllocation;
        private System.Windows.Forms.Label lblDeveloperProject;
        private System.Windows.Forms.Label lblSelectedProject;
        private System.Windows.Forms.Label lblSelectedDeveloper;
        private System.Windows.Forms.ToolTip ttMain;
    }
}