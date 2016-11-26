using System;
using System.Collections.Generic;

namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Student("Michael", "Jordan");
            stud1.Grades.Push("A++");
            stud1.Grades.Push("B");
            stud1.Grades.Push("A-");
            stud1.Grades.Push("C++");
            stud1.Grades.Push("B++");

            var stud2 = new Student("Scottie", "Pippen");
            stud2.Grades.Push("B++");
            stud2.Grades.Push("B-");
            stud2.Grades.Push("C-");
            stud2.Grades.Push("A++");
            stud2.Grades.Push("C++");

            var stud3 = new Student("Steve", "Kerr");
            stud3.Grades.Push("A--");
            stud3.Grades.Push("B++");
            stud3.Grades.Push("A");
            stud3.Grades.Push("B++");
            stud3.Grades.Push("C--");

            var course = new Course("Module 8");
            course.Students.Add(stud1);
            course.Students.Add(stud2);
            course.Students.Add(stud3);

            course.ListStudents();
        }
    }

    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }
    }

    public class Student : Person
    {
        private Stack<string> grades = new Stack<string>();

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Stack<string> Grades { get { return grades; } }
    }

    public class Course
    {
        private List<Student> students = new List<Student>();
        private string courseName;
        private int credits;
        private int durationInWeeks;

        public List<Student> Students { get { return students; } }

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int DurationInWeeks
        {
            get
            {
                return durationInWeeks;
            }

            set
            {
                durationInWeeks = value;
            }
        }

        public Course(string name)
        {
            CourseName = name;
        }
        
        public void ListStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine("Student name is: {0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
