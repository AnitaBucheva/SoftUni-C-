using System;

class Program
{
    static void Main()
    {
        // Read figure type from the console
        string figureType = Console.ReadLine();

        // Declare variables for dimensions and area
        double dimension1, dimension2, area;

        // Calculate area based on figure type
        switch (figureType.ToLower())
        {
            case "square":
                dimension1 = double.Parse(Console.ReadLine());
                area = dimension1 * dimension1;
                break;
            case "rectangle":
                dimension1 = double.Parse(Console.ReadLine());
                dimension2 = double.Parse(Console.ReadLine());
                area = dimension1 * dimension2;
                break;
            case "circle":
                dimension1 = double.Parse(Console.ReadLine());
                area = Math.PI * dimension1 * dimension1;
                break;
            default:
                Console.WriteLine("Invalid figure type!");
                return;
        }

        // Print the calculated area formatted to the 2nd decimal place
        Console.WriteLine($"{area:F2}");
    }
}
