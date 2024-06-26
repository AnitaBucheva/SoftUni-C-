using System;

namespace ProductSignCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read 3 real numbers from the console
            double number1 = ReadDouble();

  
            double number2 = ReadDouble();

        
            double number3 = ReadDouble();

            // Determine the sign of the product
            string result = DetermineProductSign(number1, number2, number3);

            // Print the result
            Console.WriteLine($"{result}");
        }

        static double ReadDouble()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }

        static string DetermineProductSign(double num1, double num2, double num3)
        {
            // If any number is zero, the product is zero
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return "zero";
            }

            // Count the number of negative numbers
            int negativeCount = 0;

            if (num1 < 0) negativeCount++;
            if (num2 < 0) negativeCount++;
            if (num3 < 0) negativeCount++;

            // If the number of negative numbers is odd, the product is negative
            if (negativeCount % 2 != 0)
            {
                return "negative";
            }

            // If the number of negative numbers is even, the product is positive
            return "positive";
        }
    }
}
