using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Priorprocess() != null)
            {
                MessageBox.Show("Application is already running..");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
        public static Process Priorprocess()
        {
            Process current = Process.GetCurrentProcess();
            Process[] process = Process.GetProcessesByName(current.ProcessName);
            foreach (Process p in process)
            {
                if ((p.Id != current.Id) && (p.MainModule.FileName == current.MainModule.FileName))
                    return p;
            }
            return null;
        }
    }
}
