using System;

namespace ProductTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the product from the console
           
            string product = Console.ReadLine().ToLower();

            // Determine the type of the product
            string productType = DetermineProductType(product);

            // Print the result
            Console.WriteLine(productType);
        }

        static string DetermineProductType(string product)
        {
            // List of fruits
            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon" };

            // List of vegetables
            string[] vegetables = { "cucumber", "pepper", "carrot" };

            // Check if the product is a fruit
            if (Array.Exists(fruits, element => element == product))
            {
                return "fruit";
            }

            // Check if the product is a vegetable
            if (Array.Exists(vegetables, element => element == product))
            {
                return "vegetable";
            }

            // If the product is not found in the lists, return "unknown"
            return "unknown";
        }
    }
}
