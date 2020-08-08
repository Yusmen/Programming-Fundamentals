using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                int number = int.Parse(line);
                int result = IsPalindrom(number);
                if(result==1)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                

            }
            
            
            
        }
        public static int Reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;

        }
        public static int IsPalindrom(int number)
        {
            int result = Reverse(number);
            if(number==result)
            {
                return 1;
            }
            else
            {
                return 0;
            }
         
        }
    }
}
