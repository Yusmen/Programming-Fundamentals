using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split(' ');
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2], CultureInfo.InvariantCulture);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);

            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach(var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
            

    }
    
}
