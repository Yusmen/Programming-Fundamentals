using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
            int a = 5;int b = 10;

            PrintSomething(a, b);
            

        }
        public static int  PrintSomething(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a) 
            {
                return b;
            }
        }
    }
}
