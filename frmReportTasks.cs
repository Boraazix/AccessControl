using AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class frmReportTasks : Form
    {
        #region Singleton
        private static frmReportTasks _instance;
        private static Developer _developer;
        private static Project _project;
        public static frmReportTasks GetInstance(Developer dev, Project proj)
        {
            _developer= dev;
            _project= proj;
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmReportTasks();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        #endregion
        public frmReportTasks()
        {
            InitializeComponent();

            if (_developer != null && _project != null)
            {
                if(AllocationRepository.FindByDeveloperAndProject(_developer, _project)!=null)
                {
                    dgvMain.DataSource = AllocationRepository.FindByDeveloperAndProject(_developer, _project).Tasks;
                }
                else
                {
                    throw new Exception("This Developer was not allocated in this Project!");
                }
            }
            else if (_developer != null)
            {
                List<Task> tasks = new List<Task>();
                foreach (Allocation al in AllocationRepository.FindAllocationByDeveloper(_developer))
                    foreach(Task task in al.Tasks)
                        tasks.Add(task);
                dgvMain.DataSource = tasks;
            }
            else
            {
                List<Task> tasks = new List<Task>();
                foreach (Allocation al in AllocationRepository.FindAllocationByProject(_project))
                {
                    foreach (Task task in al.Tasks)
                    {
                        tasks.Add(task);
                    }
                }
                dgvMain.DataSource = tasks;
            }

            dgvMain.Columns[0].Width = 30;
            dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
