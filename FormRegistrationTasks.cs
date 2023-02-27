using AccessControl;
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
    public partial class FormRegistrationTasks : Form
    {
        private static Allocation _allocation;
        private static Task _selectedTask;
        #region Singleton
        private static FormRegistrationTasks _instance;
        public static FormRegistrationTasks GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormRegistrationTasks();
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormRegistrationTasks()
        {
            InitializeComponent();
            lstProject.DataSource = ProjectRepository.FindAll();
        }
        #endregion
        private void ClearFields()
        {
            txtDescription.Text = ""; txtDescription.Focus();
            btnAddTask.Enabled = true; btnEditTask.Enabled = true;
            btnDeleteTask.Enabled = true; btnSaveChanges.Enabled = false;
            lstTasks.Enabled = true; lstProject.Enabled = true;
            lstDeveloper.Enabled = true; txtProject.Enabled = true;
        }
        private void txtProject_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProject.Text.Length > 0)
            {
                lstProject.DataSource = ProjectRepository.FindByPartialNameWithAllocationDeveloperCredential(txtProject.Text);

                if (lstProject.SelectedIndex < 0)
                {
                    lstDeveloper.DataSource = null;
                    _allocation = null;
                    lblAllocationDynamic.Text = "";
                    lstTasks.DataSource = null;
                }
            }
            else
            {
                lstProject.DataSource = ProjectRepository.FindAll();
            }
        }
        private void btnDeleteText_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if(_allocation==null)
                {
                    MessageBox.Show("Select a Project and a Developer to add tasks!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtDescription.Text.Length == 0)
                {
                    MessageBox.Show("Description was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescription.Focus();
                }
                else
                {
                    Task task = new Task(txtDescription.Text);
                    _allocation.Tasks.Add(task);
                    AllocationRepository.Save(_allocation);

                    lstTasks.DataSource = new List<Task>(_allocation.Tasks);
                    MessageBox.Show("Task successfully registered.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTasks.SelectedIndex > -1)
                {
                    if (MessageBox.Show($"Are you sure you want to delete task \"{((Task)lstTasks.SelectedItem).Description}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        TaskRepository.Remove((Task)lstTasks.SelectedItem);
                        _allocation.Tasks.Remove((Task)lstTasks.SelectedItem);
                        lstTasks.DataSource = new List<Task>(_allocation.Tasks);
                        MessageBox.Show("Task successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Task was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstTasks.SelectedIndex<0)
                {
                    MessageBox.Show("Task was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _selectedTask = (Task)lstTasks.SelectedItem;
                    txtDescription.Text = _selectedTask.Description;
                    btnAddTask.Enabled = false; lstTasks.Enabled = false;
                    btnEditTask.Enabled = false; btnDeleteTask.Enabled = false;
                    btnSaveChanges.Enabled = true; lstProject.Enabled = false;
                    lstDeveloper.Enabled = false; txtProject.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescription.Text=="")
                {
                    MessageBox.Show("Description was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescription.Focus();
                }
                else
                {
                    _selectedTask.Description = txtDescription.Text;
                    TaskRepository.Update(_selectedTask);

                    lstTasks.DataSource = new List<Task>(_allocation.Tasks);
                    MessageBox.Show("Task successfully edited", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lstTasks_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstTasks.IndexFromPoint(e.Location);
            if (index >= 0 && index < lstTasks.Items.Count)
            {
                string itemText = lstTasks.Items[index].ToString();
                ttMain.SetToolTip(lstTasks, itemText);
            }
            else
            {
                ttMain.SetToolTip(lstTasks, string.Empty);
            }
        }

        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDeveloper.DataSource = AllocationRepository.FindDevelopersByProject((Project)lstProject.SelectedItem);

            if (lstDeveloper.SelectedIndex < 0)
            {
                _allocation = null;
                lblAllocationDynamic.Text = "";
                lstTasks.DataSource = null;
            }
        }

        private void lstDeveloper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDeveloper.SelectedIndex >= 0)
            {
                _allocation = AllocationRepository.FindByDeveloperAndProjectWithDeveloperProjectTask((Developer)lstDeveloper.SelectedItem, (Project)lstProject.SelectedItem);
                lblAllocationDynamic.Text = _allocation.ToString().Substring(_allocation.ToString().IndexOf(" "));
                lstTasks.DataSource = new List<Task>(_allocation.Tasks);
            }
        }

        private void lstProject_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstProject.IndexFromPoint(e.Location);
            if (index >= 0 && index < lstProject.Items.Count)
            {
                string itemText = ((Project)lstProject.Items[index]).Name;
                ttMain.SetToolTip(lstProject, itemText);
            }
            else
            {
                ttMain.SetToolTip(lstProject, string.Empty);
            }
        }

        private void lstDeveloper_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstDeveloper.IndexFromPoint(e.Location);
            if (index >= 0 && index < lstDeveloper.Items.Count)
            {
                string itemText = ((Developer)lstDeveloper.Items[index]).Name;
                ttMain.SetToolTip(lstDeveloper, itemText);
            }
            else
            {
                ttMain.SetToolTip(lstDeveloper, string.Empty);
            }
        }
    }
}
