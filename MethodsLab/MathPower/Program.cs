using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
           // double basis = double.Parse(Console.ReadLine());
            //int degree = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintDegree(basis, degree));
            


        }
        public static double PrintDegree(double basis,int degree)
        {

            double result = 0;
            result = Math.Pow(basis, degree);
            return result;
        }
       
            
    }
          
            
            

    
}
