using System;
using System.Collections.Generic;
using System.Windows;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private int currentStudentIndex = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var stud = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(stud);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            currentStudentIndex = -1;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (currentStudentIndex > 0)
            {
                currentStudentIndex--;
                txtFirstName.Text = students[currentStudentIndex].FirstName;
                txtLastName.Text = students[currentStudentIndex].LastName;
                txtCity.Text = students[currentStudentIndex].City;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentStudentIndex < students.Count - 1)
            {
                currentStudentIndex++;
                txtFirstName.Text = students[currentStudentIndex].FirstName;
                txtLastName.Text = students[currentStudentIndex].LastName;
                txtCity.Text = students[currentStudentIndex].City;
            }
        }
    }

    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private string city;

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

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }
    }

    public class Student : Person
    {
        private Stack<string> grades = new Stack<string>();

        public Student(string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public Stack<string> Grades { get { return grades; } }
    }
}
