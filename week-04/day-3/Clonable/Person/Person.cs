using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Name { get; set; }
        public int Age  { get; set; }
        public string Gender { get; set; }



        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
        public virtual void Introducing()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Age} years old {Gender}.");
        }
    }

   
}
