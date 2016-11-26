using System;

namespace Module_6
{
    public class Course
    {
        private int firstAvailableIndexInStudents = 0;
        private int firstAvailableIndexInTeachers = 0;
        private Student[] students = new Student[3];
        private Teacher[] teachers = new Teacher[3];
        private string courseName;
        private int credits;
        private int durationInWeeks;

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

        public void AddStudent(Student student)
        {
            if (firstAvailableIndexInStudents == (students.Length - 1))
            {
                return;
            }
            students[firstAvailableIndexInStudents] = student;
            firstAvailableIndexInStudents++;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (firstAvailableIndexInTeachers == (teachers.Length - 1))
            {
                return;
            }
            teachers[firstAvailableIndexInTeachers] = teacher;
            firstAvailableIndexInTeachers++;
        }

        public int NumOfStudents { get { return students.Length; } }
    }
}
