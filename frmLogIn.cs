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

        private void btnAuthentic_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
                MessageBox.Show("Email not entered!", "WITHOUT EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtPassword.Text == "")
                MessageBox.Show("Password not entered!", "WITHOUT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Credential.ValidateDev(txtEmail.Text, txtPassword.Text))
            {
                frmMain.GetInstance().Show();
                this.Hide();
                //MessageBox.Show("Authenticated!", "LOG-IN CORRECT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
