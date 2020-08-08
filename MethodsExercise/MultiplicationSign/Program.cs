using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secodNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Sign(firstNumber, secodNumber, thirdNumber);

        }
        public static void Sign(int a,int b,int c)
        {
            if (a == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            else if (b == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            else if(c==0)
            {
                Console.WriteLine("zero");
                return;
            }
            int flag = 0;
            if (a < 0 && b > 0 && c > 0) 
            {
                flag = 0;
            }
            else if(b < 0 && a > 0 && c > 0)
            {
                flag = 0;
            }
            else if (c < 0 && b > 0 && a > 0)
            {
                flag = 0;
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                flag = 1;
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                flag = 0;
            }
            else if (a < 0 && b < 0 || a < 0 && c < 0 || b < 0 && c < 0)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }



        }
    }
}
