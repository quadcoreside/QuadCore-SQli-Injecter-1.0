using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner.Scanne
{
    class ScanneAnalyse
    {
        private MainForm form = GlobalVar.form;
        private Sqli_analyse analyse;
        private sql_inject inject;
        private Outils outille;

        public void Scanne(string url)
        {
            analyse = new Sqli_analyse();
            inject = new sql_inject();
            outille = new Outils();
            List<string> extras = new List<string> { };

            SuprimerDansVulne(url);
            string url_point = analyse.Analyse(url);
            string ip = outille.avoirip(url);
            string[] info = inject.getInfos(url_point);
            string load_file = inject.checkLoadFile(url_point).ToString();
            string extraFinale = "N/A";
            try
            {
                if (load_file == "True")
                {
                    extras.Add("");
                }
                if (info[0].Contains("root"))
                {
                    extras.Add("Root User");
                }
                extraFinale = string.Join("; ", extras);
            } catch (Exception) { }
            if (info.Length > 1)
            {

                string[] groupe = { url_point, info[0], info[1], ip, DateTime.Now.ToString(), extraFinale };

                if (url_point == "False")
                {
                    form.list_non_vulne.Invoke((MethodInvoker)(() =>
                    {
                        form.list_non_vulne.BeginUpdate();
                        form.list_non_vulne.Items.Add(new ListViewItem(groupe, 1));
                        form.list_non_vulne.EndUpdate();
                    }));
                }
                else
                {
                    form.list_injectables.Invoke((MethodInvoker)(() =>
                    {
                        form.list_url.BeginUpdate();
                        form.list_injectables.Items.Add(new ListViewItem(groupe));
                        form.list_url.EndUpdate();
                    }));
                }
            }
        }
        private void SuprimerDansVulne(string url)
        {
            form.list_vulne.Invoke((MethodInvoker)(() =>
            {
                form.list_vulne.BeginUpdate();
                for (int i = 0; i < form.list_vulne.Items.Count; i++)
                {
                    if (form.list_vulne.Items[i].SubItems[0].Text == url)
                    {
                        form.list_vulne.Items[i].Remove();
                        break;
                    }
                }
                form.list_vulne.EndUpdate();
            }));
            form.UpInfos();
        }
    }
}
