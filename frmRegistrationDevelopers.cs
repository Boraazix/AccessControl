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

            List<Char> options = new List<Char>();
            options.Add(Convert.ToChar("A"));
            options.Add(Convert.ToChar("B"));
            options.Add(Convert.ToChar("C"));
            options.Add(Convert.ToChar("D"));
            cmbLevel.DataSource = options;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("Developer's name not entered!", "WITHOUT NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtEmail.Text == "")
                MessageBox.Show("Developer's email not entered!", "WITHOUT EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtPassword.Text == "")
                MessageBox.Show("Developer's password not entered!", "WITHOUT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtName.Text.Length > 45)
                MessageBox.Show("The developer's name can be a maximum of 45 characters!", "NAME LARGER THAN MAXIMUM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12)
                MessageBox.Show("The password must be between 8 and 12 characters!", "PASSWORD OUT OF RANGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (DeveloperRepository.FindByEmail(txtEmail.Text) != null)
                MessageBox.Show("This email is already registered!", "EMAIL ALREADY REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    Credential cr = new Credential(txtEmail.Text, txtPassword.Text, chkActive.Checked, chkAdministrator.Checked);
                    Developer dev = new Developer(txtName.Text, dtpBirth.Value.Date, Convert.ToChar(cmbLevel.Text), cr);

                    DeveloperRepository.Save(dev);

                    MessageBox.Show("Developer successfully registered.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnTipLevel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just developers level \"A\" and Administrators can register new developers", "TIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
