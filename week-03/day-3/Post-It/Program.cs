using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_It
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt object1 = new PostIt("Orange", "Idea 1", "Blue");
            PostIt object2 = new PostIt("Pink", "Awesome", "Black");
            PostIt object3 = new PostIt("Yellow", "Superb!", "Green");

        }
        public struct PostIt
        {
            public string BackgroundColor { get; set; }
            public string Text { get; set; }
            public string TextColor { get; set; }

            public PostIt(string backgroundColor, string text, string textColor)
            {
                 this.BackgroundColor = backgroundColor;
                 this.Text = text;
                 this.TextColor = textColor;
            }

        }
    }
}
