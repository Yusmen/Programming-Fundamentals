using System;
using System.Linq;

namespace NakovGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            double sum = 0;
            double resultSum = 0;
            foreach (var item in strings)
            {
                string number = item.Substring(1, item.Length - 2);
                int parsedNumber = int.Parse(number);
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                if (Char.IsUpper(firstLetter))
                {
                    int position = (int)firstLetter - 64;
                    sum += (double)parsedNumber / (double)position;

                }
                else if (Char.IsLower(firstLetter))
                {
                    int position = (int)firstLetter - 96;
                    sum += parsedNumber * position;
                }
                if (Char.IsUpper(lastLetter))
                {
                    int position = (int)lastLetter - 64;
                    sum -= position;

                }
                else if (Char.IsLower(lastLetter))
                {
                    int position = (int)lastLetter - 96;
                    sum += position;
                }

                resultSum += sum;
                sum = 0;

            }
            

            Console.WriteLine($"{resultSum:f2}");

        }
    }
}
