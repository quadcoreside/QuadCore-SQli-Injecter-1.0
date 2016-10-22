using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Class Name : DH Tools
// Version : Beta 
// Author : Doddy Hackman
// (C) Doddy Hackman 2014
//
// Functions :
//
// [+] HTTP Methods GET & POST
// [+] Get HTTP Status code number
// [+] HTTP FingerPrinting
// [+] Read File
// [+] Write File
// [+] GET OS
// [+] Remove duplicates from a List
// [+] Cut urls from a List
// [+] Download
// [+] Upload
// [+] Get Basename from a path
// [+] Execute commands
// [+] URI Split
// [+] MD5 Hash Generator
// [+] Get MD5 of file
// [+] Get IP address from host name
//
// Credits : 
//
// Method POST -> https://technet.rapaport.com/Info/Prices/SampleCode/Full_Example.aspx 
// Method GET -> http://stackoverflow.com/questions/4510212/how-i-can-get-web-pages-content-and-save-it-into-the-string-variable 
// HTTP Headers -> http://msdn.microsoft.com/en-us/library/system.net.httpwebresponse.headers%28v=vs.110%29.aspx
// List Cleaner -> http://forums.asp.net/t/1318899.aspx?Remove+duplicate+items+from+List+String+ 
// Execute command -> http://www.codeproject.com/Articles/25983/How-to-Execute-a-Command-in-C 
// MD5 Hash Generator -> http://www.java2s.com/Code/CSharp/Security/GetandverifyMD5Hash.htm
// Get MD5 of file -> http://stackoverflow.com/questions/10520048/calculate-md5-checksum-for-a-file 
// 
// Thanks to : $DoC and atheros14 (Forum indetectables)
//

