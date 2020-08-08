using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }
        public static void PrintLine(int start,int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write(i + " ");
            }
              Console.WriteLine();
                
                  
        }
        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
            for (int j = n-1; j >=1 ; j--)
            {
                PrintLine(1, j);
            }
        }
    }
}
