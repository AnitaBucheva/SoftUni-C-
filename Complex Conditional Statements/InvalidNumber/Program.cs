using System;

class Program
{
    static void Main()
    {
        // Read an integer from the console
        int number = int.Parse(Console.ReadLine());

        // Check if the number is valid
        if ((number < 100 || number > 200) && number != 0)
        {
            Console.WriteLine("invalid");
        }
    }
}
