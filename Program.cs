using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Credential c = new Credential();
            User u = new User();
            u.Name = "Jacinto";
            c.Email = "russell.ed.123@gmail.com";
            c.Password = "70873";
            u.Credential = c;
            UserRepository.Save(u);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
