using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesaCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int symbol = (int)text[i] + 3;
                newText += (char)symbol;

            }
            Console.WriteLine(newText);
        }
    }
}
