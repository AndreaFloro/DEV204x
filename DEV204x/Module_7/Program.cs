
using System;
using System.Collections;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Student("Michael", "Jordan");
            stud1.Grades.Push(75);
            stud1.Grades.Push(88);
            stud1.Grades.Push(67);
            stud1.Grades.Push(56);
            stud1.Grades.Push(78);

            var stud2 = new Student("Shaquille", "O'Neal");
            stud2.Grades.Push(89);
            stud2.Grades.Push(81);
            stud2.Grades.Push(67);
            stud2.Grades.Push(98);
            stud2.Grades.Push(66);

            var stud3 = new Student("Kobe", "Bryant");
            stud3.Grades.Push(55);
            stud3.Grades.Push(67);
            stud3.Grades.Push(88);
            stud3.Grades.Push(89);
            stud3.Grades.Push(91);

            var Course = new Course("Module 7");
            Course.Students.Add(stud1);
            Course.Students.Add(stud2);
            Course.Students.Add(stud3);

            Course.ListStudents();
        }
    }
}

