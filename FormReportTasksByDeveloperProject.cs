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
    public partial class FormReportTasksByDeveloperProject : Form
    {
        #region Singleton
        private static FormReportTasksByDeveloperProject _instance;
        public static FormReportTasksByDeveloperProject GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormReportTasksByDeveloperProject();
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormReportTasksByDeveloperProject()
        {
            InitializeComponent();
            lstDeveloper.DataSource = DeveloperRepository.FindAllWCredential();
            lstProject.DataSource = ProjectRepository.FindAll();
        }
        #endregion
        private static Developer _selectedDeveloper;
        private static Project _selectedProject;

        private void txtDeveloper_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDeveloper.Text.Length > 0)
                lstDeveloper.DataSource = DeveloperRepository.FindByPartialNameWCredential(txtDeveloper.Text);
            else
                lstDeveloper.DataSource = DeveloperRepository.FindAllWCredential();
            if (lstDeveloper.SelectedIndex < 0)
            {
                lblSelectedDeveloper.Text = "Select a Developer";
                lblSelectedDeveloper.ForeColor = Color.Red;
            }
        }

        private void txtProject_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProject.Text.Length > 0)
                lstProject.DataSource = ProjectRepository.FindByPartialNameWithAllocationDeveloperCredential(txtProject.Text);
            else
                lstProject.DataSource = ProjectRepository.FindAll();
            if (lstProject.SelectedIndex < 0)
            {
                lblSelectedProject.Text = "Select a Project";
                lblSelectedProject.ForeColor = Color.Red;
            }
        }

        private void lstDeveloper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbtnAllocation.Checked || rbtnDeveloper.Checked)
            {
                _selectedDeveloper = (Developer)lstDeveloper.SelectedItem;
                lblSelectedDeveloper.Text = (_selectedDeveloper.Name.Length > 31 ? _selectedDeveloper.Name.Substring(0, 31) + "..." : _selectedDeveloper.Name);
                lblSelectedDeveloper.ForeColor = Color.Green;
            }
        }

        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnAllocation.Checked || rbtnProject.Checked)
            {
                _selectedProject = (Project)lstProject.SelectedItem;
                lblSelectedProject.Text = (_selectedProject.Name.Length > 31 ? _selectedProject.Name.Substring(0, 31) + "..." : _selectedProject.Name);
                lblSelectedProject.ForeColor = Color.Green;
            }
        }

        private void rbtnAllocation_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAllocation.Checked)
            {
                txtDeveloper.Enabled = true; txtProject.Enabled = true;
                lstDeveloper.Enabled = true; lstProject.Enabled = true;

                lstProject.DataSource = ProjectRepository.FindAll();
                lstDeveloper.DataSource = DeveloperRepository.FindAllWCredential();
            }
        }

        private void rbtnProject_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnProject.Checked)
            {
                txtDeveloper.Enabled = false; txtProject.Enabled = true;
                lstDeveloper.Enabled = false; lstProject.Enabled = true;

                lstProject.DataSource = ProjectRepository.FindAll();

                txtDeveloper.Text = ""; lstDeveloper.DataSource = null;
                _selectedDeveloper = null;
                lblSelectedDeveloper.Text = "Select a Developer";
                lblSelectedDeveloper.ForeColor = Color.Red;
            }
        }

        private void rbtnDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDeveloper.Checked)
            {
                txtDeveloper.Enabled = true; txtProject.Enabled = false;
                lstDeveloper.Enabled = true; lstProject.Enabled = false;

                lstDeveloper.DataSource= DeveloperRepository.FindAllWCredential();

                txtProject.Text = ""; lstProject.DataSource = null;
                _selectedProject = null;
                lblSelectedProject.Text = "Select a Project";
                lblSelectedProject.ForeColor = Color.Red;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportTasks.GetInstance(_selectedDeveloper, _selectedProject).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
