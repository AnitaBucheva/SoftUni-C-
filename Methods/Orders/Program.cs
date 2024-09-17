using System;

class Program
{
    static void Main()
    {
        // Read product name from console

        string product = Console.ReadLine();

        // Read quantity from console

        int quantity = int.Parse(Console.ReadLine());

        // Calculate total price
        double totalPrice = CalculateTotalPrice(product, quantity);

        // Print the result formatted to two decimal places
        Console.WriteLine($"{totalPrice:F2}");
    }

    static double CalculateTotalPrice(string product, int quantity)
    {
        // Define prices for each product
        double pricePerItem = 0;

        switch (product)
        {
            case "coffee":
                pricePerItem = 1.50;
                break;
            case "water":
                pricePerItem = 1.00;
                break;
            case "coke":
                pricePerItem = 1.40;
                break;
            case "snacks":
                pricePerItem = 2.00;
                break;
            default:
                Console.WriteLine("Invalid product entered.");
                break;
        }

        // Calculate total price
        double totalPrice = pricePerItem * quantity;
        return totalPrice;
    }
}
