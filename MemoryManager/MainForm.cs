using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            GetStatus();
        }

        private void GetStatus()
        {
            MemoryStatus memoryStatus = new MemoryStatus();

            GlobalMemoryStatus(ref memoryStatus);

            lbDwLength.Text = FormatBytes(memoryStatus.dwLength);
            lbDwMemoryLoad.Text = $"{memoryStatus.dwMemoryLoad}%";
            lbDwTotalPhys.Text = FormatBytes(memoryStatus.dwTotalPhys);
            lbDwAvailPhys.Text = FormatBytes(memoryStatus.dwAvailPhys);
            lbDwTotalPageFile.Text = FormatBytes(memoryStatus.dwTotalPageFile);
            lbDwAvailPageFile.Text = FormatBytes(memoryStatus.dwAvailPageFile);
            lbDwTotalVirtual.Text = FormatBytes(memoryStatus.dwTotalVirtual);
            lbDwAvailVirtual.Text = FormatBytes(memoryStatus.dwAvailVirtual);
        }

        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatus(ref MemoryStatus memoryStatus);

        private void btnUpdate_Click(object sender, EventArgs e) => GetStatus();

        private static string FormatBytes(long bytes)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };

            int i;
            double dblSByte = bytes;

            for (i = 0; i < suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return $"{dblSByte:0.##}{suffix[i]}";
        }
    }
}
