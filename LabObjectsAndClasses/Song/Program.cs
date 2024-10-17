using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal BoxPrice
    {
        get
        {
            return ItemQuantity * Item.Price;
        }
    }
}

public class Program
{
    public static void Main()
    {
        List<Box> boxes = new List<Box>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] parts = input.Split(' ');
            string serialNumber = parts[0];
            string itemName = parts[1];
            int itemQuantity = int.Parse(parts[2]);
            decimal itemPrice = decimal.Parse(parts[3]);

            Item item = new Item { Name = itemName, Price = itemPrice };
            Box box = new Box
            {
                SerialNumber = serialNumber,
                Item = item,
                ItemQuantity = itemQuantity
            };

            boxes.Add(box);
        }

        var sortedBoxes = boxes.OrderByDescending(b => b.BoxPrice);

        foreach (var box in sortedBoxes)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:F2}");
        }
    }
}
