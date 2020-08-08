using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Middle(line);

        }
        public static void Middle(string line)
        {
            int index = 0;
            double x = line.Length / 2;
            if (line.Length % 2 != 0)
            {
                double n = Math.Ceiling(x);
                 index = Convert.ToInt32(n);
                Console.WriteLine(line[index]);
            }
            else
            {
                Console.Write(line[line.Length / 2 - 1]);
                Console.Write(line[line.Length / 2]);
            }
                
            
        }
        
    }
}
