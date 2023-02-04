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
    public partial class frmLogIn : Form
    {
        #region Singleton
        private static frmLogIn _instance;
        public static frmLogIn GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmLogIn();
            return _instance;
        }
        #endregion
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void Authentic()
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }
                else if (CredentialRepository.ValidateDev(txtEmail.Text, txtPassword.Text))
                {
                    MessageBox.Show($"Welcome {frmMain.DeveloperLogged.Name}!", "LOG-IN CORRECT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.GetInstance().Show();
                    txtEmail.Focus();
                    this.Hide();
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(ex.Message== "This password is incorrect, please try again")
                {
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
                else if (ex.Message == "This email is incorrect, please try again")
                {
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
        }

        private void btnAuthentic_Click(object sender, EventArgs e)
        {
            Authentic();
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                Authentic();
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
                txtPassword.PasswordChar ='\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
