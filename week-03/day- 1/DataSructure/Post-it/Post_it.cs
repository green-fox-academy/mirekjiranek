using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    class Post_it
    {
        public string BackgroundColor;
        public string Text;
        public string TextColor;

        public Post_it(string backgroundColor, string text, string textColor)
        {
            BackgroundColor = backgroundColor;
            Text = text;
            TextColor = textColor;
        }
    }
}
