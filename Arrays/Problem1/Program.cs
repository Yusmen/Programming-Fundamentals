using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            string[] weekDay =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
             
            };
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
Console.WriteLine(weekDay[number-1]);
            }
            

           




        }
    }
}
