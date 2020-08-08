using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualArraays
{
    class Program
    {
        static void Main()
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int flag = 0;
            int index = 0;
            int sum = 0;

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                if (firstNumbers[i] == secondNumbers[i])
                {
                    flag = 0;
                    sum += firstNumbers[i];
                }
                else
                {
                    flag = 1;
                    index = i;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
