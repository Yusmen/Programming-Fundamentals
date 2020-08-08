using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.CSharp;
using System.Numerics;



namespace BigFactorilal
{

   
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <= number; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
            
        }
    }
}
