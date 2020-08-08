using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "exam finished")
                {
                    break;
                }

                string[] tokens = line.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string language = tokens[1];
                int points = int.Parse(tokens[2]);
                if (results.ContainsKey(username))
                {
                    results[username].Add(points);
                }
                else
                {
                    results[username] = new List<int>();
                    results[username].Add(points);
                }
                if (submissions.ContainsKey(language))
                {
                    submissions[language]++;

                }
                else
                {
                    submissions.Add(language, 1);
                }
            }

         
        
            Console.WriteLine();
            Console.WriteLine("Results: ");
            foreach (var user in results.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)) 
            {

                string username = user.Key;
                List<int> points = user.Value;
                int n = points.Max();

               
                Console.WriteLine($"{username} | {n}");

                
            }
            Console.WriteLine();
            Console.WriteLine("Submissions: ");
            foreach (var submission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) 
            {
                string language = submission.Key;
                int count = submission.Value;
                
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
