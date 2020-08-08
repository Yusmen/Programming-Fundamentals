using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorilaDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
           
            int a = Factoriel(first);
            int b = Factoriel(second);
            if (a > b)
            {
                Console.WriteLine($"{a / b:f2}");
            }
            else
            {
                Console.WriteLine($"{b / a:f2}");
            }

            int[] arr = new int[10];
         
            Array.Reverse(arr);
            
        }
        public static int Factoriel(int number)
        {
            int f = 1;
            for (int i = 1; i <= number; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
