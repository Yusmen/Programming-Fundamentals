using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());



        }
        public static int Kvadrant(int a,int b)
        {
            if (a > 0 && b > 0)
            {
                return 1;
            }
            else if (a < 0 && b > 0)
            {
                return 2;
            }
            else if (a < 0 && b < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
            
        }
        public static void LongerLine(int x1,int y1,int x2,
            int y2,int x3,int y3,int x4,int y4)
        {
            int 
            int a= Kvadrant(x1, y1);
            int b= Kvadrant(x2, y2);
            int c= Kvadrant(x3, y3);
            int d = Kvadrant(x4, y4);
            if (a == 1 && b == 4 && c == 2 && d == 2)
            {

            }

        }
    }
}
