using System;

class Program
{
    static void Main()
    {
        // Define drink and extra prices
        const double CoffeePrice = 1.00;
        const double TeaPrice = 0.60;
        const double SugarPrice = 0.40;

        // Read drink name and extra from the console
        string drinkName = Console.ReadLine().ToLower();
        string extra = Console.ReadLine().ToLower();

        // Calculate total price based on drink and extra
        double totalPrice;
        if (drinkName == "coffee")
        {
            totalPrice = CoffeePrice;
            if (extra == "sugar")
            {
                totalPrice += SugarPrice;
            }
        }
        else if (drinkName == "tea")
        {
            totalPrice = TeaPrice;
            if (extra == "sugar")
            {
                totalPrice += SugarPrice;
            }
        }
        else
        {
            Console.WriteLine("Invalid drink name!");
            return;
        }

        // Print the final price formatted to the 2nd decimal place
        Console.WriteLine($"Final price: ${totalPrice:F2}");
    }
}
