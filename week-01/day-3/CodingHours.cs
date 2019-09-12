using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int averageCodingHours = 6;
            int semesterWeeks = 17;
            int workDays = 5;
            float workHoursPerWeek = 52;

            float codingHoursPerWeek = 30;



            Console.WriteLine("Number of averege coding hours per semester: " + averageCodingHours * semesterWeeks * workDays);

            Console.WriteLine("Percentage of the coding hours in the semester: " + (codingHoursPerWeek / workHoursPerWeek) * 100);

            Console.ReadLine();
            
           
        }
    }
}
