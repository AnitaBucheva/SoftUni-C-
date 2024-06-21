using System;

class Program
{
    static void Main()
    {
        // Read ticket type from the console
        string ticketType = Console.ReadLine();

        // Define ticket prices
        double studentPrice = 1.00;
        double regularPrice = 1.60;

        // Check the ticket type and print the corresponding price
        switch (ticketType.ToLower())
        {
            case "student":
                Console.WriteLine($"${studentPrice:F2}");
                break;
            case "regular":
                Console.WriteLine($"${regularPrice:F2}");
                break;
            default:
                Console.WriteLine("Invalid ticket type!");
                break;
        }
    }
}
