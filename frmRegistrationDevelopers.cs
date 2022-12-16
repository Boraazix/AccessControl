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
    public partial class frmRegistrationDevelopers : Form
    {
        #region Singleton
        private static frmRegistrationDevelopers _instance;
        public static frmRegistrationDevelopers GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmRegistrationDevelopers();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        #endregion
        public frmRegistrationDevelopers()
        {
            InitializeComponent();

            List<Char> options = new List<Char>
            {
                Convert.ToChar("A"),
                Convert.ToChar("B"),
                Convert.ToChar("C"),
                Convert.ToChar("D")
            };
            cmbLevel.DataSource = options;
            btnSaveChanges.Enabled = false;
            try
            {
                lstDevelopers.DataSource = DeveloperRepository.FindAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ClearFields()
        {
            txtName.Text = ""; dtpBirth.Value = DateTime.Now;
            txtEmail.Text = ""; txtPassword.Text = "";  cmbLevel.SelectedIndex = 0;
            chkActive.Checked = true; chkAdministrator.Checked = false;
            txtName.Focus();
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
                else if (DeveloperRepository.FindByEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("This email is already registered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
                else
                {
                    Credential cr = new Credential(txtEmail.Text, txtPassword.Text, chkActive.Checked, chkAdministrator.Checked);
                    Developer dev = new Developer(txtName.Text, dtpBirth.Value.Date, Convert.ToChar(cmbLevel.Text), cr);

                    DeveloperRepository.Save(dev);
                    lstDevelopers.DataSource = DeveloperRepository.FindAll();

                    MessageBox.Show("Developer successfully registered.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            MessageBox.Show("Just developers level \"A\" and Administrators can make registrations", "TIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...", "NEW", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            txtName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Developer dev = (Developer)lstDevelopers.SelectedItem;
            try
            {
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
                    else if (dev.Credential.Email != txtEmail.Text && DeveloperRepository.FindByEmail(txtEmail.Text) != null)
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

                        lstDevelopers.DataSource = DeveloperRepository.FindAll();

                        MessageBox.Show("Developer successfully updated.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();

                        txtPassword.Enabled = true; lstDevelopers.Enabled = true;
                        btnRegister.Enabled = true; btnDeleteDeveloper.Enabled = true;
                        btnEditDeveloper.Enabled = true; btnChangePassword.Enabled = true;
                        btnSaveChanges.Enabled = false;
                    }
                }
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
                        MessageBox.Show("Password successfully updated.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
