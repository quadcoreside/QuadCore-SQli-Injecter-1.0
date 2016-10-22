using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;

namespace Web_faille_scanner
{
    public class Fonctions
    {
        private Form1 FormPrincipale;
        private const string useragent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.1.2) Gecko/20090729 Firefox/3.5.2 (.NET CLR 3.5.30729)";
        public Fonctions(Form1 Form1)
        {
            FormPrincipale = Form1;
        }

        public async void RechecheToutMoteur(string dork,string page)
        {
            int comter;
            int comterBing = 0;
            String lignefinale = "";
            String leer = "";
            string maxcalcul = page + 0;
            int max = Convert.ToInt16(maxcalcul);
            int pagenum = 0;
            HttpClient client = new HttpClient();

            for (comter = 0; comter <= max; comter += 10)
            {
                client.DefaultRequestHeaders.Add("User-Agent", useragent);
                string url = "http://www.google.com/search?q=" + dork + "&start=" + pagenum;
                string pagecode = "";
                bool requestOK = false;
                int ressayecomter = 0;

               // while ((requestOK == false) && ressayecomter <= 3)
                //{
                  //  try
                    //{
                        ressayecomter++;
                        Task<string> getStringTaskGoogle = client.GetStringAsync(url);
                        pagecode = await getStringTaskGoogle; pagenum += 10;
                    //} catch (Exception){} 
               // }

                if (requestOK)
                {
                    Match regex = Regex.Match(pagecode, "(?<=\"r\"><. href=\")(.+?)\"", RegexOptions.IgnoreCase);
                    while (regex.Success)
                    {
                        leer = Uri.UnescapeDataString(regex.Groups[1].Value);
                        Match trouver = Regex.Match(leer, @"\/url\?q\=(.*?)\&amp\;", RegexOptions.IgnoreCase);
                        if (trouver.Success)
                        {
                            lignefinale = trouver.Groups[1].Value;
                        }
                        else
                        {
                            lignefinale = leer;
                        }
                        if (Verfier(lignefinale))
                        {
                            if (Verfier(lignefinale))
                            {
                                FormPrincipale.list_url.Invoke((MethodInvoker)(() =>
                                {
                                    FormPrincipale.list_url.Items.Add(lignefinale);
                                }));
                            }
                        }
                        regex = regex.NextMatch();
                        Thread.Sleep(100);
                    } 
                }
                //************************************BING***************************************************
                String url_couper = "";
                String url_finale = "";
                client.DefaultRequestHeaders.Add("User-Agent", useragent);
                string adressebing = "http://bing.com/search?q=" + dork + "&first=" + comterBing;
                Task<string> getStringTaskBing = client.GetStringAsync(adressebing);
                String pagecodebing;
                requestOK = false;
                ressayecomter = 0;

               /* while (requestOK == false && ressayecomter < 5)
                {
                    try
                    {*/
                        ressayecomter++;
                        Task<string> getStringTask = client.GetStringAsync(url);
                        pagecodebing = await getStringTaskBing;
                        requestOK = true;
                    /*}
                    catch (Exception) { requestOK = false; }
                }*/

                if (requestOK)
                {
                    comterBing++;
                    Match regex1 = Regex.Match(pagecode, "<h3><a href=\"(.*?)\"", RegexOptions.IgnoreCase);
                    while (regex1.Success)
                    {
                        url_couper = regex1.Groups[1].Value;
                        Match regex2 = Regex.Match(url_couper, "(.*?)=(.*?)", RegexOptions.IgnoreCase);
                        if (regex2.Success)
                        {
                            url_finale = regex2.Groups[1].Value + "=";
                            if (Verfier(url_finale))
                            {
                                FormPrincipale.list_url.Invoke((MethodInvoker)(() =>
                                {
                                    FormPrincipale.list_url.Items.Add(url_finale);
                                })); 
                            }
                        }
                        regex1 = regex1.NextMatch();
                    } 
                }
                
                if(requestOK == false)
	            {
                    FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                    {
                        FormPrincipale.fait_txt.Text = "[+] Erreur.";
                    }));
	            }
                else
                {
                    FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                    {
                        FormPrincipale.fait_txt.Text = "[+] Recherche Terminé.";
                        FormPrincipale.list_url.Refresh();
                        FormPrincipale.Refresh();
                    }));
                }
            }
        }
        public async void BingRecherche(string[] dorkArray, string maxpage)
        {
            String url_couper = "";
            String url_finale = "";
            int max = Convert.ToInt32(maxpage);
            int comter;
            bool requestOK = false;
            int ressayecomter = 0;
            HttpClient client = new HttpClient();
            int nbrdork = ComteDansArray(dorkArray);

            for (int i = 0; i < nbrdork; i++)//Pour Dork
            {
                for (comter = 0; comter < max; comter++)//Pour Page a faire
                {
                    client.DefaultRequestHeaders.Add("User-Agent", useragent);
                    string url = "http://bing.com/search?q=" + HttpUtility.UrlEncode(dorkArray[i]) + "&first=" + comter;
                    string pagecode = "";

                  /*  while ((requestOK == false) && ressayecomter <= 5)
                    {
                        try
                        {*/
                            ressayecomter++;
                            Task<string> getStringTask = client.GetStringAsync(url);
                            pagecode = await getStringTask;
                            requestOK = true;
                            //MessageBox.Show(requestOK.ToString() + Environment.NewLine + "Bing ressaye comteur: " + ressayecomter);
                       /* }
                        catch (Exception e) { requestOK = false;  MessageBox.Show(e.ToString()); Thread.Sleep(666); }
                    } */

                    if (pagecode != "")
                    {
                        Match regex1 = Regex.Match(pagecode, "<h2><a href=\"(.*?)\"", RegexOptions.IgnoreCase);
                        while (regex1.Success)
                        {
                            url_couper = regex1.Groups[1].Value;
                            Match regex2 = Regex.Match(url_couper, "(.*?)=(.*?)", RegexOptions.IgnoreCase);
                            if (regex2.Success)
                            {
                                url_finale = regex2.Groups[1].Value + "=";

                                if(Verfier(url_finale))
                                {
                                    FormPrincipale.list_url.Invoke((MethodInvoker)(() =>
                                    {
                                        FormPrincipale.list_url.Items.Add(url_finale);
                                    }));
                                }
                                else { dupliqueComteur++; }
                            }
                            regex1 = regex1.NextMatch();
                        }
                        requestOK = false;
                        ressayecomter = 0;
                    }
                } 
            }

                if (requestOK)
                {
                    FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                    {
                        FormPrincipale.fait_txt.Text = "[+] Recherche Bing terminer correctement";
                        FormPrincipale.Refresh();
                    })); 
                }
                else
                {
                    FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                    {
                        FormPrincipale.fait_txt.Text = "[+] Erreur bing recherche.";
                        FormPrincipale.Refresh();
                    })); 
                }
            
        }
        public async void GoogleRecherche(string[] DorkArray, string maxpage)
        {
            int comter;
            String lignefinale = "";
            String leer = "";
            string maxcalcul = maxpage + 0;
            int max = Convert.ToInt16(maxcalcul);
            string pagecode = "";
            bool requestOK = false;
            int ressayecomter = 0;
            HttpClient client = new HttpClient();

            int nbrdork = ComteDansArray(DorkArray);

            for (int i = 0; i < nbrdork; i++)
            {
                for (comter = 0; comter < max; comter += 10)
                {
                    client.DefaultRequestHeaders.Add("User-Agent", useragent);

                    string url = "http://www.google.com/search?q=" + HttpUtility.UrlEncode(DorkArray[i]) + "&start=" + comter; 

                    while ((requestOK == false) && ressayecomter <= 5)
                    {
                        try
                        {
                            ressayecomter++;
                            Task<string> getStringTask = client.GetStringAsync(url);
                            pagecode = await getStringTask;
                            requestOK = true;
                        }
                        catch (Exception e) { requestOK = false; /*MessageBox.Show(e.ToString());*/ }
                    }

                    if (pagecode != "")
                    {
                        Match regex = Regex.Match(pagecode, "(?<=\"r\"><. href=\")(.+?)\"", RegexOptions.IgnoreCase);
                        while (regex.Success)
                        {
                            leer = Uri.UnescapeDataString(regex.Groups[1].Value);
                            Match trouver = Regex.Match(leer, @"\/url\?q\=(.*?)\&amp\;", RegexOptions.IgnoreCase);
                            if (trouver.Success)
                            {
                                lignefinale = trouver.Groups[1].Value;
                            }
                            else
                            {
                                lignefinale = leer;
                            }
                            if (Verfier(lignefinale))
                            {
                                FormPrincipale.list_url.Invoke((MethodInvoker)(() =>
                                {
                                    FormPrincipale.list_url.Items.Add(lignefinale);
                                }));
                            }
                            else { dupliqueComteur++; }
                            regex = regex.NextMatch();
                        }
                    }
                    requestOK = false;
                    ressayecomter = 0;
                    MajInfos();
                }
            }
            if (FormPrincipale.list_url.Items.Count > 0)
            {
                FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                {
                    FormPrincipale.fait_txt.Text = "[+] Recherche Google terminer";
                    FormPrincipale.Refresh();
                }));
            }
            else
            {
                FormPrincipale.statusStrip1.Invoke((MethodInvoker)(() =>
                {
                    FormPrincipale.fait_txt.Text = "[+] Recherche Erreur Aucun trouvé";
                    FormPrincipale.Refresh();
                }));
            }

        }

        private bool Verfier(string url)
        {
            bool ok = true;
            if ((!Filtre(url)) && (url.Contains("?")))
            {
                FormPrincipale.list_url.Invoke((MethodInvoker)(() =>
                    {
                        for (int i = 0; i < FormPrincipale.list_url.Items.Count; i++)
                        {
                            if (FormPrincipale.list_url.Items[i].SubItems[0].Text.Contains(getNomDomaine(url)))
                            {
                                ok = false;
                                break;
                            }
                        }
                    })); 
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        public string[] black =  
        {
            "google",
            "youtube",
            "facebook"
        };
        private bool Filtre(string url)
        {
            foreach (string index in black)
            {
                if(url.Contains(index))
                {
                    return true;
                }
            }
            return false;
        }
        private string getNomDomaine(string url)
        {
            string[] mrc = url.Split('/');
            url = mrc[2];
            url =  url.Replace("/", "");
            return url;
        }

        private int ComteDansArray(string[] dorkArray)
        {
            int nombre = 0;
            foreach(string element in dorkArray)
            {
                nombre++;
            }
            return nombre;
        }
 
        public int dupliqueComteur = 0;
        /*
        private string useragent()
        {
            string[] ua = {"Mozilla/5.0 (X11; Linux i686) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.52 Safari/536.5",
                        "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.8.1.11) Gecko/20071127 Firefox/2.0.0.11",
                        "Mozilla/5.0 (Windows NT 6.1; rv:33.0) Gecko/20100101 Firefox/33.0",
                        "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)",
                        "Mozilla/5.0 (compatible; Konqueror/3.5; Linux) KHTML/3.5.5 (like Gecko) (Kubuntu)",
                        "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.0.12) Gecko/20070731 Ubuntu/dapper-security Firefox/1.5.0.12",
                        "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en) AppleWebKit/534.1+ (KHTML, like Gecko)",
                        "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 8.0",
                        "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.8.1.6) Gecko/20070725 Firefox/2.0.0.6",
                        "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Ubuntu/10.10 Chromium/8.0.552.237",
                        "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.7 (KHTML, like Gecko) Ubuntu/11.10 Chromium/16.0.912.21",
                        "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.1.2) Gecko/20090729 Firefox/3.5.2 (.NET CLR 3.5.30729)",
                        "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.2 (KHTML, like Gecko) Ubuntu/11.04 Chromium/15.0.871.0 ",
                        "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20",
                        "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.45 Safari/535.19",
                        "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.93 Safari/537.36",
                        "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.1 (KHTML, like Gecko) Comodo_Dragon/14.0.1.0 Chrome/14.0.835.163 Safari/535.1",
                        "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.105 CoRom/30.0.1599.105 Safari/537.36",
                        "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36",
                        "Mozilla/5.0 (IE 11.0; Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko",
                        "Mozilla/5.0 (Linux; U; Android 4.2; en-us; Nexus 10 Build/JVP15I) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Safari/534.30",
                        "Mozilla/5.0 (Linux; U; Android 2.3.4; en-US; MT11i Build/4.0.2.A.0.62) AppleWebKit/534.31 (KHTML, like Gecko)",
                        "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Flock/3.5.3.4628 Chrome/7.0.517.450 Safari/534.7",
                        "Mozilla/5.0 (Windows NT 6.1; rv:26.0) Gecko/20100101 Firefox/26.0 IceDragon/26.0.0.2"
                          };
            Random rand = new Random();
            int i = rand.Next(0, ua.Length - 1);
            string ua2 = ua[i];
            return ua2;
        }
         * */

        public string avoircode(string url)
        {
            string rtncode;
            WebClient client = new WebClient();
            try
            {
                client.Headers["User-Agent"] = useragent;
                MessageBox.Show(client.Headers["User-Agent"]);
            }
            catch { }
            rtncode = client.DownloadString(url);
            return rtncode;
        }
    }
}
