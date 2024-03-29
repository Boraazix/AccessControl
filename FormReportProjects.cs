﻿
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
    public partial class FormReportProjects : Form
    {
        #region Singleton
        private static FormReportProjects _instance;
        public static FormReportProjects GetInstance()
        {
            List<Project> projects = ProjectRepository.FindAll();
            if (projects.Count>0)
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormReportProjects();
                _instance.MdiParent = FormMain.ActiveForm;
                _instance.WindowState = FormWindowState.Normal;
                return _instance;
            }
            else
            {
                throw new Exception("There are no projects to show");
            }
        }
        private FormReportProjects()
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
        #endregion
    }
}
