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

namespace ControleAcesso
{
    public partial class frmReportTask : Form
    {
        #region Singleton
        private static frmReportTask _instance;
        public static frmReportTask GetInstance()
        {
            /*
            if (task.Count > 0)
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frmReportTask();
                _instance.MdiParent = frmMain.ActiveForm;
                _instance.WindowState = FormWindowState.Normal;
                return _instance;
            }
            else
            {
                throw new Exception("There are no projects to show");
            }
            */
            return null;
        }
        #endregion
        public frmReportTask()
        {
            InitializeComponent();
        }
    }
}
