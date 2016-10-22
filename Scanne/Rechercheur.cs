using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class Rechercheur
    {
        private MainForm form = GlobalVar.form;
        public void Google(string[] DorkArray, string maxpage)
        {
            int compteur;
            int nbrdork = DorkArray.Length;
            int max = Convert.ToInt16(maxpage + 0);
            HttpRequete hr = new HttpRequete();
            Extracteur ext = new Extracteur();
            for (int i = 0; i < nbrdork; i++)
            {
                for (compteur = 0; compteur < max; compteur += 10)
                {
                    string url = "https://www.google.com/search?q=" + HttpUtility.UrlEncode(DorkArray[i]) + "&start=" + compteur;
                    string page = hr.get(url);
                    if ((!page.Contains("CAPTCHA")) || (!page.Contains(form.monip)))
                    {
                        ext.Google(page);
                    }
                    else
                    {

                    }
                    form.UpInfos();
                }
            }
        }

        public void Bing(string[] DorkArray, string maxpage)
        {
            int compteur;
            int nbrdork = DorkArray.Length;
            int max = Convert.ToInt16(maxpage + 0);
            HttpRequete hr = new HttpRequete();
            Extracteur ext = new Extracteur();
            for (int i = 0; i < nbrdork; i++)//Pour Dork
            {
                for (compteur = 0; compteur < max; compteur += 15)//Pour Page a faire
                {
                    string url = "http://bing.com/search?q=" + HttpUtility.UrlEncode(DorkArray[i]) + "&first=" + compteur;
                    string page = hr.get(url);
                    ext.Bing(page);
                    form.UpInfos();
                }
            }
        }

        public void Yahoo(string[] DorkArray, string maxpage)
        {
            int compteur;
            int nbrdork = DorkArray.Length;
            int max = Convert.ToInt16(maxpage + 0);
            HttpRequete hr = new HttpRequete();
            Extracteur ext = new Extracteur();
            for (int i = 0; i < nbrdork; i++)//Pour Dork
            {
                for (compteur = 1; compteur < max; compteur += 10)//Pour Page a faire
                {
                    string url = "http://search.yahoo.com/search?n=100&p=" + HttpUtility.UrlEncode(DorkArray[i]) + "&pstart=1&b=" + compteur;
                    string page = hr.get(url);
                    ext.Yahoo(page);
                    form.UpInfos();
                }
            }
        }
        // ?    ===> %3F
        public void Yandex(string[] DorkArray, string maxpage)
        {//http://www.yandex.com/yandsearch?text=shop.php%3fsubcat_id%3d
            int compteur;
            int nbrdork = DorkArray.Length;
            int max = Convert.ToInt16(maxpage + 0);
            HttpRequete hr = new HttpRequete();
            Extracteur ext = new Extracteur();
            hr.get("https://www.yandex.com/yandsearch");
            for (int i = 0; i < nbrdork; i++)//Pour Dork
            {
                for (compteur = 0; compteur < max; compteur++)//Pour Page a faire
                {
                    string url = "http://www.yandex.com/yandsearch?text=" + HttpUtility.UrlEncode(DorkArray[i]) + "&p=" + compteur;
                    string page = hr.get(url);
                    if (!page.Contains("search requests sent from your IP"))
                    {
                        ext.Yandex(page);
                    }
                    else { break; }
                    form.UpInfos();
                }
            }
        }
        internal void Aol(string[] DorkArray, string maxpage)
        {
            int compteur;
            int nbrdork = DorkArray.Length;
            int max = Convert.ToInt16(maxpage + 0);
            HttpRequete hr = new HttpRequete();
            Extracteur ext = new Extracteur();
            hr.get("http://search.aol.com/aol/webhome");
            for (int i = 0; i < nbrdork; i++)//Pour Dork
            {
                for (compteur = 0; compteur < max; compteur++)//Pour Page a faire //http://search.aol.com/aol/search?q=
                {
                    string url = "http://search.aol.com/aol/search?q=" + DorkArray[i] + "&page=" + compteur;
                    string page = hr.get(url);
                    ext.Aol(page);
                    form.UpInfos();
                }
            }
        }
    }
}
