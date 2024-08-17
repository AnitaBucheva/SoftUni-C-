using System;

namespace ReadOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           
            while (number % 2 == 0)
            {
                number = int.Parse(Console.ReadLine());
            }

            // Print the odd number
            Console.WriteLine($"{number}");
        }
    }
}
