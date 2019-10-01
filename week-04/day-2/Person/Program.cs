using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person newPerson = new Person("Jane Doe", 30, "female");

            Student newStudent = new Student("Jana Doe", 30, "female", "The school of life");

            Mentor newMentor = new Mentor("Jana Doe", 30, "female", MentorLevel.intermediet);

            Sponsor newSponsor = new Sponsor("Jana Doe", 30, "female", "Google");*/

            var people = new List<Person>();
            var students = new List<Student>();
            var mentors = new List<Mentor>();
            var sponsors = new List<Sponsor>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var mark1 = new Person("Mark1", 46, "male");
            people.Add(mark1);
            var john = new Student("John Doe", 20, "male", "BME");
            students.Add(john);
            var john1 = new Student("John Doe1", 20, "male", "BME");
            students.Add(john1);
            var gandhi = new Mentor("Gandhi", 148, "male", MentorLevel.senior);
            mentors.Add(gandhi);
            var gandhi1 = new Mentor("Gandhi1", 148, "male", MentorLevel.senior);
            mentors.Add(gandhi1);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            sponsors.Add(elon);
            var elon1 = new Sponsor("Elon Musk1", 46, "male", "SpaceX");
            sponsors.Add(elon1);


            john.SkippedDaysAtCourse(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire(i);
            }

            foreach (var person in people)
            {
                person.Introducing();
                person.GetGoal();
            }

            foreach (var student in students)
            {
                student.Introducing();
                student.GetGoal();
            }

            foreach (var mentor in mentors)
            {
                mentor.Introducing();
                mentor.GetGoal();
            }

            foreach (var sponsor in sponsors)
            {
                sponsor.Introducing();
                sponsor.GetGoal();
            }

            /*newPerson.Introducing();

            Console.WriteLine();

            newStudent.SkippedDaysAtCourse(5);
            newStudent.Introducing();

            Console.WriteLine();

            newMentor.Introducing();

            Console.WriteLine();

            newSponsor.Hire(5);
            newSponsor.Introducing();*/




            Console.ReadKey();
        }
    }
}
