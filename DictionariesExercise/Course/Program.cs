using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
      
                string[] tokens = input.Split(':');
                string courseName = tokens[0];
                string studentName = tokens[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);
         
            }
            Dictionary<string, List<string>> sorted=courses.OrderByDescending(x=>x.Value.Count)
                .ToDictionary(x=>x.Key,x => x.Value );

            foreach (var kvp in sorted)
            {
                string course = kvp.Key;
                string courseName = course.TrimEnd();
                List<string> studentName = kvp.Value;
                studentName = studentName.OrderBy(x => x).ToList();
                int br = studentName.Count;
                Console.WriteLine($"{courseName}: {br}");

                foreach(var name in studentName)
                {

                    Console.WriteLine("-" + "-" + name);
                 
                }
               
            }
        }
    }
}
