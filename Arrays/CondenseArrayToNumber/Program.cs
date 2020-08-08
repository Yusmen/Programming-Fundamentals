using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];


            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = 0; j < condensed.Length - i; j++) 
                {
                    condensed[j] = numbers[j] + numbers[j + 1];


                }
                numbers = condensed;
            }
            Console.WriteLine(condensed[0]);
           
            
                
        }
    }
}
