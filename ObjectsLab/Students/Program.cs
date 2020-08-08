using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string hometown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string firstname = tokens[0];
                string lastname = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];

                if(IsExisting(students,firstname,lastname))
                {
                   
                    Student student = GetStudent(students, firstname, lastname);
                    student.firstName = firstname;
                    student.lastName = lastname;
                    student.Age = age;
                    student.hometown = hometown;
                }
                else
                {
                    Student student = new Student();
                    {
                        student.firstName = firstname;
                        student.lastName = lastname;
                        student.Age = age;
                        student.hometown = hometown;
                    }
                    students.Add(student);
                }
                
                
                
            }
            string city = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.hometown == city)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.Age} years old.");
                }
            }

        }

        private static Student GetStudent(List<Student> students, string firstname, string lastname)
        {
            Student existingstudent = null;

            foreach (var student in students)
            {
                if (student.firstName == firstname && student.lastName == lastname)
                {
                    existingstudent = student;
                }
            }
            return existingstudent;
  
        }

        private static bool IsExisting(List<Student> students, string firstname, string lastname)
        {
            foreach (var student in students)
            {
                if (student.firstName == firstname && student.lastName == lastname)
                {
                    return true;
                }
                
                    
            }
            return false;
        }
    }
}
