using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
           line = line.ToLower();
            Console.WriteLine(CountVowels(line));
        }
        public static int CountVowels(string line)
        {
            int br = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i]=='a'|| line[i] == 'o'|| line[i] == 'u'||line[i] == 'e'|| line[i] == 'i')
                {
                    br++;
                }
            }
            return br;
        }
    }
}
