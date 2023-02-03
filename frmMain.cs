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
    public partial class frmMain : Form
    {
        #region Singleton
        private static frmMain _instance;
        public static frmMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmMain();
            _instance.WindowState= FormWindowState.Maximized;
            return _instance;
        }
        #endregion
        public static Developer DeveloperLogged { get; set; }
        public frmMain()
        {
            InitializeComponent();
            DeveloperLogged = DeveloperRepository.FindByIdWCredencial(1);
            if (DeveloperLogged.Credential.Administrator 
                || DeveloperLogged.LevelMemory==Convert.ToChar("A"))
            {
                mnuRegistration.Enabled = true;
            }
            else
            {
                mnuRegistration.Enabled = false;
            }
        }
        private void mnuBack_Click(Object sender, EventArgs e)
        {
            frmLogIn.GetInstance().Show();
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout.GetInstance().Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogIn.GetInstance().Show();
        }

        private void mnuDevelopers_Click(object sender, EventArgs e)
        {
            frmRegistrationDevelopers.GetInstance().Show();
        }

        private void mnuProjects_Click(object sender, EventArgs e)
        {
            frmRegistrationProjects.GetInstance().Show();
        }

        private void allocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mnuReportDevelopers_Click(object sender, EventArgs e)
        {
            frmReportDeveloper.GetInstance().Show();
        }

        private void mnuReportProjects_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportProject.GetInstance().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuRegistrationAllocations_Click(object sender, EventArgs e)
        {
            frmRegistrationAllocations.GetInstance().Show();
        }

        private void mnuRegistrationTasks_Click(object sender, EventArgs e)
        {
            frmRegistrationTasks.GetInstance().Show();
        }
    }
}
