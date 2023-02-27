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
    public partial class FormReportDevelopers : Form
    {
        #region Singleton
        private static FormReportDevelopers _instance;
        public static FormReportDevelopers GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormReportDevelopers();
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        private FormReportDevelopers()
        {
            InitializeComponent();
            dgvMain.DataSource = DeveloperRepository.FindAllWCredential();
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
        #endregion
    }
}
