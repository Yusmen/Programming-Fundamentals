using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string result = string.Empty;
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                for (int i = line.Length - 1; i >= 0; i--) 
                {
                    result += line[i];
                   
                }


                Console.WriteLine($"{line} = {result}");
                    
                        
            }
        }
    }
}
