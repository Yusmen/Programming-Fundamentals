using System;
using System.Linq;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string line = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < line.Length; i++)
            {
                if (!Char.IsNumber(line[i]))
                {
                    result += line[i];
                }
                else if(Char.IsNumber(line[i]))
                {
                    string numbers = string.Empty;
                    int j = i;
                    int count = -1;
                    
                    while(Char.IsNumber(line[j]))
                    {
                        numbers += line[j];
                        if (j == line.Length - 1)
                        {
                            result += numbers;
                            Console.WriteLine(result);
                            return;
                        }
                        j++;
                       
                        count++;
                    }
                   
                    i += count;
                    result +=line[j];
                }
            }
           

            Console.WriteLine(result);
        }
    }
}
