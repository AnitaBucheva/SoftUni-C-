
using System;

class Program
{
    static void Main()
    {
        // Read three integer numbers from the console
      
        int num1 = int.Parse(Console.ReadLine());
     
        int num2 = int.Parse(Console.ReadLine());

        int num3 = int.Parse(Console.ReadLine());

        // Find the largest number
        int largest = Math.Max(num1, Math.Max(num2, num3));

        // Print the largest number
        Console.WriteLine(largest);
    }
}
