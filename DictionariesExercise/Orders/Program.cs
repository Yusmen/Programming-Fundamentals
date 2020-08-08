using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> productsQuantity = new Dictionary<string, int>();
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] tokens = input.Split();
                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                int quantity = int.Parse(tokens[2]);
             
                if (productsPrice.ContainsKey(product) == false)
                {
                    productsQuantity[product] = quantity;
                }
                else
                {
                    productsQuantity[product] += quantity;
                }
                productsPrice[product] = price;




            }
            foreach (var kvp in productsQuantity)
            {
                string product = kvp.Key;
                int quantity = kvp.Value;
                decimal price = productsPrice[product];

                Console.WriteLine($"{product} -> {price * quantity}");
            }

        }
    }
}
