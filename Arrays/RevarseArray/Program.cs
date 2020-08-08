using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevarseArray
{
    class Program
    {
        static void Main()
        {
            string[] texts = Console.ReadLine().Split();
            for (int i = 0; i < texts.Length / 2; i++)
            {
                string firstText=texts[i];
                texts[i] = texts[texts.Length - 1 - i];
                texts[texts.Length - 1 - i] = firstText;
                

            }
            Console.WriteLine(string.Join(" ", texts));

            

        }
    }
}
