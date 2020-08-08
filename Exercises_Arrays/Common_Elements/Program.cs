using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Elements
{
    class Program
    {
        static void Main()
        {
            string text1 = Console.ReadLine();
            string[] texts1 = text1.Split(' ');
            string text2= Console.ReadLine();
            string[] texts2 = text2.Split(' ');
    
            

            
            for (int i = 0; i < texts2.Length; i++)
            {
                for (int j = 0; j < texts1.Length; j++) 
                
                {
                    if (texts2[i] == texts1[j])
                    {
                        Console.Write(texts2[i]+ " ");
                    }
                }
            }
            Console.WriteLine();
      
        }
    }
}
