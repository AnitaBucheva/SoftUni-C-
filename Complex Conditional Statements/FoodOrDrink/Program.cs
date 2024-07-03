using System;

class Program
{
    static void Main()
    {
        // Read the product from the console
    
        string product = Console.ReadLine().ToLower();

        // Determine and print the type of the product
        if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
        {
            Console.WriteLine("food");
        }
        else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
        {
            Console.WriteLine("drink");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
