using System;

namespace Module_7
{
    public class Degree
    {
        private string name;
        private int creditsRequired;
        private Course course;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int CreditsRequired
        {
            get
            {
                return creditsRequired;
            }

            set
            {
                creditsRequired = value;
            }
        }

        public Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public Degree() { }

        public Degree(string name)
        {
            Name = name;
        }

        public void AddCourse(Course course)
        {
            Course = course;
        }
    }
}
