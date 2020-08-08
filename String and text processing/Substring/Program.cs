using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);
            while (index != -1)
            {
                text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
            }
            Console.WriteLine(text);
            
        }
    }
}
