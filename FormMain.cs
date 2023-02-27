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
    public partial class FormMain : Form
    {
        #region Singleton
        private static FormMain _instance;
        public static FormMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormMain();
            _instance.WindowState= FormWindowState.Maximized;
            return _instance;
        }
        private FormMain()
        {
            InitializeComponent();
            if (DeveloperLogged.Credential.Administrator
                || DeveloperLogged.LevelMemory == 'A')
            {
                mnuRegistration.Enabled = true;
            }
            else
            {
                mnuRegistration.Enabled = false;
            }
        }
        #endregion
        public static Developer DeveloperLogged { get; set; }
        #region Clicks
        private void mnuBack_Click(Object sender, EventArgs e)
        {
            FormLogIn.GetInstance().Show();
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            FormAbout.GetInstance().Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogIn.GetInstance().Show();
        }

        private void mnuDevelopers_Click(object sender, EventArgs e)
        {
            FormRegistrationDevelopers.GetInstance().Show();
        }

        private void mnuProjects_Click(object sender, EventArgs e)
        {
            FormRegistrationProjects.GetInstance().Show();
        }

        private void allocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mnuReportDevelopers_Click(object sender, EventArgs e)
        {
            FormReportDevelopers.GetInstance().Show();
        }

        private void mnuReportProjects_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportProjects.GetInstance().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuRegistrationAllocations_Click(object sender, EventArgs e)
        {
            FormRegistrationAllocations.GetInstance().Show();
        }

        private void mnuRegistrationTasks_Click(object sender, EventArgs e)
        {
            FormRegistrationTasks.GetInstance().Show();
        }

        private void mnuReportTasks_Click(object sender, EventArgs e)
        {
            FormReportTasksByDeveloperProject.GetInstance().Show();
        }
#endregion

    }
}
