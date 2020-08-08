using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
           
            if(n==1)
            {
                Console.Write(1+" ");
                Console.WriteLine();
            }
            else if(n==2)
            {
                Console.Write(1 + " ");
                Console.Write(1 + " ");
                Console.WriteLine();
            }
            else
            {
                PrintTribonachi(arr, n);

            }
            

        }
        public static void PrintTribonachi(int[] arr,int n)
        {
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            Console.Write(arr[0] + " ");
            Console.Write(arr[1] + " ");
            Console.Write(arr[2] + " ");

            for (int i = 3; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
        
        }
    }
}
