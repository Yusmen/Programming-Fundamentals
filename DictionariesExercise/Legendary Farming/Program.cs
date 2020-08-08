using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterial = new Dictionary<string, int>();
            keyMaterial["shards"] = 0;
            keyMaterial["motes"] = 0;
            keyMaterial["fragments"] = 0;
            var junkMaterial = new Dictionary<string, int>();
            while (true)
            {
                int flag = 0;
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i+1].ToLower();
                    if (material == "shards")
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] > 250)
                        {

                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterial[material] -= 250;
                            flag = 1;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] > 250)
                        {

                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterial[material] -= 250;
                            flag = 1;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] > 250)
                        {

                            Console.WriteLine("Valanyr obtained!");
                            keyMaterial[material] -= 250;
                            flag = 1;
                            break;
                        }
                    }
                    else
                    {
                        if(!junkMaterial.ContainsKey(material))
                        {
                            junkMaterial[material] = quantity;
                        }
                        else
                        {
                            junkMaterial[material] += quantity;
                        }
                        
                    }


                }
                if (flag == 1)
                {
                    break;
                }
            }

            Dictionary<string, int> sortedKey = keyMaterial
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach(var kvp in sortedKey)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterial.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
              
            
        }
    }
}
