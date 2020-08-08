using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var jewellery = new Dictionary<string, int>();

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                if (!jewellery.ContainsKey(word))
                {
                    jewellery[word] = quantity;
                }
                else
                {
                    jewellery[word] += quantity;
                }
            }

            foreach (var kvp in jewellery)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
