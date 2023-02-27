using Org.BouncyCastle.Crypto.Macs;
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
    public partial class FormAbout : Form
    {
        #region Singleton
        private static FormAbout _instance;
        public static FormAbout GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormAbout();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormAbout()
        {
            InitializeComponent();
        }
        #endregion

        private void lklblKumon_LinkCLicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lklblKumon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.kumon.com.br/");
        }

        private void lklblInternews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lklblKumon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.internewssistemas.com.br/");
        }

        private void lklblIFNMG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lklblKumon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.ifnmg.edu.br/");
        }

        private void pcbGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto: russell.ed.123@gmail.com");
        }

        private void pcbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Boraazix");
        }

        private void pcbLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/russell-edward-356379228");
        }

        private void pcbGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Boraazix");
        }
    }
}
