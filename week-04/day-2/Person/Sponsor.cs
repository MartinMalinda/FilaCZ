using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Sponsor : Person
    {
        public string CompanyName { get; private set; }
        public int HiredStudents { get; private set; }
        public Sponsor(string name, int age, string gender, string companyName) : base(name, age, gender)
        {
            this.CompanyName = companyName;
            this.HiredStudents = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public override void Introducing()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Age} years old {Gender} who represents {CompanyName} company " +
                $"and hired {HiredStudents} students.");
        }

        public void Hire(int numToHire)
        {
            HiredStudents = HiredStudents + numToHire;
        }
    }
}
