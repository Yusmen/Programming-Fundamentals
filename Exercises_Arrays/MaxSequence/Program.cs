using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 1;
            int sequnceNumber = 0;
            int br = 1;

            for (int i = 0; i < numbers.Length- 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    br++;
                    if(br>max)
                    {
                        max = br;
                        sequnceNumber = numbers[i];
                    }
                }
                else
                {
                    br = 1;
                    

                }
               


            }
              
            for (int i = 0; i < max; i++)
            {
                Console.Write(sequnceNumber + " ");
            }



        }
    }
}
