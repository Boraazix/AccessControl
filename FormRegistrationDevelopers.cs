using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AccessControl
{
    public partial class FormRegistrationDevelopers : Form
    {
        #region Singleton
        private static FormRegistrationDevelopers _instance;
        public static FormRegistrationDevelopers GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormRegistrationDevelopers();
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormRegistrationDevelopers()
        {
            InitializeComponent();

            List<Char> options = new List<Char> { 'A', 'B', 'C', 'D' };
            cmbLevel.DataSource = options;
            btnSaveChanges.Enabled = false;
            try
            {
                lstDevelopers.DataSource = DeveloperRepository.FindAllWCredential();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        private void ClearFields()
        {
            txtName.Text = ""; dtpBirth.Value = DateTime.Now; txtRepeatedPassword.Text = "";
            txtEmail.Text = ""; txtPassword.Text = "";  cmbLevel.SelectedIndex = 0;
            chkActive.Checked = true; chkAdministrator.Checked = false;
            txtName.Focus();
        }
        private void lstDeveloper_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstDevelopers.IndexFromPoint(e.Location);
            if (index >= 0 && index < lstDevelopers.Items.Count)
            {
                string itemText = ((Developer)lstDevelopers.Items[index]).Name;
                ttMain.SetToolTip(lstDevelopers, itemText);
            }
            else
            {
                ttMain.SetToolTip(lstDevelopers, string.Empty);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Developer name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Developer email not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }
                else if (txtRepeatedPassword.Text == "")
                {
                    MessageBox.Show("Repeat the Password!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRepeatedPassword.Focus();
                }
                else if (DeveloperRepository.FindByEmailWCredential(txtEmail.Text) != null)
                {
                    MessageBox.Show("This email is already registered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
                else if (txtPassword.Text != txtRepeatedPassword.Text)
                {
                    MessageBox.Show("The entered passwords are different!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRepeatedPassword.Focus();
                }
                else
                {
                    Credential cr = new Credential(txtEmail.Text, txtPassword.Text, chkActive.Checked, chkAdministrator.Checked);
                    Developer dev = new Developer(txtName.Text, dtpBirth.Value.Date, Convert.ToChar(cmbLevel.Text), cr);

                    DeveloperRepository.Save(dev);
                    lstDevelopers.DataSource = DeveloperRepository.FindAllWCredential();

                    MessageBox.Show("Developer successfully registered.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTipLevel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just developers level \"A\" and Administrators can make registrations", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "New", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Developer dev = (Developer)lstDevelopers.SelectedItem;

            txtName.Text = dev.Name; 
            dtpBirth.Value = dev.Birth;
            txtEmail.Text = dev.Credential.Email; 
            txtPassword.Text = "";
            cmbLevel.SelectedItem = dev.LevelMemory; 
            chkActive.Checked = dev.Credential.Active;
            chkAdministrator.Checked = dev.Credential.Administrator; 

            btnRegister.Enabled = false;
            lstDevelopers.Enabled = false; 
            btnDeleteDeveloper.Enabled = false;
            txtPassword.Enabled= false; 
            btnEditDeveloper.Enabled = false;
            btnChangePassword.Enabled = false;
            btnSaveChanges.Enabled = true;
            txtRepeatedPassword.Enabled = false;

            txtName.Focus();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Developer dev = (Developer)lstDevelopers.SelectedItem;
            try
            {
                // if is editing
                if (!txtPassword.Enabled)
                {
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtName.Focus();
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Email not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Focus();
                    }
                    else if (dev.Credential.Email != txtEmail.Text && DeveloperRepository.FindByEmailWCredential(txtEmail.Text) != null)
                    {
                        MessageBox.Show("This email is from another developer!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Focus();
                        txtEmail.SelectAll();
                    }
                    else
                    {
                        dev.Credential.Email = txtEmail.Text; dev.Credential.Active = chkActive.Checked;
                        dev.Credential.Administrator = chkAdministrator.Checked;

                        dev.Name = txtName.Text; dev.Birth = dtpBirth.Value.Date;
                        dev.LevelMemory = Convert.ToChar(cmbLevel.Text);

                        DeveloperRepository.Save(dev);

                        lstDevelopers.DataSource = DeveloperRepository.FindAllWCredential();

                        MessageBox.Show("Developer Successfully updated.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();

                        txtPassword.Enabled = true; lstDevelopers.Enabled = true;
                        btnRegister.Enabled = true; btnDeleteDeveloper.Enabled = true;
                        btnEditDeveloper.Enabled = true; btnChangePassword.Enabled = true;
                        btnSaveChanges.Enabled = false; txtRepeatedPassword.Enabled = true;
                    }
                }
                // if is changing password
                else
                {
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Password not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPassword.Focus();
                    }
                    else
                    {
                        dev.Credential.Password = txtPassword.Text;
                        DeveloperRepository.Save(dev);
                        MessageBox.Show("Password Successfully updated.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();

                        txtName.Enabled = true; dtpBirth.Enabled = true; txtEmail.Enabled = true;
                        cmbLevel.Enabled = true; btnTipLevel.Enabled = true; chkActive.Enabled = true;
                        chkAdministrator.Enabled = true; lstDevelopers.Enabled = true;
                        btnEditDeveloper.Enabled = true; btnDeleteDeveloper.Enabled = true;
                        btnChangePassword.Enabled = true; btnRegister.Enabled = true;
                        btnSaveChanges.Enabled = false;
                    }

                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Developer dev = (Developer)lstDevelopers.SelectedItem;

            txtName.Text = dev.Name;
            dtpBirth.Value = dev.Birth;
            txtEmail.Text = dev.Credential.Email;
            txtPassword.Text = "";
            cmbLevel.SelectedItem = dev.LevelMemory;
            chkActive.Checked = dev.Credential.Active;
            chkAdministrator.Checked = dev.Credential.Administrator;


            txtName.Enabled= false; dtpBirth.Enabled= false; txtEmail.Enabled= false;
            cmbLevel.Enabled=false; btnTipLevel.Enabled=false; chkActive.Enabled=false;
            chkAdministrator.Enabled=false; lstDevelopers.Enabled = false; 
            btnEditDeveloper.Enabled= false; btnDeleteDeveloper.Enabled= false;
            btnChangePassword.Enabled= false; btnRegister.Enabled= false;
            btnSaveChanges.Enabled = true;
        }
    }
}
