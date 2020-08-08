using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split();
            var counts = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (!counts.ContainsKey(word[j]))
                    {
                        counts[word[j]] = 1;
                    }
                    else
                    {
                        counts[word[j]]++;
                    }
                }
                    
                        
            }
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


        }
    }
}
