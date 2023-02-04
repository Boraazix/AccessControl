using System;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ClearFields()
        {
            txtName.Text = "";
            dtpFinish.Value = DateTimePicker.MinDateTime;
            dtpStart.Value = DateTime.Now;
            dtpPlannedFinish.Value = DateTime.Now;
            txtName.Focus();
        }
        private void lstProject_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstProjects.IndexFromPoint(e.Location);
            if (index >= 0 && index < lstProjects.Items.Count)
            {
                string itemText = ((Project)lstProjects.Items[index]).Name;
                ttMain.SetToolTip(lstProjects, itemText);
            }
            else
            {
                ttMain.SetToolTip(lstProjects, string.Empty);
            }
        }
        private void chkFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFinish.Checked)
                dtpFinish.Enabled = true;
            else
            {
                dtpFinish.Enabled = false;
                dtpFinish.Value = DateTimePicker.MinDateTime;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text=="")
                {
                    MessageBox.Show("Project name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else
                {

                    Project project= new Project(txtName.Text, dtpStart.Value.Date, dtpPlannedFinish.Value.Date, dtpFinish.Value.Date);
                    ProjectRepository.Save(project);
                    lstProjects.DataSource= ProjectRepository.FindAll();

                    btnEditProject.Enabled = true;

                    MessageBox.Show("Project successfully registered.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "New", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else
                {

                    Project project = (Project)lstProjects.SelectedItem;
                    project.Name = txtName.Text; project.Finish = dtpFinish.Value; 
                    project.Start = dtpStart.Value; project.PlannedFinish = dtpPlannedFinish.Value;

                    ProjectRepository.Save(project);
                    lstProjects.DataSource = ProjectRepository.FindAll();

                    MessageBox.Show("Project Successfully updated.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRegister.Enabled = true; btnEditProject.Enabled = true;
                    btnDeleteProject.Enabled = true; lstProjects.Enabled = true;
                    btnSaveChanges.Enabled = false; chkFinish.Checked = false;

                    ClearFields();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
