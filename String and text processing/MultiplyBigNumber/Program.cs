using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string  firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());
            int onMind = 0;
            string resultNumber = string.Empty;

            string reversed = string.Join("", firstNumber.ToCharArray().Reverse());
            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                int firstDigit = int.Parse(reversed[i].ToString());
                int result = firstDigit * secondNumber+onMind;

                resultNumber += result % 10;
                onMind = result / 10;

                if (i == reversed.Length - 1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }
            string output = string.Join("", resultNumber.ToCharArray().Reverse());
            Console.WriteLine(output);
        }
    }
}
