using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace StoreBoxes
{

    class Box
    {

        public string serialnumber { get; set; }
        public Item Item { get; set; }
        public int quantity { get; set; }
        public double PriceBox { get; set; }



    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split(' ');
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3],CultureInfo.InvariantCulture);
                Box box = new Box();
                {
                    box.serialnumber = serialNumber;
                    box.quantity = itemQuantity;
                    box.PriceBox = itemQuantity * itemPrice;

                }
                box.Item = new Item();
                {
                    box.Item.Name = itemName;
                    box.Item.Price = itemPrice;
                }

                boxes.Add(box);
                
            }


            foreach (var box in boxes)
            {
                Console.WriteLine(box.serialnumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
                
            }

           
        }
    }
}
