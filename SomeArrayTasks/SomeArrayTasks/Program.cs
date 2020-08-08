using System;
using System.Linq;

namespace SomeArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string line =Console.ReadLine();

            var arr = line.Split("");  



            Console.WriteLine(string.Join("  ",arr));
        }
    }
}
