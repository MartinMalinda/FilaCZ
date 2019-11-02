using HelloDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDI.Models
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is red color..");
        }
    }
}
