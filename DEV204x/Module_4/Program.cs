using System;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0].firstName = "John";
            students[0].lastName = "Doe";
            students[0].birthday = new DateTime(1986, 04, 23);
            students[0].addressLine1 = "Main street 1";
            students[0].addressLine2 = "Apartment 3";
            students[0].city = "New York";
            students[0].state = "New York State";
            students[0].zipCode = 10000;
            students[0].country = "U.S.A.";

            Console.WriteLine("Student Name: {0} {1}", students[0].firstName, students[0].lastName);
            Console.WriteLine("Student birthday: {0}", students[0].birthday.ToShortDateString());
            Console.WriteLine("Student address: {0} - {1}, {2}, {3}, {4}, {5}", students[0].addressLine1, students[0].addressLine2,
                                                                            students[0].city, students[0].state, students[0].zipCode, students[0].country);
        }

        public struct Student
        {
            public string firstName;
            public string lastName;
            public DateTime birthday;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string state;
            public int zipCode;
            public string country;
        }

        public struct Teacher
        {
            public string firstName;
            public string lastName;
            public DateTime birthday;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string state;
            public int zipCode;
            public string country;
        }

        public struct UProgram
        {
            public string programName;
            public string departmentHead;
            public string degrees;
        }

        public struct Course
        {
            public string courseName;
            public int credits;
            public int durationInWeeks;
            public string teacher;
        }
    }
}
