using System;

class Program
{
    static void Main()
    {
        // Read the type of the movie from the console
        
        string movieType = Console.ReadLine();

        // Read the count of rows from the console

        int rows = int.Parse(Console.ReadLine());

        // Read the count of seats per row from the console
        
        int seatsPerRow = int.Parse(Console.ReadLine());

        // Define the ticket prices based on the type of the movie
        double pricePerTicket = 0;

        switch (movieType)
        {
            case "Premiere":
                pricePerTicket = 12.00;
                break;
            case "Normal":
                pricePerTicket = 7.50;
                break;
            case "Discount":
                pricePerTicket = 5.00;
                break;
            default:
                Console.WriteLine("Invalid movie type");
                return;
        }

        // Calculate the total price for all tickets
        double totalPrice = rows * seatsPerRow * pricePerTicket;

        // Print the total price formatted to the 2nd digit after the decimal point
        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}
