using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class ScannePort
    {
        private MainForm form = GlobalVar.form;
        public void Scanne(string url)
        {
            string hote = url.Split('/')[2];
            string ip = avoirip(hote);
            if (Verfier(ip, hote))
            {
                string ssh = Test_Port(ip, 22).ToString();
                string rdp = Test_Port(ip, 3389).ToString();
                string ftp = Test_Port(ip, 21).ToString();
                string vnc = Test_Port(ip, 5900).ToString();
                string date = DateTime.Now.ToString();

                if (ssh == "True" || rdp == "True" ||  ftp == "True" || vnc == "True")
                {
                    string[] groupe = { hote, ip, ssh, rdp, ftp, vnc, date };
                    form.list_scanne_port.Invoke((MethodInvoker)(() =>
                    {
                        if (!existDeja(groupe[0], form.list_scanne_port))
                        {
                            form.list_scanne_port.BeginUpdate();
                            form.list_scanne_port.Items.Add(new ListViewItem(groupe));
                            form.list_scanne_port.EndUpdate();
                        }                  
                    }));
                }
            }
        }

        private bool existDeja(string str, ListView lv)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.SubItems[0].Text == str)
                {
                    return true;
                }
            }
            return false;
        }
        public bool TestPortTry(string ip)
        {
            IPAddress ipa = IPAddress.Parse(ip);
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ipa, 3389);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string avoirip(string hote)
        {
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
        private bool Verfier(string ip, string hote)
        {
            if ((ip.Contains('.')) && (!form.HashIP.Contains(ip)))
            {
                form.HashIP.Add((ip), hote);
                return true;
            }
            else { return false; }
        }

        private bool Test_Port(string ipString, int port)
        {
            IPAddress ip = IPAddress.Parse(ipString);
            bool test = false;
            if (ipString.Contains("."))
	        {
		        try
                {
                    if(ipString.Contains("."))
                    {
                        System.Net.Sockets.Socket s = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        s.Connect(ip, port);
                        if (s.Connected == true)
                        {
                            test = true;
                            s.Close();
                        }
                    }
                }
                catch (SocketException)
                {
                    test = false;
                }
            }
            return test;

        }
    }
}
