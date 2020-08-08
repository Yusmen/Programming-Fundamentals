using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                {
                    words[word].Add(synonym);


                }
               


            }
            foreach (var worda in words)
            {
                Console.WriteLine($"{worda.Key} - {string.Join(", ", worda.Value)}");
            }
        }
    }
}
