using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            switch(command)
            {
                case "add":PrintAdd(firstNumber, secondNumber);break;
                case "subtract": PrintSubstract(firstNumber, secondNumber); break;
                case "divide": PrintDivide(firstNumber, secondNumber); break;
                case "multiply": PrintMultiply(firstNumber, secondNumber); break;
                   




            }


        }
        public static void PrintAdd(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void PrintMultiply(int a,int b)
        {
            Console.WriteLine(a * b);
        }
        public static void PrintSubstract(int first,int second)
        {
            Console.WriteLine(first - second);
        }
        public static void PrintDivide(int a,int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
