using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurenses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach(var word in words)
            {
                string wordInLower = word.ToLower();
                if (counts.ContainsKey(wordInLower))
                {
                    counts[wordInLower]++;
                }
                else
                {
                    counts[wordInLower] = 1;
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }


        }
    }
}
