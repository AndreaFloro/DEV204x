using System;

namespace Module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();

            var course = new Course("Programming with C#");

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            var teacher = new Teacher();

            course.AddTeacher(teacher);

            var degree = new Degree("Bachelor");

            degree.AddCourse(course);

            var uprogram = new UProgram("Information Technology");

            uprogram.AddDegree(degree);

            Console.WriteLine("{0} program contains {1} degree\n", uprogram.ProgramName, uprogram.Degree.Name);

            Console.WriteLine("{0} degree contains the course {1}\n", uprogram.Degree.Name, uprogram.Degree.Course.CourseName);

            Console.WriteLine("{0} course contains {1} student(s)\n", uprogram.Degree.Course.CourseName, uprogram.Degree.Course.NumOfStudents);

            //Checking GradeTest() and TakeTest() methods
            Person personStudent = new Student();
            personStudent.FirstName = "Michael";
            personStudent.LastName = "Jordan";
            Person personTeacher = new Teacher();
            personTeacher.FirstName = "Phil";
            personTeacher.LastName = "Jackson";

            (personStudent as Student).TakeTest();

            (personTeacher as Teacher).GradeTest();
        }
    }
}
