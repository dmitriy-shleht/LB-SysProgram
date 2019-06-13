using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public static Process[] process = Process.GetProcesses();
        private Proc current;

        public TaskManager()
        {
            InitializeComponent();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            var query = new SelectQuery("select * from Win32_Process");
            ManagementScope scope = new System.Management.ManagementScope(@"\\.\root\CIMV2");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection processes = searcher.Get();

            List<Proc> proc = new List<Proc>();

            foreach (var item in processes)
            {
                proc.Add(new Proc(item));
            }

            dgTaskManager.DataSource = proc;
        }

        private void btnNewProc_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var proc = new ProcessStartInfo(dialog.FileName);
                proc.WorkingDirectory = Path.GetDirectoryName(dialog.FileName);
                Process.Start(proc);
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            current = dgTaskManager.SelectedRows?[0].DataBoundItem as Proc;

            Process.GetProcessById(current.Pid).Kill();
        }

        private void dgTaskManager_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                current = dgTaskManager.SelectedRows?[0].DataBoundItem as Proc;

                var p = Process.GetProcessById(current.Pid);

                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add("Нормальный", (s, ev) => { p.PriorityClass = ProcessPriorityClass.Normal; });
                contextMenu.MenuItems.Add("Высокий", (s, ev) => { p.PriorityClass = ProcessPriorityClass.High; });
                contextMenu.MenuItems.Add("Реального времени", (s, ev) => { p.PriorityClass = ProcessPriorityClass.RealTime; });

                contextMenu.Show(dgTaskManager, new Point(e.X, e.Y));
            }
        }
    }
}