namespace SQl_SCanner
{
    class Outils
    {
        public async Task<string> prendresource(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", useragent());
            Task<string> getStringTask = client.GetStringAsync(url);
            string code = await getStringTask;
            return code;
        }
        public string avoirip(string url)
        {
            string hote = string.Empty;
            try
            {
                hote = url.Split('/')[2];
            }
            catch (Exception) { }
            hote = (hote == string.Empty) ? url : hote;
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
        private string useragent()
        {
            string[] ua = {"Mozilla/5.0 (X11; Linux i686) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.52 Safari/536.5",
                    "Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.8.1.11) Gecko/20071127 Firefox/2.0.0.11",
                    "Opera/9.25 (Windows NT 5.1; U; en)",
                    "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)",
                    "Mozilla/5.0 (compatible; Konqueror/3.5; Linux) KHTML/3.5.5 (like Gecko) (Kubuntu)",
                    "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.0.12) Gecko/20070731 Ubuntu/dapper-security Firefox/1.5.0.12",
                    "Mozilla/5.0 (iPad; U; CPU OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B334b Safari/531.21.102011-10-16 20:23:50",
                    "Mozilla/5.0 (BlackBerry; U; BlackBerry 9800; en) AppleWebKit/534.1+ (KHTML, like Gecko) Version/6.0.0.337 Mobile Safari/534.1+2011-10-16 20:21:10",
                    "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en) Opera 8.0",
                    "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/38.0.2066.0 Safari/537.36",
                    "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-GB; rv:1.8.1.6) Gecko/20070725 Firefox/2.0.0.6",
                    "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Ubuntu/10.10 Chromium/8.0.552.237",
                    "Mozilla/5.0 (X11; Linux i686) AppleWebKit/535.7 (KHTML, like Gecko) Ubuntu/11.10 Chromium/16.0.912.21",
                    "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/535.2 (KHTML, like Gecko) Ubuntu/11.04 Chromium/15.0.871.0 ",
                    "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.20 (KHTML, like Gecko) Chrome/11.0.672.2 Safari/534.20",
                    "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.45 Safari/535.19",
                    "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.93 Safari/537.36",
                    "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.1 (KHTML, like Gecko) Comodo_Dragon/14.0.1.0 Chrome/14.0.835.163 Safari/535.1",
                    "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.105 CoRom/30.0.1599.105 Safari/537.36",
                    "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36",
                    "Mozilla/5.0 (IE 11.0; Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko",
                    "Mozilla/5.0 (Linux; U; Android 4.2; en-us; Nexus 10 Build/JVP15I) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Safari/534.30",
                    "Opera/10.61 (J2ME/MIDP; Opera Mini/5.1.21219/19.999; en-US; rv:1.9.3a5) WebKit/534.5 Presto/2.6.30",
                    "Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0",
                    "Mozilla/5.0 (Linux; U; Android 2.3.4; en-US; MT11i Build/4.0.2.A.0.62) AppleWebKit/534.31 (KHTML, like Gecko) UCBrowser/9.0.1.275 U3/0.8.0 Mobile Safari/534.31",
                    "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_6; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Flock/3.5.3.4628 Chrome/7.0.517.450 Safari/534.7",
                    "Mozilla/5.0 (Windows NT 6.1; rv:26.0) Gecko/20100101 Firefox/26.0 IceDragon/26.0.0.2"
                          };
            Random rand = new Random();
            int i = rand.Next(0, ua.Length - 1);
            string ua2 = ua[i];
            return ua2;
        }

        public string tomar(string url, string par)
        {

            string code = "";

            try
            {

                HttpWebRequest nave = (HttpWebRequest)
                WebRequest.Create(url);

                nave.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36";
                nave.Method = "POST";
                nave.ContentType = "application/x-www-form-urlencoded";

                Stream anteantecode = nave.GetRequestStream();

                anteantecode.Write(Encoding.ASCII.GetBytes(par), 0, Encoding.ASCII.GetBytes(par).Length);
                anteantecode.Close();

                StreamReader antecode = new StreamReader(nave.GetResponse().GetResponseStream());
                code = antecode.ReadToEnd();

            }
            catch
            {
                //
            }

            return code;

        }

        public string respondecode(string url)
        {
            String code = "";
            try
            {
                HttpWebRequest nave = (HttpWebRequest)WebRequest.Create(url);
                nave.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0";
                HttpWebResponse num = (HttpWebResponse)nave.GetResponse();

                int number = (int)num.StatusCode;
                code = Convert.ToString(number);

            }
            catch
            {

                code = "404";

            }
            return code;
        }

        public string httpfinger(string url)
        {

            String code = "";

            try
            {

                HttpWebRequest nave1 = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse nave2 = (HttpWebResponse)nave1.GetResponse();

                for (int num = 0; num < nave2.Headers.Count; ++num)
                {
                    code = code + "[+] " + nave2.Headers.Keys[num] + ":" + nave2.Headers[num] + Environment.NewLine;
                }

                nave2.Close();
            }
            catch
            {
                //
            }

            return code;

        }

        public string openword(string file)
        {
            String code = "";
            try
            {
                code = System.IO.File.ReadAllText(file);
            }
            catch
            {
                //
            }
            return code;
        }

        public void savefile(string file, string texto)
        {

            try
            {
                System.IO.StreamWriter save = new System.IO.StreamWriter(file, true);
                save.Write(texto);
                save.Close();
            }
            catch
            {
                //
            }
        }

        public string avoiros()
        {
            string code = "";

            try
            {
                System.OperatingSystem os = System.Environment.OSVersion;
                code = Convert.ToString(os);
            }
            catch
            {
                code = "?";
            }

            return code;
        }

        public List<string> repes(List<string> array)
        {
            List<string> repe = new List<string>();
            foreach (string lin in array)
            {
                if (!repe.Contains(lin))
                {
                    repe.Add(lin);
                }
            }

            return repe;

        }

        public List<string> couper(List<string> otroarray)
        {
            List<string> cort = new List<string>();

            foreach (string row in otroarray)
            {

                String lignefinale = "";

                Match regex = Regex.Match(row, @"(.*)\?(.*)=(.*)", RegexOptions.IgnoreCase);
                if (regex.Success)
                {
                    lignefinale = regex.Groups[1].Value + "?" + regex.Groups[2].Value + "=";
                    cort.Add(lignefinale);
                }

            }

            return cort;
        }

        public string download(string url, string savename)
        {

            String code = "";

            WebClient wb = new WebClient();
            wb.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0";

            try
            {
                wb.DownloadFile(url, savename);
                code = "OK";
            }
            catch
            {
                code = "Error";
            }

            return code;
        }

        public string upload(string link, string archivo)
        {

            String code = "";

            try
            {

                WebClient wb = new WebClient();
                wb.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0";
                byte[] codedos = wb.UploadFile(link, "POST", archivo);
                code = System.Text.Encoding.UTF8.GetString(codedos, 0, codedos.Length);

            }

            catch
            {
                code = "Error";
            }

            return code;

        }

        public string basename(string file)
        {
            String nombre = "";

            FileInfo basename = new FileInfo(file);
            nombre = basename.Name;

            return nombre;

        }

        public string console(string cmd)
        {

            string code = "";

            try
            {

                System.Diagnostics.ProcessStartInfo loadnow = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);
                loadnow.RedirectStandardOutput = true;
                loadnow.UseShellExecute = false;
                loadnow.CreateNoWindow = true;
                System.Diagnostics.Process loadnownow = new System.Diagnostics.Process();
                loadnownow.StartInfo = loadnow;
                loadnownow.Start();
                code = loadnownow.StandardOutput.ReadToEnd();

            }

            catch
            {
                code = "Error";
            }

            return code;

        }

        public string urisplit(string url, string opcion)
        {

            string code = "";

            Uri dividir = new Uri(url);

            if (opcion == "host")
            {
                code = dividir.Host;
            }

            if (opcion == "port")
            {
                code = Convert.ToString(dividir.Port);
            }

            if (opcion == "path")
            {
                code = dividir.LocalPath;
            }

            if (opcion == "file")
            {
                code = dividir.AbsolutePath;
                FileInfo basename = new FileInfo(code);
                code = basename.Name;
            }

            if (opcion == "query")
            {
                code = dividir.Query;
            }

            if (opcion == "")
            {
                code = "Error";
            }

            return code;
        }

        public string convertir_md5(string text)
        {
            MD5 convertirmd5 = MD5.Create();
            byte[] infovalor = convertirmd5.ComputeHash(Encoding.Default.GetBytes(text));
            StringBuilder guardar = new StringBuilder();
            for (int numnow = 0; numnow < infovalor.Length; numnow++)
            {
                guardar.Append(infovalor[numnow].ToString("x2"));
            }
            return guardar.ToString();
        }

        public string md5fichier(string file)
        {

            string code = "";

            try
            {
                var gen = MD5.Create();
                var ar = File.OpenRead(file);
                code = BitConverter.ToString(gen.ComputeHash(ar)).Replace("-", "").ToLower();

            }
            catch
            {
                code = "Error";
            }

            return code;
        }
    }
}
