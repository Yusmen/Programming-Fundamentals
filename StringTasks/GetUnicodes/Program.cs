using System;
using System.Text;

namespace GetUnicodes
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string line = Console.ReadLine();


            foreach (var item in line)
            {
                sb.Append("\\u" + ((int)item).ToString("X4"));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
