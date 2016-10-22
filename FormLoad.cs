using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }
        MainForm form_main;
        private void FormLoad_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            progressBar1.Value = 50;
            progressBar1.Style = ProgressBarStyle.Blocks;
            txt_output.Text = "Chargement de vos données...";
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            Thread.Sleep(66);
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    form_main = new MainForm();
                    form_main.Hide();
                    form_main.remetDonne(); //http://dotnetcodr.com/2014/01/01/5-ways-to-start-a-task-in-net-c/
                    form_main.setIP();
                    form_main.UpInfos();
                    form_main.Refresh();
                });
                return;
            }
            
            backgroundWorker1.ReportProgress(100);
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            form_main.Show();
        }



    }
}
