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
    public partial class frmRegistrationDevelopers : Form
    {
        #region Singleton
        private static frmRegistrationDevelopers _instance;
        public static frmRegistrationDevelopers GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmRegistrationDevelopers();
            return _instance;
        }
        #endregion
        public frmRegistrationDevelopers()
        {
            InitializeComponent();
            cmbLevel.DataSource = ("A", "B", "C", "D");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (Repository repository = new Repository())
            {
                foreach (Developer deve in repository.Developers)
                    if (txtEmail.Text == deve.Credential.Email)
                    {
                        MessageBox.Show("This Email is already registered!", "EMAIL ALREADY REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                Credential cr = new Credential(txtEmail.Text, txtPassword.Text, chkActive.Checked, chkAdministrator.Checked);
                Developer dev = new Developer(txtName.Text, dtpBirth.Value, Convert.ToChar(cmbLevel.Text), cr);

                DeveloperRepository.Save(dev);
            }
        }
    }
}
