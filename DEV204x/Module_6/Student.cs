using System;

namespace Module_6
{
    public class Student : Person
    {
        public void TakeTest()
        {
            Console.WriteLine("Student {0} {1} is taking a test", FirstName, LastName);
        }
    }
}
