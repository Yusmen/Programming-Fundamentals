using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int firstNumber = 0;
            
            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                firstNumber = numbers[i];
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(firstNumber+numbers[j]==number)
                    {
                        Console.Write(firstNumber + " ");
                        Console.Write(numbers[j] + " ");
                        Console.WriteLine();
                    }


                }
                
            }

        }
    }
}
