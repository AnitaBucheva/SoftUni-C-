using System;

namespace NumberRangeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                // Prompt the user to enter a number
               
                // Read the user's input
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    // Check if the number is within the range [1 ... 100]
                    if (number >= 1 && number <= 100)
                    {
                        // If the number is within the range, print it and exit the program
                        Console.WriteLine($"{number}");
                        break; // Exit the loop and stop the program
                    }
                   
                }
                
            }
        }
    }
}
