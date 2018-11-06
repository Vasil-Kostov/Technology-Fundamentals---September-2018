namespace _07._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArr = input.Split();

                boxes.Add(new Box(inputArr));

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(b => b.PriceForABox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.CurrentBoxItem.Name} - ${box.CurrentBoxItem.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public decimal PriceForABox { get; set; }
        public Item CurrentBoxItem { get; set; }
        public int ItemQuantity { get; set; }

        public Box(string[] boxInfo)
        {
            this.SerialNumber = boxInfo[0];
            this.ItemQuantity = int.Parse(boxInfo[2]);

            string itemName = boxInfo[1];
            decimal itemPrice = decimal.Parse(boxInfo[3]);

            this.CurrentBoxItem = new Item(itemName, itemPrice);

            this.PriceForABox = ItemQuantity * CurrentBoxItem.Price;
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
