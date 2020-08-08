using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b > 10) 
            {
                Console.WriteLine($"{a} X {b} = {a * b}");
                
            }
            else
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{a} X {i} = {a * i}");
                }
            }
                  
        }
    }
}
