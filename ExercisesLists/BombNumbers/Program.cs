using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> theBomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = theBomb[0];
            int power = theBomb[1];
            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] == bombNumber)
                {
                    int startindex = i - power;
                    int endindex = i + power;
                    if (startindex < 0)
                    {
                        startindex = 0;
                    }
                    if (endindex > numbers.Count - 1)
                    {
                        endindex = numbers.Count - 1;
                    }
                    if (startindex > numbers.Count - 1 || endindex < 0)
                    {
                        continue;
                    }
                    numbers.RemoveRange(startindex, endindex - startindex + 1);
                    i = startindex - 1;
                 
                }

            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
                


        }
    }
}
