using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
       

            
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (i == numbers.Length - 1)
                {
                    
                    Console.Write(numbers[numbers.Length - 1]+ " ");
                    break;
                }

                if (numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                   
                    
                }
              
                
            }
           
                    


        }
    }
}
