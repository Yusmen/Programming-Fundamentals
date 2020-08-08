using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReavarseOrder
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i <= n-1; i++) 
            {

                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= ; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
