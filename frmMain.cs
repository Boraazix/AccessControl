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
    public partial class frmMain : Form
    {
        #region Singleton
        private static frmMain _instance;
        public static frmMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmMain();
            return _instance;
        }
        #endregion
        public frmMain()
        {
            InitializeComponent();
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

        }

        private void mnuProjects_Click(object sender, EventArgs e)
        {

        }
    }
}
