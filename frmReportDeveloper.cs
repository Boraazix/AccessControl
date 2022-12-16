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
    public partial class frmReportDeveloper : Form
    {
        #region Singleton
        private static frmReportDeveloper _instance;
        public static frmReportDeveloper GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmReportDeveloper();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        #endregion
        public frmReportDeveloper()
        {
            InitializeComponent();
            dgvMain.DataSource = DeveloperRepository.FindAll();
            dgvMain.Columns[3].HeaderText = "Birth date";
            dgvMain.Columns[4].HeaderText = "Level";
            dgvMain.Columns[5].Visible = false;
            dgvMain.Columns[6].Visible = false;
            dgvMain.Columns[0].Width = 30;
            dgvMain.Columns[3].Width = 66;
            dgvMain.Columns[4].Width = 43;
            dgvMain.Columns[7].Width = 45;
            dgvMain.Columns[8].Width = 75;
            dgvMain.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
