using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = { ", " };
            string[] words = Console.ReadLine().Split(symbols,StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var word in words)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);


        }
    }
}
