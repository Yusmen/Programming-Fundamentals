using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRain
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
               
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(passengers[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
           


        }
    }
}
