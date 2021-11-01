using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EncodeDecodeText
    {
        public string Text { get; set; }
        public string Encoded_Text { get; set; }
        public EncodeDecodeText(string text, string encoded_text)
        {
            Text = text;
            Encoded_Text = encoded_text;
        }
    }
}
