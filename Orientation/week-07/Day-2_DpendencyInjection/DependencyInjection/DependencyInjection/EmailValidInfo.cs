using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EmailValidInfo
    {
        public string URL_Text { get; set; }
        public bool isValid { get; set; }
        public EmailValidInfo(string url_text,bool isvalid)
        {
            URL_Text = url_text;
            isValid = isvalid;
        }
    }
}
