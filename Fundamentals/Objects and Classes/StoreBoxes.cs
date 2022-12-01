using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ');

                string serialNumber = cmdArgs[0];
                string itemName = cmdArgs[1];
                int itemQuantity = int.Parse(cmdArgs[2]);
                decimal itemPrice = decimal.Parse(cmdArgs[3]);

                Item item = new Item(itemName, itemPrice);

                Box box = new Box(serialNumber, item, itemQuantity);
                
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(boxes => boxes.PriceForBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price) 
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
