using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Greetings
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public static long counter = 0;

        public Greetings()
        {
            this.Id = 1;
            this.Content = "from the model";
        }

        public Greetings(long id, string content)
        {
            this.Id = id;
            this.Content = content;
        }

    }
}
