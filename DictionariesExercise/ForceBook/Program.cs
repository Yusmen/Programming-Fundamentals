using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceBook = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] tokens = new string[0];
                if (input.Contains("|")) 
                {
                    string[] symbols = {" | "};
                    tokens = input.Split(symbols,StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[0];
                    string name = tokens[1];
                    if (forceBook.ContainsKey(name) == false)
                    {
                        forceBook[name] = side;
                    }
                  

                }
                else
                {
                    string[] symbols = { " -> " };
                    tokens = input.Split(symbols,StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    string side = tokens[1];
                    if (forceBook.ContainsKey(name))
                    {
                        forceBook[name] = side;
                    }
                    else
                    {
                        forceBook[name] = side;
                    }

                    Console.WriteLine($"{name} joins the {side} side!");
                }
                    
                    
            }
            var filtered = forceBook
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);
      
            foreach (var kvp in filtered) 
            {
                string side = kvp.Key;
               var nameSideValue = kvp;
                Console.WriteLine($"Side: {side}, Members: {nameSideValue.Count()}");
                foreach (var kvpValue in nameSideValue.OrderBy(x=>x.Key))
                {
                    string name = kvpValue.Key;
                    string side2 = kvpValue.Value;
                    Console.WriteLine($"! {name}");
                }
            }

        }
    }
}
