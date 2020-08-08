using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int br = 0;
            int a=0;
            a = n;
            while (a > m)
            {
               
                a = n - m;
                br++;
                if (a == n / 2)
                {
                    if (y != 0) 
                    {
                        a=a / y;
                    }
                }

            }
            Console.WriteLine(a);
            Console.WriteLine(br);
        }
    }
}
