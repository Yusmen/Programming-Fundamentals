using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var item in counts) 
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
