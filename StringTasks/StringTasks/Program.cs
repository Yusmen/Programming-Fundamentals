using System;
using System.Linq;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {


            var parameters = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var system = parameters[0];
            var number = parameters[1];
            string result = string.Empty;

            while (number!=0)
            {
                result += number % system;
                number = number / system;

            }

            var endResult=result.ToCharArray();
            Array.Reverse(endResult);
            Console.WriteLine(endResult);
        }
    }
}
