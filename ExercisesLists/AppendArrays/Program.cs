using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
           char[] symbols = {'|'};
           List<string> numbers = Console.ReadLine().Split(symbols,StringSplitOptions.RemoveEmptyEntries).ToList();
            

            for (int i = numbers.Count - 1; i >=0; i--)
            {
                string line = numbers[i];
                line = line.Replace(" ", string.Empty);

                for (int j = 0; j < line.Length; j++) 
                {
                    
                    Console.Write(line[j] + " ");
                }
            }

        }
    }
}