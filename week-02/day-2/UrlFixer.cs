using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            https://www.reddit.com/r/nevertellmetheodds/
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            string url2 = url.Replace("bots", "odds");
            string url3 = url2.Insert(url.IndexOf('/'), ":");

            Console.WriteLine(url3);
            Console.ReadLine();
        }
    }
}
