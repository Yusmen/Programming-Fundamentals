using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = 0;
            for (int i = 0; i < text.Length - 1; i++) 
            {
                if (text[i] == text[i + 1])
                {

                    repeat++;
                    
                }
               else if (repeat != 0) 
                {
                    text = text.Remove(i - repeat, repeat);
                    i = i - repeat;
                    repeat = 0;
                    
                }
               
            }
              repeat = 0;
             text =string.Join("", text.ToCharArray().Reverse());
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {

                    repeat++;

                }
                else if (repeat != 0)
                {
                    text = text.Remove(i - repeat, repeat);
                    i = i - repeat;
                    repeat = 0;

                }

            }
            text = string.Join("", text.ToCharArray().Reverse());
            Console.WriteLine(text);
          
        }
    }
}
