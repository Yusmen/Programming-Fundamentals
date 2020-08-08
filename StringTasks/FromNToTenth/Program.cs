using System;
using System.Linq;

namespace FromNToTenth
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int system = parameters[0];
            int number = parameters[1];

            int sum = 0;
            int index = 0;
            while (number!=0)
            {
                sum += number % 10 *(int)Math.Pow(system, index);
                number /= 10;
                index++;
            }

            Console.WriteLine(sum);
          
        }
    }
}
