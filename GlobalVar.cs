using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SQl_SCanner
{
    public static class GlobalVar
    {
        public static MainForm form;
        public static CookieCollection cookies = new CookieCollection();
        public static CookieCollection GblCookie
        {
            get { return cookies; }
            set { cookies.Add(value); }
        }
    }
}
