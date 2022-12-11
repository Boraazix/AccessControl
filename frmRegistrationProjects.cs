﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class frmRegistrationProjects : Form
    {
        #region Singleton
        private static frmRegistrationProjects _instance;
        public static frmRegistrationProjects GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmRegistrationProjects();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        #endregion
        public frmRegistrationProjects()
        {
            InitializeComponent();

            dtpFinish.Value = DateTimePicker.MinDateTime;
            btnSaveChanges.Enabled = false;
            try
            {
                lstProjects.DataSource=ProjectRepository.FindAll();
                if(lstProjects.Items.Count>0) 
                    btnEditProject.Enabled = true;
            }
            catch (Exception) { throw; }
        }
        private void ClearFields()
        {
            txtName.Text = "";
            dtpFinish.Value = DateTimePicker.MinDateTime;
            dtpStart.Value = DateTime.Now;
            dtpPlannedFinish.Value = DateTime.Now;
            txtName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text=="")
                {
                    MessageBox.Show("Project name not entered!", "WITHOUT NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else if (txtName.Text.Length>35)
                {
                    MessageBox.Show("The project name can be a maximum of 35 characters!", "NAME LARGER THAN MAXIMUM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {

                    Project project= new Project(txtName.Text, dtpStart.Value, dtpPlannedFinish.Value, dtpFinish.Value);
                    ProjectRepository.Save(project);
                    lstProjects.DataSource= ProjectRepository.FindAll();

                    btnEditProject.Enabled = true;

                    MessageBox.Show("Project successfully registered.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch(Exception) { }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "NEW", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            Project project = (Project)lstProjects.SelectedItem;
            btnRegister.Enabled= false; btnEditProject.Enabled= false;
            btnDeleteProject.Enabled= false; lstProjects.Enabled= false;
            btnSaveChanges.Enabled= true;
            txtName.Text = project.Name;
            dtpFinish.Value= project.Finish;
            dtpStart.Value = project.Start;
            dtpPlannedFinish.Value= project.PlannedFinish;
            if(project.Finish==DateTimePicker.MinDateTime.Date)
                chkFinish.Checked= false;
            else
                chkFinish.Checked= true;
        }

        private void chkFinish_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFinish.Checked)
                dtpFinish.Enabled = true; 
            else
            {
                dtpFinish.Enabled = false;
                dtpFinish.Value = DateTimePicker.MinDateTime;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name not entered!", "WITHOUT NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else if (txtName.Text.Length > 35)
                {
                    MessageBox.Show("The name can be a maximum of 35 characters!", "NAME LARGER THAN MAXIMUM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {

                    Project project = (Project)lstProjects.SelectedItem;
                    project.Name = txtName.Text; project.Finish = dtpFinish.Value; 
                    project.Start = dtpStart.Value; project.PlannedFinish = dtpPlannedFinish.Value;

                    ProjectRepository.Save(project);
                    lstProjects.DataSource = ProjectRepository.FindAll();

                    MessageBox.Show("Project successfully updated.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRegister.Enabled = true; btnEditProject.Enabled = true;
                    btnDeleteProject.Enabled = true; lstProjects.Enabled = true;
                    btnSaveChanges.Enabled = false; chkFinish.Checked = false;

                    ClearFields();
                }
            }
            catch(Exception) { throw; }
        }
    }
}
