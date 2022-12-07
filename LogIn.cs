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
    public partial class LogIn : Form
    {
        #region Singleton
        private static LogIn _instance;
        public static LogIn GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new LogIn();
            return _instance;
        }
        #endregion
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnAuthentic_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
                MessageBox.Show("Usuário não inserido!");
            else if (txtPassword.Text == "")
                MessageBox.Show("Senha não inserida!");
            else if (UserRepository.FindByEmailAndPassword(txtEmail.Text, txtPassword.Text)!=null)
            {
                MessageBox.Show("Autenticado!");
            }
            else
                MessageBox.Show("Incorreto :/");
            Console.WriteLine(Credential.ComputeSHA256(Credential.ComputeSHA256(txtPassword.Text, Credential.SALT)));
        }

    }
}
