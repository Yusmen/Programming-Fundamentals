using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> line = Console.ReadLine().Split().ToList();
            Console.WriteLine(line.Contains("a"));
        }
    }
}
