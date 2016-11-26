using System;

namespace Module_6
{
    public class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} {1} is grading a test", FirstName, LastName);
        }
    }
}
