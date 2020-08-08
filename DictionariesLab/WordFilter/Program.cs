using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
            .Split()
            .Where(x => x.Length % 2 == 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x));


        
        }
    }
}
