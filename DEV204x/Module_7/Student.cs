using System;
using System.Collections;

namespace Module_7
{
    public class Student : Person
    {
        private Stack grades = new Stack();

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Stack Grades { get { return grades; } }
    }
}
