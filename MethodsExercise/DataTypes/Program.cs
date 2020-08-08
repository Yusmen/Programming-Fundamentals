using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "int":int number = int.Parse(Console.ReadLine());Console.WriteLine(PrintResult(number)); break;
                case "real":double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{PrintResult(realNumber):f2}");break;
                case "string": string line = Console.ReadLine();
                    Console.WriteLine(PrintResult(line));break;
            }


        }
        public static int PrintResult(int number)
        {
            return number * 2;
        }
        public static double PrintResult(double number)
        {
            return number * 1.5;
        }
        public static string PrintResult(string line)
        {
            line = "$" + line + "$";
            return line;
        }
            
    }
}
