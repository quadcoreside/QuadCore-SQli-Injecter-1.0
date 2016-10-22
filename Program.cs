using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace SQl_SCanner
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLoad());
            //Application.Run(new MainForm());
        }
    }
}
