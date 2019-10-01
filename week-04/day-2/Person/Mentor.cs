using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public enum MentorLevel
    {
        junior,
        intermediet,
        senior
    }
    class Mentor : Person
    {
        public MentorLevel Level { get; private set; }
        public Mentor(string name, int age, string gender, MentorLevel level) : base(name, age, gender)
        {
            this.Level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introducing()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Age} years old {Gender} {Level} mentor.");
        }
    }
}
