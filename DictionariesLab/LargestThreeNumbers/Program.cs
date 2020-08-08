using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            if (numbers.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            

        }
    }
}
