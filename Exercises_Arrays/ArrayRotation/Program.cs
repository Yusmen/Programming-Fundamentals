using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int n = numbers.Length;
            for (int j = 0; j < rotations; j++)
            {
               int firstnumber = numbers[0];
                for (int i = 0; i < numbers.Length - 1; i++) 
                {

                    numbers[i] = numbers[i + 1];
                   
                }
                numbers[n - 1] = firstnumber;

            }
            


            Console.WriteLine(string.Join(" ", numbers));
            

        }
    }
}
