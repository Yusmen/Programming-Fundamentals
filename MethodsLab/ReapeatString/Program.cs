using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReapeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStirng(line, n));

        }
        public static string RepeatStirng(string str,int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
