using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
           int number = Math.Abs(firstnumber);
            

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));


        }
        public  static int GetSumOfEvenDigits(int number)
        {
            
            int currentNumber = number;
            int sum = 0;
            while(currentNumber!=0)
            {
                int a = currentNumber % 10;
                if (a % 2 == 0) 
                {
                    sum += a;
                }
                currentNumber = currentNumber / 10;
            }
            return sum;
        }
        public static int GetSumOfÓddDigits(int number)
        {
            int currentNumber = number;
            int sum = 0;
            while (currentNumber != 0)
            {
                int a = currentNumber % 10;
                if (a % 2 != 0)
                {
                    sum += a;
                }
                currentNumber = currentNumber / 10;
            }
            return sum;
        }
         public static int GetMultipleOfEvenAndOdds(int number)
        {
            int a = GetSumOfEvenDigits(number);
            int b = GetSumOfÓddDigits(number);
            return a * b;

        }
    }
}
