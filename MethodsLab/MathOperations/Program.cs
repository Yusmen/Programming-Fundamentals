using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            switch(command)
            {
                case "+":Console.WriteLine(Add(firstNumber, secondNumber));break;
                case "-": Console.WriteLine(Subtract(firstNumber, secondNumber)); break;
                case "*": Console.WriteLine(Multiply(firstNumber, secondNumber)); break;
                case "/": Console.WriteLine(Divide(firstNumber, secondNumber)); break;
            }

        }
        public static double Add(double a,double b)
        {
            return a + b;
        }
        public static double Subtract(double a,double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;

        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
