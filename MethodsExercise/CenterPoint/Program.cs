using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
           
            
           
            PrintPoint(x1, y1, x2, y2);



        }
        public static double AbsoluteValue(double number)
        {
            double result = 0;
            result = Math.Abs(number);
            return number;
          
        }
        public static void PrintPoint(int x1,int y1,int x2,int y2)
        {
            int a = x1;
            int b = y1;
            int c = x2;
            int d = y2;
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            d = Math.Abs(d);
            int firstDifference = Math.Abs(a - b);
            int seconddifference = Math.Abs(c - d);
            if(firstDifference<=seconddifference)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if(seconddifference<firstDifference)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            
        }
    }
}
