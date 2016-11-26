using System;
using System.Collections;

namespace Module_7
{
    public class Course
    {
        private int firstAvailableIndexInStudents = 0;
        private int firstAvailableIndexInTeachers = 0;
        private ArrayList students = new ArrayList();
        private Teacher[] teachers = new Teacher[3];
        private string courseName;
        private int credits;
        private int durationInWeeks;

        public ArrayList Students { get { return students; } }

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

        public Course()
        { }
        
        public void AddTeacher(Teacher teacher)
        {
            if (firstAvailableIndexInTeachers == (teachers.Length - 1))
            {
                return;
            }
            teachers[firstAvailableIndexInTeachers] = teacher;
            firstAvailableIndexInTeachers++;
        }

        public int NumOfStudents { get { return students.Count; } }

        public void ListStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine("Student name is: {0} {1}", (student as Student).FirstName, (student as Student).LastName);
            }
        }
    }
}
