using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallalestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(MaxThreeNumbers(firstNumber, secondNumber, thirdNumber));


        }
        public static int MaxThreeNumbers(int a,int b,int c)
        {
            int min = int.MaxValue;
            if (a < min)
            {
                min = a;
            }
             if (b < min)
            {
                min = b;
            }
             if (c < min)
            {
                min = c;
            }
            return min;

        }
    }
}
