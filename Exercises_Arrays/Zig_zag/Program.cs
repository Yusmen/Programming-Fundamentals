using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_zag
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int[] firstarr = new int[n];
            int[] secondarr = new int[n];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            firstarr[0] = numbers[0];
            secondarr[0] = numbers[1];
            for (int i = 1; i < n; i++)
            {
                 numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    secondarr[i] = numbers[0];
                    firstarr[i] = numbers[1];
                    
                }
                else
                {
                    secondarr[i] = numbers[1];
                    firstarr[i] = numbers[0];
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(firstarr[j] + " ");
               
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write(secondarr[j] + " ");

            }
        }
    }
}
