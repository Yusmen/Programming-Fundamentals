using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFinder
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string line = Console.ReadLine();
                if(line=="END")
                {
                    break;
                }
                bool isboolean = bool.TryParse(line, out bool boolean);
                bool isInteger = int.TryParse(line, out int integer);
                bool isdouble = double.TryParse(line, out double floatingPoint);
                bool ischaracter = char.TryParse(line, out char character);
                if(isboolean)
                {
                    Console.WriteLine($"{boolean} is boolean type");
                }
                else if(isInteger)
                {
                    Console.WriteLine($"{integer} is integer type");

                }
                else if(isdouble)
                {
                    Console.WriteLine($"{floatingPoint} is floating point type");
                }
                else if(ischaracter)
                {
                    Console.WriteLine($"{character} is character type");
                }
                else
                {
                    Console.WriteLine($"{line} is string type");
                }
                        
            }
        }
    }
}
