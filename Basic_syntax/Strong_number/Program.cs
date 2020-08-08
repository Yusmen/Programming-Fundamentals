using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int realnumber = int.Parse(Console.ReadLine());
            int number = realnumber;
            int a = 0;
            int pr = 1;
            int sum = 0;
            while (number != 0) 
            {
                pr = 1;
                a = number % 10;
                for (int i = 1; i <= a; i++) 
                {
                    pr = pr * i;
                }
                sum += pr;
                number = number / 10;
            }
            
            if (sum == realnumber) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
                    
        }
    }
}
