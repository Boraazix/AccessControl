using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccessControl
{
    public partial class FormRegistrationAllocations : Form
    {
        #region Singleton
        private static FormRegistrationAllocations _instance;
        public static FormRegistrationAllocations GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormRegistrationAllocations();
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormRegistrationAllocations()
        {
            InitializeComponent();
            lstDeveloper.DataSource = DeveloperRepository.FindAllWCredential();
            lstProject.DataSource = ProjectRepository.FindAll();
            lstAllocations.DataSource = AllocationRepository.FindAllWithDeveloperProjectTask();
            if (lstAllocations.SelectedIndex == -1)
                lblAllocation.Text = "";
        }
        #endregion

        private static Developer _selectedDeveloper;
        private static Project _selectedProject;
        private void ClearFields()
        {
            txtDeveloper.Text = string.Empty;
            txtProject.Text = string.Empty;

            _selectedDeveloper= null;
            _selectedProject= null;
            lblSelectedDeveloper.Text = "Select a Developer";
            lblSelectedDeveloper.ForeColor= Color.Red;
            lblSelectedProject.Text = "Select a Project";
            lblSelectedProject.ForeColor= Color.Red;

            dtpStart.Value=DateTime.Now;
            dtpFinish.Value = DateTime.Now;
            numHoursPerWeek.Value = 0;
            txtRemuneration.Text = string.Empty;

            txtDeveloper.Enabled = true; txtProject.Enabled = true;
            txtAllocation.Enabled = true;
            lstDeveloper.Enabled = true; lstProject.Enabled = true;
            btnSave.Enabled = true; btnSaveChanges.Enabled = false;
            lstAllocations.Enabled = true; btnEditAllocation.Enabled = true;
            btnDeleteAllocation.Enabled = true; btnAddTasks.Enabled = true;
        }
        private void Save()
        {
            try
            {
                if(_selectedDeveloper== null)
                {
                    MessageBox.Show("Developer was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDeveloper.Focus();
                }
                else if (_selectedProject== null)
                {
                    MessageBox.Show("Project was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtProject.Focus();
                }
                else if (AllocationRepository.FindByDeveloperAndProjectWithDeveloperProjectTask(_selectedDeveloper,_selectedProject)!=null)
                {
                    MessageBox.Show("This allocation is already registered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDeveloper.Focus();
                }
                else if(txtRemuneration.Text.Length==0)
                {
                    MessageBox.Show("Remuneration was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRemuneration.Focus();
                }
                else
                {
                    Allocation allocation=new Allocation(dtpStart.Value.Date, dtpFinish.Value.Date, Convert.ToByte(numHoursPerWeek.Value), Convert.ToDecimal(txtRemuneration.Text), _selectedDeveloper, _selectedProject);
                    AllocationRepository.Save(allocation);

                    lstAllocations.DataSource=AllocationRepository.FindAllWithDeveloperProjectTask();
                    MessageBox.Show("Allocation successfully registered.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void txtRemuneration_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
        private void frmRegistrationAllocations_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearFields();
        }

        private void txtDeveloper_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtDeveloper.Text.Length > 0)
                lstDeveloper.DataSource=DeveloperRepository.FindByPartialNameWCredential(txtDeveloper.Text);
            else
                lstDeveloper.DataSource=DeveloperRepository.FindAllWCredential();
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
                lstProject.DataSource=ProjectRepository.FindAll();
            if (lstProject.SelectedIndex < 0)
            {
                lblSelectedProject.Text = "Select a Project";
                lblSelectedProject.ForeColor = Color.Red;
            }
        }
        private void txtAllocation_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtAllocation.Text.Length > 0)
                    lstAllocations.DataSource = AllocationRepository.FindByPartialNameWithDeveloperProjectTask(txtAllocation.Text);
                else
                    lstAllocations.DataSource = AllocationRepository.FindAllWithDeveloperProjectTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #region txtRemuneration mask
        private void txtRemuneration_KeyPress(object sender, KeyPressEventArgs e)
        {
            // making a 'custom mask' to txtRemuneration

            // turning dots into commas
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (
                // allowing only numbers and comma
                !char.IsDigit(e.KeyChar) && (e.KeyChar != ',' && !char.IsControl(e.KeyChar))
                // don't allow more than one comma, and don't allow the comma if is the first character
                || e.KeyChar == ',' && (txtRemuneration.Text.Contains(",") || txtRemuneration.SelectionStart == 0)
                // don't allow more than 2 numbers after comma
                || txtRemuneration.Text.Length == (txtRemuneration.Text.IndexOf(',') == -1 ? -1 : txtRemuneration.Text.IndexOf(',') + 3) && e.KeyChar != (char)Keys.Back && txtRemuneration.SelectionStart>txtRemuneration.Text.IndexOf(',')
                )
            {
                e.Handled = true;
            }
            // if a digit is entered after zero before the comma, the zero is deleted
            if(txtRemuneration.SelectionStart> 0 && txtRemuneration.SelectionStart <= txtRemuneration.Text.IndexOf(',') && txtRemuneration.Text[0]=='0' && e.KeyChar!=(char)Keys.Back)
            {
                StringBuilder sb = new StringBuilder(txtRemuneration.Text);
                while (sb.ToString()[0] == '0')
                    sb.Remove(0, 1);
                txtRemuneration.Text = sb.ToString();
            }
        }
        private void txtRemuneration_KeyDown(object sender, KeyEventArgs e)
        {
            // making a 'custom mask' to txtRemuneration, part two

            // if just have one digit before the comma, and this digit is deleted, puts zero in place of the entered digit
            // (the "Delete" key was not detected by the KeyPress event, so i did it here.)
            if (txtRemuneration.Text.Length>1 && e.KeyCode == Keys.Delete && txtRemuneration.SelectionStart == 0 && txtRemuneration.Text[1] == ',')
            {
                e.SuppressKeyPress = true;
                StringBuilder sb= new StringBuilder(txtRemuneration.Text);
                sb.Remove(0,2);
                txtRemuneration.Text = Convert.ToString(sb);
            }
            if (txtRemuneration.Text.Length > 1 && e.KeyCode == Keys.Back && txtRemuneration.SelectionStart == 1 && txtRemuneration.Text[1] == ',')
            {
                e.SuppressKeyPress = true;
                StringBuilder sb = new StringBuilder(txtRemuneration.Text);
                sb.Remove(0, 1); sb.Insert(0, '0');
                txtRemuneration.Text = Convert.ToString(sb);
                txtRemuneration.SelectionStart = 1;
            }
        }
        private void txtRemuneration_TextChanged(object sender, EventArgs e)
        {
            // the copied text need have just digits and just one comma
            string newText = "";
            int count = 0;
            foreach (char c in txtRemuneration.Text)
            {
                if (char.IsDigit(c) || (c == ',' && count == 0))
                {
                    newText += c;
                    if (c == ',') 
                        count++;
                }
            }
            // delete digits after two after comma
            while (newText.Length-1 > newText.IndexOf(",")+2 && newText.IndexOf(",")!=-1)
            {
                newText = newText.Remove(newText.Length - 1, 1);
            }
            txtRemuneration.Text = newText;
        }
        #endregion

        private void btnEditAllocation_Click(object sender, EventArgs e)
        {
            if (lstAllocations.SelectedIndex > -1)
            {
                Allocation al = (Allocation)lstAllocations.SelectedItem;

                txtDeveloper.Enabled = false; txtProject.Enabled = false;
                txtAllocation.Enabled = false;
                lstDeveloper.Enabled = false; lstProject.Enabled = false;
                btnSave.Enabled = false; btnSaveChanges.Enabled = true;
                lstAllocations.Enabled = false; btnEditAllocation.Enabled = false;
                btnDeleteAllocation.Enabled = false; btnAddTasks.Enabled = false;

                dtpStart.Value = al.Start; dtpFinish.Value=al.Finish;
                numHoursPerWeek.Value = al.HoursPerWeek; txtRemuneration.Text = Convert.ToString(al.Remuneration);
            }
            else
                MessageBox.Show("Allocation was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDeleteAllocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAllocations.SelectedIndex > -1)
                {
                    if (MessageBox.Show($"Are you sure you want to delete allocation {((Allocation)lstAllocations.SelectedItem).Id}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AllocationRepository.Remove((Allocation)lstAllocations.SelectedItem);
                        lstAllocations.DataSource = AllocationRepository.FindAllWithDeveloperProjectTask();
                        if (lstAllocations.SelectedIndex == -1)
                            lblAllocation.Text = "";
                        MessageBox.Show("Allocation successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Allocation was not selected!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRemuneration.Text.Length == 0)
                {
                    MessageBox.Show("Remuneration was not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRemuneration.Focus();
                }
                else
                {
                    Allocation al = (Allocation)lstAllocations.SelectedItem;

                    al.Start = dtpStart.Value; al.Finish = dtpFinish.Value;
                    al.HoursPerWeek = Convert.ToByte(numHoursPerWeek.Value);
                    al.Remuneration = Convert.ToDecimal(txtRemuneration.Text);

                    AllocationRepository.Save(al);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            FormRegistrationTasks.GetInstance().Show();
        }

        private void lstAllocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAllocation.Text = lstAllocations.SelectedItem.ToString();
        }

        private void lstDeveloper_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedDeveloper = (Developer)lstDeveloper.SelectedItem;
            lblSelectedDeveloper.Text = (_selectedDeveloper.Name.Length > 31 ? _selectedDeveloper.Name.Substring(0, 31) + "..." : _selectedDeveloper.Name);
            lblSelectedDeveloper.ForeColor = Color.Green;
        }

        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProject = (Project)lstProject.SelectedItem;
            lblSelectedProject.Text = (_selectedProject.Name.Length > 20 ? _selectedProject.Name.Substring(0, 20) + "..." : _selectedProject.Name);
            lblSelectedProject.ForeColor = Color.Green;
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
