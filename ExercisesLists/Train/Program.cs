using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    passengers.Add(numberToAdd);
                }
                else
                {
                    int numberToFit = int.Parse(tokens[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        int addResult = numberToFit + passengers[i];
                        if (addResult <=maxCapacity)
                        {
                            passengers[i] += numberToFit;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", passengers));


        }
    }
}
