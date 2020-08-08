using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(SumDvisibleByEight(i)&&HoldsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            int currentNumber = number;
            while (currentNumber > 0)
            {
                int a = currentNumber % 10;
                sum += a;
                currentNumber /= 10;
            }
            return sum;
        }
        public static bool SumDvisibleByEight(int number)
        {
            int sum = SumOfDigits(number);
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public static bool HoldsOddDigit(int number)
        {
            int flag = 0;
            int currentNumber = number;
            while (currentNumber > 0)
            {
                int a = currentNumber % 10;
                if (a % 2 != 0)
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
                currentNumber /= 10;


            }
            if(flag==1)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
