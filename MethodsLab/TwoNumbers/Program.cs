using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    PrintInteger(a, b);break;
                case "char":
                    char first = char.Parse(Console.ReadLine());
                    char second = char.Parse(Console.ReadLine());
                   Console.WriteLine( PrinCharacter(first, second)); break;
                case "string":
                    string firstNumber = Console.ReadLine();
                    string secondNumber =Console.ReadLine();
                    Console.WriteLine(PrintString(firstNumber, secondNumber)); break;


            }
        }
        public static void PrintInteger(int a,int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if(b>a)
            {
                Console.WriteLine(b);
            }
            
        }
        public static string PrintString(string a,string b)
        {
            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static char PrinCharacter(char a,char b)
        {
            if(a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        
    }
}
