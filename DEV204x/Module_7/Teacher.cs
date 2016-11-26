using System;

namespace Module_7
{
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} {1} is grading a test", FirstName, LastName);
        }
    }
}
