using System;

namespace Module_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            string lastName = "Jordan";
            DateTime birthDate = new DateTime(1963, 2, 17);
            string addressLine1 = "1901 West Madison Street";
            string addressLine2 = "United Center";
            string city = "Chicago";
            string state_province = "Illinois";
            int zip_postal = 60290;
            string country = "U.S.A.";
            //Print all these informations
            Console.WriteLine(string.Format("First Name: {0}", firstName));
            Console.WriteLine(string.Format("Last Name: {0}", lastName));
            Console.WriteLine(string.Format("Birthdate: {0}", birthDate.ToString("yyyy/MM/dd")));
            Console.WriteLine(string.Format("Address Line 1: {0}", addressLine1));
            Console.WriteLine(string.Format("Address Line 2: {0}", addressLine2));
            Console.WriteLine(string.Format("City: {0}", city));
            Console.WriteLine(string.Format("State/Province: {0}", state_province));
            Console.WriteLine(string.Format("Zip/Postal: {0}", zip_postal));
            Console.WriteLine(string.Format("Country: {0}", country));
        }
    }
}
