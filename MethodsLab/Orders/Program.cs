using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());

           

            switch (product)
            {
                case "coffee":Callculation(n, 1.50);break;
                case "water":Callculation(n, 1.00);break;
                case "coke": Callculation(n, 1.40); break;
                case "snacks": Callculation(n, 2.00); break;

            }
            
        }
        public static void Callculation(double n,double a)
        {
            double x = n * a;
            Console.WriteLine($"{x:f2}");
        }
    }
}
