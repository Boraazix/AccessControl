
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
    public partial class frmReportProjects : Form
    {
        #region Singleton
        private static frmReportProjects _instance;
        public static frmReportProjects GetInstance()
        {
            List<Project> projects = ProjectRepository.FindAll();
            if (projects.Count>0)
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frmReportProjects();
                _instance.MdiParent = frmMain.ActiveForm;
                _instance.WindowState = FormWindowState.Normal;
                return _instance;
            }
            else
            {
                throw new Exception("There are no projects to show");
            }
        }
        #endregion
        public frmReportProjects()
        {
            InitializeComponent();
            dgvMain.DataSource = ProjectRepository.FindAll();
            dgvMain.Columns[3].HeaderText = "Planned Finish";
            dgvMain.Columns[0].Width = 30;
            dgvMain.Columns[2].Width = 66;
            dgvMain.Columns[3].Width = 84;
            dgvMain.Columns[4].Width = 66;
            dgvMain.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
