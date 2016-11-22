using System;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetUprogramInformation();
            GetDegreeInformation();
            GetCourseInformation();

            ValidateStudentBirthdat("04/23/1986");
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate");
            string birthdate = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, birthdate);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the Teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's birthdate");
            string birthdate = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, birthdate);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetUprogramInformation()
        {
            Console.WriteLine("Enter the UProgram name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the department head name");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the offered degrees");
            string degrees = Console.ReadLine();
            PrintProgramDetails(programName, departmentHead, degrees);
        }

        static void PrintProgramDetails(string programName, string departmentHead, string degrees)
        {
            Console.WriteLine("Program {0} head by {1} degree offered: {2}", programName, departmentHead, degrees);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter required credits");
            string creditsStr = Console.ReadLine();
            int credits = 0;
            try
            {
                credits = int.Parse(creditsStr);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Credit format is invalid. Must be numerical.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error occured");
            }

            PrintDegreeDetails(degreeName, credits);
        }

        static void PrintDegreeDetails(string degreeName, int credits)
        {
            Console.WriteLine("Degree {0} required credits: {1}", degreeName, credits);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter awarded credits");
            string creditsStr = Console.ReadLine();
            int credits = 0;
            try
            {
                credits = int.Parse(creditsStr);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Credit format is invalid. Must be numerical.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error occured");
            }
            Console.WriteLine("Enter the weeks duration: ");
            string durationInWeeksStr = Console.ReadLine();
            int durationInWeeks = 0;
            try
            {
                durationInWeeks = int.Parse(durationInWeeksStr);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Duration in week format is invalid. Must be numerical.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error occured");
            }

            PrintCourseDetails(courseName, credits, durationInWeeks);
        }

        static void PrintCourseDetails(string courseName, int credits, int durationInWeeks)
        {
            Console.WriteLine("Course {0}: award {1} credits and have duration of {2} weeks", courseName, credits, durationInWeeks);
        }

        static void ValidateStudentBirthdat(string birthday)
        {
            throw new NotImplementedException();
        }
    }
}
