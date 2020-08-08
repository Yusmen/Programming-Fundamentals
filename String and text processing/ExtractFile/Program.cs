using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path=Console.ReadLine().Split('\\');
            string file = path[path.Length - 1];
            string[] newfile = file.Split('.');
            Console.WriteLine($"File name: {newfile[0]}");
            Console.WriteLine($"File extension: {newfile[1]}");

        }
    }
}
