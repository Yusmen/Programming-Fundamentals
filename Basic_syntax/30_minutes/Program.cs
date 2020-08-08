using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            if (mins + 30 > 59)
            {
                if(hours==23)
                {

                    if (mins - 30 < 10)
                    {
                        Console.WriteLine($"0:0{mins - 30}");
                    }
                    else
                    {
                        Console.WriteLine($"0:{mins - 30}");
                    }

                }
                else
                {
                    if (mins - 30 < 10)
                    {
                        Console.WriteLine($"{hours + 1}:0{mins - 30}");
                    }
                    else
                    {
                        Console.WriteLine($"{hours + 1}:{mins - 30}");
                    }
                }
               
                
            }
            else
            {
                Console.WriteLine($"{hours}:{mins + 30}");
            }
        }
    }
}
