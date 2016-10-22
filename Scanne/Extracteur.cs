using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class Extracteur
    {
        private MainForm form = GlobalVar.form;
        //https://msdn.microsoft.com/fr-fr/library/az24scfc.aspx
        private void helpRegex()
        {
            string text = "-----------------------------------------------------------------------------------------------------------------------\r\n";
            text += "The regular expression used here to parse an HTML anchor, e.g.,\r\n";
            text += " <a href=\"http://www.zone-hacker.net/\"></a> is explained \r\n";
            text += " as follows:\r\n";
            text += "                        <a\\s+href\\s*=\\s*\"?([^\" >]+)\"?>(.+)</a>\r\n";
            text += "----------------------------------------------------------------------------------------------------------------------\r\n";
            text += "   <a   \tThe beginning of the HTML anchor\r\n";
            text += "   \\s+  \tOne or more white space characters\r\n";
            text += "   href\tContinuing with exact text in HTML anchor\r\n";
            text += "   \\s*  \tZero or more white space characters\r\n";
            text += "   =     \tContinuing with exact text in HTML anchor\r\n";
            text += "   \\s*   \tZero or more white space characters\r\n";
            text += "   \"?  \tZero or none quotation mark (escaped)\r\n";
            text += "   (    \tStart of group defining a substring: The anchor URL.\r\n";
            text += "   [^\" >]+  One or more matches of any character except those in brackets.\r\n";
            text += "   )    \tEnd of first group defining a substring\r\n";
            text += "   \"?  \tZero or none quotation mark (escaped)\r\n";
            text += "   >    \tContinuing with exact text in HTML anchor\r\n";
            text += "-----------------------------------------------------------------------------------------------------------------------";
            Clipboard.SetText(text);
            MessageBox.Show(text, "Help RegEx", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void Google(string page)
        {
            List<string> Urls = new List<string> { }; //<a\s+href\s*=\s*"?([^" >]+)"?>
            Match regex = Regex.Match(page, "(?<=\"r\"><. href=\")(.+?)\"", RegexOptions.IgnoreCase);
            while (regex.Success)
            {
               string url = regex.Groups[1].Value;
               Match trouver = Regex.Match(url, @"\/url\?q\=(.*?)\&amp\;", RegexOptions.IgnoreCase);
               if (trouver.Success)
               {
                   url = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(trouver.Groups[1].Value));
                   if (Verfier(url))
                   {
                       Urls.Add(url);
                   }
               }
                regex = regex.NextMatch();
            }
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < Urls.Count; i++)
                {
                    form.list_url.Items.Add(Urls[i]);
                }
                form.list_url.EndUpdate();
            }));
        }

        public void Bing(string page)
        {
            List<string> Urls = new List<string> { };
            Match regex1 = Regex.Match(page, "<h2><a href=\"(.*?)\"", RegexOptions.IgnoreCase);
            while (regex1.Success)
            {
                string url = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(regex1.Groups[1].Value));
                if (Verfier(url))
                {
                    Urls.Add(url);
                }
                regex1 = regex1.NextMatch();
            }
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < Urls.Count; i++)
                {
                    form.list_url.Items.Add(Urls[i]);
                }
                form.list_url.EndUpdate();
            }));
        }

        public void Yahoo(string page)
        {
            List<string> Urls = new List<string> { };
            Match regex1 = Regex.Match(page, "fw-m fc-12th wr-bw\">(.*?)</span>");
            while (regex1.Success)
            {
                string url = regex1.Groups[1].Value;

                if(url.Contains("/") && url.Contains("."))
                {
                    url = "http://" + url;
                    url = url.Replace("<b>", "").Replace("</b>", "").Replace("...", "");
                    url = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(url));
                    if (Verfier(url))
                    {
                        Urls.Add(url);
                    }
                }
                regex1 = regex1.NextMatch();
            }
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < Urls.Count; i++)
                {
                    form.list_url.Items.Add(Urls[i]);
                }
                form.list_url.EndUpdate();
            }));
        }

        public void Yandex(string page)
        {
            List<string> Urls = new List<string> { };
            Match regex1 = Regex.Match(page, "\"_blank\" href=\"(.*?)\"");
            while (regex1.Success)
            {
                string url = HttpUtility.UrlDecode(HttpUtility.HtmlDecode(regex1.Groups[1].Value));
                if (Verfier(url))
                {
                    Urls.Add(url);
                }
                regex1 = regex1.NextMatch();
            }
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < Urls.Count; i++)
                {
                    form.list_url.Items.Add(Urls[i]);
                }
                form.list_url.EndUpdate();
            }));
        }

        internal void Aol(string page)
        {
            List<string> Urls = new List<string> { };
            Match regex1 = Regex.Match(page, "\"_blank\" href=\"(.*?)\"");
            while (regex1.Success)
            {
                string url = HttpUtility.HtmlDecode(HttpUtility.UrlDecode(regex1.Groups[1].Value));
                if (Verfier(url))
                {
                    Urls.Add(url);
                }
                regex1 = regex1.NextMatch();
            }
            form.list_url.Invoke((MethodInvoker)(() =>
            {
                form.list_url.BeginUpdate();
                for (int i = 0; i < Urls.Count; i++)
                {
                    form.list_url.Items.Add(Urls[i]);
                }
                form.list_url.EndUpdate();
            }));
        }

        private bool Verfier(string url)
        {
            if((url.Contains('?')) && (url.Contains('=')) && (Bon(url)) && (url.StartsWith("http")) && (!form.Hashurls.Contains(nomdomaine(url))))
            {
                form.Hashurls.Add(nomdomaine(url), url);
                return true;
            }
            else { return false; }
        }
        List<string> BlackList = new List<string> 
        {
            "facebook",
            "youtube",
            "msn",
            "ebay",
            "google",
            "pastebin",
            "yahoo",
            "sourceforge",
            "microsoft",
            "yandex.com",
            "github.com"
        };
        private bool Bon(string url)
        {
            bool oui = true;
            foreach (string mot in BlackList)
            {
                if(url.Contains(mot))
                {
                    oui = false;
                    break;
                }
            }
            return oui;
        }
        private string nomdomaine(string url)
        {
            return url.Split('/')[2];
        }

        /*
        private void b(object A_0, DoWorkEventArgs A_1)
        {
            frmScanner.b b = (frmScanner.b)A_1.Argument;
            string text = "";
            string sRegExPattern = "";
            int num = -1;
            this.b1 = true;
            this.bs = new Hashtable();
            int num2;
            switch (b.f)
            {
                case frmScanner.c.a:
                    text = this.bu.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 100;
                    sRegExPattern = "<a\\s+href\\s*=\\s*\"?([^\" >]+)\"";
                    break;
                case frmScanner.c.b:
                    text = this.bv.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 100;
                    sRegExPattern = "<a\\s+href\\s*=\\s*\"?([^\" >]+)\"";
                    break;
                case frmScanner.c.c:
                    text = this.bw.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 50;
                    sRegExPattern = "<a\\s+href\\s*=\\s*\"?([^\" >]+)\"";
                    break;
                case frmScanner.c.d:
                    text = this.bx.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 10;
                    sRegExPattern = "<a\\s+href\\s*=\\s*\"?([^\" >]+)\"\\s+onmousedown";
                    break;
                case frmScanner.c.e:
                    text = this.by.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 10;
                    sRegExPattern = "ngrn>([^ <]+) <";
                    break;
                case frmScanner.c.f:
                    text = this.bz.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 10;
                    sRegExPattern = "\"_blank\">([^ <]+)</a>";
                    break;
                case frmScanner.c.g:
                    text = this.b0.Replace("<%searchText%>", global::c.q.EncodeURL(b.d));
                    num2 = 1;
                    sRegExPattern = "<a\\s+href\\s*=\\s*\"?([^\" >]+)\">http:";
                    break;
            }
            checked
            {
                b.e *= num2;
                using (clsHTTP clsHTTP = new clsHTTP(b.a, false))
                {
                    int arg_1EF_0 = 0;
                    int arg_1ED_0 = b.e;
                    int num3 = num2;
                    int num4 = arg_1ED_0;
                    int num5 = arg_1EF_0;
                    while ((num3 >> 31 ^ num5) <= (num3 >> 31 ^ num4))
                    {
                        int num6;
                        num6++;
                        if (this.bckWorkerSearch.CancellationPending)
                        {
                            break;
                        }
                        if (this.b2 != null)
                        {
                            while (this.b2.Paused)
                            {
                                Thread.Sleep(100);
                            }
                        }
                        string text2 = text.Replace("<%currentIndex%>", Convert.ToString(num5));
                        if (num5 < b.e)
                        {
                            this.bckWorkerSearch.ReportProgress((int)Math.Round(Math.Round((double)(100 * num6) / ((double)b.e / (double)num2))), "Total URL's: " + Conversions.ToString(this.bs.Count));
                        }
                        clsHTTP arg_29A_0 = clsHTTP;
                        string arg_29A_1 = text2;
                        enHTTPMethod arg_29A_2 = enHTTPMethod.GET;
                        NetworkCredential arg_29A_3 = null;
                        bool arg_29A_4 = false;
                        string text3 = "";
                        string text4 = arg_29A_0.GetHTML(arg_29A_1, arg_29A_2, arg_29A_3, arg_29A_4, ref text3);
                        if (string.IsNullOrEmpty(text4))
                        {
                            break;
                        }
                        switch (b.f)
                        {
                            case frmScanner.c.a:
                            case frmScanner.c.b:
                                if (text4.Contains("Your search - <b>" + global::c.q.EncodeURL(b.d) + "</b> - did not match any documents."))
                                {
                                    return;
                                }
                                text4 = global::c.q.DecodeURL(text4).Trim();
                                break;
                            case frmScanner.c.c:
                                if (text4.Contains("We did not find results for: <strong>" + global::c.q.EncodeURL(b.d) + "</strong>"))
                                {
                                    return;
                                }
                                break;
                            case frmScanner.c.f:
                                if (text4.Contains("<li>Search for <b>" + global::c.q.EncodeURL(b.d) + "</b>"))
                                {
                                    return;
                                }
                                break;
                            case frmScanner.c.g:
                                if (text4.Contains("Não encontramos resultados para a pesquisa por"))
                                {
                                    return;
                                }
                                break;
                        }
                        using (clsRegExp clsRegExp = new clsRegExp())
                        {
                            Hashtable links = clsRegExp.GetLinks("", text4, sRegExPattern);
                            if (links != null)
                            {
                                if (links.Count == 0 | num == 0)
                                {
                                    byte b2;
                                    b2 += 1;
                                    if (b2 >= 3)
                                    {
                                        break;
                                    }
                                }
                                num = 0;
                                try
                                {
                                    IEnumerator enumerator = links.Values.GetEnumerator();
                                    while (enumerator.MoveNext())
                                    {
                                        string text5 = Conversions.ToString(enumerator.Current);
                                        int num7;
                                        switch (b.f)
                                        {
                                            case frmScanner.c.a:
                                            case frmScanner.c.b:
                                                try
                                                {
                                                    if (text5.StartsWith("http"))
                                                    {
                                                        if (!(this.bs.Contains(text5) | !this.b(text5)))
                                                        {
                                                            this.bs.Add(text5, text5);
                                                            num++;
                                                        }
                                                    }
                                                    continue;
                                                }
                                                catch (Exception expr_465)
                                                {
                                                    ProjectData.SetProjectError(expr_465);
                                                    ProjectData.ClearProjectError();
                                                    continue;
                                                }
                                                break;
                                            case frmScanner.c.c:
                                                break;
                                            case frmScanner.c.d:
                                                if (text5.Contains("cc.bingj.com/cache.aspx") | text5.Contains("login.live.com/") | text5.Contains("help.live.com/") | text5.Contains("g.live.com/"))
                                                {
                                                    continue;
                                                }
                                                text5 = global::c.q.DecodeURL(text5);
                                                num7 = Strings.InStr(text5, "&amp", CompareMethod.Binary);
                                                if (num7 > 0)
                                                {
                                                    text5 = Strings.Mid(text5, 1, num7 - 1);
                                                }
                                                if (text5.StartsWith("wwww"))
                                                {
                                                    text5 = "http://" + text5;
                                                }
                                                else
                                                {
                                                    if (!(text5.StartsWith("http://") | text5.StartsWith("https://")))
                                                    {
                                                        if (!text5.Contains("search?q="))
                                                        {
                                                            text5 = "http://" + text5;
                                                        }
                                                    }
                                                }
                                                if (this.bs.Contains(text5) | text5.Contains("msnscache") | text5.Contains("hotmail") | text5.Contains("live.com") | text5.Contains("/results.aspx?") | text5.Contains("WindowsLiveTranslator") | text5.Contains("microsoft") | text5.Contains("bing.com") | !this.b(text5))
                                                {
                                                    continue;
                                                }
                                                if (text5.StartsWith("http"))
                                                {
                                                    this.bs.Add(text5, text5);
                                                    num++;
                                                    continue;
                                                }
                                                continue;
                                            case frmScanner.c.e:
                                                text5 = global::c.q.DecodeURL(text5);
                                                if (text5.StartsWith("wwww"))
                                                {
                                                    text5 = "http://" + text5;
                                                }
                                                else
                                                {
                                                    if (!(text5.StartsWith("http://") | text5.StartsWith("https://")))
                                                    {
                                                        text5 = "http://" + text5;
                                                    }
                                                }
                                                if (this.bs.Contains(text5) | text5.Contains("altavista") | !this.b(text5))
                                                {
                                                    continue;
                                                }
                                                this.bs.Add(text5, text5);
                                                num++;
                                                continue;
                                            case frmScanner.c.f:
                                                text5 = global::c.q.DecodeURL(text5);
                                                if (text5.StartsWith("wwww"))
                                                {
                                                    text5 = "http://" + text5;
                                                }
                                                else
                                                {
                                                    if (!(text5.StartsWith("http://") | text5.StartsWith("https://")))
                                                    {
                                                        text5 = "http://" + text5;
                                                    }
                                                }
                                                if (this.bs.Contains(text5) | text5.Contains("terravista") | !this.b(text5))
                                                {
                                                    continue;
                                                }
                                                this.bs.Add(text5, text5);
                                                num++;
                                                continue;
                                            case frmScanner.c.g:
                                                num7 = text5.IndexOf("&amp");
                                                if (num7 > 0)
                                                {
                                                    text5 = text5.Substring(0, num7).Trim();
                                                }
                                                if (this.bs.Contains(text5) | text5.Contains("sapo") | !text5.StartsWith("http://") | !this.b(text5))
                                                {
                                                    continue;
                                                }
                                                this.bs.Add(text5, text5);
                                                num++;
                                                continue;
                                            default:
                                                continue;
                                        }
                                        text5 = global::c.q.DecodeURL(text5);
                                        num7 = Strings.InStr(text5, "**http://", CompareMethod.Binary);
                                        if (num7 > 0)
                                        {
                                            try
                                            {
                                                text5 = Strings.Mid(text5, num7 + 2);
                                                if (!text5.Contains("yahoo.com"))
                                                {
                                                    num7 = Strings.InStr(text5, "&u=", CompareMethod.Binary);
                                                    if (num7 > 0)
                                                    {
                                                        text5 = Strings.Mid(text5, num7 + 3);
                                                        string[] array = Strings.Split(text5, "=", -1, CompareMethod.Binary);
                                                        if (!Information.IsNothing(array))
                                                        {
                                                            text5 = array[0] + "=" + array[1];
                                                            if (text5.Contains("&w="))
                                                            {
                                                                text5 = Strings.Mid(text5, 1, Strings.InStr(text5, "&w=", CompareMethod.Binary) - 1);
                                                            }
                                                            if (text5.StartsWith("wwww"))
                                                            {
                                                                text5 = "http://" + text5;
                                                            }
                                                            else
                                                            {
                                                                if (!(text5.StartsWith("http://") | text5.StartsWith("https://")))
                                                                {
                                                                    text5 = "http://" + text5;
                                                                }
                                                            }
                                                            text5 = global::c.q.DecodeURL(text5);
                                                            if (!(this.bs.Contains(text5) | !this.b(text5)))
                                                            {
                                                                this.bs.Add(text5, text5);
                                                                num++;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            catch (Exception expr_5C2)
                                            {
                                                ProjectData.SetProjectError(expr_5C2);
                                                ProjectData.ClearProjectError();
                                            }
                                        }
                                    }
                                    goto IL_917;
                                }
                                finally
                                {
                                    IEnumerator enumerator;
                                    if (enumerator is IDisposable)
                                    {
                                        (enumerator as IDisposable).Dispose();
                                    }
                                }
                            }
                            break;
                        }
                    IL_917:
                        num5 += num3;
                    }
                }
            }
            
        }*/

    }


    /*
    public class clsRegExp : IDisposable
    {
        private bool a;
        [DebuggerNonUserCode]
        public clsRegExp()
        {
        }
        protected virtual void Dispose(bool b)
        {
            if (!this.a)
            {
            }
            this.a = true;
        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        public Hashtable Match(string sPattern, string sData, RegexOptions o)
        {
            Hashtable hashtable = new Hashtable();
            Regex regex = new Regex(sPattern, o);
            Match match = regex.Match(sData);
            while (match.Success)
            {
                clsRegExpResult clsRegExpResult = new clsRegExpResult();
                clsRegExpResult.Index = match.Index;
                clsRegExpResult.Value = match.Groups[1].Value;
                hashtable.Add(match.Index.ToString(), clsRegExpResult);
                match = match.NextMatch();
            }
            return hashtable;
        }
        public Hashtable GetData(string sData, string sRegExPattern)
        {
            Hashtable hashtable = this.Match(sRegExPattern, sData, RegexOptions.IgnoreCase);
            Hashtable hashtable2 = new Hashtable();
            if (hashtable.Count == 0)
            {
                return hashtable2;
            }
            try
            {
                IEnumerator enumerator = hashtable.Values.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    clsRegExpResult clsRegExpResult = (clsRegExpResult)enumerator.Current;
                    hashtable2.Add(hashtable2.Count.ToString(), clsRegExpResult.Value);
                }
            }
            finally
            {
                IEnumerator enumee;
                if (enumee is IDisposable)
                {
                    (enumee as IDisposable).Dispose();
                }
            }
            return hashtable2;
        }
        public string GetItemData(string sData, string sPattern, string sDefautValue = "")
        {
            Regex regex = new Regex(sPattern, RegexOptions.IgnoreCase);
            Match match = regex.Match(sData);
            while (match.Success)
            {
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    return match.Groups[1].Value;
                }
            }
            return sDefautValue;
        }
        public Hashtable SplitData(string sData, string sFind)
        {
            Hashtable hashtable = new Hashtable();
            string[] array = Regex.Split(sData, sFind);
            checked
            {
                for (int i = 0; i < array.Length; i++)
                {
                    string text = array[i];
                    if (!hashtable.Contains(text))
                    {
                        hashtable.Add(text, text);
                    }
                }
                return hashtable;
            }
        }
        public Hashtable GetLinks(string sUrl, string sData, string sRegExPattern)
        {
            Hashtable hashtable = this.Match(sRegExPattern, sData, RegexOptions.IgnoreCase);
            Hashtable hashtable2 = new Hashtable();
            if (hashtable.Count == 0)
            {
                return hashtable2;
            }
            if (string.IsNullOrEmpty(sUrl))
            {
                try
                {
                    IEnumerator enumerator = hashtable.Values.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        clsRegExpResult clsRegExpResult = (clsRegExpResult)enumerator.Current;
                        hashtable2.Add(hashtable2.Count.ToString(), clsRegExpResult.Value);
                    }
                }
                finally
                {
                    IEnumerator enumerator;
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                return hashtable2;
            }
            string[] array = Regex.Split(sUrl, "/");
            string str = array[0] + "//" + array[2];
            try
            {
                IEnumerator enumerator2 = hashtable.Values.GetEnumerator();
                while (enumerator2.MoveNext())
                {
                    clsRegExpResult clsRegExpResult2 = (clsRegExpResult)enumerator2.Current;
                    if (clsRegExpResult2.Value.StartsWith("http://"))
                    {
                        hashtable2.Add(hashtable2.Count.ToString(), new clsLink(clsRegExpResult2.Value, clsRegExpResult2.Value, clsRegExpResult2));
                    }
                    else
                    {
                        if (clsRegExpResult2.Value.StartsWith("./"))
                        {
                            clsRegExpResult2.Value = clsRegExpResult2.Value.Replace("./", "/");
                        }
                        if (clsRegExpResult2.Value.StartsWith("/") | clsRegExpResult2.Value.StartsWith("./"))
                        {
                            hashtable2.Add(hashtable2.Count.ToString(), new clsLink(clsRegExpResult2.Value, str + clsRegExpResult2.Value, clsRegExpResult2));
                        }
                        else
                        {
                            hashtable2.Add(hashtable2.Count.ToString(), new clsLink(clsRegExpResult2.Value, str + "/" + clsRegExpResult2.Value, clsRegExpResult2));
                        }
                    }
                }
            }
            finally
            {
                IEnumerator enumerator2;
                if (enumerator2 is IDisposable)
                {
                    (enumerator2 as IDisposable).Dispose();
                }
            }
            return hashtable2;
        }
    }
    public class clsRegExpResult
    {
        private int a;
        private string b;
        public int Index
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public string Value
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }
        [DebuggerNonUserCode]
        public clsRegExpResult()
        {
        }
    }
    public class clsLink
    {
        private string a;
        private string b;
        private clsRegExpResult c;
        public string UrlSite
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public string Url
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }
        public clsRegExpResult Result
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }
        public clsLink(string sUrlSite, string sUrl, clsRegExpResult oResult)
        {
            this.a = sUrlSite;
            this.b = sUrl;
            this.c = oResult;
        }
    }
    */

}
