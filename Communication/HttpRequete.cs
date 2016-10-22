using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class HttpRequete
    {
        private MainForm form = GlobalVar.form;
        public static string useragent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.1.2) Gecko/20090729 Firefox/3.5.2 (.NET CLR 3.5.30729)";
        private CookieCollection cookies = new CookieCollection();
        private int tantativeMax = 5;

        public string get(string url)
        {
            CookieCollection cctemps = GlobalVar.GblCookie;
            var reponseString = "";
            for (int t = 0; t < tantativeMax; t++)
            {
                try
                {
                    var requete = (HttpWebRequest)WebRequest.Create(url);
                    requete.UserAgent = useragent;
                    requete.Timeout = 500000;
                    requete.CookieContainer = new CookieContainer();
                    requete.CookieContainer.Add(cctemps);
                    requete.AllowAutoRedirect = true;
                    requete.KeepAlive = true;

                    var response = (HttpWebResponse)requete.GetResponse();
                    reponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    cookies = response.Cookies;
                    break;
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.UnknownError ||
                        ex.Status == WebExceptionStatus.TrustFailure ||
                        ex.Status == WebExceptionStatus.ServerProtocolViolation ||
                        ex.Status == WebExceptionStatus.SendFailure ||
                        ex.Status == WebExceptionStatus.SecureChannelFailure ||
                        ex.Status == WebExceptionStatus.RequestProhibitedByCachePolicy ||
                        ex.Status == WebExceptionStatus.RequestCanceled ||
                        ex.Status == WebExceptionStatus.ProtocolError ||
                        ex.Status == WebExceptionStatus.PipelineFailure ||
                        ex.Status == WebExceptionStatus.CacheEntryNotFound)
                    {
                        try
                        {
                            using (var stream = ex.Response.GetResponseStream())
                            using (var reader = new StreamReader(stream))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                        catch
                        {
                            
                        }
                    }
                    else if (ex.Status == WebExceptionStatus.ProxyNameResolutionFailure)
                    {
                        if (t == 4)
                        {
                            /*string Hote = url.Split('/')[2];
                            form.list_trash.Invoke((MethodInvoker)(() =>
                            {
                                if (!existDeja(Hote, form.list_trash))
                                {
                                    form.list_trash.BeginUpdate();
                                    form.list_trash.Items.Add(Hote);
                                    form.list_trash.EndUpdate();
                                }
                            }));*/
                        }
                    }
                    else
                    {
                        return reponseString;
                    }
                }
                catch
                {

                }
            }
            return reponseString;
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
    }
}
