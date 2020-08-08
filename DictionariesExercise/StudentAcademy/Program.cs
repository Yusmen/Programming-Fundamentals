using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            var studentsAverage = new Dictionary<string, double>();
            for (int i = 0; i < n; i++) 
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();

                }
                students[name].Add(grade);
                    
            }
            foreach (var kvp in students)
            {
                string name = kvp.Key;
                List<double> grades = kvp.Value;
                double sum = 0;
                for (int i = 0; i < grades.Count; i++)
                {
                    sum += grades[i];
                }
                double result = sum / grades.Count;
                if (result >= 4.50)
                {
                    studentsAverage[name] = result;
                }
                    
            }
            var sorted = studentsAverage.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }

        }
    }
}
