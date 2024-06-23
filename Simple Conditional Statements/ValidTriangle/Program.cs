using System;

class Program
{
    static void Main()
    {
        // Read sides of the triangle from the console
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());

        // Check if the triangle is valid
        bool isValidTriangle = (side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2);

        // Print the result
        if (isValidTriangle)
        {
            Console.WriteLine("Valid Triangle");
        }
        else
        {
            Console.WriteLine("Invalid Triangle");
        }
    }
}
