using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student : Person, ICloneable
    {
        public string PreviousOrganisation { get; private set; }
        private int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganisation) : base (name, age, gender)
        {
            this.PreviousOrganisation = previousOrganisation;
            this.SkippedDays = 0;
        }



        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introducing()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Age} years old {Gender} from {PreviousOrganisation}" +
                $" and I skipped {SkippedDays} days of course.");
        }

        public void SkippedDaysAtCourse(int numberOfDays)
        {
            SkippedDays = SkippedDays + numberOfDays;
        }

        public object Clone()
        {
            return new Student(this.Name, this.Age, this.Gender, this.PreviousOrganisation);
        }
    }
}
