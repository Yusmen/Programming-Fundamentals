using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);

        }
    }
}
